using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using RexConst;
using System.Drawing;
using VisionCore;
using DockContrl;
using RexHelps;
using System.Diagnostics;
using System.Threading.Tasks;
using Rex.UI;
using System.Runtime.InteropServices;

namespace RexVision
{
    public partial class FormMain : DockForm
    {
        public static event SetEComDg SetEComEvent;
        /// <summary>开始</summary>
        public static DateTime RunStartTime = DateTime.Now;
        /// <summary>主父窗体</summary>
        private FrmShow mMainShow = null;
        /// <summary>子窗体集合</summary>
        private List<Form> mFormList = new List<Form>();
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowUIForm();
            OpenProj("AutoStart");
            //RunMemoryCPU();
            ShowMsg.ShowRImageEvent += ShowImgae;
        }
        private void ShowUIForm()
        {
            try
            {
                mMainShow = new FrmShow();
                mFormList.Add(mMainShow);
                foreach (Form form in mFormList)
                {
                    form.TopLevel = false;
                    MainPanel.Controls.Add(form);
                    form.Show();
                }
                mMainShow.Dock = DockStyle.Fill;
                mMainShow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        protected void ShowImgae(string name, RImage image)
        {   if(image!=null)
            if (image.Screen <= 0) return;
            mMainShow?.Invoke(new Action(() => { mMainShow.ScreenShow(image); }));
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Sol.mSol != null)
            {
                if (!Sol.mProjSave)
                {
                    if (MessageBox.Show("当前项目未保存,是否关闭?", "消息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        IsClose = true;
                        Sol.mSol.CloseProj();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            System.Environment.Exit(0);
        }
        private void ToolStripMenuSet_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbt = sender as ToolStripButton;
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            if (tsbt != null)
            {
                switch (tsbt.Text)
                {
                    case "解决方案":
                        VisionSet mSolSetForm = new VisionSet();
                        mSolSetForm.Show();
                        break;
                }
            }
            if (tsmi != null)
            {
                switch (tsmi.Text)
                {
                    case "系统设置":
                        VisionSet mSolSetForm = new VisionSet();
                        mSolSetForm.Show();
                        break;
                    case "画布设置":
                        if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
                        CanvasSet mShowFormSet = new CanvasSet(Sol.mSol.mScreenNum);
                        mShowFormSet.ShowDialog();
                        if (mShowFormSet.NewQty >= 0)
                        {
                            Sol.mSol.mScreenNum = mShowFormSet.NewQty;
                            mMainShow.CanvasSet(mShowFormSet.NewQty);
                        }
                        break;
                    case "关于RexVision":
                        FrmAbout m_FrmAbout = new FrmAbout();
                        m_FrmAbout.ShowDialog();
                        break;
                }
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsbt = sender as ToolStripMenuItem;
            mMainShow.ShowUI(tsbt.Text);
        }
        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton tsbt = sender as ToolStripButton;
            if (Sol.mSol == null)
            {
                bool IsNewOpen = tsbt.Text.Contains("新建项目") || tsbt.Text.Contains("打开项目");
                if (!IsNewOpen)
                {
                    MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            switch (tsbt.Text)
            {
                case "新建项目":
                    新建项目ToolStripMenuItem_Click(null, null);
                    break;
                case "打开项目":
                    打开项目ToolStripMenuItem_Click(null, null);
                    break;
                case "保存项目":
                    mSaveFile.FileName = Sol.mSol.Name + ".RV";
                    if (mSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                            Sol.mSavePath = mSaveFile.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    break;
                case "系统变量":
                    VarSet mVarSetForm = new VarSet(Sol.mSol.mSysVar);
                    mVarSetForm.ShowDialog();
                    break;
                case "通讯设置":
                    NetSet mCommunicationSet = new NetSet(Sol.mSol.mEComList);
                    mCommunicationSet.ShowDialog();
                    break;
                case "相机设置":
                    CameraSet mCameraFormSet = new CameraSet();
                    CameraSet.mCamerasList = Sol.mSol.mCamerasList;
                    mCameraFormSet.ShowDialog();
                    break;
                case "用户登录":
                    break;
                case "单次运行":
                    Sol.OnceRun();
                    break;
                case "循环运行":
                    Sol.StartRun();
                    break;
                case "停止运行":
                    Sol.StopRun();
                    break;
            }
        }
        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEComEvent(null, EComType.Clear);
            CreateProj();
        }
        private void 打开项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mOpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    VisionSet.mRini.WriteValue("Config", "mSavePath", mOpenFile.FileName);
                    OpenProj("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void 项目另存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sol.mSol != null)
            {
                mSaveFile.FileName = Sol.mSol.Name + ".RV";
                if (mSaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Sol.mSavePath = mSaveFile.FileName;
                        Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        public void CreateProj()
        {
            if (Sol.mSol == null)
            {
                Sol.mSol = new Sol();
                Sol.mSol.mScreenNum = 0;
            }
            else
            {
                if (MessageBox.Show("是否保存当前项目?", "消息", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (mSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            Sol.mSavePath = mSaveFile.FileName;
                            Sol.SaveData(mSaveFile.FileName, Sol.mSol);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                Sol.mSol.Dispose();
                Sol.mSol = new Sol();
                Sol.mSol.mScreenNum = 0;
            }
            if (Sol.mSol != null)
            {
                mMainShow.SetProj();
                mMainShow.CanvasSet(Sol.mSol.mScreenNum);
            }
        }
        private void OpenProj(string msg)
        {
            Sol.mSavePath = VisionSet.mRini.ReadValue("Config", "mSavePath", "");
            if (Sol.mSol != null)
            {
                Sol.mSol.CloseProj();
                SetEComEvent(null, EComType.Clear);
            }
            Sol.IsStop = true;
            Sol.mSol = Sol.ReadData(Sol.mSavePath);
            if (Sol.mSol != null)
            {
                Sol.mSol.InitCameraStatus();
                mMainShow.SetProj();
                mMainShow.CanvasSet(Sol.mSol.mScreenNum);
                if (bool.Parse(VisionSet.mRini.ReadValue("Config", "mAutoStart", "false")))
                {
                    if (msg.Equals("AutoStart"))
                    {
                        if (Sol.mSol.mProjList.Count>0& Sol.mSol.mProjList[0].mObjBase.Count>0)
                        {
                            Sol.StartRun();
                        }
                    }
                }
            }
        }

        //TODO:获取进程----------------------------------------------------------------------------------------------------------------------------------------
        bool IsClose = false;
        private async void RunMemoryCPU()
        {
            TimeSpan RunTime = new TimeSpan();
            Process CurrentProcess = Process.GetProcessesByName("RexVision")[0];
            var CurrentProcessName = Process.GetCurrentProcess().ProcessName;
            var CurrentProcessCpu = new PerformanceCounter("Process", "% Processor Time", CurrentProcessName);
            var TotalCurrentCpu = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            var CurrentProcessMemory = new PerformanceCounter("Process", "Working Set - Private", CurrentProcessName);
            await Task.Run(async () =>
            {
                while (!IsClose)
                {
                    await Task.Delay(5000);
                    try
                    {
                        BeginInvoke(new Action(() =>
                        {
                            RunTime += DateTime.Now - RunStartTime;
                            RunStartTime = DateTime.Now;
                            ts_RunTime.Text = string.Format("运行:{0}H", RunTime.TotalHours.ToString("F2"));
                            tS_time.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss ") + GetWeekName();
                            Run_CPU.Text = "CPU:" + (CurrentProcessCpu.NextValue() / Environment.ProcessorCount).ToString("F2") + " %";
                            Run_Memory.Text = "内存:" + (CurrentProcessMemory.NextValue() / 1024 / 1024).ToString("F2") + " MB";
                            ts_ProjPath.Text = Sol.mSavePath;
                            ts_Drive.Text="D盘："+(int)(((double)(RDrive.GetHardDiskFreeSpace("D") / 1024 / 1024 / 1024) / (double)(RDrive.GetHardDiskSpace("D") / 1024 / 1024 / 1024)) * 100)+"%";
                        }));
                    }
                    catch (Exception ex)
                    {
                        Run_CPU.Text = "0%";
                        Run_Memory.Text = "0 KB";
                        this.ShowWarningNotifier(ex + "\r\n 性能计数器异常,请输入CMD运行后输入LODCTR/R");
                    }
                }
            });
        }
        private static string GetWeekName()
        {
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "星期一";
                case DayOfWeek.Tuesday:
                    return "星期二";
                case DayOfWeek.Wednesday:
                    return "星期三";
                case DayOfWeek.Thursday:
                    return "星期四";
                case DayOfWeek.Friday:
                    return "星期五";
                case DayOfWeek.Saturday:
                    return "星期六";
                case DayOfWeek.Sunday:
                    return "星期日";
            }
            return "";
        }
        #region 窗体拖动
        protected override bool ProcessCmdKey(ref Message m, Keys key)
        {

            if (m.Msg == Win32.WM_KEYDOWN | m.Msg == Win32.WM_SYSKEYDOWN)
            {
                if (key.Equals(Keys.Escape))
                {
                    WindowState = FormWindowState.Normal;
                    CenterToScreen();
                }
                else if (key.Equals(Keys.A | Keys.Alt))
                {

                }
            }
            return false;
        }
        public class Win32
        {
            public const int WM_SYSCOMMAND = 0x112;
            public const int SC_MAXIMIZE = 0xF030;
            public const int SC_MINIMIZE = 0xF020;
            public const int SC_CLOSE = 0xF060;
            public const int WM_KEYDOWN = 256;
            public const int WM_SYSKEYDOWN = 260;
            public const int AW_HOR_POSITIVE = 0x00000001;    // 从左到右打开窗口
            public const int AW_HOR_NEGATIVE = 0x00000002;    // 从右到左打开窗口
            public const int AW_VER_POSITIVE = 0x00000004;    // 从上到下打开窗口
            public const int AW_VER_NEGATIVE = 0x00000008;    // 从下到上打开窗口
            public const int AW_CENTER = 0x00000010;
            public const int AW_HIDE = 0x00010000;        // 在窗体卸载时若想使用本函数就得加上此常量
            public const int AW_ACTIVATE = 0x00020000;    //在窗体通过本函数打开后，默认情况下会失去焦点，除非加上本常量
            public const int AW_SLIDE = 0x00040000;
            public const int AW_BLEND = 0x00080000;       // 淡入淡出效果
            /// <summary>
            /// 窗体效果
            /// </summary>
            /// <param name="hwnd">handle to window</param>
            /// <param name="dwTime">duration of animation</param>
            /// <param name="dwFlags">animation type</param>
            /// <returns></returns>
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
            //Win32.AnimateWindow(this.Handle, 2000, Win32.AW_BLEND);   /*淡入窗体*/
            //Win32.AnimateWindow(this.Handle, 2000, Win32.AW_SLIDE | Win32.AW_HIDE | Win32.AW_BLEND);    /*淡出窗体*/
        }
        #endregion
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmLock mFrmLock = new FrmLock(this.Location,this.Width,this.Height);
            mFrmLock.ShowDialog();
        }
        private void 反馈及建议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFeedback().ShowDialog();
        }
    }
}
