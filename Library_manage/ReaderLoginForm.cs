using System.Data.SqlClient;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_manage
{
    public partial class ReaderLoginForm : Form
    {
        public ReaderLoginForm()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this)) InitializeData();
        }

        private void ReaderLoginForm_Load(object sender, EventArgs e)
        {

        }

        private bool movingWindow;
        private System.Drawing.Point moveStart;
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e) { if(e.Button == MouseButtons.Left) { movingWindow = true; moveStart = e.Location; titlePanel.Capture = true; } }
        private void TitlePanel_MouseMove(object sender, MouseEventArgs e) { if(movingWindow) Location = new System.Drawing.Point(Location.X + e.X - moveStart.X, Location.Y + e.Y - moveStart.Y); }
        private void TitlePanel_MouseUp(object sender, MouseEventArgs e) { movingWindow = false; titlePanel.Capture = false; }
        private void MinimizeButton_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; }
        private void CloseWindowButton_Click(object sender, EventArgs e) { Close(); }

        private void AdminEntryButton_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            this.Hide();
            form.ShowDialog();
            form.Dispose();
            this.Show();
        }

        private void startRecognitionButton_Click(object sender, EventArgs e)
        {
            NoDevice();
        }

        private void connectDeviceButton_Click(object sender, EventArgs e)
        {

        }
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            startRecognitionButton.Text="开始虹膜识别";
            connectDeviceButton.Click+=delegate {NoDevice();};
            retryRecognitionButton.Click+=delegate {NoDevice();};
        }
        private void NoDevice() {MessageBox.Show("尚未接入虹膜设备 SDK，不能采集或验证身份。\n可由管理员核对读者后，在读者管理中选择“核验后借还”。","虹膜设备");}
    }
}
