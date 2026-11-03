using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage.Views
{
    public partial class IrisRegistrationView : UserControl
    {
        public IrisRegistrationView()
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
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshRegistration);};
            findReaderButton.Click+=delegate {ScreenData.Run(RefreshRegistration);};
            registerReadersGrid.SelectionChanged+=delegate {DataRow r=ScreenData.Row(registerReadersGrid);if(r!=null){selectedReader.Text="当前读者："+r["ReaderName"];selectedReaderId.Text="读者编号："+r["ReaderID"];registrationState.Text="注册状态："+r["IrisState"];}};
            connectDeviceButton.Click+=delegate {MissingSDK();};startRegistrationButton.Click+=delegate {MissingSDK();};recaptureButton.Click+=delegate {MissingSDK();};
        }
        private void MissingSDK() {MessageBox.Show("读者与虹膜注册状态已连接数据库。\n尚未提供虹膜设备 SDK，不能采集、匹配或保存虚构模板。","虹膜设备");}
        private void RefreshRegistration()
        {
            Database.RequireAdmin();DataTable d=Database.Query("SELECT r.ReaderID,r.ReaderName,CASE WHEN EXISTS(SELECT 1 FROM dbo.IrisTemplate i WHERE i.ReaderID=r.ReaderID AND i.IsActive=1) THEN N'已注册' ELSE N'未注册' END AS IrisState FROM dbo.Reader r WHERE r.ReaderID LIKE @q OR r.ReaderName LIKE @q ORDER BY r.ReaderID",Database.P("@q","%"+findReaderTextBox.Text.Trim()+"%"));ScreenData.Bind(registerReadersGrid,d,"ReaderID","ReaderName","IrisState");registerReaderCount.Text=d.Rows.Count+" 条记录";
        }
        public void SelectReader(string reader) {findReaderTextBox.Text=reader;ScreenData.Run(delegate {RefreshRegistration();foreach(DataGridViewRow row in registerReadersGrid.Rows){DataRowView r=row.DataBoundItem as DataRowView;if(r!=null && r["ReaderID"].ToString()==reader){registerReadersGrid.CurrentCell=row.Cells[0];row.Selected=true;break;}}});}
    }
}
