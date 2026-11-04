using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Library_manage
{
    public sealed class IrisEnrollment
    {
        public string ReaderID;
        public int CodeLength;
        public readonly Dictionary<string,byte[]> Codes=new Dictionary<string,byte[]>();
        public readonly Dictionary<string,int> Quality=new Dictionary<string,int>();
    }

    public static class IrisService
    {
        public const string TemplateFormat="Irising0338";
        private static string authenticatedReader;
        private static int authenticatedTemplate;
        private static DateTime sessionExpires;

        public static DataTable Templates(bool allReaders=false)
        {
            return Database.Query("SELECT i.TemplateID,i.ReaderID,i.EyeSide,i.TemplateData,r.ReaderName FROM dbo.IrisTemplate i JOIN dbo.Reader r ON r.ReaderID=i.ReaderID WHERE i.IsActive=1 AND i.TemplateFormat=@f AND (@all=1 OR (r.Status=N'正常' AND (r.ExpireDate IS NULL OR r.ExpireDate>=CONVERT(date,GETDATE())))) ORDER BY i.TemplateID",Database.P("@f",TemplateFormat),Database.P("@all",allReaders));
        }
        internal static string BeginSession(int templateID)
        {
            EndSession();
            DataTable d=Database.Query("SELECT i.ReaderID FROM dbo.IrisTemplate i JOIN dbo.Reader r ON r.ReaderID=i.ReaderID WHERE i.TemplateID=@id AND i.IsActive=1 AND i.TemplateFormat=@f AND r.Status=N'正常' AND (r.ExpireDate IS NULL OR r.ExpireDate>=CONVERT(date,GETDATE()))",Database.P("@id",templateID),Database.P("@f",TemplateFormat));
            if(d.Rows.Count!=1)throw new Exception("识别对应的读者或模板已失效，请重新注册或核对档案。");
            authenticatedReader=d.Rows[0][0].ToString();authenticatedTemplate=templateID;sessionExpires=DateTime.UtcNow.AddMinutes(10);
            return authenticatedReader;
        }
        public static void EndSession() {authenticatedReader=null;authenticatedTemplate=0;sessionExpires=DateTime.MinValue;}
        public static void AuthorizeReader(string reader)
        {
            if(Database.AdminID<=0 && (string.IsNullOrEmpty(reader) || reader!=authenticatedReader || DateTime.UtcNow>=sessionExpires)){EndSession();throw new Exception("读者身份未认证或已超时，请返回重新识别。");}
            using(SqlConnection c=Database.Open())AuthorizeReader(reader,c,null);
        }
        internal static void AuthorizeReader(string reader,SqlConnection c,SqlTransaction t)
        {
            if(Database.AdminID>0){Database.RequireAdmin(c,t);return;}
            if(string.IsNullOrEmpty(reader) || reader!=authenticatedReader || DateTime.UtcNow>=sessionExpires){EndSession();throw new Exception("读者身份未认证或已超时，请返回重新识别。");}
            if(t!=null)Database.Query(c,t,"SELECT ReaderID FROM dbo.Reader WITH(UPDLOCK,HOLDLOCK) WHERE ReaderID=@r",Database.P("@r",reader));
            DataTable d=Database.Query(c,t,"SELECT TemplateID FROM dbo.IrisTemplate WITH(HOLDLOCK) WHERE TemplateID=@id AND ReaderID=@r AND IsActive=1 AND TemplateFormat=@f",Database.P("@id",authenticatedTemplate),Database.P("@r",reader),Database.P("@f",TemplateFormat));
            if(d.Rows.Count!=1){EndSession();throw new Exception("虹膜模板已更新或失效，请重新识别。");}
        }
        public static void SaveRegistration(IrisEnrollment result)
        {
            Database.RequireAdmin();
            if(result==null || string.IsNullOrEmpty(result.ReaderID) || result.Codes.Count==0 || result.CodeLength<256 || result.CodeLength>65536)throw new Exception("采集结果不完整，未保存模板。");
            foreach(var pair in result.Codes)
                if((pair.Key!="L" && pair.Key!="R") || pair.Value==null || pair.Value.Length!=result.CodeLength || !result.Quality.ContainsKey(pair.Key) || result.Quality[pair.Key]<60 || result.Quality[pair.Key]>100)throw new Exception("眼别、编码长度或采集质量不符合要求。");
            using(SqlConnection c=Database.Open())using(SqlTransaction t=c.BeginTransaction(IsolationLevel.Serializable))
            {
                try {
                    Database.RequireAdmin(c,t);
                    DataTable r=Database.Query(c,t,"SELECT ReaderID FROM dbo.Reader WITH(UPDLOCK,HOLDLOCK) WHERE ReaderID=@r AND Status=N'正常' AND (ExpireDate IS NULL OR ExpireDate>=CONVERT(date,GETDATE()))",Database.P("@r",result.ReaderID));
                    if(r.Rows.Count!=1)throw new Exception("读者档案无效，不能注册虹膜。");
                    foreach(var pair in result.Codes)
                    {
                        Database.Execute(c,t,"UPDATE dbo.IrisTemplate SET IsActive=0 WHERE ReaderID=@r AND EyeSide=@eye AND IsActive=1; INSERT dbo.IrisTemplate(ReaderID,EyeSide,TemplateData,TemplateFormat,QualityScore,RegisteredBy) VALUES(@r,@eye,@data,@f,@q,@a)",Database.P("@r",result.ReaderID),Database.P("@eye",pair.Key),Database.P("@data",pair.Value),Database.P("@f",TemplateFormat),Database.P("@q",result.Quality[pair.Key]),Database.P("@a",Database.AdminID));
                    }
                    Database.Log(c,t,"虹膜注册","Reader",result.ReaderID,result.ReaderID,null,string.Join(",",result.Codes.Keys));t.Commit();
                }catch{t.Rollback();throw;}
            }
        }
    }
}
