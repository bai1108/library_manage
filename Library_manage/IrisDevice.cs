using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using AxIRISINGFRAMEWORKLib;

namespace Library_manage
{
    // 仅在点击连接时创建ActiveX；设计器不创建控件、不读取设备或数据库。
    public sealed class IrisDevice : IDisposable
    {
        private AxIrisingFramework sdk;
        private Control host;
        private static IrisDevice owner;
        private DataTable models;
        private bool moduleStarted,disposed;
        private int operation,version,token;
        private static int nextToken;
        private IrisEnrollment enrollment;
        private string selectedEye;
        private Timer timeout;
        public event Action<string> Status;
        public event Action<string> Failed;
        public event Action<int> Identified;
        public event Action<IrisEnrollment> Enrolled;
        public bool Connected {get {return sdk!=null && moduleStarted && !disposed;}}
        public bool Busy {get {return operation!=0;}}
        [DllImport("kernel32.dll",CharSet=CharSet.Unicode,SetLastError=true)]private static extern bool SetDllDirectory(string path);

        private static void CheckHardware()
        {
            using(ManagementObjectSearcher search=new ManagementObjectSearcher("SELECT Name,PNPDeviceID,Present,ConfigManagerErrorCode FROM Win32_PnPEntity WHERE PNPDeviceID LIKE '%VID_1FC9&PID_000B%' OR PNPDeviceID LIKE '%VID_1CBE&PID_0003%' OR Name LIKE '%Irisian%' OR Name LIKE '%Irising%' OR Name LIKE '%Iris Camera%' OR Name LIKE '%虹膜%'"))
            using(ManagementObjectCollection devices=search.Get())
            {
                bool driverError=false;
                foreach(ManagementObject device in devices)
                {
                    if(device["Present"]!=null && !Convert.ToBoolean(device["Present"]))continue;
                    if(device["ConfigManagerErrorCode"]!=null && Convert.ToInt32(device["ConfigManagerErrorCode"])!=0){driverError=true;continue;}
                    return;
                }
                if(driverError)throw new Exception("检测到虹膜设备，但USB驱动异常，请检查设备管理器。");
            }
            throw new Exception("未检测到虹膜采集仪，请连接设备并检查USB驱动。");
        }

