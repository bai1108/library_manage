using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage
{
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this)) InitializeData();
            
        }

        private bool movingWindow;
        private System.Drawing.Point moveStart;
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e) { if(e.Button == MouseButtons.Left) { movingWindow = true; moveStart = e.Location; titlePanel.Capture = true; } }
        private void TitlePanel_MouseMove(object sender, MouseEventArgs e) { if(movingWindow) Location = new System.Drawing.Point(Location.X + e.X - moveStart.X, Location.Y + e.Y - moveStart.Y); }
        private void TitlePanel_MouseUp(object sender, MouseEventArgs e) { movingWindow = false; titlePanel.Capture = false; }
        private void MinimizeButton_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void CloseWindowButton_Click(object sender, EventArgs e) { Close(); }

        private void finishReaderButton_Click(object sender, EventArgs e)
        {
            // 关闭借还窗口，读者登录窗口会重新显示。
            this.Close();
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {

        }
        private string currentReader;
        public BorrowForm(string reader) : this() {currentReader=reader;}
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            resultLabel.Text="请由管理员核验读者身份后办理。";
            Load+=delegate {if(!ScreenData.IsDesignMode(this))ScreenData.Run(RefreshLoan);};
            searchBookButton.Click+=delegate {ScreenData.Run(FindCopy);};
            borrowButton.Click+=delegate {ProcessLoan("借书");};
            returnButton.Click+=delegate {ProcessLoan("还书");};
            renewButton.Click+=delegate {ProcessLoan("续借");};
            loanGrid.SelectionChanged+=delegate {DataRow r=ScreenData.Row(loanGrid);if(r!=null)barcodeTextBox.Text=r["Barcode"].ToString();};
        }
        private void RefreshLoan()
        {
            Database.RequireAdmin();
            DataTable d=Database.Query("SELECT * FROM dbo.Reader WHERE ReaderID=@r",Database.P("@r",currentReader));
            if(d.Rows.Count==0)throw new Exception("请从读者管理选择有效读者。");
            DataRow r=d.Rows[0];readerName.Text=r["ReaderName"].ToString();readerId.Text="读者编号  "+currentReader;
            readerValue0.Text=r["ClassOrDepartment"].ToString();readerValue1.Text=r["Status"].ToString();
            d=Database.Query("SELECT b.BorrowID,c.Barcode,k.BookName,b.BorrowDate,b.DueDate,b.RenewCount,CASE WHEN b.Status=N'借出' AND b.DueDate<SYSDATETIME() THEN N'逾期' ELSE b.Status END AS Status FROM dbo.BorrowRecord b JOIN dbo.BookCopy c ON b.CopyID=c.CopyID JOIN dbo.Book k ON c.BookID=k.BookID WHERE b.ReaderID=@r AND b.ClosedAt IS NULL ORDER BY b.BorrowDate DESC",Database.P("@r",currentReader));
            ScreenData.Bind(loanGrid,d,"Barcode","BookName","BorrowDate","DueDate","RenewCount","Status");readerValue2.Text=d.Rows.Count.ToString();
            readerValue3.Text=d.Select("Status='逾期'").Length.ToString();
        }
        private void FindCopy()
        {
            DataTable d=Database.Query("SELECT b.BookName,b.Author,c.Status FROM dbo.BookCopy c JOIN dbo.Book b ON b.BookID=c.BookID WHERE c.Barcode=@b",Database.P("@b",ScreenData.Required(barcodeTextBox,"复本条码")));
            if(d.Rows.Count==0){bookInformation.Text="未找到此复本。";return;}
            DataRow r=d.Rows[0];bookInformation.Text="书名："+r[0]+"    作者："+r[1]+"    馆藏状态："+r[2];
        }
        private void ProcessLoan(string action)
        {
            resultLabel.Text="等待完成"+action+"。";
            ScreenData.Run(delegate {string barcode=ScreenData.Required(barcodeTextBox,"复本条码");Database.Circulate(currentReader,barcode,action);resultLabel.Text=action+"成功，记录已保存。";RefreshLoan();barcodeTextBox.Text=barcode;FindCopy();});
        }
    }
}
