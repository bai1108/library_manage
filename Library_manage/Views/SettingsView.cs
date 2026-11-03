using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace Library_manage.Views
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this))
            {
                InitializeData();
            }
        }
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            serverTextBox.ReadOnly=true;databaseTextBox.ReadOnly=true;
            dbUserTextBox.Text="Windows 身份验证";dbUserTextBox.ReadOnly=true;dbPasswordTextBox.Enabled=false;
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshSettings);};
            testDatabaseButton.Click+=delegate {ScreenData.Run(delegate {using(SqlConnection c=Database.Open()){} MessageBox.Show("已成功连接 BAI / DoorAccess2026。","数据库连接");});};
            testDeviceButton.Click+=delegate {MessageBox.Show("尚未接入设备 SDK，不能测试虹膜采集。","虹膜设备");};
            saveSettingsButton.Click+=delegate {ScreenData.Run(delegate {Database.SaveRules((int)maxBooksNumeric.Value,(int)loanDaysNumeric.Value,(int)renewCountNumeric.Value,(int)renewDaysNumeric.Value);MessageBox.Show("借阅规则已保存，重新启动后仍然有效。","设置");});};
            addAccountButton.Click+=delegate {EditAccount(true);};editAccountButton.Click+=delegate {EditAccount(false);};
            stopAccountButton.Click+=delegate {ScreenData.Run(delegate {Database.RequireAdmin(true);DataRow r=ScreenData.Need(accountsGrid);int id=Convert.ToInt32(r["AdminID"]);if(id==Database.AdminID)throw new Exception("不能停用当前登录账户。");string state=r["Status"].ToString()=="正常"?"停用":"正常";Database.Write("账户状态","Admin",id,"UPDATE dbo.Admin SET Status=@s WHERE AdminID=@id",Database.P("@s",state),Database.P("@id",id));RefreshSettings();});};
            stopAccountButton.Text="停用 / 恢复";
        }
        private void RefreshSettings()
        {
            SqlConnectionStringBuilder b=new SqlConnectionStringBuilder(Database.ConnectionString);
            serverTextBox.Text=b.DataSource;databaseTextBox.Text=b.InitialCatalog;
            Database.RequireAdmin();
            maxBooksNumeric.Maximum=3650;loanDaysNumeric.Maximum=3650;renewCountNumeric.Minimum=0;renewCountNumeric.Maximum=3650;renewDaysNumeric.Maximum=3650;
            maxBooksNumeric.Value=Database.MaxBooks;loanDaysNumeric.Value=Database.LoanDays;renewCountNumeric.Value=Database.RenewLimit;renewDaysNumeric.Value=Database.RenewDays;
            bool system=Database.AdminRole=="系统管理员";saveSettingsButton.Enabled=system;addAccountButton.Enabled=system;editAccountButton.Enabled=system;stopAccountButton.Enabled=system;
            if(system)ScreenData.Bind(accountsGrid,Database.Query("SELECT AdminID,LoginName,DisplayName,Role,Status FROM dbo.Admin ORDER BY AdminID"),"LoginName","Role","Status");
        }
        private void EditAccount(bool create)
        {
            ScreenData.Run(delegate {Database.RequireAdmin(true);DataRow r=create?null:ScreenData.Need(accountsGrid);using(AccountEditor f=new AccountEditor(r)){if(f.ShowDialog()==DialogResult.OK)RefreshSettings();}});
        }
    }
    public class AccountEditor : Form
    {
        private TextBox login=new TextBox(),name=new TextBox(),password=new TextBox();
        private ComboBox role=new ComboBox();
        private int id;
        public AccountEditor(DataRow row)
        {
            Text=row==null?"新增管理员":"修改管理员";Font=new Font("Microsoft YaHei UI",10);ClientSize=new Size(420,310);StartPosition=FormStartPosition.CenterParent;FormBorderStyle=FormBorderStyle.FixedDialog;MaximizeBox=false;MinimizeBox=false;BackColor=Color.FromArgb(248,249,245);
            string[] labels={"登录名","姓名","密码","角色"};Control[] fields={login,name,password,role};
            for(int i=0;i<4;i++){Controls.Add(new Label{Text=labels[i],Location=new Point(24,28+i*50),AutoSize=true});fields[i].Location=new Point(105,24+i*50);fields[i].Width=280;Controls.Add(fields[i]);}
            login.MaxLength=50;name.MaxLength=50;password.UseSystemPasswordChar=true;role.DropDownStyle=ComboBoxStyle.DropDownList;role.Items.AddRange(new object[]{"业务管理员","系统管理员"});role.SelectedIndex=0;
            Controls.Add(new Label{Text="密码至少6位；修改时留空表示保留原密码。",Location=new Point(24,225),AutoSize=true});
            Button save=new Button{Text="保存",Location=new Point(230,263),Size=new Size(75,30)};Button cancel=new Button{Text="取消",Location=new Point(315,263),Size=new Size(75,30),DialogResult=DialogResult.Cancel};Controls.Add(save);Controls.Add(cancel);AcceptButton=save;CancelButton=cancel;
            if(row!=null){id=Convert.ToInt32(row["AdminID"]);login.Text=row["LoginName"].ToString();name.Text=row["DisplayName"].ToString();role.Text=row["Role"].ToString();}
            save.Click+=delegate {ScreenData.Run(delegate {Database.SaveAdmin(id,login.Text,name.Text,password.Text,role.Text);password.Clear();DialogResult=DialogResult.OK;Close();});};
        }
    }
}
