namespace Library_manage
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.libraryLogo = new System.Windows.Forms.PictureBox();
            this.applicationTitle = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.titleDivider = new System.Windows.Forms.Panel();
            this.adminTitle = new System.Windows.Forms.Label();
            this.accountCaption = new System.Windows.Forms.Label();
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.passwordCaption = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.backReaderButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).BeginInit();
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
            this.titlePanel.Size = new System.Drawing.Size(700, 75);
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
            this.applicationTitle.Size = new System.Drawing.Size(450, 38);
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
            this.minimizeButton.Location = new System.Drawing.Point(562, 12);
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
            this.closeWindowButton.Location = new System.Drawing.Point(622, 12);
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
            this.titleDivider.Size = new System.Drawing.Size(700, 1);
            this.titleDivider.TabIndex = 5;
            // 
            // adminTitle
            // 
            this.adminTitle.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Bold);
            this.adminTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.adminTitle.Location = new System.Drawing.Point(247, 125);
            this.adminTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(222, 55);
            this.adminTitle.TabIndex = 3;
            this.adminTitle.Text = "管理员登录";
            // 
            // accountCaption
            // 
            this.accountCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.accountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.accountCaption.Location = new System.Drawing.Point(50, 219);
            this.accountCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountCaption.Name = "accountCaption";
            this.accountCaption.Size = new System.Drawing.Size(600, 31);
            this.accountCaption.TabIndex = 4;
            this.accountCaption.Text = "账号";
            // 
            // accountTextBox
            // 
            this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.accountTextBox.Location = new System.Drawing.Point(50, 264);
            this.accountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(600, 31);
            this.accountTextBox.TabIndex = 5;
            // 
            // passwordCaption
            // 
            this.passwordCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.passwordCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.passwordCaption.Location = new System.Drawing.Point(50, 342);
            this.passwordCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordCaption.Name = "passwordCaption";
            this.passwordCaption.Size = new System.Drawing.Size(600, 31);
            this.passwordCaption.TabIndex = 6;
            this.passwordCaption.Text = "密码";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.passwordTextBox.Location = new System.Drawing.Point(50, 388);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(600, 31);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.adminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.adminLoginButton.FlatAppearance.BorderSize = 0;
            this.adminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.adminLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminLoginButton.Location = new System.Drawing.Point(50, 472);
            this.adminLoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(600, 55);
            this.adminLoginButton.TabIndex = 8;
            this.adminLoginButton.Text = "登录（演示）";
            this.adminLoginButton.UseVisualStyleBackColor = false;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // backReaderButton
            // 
            this.backReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.backReaderButton.FlatAppearance.BorderSize = 0;
            this.backReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.backReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.backReaderButton.Location = new System.Drawing.Point(50, 555);
            this.backReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backReaderButton.Name = "backReaderButton";
            this.backReaderButton.Size = new System.Drawing.Size(600, 45);
            this.backReaderButton.TabIndex = 9;
            this.backReaderButton.Text = "返回读者登录";
            this.backReaderButton.UseVisualStyleBackColor = false;
            this.backReaderButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(700, 638);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.accountCaption);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.passwordCaption);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.backReaderButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录";
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox libraryLogo;
        private System.Windows.Forms.Label applicationTitle;

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Panel titleDivider;

        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.Label accountCaption;
        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.Label passwordCaption;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.Button backReaderButton;
    }
}
