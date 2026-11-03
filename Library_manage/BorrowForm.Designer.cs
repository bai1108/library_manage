namespace Library_manage
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.libraryLogo = new System.Windows.Forms.PictureBox();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.titleDivider = new System.Windows.Forms.Panel();
            this.readerCard = new System.Windows.Forms.Panel();
            this.readerTitle = new System.Windows.Forms.Label();
            this.readerName = new System.Windows.Forms.Label();
            this.readerId = new System.Windows.Forms.Label();
            this.readerDivider = new System.Windows.Forms.Panel();
            this.readerField0 = new System.Windows.Forms.Label();
            this.readerValue0 = new System.Windows.Forms.Label();
            this.readerField1 = new System.Windows.Forms.Label();
            this.readerValue1 = new System.Windows.Forms.Label();
            this.readerField2 = new System.Windows.Forms.Label();
            this.readerValue2 = new System.Windows.Forms.Label();
            this.readerField3 = new System.Windows.Forms.Label();
            this.readerValue3 = new System.Windows.Forms.Label();
            this.finishReaderButton = new System.Windows.Forms.Button();
            this.borrowWorkspace = new System.Windows.Forms.Panel();
            this.barcodeCaption = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.searchBookButton = new System.Windows.Forms.Button();
            this.bookInformation = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.renewButton = new System.Windows.Forms.Button();
            this.borrowDivider = new System.Windows.Forms.Panel();
            this.loanListTitle = new System.Windows.Forms.Label();
            this.loanGrid = new System.Windows.Forms.DataGridView();
            this.loanGridBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanGridTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanGridBorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanGridDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanGridRenew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).BeginInit();
            this.readerCard.SuspendLayout();
            this.borrowWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.titlePanel.Controls.Add(this.libraryLogo);
            this.titlePanel.Controls.Add(this.applicationTitle);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Controls.Add(this.closeWindowButton);
            this.titlePanel.Controls.Add(this.titleDivider);
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1600, 75);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseUp);
            // 
            // libraryLogo
            // 
            this.libraryLogo.Image = ((System.Drawing.Image)(resources.GetObject("libraryLogo.Image")));
            this.libraryLogo.Location = new System.Drawing.Point(30, 19);
            this.libraryLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libraryLogo.Name = "libraryLogo";
            this.libraryLogo.Size = new System.Drawing.Size(38, 38);
            this.libraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.libraryLogo.TabIndex = 0;
            this.libraryLogo.TabStop = false;
            // 
            // applicationTitle
            // 
            this.applicationTitle.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.applicationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.applicationTitle.Location = new System.Drawing.Point(85, 21);
            this.applicationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.Size = new System.Drawing.Size(1350, 38);
            this.applicationTitle.TabIndex = 1;
            this.applicationTitle.Text = "图书借还";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.minimizeButton.Location = new System.Drawing.Point(1462, 12);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(55, 50);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "—";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.closeWindowButton.FlatAppearance.BorderSize = 0;
            this.closeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowButton.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.closeWindowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.closeWindowButton.Location = new System.Drawing.Point(1522, 12);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(55, 50);
            this.closeWindowButton.TabIndex = 4;
            this.closeWindowButton.Text = "×";
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // titleDivider
            // 
            this.titleDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.titleDivider.Location = new System.Drawing.Point(0, 74);
            this.titleDivider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleDivider.Name = "titleDivider";
            this.titleDivider.Size = new System.Drawing.Size(1600, 1);
            this.titleDivider.TabIndex = 5;
            // 
            // readerCard
            // 
            this.readerCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readerCard.Controls.Add(this.readerTitle);
            this.readerCard.Controls.Add(this.readerName);
            this.readerCard.Controls.Add(this.readerId);
            this.readerCard.Controls.Add(this.readerDivider);
            this.readerCard.Controls.Add(this.readerField0);
            this.readerCard.Controls.Add(this.readerValue0);
            this.readerCard.Controls.Add(this.readerField1);
            this.readerCard.Controls.Add(this.readerValue1);
            this.readerCard.Controls.Add(this.readerField2);
            this.readerCard.Controls.Add(this.readerValue2);
            this.readerCard.Controls.Add(this.readerField3);
            this.readerCard.Controls.Add(this.readerValue3);
            this.readerCard.Controls.Add(this.finishReaderButton);
            this.readerCard.Location = new System.Drawing.Point(30, 105);
            this.readerCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerCard.Name = "readerCard";
            this.readerCard.Size = new System.Drawing.Size(310, 778);
            this.readerCard.TabIndex = 1;
            // 
            // readerTitle
            // 
            this.readerTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.readerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerTitle.Location = new System.Drawing.Point(25, 25);
            this.readerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerTitle.Name = "readerTitle";
            this.readerTitle.Size = new System.Drawing.Size(262, 35);
            this.readerTitle.TabIndex = 0;
            this.readerTitle.Text = "当前读者";
            // 
            // readerName
            // 
            this.readerName.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold);
            this.readerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerName.Location = new System.Drawing.Point(25, 94);
            this.readerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerName.Name = "readerName";
            this.readerName.Size = new System.Drawing.Size(262, 42);
            this.readerName.TabIndex = 2;
            this.readerName.Text = "未登录";
            // 
            // readerId
            // 
            this.readerId.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerId.Location = new System.Drawing.Point(25, 155);
            this.readerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerId.Name = "readerId";
            this.readerId.Size = new System.Drawing.Size(262, 32);
            this.readerId.TabIndex = 3;
            this.readerId.Text = "读者编号  —";
            // 
            // readerDivider
            // 
            this.readerDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.readerDivider.Location = new System.Drawing.Point(25, 216);
            this.readerDivider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerDivider.Name = "readerDivider";
            this.readerDivider.Size = new System.Drawing.Size(260, 1);
            this.readerDivider.TabIndex = 4;
            // 
            // readerField0
            // 
            this.readerField0.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerField0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerField0.Location = new System.Drawing.Point(25, 254);
            this.readerField0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerField0.Name = "readerField0";
            this.readerField0.Size = new System.Drawing.Size(175, 35);
            this.readerField0.TabIndex = 5;
            this.readerField0.Text = "班级 / 部门";
            // 
            // readerValue0
            // 
            this.readerValue0.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.readerValue0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerValue0.Location = new System.Drawing.Point(222, 254);
            this.readerValue0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerValue0.Name = "readerValue0";
            this.readerValue0.Size = new System.Drawing.Size(62, 35);
            this.readerValue0.TabIndex = 6;
            this.readerValue0.Text = "—";
            // 
            // readerField1
            // 
            this.readerField1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerField1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerField1.Location = new System.Drawing.Point(25, 314);
            this.readerField1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerField1.Name = "readerField1";
            this.readerField1.Size = new System.Drawing.Size(175, 35);
            this.readerField1.TabIndex = 7;
            this.readerField1.Text = "档案状态";
            // 
            // readerValue1
            // 
            this.readerValue1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.readerValue1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerValue1.Location = new System.Drawing.Point(222, 314);
            this.readerValue1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerValue1.Name = "readerValue1";
            this.readerValue1.Size = new System.Drawing.Size(62, 35);
            this.readerValue1.TabIndex = 8;
            this.readerValue1.Text = "—";
            // 
            // readerField2
            // 
            this.readerField2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerField2.Location = new System.Drawing.Point(25, 374);
            this.readerField2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerField2.Name = "readerField2";
            this.readerField2.Size = new System.Drawing.Size(175, 35);
            this.readerField2.TabIndex = 9;
            this.readerField2.Text = "当前在借";
            // 
            // readerValue2
            // 
            this.readerValue2.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.readerValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerValue2.Location = new System.Drawing.Point(222, 374);
            this.readerValue2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerValue2.Name = "readerValue2";
            this.readerValue2.Size = new System.Drawing.Size(62, 35);
            this.readerValue2.TabIndex = 10;
            this.readerValue2.Text = "—";
            // 
            // readerField3
            // 
            this.readerField3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerField3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerField3.Location = new System.Drawing.Point(25, 434);
            this.readerField3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerField3.Name = "readerField3";
            this.readerField3.Size = new System.Drawing.Size(175, 35);
            this.readerField3.TabIndex = 11;
            this.readerField3.Text = "逾期数量";
            // 
            // readerValue3
            // 
            this.readerValue3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.readerValue3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerValue3.Location = new System.Drawing.Point(222, 434);
            this.readerValue3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerValue3.Name = "readerValue3";
            this.readerValue3.Size = new System.Drawing.Size(62, 35);
            this.readerValue3.TabIndex = 12;
            this.readerValue3.Text = "—";
            // 
            // finishReaderButton
            // 
            this.finishReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.finishReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.finishReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.finishReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.finishReaderButton.Location = new System.Drawing.Point(25, 690);
            this.finishReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishReaderButton.Name = "finishReaderButton";
            this.finishReaderButton.Size = new System.Drawing.Size(260, 52);
            this.finishReaderButton.TabIndex = 13;
            this.finishReaderButton.Text = "结束本次服务";
            this.finishReaderButton.UseVisualStyleBackColor = false;
            this.finishReaderButton.Click += new System.EventHandler(this.finishReaderButton_Click);
            // 
            // borrowWorkspace
            // 
            this.borrowWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowWorkspace.Controls.Add(this.barcodeCaption);
            this.borrowWorkspace.Controls.Add(this.barcodeTextBox);
            this.borrowWorkspace.Controls.Add(this.searchBookButton);
            this.borrowWorkspace.Controls.Add(this.bookInformation);
            this.borrowWorkspace.Controls.Add(this.borrowButton);
            this.borrowWorkspace.Controls.Add(this.returnButton);
            this.borrowWorkspace.Controls.Add(this.renewButton);
            this.borrowWorkspace.Controls.Add(this.borrowDivider);
            this.borrowWorkspace.Controls.Add(this.loanListTitle);
            this.borrowWorkspace.Controls.Add(this.loanGrid);
            this.borrowWorkspace.Controls.Add(this.resultLabel);
            this.borrowWorkspace.Location = new System.Drawing.Point(365, 105);
            this.borrowWorkspace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowWorkspace.Name = "borrowWorkspace";
            this.borrowWorkspace.Size = new System.Drawing.Size(1205, 778);
            this.borrowWorkspace.TabIndex = 2;
            // 
            // barcodeCaption
            // 
            this.barcodeCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.barcodeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.barcodeCaption.Location = new System.Drawing.Point(30, 30);
            this.barcodeCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barcodeCaption.Name = "barcodeCaption";
            this.barcodeCaption.Size = new System.Drawing.Size(812, 32);
            this.barcodeCaption.TabIndex = 2;
            this.barcodeCaption.Text = "复本条码";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.barcodeTextBox.Location = new System.Drawing.Point(30, 76);
            this.barcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(884, 31);
            this.barcodeTextBox.TabIndex = 3;
            // 
            // searchBookButton
            // 
            this.searchBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.searchBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.searchBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.searchBookButton.Location = new System.Drawing.Point(939, 71);
            this.searchBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBookButton.Name = "searchBookButton";
            this.searchBookButton.Size = new System.Drawing.Size(236, 52);
            this.searchBookButton.TabIndex = 4;
            this.searchBookButton.Text = "查询";
            this.searchBookButton.UseVisualStyleBackColor = false;
            // 
            // bookInformation
            // 
            this.bookInformation.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            this.bookInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.bookInformation.Location = new System.Drawing.Point(30, 149);
            this.bookInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookInformation.Name = "bookInformation";
            this.bookInformation.Size = new System.Drawing.Size(1145, 36);
            this.bookInformation.TabIndex = 5;
            this.bookInformation.Text = "书名：—     作者：—     馆藏状态：—";
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.borrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.borrowButton.FlatAppearance.BorderSize = 0;
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.borrowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.borrowButton.Location = new System.Drawing.Point(30, 219);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(150, 50);
            this.borrowButton.TabIndex = 6;
            this.borrowButton.Text = "借书";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.returnButton.Location = new System.Drawing.Point(202, 219);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(150, 50);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "还书";
            this.returnButton.UseVisualStyleBackColor = false;
            // 
            // renewButton
            // 
            this.renewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.renewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.renewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.renewButton.Location = new System.Drawing.Point(375, 219);
            this.renewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renewButton.Name = "renewButton";
            this.renewButton.Size = new System.Drawing.Size(150, 50);
            this.renewButton.TabIndex = 8;
            this.renewButton.Text = "续借";
            this.renewButton.UseVisualStyleBackColor = false;
            // 
            // borrowDivider
            // 
            this.borrowDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.borrowDivider.Location = new System.Drawing.Point(30, 306);
            this.borrowDivider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrowDivider.Name = "borrowDivider";
            this.borrowDivider.Size = new System.Drawing.Size(1145, 1);
            this.borrowDivider.TabIndex = 9;
            // 
            // loanListTitle
            // 
            this.loanListTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.loanListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.loanListTitle.Location = new System.Drawing.Point(30, 338);
            this.loanListTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanListTitle.Name = "loanListTitle";
            this.loanListTitle.Size = new System.Drawing.Size(938, 38);
            this.loanListTitle.TabIndex = 10;
            this.loanListTitle.Text = "当前借阅";
            // 
            // loanGrid
            // 
            this.loanGrid.AllowUserToAddRows = false;
            this.loanGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.loanGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loanGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loanGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loanGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loanGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.loanGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loanGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.loanGrid.ColumnHeadersHeight = 40;
            this.loanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.loanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanGridBarcode,
            this.loanGridTitle,
            this.loanGridBorrowDate,
            this.loanGridDueDate,
            this.loanGridRenew,
            this.loanGridState});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loanGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.loanGrid.EnableHeadersVisualStyles = false;
            this.loanGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.loanGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.loanGrid.Location = new System.Drawing.Point(30, 394);
            this.loanGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loanGrid.MultiSelect = false;
            this.loanGrid.Name = "loanGrid";
            this.loanGrid.ReadOnly = true;
            this.loanGrid.RowHeadersVisible = false;
            this.loanGrid.RowTemplate.Height = 34;
            this.loanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loanGrid.Size = new System.Drawing.Size(1145, 270);
            this.loanGrid.TabIndex = 11;
            // 
            // loanGridBarcode
            // 
            this.loanGridBarcode.FillWeight = 105F;
            this.loanGridBarcode.HeaderText = "条码";
            this.loanGridBarcode.Name = "loanGridBarcode";
            this.loanGridBarcode.ReadOnly = true;
            // 
            // loanGridTitle
            // 
            this.loanGridTitle.FillWeight = 180F;
            this.loanGridTitle.HeaderText = "书名";
            this.loanGridTitle.Name = "loanGridTitle";
            this.loanGridTitle.ReadOnly = true;
            // 
            // loanGridBorrowDate
            // 
            this.loanGridBorrowDate.FillWeight = 105F;
            this.loanGridBorrowDate.HeaderText = "借出日期";
            this.loanGridBorrowDate.Name = "loanGridBorrowDate";
            this.loanGridBorrowDate.ReadOnly = true;
            // 
            // loanGridDueDate
            // 
            this.loanGridDueDate.FillWeight = 105F;
            this.loanGridDueDate.HeaderText = "应还日期";
            this.loanGridDueDate.Name = "loanGridDueDate";
            this.loanGridDueDate.ReadOnly = true;
            // 
            // loanGridRenew
            // 
            this.loanGridRenew.FillWeight = 65F;
            this.loanGridRenew.HeaderText = "续借";
            this.loanGridRenew.Name = "loanGridRenew";
            this.loanGridRenew.ReadOnly = true;
            // 
            // loanGridState
            // 
            this.loanGridState.FillWeight = 80F;
            this.loanGridState.HeaderText = "状态";
            this.loanGridState.Name = "loanGridState";
            this.loanGridState.ReadOnly = true;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.resultLabel.Location = new System.Drawing.Point(30, 714);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(1145, 32);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "操作结果：等待办理";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1600, 912);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.readerCard);
            this.Controls.Add(this.borrowWorkspace);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借还";
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).EndInit();
            this.readerCard.ResumeLayout(false);
            this.borrowWorkspace.ResumeLayout(false);
            this.borrowWorkspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanGrid)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox libraryLogo;
        private System.Windows.Forms.Label applicationTitle;

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Panel titleDivider;
        private System.Windows.Forms.Panel readerCard;
        private System.Windows.Forms.Label readerTitle;

        private System.Windows.Forms.Label readerName;
        private System.Windows.Forms.Label readerId;
        private System.Windows.Forms.Panel readerDivider;
        private System.Windows.Forms.Label readerField0;
        private System.Windows.Forms.Label readerValue0;
        private System.Windows.Forms.Label readerField1;
        private System.Windows.Forms.Label readerValue1;
        private System.Windows.Forms.Label readerField2;
        private System.Windows.Forms.Label readerValue2;
        private System.Windows.Forms.Label readerField3;
        private System.Windows.Forms.Label readerValue3;
        private System.Windows.Forms.Button finishReaderButton;
        private System.Windows.Forms.Panel borrowWorkspace;

        private System.Windows.Forms.Label barcodeCaption;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Button searchBookButton;
        private System.Windows.Forms.Label bookInformation;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button renewButton;
        private System.Windows.Forms.Panel borrowDivider;
        private System.Windows.Forms.Label loanListTitle;
        private System.Windows.Forms.DataGridView loanGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridBorrowDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridRenew;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanGridState;

        private System.Windows.Forms.Label resultLabel;

    }
}
