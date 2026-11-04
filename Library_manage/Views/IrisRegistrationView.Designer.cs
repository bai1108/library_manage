namespace Library_manage.Views
{
    partial class IrisRegistrationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IrisRegistrationView));
            this.pageTitle = new System.Windows.Forms.Label();
            this.findReaderCaption = new System.Windows.Forms.Label();
            this.findReaderTextBox = new System.Windows.Forms.TextBox();
            this.findReaderButton = new System.Windows.Forms.Button();
            this.registerReadersGrid = new System.Windows.Forms.DataGridView();
            this.registerReadersGridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerReadersGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerReadersGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerReaderCount = new System.Windows.Forms.Label();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.selectedReader = new System.Windows.Forms.Label();
            this.selectedReaderId = new System.Windows.Forms.Label();
            this.cameraPanel = new System.Windows.Forms.Panel();
            this.irisCameraGuide = new System.Windows.Forms.PictureBox();
            this.registerDeviceState = new System.Windows.Forms.Label();
            this.eyeLabel = new System.Windows.Forms.Label();
            this.eyeCombo = new System.Windows.Forms.ComboBox();
            this.registrationState = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.connectDeviceButton = new System.Windows.Forms.Button();
            this.startRegistrationButton = new System.Windows.Forms.Button();
            this.recaptureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerReadersGrid)).BeginInit();
            this.registrationPanel.SuspendLayout();
            this.cameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irisCameraGuide)).BeginInit();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.pageTitle.Location = new System.Drawing.Point(24, 13);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(875, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "虹膜注册";
            // 
            // findReaderCaption
            // 
            this.findReaderCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.findReaderCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.findReaderCaption.Location = new System.Drawing.Point(27, 72);
            this.findReaderCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.findReaderCaption.Name = "findReaderCaption";
            this.findReaderCaption.Size = new System.Drawing.Size(450, 31);
            this.findReaderCaption.TabIndex = 2;
            this.findReaderCaption.Text = "读者编号 / 姓名";
            // 
            // findReaderTextBox
            // 
            this.findReaderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findReaderTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.findReaderTextBox.Location = new System.Drawing.Point(34, 119);
            this.findReaderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.findReaderTextBox.Name = "findReaderTextBox";
            this.findReaderTextBox.Size = new System.Drawing.Size(361, 31);
            this.findReaderTextBox.TabIndex = 3;
            // 
            // findReaderButton
            // 
            this.findReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.findReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.findReaderButton.FlatAppearance.BorderSize = 0;
            this.findReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.findReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.findReaderButton.Location = new System.Drawing.Point(403, 107);
            this.findReaderButton.Margin = new System.Windows.Forms.Padding(4);
            this.findReaderButton.Name = "findReaderButton";
            this.findReaderButton.Size = new System.Drawing.Size(129, 50);
            this.findReaderButton.TabIndex = 4;
            this.findReaderButton.Text = "查找";
            this.findReaderButton.UseVisualStyleBackColor = false;
            // 
            // registerReadersGrid
            // 
            this.registerReadersGrid.AllowUserToAddRows = false;
            this.registerReadersGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.registerReadersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.registerReadersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerReadersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registerReadersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registerReadersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.registerReadersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registerReadersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.registerReadersGrid.ColumnHeadersHeight = 40;
            this.registerReadersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.registerReadersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerReadersGridId,
            this.registerReadersGridName,
            this.registerReadersGridState});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registerReadersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.registerReadersGrid.EnableHeadersVisualStyles = false;
            this.registerReadersGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.registerReadersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.registerReadersGrid.Location = new System.Drawing.Point(12, 183);
            this.registerReadersGrid.Margin = new System.Windows.Forms.Padding(4);
            this.registerReadersGrid.MultiSelect = false;
            this.registerReadersGrid.Name = "registerReadersGrid";
            this.registerReadersGrid.ReadOnly = true;
            this.registerReadersGrid.RowHeadersVisible = false;
            this.registerReadersGrid.RowTemplate.Height = 34;
            this.registerReadersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registerReadersGrid.Size = new System.Drawing.Size(510, 502);
            this.registerReadersGrid.TabIndex = 5;
            // 
            // registerReadersGridId
            // 
            this.registerReadersGridId.FillWeight = 90F;
            this.registerReadersGridId.HeaderText = "读者编号";
            this.registerReadersGridId.Name = "registerReadersGridId";
            this.registerReadersGridId.ReadOnly = true;
            // 
            // registerReadersGridName
            // 
            this.registerReadersGridName.FillWeight = 70F;
            this.registerReadersGridName.HeaderText = "姓名";
            this.registerReadersGridName.Name = "registerReadersGridName";
            this.registerReadersGridName.ReadOnly = true;
            // 
            // registerReadersGridState
            // 
            this.registerReadersGridState.FillWeight = 90F;
            this.registerReadersGridState.HeaderText = "虹膜状态";
            this.registerReadersGridState.Name = "registerReadersGridState";
            this.registerReadersGridState.ReadOnly = true;
            // 
            // registerReaderCount
            // 
            this.registerReaderCount.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.registerReaderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.registerReaderCount.Location = new System.Drawing.Point(0, 732);
            this.registerReaderCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerReaderCount.Name = "registerReaderCount";
            this.registerReaderCount.Size = new System.Drawing.Size(500, 31);
            this.registerReaderCount.TabIndex = 7;
            this.registerReaderCount.Text = "0 条记录";
            // 
            // registrationPanel
            // 
            this.registrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.registrationPanel.Controls.Add(this.selectedReader);
            this.registrationPanel.Controls.Add(this.selectedReaderId);
            this.registrationPanel.Controls.Add(this.cameraPanel);
            this.registrationPanel.Controls.Add(this.eyeLabel);
            this.registrationPanel.Controls.Add(this.eyeCombo);
            this.registrationPanel.Controls.Add(this.registrationState);
            this.registrationPanel.Controls.Add(this.qualityLabel);
            this.registrationPanel.Controls.Add(this.connectDeviceButton);
            this.registrationPanel.Controls.Add(this.startRegistrationButton);
            this.registrationPanel.Controls.Add(this.recaptureButton);
            this.registrationPanel.Location = new System.Drawing.Point(540, 72);
            this.registrationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(770, 720);
            this.registrationPanel.TabIndex = 8;
            // 
            // selectedReader
            // 
            this.selectedReader.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.selectedReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.selectedReader.Location = new System.Drawing.Point(25, 22);
            this.selectedReader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedReader.Name = "selectedReader";
            this.selectedReader.Size = new System.Drawing.Size(700, 36);
            this.selectedReader.TabIndex = 0;
            this.selectedReader.Text = "当前读者：未选择";
            // 
            // selectedReaderId
            // 
            this.selectedReaderId.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.selectedReaderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.selectedReaderId.Location = new System.Drawing.Point(25, 72);
            this.selectedReaderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedReaderId.Name = "selectedReaderId";
            this.selectedReaderId.Size = new System.Drawing.Size(700, 31);
            this.selectedReaderId.TabIndex = 1;
            this.selectedReaderId.Text = "读者编号：—";
            // 
            // cameraPanel
            // 
            this.cameraPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cameraPanel.Controls.Add(this.irisCameraGuide);
            this.cameraPanel.Controls.Add(this.registerDeviceState);
            this.cameraPanel.Location = new System.Drawing.Point(25, 107);
            this.cameraPanel.Margin = new System.Windows.Forms.Padding(4);
            this.cameraPanel.Name = "cameraPanel";
            this.cameraPanel.Size = new System.Drawing.Size(687, 372);
            this.cameraPanel.TabIndex = 2;
            // 
            // irisCameraGuide
            // 
            this.irisCameraGuide.Image = ((System.Drawing.Image)(resources.GetObject("irisCameraGuide.Image")));
            this.irisCameraGuide.Location = new System.Drawing.Point(5, 4);
            this.irisCameraGuide.Margin = new System.Windows.Forms.Padding(4);
            this.irisCameraGuide.Name = "irisCameraGuide";
            this.irisCameraGuide.Size = new System.Drawing.Size(678, 305);
            this.irisCameraGuide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.irisCameraGuide.TabIndex = 0;
            this.irisCameraGuide.TabStop = false;
            // 
            // registerDeviceState
            // 
            this.registerDeviceState.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.registerDeviceState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(134)))), ((int)(((byte)(76)))));
            this.registerDeviceState.Location = new System.Drawing.Point(264, 341);
            this.registerDeviceState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerDeviceState.Name = "registerDeviceState";
            this.registerDeviceState.Size = new System.Drawing.Size(111, 31);
            this.registerDeviceState.TabIndex = 7;
            this.registerDeviceState.Text = "设备未连接";
            this.registerDeviceState.Visible = false;
            // 
            // eyeLabel
            // 
            this.eyeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.eyeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.eyeLabel.Location = new System.Drawing.Point(39, 523);
            this.eyeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eyeLabel.Name = "eyeLabel";
            this.eyeLabel.Size = new System.Drawing.Size(262, 31);
            this.eyeLabel.TabIndex = 3;
            this.eyeLabel.Text = "采集眼别";
            // 
            // eyeCombo
            // 
            this.eyeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eyeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeCombo.Items.AddRange(new object[] {
            "双眼",
            "左眼",
            "右眼"});
            this.eyeCombo.Location = new System.Drawing.Point(43, 567);
            this.eyeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.eyeCombo.Name = "eyeCombo";
            this.eyeCombo.Size = new System.Drawing.Size(274, 28);
            this.eyeCombo.TabIndex = 4;
            // 
            // registrationState
            // 
            this.registrationState.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.registrationState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.registrationState.Location = new System.Drawing.Point(437, 519);
            this.registrationState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationState.Name = "registrationState";
            this.registrationState.Size = new System.Drawing.Size(275, 35);
            this.registrationState.TabIndex = 5;
            this.registrationState.Text = "注册状态：未注册";
            // 
            // qualityLabel
            // 
            this.qualityLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.qualityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.qualityLabel.Location = new System.Drawing.Point(437, 567);
            this.qualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(275, 35);
            this.qualityLabel.TabIndex = 6;
            this.qualityLabel.Text = "采集质量：—";
            // 
            // connectDeviceButton
            // 
            this.connectDeviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.connectDeviceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectDeviceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.connectDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectDeviceButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.connectDeviceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.connectDeviceButton.Location = new System.Drawing.Point(30, 639);
            this.connectDeviceButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectDeviceButton.Name = "connectDeviceButton";
            this.connectDeviceButton.Size = new System.Drawing.Size(200, 52);
            this.connectDeviceButton.TabIndex = 8;
            this.connectDeviceButton.Text = "连接设备";
            this.connectDeviceButton.UseVisualStyleBackColor = false;
            // 
            // startRegistrationButton
            // 
            this.startRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.startRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startRegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.startRegistrationButton.FlatAppearance.BorderSize = 0;
            this.startRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.startRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startRegistrationButton.Location = new System.Drawing.Point(248, 639);
            this.startRegistrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.startRegistrationButton.Name = "startRegistrationButton";
            this.startRegistrationButton.Size = new System.Drawing.Size(225, 52);
            this.startRegistrationButton.TabIndex = 9;
            this.startRegistrationButton.Text = "采集并注册";
            this.startRegistrationButton.UseVisualStyleBackColor = false;
            this.startRegistrationButton.Click += new System.EventHandler(this.startRegistrationButton_Click);
            // 
            // recaptureButton
            // 
            this.recaptureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recaptureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recaptureButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.recaptureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recaptureButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.recaptureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.recaptureButton.Location = new System.Drawing.Point(491, 639);
            this.recaptureButton.Margin = new System.Windows.Forms.Padding(4);
            this.recaptureButton.Name = "recaptureButton";
            this.recaptureButton.Size = new System.Drawing.Size(249, 52);
            this.recaptureButton.TabIndex = 10;
            this.recaptureButton.Text = "重新采集";
            this.recaptureButton.UseVisualStyleBackColor = false;
            // 
            // IrisRegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.findReaderCaption);
            this.Controls.Add(this.findReaderTextBox);
            this.Controls.Add(this.findReaderButton);
            this.Controls.Add(this.registerReadersGrid);
            this.Controls.Add(this.registerReaderCount);
            this.Controls.Add(this.registrationPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IrisRegistrationView";
            this.Size = new System.Drawing.Size(1312, 808);
            ((System.ComponentModel.ISupportInitialize)(this.registerReadersGrid)).EndInit();
            this.registrationPanel.ResumeLayout(false);
            this.cameraPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.irisCameraGuide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label pageTitle;

        private System.Windows.Forms.Label findReaderCaption;
        private System.Windows.Forms.TextBox findReaderTextBox;
        private System.Windows.Forms.Button findReaderButton;
        private System.Windows.Forms.DataGridView registerReadersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerReadersGridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerReadersGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerReadersGridState;

        private System.Windows.Forms.Label registerReaderCount;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Label selectedReader;
        private System.Windows.Forms.Label selectedReaderId;
        private System.Windows.Forms.Panel cameraPanel;
        private System.Windows.Forms.PictureBox irisCameraGuide;

        private System.Windows.Forms.Label eyeLabel;
        private System.Windows.Forms.ComboBox eyeCombo;
        private System.Windows.Forms.Label registrationState;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label registerDeviceState;
        private System.Windows.Forms.Button connectDeviceButton;
        private System.Windows.Forms.Button startRegistrationButton;
        private System.Windows.Forms.Button recaptureButton;
    }
}
