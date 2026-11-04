using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library_manage
{
    public partial class ReaderLoginForm
    {
        private IrisDevice loginDevice;
        private bool openingReader;
        private void ToggleIrisConnection()
        {
            if(loginDevice!=null && loginDevice.Connected)
            {
                IrisService.EndSession();
                CloseLoginDevice();
                captureInstruction.Text="设备已断开，请重新连接后识别。";
            }
            else ConnectIris();
        }
        private void ConnectIris()
        {
            try {
                if(loginDevice==null)
                {
                    loginDevice=new IrisDevice();
                    loginDevice.Status+=delegate(string s){captureInstruction.Text=s;};
                    loginDevice.Failed+=delegate(string s){IrisService.EndSession();captureInstruction.Text=s;startRecognitionButton.Enabled=true;retryRecognitionButton.Enabled=true;};
                    loginDevice.Identified+=OpenIdentifiedReader;
                }
                loginDevice.Connect(previewPanel);irisGuidePicture.Visible=false;captureInstruction.BringToFront();
                connectDeviceButton.Text="断开连接";
            }catch {CloseLoginDevice();throw;}
        }
        private void StartIris()
        {
            ScreenData.Run(delegate {
                IrisService.EndSession();ConnectIris();loginDevice.Identify();
                startRecognitionButton.Enabled=false;retryRecognitionButton.Enabled=false;
            });
        }
        private void CloseLoginDevice()
        {
            IrisDevice previous=loginDevice;loginDevice=null;if(previous!=null)previous.Dispose();
            irisGuidePicture.Visible=true;connectDeviceButton.Text="连接设备";
            startRecognitionButton.Enabled=true;retryRecognitionButton.Enabled=true;
        }
        private void OpenIdentifiedReader(int template)
        {
            if(openingReader)return;openingReader=true;
            try {
                string reader=IrisService.BeginSession(template);
                CloseLoginDevice();Hide();
                using(BorrowForm f=new BorrowForm(reader))f.ShowDialog();
            }catch(Exception ex){MessageBox.Show(ex.Message,"读者识别");}
            finally {CloseLoginDevice();IrisService.EndSession();openingReader=false;if(!IsDisposed){Show();captureInstruction.Text="请正视采集设备";}}
        }
    }

    public class IrisTestForm : Form
    {
        private IrisDevice device;
        public IrisTestForm()
        {
            Text="虹膜设备测试";ClientSize=new Size(500,300);StartPosition=FormStartPosition.CenterParent;
            Panel preview=new Panel{Dock=DockStyle.Fill,BackColor=Color.White};Label state=new Label{Dock=DockStyle.Bottom,Height=40,Text="正在连接设备…",TextAlign=ContentAlignment.MiddleCenter};Controls.Add(preview);Controls.Add(state);
            Shown+=delegate {try {device=new IrisDevice();device.Status+=delegate(string s){state.Text=s;};device.Connect(preview);}catch(Exception ex){state.Text=ex.Message;}};
            FormClosed+=delegate {if(device!=null)device.Dispose();};
        }
    }
}

namespace Library_manage.Views
{
    public partial class IrisRegistrationView
    {
        private IrisDevice registrationDevice;
        private void ToggleRegistrationConnection()
        {
            if(registrationDevice!=null && registrationDevice.Connected)
            {
                bool collecting=registrationDevice.Busy;
                CloseRegistrationDevice();
                registerDeviceState.Text=collecting?"设备已断开，本次采集已取消，未保存模板。":"设备已断开。";
                qualityLabel.Text="采集质量：—";
            }
            else ConnectRegistration();
        }
        private void ConnectRegistration()
        {
            Database.RequireAdmin();
            try {
                if(registrationDevice==null)
                {
                    registrationDevice=new IrisDevice();
                    registrationDevice.Status+=delegate(string s){registerDeviceState.Text=s;};
                    registrationDevice.Failed+=delegate(string s){registerDeviceState.Text=s;UnlockRegistration();};
                    registrationDevice.Enrolled+=SaveIris;
                }
                registrationDevice.Connect(cameraPanel);irisCameraGuide.Visible=false;connectDeviceButton.Text="断开连接";
            }catch{CloseRegistrationDevice();throw;}
        }
        private void StartRegistration()
        {
            ScreenData.Run(delegate {
                Database.RequireAdmin();DataRow row=ScreenData.Need(registerReadersGrid);string reader=row["ReaderID"].ToString();
                if(MessageBox.Show("请核对读者："+row["ReaderName"]+"（"+reader+"）\n确认采集并保存虹膜特征模板？","虹膜注册",MessageBoxButtons.OKCancel)!=DialogResult.OK)return;
                ConnectRegistration();string eye=eyeCombo.Text=="左眼"?"L":eyeCombo.Text=="右眼"?"R":"B";
                registrationDevice.Enroll(reader,eye);
                registerReadersGrid.Enabled=false;eyeCombo.Enabled=false;findReaderButton.Enabled=false;startRegistrationButton.Enabled=false;
                qualityLabel.Text="采集质量：等待回调";
            });
        }
        private void UnlockRegistration()
        {
            registerReadersGrid.Enabled=true;eyeCombo.Enabled=true;findReaderButton.Enabled=true;startRegistrationButton.Enabled=true;
        }
        private void SaveIris(IrisEnrollment result)
        {
            try {
                IrisService.SaveRegistration(result);
                string quality="";foreach(var pair in result.Quality)quality+=(pair.Key=="L"?"左眼":"右眼")+pair.Value+" ";
                qualityLabel.Text="采集质量："+quality;registrationState.Text="注册状态：已保存";registerDeviceState.Text="虹膜注册成功，模板已保存到数据库。";
                SelectReader(result.ReaderID);
            }catch(Exception ex){registerDeviceState.Text="注册未保存："+ex.Message;MessageBox.Show(ex.Message,"虹膜注册");}
            finally{CloseRegistrationDevice();}
        }
        private void CloseRegistrationDevice()
        {
            IrisDevice previous=registrationDevice;registrationDevice=null;if(previous!=null)previous.Dispose();
            irisCameraGuide.Visible=true;connectDeviceButton.Text="连接设备";UnlockRegistration();
        }
    }
}
