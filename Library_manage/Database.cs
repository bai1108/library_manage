using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_manage
{
    // 一个连接帮助类，所有输入均通过参数传给 SQL Server。
    public static class Database
    {
        private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                if (connectionString != null) return connectionString;
                System.Configuration.ConnectionStringSettings setting = System.Configuration.ConfigurationManager.ConnectionStrings["LibraryDb"];
                if (setting == null || string.IsNullOrWhiteSpace(setting.ConnectionString))
                    throw new InvalidOperationException("未找到 LibraryDb 数据库连接配置，请检查程序旁的配置文件。");
                return setting.ConnectionString;
            }
            set { connectionString = value; }
        }
        public static int AdminID;
        public static string AdminRole;
        public static int MaxBooks=5, LoanDays=30, RenewLimit=1, RenewDays=30;
        private static string SettingsPath { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Library_manage","rules.xml"); } }
        public static void LoadRules()
        {
            if (!File.Exists(SettingsPath)) return;
            XElement x=XElement.Load(SettingsPath);
            MaxBooks=Rule(x,"MaxBooks",5,1); LoanDays=Rule(x,"LoanDays",30,1);
            RenewLimit=Rule(x,"RenewLimit",1,0); RenewDays=Rule(x,"RenewDays",30,1);
        }
        private static int Rule(XElement x,string name,int fallback,int min) { int n; return int.TryParse((string)x.Element(name),out n) && n>=min && n<=3650 ? n : fallback; }
        public static void SaveRules(int max,int days,int limit,int renew)
        {
            RequireAdmin(true);
            if(max<1 || days<1 || limit<0 || renew<1) throw new Exception("请填写有效的借阅参数。");
            Directory.CreateDirectory(Path.GetDirectoryName(SettingsPath));
            new XElement("Rules",new XElement("MaxBooks",max),new XElement("LoanDays",days),new XElement("RenewLimit",limit),new XElement("RenewDays",renew)).Save(SettingsPath);
            MaxBooks=max; LoanDays=days; RenewLimit=limit; RenewDays=renew;
        }
        public static SqlParameter P(string name,object value) { return new SqlParameter(name,value ?? DBNull.Value); }
        public static SqlConnection Open()
        {
            SqlConnection c=new SqlConnection(ConnectionString);
            try { c.Open(); using(SqlCommand q=c.CreateCommand()) { q.CommandText="SET ANSI_NULLS ON; SET QUOTED_IDENTIFIER ON; SET ANSI_PADDING ON; SET ANSI_WARNINGS ON; SET ARITHABORT ON; SET CONCAT_NULL_YIELDS_NULL ON; SET NUMERIC_ROUNDABORT OFF;";q.ExecuteNonQuery(); } return c; }
            catch { c.Dispose(); throw; }
        }
        public static DataTable Query(string sql,params SqlParameter[] values)
        {
            using(SqlConnection c=Open()) return Query(c,null,sql,values);
        }
        public static DataTable Query(SqlConnection c,SqlTransaction t,string sql,params SqlParameter[] values)
        {
            using(SqlCommand q=new SqlCommand(sql,c,t)) { q.Parameters.AddRange(values);using(SqlDataAdapter a=new SqlDataAdapter(q)) { DataTable d=new DataTable();a.Fill(d);return d; } }
        }
        public static int Execute(SqlConnection c,SqlTransaction t,string sql,params SqlParameter[] values)
        {
            using(SqlCommand q=new SqlCommand(sql,c,t)) { q.Parameters.AddRange(values);return q.ExecuteNonQuery(); }
        }
        public static void RequireAdmin(bool system=false)
        {
            DataTable a=Query("SELECT Role FROM dbo.Admin WHERE AdminID=@id AND Status=N'正常'",P("@id",AdminID));
            if(a.Rows.Count==0 || (system && a.Rows[0][0].ToString()!="系统管理员")) throw new Exception("当前账户没有此项操作权限，请重新登录或联系系统管理员。");
        }
        public static void Log(SqlConnection c,SqlTransaction t,string type,string entity,object id,string reader,string before=null,string after=null)
        {
            Execute(c,t,"INSERT dbo.OperationLog(AdminID,ReaderID,BusinessType,EntityName,EntityID,BeforeValue,AfterValue) VALUES(@a,@r,@b,@e,@id,@old,@new)",P("@a",AdminID==0?(object)null:AdminID),P("@r",reader),P("@b",type),P("@e",entity),P("@id",Convert.ToString(id)),P("@old",before),P("@new",after));
        }
        public static void Write(string type,string entity,object id,string sql,params SqlParameter[] values)
        {
            RequireAdmin();
            using(SqlConnection c=Open()) using(SqlTransaction t=c.BeginTransaction(IsolationLevel.Serializable))
            { try { if(id is int && (int)id==0 && (entity=="Book" || entity=="BookCopy")) id=Query(c,t,sql+";SELECT SCOPE_IDENTITY();",values).Rows[0][0];else if(Execute(c,t,sql,values)==0) throw new Exception("记录已被修改或不存在，请刷新后重试。");Log(c,t,type,entity,id,null);t.Commit(); } catch {t.Rollback();throw;} }
        }
        public static byte[] Hash(string password,byte[] salt,int rounds)
        { using(Rfc2898DeriveBytes k=new Rfc2898DeriveBytes(password,salt,rounds)) return k.GetBytes(32); }
        public static bool Same(byte[] a,byte[] b) { int diff=a.Length^b.Length; for(int i=0;i<Math.Min(a.Length,b.Length);i++) diff|=a[i]^b[i];return diff==0; }
        public static void Login(string login,string password)
        {
            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrEmpty(password)) throw new Exception("请输入账号和密码。");
            DataTable d=Query("SELECT * FROM dbo.Admin WHERE LoginName=@n AND Status=N'正常'",P("@n",login));
            if(d.Rows.Count!=1) throw new Exception("账号、密码不正确或账户已停用。");
            DataRow r=d.Rows[0];
            if(r["PasswordAlgorithm"].ToString()!="PBKDF2-SHA1" || !Same((byte[])r["PasswordHash"],Hash(password,(byte[])r["PasswordSalt"],Convert.ToInt32(r["PasswordIterations"])))) throw new Exception("账号、密码不正确或账户已停用。");
            AdminID=Convert.ToInt32(r["AdminID"]);AdminRole=r["Role"].ToString();
        }
        public static int InsertAdmin(SqlConnection c,SqlTransaction t,int id,string login,string name,string password,string role)
        {
            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(name)) throw new Exception("账号和姓名不能为空。");
            if(role!="系统管理员" && role!="业务管理员") throw new Exception("角色只能是系统管理员或业务管理员。");
            if(id==0 || password.Length>0)
            {
                if(password.Length<6) throw new Exception("密码至少6位。");
                byte[] salt=new byte[32];using(RandomNumberGenerator rng=RandomNumberGenerator.Create())rng.GetBytes(salt);
                Execute(c,t,id==0?"INSERT dbo.Admin(LoginName,DisplayName,PasswordHash,PasswordSalt,PasswordAlgorithm,PasswordIterations,Role) VALUES(@l,@n,@h,@s,N'PBKDF2-SHA1',100000,@r)":"UPDATE dbo.Admin SET LoginName=@l,DisplayName=@n,PasswordHash=@h,PasswordSalt=@s,PasswordAlgorithm=N'PBKDF2-SHA1',PasswordIterations=100000,Role=@r WHERE AdminID=@id",P("@l",login.Trim()),P("@n",name.Trim()),P("@h",Hash(password,salt,100000)),P("@s",salt),P("@r",role),P("@id",id));
            }
            else Execute(c,t,"UPDATE dbo.Admin SET LoginName=@l,DisplayName=@n,Role=@r WHERE AdminID=@id",P("@l",login.Trim()),P("@n",name.Trim()),P("@r",role),P("@id",id));
            return Convert.ToInt32(Query(c,t,"SELECT AdminID FROM dbo.Admin WHERE LoginName=@l",P("@l",login.Trim())).Rows[0][0]);
        }
        public static void SaveAdmin(int id,string login,string name,string password,string role)
        {
            RequireAdmin(true);
            if(id==AdminID && role!="系统管理员") throw new Exception("不能取消当前账户的系统管理员权限。");
            using(SqlConnection c=Open()) using(SqlTransaction t=c.BeginTransaction()) {try {id=InsertAdmin(c,t,id,login,name,password,role);Log(c,t,"账户维护","Admin",id,null);t.Commit();}catch{t.Rollback();throw;}}
        }
        public static void Circulate(string reader,string barcode,string action)
        {
            RequireAdmin(); // 现阶段由管理员核验读者身份后办理。
            using(SqlConnection c=Open()) using(SqlTransaction t=c.BeginTransaction(IsolationLevel.Serializable))
            {
                try {
                    DataTable rd=Query(c,t,"SELECT * FROM dbo.Reader WITH(UPDLOCK,HOLDLOCK) WHERE ReaderID=@r",P("@r",reader));
                    if(rd.Rows.Count==0) throw new Exception("读者不存在。");
                    DataTable cp=Query(c,t,"SELECT * FROM dbo.BookCopy WITH(UPDLOCK,HOLDLOCK) WHERE Barcode=@b",P("@b",barcode));
                    if(cp.Rows.Count==0) throw new Exception("未找到复本条码。");
                    int copy=Convert.ToInt32(cp.Rows[0]["CopyID"]);DateTime now=Convert.ToDateTime(Query(c,t,"SELECT SYSDATETIME()").Rows[0][0]);
                    DataTable loan=Query(c,t,"SELECT * FROM dbo.BorrowRecord WITH(UPDLOCK,HOLDLOCK) WHERE CopyID=@c AND ReturnDate IS NULL AND ClosedAt IS NULL",P("@c",copy));
                    if(action!="还书")
                    {
                        if(rd.Rows[0]["Status"].ToString()!="正常" || (rd.Rows[0]["ExpireDate"]!=DBNull.Value && Convert.ToDateTime(rd.Rows[0]["ExpireDate"]).Date<now.Date)) throw new Exception("读者档案已停用、注销或过期。");
                        if(Convert.ToInt32(Query(c,t,"SELECT COUNT(*) FROM dbo.BorrowRecord WHERE ReaderID=@r AND ReturnDate IS NULL AND ClosedAt IS NULL AND (DueDate<@now OR Status=N'遗失待处理')",P("@r",reader),P("@now",now)).Rows[0][0])>0) throw new Exception("存在逾期或未处理遗失记录，请先处理。");
                    }
                    object record;string before=null,after=null;
                    if(action=="借书")
                    {
                        if(cp.Rows[0]["Status"].ToString()!="可借" || loan.Rows.Count>0) throw new Exception("此复本当前不可借。");
                        if(Convert.ToInt32(Query(c,t,"SELECT COUNT(*) FROM dbo.BorrowRecord WHERE ReaderID=@r AND ClosedAt IS NULL",P("@r",reader)).Rows[0][0])>=MaxBooks) throw new Exception("已达到借阅上限。");
                        DateTime due=now.AddDays(LoanDays);
                        record=Query(c,t,"INSERT dbo.BorrowRecord(ReaderID,CopyID,BorrowDate,OriginalDueDate,DueDate,BorrowAdminID) VALUES(@r,@c,@now,@due,@due,@a);SELECT SCOPE_IDENTITY();",P("@r",reader),P("@c",copy),P("@now",now),P("@due",due),P("@a",AdminID)).Rows[0][0];
                        Execute(c,t,"UPDATE dbo.BookCopy SET Status=N'在借' WHERE CopyID=@c",P("@c",copy));after=due.ToString("o");
                    }
                    else
                    {
                        if(loan.Rows.Count==0 || loan.Rows[0]["ReaderID"].ToString()!=reader) throw new Exception("此复本不在该读者的借阅清单中。");
                        DataRow l=loan.Rows[0];record=l["BorrowID"];
                        if(l["Status"].ToString()!="借出") throw new Exception("此笔为遗失待处理记录，需先人工处理。");
                        before=Convert.ToDateTime(l["DueDate"]).ToString("o");
                        if(action=="还书")
                        {
                            Execute(c,t,"UPDATE dbo.BorrowRecord SET Status=N'已归还',ReturnDate=@now,ClosedAt=@now,ReturnAdminID=@a WHERE BorrowID=@id",P("@now",now),P("@a",AdminID),P("@id",record));
                            Execute(c,t,"UPDATE dbo.BookCopy SET Status=N'可借' WHERE CopyID=@c",P("@c",copy));
                        }
                        else if(action=="续借")
                        {
                            if(Convert.ToInt32(l["RenewCount"])>=RenewLimit) throw new Exception("已达到续借次数上限。");
                            DateTime due=Convert.ToDateTime(l["DueDate"]).AddDays(RenewDays);after=due.ToString("o");
                            Execute(c,t,"UPDATE dbo.BorrowRecord SET RenewCount=RenewCount+1,LastRenewAt=@now,DueDate=@due WHERE BorrowID=@id",P("@now",now),P("@due",due),P("@id",record));
                        }
                        else throw new Exception("业务类型无效。");
                    }
                    Log(c,t,action,"BorrowRecord",record,reader,before,after);t.Commit();
                } catch {t.Rollback();throw;}
            }
        }
    }
    public static class ScreenData
    {
        public static bool IsDesignMode(Control control)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return true;
            for (Control current = control; current != null; current = current.Parent)
                if (current.Site != null && current.Site.DesignMode) return true;
            return false;
        }
        public static void Run(Action action) { try {action();} catch(SqlException e) { MessageBox.Show(e.Number==2601||e.Number==2627?"编号、条码或账号重复，请检查。":e.Number==547?"记录被其他数据引用或状态不符合要求。":"数据库操作未完成，请检查 SQL Server 连接。\n"+e.Message,"提示"); } catch(Exception e) { MessageBox.Show(e.Message,"提示"); } }
        public static void Bind(DataGridView g,DataTable d,params string[] fields)
        {
            g.AutoGenerateColumns=false;g.MultiSelect=false;g.ReadOnly=true;
            for(int i=0;i<g.Columns.Count && i<fields.Length;i++)g.Columns[i].DataPropertyName=fields[i];
            g.DataSource=d;
        }
        public static DataRow Row(DataGridView g) { DataRowView r=g.CurrentRow==null?null:g.CurrentRow.DataBoundItem as DataRowView;return r==null?null:r.Row; }
        public static DataRow Need(DataGridView g) {DataRow r=Row(g);if(r==null)throw new Exception("请先选择一条记录。");return r;}
        public static string Required(TextBox t,string label) { string s=t.Text.Trim();if(s.Length==0)throw new Exception("请填写"+label+"。");return s; }
    }
}
