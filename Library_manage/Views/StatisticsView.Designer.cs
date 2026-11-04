namespace Library_manage.Views
{
    partial class StatisticsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTitle = new System.Windows.Forms.Label();
            this.startDatePickerCaption = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePickerCaption = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.statReaderCaption = new System.Windows.Forms.Label();
            this.statReaderId = new System.Windows.Forms.TextBox();
            this.statTypeCaption = new System.Windows.Forms.Label();
            this.statTypeCombo = new System.Windows.Forms.ComboBox();
            this.handleExceptionButton = new System.Windows.Forms.Button();
            this.searchStatisticsButton = new System.Windows.Forms.Button();
            this.exportStatisticsButton = new System.Windows.Forms.Button();
            this.statBookCaption = new System.Windows.Forms.Label();
            this.statBookTextBox = new System.Windows.Forms.TextBox();
            this.statisticsSummary = new System.Windows.Forms.Panel();
            this.metricTitle0 = new System.Windows.Forms.Label();
            this.metricValue0 = new System.Windows.Forms.Label();
            this.metricSeparator0 = new System.Windows.Forms.Panel();
            this.metricTitle1 = new System.Windows.Forms.Label();
            this.metricValue1 = new System.Windows.Forms.Label();
            this.metricSeparator1 = new System.Windows.Forms.Panel();
            this.metricTitle2 = new System.Windows.Forms.Label();
            this.metricValue2 = new System.Windows.Forms.Label();
            this.metricSeparator2 = new System.Windows.Forms.Panel();
            this.metricTitle3 = new System.Windows.Forms.Label();
            this.metricValue3 = new System.Windows.Forms.Label();
            this.statListTitle = new System.Windows.Forms.Label();
            this.statisticsGrid = new System.Windows.Forms.DataGridView();
            this.statisticsGridReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsCount = new System.Windows.Forms.Label();
            this.statisticsSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.pageTitle.Location = new System.Drawing.Point(4, 10);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(875, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "借阅查询";
            // 
            // startDatePickerCaption
            // 
            this.startDatePickerCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.startDatePickerCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.startDatePickerCaption.Location = new System.Drawing.Point(0, 72);
            this.startDatePickerCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDatePickerCaption.Name = "startDatePickerCaption";
            this.startDatePickerCaption.Size = new System.Drawing.Size(225, 30);
            this.startDatePickerCaption.TabIndex = 2;
            this.startDatePickerCaption.Text = "开始日期";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(0, 112);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(222, 27);
            this.startDatePicker.TabIndex = 3;
            // 
            // endDatePickerCaption
            // 
            this.endDatePickerCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.endDatePickerCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.endDatePickerCaption.Location = new System.Drawing.Point(249, 72);
            this.endDatePickerCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDatePickerCaption.Name = "endDatePickerCaption";
            this.endDatePickerCaption.Size = new System.Drawing.Size(225, 30);
            this.endDatePickerCaption.TabIndex = 4;
            this.endDatePickerCaption.Text = "结束日期";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(249, 112);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(222, 27);
            this.endDatePicker.TabIndex = 5;
            // 
            // statReaderCaption
            // 
            this.statReaderCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.statReaderCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.statReaderCaption.Location = new System.Drawing.Point(498, 72);
            this.statReaderCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statReaderCaption.Name = "statReaderCaption";
            this.statReaderCaption.Size = new System.Drawing.Size(230, 30);
            this.statReaderCaption.TabIndex = 6;
            this.statReaderCaption.Text = "读者编号";
            // 
            // statReaderId
            // 
            this.statReaderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statReaderId.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.statReaderId.Location = new System.Drawing.Point(498, 112);
            this.statReaderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statReaderId.Name = "statReaderId";
            this.statReaderId.Size = new System.Drawing.Size(212, 31);
            this.statReaderId.TabIndex = 7;
            // 
            // statTypeCaption
            // 
            this.statTypeCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.statTypeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.statTypeCaption.Location = new System.Drawing.Point(739, 72);
            this.statTypeCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statTypeCaption.Name = "statTypeCaption";
            this.statTypeCaption.Size = new System.Drawing.Size(192, 30);
            this.statTypeCaption.TabIndex = 8;
            this.statTypeCaption.Text = "业务类型";
            // 
            // statTypeCombo
            // 
            this.statTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statTypeCombo.Items.AddRange(new object[] { "全部", "借阅", "归还", "续借", "遗失", "找回归还", "遗失结案", "当前超期", "遗失待处理", "遗失已结案" });
            this.statTypeCombo.Location = new System.Drawing.Point(739, 112);
            this.statTypeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statTypeCombo.Name = "statTypeCombo";
            this.statTypeCombo.Size = new System.Drawing.Size(188, 28);
            this.statTypeCombo.TabIndex = 9;
            // 
            // searchStatisticsButton
            // 
            this.searchStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchStatisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchStatisticsButton.FlatAppearance.BorderSize = 0;
            this.searchStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchStatisticsButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.searchStatisticsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchStatisticsButton.Location = new System.Drawing.Point(955, 109);
            this.searchStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchStatisticsButton.Name = "searchStatisticsButton";
            this.searchStatisticsButton.Size = new System.Drawing.Size(152, 50);
            this.searchStatisticsButton.TabIndex = 10;
            this.searchStatisticsButton.Text = "查询";
            this.searchStatisticsButton.UseVisualStyleBackColor = false;
            // 
            // exportStatisticsButton
            // 
            this.exportStatisticsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exportStatisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.exportStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportStatisticsButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.exportStatisticsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.exportStatisticsButton.Location = new System.Drawing.Point(1129, 109);
            this.exportStatisticsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportStatisticsButton.Name = "exportStatisticsButton";
            this.exportStatisticsButton.Size = new System.Drawing.Size(180, 50);
            this.exportStatisticsButton.TabIndex = 11;
            this.exportStatisticsButton.Text = "导出";
            this.exportStatisticsButton.UseVisualStyleBackColor = false;
            // 
            // statBookCaption
            // 
            this.statBookCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.statBookCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.statBookCaption.Location = new System.Drawing.Point(0, 186);
            this.statBookCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statBookCaption.Name = "statBookCaption";
            this.statBookCaption.Size = new System.Drawing.Size(138, 31);
            this.statBookCaption.TabIndex = 12;
            this.statBookCaption.Text = "书名 / 作者";
            // 
            // statBookTextBox
            // 
            this.statBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statBookTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.statBookTextBox.Location = new System.Drawing.Point(141, 179);
            this.statBookTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statBookTextBox.Name = "statBookTextBox";
            this.statBookTextBox.Size = new System.Drawing.Size(786, 31);
            this.statBookTextBox.TabIndex = 13;
            // 
            // statisticsSummary
            // 
            this.statisticsSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.statisticsSummary.Controls.Add(this.metricTitle0);
            this.statisticsSummary.Controls.Add(this.metricValue0);
            this.statisticsSummary.Controls.Add(this.metricSeparator0);
            this.statisticsSummary.Controls.Add(this.metricTitle1);
            this.statisticsSummary.Controls.Add(this.metricValue1);
            this.statisticsSummary.Controls.Add(this.metricSeparator1);
            this.statisticsSummary.Controls.Add(this.metricTitle2);
            this.statisticsSummary.Controls.Add(this.metricValue2);
            this.statisticsSummary.Controls.Add(this.metricSeparator2);
            this.statisticsSummary.Controls.Add(this.metricTitle3);
            this.statisticsSummary.Controls.Add(this.metricValue3);
            this.statisticsSummary.Location = new System.Drawing.Point(0, 254);
            this.statisticsSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticsSummary.Name = "statisticsSummary";
            this.statisticsSummary.Size = new System.Drawing.Size(1310, 68);
            this.statisticsSummary.TabIndex = 14;
            // 
            // metricTitle0
            // 
            this.metricTitle0.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.metricTitle0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.metricTitle0.Location = new System.Drawing.Point(25, 18);
            this.metricTitle0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricTitle0.Name = "metricTitle0";
            this.metricTitle0.Size = new System.Drawing.Size(166, 32);
            this.metricTitle0.TabIndex = 0;
            this.metricTitle0.Text = "借出";
            // 
            // metricValue0
            // 
            this.metricValue0.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.metricValue0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.metricValue0.Location = new System.Drawing.Point(216, 12);
            this.metricValue0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricValue0.Name = "metricValue0";
            this.metricValue0.Size = new System.Drawing.Size(88, 40);
            this.metricValue0.TabIndex = 1;
            this.metricValue0.Text = "—";
            // 
            // metricSeparator0
            // 
            this.metricSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.metricSeparator0.Location = new System.Drawing.Point(309, 15);
            this.metricSeparator0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metricSeparator0.Name = "metricSeparator0";
            this.metricSeparator0.Size = new System.Drawing.Size(1, 38);
            this.metricSeparator0.TabIndex = 2;
            // 
            // metricTitle1
            // 
            this.metricTitle1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.metricTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.metricTitle1.Location = new System.Drawing.Point(351, 18);
            this.metricTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricTitle1.Name = "metricTitle1";
            this.metricTitle1.Size = new System.Drawing.Size(166, 32);
            this.metricTitle1.TabIndex = 3;
            this.metricTitle1.Text = "归还";
            // 
            // metricValue1
            // 
            this.metricValue1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.metricValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.metricValue1.Location = new System.Drawing.Point(542, 12);
            this.metricValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricValue1.Name = "metricValue1";
            this.metricValue1.Size = new System.Drawing.Size(88, 40);
            this.metricValue1.TabIndex = 4;
            this.metricValue1.Text = "—";
            // 
            // metricSeparator1
            // 
            this.metricSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.metricSeparator1.Location = new System.Drawing.Point(635, 15);
            this.metricSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metricSeparator1.Name = "metricSeparator1";
            this.metricSeparator1.Size = new System.Drawing.Size(1, 38);
            this.metricSeparator1.TabIndex = 5;
            // 
            // metricTitle2
            // 
            this.metricTitle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.metricTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.metricTitle2.Location = new System.Drawing.Point(678, 18);
            this.metricTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricTitle2.Name = "metricTitle2";
            this.metricTitle2.Size = new System.Drawing.Size(166, 32);
            this.metricTitle2.TabIndex = 6;
            this.metricTitle2.Text = "续借";
            // 
            // metricValue2
            // 
            this.metricValue2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.metricValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.metricValue2.Location = new System.Drawing.Point(869, 12);
            this.metricValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricValue2.Name = "metricValue2";
            this.metricValue2.Size = new System.Drawing.Size(88, 40);
            this.metricValue2.TabIndex = 7;
            this.metricValue2.Text = "—";
            // 
            // metricSeparator2
            // 
            this.metricSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.metricSeparator2.Location = new System.Drawing.Point(961, 15);
            this.metricSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metricSeparator2.Name = "metricSeparator2";
            this.metricSeparator2.Size = new System.Drawing.Size(1, 38);
            this.metricSeparator2.TabIndex = 8;
            // 
            // metricTitle3
            // 
            this.metricTitle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.metricTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.metricTitle3.Location = new System.Drawing.Point(1004, 18);
            this.metricTitle3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricTitle3.Name = "metricTitle3";
            this.metricTitle3.Size = new System.Drawing.Size(166, 32);
            this.metricTitle3.TabIndex = 9;
            this.metricTitle3.Text = "当前超期";
            // 
            // metricValue3
            // 
            this.metricValue3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.metricValue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.metricValue3.Location = new System.Drawing.Point(1195, 12);
            this.metricValue3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metricValue3.Name = "metricValue3";
            this.metricValue3.Size = new System.Drawing.Size(88, 40);
            this.metricValue3.TabIndex = 10;
            this.metricValue3.Text = "—";
            // 
            // statListTitle
            // 
            this.statListTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.statListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.statListTitle.Location = new System.Drawing.Point(0, 356);
            this.statListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statListTitle.Name = "statListTitle";
            this.statListTitle.Size = new System.Drawing.Size(875, 39);
            this.statListTitle.TabIndex = 15;
            this.statListTitle.Text = "借阅流水";
            // 
            // statisticsGrid
            // 
            this.statisticsGrid.AllowUserToAddRows = false;
            this.statisticsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.statisticsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.statisticsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statisticsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisticsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statisticsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.statisticsGrid.ColumnHeadersHeight = 40;
            this.statisticsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statisticsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statisticsGridReader,
            this.statisticsGridName,
            this.statisticsGridBarcode,
            this.statisticsGridTitle,
            this.statisticsGridEvent,
            this.statisticsGridTime,
            this.statisticsGridDueDate,
            this.statisticsGridState});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statisticsGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.statisticsGrid.EnableHeadersVisualStyles = false;
            this.statisticsGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.statisticsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.statisticsGrid.Location = new System.Drawing.Point(0, 415);
            this.statisticsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticsGrid.MultiSelect = false;
            this.statisticsGrid.Name = "statisticsGrid";
            this.statisticsGrid.ReadOnly = true;
            this.statisticsGrid.RowHeadersVisible = false;
            this.statisticsGrid.RowTemplate.Height = 34;
            this.statisticsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticsGrid.Size = new System.Drawing.Size(1310, 338);
            this.statisticsGrid.TabIndex = 16;
            // 
            // statisticsGridReader
            // 
            this.statisticsGridReader.FillWeight = 95F;
            this.statisticsGridReader.HeaderText = "读者编号";
            this.statisticsGridReader.Name = "statisticsGridReader";
            this.statisticsGridReader.ReadOnly = true;
            // 
            // statisticsGridName
            // 
            this.statisticsGridName.FillWeight = 75F;
            this.statisticsGridName.HeaderText = "姓名";
            this.statisticsGridName.Name = "statisticsGridName";
            this.statisticsGridName.ReadOnly = true;
            // 
            // statisticsGridBarcode
            // 
            this.statisticsGridBarcode.HeaderText = "复本条码";
            this.statisticsGridBarcode.Name = "statisticsGridBarcode";
            this.statisticsGridBarcode.ReadOnly = true;
            // 
            // statisticsGridTitle
            // 
            this.statisticsGridTitle.FillWeight = 160F;
            this.statisticsGridTitle.HeaderText = "书名";
            this.statisticsGridTitle.Name = "statisticsGridTitle";
            this.statisticsGridTitle.ReadOnly = true;
            // 
            // statisticsGridEvent
            // 
            this.statisticsGridEvent.FillWeight = 70F;
            this.statisticsGridEvent.HeaderText = "业务";
            this.statisticsGridEvent.Name = "statisticsGridEvent";
            this.statisticsGridEvent.ReadOnly = true;
            // 
            // statisticsGridTime
            // 
            this.statisticsGridTime.FillWeight = 120F;
            this.statisticsGridTime.HeaderText = "操作时间";
            this.statisticsGridTime.Name = "statisticsGridTime";
            this.statisticsGridTime.ReadOnly = true;
            // 
            // statisticsGridDueDate
            // 
            this.statisticsGridDueDate.HeaderText = "应还日期";
            this.statisticsGridDueDate.Name = "statisticsGridDueDate";
            this.statisticsGridDueDate.ReadOnly = true;
            // 
            // statisticsGridState
            // 
            this.statisticsGridState.FillWeight = 75F;
            this.statisticsGridState.HeaderText = "状态";
            this.statisticsGridState.Name = "statisticsGridState";
            this.statisticsGridState.ReadOnly = true;
            // 
            // statisticsCount
            // 
            this.statisticsCount.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.statisticsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.statisticsCount.Location = new System.Drawing.Point(1, 772);
            this.statisticsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statisticsCount.Name = "statisticsCount";
            this.statisticsCount.Size = new System.Drawing.Size(500, 31);
            this.statisticsCount.TabIndex = 18;
            this.statisticsCount.Text = "0 条记录";
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.startDatePickerCaption);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endDatePickerCaption);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.statReaderCaption);
            this.Controls.Add(this.statReaderId);
            this.Controls.Add(this.statTypeCaption);
            this.Controls.Add(this.statTypeCombo);
            this.Controls.Add(this.searchStatisticsButton);
            this.Controls.Add(this.exportStatisticsButton);
            this.Controls.Add(this.statBookCaption);
            this.Controls.Add(this.statBookTextBox);
            this.Controls.Add(this.statisticsSummary);
            this.Controls.Add(this.statListTitle);
            this.Controls.Add(this.statisticsGrid);
            this.Controls.Add(this.statisticsCount);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatisticsView";
            this.Size = new System.Drawing.Size(1312, 808);
            this.statisticsSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).EndInit();
            this.handleExceptionButton.Text = "处理所选异常";
            this.handleExceptionButton.Name = "handleExceptionButton";
            this.handleExceptionButton.Location = new System.Drawing.Point(975, 767);
            this.handleExceptionButton.Size = new System.Drawing.Size(180, 36);
            this.handleExceptionButton.BackColor = System.Drawing.Color.White;
            this.handleExceptionButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            this.handleExceptionButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.handleExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Controls.Add(this.handleExceptionButton);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label pageTitle;

        private System.Windows.Forms.Label startDatePickerCaption;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDatePickerCaption;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label statReaderCaption;
        private System.Windows.Forms.TextBox statReaderId;
        private System.Windows.Forms.Label statTypeCaption;
        private System.Windows.Forms.ComboBox statTypeCombo;
        private System.Windows.Forms.Button handleExceptionButton;
        private System.Windows.Forms.Button searchStatisticsButton;
        private System.Windows.Forms.Button exportStatisticsButton;
        private System.Windows.Forms.Label statBookCaption;
        private System.Windows.Forms.TextBox statBookTextBox;
        private System.Windows.Forms.Panel statisticsSummary;
        private System.Windows.Forms.Label metricTitle0;
        private System.Windows.Forms.Label metricValue0;
        private System.Windows.Forms.Panel metricSeparator0;
        private System.Windows.Forms.Label metricTitle1;
        private System.Windows.Forms.Label metricValue1;
        private System.Windows.Forms.Panel metricSeparator1;
        private System.Windows.Forms.Label metricTitle2;
        private System.Windows.Forms.Label metricValue2;
        private System.Windows.Forms.Panel metricSeparator2;
        private System.Windows.Forms.Label metricTitle3;
        private System.Windows.Forms.Label metricValue3;
        private System.Windows.Forms.Label statListTitle;
        private System.Windows.Forms.DataGridView statisticsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsGridState;

        private System.Windows.Forms.Label statisticsCount;
    }
}
