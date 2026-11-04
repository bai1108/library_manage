namespace Library_manage.Views
{
    partial class SettingsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTitle = new System.Windows.Forms.Label();
            this.rulesPanel = new System.Windows.Forms.Panel();
            this.rulesTitle = new System.Windows.Forms.Label();
            this.maxBooksNumericCaption = new System.Windows.Forms.Label();
            this.maxBooksNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxBooksNumericUnit = new System.Windows.Forms.Label();
            this.loanDaysNumericCaption = new System.Windows.Forms.Label();
            this.loanDaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.loanDaysNumericUnit = new System.Windows.Forms.Label();
            this.renewCountNumericCaption = new System.Windows.Forms.Label();
            this.renewCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.renewCountNumericUnit = new System.Windows.Forms.Label();
            this.renewDaysNumericCaption = new System.Windows.Forms.Label();
            this.renewDaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.renewDaysNumericUnit = new System.Windows.Forms.Label();
            this.devicePanel = new System.Windows.Forms.Panel();
            this.deviceTitle = new System.Windows.Forms.Label();
            this.deviceCaption = new System.Windows.Forms.Label();
            this.deviceCombo = new System.Windows.Forms.ComboBox();
            this.deviceEyeCaption = new System.Windows.Forms.Label();
            this.deviceEyeCombo = new System.Windows.Forms.ComboBox();
            this.deviceStateLabel = new System.Windows.Forms.Label();
            this.testDeviceButton = new System.Windows.Forms.Button();
            this.databasePanel = new System.Windows.Forms.Panel();
            this.databaseTitle = new System.Windows.Forms.Label();
            this.serverTextBoxLabel = new System.Windows.Forms.Label();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.databaseTextBoxLabel = new System.Windows.Forms.Label();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.dbUserTextBoxLabel = new System.Windows.Forms.Label();
            this.dbUserTextBox = new System.Windows.Forms.TextBox();
            this.dbPasswordTextBoxLabel = new System.Windows.Forms.Label();
            this.dbPasswordTextBox = new System.Windows.Forms.TextBox();
            this.accountsPanel = new System.Windows.Forms.Panel();
            this.accountsTitle = new System.Windows.Forms.Label();
            this.accountsGrid = new System.Windows.Forms.DataGridView();
            this.accountsGridAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsGridRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.stopAccountButton = new System.Windows.Forms.Button();
            this.testDatabaseButton = new System.Windows.Forms.Button();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.rulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBooksNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDaysNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renewCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renewDaysNumeric)).BeginInit();
            this.devicePanel.SuspendLayout();
            this.databasePanel.SuspendLayout();
            this.accountsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.pageTitle.Location = new System.Drawing.Point(20, 9);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(875, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "系统设置";
            // 
            // rulesPanel
            // 
            this.rulesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.rulesPanel.Controls.Add(this.rulesTitle);
            this.rulesPanel.Controls.Add(this.maxBooksNumericCaption);
            this.rulesPanel.Controls.Add(this.maxBooksNumeric);
            this.rulesPanel.Controls.Add(this.maxBooksNumericUnit);
            this.rulesPanel.Controls.Add(this.loanDaysNumericCaption);
            this.rulesPanel.Controls.Add(this.loanDaysNumeric);
            this.rulesPanel.Controls.Add(this.loanDaysNumericUnit);
            this.rulesPanel.Controls.Add(this.renewCountNumericCaption);
            this.rulesPanel.Controls.Add(this.renewCountNumeric);
            this.rulesPanel.Controls.Add(this.renewCountNumericUnit);
            this.rulesPanel.Controls.Add(this.renewDaysNumericCaption);
            this.rulesPanel.Controls.Add(this.renewDaysNumeric);
            this.rulesPanel.Controls.Add(this.renewDaysNumericUnit);
            this.rulesPanel.Location = new System.Drawing.Point(0, 72);
            this.rulesPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rulesPanel.Name = "rulesPanel";
            this.rulesPanel.Size = new System.Drawing.Size(638, 284);
            this.rulesPanel.TabIndex = 2;
            // 
            // rulesTitle
            // 
            this.rulesTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.rulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.rulesTitle.Location = new System.Drawing.Point(22, 18);
            this.rulesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rulesTitle.Name = "rulesTitle";
            this.rulesTitle.Size = new System.Drawing.Size(562, 38);
            this.rulesTitle.TabIndex = 0;
            this.rulesTitle.Text = "借阅规则";
            // 
            // maxBooksNumericCaption
            // 
            this.maxBooksNumericCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.maxBooksNumericCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.maxBooksNumericCaption.Location = new System.Drawing.Point(25, 81);
            this.maxBooksNumericCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxBooksNumericCaption.Name = "maxBooksNumericCaption";
            this.maxBooksNumericCaption.Size = new System.Drawing.Size(218, 32);
            this.maxBooksNumericCaption.TabIndex = 1;
            this.maxBooksNumericCaption.Text = "借阅上限";
            // 
            // maxBooksNumeric
            // 
            this.maxBooksNumeric.Location = new System.Drawing.Point(261, 78);
            this.maxBooksNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxBooksNumeric.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.maxBooksNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxBooksNumeric.Name = "maxBooksNumeric";
            this.maxBooksNumeric.Size = new System.Drawing.Size(201, 27);
            this.maxBooksNumeric.TabIndex = 2;
            this.maxBooksNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // maxBooksNumericUnit
            // 
            this.maxBooksNumericUnit.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.maxBooksNumericUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.maxBooksNumericUnit.Location = new System.Drawing.Point(486, 81);
            this.maxBooksNumericUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxBooksNumericUnit.Name = "maxBooksNumericUnit";
            this.maxBooksNumericUnit.Size = new System.Drawing.Size(106, 32);
            this.maxBooksNumericUnit.TabIndex = 3;
            this.maxBooksNumericUnit.Text = "册";
            // 
            // loanDaysNumericCaption
            // 
            this.loanDaysNumericCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.loanDaysNumericCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.loanDaysNumericCaption.Location = new System.Drawing.Point(25, 128);
            this.loanDaysNumericCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanDaysNumericCaption.Name = "loanDaysNumericCaption";
            this.loanDaysNumericCaption.Size = new System.Drawing.Size(218, 32);
            this.loanDaysNumericCaption.TabIndex = 4;
            this.loanDaysNumericCaption.Text = "借阅期限";
            // 
            // loanDaysNumeric
            // 
            this.loanDaysNumeric.Location = new System.Drawing.Point(261, 124);
            this.loanDaysNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loanDaysNumeric.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.loanDaysNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loanDaysNumeric.Name = "loanDaysNumeric";
            this.loanDaysNumeric.Size = new System.Drawing.Size(201, 27);
            this.loanDaysNumeric.TabIndex = 5;
            this.loanDaysNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // loanDaysNumericUnit
            // 
            this.loanDaysNumericUnit.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.loanDaysNumericUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.loanDaysNumericUnit.Location = new System.Drawing.Point(486, 128);
            this.loanDaysNumericUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanDaysNumericUnit.Name = "loanDaysNumericUnit";
            this.loanDaysNumericUnit.Size = new System.Drawing.Size(106, 32);
            this.loanDaysNumericUnit.TabIndex = 6;
            this.loanDaysNumericUnit.Text = "天";
            // 
            // renewCountNumericCaption
            // 
            this.renewCountNumericCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.renewCountNumericCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.renewCountNumericCaption.Location = new System.Drawing.Point(25, 174);
            this.renewCountNumericCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renewCountNumericCaption.Name = "renewCountNumericCaption";
            this.renewCountNumericCaption.Size = new System.Drawing.Size(218, 32);
            this.renewCountNumericCaption.TabIndex = 7;
            this.renewCountNumericCaption.Text = "续借上限";
            // 
            // renewCountNumeric
            // 
            this.renewCountNumeric.Location = new System.Drawing.Point(261, 170);
            this.renewCountNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renewCountNumeric.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.renewCountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.renewCountNumeric.Name = "renewCountNumeric";
            this.renewCountNumeric.Size = new System.Drawing.Size(201, 27);
            this.renewCountNumeric.TabIndex = 8;
            this.renewCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // renewCountNumericUnit
            // 
            this.renewCountNumericUnit.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.renewCountNumericUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.renewCountNumericUnit.Location = new System.Drawing.Point(486, 174);
            this.renewCountNumericUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renewCountNumericUnit.Name = "renewCountNumericUnit";
            this.renewCountNumericUnit.Size = new System.Drawing.Size(106, 32);
            this.renewCountNumericUnit.TabIndex = 9;
            this.renewCountNumericUnit.Text = "次";
            // 
            // renewDaysNumericCaption
            // 
            this.renewDaysNumericCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.renewDaysNumericCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.renewDaysNumericCaption.Location = new System.Drawing.Point(25, 220);
            this.renewDaysNumericCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renewDaysNumericCaption.Name = "renewDaysNumericCaption";
            this.renewDaysNumericCaption.Size = new System.Drawing.Size(218, 32);
            this.renewDaysNumericCaption.TabIndex = 10;
            this.renewDaysNumericCaption.Text = "续借延长";
            // 
            // renewDaysNumeric
            // 
            this.renewDaysNumeric.Location = new System.Drawing.Point(261, 216);
            this.renewDaysNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renewDaysNumeric.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.renewDaysNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.renewDaysNumeric.Name = "renewDaysNumeric";
            this.renewDaysNumeric.Size = new System.Drawing.Size(201, 27);
            this.renewDaysNumeric.TabIndex = 11;
            this.renewDaysNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // renewDaysNumericUnit
            // 
            this.renewDaysNumericUnit.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.renewDaysNumericUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.renewDaysNumericUnit.Location = new System.Drawing.Point(486, 220);
            this.renewDaysNumericUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.renewDaysNumericUnit.Name = "renewDaysNumericUnit";
            this.renewDaysNumericUnit.Size = new System.Drawing.Size(106, 32);
            this.renewDaysNumericUnit.TabIndex = 12;
            this.renewDaysNumericUnit.Text = "天";
            // 
            // devicePanel
            // 
            this.devicePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.devicePanel.Controls.Add(this.deviceTitle);
            this.devicePanel.Controls.Add(this.deviceCaption);
            this.devicePanel.Controls.Add(this.deviceCombo);
            this.devicePanel.Controls.Add(this.deviceEyeCaption);
            this.devicePanel.Controls.Add(this.deviceEyeCombo);
            this.devicePanel.Controls.Add(this.deviceStateLabel);
            this.devicePanel.Controls.Add(this.testDeviceButton);
            this.devicePanel.Location = new System.Drawing.Point(668, 72);
            this.devicePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicePanel.Name = "devicePanel";
            this.devicePanel.Size = new System.Drawing.Size(642, 284);
            this.devicePanel.TabIndex = 3;
            // 
            // deviceTitle
            // 
            this.deviceTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.deviceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.deviceTitle.Location = new System.Drawing.Point(22, 18);
            this.deviceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceTitle.Name = "deviceTitle";
            this.deviceTitle.Size = new System.Drawing.Size(562, 38);
            this.deviceTitle.TabIndex = 0;
            this.deviceTitle.Text = "虹膜设备";
            // 
            // deviceCaption
            // 
            this.deviceCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.deviceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.deviceCaption.Location = new System.Drawing.Point(25, 86);
            this.deviceCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceCaption.Name = "deviceCaption";
            this.deviceCaption.Size = new System.Drawing.Size(140, 32);
            this.deviceCaption.TabIndex = 1;
            this.deviceCaption.Text = "采集设备";
            // 
            // deviceCombo
            // 
            this.deviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceCombo.Items.AddRange(new object[] {
            "请选择设备"});
            this.deviceCombo.Location = new System.Drawing.Point(181, 80);
            this.deviceCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deviceCombo.Name = "deviceCombo";
            this.deviceCombo.Size = new System.Drawing.Size(432, 28);
            this.deviceCombo.TabIndex = 2;
            // 
            // deviceEyeCaption
            // 
            this.deviceEyeCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.deviceEyeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.deviceEyeCaption.Location = new System.Drawing.Point(25, 145);
            this.deviceEyeCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceEyeCaption.Name = "deviceEyeCaption";
            this.deviceEyeCaption.Size = new System.Drawing.Size(140, 32);
            this.deviceEyeCaption.TabIndex = 3;
            this.deviceEyeCaption.Text = "识别眼别";
            // 
            // deviceEyeCombo
            // 
            this.deviceEyeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceEyeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceEyeCombo.Items.AddRange(new object[] {
            "任意眼",
            "左眼",
            "右眼",
            "双眼"});
            this.deviceEyeCombo.Location = new System.Drawing.Point(181, 139);
            this.deviceEyeCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deviceEyeCombo.Name = "deviceEyeCombo";
            this.deviceEyeCombo.Size = new System.Drawing.Size(244, 28);
            this.deviceEyeCombo.TabIndex = 4;
            // 
            // deviceStateLabel
            // 
            this.deviceStateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.deviceStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.deviceStateLabel.Location = new System.Drawing.Point(25, 222);
            this.deviceStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceStateLabel.Name = "deviceStateLabel";
            this.deviceStateLabel.Size = new System.Drawing.Size(312, 32);
            this.deviceStateLabel.TabIndex = 5;
            this.deviceStateLabel.Text = "未连接";
            // 
            // testDeviceButton
            // 
            this.testDeviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testDeviceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testDeviceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.testDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testDeviceButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.testDeviceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.testDeviceButton.Location = new System.Drawing.Point(436, 211);
            this.testDeviceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testDeviceButton.Name = "testDeviceButton";
            this.testDeviceButton.Size = new System.Drawing.Size(178, 48);
            this.testDeviceButton.TabIndex = 6;
            this.testDeviceButton.Text = "测试设备";
            this.testDeviceButton.UseVisualStyleBackColor = false;
            // 
            // databasePanel
            // 
            this.databasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.databasePanel.Controls.Add(this.databaseTitle);
            this.databasePanel.Controls.Add(this.serverTextBoxLabel);
            this.databasePanel.Controls.Add(this.serverTextBox);
            this.databasePanel.Controls.Add(this.databaseTextBoxLabel);
            this.databasePanel.Controls.Add(this.databaseTextBox);
            this.databasePanel.Controls.Add(this.dbUserTextBoxLabel);
            this.databasePanel.Controls.Add(this.dbUserTextBox);
            this.databasePanel.Controls.Add(this.dbPasswordTextBoxLabel);
            this.databasePanel.Controls.Add(this.dbPasswordTextBox);
            this.databasePanel.Location = new System.Drawing.Point(0, 386);
            this.databasePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Size = new System.Drawing.Size(638, 311);
            this.databasePanel.TabIndex = 4;
            // 
            // databaseTitle
            // 
            this.databaseTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.databaseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.databaseTitle.Location = new System.Drawing.Point(22, 18);
            this.databaseTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databaseTitle.Name = "databaseTitle";
            this.databaseTitle.Size = new System.Drawing.Size(562, 38);
            this.databaseTitle.TabIndex = 0;
            this.databaseTitle.Text = "数据库连接";
            // 
            // serverTextBoxLabel
            // 
            this.serverTextBoxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.serverTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.serverTextBoxLabel.Location = new System.Drawing.Point(25, 84);
            this.serverTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverTextBoxLabel.Name = "serverTextBoxLabel";
            this.serverTextBoxLabel.Size = new System.Drawing.Size(118, 31);
            this.serverTextBoxLabel.TabIndex = 1;
            this.serverTextBoxLabel.Text = "服务器";
            // 
            // serverTextBox
            // 
            this.serverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.serverTextBox.Location = new System.Drawing.Point(156, 78);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(451, 31);
            this.serverTextBox.TabIndex = 2;
            // 
            // databaseTextBoxLabel
            // 
            this.databaseTextBoxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.databaseTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.databaseTextBoxLabel.Location = new System.Drawing.Point(25, 141);
            this.databaseTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databaseTextBoxLabel.Name = "databaseTextBoxLabel";
            this.databaseTextBoxLabel.Size = new System.Drawing.Size(118, 31);
            this.databaseTextBoxLabel.TabIndex = 3;
            this.databaseTextBoxLabel.Text = "数据库";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.databaseTextBox.Location = new System.Drawing.Point(156, 135);
            this.databaseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(451, 31);
            this.databaseTextBox.TabIndex = 4;
            this.databaseTextBox.Text = "IrisLibrary";
            // 
            // dbUserTextBoxLabel
            // 
            this.dbUserTextBoxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.dbUserTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.dbUserTextBoxLabel.Location = new System.Drawing.Point(25, 199);
            this.dbUserTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbUserTextBoxLabel.Name = "dbUserTextBoxLabel";
            this.dbUserTextBoxLabel.Size = new System.Drawing.Size(118, 31);
            this.dbUserTextBoxLabel.TabIndex = 5;
            this.dbUserTextBoxLabel.Text = "账号";
            // 
            // dbUserTextBox
            // 
            this.dbUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbUserTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.dbUserTextBox.Location = new System.Drawing.Point(156, 192);
            this.dbUserTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbUserTextBox.Name = "dbUserTextBox";
            this.dbUserTextBox.Size = new System.Drawing.Size(451, 31);
            this.dbUserTextBox.TabIndex = 6;
            // 
            // dbPasswordTextBoxLabel
            // 
            this.dbPasswordTextBoxLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.dbPasswordTextBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.dbPasswordTextBoxLabel.Location = new System.Drawing.Point(25, 256);
            this.dbPasswordTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dbPasswordTextBoxLabel.Name = "dbPasswordTextBoxLabel";
            this.dbPasswordTextBoxLabel.Size = new System.Drawing.Size(118, 31);
            this.dbPasswordTextBoxLabel.TabIndex = 7;
            this.dbPasswordTextBoxLabel.Text = "密码";
            // 
            // dbPasswordTextBox
            // 
            this.dbPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbPasswordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.dbPasswordTextBox.Location = new System.Drawing.Point(156, 250);
            this.dbPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbPasswordTextBox.Name = "dbPasswordTextBox";
            this.dbPasswordTextBox.Size = new System.Drawing.Size(451, 31);
            this.dbPasswordTextBox.TabIndex = 8;
            this.dbPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // accountsPanel
            // 
            this.accountsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.accountsPanel.Controls.Add(this.accountsTitle);
            this.accountsPanel.Controls.Add(this.accountsGrid);
            this.accountsPanel.Controls.Add(this.addAccountButton);
            this.accountsPanel.Controls.Add(this.editAccountButton);
            this.accountsPanel.Controls.Add(this.stopAccountButton);
            this.accountsPanel.Location = new System.Drawing.Point(668, 386);
            this.accountsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountsPanel.Name = "accountsPanel";
            this.accountsPanel.Size = new System.Drawing.Size(642, 311);
            this.accountsPanel.TabIndex = 5;
            // 
            // accountsTitle
            // 
            this.accountsTitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.accountsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.accountsTitle.Location = new System.Drawing.Point(22, 18);
            this.accountsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountsTitle.Name = "accountsTitle";
            this.accountsTitle.Size = new System.Drawing.Size(562, 38);
            this.accountsTitle.TabIndex = 0;
            this.accountsTitle.Text = "管理员账户";
            // 
            // accountsGrid
            // 
            this.accountsGrid.AllowUserToAddRows = false;
            this.accountsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.accountsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.accountsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.accountsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.accountsGrid.ColumnHeadersHeight = 40;
            this.accountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountsGridAccount,
            this.accountsGridRole,
            this.accountsGridState});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.accountsGrid.EnableHeadersVisualStyles = false;
            this.accountsGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.accountsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.accountsGrid.Location = new System.Drawing.Point(24, 78);
            this.accountsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountsGrid.MultiSelect = false;
            this.accountsGrid.Name = "accountsGrid";
            this.accountsGrid.ReadOnly = true;
            this.accountsGrid.RowHeadersVisible = false;
            this.accountsGrid.RowTemplate.Height = 34;
            this.accountsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsGrid.Size = new System.Drawing.Size(592, 144);
            this.accountsGrid.TabIndex = 1;
            // 
            // accountsGridAccount
            // 
            this.accountsGridAccount.FillWeight = 120F;
            this.accountsGridAccount.HeaderText = "账号";
            this.accountsGridAccount.Name = "accountsGridAccount";
            this.accountsGridAccount.ReadOnly = true;
            // 
            // accountsGridRole
            // 
            this.accountsGridRole.HeaderText = "角色";
            this.accountsGridRole.Name = "accountsGridRole";
            this.accountsGridRole.ReadOnly = true;
            // 
            // accountsGridState
            // 
            this.accountsGridState.FillWeight = 90F;
            this.accountsGridState.HeaderText = "状态";
            this.accountsGridState.Name = "accountsGridState";
            this.accountsGridState.ReadOnly = true;
            // 
            // addAccountButton
            // 
            this.addAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.addAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.addAccountButton.Location = new System.Drawing.Point(25, 240);
            this.addAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(134, 46);
            this.addAccountButton.TabIndex = 3;
            this.addAccountButton.Text = "新增";
            this.addAccountButton.UseVisualStyleBackColor = false;
            // 
            // editAccountButton
            // 
            this.editAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.editAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.editAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.editAccountButton.Location = new System.Drawing.Point(178, 240);
            this.editAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(134, 46);
            this.editAccountButton.TabIndex = 4;
            this.editAccountButton.Text = "修改";
            this.editAccountButton.UseVisualStyleBackColor = false;
            // 
            // stopAccountButton
            // 
            this.stopAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.stopAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopAccountButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.stopAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.stopAccountButton.Location = new System.Drawing.Point(330, 240);
            this.stopAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopAccountButton.Name = "stopAccountButton";
            this.stopAccountButton.Size = new System.Drawing.Size(134, 46);
            this.stopAccountButton.TabIndex = 5;
            this.stopAccountButton.Text = "停用";
            this.stopAccountButton.UseVisualStyleBackColor = false;
            // 
            // testDatabaseButton
            // 
            this.testDatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testDatabaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testDatabaseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.testDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testDatabaseButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.testDatabaseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.testDatabaseButton.Location = new System.Drawing.Point(0, 735);
            this.testDatabaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testDatabaseButton.Name = "testDatabaseButton";
            this.testDatabaseButton.Size = new System.Drawing.Size(239, 44);
            this.testDatabaseButton.TabIndex = 6;
            this.testDatabaseButton.Text = "测试数据库连接";
            this.testDatabaseButton.UseVisualStyleBackColor = false;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveSettingsButton.FlatAppearance.BorderSize = 0;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.saveSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveSettingsButton.Location = new System.Drawing.Point(1108, 735);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(202, 44);
            this.saveSettingsButton.TabIndex = 7;
            this.saveSettingsButton.Text = "保存设置";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.rulesPanel);
            this.Controls.Add(this.devicePanel);
            this.Controls.Add(this.databasePanel);
            this.Controls.Add(this.accountsPanel);
            this.Controls.Add(this.testDatabaseButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(1312, 808);
            this.Load += new System.EventHandler(this.SettingsView_Load);
            this.rulesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxBooksNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDaysNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renewCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renewDaysNumeric)).EndInit();
            this.devicePanel.ResumeLayout(false);
            this.databasePanel.ResumeLayout(false);
            this.databasePanel.PerformLayout();
            this.accountsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label pageTitle;

        private System.Windows.Forms.Panel rulesPanel;
        private System.Windows.Forms.Label rulesTitle;
        private System.Windows.Forms.Label maxBooksNumericCaption;
        private System.Windows.Forms.NumericUpDown maxBooksNumeric;
        private System.Windows.Forms.Label maxBooksNumericUnit;
        private System.Windows.Forms.Label loanDaysNumericCaption;
        private System.Windows.Forms.NumericUpDown loanDaysNumeric;
        private System.Windows.Forms.Label loanDaysNumericUnit;
        private System.Windows.Forms.Label renewCountNumericCaption;
        private System.Windows.Forms.NumericUpDown renewCountNumeric;
        private System.Windows.Forms.Label renewCountNumericUnit;
        private System.Windows.Forms.Label renewDaysNumericCaption;
        private System.Windows.Forms.NumericUpDown renewDaysNumeric;
        private System.Windows.Forms.Label renewDaysNumericUnit;
        private System.Windows.Forms.Panel devicePanel;
        private System.Windows.Forms.Label deviceTitle;
        private System.Windows.Forms.Label deviceCaption;
        private System.Windows.Forms.ComboBox deviceCombo;
        private System.Windows.Forms.Label deviceEyeCaption;
        private System.Windows.Forms.ComboBox deviceEyeCombo;
        private System.Windows.Forms.Label deviceStateLabel;
        private System.Windows.Forms.Button testDeviceButton;
        private System.Windows.Forms.Panel databasePanel;
        private System.Windows.Forms.Label databaseTitle;
        private System.Windows.Forms.Label serverTextBoxLabel;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label databaseTextBoxLabel;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.Label dbUserTextBoxLabel;
        private System.Windows.Forms.TextBox dbUserTextBox;
        private System.Windows.Forms.Label dbPasswordTextBoxLabel;
        private System.Windows.Forms.TextBox dbPasswordTextBox;
        private System.Windows.Forms.Panel accountsPanel;
        private System.Windows.Forms.Label accountsTitle;
        private System.Windows.Forms.DataGridView accountsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsGridAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsGridRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountsGridState;

        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Button stopAccountButton;
        private System.Windows.Forms.Button testDatabaseButton;
        private System.Windows.Forms.Button saveSettingsButton;
    }
}
