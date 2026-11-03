using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_manage.Views
{
    public partial class ReaderManagementView : UserControl
    {
        public ReaderManagementView()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this))
            {
                InitializeData();
            }
        }

        private void irisRegistrationButton_Click(object sender, EventArgs e)
        {
            ScreenData.Run(delegate { DataRow r=ScreenData.Need(readersGrid); ManageForm f=FindForm() as ManageForm; if(f!=null) f.OpenRegistration(r["ReaderID"].ToString()); });
        }
        private string editReader;
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            saveReaderButton.Enabled=false;readerIdTextBox.MaxLength=20;readerNameTextBox.MaxLength=50;departmentTextBox.MaxLength=100;phoneTextBox.MaxLength=30;
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshReaders);};
            searchButton.Click+=delegate {ScreenData.Run(RefreshReaders);};
            resetButton.Click+=delegate {readerIdFilter.Clear();readerNameFilter.Clear();readerStateFilter.SelectedIndex=0;ScreenData.Run(RefreshReaders);};
            newReaderButton.Click+=delegate {editReader=null;readerIdTextBox.ReadOnly=false;readerIdTextBox.Clear();readerNameTextBox.Clear();departmentTextBox.Clear();phoneTextBox.Clear();readerStateCombo.Text="正常";saveReaderButton.Enabled=true;readerIdTextBox.Focus();};
            editReaderButton.Click+=delegate {ScreenData.Run(delegate {FillReader();editReader=ScreenData.Need(readersGrid)["ReaderID"].ToString();readerIdTextBox.ReadOnly=true;saveReaderButton.Enabled=true;});};
            saveReaderButton.Click+=delegate {ScreenData.Run(SaveReader);};
            cancelReaderButton.Click+=delegate {saveReaderButton.Enabled=false;FillReader();};
            readersGrid.SelectionChanged+=delegate {saveReaderButton.Enabled=false;FillReader();};
            stopReaderButton.Click+=delegate {ScreenData.Run(delegate {DataRow r=ScreenData.Need(readersGrid);string state=r["Status"].ToString()=="停用"?"正常":"停用";Database.Write("读者状态","Reader",r["ReaderID"],"UPDATE dbo.Reader SET Status=@s,UpdatedAt=SYSDATETIME() WHERE ReaderID=@id",Database.P("@s",state),Database.P("@id",r["ReaderID"]));RefreshReaders();});};
            stopReaderButton.Text="停用 / 恢复";
            Button service=new Button();service.Text="核验后借还";service.Size=new Size(135,36);service.FlatStyle=FlatStyle.Flat;service.BackColor=Color.White;service.Location=new Point(irisRegistrationButton.Left-150,irisRegistrationButton.Top);irisRegistrationButton.Parent.Controls.Add(service);
            service.Click+=delegate {ScreenData.Run(delegate {Database.RequireAdmin();DataRow r=ScreenData.Need(readersGrid);if(MessageBox.Show("请核对读者："+r["ReaderName"]+"（"+r["ReaderID"]+"）\n确认身份后办理借还？","核验读者",MessageBoxButtons.OKCancel)!=DialogResult.OK)return;using(BorrowForm f=new BorrowForm(r["ReaderID"].ToString()))f.ShowDialog();RefreshReaders();});};
        }
        private void RefreshReaders()
        {
            Database.RequireAdmin();
            DataTable d=Database.Query("SELECT r.*,CASE WHEN EXISTS(SELECT 1 FROM dbo.IrisTemplate i WHERE i.ReaderID=r.ReaderID AND i.IsActive=1) THEN N'已注册' ELSE N'未注册' END AS IrisState FROM dbo.Reader r WHERE (@id=N'' OR r.ReaderID=@id) AND r.ReaderName LIKE @name AND (@state=N'全部' OR @state=N'' OR r.Status=@state) ORDER BY r.ReaderID",Database.P("@id",readerIdFilter.Text.Trim()),Database.P("@name","%"+readerNameFilter.Text.Trim()+"%"),Database.P("@state",readerStateFilter.Text));
            ScreenData.Bind(readersGrid,d,"ReaderID","ReaderName","ClassOrDepartment","Status","IrisState");recordCount.Text=d.Rows.Count+" 条记录";
        }
        private void FillReader()
        {
            DataRow r=ScreenData.Row(readersGrid);if(r==null)return;
            readerIdTextBox.Text=r["ReaderID"].ToString();readerNameTextBox.Text=r["ReaderName"].ToString();departmentTextBox.Text=r["ClassOrDepartment"].ToString();phoneTextBox.Text=r["Phone"].ToString();readerStateCombo.Text=r["Status"].ToString();
        }
        private void SaveReader()
        {
            string id=ScreenData.Required(readerIdTextBox,"读者编号"),name=ScreenData.Required(readerNameTextBox,"姓名");
            if(readerStateCombo.Text=="注销" && Convert.ToInt32(Database.Query("SELECT COUNT(*) FROM dbo.BorrowRecord WHERE ReaderID=@id AND ClosedAt IS NULL",Database.P("@id",id)).Rows[0][0])>0)throw new Exception("有未结束借阅，不能注销。");
            string sql=editReader==null?"INSERT dbo.Reader(ReaderID,ReaderName,ClassOrDepartment,Phone,Status) VALUES(@id,@n,@d,@p,@s)":"UPDATE dbo.Reader SET ReaderName=@n,ClassOrDepartment=@d,Phone=@p,Status=@s,UpdatedAt=SYSDATETIME() WHERE ReaderID=@id AND (@s<>N'注销' OR NOT EXISTS(SELECT 1 FROM dbo.BorrowRecord WHERE ReaderID=@id AND ClosedAt IS NULL))";
            Database.Write("读者维护","Reader",id,sql,Database.P("@id",id),Database.P("@n",name),Database.P("@d",departmentTextBox.Text.Trim()),Database.P("@p",phoneTextBox.Text.Trim()),Database.P("@s",readerStateCombo.Text));
            saveReaderButton.Enabled=false;RefreshReaders();
        }
    }
}
