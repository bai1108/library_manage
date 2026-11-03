using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage
{
    public partial class ManageForm : Form
    {
        public ManageForm()
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

        public void ShowPage(int index)
        {
            if (index < 0 || index > 4) return;

            // 先隐藏全部页面，并恢复菜单颜色。
            readerManagementView.Visible = false;
            irisRegistrationView.Visible = false;
            bookManagementView.Visible = false;
            statisticsView.Visible = false;
            settingsView.Visible = false;
            readerNavButton.BackColor = System.Drawing.Color.FromArgb(239, 241, 235);
            readerNavButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            irisNavButton.BackColor = System.Drawing.Color.FromArgb(239, 241, 235);
            irisNavButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            bookNavButton.BackColor = System.Drawing.Color.FromArgb(239, 241, 235);
            bookNavButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            statisticsNavButton.BackColor = System.Drawing.Color.FromArgb(239, 241, 235);
            statisticsNavButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);
            settingsNavButton.BackColor = System.Drawing.Color.FromArgb(239, 241, 235);
            settingsNavButton.ForeColor = System.Drawing.Color.FromArgb(43, 52, 48);

            // 显示选中的页面。
            if (index == 0)
            {
                readerManagementView.Visible = true;
                readerManagementView.BringToFront();
                readerNavButton.BackColor = System.Drawing.Color.FromArgb(235, 242, 236);
                readerNavButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            }
            if (index == 1)
            {
                irisRegistrationView.Visible = true;
                irisRegistrationView.BringToFront();
                irisNavButton.BackColor = System.Drawing.Color.FromArgb(235, 242, 236);
                irisNavButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            }
            if (index == 2)
            {
                bookManagementView.Visible = true;
                bookManagementView.BringToFront();
                bookNavButton.BackColor = System.Drawing.Color.FromArgb(235, 242, 236);
                bookNavButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            }
            if (index == 3)
            {
                statisticsView.Visible = true;
                statisticsView.BringToFront();
                statisticsNavButton.BackColor = System.Drawing.Color.FromArgb(235, 242, 236);
                statisticsNavButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            }
            if (index == 4)
            {
                settingsView.Visible = true;
                settingsView.BringToFront();
                settingsNavButton.BackColor = System.Drawing.Color.FromArgb(235, 242, 236);
                settingsNavButton.ForeColor = System.Drawing.Color.FromArgb(53, 100, 82);
            }

            readerNavButtonIcon.BackColor = readerNavButton.BackColor;
            irisNavButtonIcon.BackColor = irisNavButton.BackColor;
            bookNavButtonIcon.BackColor = bookNavButton.BackColor;
            statisticsNavButtonIcon.BackColor = statisticsNavButton.BackColor;
            settingsNavButtonIcon.BackColor = settingsNavButton.BackColor;
        }
        private void readerNavButton_Click(object sender, EventArgs e) { ShowPage(0); }
        private void irisNavButton_Click(object sender, EventArgs e) { ShowPage(1); }
        private void bookNavButton_Click(object sender, EventArgs e) { ShowPage(2); }
        private void statisticsNavButton_Click(object sender, EventArgs e) { ShowPage(3); }
        private void settingsNavButton_Click(object sender, EventArgs e) { ShowPage(4); }
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            Load+=delegate {if(!ScreenData.IsDesignMode(this))ScreenData.Run(delegate {Database.RequireAdmin();ShowPage(0);});};
        }
        public void OpenRegistration(string reader) {ShowPage(1);irisRegistrationView.SelectReader(reader);}
    }
}
