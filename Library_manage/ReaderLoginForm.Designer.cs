namespace Library_manage
{
    partial class ReaderLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderLoginForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.libraryLogo = new System.Windows.Forms.PictureBox();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.titleDivider = new System.Windows.Forms.Panel();
            this.capturePanel = new System.Windows.Forms.Panel();
            this.captureLabel = new System.Windows.Forms.Label();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.irisGuidePicture = new System.Windows.Forms.PictureBox();
            this.captureInstruction = new System.Windows.Forms.Label();
            this.connectDeviceButton = new System.Windows.Forms.Button();
            this.loginTitle = new System.Windows.Forms.Label();
            this.loginDescription = new System.Windows.Forms.Label();
            this.rightSeparator = new System.Windows.Forms.Panel();
            this.startRecognitionButton = new System.Windows.Forms.Button();
            this.retryRecognitionButton = new System.Windows.Forms.Button();
            this.adminEntryButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).BeginInit();
            this.capturePanel.SuspendLayout();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irisGuidePicture)).BeginInit();
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
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1350, 75);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseUp);
            // 
            // libraryLogo
            // 
            this.libraryLogo.Image = ((System.Drawing.Image)(resources.GetObject("libraryLogo.Image")));
            this.libraryLogo.Location = new System.Drawing.Point(30, 19);
            this.libraryLogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.applicationTitle.Size = new System.Drawing.Size(1100, 38);
            this.applicationTitle.TabIndex = 1;
            this.applicationTitle.Text = "图书借阅管理系统";
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
            this.minimizeButton.Location = new System.Drawing.Point(1212, 12);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.closeWindowButton.Location = new System.Drawing.Point(1272, 12);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.titleDivider.Margin = new System.Windows.Forms.Padding(4);
            this.titleDivider.Name = "titleDivider";
            this.titleDivider.Size = new System.Drawing.Size(1350, 1);
            this.titleDivider.TabIndex = 5;
            // 
            // capturePanel
            // 
            this.capturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(241)))));
            this.capturePanel.Controls.Add(this.captureLabel);
            this.capturePanel.Controls.Add(this.previewPanel);
            this.capturePanel.Controls.Add(this.connectDeviceButton);
            this.capturePanel.Location = new System.Drawing.Point(30, 105);
            this.capturePanel.Margin = new System.Windows.Forms.Padding(4);
            this.capturePanel.Name = "capturePanel";
            this.capturePanel.Size = new System.Drawing.Size(730, 615);
            this.capturePanel.TabIndex = 1;
            // 
            // captureLabel
            // 
            this.captureLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.captureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.captureLabel.Location = new System.Drawing.Point(25, 25);
            this.captureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureLabel.Name = "captureLabel";
            this.captureLabel.Size = new System.Drawing.Size(120, 38);
            this.captureLabel.TabIndex = 0;
            this.captureLabel.Text = "采集画面";
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previewPanel.Controls.Add(this.irisGuidePicture);
            this.previewPanel.Controls.Add(this.captureInstruction);
            this.previewPanel.Location = new System.Drawing.Point(25, 85);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(680, 500);
            this.previewPanel.TabIndex = 2;
            // 
            // irisGuidePicture
            // 
            this.irisGuidePicture.Image = ((System.Drawing.Image)(resources.GetObject("irisGuidePicture.Image")));
            this.irisGuidePicture.Location = new System.Drawing.Point(6, 4);
            this.irisGuidePicture.Margin = new System.Windows.Forms.Padding(4);
            this.irisGuidePicture.Name = "irisGuidePicture";
            this.irisGuidePicture.Size = new System.Drawing.Size(670, 319);
            this.irisGuidePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.irisGuidePicture.TabIndex = 0;
            this.irisGuidePicture.TabStop = false;
            // 
            // captureInstruction
            // 
            this.captureInstruction.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.captureInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.captureInstruction.Location = new System.Drawing.Point(-6, 391);
            this.captureInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureInstruction.Name = "captureInstruction";
            this.captureInstruction.Size = new System.Drawing.Size(680, 42);
            this.captureInstruction.TabIndex = 1;
            this.captureInstruction.Text = "请正视采集设备";
            this.captureInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectDeviceButton
            // 
            this.connectDeviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.connectDeviceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectDeviceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.connectDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectDeviceButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.connectDeviceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.connectDeviceButton.Location = new System.Drawing.Point(489, 18);
            this.connectDeviceButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectDeviceButton.Name = "connectDeviceButton";
            this.connectDeviceButton.Size = new System.Drawing.Size(216, 48);
            this.connectDeviceButton.TabIndex = 9;
            this.connectDeviceButton.Text = "连接设备";
            this.connectDeviceButton.UseVisualStyleBackColor = false;
            this.connectDeviceButton.Click += new System.EventHandler(this.connectDeviceButton_Click);
            // 
            // loginTitle
            // 
            this.loginTitle.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.loginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.loginTitle.Location = new System.Drawing.Point(822, 149);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(458, 60);
            this.loginTitle.TabIndex = 3;
            this.loginTitle.Text = "读者登录";
            // 
            // loginDescription
            // 
            this.loginDescription.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.loginDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.loginDescription.Location = new System.Drawing.Point(826, 234);
            this.loginDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginDescription.Name = "loginDescription";
            this.loginDescription.Size = new System.Drawing.Size(454, 50);
            this.loginDescription.TabIndex = 4;
            this.loginDescription.Text = "请正视设备，完成身份识别。";
            // 
            // rightSeparator
            // 
            this.rightSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.rightSeparator.Location = new System.Drawing.Point(826, 305);
            this.rightSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.rightSeparator.Name = "rightSeparator";
            this.rightSeparator.Size = new System.Drawing.Size(454, 1);
            this.rightSeparator.TabIndex = 5;
            // 
            // startRecognitionButton
            // 
            this.startRecognitionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.startRecognitionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startRecognitionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.startRecognitionButton.FlatAppearance.BorderSize = 0;
            this.startRecognitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRecognitionButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.startRecognitionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startRecognitionButton.Location = new System.Drawing.Point(826, 412);
            this.startRecognitionButton.Margin = new System.Windows.Forms.Padding(4);
            this.startRecognitionButton.Name = "startRecognitionButton";
            this.startRecognitionButton.Size = new System.Drawing.Size(454, 58);
            this.startRecognitionButton.TabIndex = 8;
            this.startRecognitionButton.Text = "开始识别（演示）";
            this.startRecognitionButton.UseVisualStyleBackColor = false;
            this.startRecognitionButton.Click += new System.EventHandler(this.startRecognitionButton_Click);
            // 
            // retryRecognitionButton
            // 
            this.retryRecognitionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.retryRecognitionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retryRecognitionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.retryRecognitionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retryRecognitionButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.retryRecognitionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.retryRecognitionButton.Location = new System.Drawing.Point(826, 491);
            this.retryRecognitionButton.Margin = new System.Windows.Forms.Padding(4);
            this.retryRecognitionButton.Name = "retryRecognitionButton";
            this.retryRecognitionButton.Size = new System.Drawing.Size(454, 48);
            this.retryRecognitionButton.TabIndex = 10;
            this.retryRecognitionButton.Text = "重新识别";
            this.retryRecognitionButton.UseVisualStyleBackColor = false;
            // 
            // adminEntryButton
            // 
            this.adminEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminEntryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.adminEntryButton.FlatAppearance.BorderSize = 0;
            this.adminEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminEntryButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.adminEntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.adminEntryButton.Location = new System.Drawing.Point(826, 654);
            this.adminEntryButton.Margin = new System.Windows.Forms.Padding(4);
            this.adminEntryButton.Name = "adminEntryButton";
            this.adminEntryButton.Size = new System.Drawing.Size(454, 45);
            this.adminEntryButton.TabIndex = 12;
            this.adminEntryButton.Text = "管理员入口  →";
            this.adminEntryButton.UseVisualStyleBackColor = false;
            this.adminEntryButton.Click += new System.EventHandler(this.AdminEntryButton_Click);
            // 
            // ReaderLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1350, 762);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.capturePanel);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.loginDescription);
            this.Controls.Add(this.rightSeparator);
            this.Controls.Add(this.startRecognitionButton);
            this.Controls.Add(this.retryRecognitionButton);
            this.Controls.Add(this.adminEntryButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReaderLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读者登录";
            this.Load += new System.EventHandler(this.ReaderLoginForm_Load);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).EndInit();
            this.capturePanel.ResumeLayout(false);
            this.previewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.irisGuidePicture)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox libraryLogo;
        private System.Windows.Forms.Label applicationTitle;

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Panel titleDivider;
        private System.Windows.Forms.Panel capturePanel;
        private System.Windows.Forms.Label captureLabel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.PictureBox irisGuidePicture;
        private System.Windows.Forms.Label captureInstruction;

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label loginDescription;
        private System.Windows.Forms.Panel rightSeparator;

        private System.Windows.Forms.Button startRecognitionButton;
        private System.Windows.Forms.Button connectDeviceButton;
        private System.Windows.Forms.Button retryRecognitionButton;

        private System.Windows.Forms.Button adminEntryButton;

    }
}
