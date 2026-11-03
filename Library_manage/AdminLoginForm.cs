using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this))
            {
                InitializeData();
            }
        }

        private bool movingWindow;
        private System.Drawing.Point moveStart;
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e) { if(e.Button == MouseButtons.Left) { movingWindow = true; moveStart = e.Location; titlePanel.Capture = true; } }
        private void TitlePanel_MouseMove(object sender, MouseEventArgs e) { if(movingWindow) Location = new System.Drawing.Point(Location.X + e.X - moveStart.X, Location.Y + e.Y - moveStart.Y); }
        private void TitlePanel_MouseUp(object sender, MouseEventArgs e) { movingWindow = false; titlePanel.Capture = false; }
        private void MinimizeButton_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void CloseWindowButton_Click(object sender, EventArgs e) { Close(); }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            adminLoginButton.Text="登录";
            adminTitle.Text="管理员登录";
        }
        private void SignIn()
        {
            ScreenData.Run(delegate {
                Database.Login(accountTextBox.Text.Trim(),passwordTextBox.Text);
                passwordTextBox.Clear();Hide();
                try {using(ManageForm f=new ManageForm())f.ShowDialog();}
                finally {Database.AdminID=0;Database.AdminRole=null;Close();}
            });
        }
    }
}