        public void Connect(Control preview)
        {
            if(Connected)return;
            if(ScreenData.IsDesignMode(preview))throw new Exception("设计模式不能连接设备。");
            if(IntPtr.Size!=4)throw new Exception("此虹膜 SDK 为32位，请使用项目的 x86 配置运行。");
            if(owner!=null && owner!=this)throw new Exception("虹膜设备正在其他页面使用，请先结束当前操作。");
            CheckHardware();
            disposed=false;host=preview;owner=this;
            try {
                string directory;
                using(RegistryKey root=RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot,RegistryView.Registry32))
                using(RegistryKey key=root.OpenSubKey(@"CLSID\{5713A78B-4D81-43EC-8B7F-CDC2BC1E1080}\InprocServer32"))
                {
                    if(key==null)throw new Exception("未安装或未注册 Irising0338 SDK，请先运行提供的SDK安装程序。");
                    directory=Path.GetDirectoryName(Convert.ToString(key.GetValue(null)));
                }
                if(!SetDllDirectory(directory))throw new Exception("无法设置虹膜 SDK 依赖目录。");
                int width=Math.Max(80,Math.Min(220,(preview.ClientSize.Width-8)/2));width-=width%20;
                sdk=new AxIrisingFramework();((ISupportInitialize)sdk).BeginInit();
                sdk.Size=new Size(width*2,width*3/4);sdk.Location=new Point(Math.Max(0,(preview.Width-sdk.Width)/2),Math.Max(0,(preview.Height-sdk.Height)/2));
                preview.Controls.Add(sdk);((ISupportInitialize)sdk).EndInit();sdk.CreateControl();sdk.BringToFront();
                sdk.EnrollStateCallback+=OnEnroll;sdk.IdentifyStateCallback+=OnIdentify;
                // 低位1：不保存注册原始图像，库中只保存特征模板。
                int result=sdk.ModuleLoad(width+1);moduleStarted=result==0;
                if(result!=0)throw new Exception(result==-1?"未检测到虹膜采集仪，请连接设备并检查USB驱动。":result==-2?"SDK 未激活或设备型号不匹配。":"设备初始化未完成，返回码："+result);
                sdk.ModulePropSet(6,0);sdk.ModulePropSet(4,0);sdk.ModulePropSet(3,0);
                timeout=new Timer();timeout.Interval=45000;timeout.Tick+=delegate {Fail("采集或识别超时，请调整位置后重试。");};
                Notify("设备已连接");
            }catch{Dispose();throw;}
        }
        private void Notify(string text) {if(Status!=null)Status(text);}
        private void Queue(Action action,int ticket)
        {
            if(disposed || host==null || host.IsDisposed || !host.IsHandleCreated)return;
            try {
                host.BeginInvoke(new Action(delegate {
                    if(disposed || ticket!=version)return;
                    try{action();}catch(Exception ex){Fail("虹膜操作未完成："+ex.Message);}
                }));
            }catch(InvalidOperationException){ /* 窗口已关闭，忽略迟到回调。 */ }
        }
        public void LoadTemplates(bool allReaders=false)
        {
            if(!Connected)throw new Exception("请先连接设备。");
            sdk.IdentifyStop();models=null;
            DataTable data=IrisService.Templates(allReaders);int length=sdk.IRISCODELENGTH;
            if(length<256 || length>65536)throw new Exception("SDK 返回了无效的模板长度。");
            if(data.Rows.Count==0){sdk.IrisCodeAttach(0,0);models=data;return;}
            byte[] codes=new byte[checked(data.Rows.Count*length)];
            for(int i=0;i<data.Rows.Count;i++)
            {
                byte[] code=(byte[])data.Rows[i]["TemplateData"];
                if(code.Length!=length)throw new Exception("数据库中存在不兼容的虹膜编码，请由管理员重新注册对应模板。");
                Buffer.BlockCopy(code,0,codes,i*length,length);
            }
            GCHandle pin=GCHandle.Alloc(codes,GCHandleType.Pinned);
            try {int loaded=sdk.IrisCodeAttach(pin.AddrOfPinnedObject().ToInt32(),data.Rows.Count);if(loaded!=data.Rows.Count)throw new Exception("SDK拒绝了第"+loaded+"条虹膜模板，未开始识别。");}
            finally{pin.Free();}
            models=data;
        }
        public void Identify()
        {
            if(!Connected)throw new Exception("请先连接设备。");if(Busy)throw new Exception("设备正在采集中。");
            LoadTemplates();if(models.Rows.Count==0)throw new Exception("还没有有效的虹膜模板，请先到管理端注册。");
            version++;operation=1;timeout.Start();
            try{int result=sdk.IdentifyMatch();if(result!=0)throw new Exception("启动识别失败，返回码："+result);Notify("正在识别，请正视设备");}catch{Cancel();throw;}
        }
        public void Enroll(string reader,string eye)
        {
            if(!Connected)throw new Exception("请先连接设备。");if(Busy)throw new Exception("设备正在采集中。");
            if(eye!="L" && eye!="R" && eye!="B")throw new Exception("请选择注册眼别。");
            LoadTemplates(true);sdk.ModulePropSet(1,eye=="L"?1:eye=="R"?2:0);sdk.ModulePropSet(2,60);
            version++;token=(System.Threading.Interlocked.Increment(ref nextToken)&int.MaxValue)%999999+1;selectedEye=eye;enrollment=new IrisEnrollment{ReaderID=reader,CodeLength=sdk.IRISCODELENGTH};operation=2;timeout.Start();
            try{int result=sdk.Enroll(token);if(result!=0)throw new Exception("启动注册失败，返回码："+result);Notify("正在采集，请保持眼睛正视设备");}catch{Cancel();throw;}
        }
        private void OnIdentify(object sender,_DIrisingFrameworkEvents_IdentifyStateCallbackEvent e)
        {
            if(operation!=1)return;int ticket=version;operation=0;timeout.Stop();
            int index=e.identifyUser,quality=e.responseState & 65535;
            if(index<0 || ((e.responseState>>16)&65535)>1 || quality<=50 || models==null || index>=models.Rows.Count)
            {Queue(delegate {Fail(index==-2?"虹膜摄像头故障，请重新连接。":"未识别到有效读者，请调整位置后重试。");},ticket);return;}
            int template=Convert.ToInt32(models.Rows[index]["TemplateID"]);
            Queue(delegate {sdk.IdentifyStop();if(Identified!=null)Identified(template);},ticket);
        }
        private void OnEnroll(object sender,_DIrisingFrameworkEvents_EnrollStateCallbackEvent e)
        {
            if(operation!=2)return;int ticket=version;
            try {
                int state=e.responseState;int eye=(state>>16)&65535,duplicate=(state>>8)&255,quality=state&255;
                if(eye>1 || e.enrollUser<0 || quality<60 || quality>100)throw new Exception(quality==2?"注册超时，请重新采集。":"采集质量不足，请重新采集。");
                string side=eye==0?"L":"R";
                if(selectedEye!="B" && selectedEye!=side)throw new Exception("采集返回眼别与选择不一致，未保存。");
                if(duplicate>0)
                {
                    if(models==null || e.enrollUser>=models.Rows.Count || models.Rows[e.enrollUser]["ReaderID"].ToString()!=enrollment.ReaderID || models.Rows[e.enrollUser]["EyeSide"].ToString()!=side)throw new Exception("该虹膜已绑定其他读者或眼别，不能重复注册。");
                }
                else if(e.enrollUser!=token)throw new Exception("注册回调与当前采集不匹配，未保存。");
                if(e.irisCode==0)throw new Exception("SDK没有返回有效特征模板。");
                // 必须在回调返回前复制指针内容；回调内不再调用其他SDK方法。
                byte[] code=new byte[enrollment.CodeLength];Marshal.Copy(new IntPtr(e.irisCode),code,0,code.Length);
                enrollment.Codes[side]=code;enrollment.Quality[side]=quality;
                bool complete=selectedEye!="B" || (enrollment.Codes.ContainsKey("L") && enrollment.Codes.ContainsKey("R"));
                if(complete)
                {
                    operation=0;timeout.Stop();IrisEnrollment result=enrollment;enrollment=null;
                    Queue(delegate {sdk.IdentifyStop();if(Enrolled!=null)Enrolled(result);},ticket);
                }
                else Queue(delegate {Notify((side=="L"?"左眼":"右眼")+"采集完成，请继续采集另一只眼");},ticket);
            }catch(Exception ex){operation=0;timeout.Stop();string message=ex.Message;Queue(delegate {Fail(message);},ticket);}
        }
        private void Fail(string message) {try{Cancel();}catch(Exception){message+=" 请重新连接设备。";}if(Failed!=null)try{Failed(message);}catch(Exception ex){System.Diagnostics.Trace.WriteLine("虹膜失败提示未完成："+ex.GetType().Name);}}
        public void Cancel()
        {
            version++;operation=0;enrollment=null;if(timeout!=null)timeout.Stop();
            if(sdk!=null && moduleStarted)sdk.IdentifyStop();
        }
        public void Dispose()
        {
            if(disposed)return;bool running=operation!=0;disposed=true;version++;operation=0;enrollment=null;
            AxIrisingFramework control=sdk;sdk=null;bool loaded=moduleStarted;moduleStarted=false;
            try {
                if(timeout!=null){timeout.Stop();timeout.Dispose();timeout=null;}
                if(control!=null)
                {
                    control.EnrollStateCallback-=OnEnroll;control.IdentifyStateCallback-=OnIdentify;
                    if(loaded)
                    {
                        if(running)try{control.IdentifyStop();}catch(Exception ex){System.Diagnostics.Trace.WriteLine("虹膜停止失败："+ex.GetType().Name);}
                        try{control.ModuleUnload();}catch(Exception ex){System.Diagnostics.Trace.WriteLine("虹膜卸载失败："+ex.GetType().Name);}
                    }
                }
            }
            finally {
                try {if(control!=null)control.Dispose();}
                catch(Exception ex){System.Diagnostics.Trace.WriteLine("虹膜控件释放失败："+ex.GetType().Name);}
                finally {models=null;host=null;if(owner==this){owner=null;SetDllDirectory(null);}}
            }
        }
    }
}
