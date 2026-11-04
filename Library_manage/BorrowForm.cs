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
        public BorrowForm(string reader,string barcode) : this(reader) {barcodeTextBox.Text=barcode;}
        private string exceptionSummary="";
        private bool readerCanBorrow;
        private string queriedBarcode,queriedCopyState;
        private System.Windows.Forms.Timer loanRefreshTimer;
        private void InitializeData()
        {
            if(ScreenData.IsDesignMode(this))return;
            resultLabel.Text="已核验身份，请输入复本条码。";
            reportLostButton.Visible=Database.AdminID>0;resolveLostButton.Visible=Database.AdminID>0;
            FormClosed+=delegate {if(loanRefreshTimer!=null)loanRefreshTimer.Dispose();IrisService.EndSession();};
            Load+=delegate {if(!ScreenData.IsDesignMode(this))ScreenData.Run(delegate {RefreshLoan();ShowLoanMessage(exceptionSummary);});};
            searchBookButton.Click+=delegate {ScreenData.Run(delegate {RefreshLoan();FindCopy();});};
            borrowButton.Click+=delegate {ProcessLoan("借书");};returnButton.Click+=delegate {ProcessLoan("还书");};renewButton.Click+=delegate {ProcessLoan("续借");};
            reportLostButton.Click+=delegate {HandleException(false);};resolveLostButton.Click+=delegate {HandleException(true);};
            barcodeTextBox.TextChanged+=delegate {queriedBarcode=null;queriedCopyState=null;bookInformation.Text="书名：—     作者：—     馆藏状态：—";UpdateActionState();};
            loanGrid.SelectionChanged+=delegate {DataRow row=ScreenData.Row(loanGrid);if(row!=null)barcodeTextBox.Text=row["Barcode"].ToString();UpdateActionState();};
            loanRefreshTimer=new System.Windows.Forms.Timer();loanRefreshTimer.Interval=60000;
            loanRefreshTimer.Tick+=delegate {try{if(Visible)RefreshLoan();}catch(Exception ex){DisableLoanActions();ShowLoanMessage("刷新失败："+ex.Message);}};
            loanRefreshTimer.Start();
        }
        private void RefreshLoan()
        {
            try{IrisService.AuthorizeReader(currentReader);}catch(SqlException){DisableLoanActions();throw;}catch{DisableLoanActions();loanGrid.DataSource=null;readerName.Text="身份已失效";readerId.Text="请重新核验或识别";readerValue0.Text="—";readerValue1.Text="—";readerValue2.Text="—";readerValue3.Text="—";bookInformation.Text="请结束本次服务并重新核验身份。";throw;}
            string barcode=barcodeTextBox.Text;
            DataTable readers=Database.Query("SELECT *,CONVERT(date,GETDATE()) AS Today FROM dbo.Reader WHERE ReaderID=@r",Database.P("@r",currentReader));
            if(readers.Rows.Count==0)throw new Exception("读者档案不存在。");DataRow reader=readers.Rows[0];
            readerName.Text=reader["ReaderName"].ToString();readerId.Text="读者编号  "+currentReader;readerValue0.Text=reader["ClassOrDepartment"].ToString();readerValue1.Text=reader["Status"].ToString();
            readerCanBorrow=reader["Status"].ToString()=="正常" && (reader["ExpireDate"]==DBNull.Value || Convert.ToDateTime(reader["ExpireDate"]).Date>=Convert.ToDateTime(reader["Today"]).Date);
            DataTable loans=LoanExceptions.CurrentLoans(currentReader);ScreenData.Bind(loanGrid,loans,"Barcode","BookName","BorrowDate","DueDate","RenewCount","Status");
            int overdue=loans.Select("Status='超期'").Length,lost=loans.Select("BaseStatus='遗失待处理'").Length;
            readerField3.Text="超期数量";readerValue2.Text=loans.Rows.Count.ToString();readerValue3.Text=overdue.ToString();readerValue3.ForeColor=overdue>0?Color.Firebrick:Color.FromArgb(43,52,48);
            exceptionSummary=(overdue>0 || lost>0)?"超期 "+overdue+" 册，遗失待处理 "+lost+" 册；暂停借书和续借，请先归还超期图书，遗失请联系管理员。":readerCanBorrow?"当前无超期或遗失待处理记录。":"读者档案已停用、注销或过期；仅可办理归还。";
            loanListTitle.Text="当前借阅（超期 "+overdue+" / 遗失待处理 "+lost+"）";
            foreach(DataGridViewRow gridRow in loanGrid.Rows)
            {
                DataRowView item=gridRow.DataBoundItem as DataRowView;if(item==null)continue;
                string status=item["Status"].ToString();
                if(status=="超期") {gridRow.DefaultCellStyle.BackColor=Color.MistyRose;gridRow.DefaultCellStyle.ForeColor=Color.Firebrick;gridRow.DefaultCellStyle.SelectionBackColor=Color.MistyRose;gridRow.DefaultCellStyle.SelectionForeColor=Color.Firebrick;}
                else if(status=="遗失待处理") {gridRow.DefaultCellStyle.BackColor=Color.LemonChiffon;gridRow.DefaultCellStyle.ForeColor=Color.SaddleBrown;gridRow.DefaultCellStyle.SelectionBackColor=Color.LemonChiffon;gridRow.DefaultCellStyle.SelectionForeColor=Color.SaddleBrown;}
                string tip=status=="超期"?"已超期 "+Math.Max(1,Convert.ToInt32(item["OverdueDays"]))+" 天；请尽快归还。":item["ResolutionNote"].ToString();
                foreach(DataGridViewCell cell in gridRow.Cells)cell.ToolTipText=tip;
            }
            if(!string.IsNullOrWhiteSpace(barcode))barcodeTextBox.Text=barcode;
            UpdateActionState();
        }
        private DataRow MatchingLoan()
        {
            DataTable data=loanGrid.DataSource as DataTable;if(data==null)return null;
            foreach(DataRow row in data.Rows)if(row["Barcode"].ToString()==barcodeTextBox.Text.Trim())return row;return null;
        }
        private void UpdateActionState()
        {
            DataTable data=loanGrid.DataSource as DataTable;DataRow row=MatchingLoan();bool blocked=data!=null && (data.Select("Status='超期' OR BaseStatus='遗失待处理'").Length>0);
            borrowButton.Enabled=data!=null && readerCanBorrow && !blocked && data.Rows.Count<Database.MaxBooks && queriedBarcode==barcodeTextBox.Text.Trim() && queriedCopyState=="可借";
            borrowButton.BackColor=borrowButton.Enabled?Color.FromArgb(53,100,82):Color.Gainsboro;
            borrowButton.ForeColor=borrowButton.Enabled?Color.White:Color.DimGray;
            returnButton.Enabled=row!=null && row["BaseStatus"].ToString()=="借出";
            renewButton.Enabled=returnButton.Enabled && readerCanBorrow && !blocked && Convert.ToInt32(row["RenewCount"])<Database.RenewLimit;
            reportLostButton.Enabled=Database.AdminID>0 && returnButton.Enabled;
            resolveLostButton.Enabled=Database.AdminID>0 && row!=null && row["BaseStatus"].ToString()=="遗失待处理";
        }
        private void ShowLoanMessage(string text)
        {
            resultLabel.Text=text;resultLabel.ForeColor=(text.Contains("超期") && !text.Contains("无超期")) || text.Contains("失败") || text.Contains("未完成") || text.Contains("不能") || text.Contains("不存在") || text.Contains("暂停")?Color.Firebrick:Color.FromArgb(53,100,82);
        }
        private void FindCopy()
        {
            IrisService.AuthorizeReader(currentReader);
            DataTable copies=Database.Query("SELECT b.BookName,b.Author,c.Status FROM dbo.BookCopy c JOIN dbo.Book b ON b.BookID=c.BookID WHERE c.Barcode=@b",Database.P("@b",ScreenData.Required(barcodeTextBox,"复本条码")));
            if(copies.Rows.Count==0){bookInformation.Text="未找到此条码，请核对复本条码。";borrowButton.Enabled=false;ShowLoanMessage("条码不存在，未办理任何业务。");return;}
            DataRow copy=copies.Rows[0];queriedBarcode=barcodeTextBox.Text.Trim();queriedCopyState=copy["Status"].ToString();bookInformation.Text="书名："+copy[0]+"    作者："+copy[1]+"    馆藏状态："+copy[2];
            UpdateActionState();if(copy["Status"].ToString()!="可借")borrowButton.Enabled=false;
            DataRow loan=MatchingLoan();
            if(loan!=null && loan["Status"].ToString()=="超期")ShowLoanMessage("该书已超期 "+Math.Max(1,Convert.ToInt32(loan["OverdueDays"]))+" 天，允许归还，不能续借。");
            else if(copy["Status"].ToString()=="遗失")ShowLoanMessage("该复本已登记遗失，请由管理员处理；不能直接借出或普通归还。");
            else if(copy["Status"].ToString()=="停用")ShowLoanMessage("该复本已停用，不能借出。");
            else ShowLoanMessage(exceptionSummary);
        }
        private void DisableLoanActions()
        {
            borrowButton.Enabled=false;renewButton.Enabled=false;returnButton.Enabled=false;reportLostButton.Enabled=false;resolveLostButton.Enabled=false;readerCanBorrow=false;queriedBarcode=null;queriedCopyState=null;
        }
        private void ProcessLoan(string action)
        {
            string barcode=barcodeTextBox.Text.Trim();
            try{Database.Circulate(currentReader,ScreenData.Required(barcodeTextBox,"复本条码"),action);}
            catch(Exception ex){ShowLoanMessage(action+"未完成："+ex.Message);MessageBox.Show(ex.Message,"办理提示");return;}
            try{RefreshLoan();barcodeTextBox.Text=barcode;FindCopy();ShowLoanMessage(action+"成功。 "+exceptionSummary);}
            catch(Exception ex){DisableLoanActions();ShowLoanMessage(action+"已保存，界面刷新失败，请重新查询；不要重复提交。 "+ex.Message);}
        }
        private void HandleException(bool resolve)
        {
            ScreenData.Run(delegate {
                Database.RequireAdmin();DataRow loan=MatchingLoan();if(loan==null)throw new Exception("请先选择该读者的一条当前借阅记录。");
                string barcode=loan["Barcode"].ToString();
                using(LostHandlingDialog dialog=new LostHandlingDialog(resolve,loan["BookName"].ToString(),barcode))
                {
                    if(dialog.ShowDialog(this)!=DialogResult.OK)return;
                    LoanExceptions.HandleLost(currentReader,barcode,dialog.ActionName,dialog.Note);
                    try{RefreshLoan();barcodeTextBox.Text=barcode;FindCopy();ShowLoanMessage(dialog.ActionName+"成功。 "+exceptionSummary);}
                    catch(Exception ex){DisableLoanActions();ShowLoanMessage(dialog.ActionName+"已保存，界面刷新失败，请重新查询。 "+ex.Message);}
                }
            });
        }

    }

    public class LostHandlingDialog : Form
    {
        private ComboBox action=new ComboBox();
        private TextBox note=new TextBox();
        public string ActionName {get {return action.Text;}}
        public string Note {get {return note.Text.Trim();}}
        public LostHandlingDialog(bool resolve,string book,string barcode)
        {
            Text=resolve?"遗失处理":"登记遗失";ClientSize=new Size(520,365);Font=new Font("Microsoft YaHei UI",10);StartPosition=FormStartPosition.CenterParent;FormBorderStyle=FormBorderStyle.FixedDialog;MaximizeBox=false;MinimizeBox=false;
            Controls.Add(new Label{Text=book+"（"+barcode+"）",Location=new Point(20,18),Size=new Size(480,45)});
            action.Location=new Point(20,68);action.Width=480;action.DropDownStyle=ComboBoxStyle.DropDownList;
            action.Items.AddRange(resolve?new object[]{"找回归还","遗失结案"}:new object[]{"登记遗失"});action.SelectedIndex=0;Controls.Add(action);
            Label explanation=new Label{Location=new Point(20,107),Size=new Size(480,45)};Controls.Add(explanation);
            Action update=delegate {explanation.Text=ActionName=="找回归还"?"实物已找回并归还：关闭记录，恢复复本可借。":ActionName=="遗失结案"?"已完成遗失处理：关闭记录，复本仍保留遗失状态。":"登记后暂停该读者借书和续借，请填写遗失原因。";};action.SelectedIndexChanged+=delegate{update();};update();
            Controls.Add(new Label{Text=resolve?"处理结果（必填）":"遗失原因（必填）",Location=new Point(20,155),AutoSize=true});
            note.Location=new Point(20,183);note.Size=new Size(480,105);note.Multiline=true;note.MaxLength=500;note.ScrollBars=ScrollBars.Vertical;Controls.Add(note);
            Button save=new Button{Text="确认保存",Location=new Point(300,313),Size=new Size(95,32)};Button cancel=new Button{Text="取消",Location=new Point(405,313),Size=new Size(95,32),DialogResult=DialogResult.Cancel};Controls.Add(save);Controls.Add(cancel);CancelButton=cancel;
            save.Click+=delegate{if(Note.Length==0){MessageBox.Show("请填写原因或处理结果。");return;}DialogResult=DialogResult.OK;Close();};
        }
    }

}
