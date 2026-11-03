using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage.Views
{
    public partial class StatisticsView : UserControl
    {
        public StatisticsView()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this))
            {
                InitializeData();
            }
        }
        private DataTable statistics;
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            startDatePicker.Value=DateTime.Today.AddDays(-30);endDatePicker.Value=DateTime.Today;
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshStatistics);};
            searchStatisticsButton.Click+=delegate {ScreenData.Run(RefreshStatistics);};exportStatisticsButton.Click+=delegate {ScreenData.Run(ExportStatistics);};
        }
        private void RefreshStatistics()
        {
            Database.RequireAdmin();if(startDatePicker.Value.Date>endDatePicker.Value.Date)throw new Exception("开始日期不能晚于结束日期。");
            statistics=Database.Query("SELECT r.ReaderID,r.ReaderName,c.Barcode,b.BookName,CASE l.BusinessType WHEN N'借书' THEN N'借阅' WHEN N'还书' THEN N'归还' ELSE l.BusinessType END AS EventType,l.OperationTime,CASE WHEN l.BusinessType IN(N'借书',N'续借') THEN TRY_CONVERT(datetime2,l.AfterValue) ELSE br.DueDate END AS DueDate,br.Status FROM dbo.OperationLog l JOIN dbo.BorrowRecord br ON l.EntityName=N'BorrowRecord' AND TRY_CONVERT(bigint,l.EntityID)=br.BorrowID JOIN dbo.Reader r ON br.ReaderID=r.ReaderID JOIN dbo.BookCopy c ON br.CopyID=c.CopyID JOIN dbo.Book b ON c.BookID=b.BookID WHERE l.Result=N'成功' AND l.BusinessType IN(N'借书',N'还书',N'续借',N'遗失') AND l.OperationTime>=@s AND l.OperationTime<@e AND (@r=N'' OR r.ReaderID=@r) AND (b.BookName LIKE @b OR ISNULL(b.Author,N'') LIKE @b) ORDER BY l.OperationTime DESC,l.LogID DESC",Database.P("@s",startDatePicker.Value.Date),Database.P("@e",endDatePicker.Value.Date.AddDays(1)),Database.P("@r",statReaderId.Text.Trim()),Database.P("@b","%"+statBookTextBox.Text.Trim()+"%"));
            metricValue0.Text=statistics.Select("EventType='借阅'").Length.ToString();metricValue1.Text=statistics.Select("EventType='归还'").Length.ToString();metricValue2.Text=statistics.Select("EventType='续借'").Length.ToString();
            metricValue3.Text=Database.Query("SELECT COUNT(*) FROM dbo.BorrowRecord br JOIN dbo.BookCopy c ON br.CopyID=c.CopyID JOIN dbo.Book b ON c.BookID=b.BookID WHERE br.ClosedAt IS NULL AND br.DueDate<SYSDATETIME() AND (@r=N'' OR br.ReaderID=@r) AND (b.BookName LIKE @b OR ISNULL(b.Author,N'') LIKE @b)",Database.P("@r",statReaderId.Text.Trim()),Database.P("@b","%"+statBookTextBox.Text.Trim()+"%")).Rows[0][0].ToString();
            DataView view=statistics.DefaultView;view.RowFilter=statTypeCombo.Text=="全部" || statTypeCombo.Text==""?"":"EventType='"+statTypeCombo.Text.Replace("'","''")+"'";ScreenData.Bind(statisticsGrid,view.ToTable(),"ReaderID","ReaderName","Barcode","BookName","EventType","OperationTime","DueDate","Status");statisticsCount.Text=view.Count+" 条记录";
        }
        private void ExportStatistics()
        {
            Database.RequireAdmin();RefreshStatistics();using(SaveFileDialog f=new SaveFileDialog()){f.Filter="CSV文件|*.csv";f.FileName="借阅查询.csv";if(f.ShowDialog()!=DialogResult.OK)return;DataTable d=(DataTable)statisticsGrid.DataSource;using(StreamWriter w=new StreamWriter(f.FileName,false,new UTF8Encoding(true))){string[] headers=new string[statisticsGrid.Columns.Count];for(int i=0;i<headers.Length;i++)headers[i]=Csv(statisticsGrid.Columns[i].HeaderText);w.WriteLine(string.Join(",",headers));foreach(DataRow r in d.Rows){string[] cells=new string[d.Columns.Count];for(int i=0;i<cells.Length;i++)cells[i]=Csv(Convert.ToString(r[i]));w.WriteLine(string.Join(",",cells));}}}
        }
        private static string Csv(string s) {if(s.Length>0 && "=+-@\t\r".IndexOf(s[0])>=0)s="'"+s;return "\""+s.Replace("\"","\"\"")+"\"";}
    }
}
