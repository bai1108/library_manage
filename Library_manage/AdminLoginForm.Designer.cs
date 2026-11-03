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
            this.SuspendLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Size = new System.Drawing.Size(560, 60);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.TabIndex = 0;
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Controls.Add(this.titlePanel);
            this.libraryLogo = new System.Windows.Forms.PictureBox();
            this.libraryLogo.Location = new System.Drawing.Point(24, 15);
            this.libraryLogo.Size = new System.Drawing.Size(30, 30);
            this.libraryLogo.Name = "libraryLogo";
            this.libraryLogo.TabIndex = 0;
            this.libraryLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.libraryLogo.Image = ((System.Drawing.Image)(resources.GetObject("libraryLogo.Image")));
            this.libraryLogo.TabStop = false;
            this.titlePanel.Controls.Add(this.libraryLogo);
            this.applicationTitle = new System.Windows.Forms.Label();
            this.applicationTitle.Location = new System.Drawing.Point(68, 17);
            this.applicationTitle.Size = new System.Drawing.Size(360, 30);
            this.applicationTitle.Name = "applicationTitle";
            this.applicationTitle.TabIndex = 1;
            this.applicationTitle.Text = "图书借阅管理系统";
            this.applicationTitle.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            this.applicationTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.titlePanel.Controls.Add(this.applicationTitle);

            this.minimizeButton = new System.Windows.Forms.Button();
            this.minimizeButton.Location = new System.Drawing.Point(450, 10);
            this.minimizeButton.Size = new System.Drawing.Size(44, 40);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "—";
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 225, 218);
            this.minimizeButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.minimizeButton.FlatAppearance.BorderSize = 1;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.closeWindowButton.Location = new System.Drawing.Point(498, 10);
            this.closeWindowButton.Size = new System.Drawing.Size(44, 40);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.TabIndex = 4;
            this.closeWindowButton.Text = "×";
            this.closeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.closeWindowButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            this.closeWindowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindowButton.UseVisualStyleBackColor = false;
            this.closeWindowButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.titlePanel.Controls.Add(this.closeWindowButton);
            this.closeWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 225, 218);
            this.closeWindowButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.closeWindowButton.FlatAppearance.BorderSize = 1;
            this.closeWindowButton.FlatAppearance.BorderSize = 0;
            this.closeWindowButton.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.titleDivider = new System.Windows.Forms.Panel();
            this.titleDivider.Location = new System.Drawing.Point(0, 59);
            this.titleDivider.Size = new System.Drawing.Size(560, 1);
            this.titleDivider.Name = "titleDivider";
            this.titleDivider.TabIndex = 5;
            this.titleDivider.BackColor = System.Drawing.Color.FromArgb(225, 228, 222);
            this.titlePanel.Controls.Add(this.titleDivider);
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseUp);
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.closeWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);

            this.adminTitle = new System.Windows.Forms.Label();
            this.adminTitle.Location = new System.Drawing.Point(40, 99);
            this.adminTitle.Size = new System.Drawing.Size(480, 44);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.TabIndex = 3;
            this.adminTitle.Text = "管理员登录";
            this.adminTitle.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            this.adminTitle.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Bold);
            this.Controls.Add(this.adminTitle);
            this.accountCaption = new System.Windows.Forms.Label();
            this.accountCaption.Location = new System.Drawing.Point(40, 175);
            this.accountCaption.Size = new System.Drawing.Size(480, 25);
            this.accountCaption.Name = "accountCaption";
            this.accountCaption.TabIndex = 4;
            this.accountCaption.Text = "账号";
            this.accountCaption.ForeColor = System.Drawing.Color.FromArgb(120, 128, 122);
            this.accountCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular);
            this.Controls.Add(this.accountCaption);
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.accountTextBox.Location = new System.Drawing.Point(40, 211);
            this.accountTextBox.Size = new System.Drawing.Size(480, 34);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.TabIndex = 5;
            this.accountTextBox.Text = "";
            this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Controls.Add(this.accountTextBox);
            this.accountTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.passwordCaption = new System.Windows.Forms.Label();
            this.passwordCaption.Location = new System.Drawing.Point(40, 274);
            this.passwordCaption.Size = new System.Drawing.Size(480, 25);
            this.passwordCaption.Name = "passwordCaption";
            this.passwordCaption.TabIndex = 6;
            this.passwordCaption.Text = "密码";
            this.passwordCaption.ForeColor = System.Drawing.Color.FromArgb(120, 128, 122);
            this.passwordCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular);
            this.Controls.Add(this.passwordCaption);
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox.Location = new System.Drawing.Point(40, 310);
            this.passwordTextBox.Size = new System.Drawing.Size(480, 34);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.Controls.Add(this.passwordTextBox);
            this.passwordTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.adminLoginButton.Location = new System.Drawing.Point(40, 378);
            this.adminLoginButton.Size = new System.Drawing.Size(480, 44);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.TabIndex = 8;
            this.adminLoginButton.Text = "登录（演示）";
            this.adminLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginButton.BackColor = System.Drawing.Color.FromArgb(53, 100, 82);
            this.adminLoginButton.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.adminLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLoginButton.UseVisualStyleBackColor = false;
            this.adminLoginButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Controls.Add(this.adminLoginButton);
            this.adminLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(53, 100, 82);
            this.adminLoginButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.adminLoginButton.FlatAppearance.BorderSize = 0;
            this.backReaderButton = new System.Windows.Forms.Button();
            this.backReaderButton.Location = new System.Drawing.Point(40, 444);
            this.backReaderButton.Size = new System.Drawing.Size(480, 36);
            this.backReaderButton.Name = "backReaderButton";
            this.backReaderButton.TabIndex = 9;
            this.backReaderButton.Text = "返回读者登录";
            this.backReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backReaderButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.backReaderButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            this.backReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backReaderButton.UseVisualStyleBackColor = false;
            this.backReaderButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Controls.Add(this.backReaderButton);
            this.backReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 225, 218);
            this.backReaderButton.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.backReaderButton.FlatAppearance.BorderSize = 1;
            this.backReaderButton.FlatAppearance.BorderSize = 0;
            this.backReaderButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 241);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Name = "AdminLoginForm";
            this.ClientSize = new System.Drawing.Size(560, 510);
            this.Text = "管理员登录";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
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
