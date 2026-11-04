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
            handleExceptionButton.Click+=delegate {OpenExceptionReader();};
            statisticsGrid.SelectionChanged+=delegate {UpdateExceptionButton();};
            startDatePicker.Value=DateTime.Today.AddDays(-30);endDatePicker.Value=DateTime.Today;
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshStatistics);};
            searchStatisticsButton.Click+=delegate {ScreenData.Run(RefreshStatistics);};exportStatisticsButton.Click+=delegate {ScreenData.Run(ExportStatistics);};
        }
        private void RefreshStatistics()
        {
            Database.RequireAdmin();
            string type=statTypeCombo.Text;bool current=type=="当前超期" || type=="遗失待处理" || type=="遗失已结案";
            if(!current && startDatePicker.Value.Date>endDatePicker.Value.Date)throw new Exception("开始日期不能晚于结束日期。");
            if(current)
            {
                string condition=type=="当前超期"?"br.Status=N'借出' AND br.ClosedAt IS NULL AND br.DueDate<SYSDATETIME()":type=="遗失待处理"?"br.Status=N'遗失待处理' AND br.ClosedAt IS NULL":"br.Status=N'遗失已结案'";
                statistics=Database.Query("SELECT r.ReaderID,r.ReaderName,c.Barcode,b.BookName,@type AS EventType,COALESCE(br.ClosedAt,br.LostAt,br.BorrowDate) AS OperationTime,br.DueDate,CASE WHEN br.Status=N'借出' AND br.DueDate<SYSDATETIME() THEN N'超期' ELSE br.Status END AS Status,br.ResolutionNote FROM dbo.BorrowRecord br JOIN dbo.Reader r ON br.ReaderID=r.ReaderID JOIN dbo.BookCopy c ON br.CopyID=c.CopyID JOIN dbo.Book b ON c.BookID=b.BookID WHERE "+condition+" AND (@r=N'' OR br.ReaderID=@r) AND (b.BookName LIKE @b OR ISNULL(b.Author,N'') LIKE @b) ORDER BY br.DueDate",Database.P("@type",type),Database.P("@r",statReaderId.Text.Trim()),Database.P("@b","%"+statBookTextBox.Text.Trim()+"%"));
            }
            else
            {
                statistics=Database.Query("SELECT r.ReaderID,r.ReaderName,c.Barcode,b.BookName,CASE l.BusinessType WHEN N'借书' THEN N'借阅' WHEN N'还书' THEN N'归还' ELSE l.BusinessType END AS EventType,l.OperationTime,CASE WHEN l.BusinessType IN(N'借书',N'续借') THEN TRY_CONVERT(datetime2,l.AfterValue) ELSE br.DueDate END AS DueDate,CASE WHEN br.Status=N'借出' AND br.DueDate<SYSDATETIME() THEN N'超期' ELSE br.Status END AS Status,br.ResolutionNote FROM dbo.OperationLog l JOIN dbo.BorrowRecord br ON l.EntityName=N'BorrowRecord' AND TRY_CONVERT(bigint,l.EntityID)=br.BorrowID JOIN dbo.Reader r ON br.ReaderID=r.ReaderID JOIN dbo.BookCopy c ON br.CopyID=c.CopyID JOIN dbo.Book b ON c.BookID=b.BookID WHERE l.Result=N'成功' AND l.BusinessType IN(N'借书',N'还书',N'续借',N'遗失',N'遗失结案',N'找回归还') AND l.OperationTime>=@s AND l.OperationTime<@e AND (@r=N'' OR r.ReaderID=@r) AND (b.BookName LIKE @b OR ISNULL(b.Author,N'') LIKE @b) ORDER BY l.OperationTime DESC,l.LogID DESC",Database.P("@s",startDatePicker.Value.Date),Database.P("@e",endDatePicker.Value.Date.AddDays(1)),Database.P("@r",statReaderId.Text.Trim()),Database.P("@b","%"+statBookTextBox.Text.Trim()+"%"));
            }
            metricValue0.Text=current?"—":statistics.Select("EventType='借阅'").Length.ToString();metricValue1.Text=current?"—":statistics.Select("EventType='归还' OR EventType='找回归还'").Length.ToString();metricValue2.Text=current?"—":statistics.Select("EventType='续借'").Length.ToString();
            metricValue3.Text=Database.Query("SELECT COUNT(*) FROM dbo.BorrowRecord br JOIN dbo.BookCopy c ON br.CopyID=c.CopyID JOIN dbo.Book b ON c.BookID=b.BookID WHERE br.Status=N'借出' AND br.ClosedAt IS NULL AND br.DueDate<SYSDATETIME() AND (@r=N'' OR br.ReaderID=@r) AND (b.BookName LIKE @b OR ISNULL(b.Author,N'') LIKE @b)",Database.P("@r",statReaderId.Text.Trim()),Database.P("@b","%"+statBookTextBox.Text.Trim()+"%")).Rows[0][0].ToString();
            DataView view=statistics.DefaultView;view.RowFilter=current || type=="全部" || type==""?"":"EventType='"+type.Replace("'","''")+"'";
            ScreenData.Bind(statisticsGrid,view.ToTable(),"ReaderID","ReaderName","Barcode","BookName","EventType","OperationTime","DueDate","Status");
            statisticsCount.Text=view.Count+(current?" 条记录；当前状态清单不受日期筛选限制。":" 条记录");
            foreach(DataGridViewRow row in statisticsGrid.Rows)
            {
                DataRowView item=row.DataBoundItem as DataRowView;if(item==null)continue;
                string state=item["Status"].ToString();
                if(state=="超期") {row.DefaultCellStyle.BackColor=Color.MistyRose;row.DefaultCellStyle.ForeColor=Color.Firebrick;row.DefaultCellStyle.SelectionBackColor=Color.MistyRose;row.DefaultCellStyle.SelectionForeColor=Color.Firebrick;}
                else if(state=="遗失待处理") {row.DefaultCellStyle.BackColor=Color.LemonChiffon;row.DefaultCellStyle.ForeColor=Color.SaddleBrown;row.DefaultCellStyle.SelectionBackColor=Color.LemonChiffon;row.DefaultCellStyle.SelectionForeColor=Color.SaddleBrown;}
                foreach(DataGridViewCell cell in row.Cells)cell.ToolTipText=item["ResolutionNote"].ToString();
            }
            UpdateExceptionButton();
        }
        private void UpdateExceptionButton()
        {
            DataRow row=ScreenData.Row(statisticsGrid);string state=row==null?"":row["Status"].ToString();
            handleExceptionButton.Enabled=state=="超期" || state=="遗失待处理" || state=="借出";
        }
        private void OpenExceptionReader()
        {
            ScreenData.Run(delegate {Database.RequireAdmin();DataRow row=ScreenData.Need(statisticsGrid);using(BorrowForm form=new BorrowForm(row["ReaderID"].ToString(),row["Barcode"].ToString()))form.ShowDialog();RefreshStatistics();});
        }

        private void ExportStatistics()
        {
            Database.RequireAdmin();RefreshStatistics();using(SaveFileDialog f=new SaveFileDialog()){f.Filter="CSV文件|*.csv";f.FileName="借阅查询.csv";if(f.ShowDialog()!=DialogResult.OK)return;DataTable d=(DataTable)statisticsGrid.DataSource;using(StreamWriter w=new StreamWriter(f.FileName,false,new UTF8Encoding(true))){string[] headers=new string[statisticsGrid.Columns.Count];for(int i=0;i<headers.Length;i++)headers[i]=Csv(statisticsGrid.Columns[i].HeaderText);w.WriteLine(string.Join(",",headers));foreach(DataRow r in d.Rows){string[] cells=new string[statisticsGrid.Columns.Count];for(int i=0;i<cells.Length;i++)cells[i]=Csv(Convert.ToString(r[statisticsGrid.Columns[i].DataPropertyName]));w.WriteLine(string.Join(",",cells));}}}
        }
        private static string Csv(string s) {string trimmed=s.TrimStart();if((s.Length>0 && "\t\r\n".IndexOf(s[0])>=0) || (trimmed.Length>0 && "=+-@".IndexOf(trimmed[0])>=0))s="'"+s;return "\""+s.Replace("\"","\"\"")+"\"";}
    }
}
