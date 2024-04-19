using DockContrl;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;
using RexHelps;
using System;
using System.Windows.Forms;
using VisionCore;

namespace RexVision
{
    /// <summary>工程设置画面</summary>
    public partial class VisionSet : DockForm
    {
        public static RIni mRini = new RIni(Application.StartupPath + "\\Config.ini");
        public VisionSet()
        {
            this.Set_MinMax();
            InitializeComponent();
        }
        private void VisionSet_Load(object sender, EventArgs e)
        {
            //项目打开及路径
            ui_OpenStart.Checked= bool.Parse(mRini.ReadValue("Config", "mOpenStart", "true"));
            ui_StartLoadProj.Checked = bool.Parse(mRini.ReadValue("Config", "mStartLoadProj", "true"));
            ui_AutoRun.Checked=  bool.Parse(mRini.ReadValue("Config", "mAutoRun", "true"));
            uiLink_ProjFile.Values.Text =mRini.ReadValue("Config", "mSavePath", "");
            //时间间隔类
            ui_RunInterval.Value = int.Parse(mRini.ReadValue("Config", "mRunInterval", "100"));
            ui_NetInterval.Value = int.Parse(mRini.ReadValue("Config", "mNetInterval", "100"));
            //日志类
            ui_LogDay.Value = int.Parse(mRini.ReadValue("Config", "mLogSaveDay", "10"));
            ui_LogSet.SelectedIndex =int.Parse(mRini.ReadValue("Config", "mLogLevel", "1"));
            //其他设置
            ui_AutoSaveProj.Checked =bool.Parse(mRini.ReadValue("Config", "mAutoSaveProj", "true"));
        }
        private void uibt_Enter_Click(object sender, EventArgs e)
        { 
            //项目打开及路径
            Sol.mOpenStart=ui_OpenStart.Checked;
            Sol.mStartLoadProj=ui_StartLoadProj.Checked;
            Sol.mAutoRun=ui_AutoRun.Checked ;
            Sol.mSavePath= uiLink_ProjFile.Values.Text;
            //时间间隔类
            Sol.mRunInterval=(int)ui_RunInterval.Value ;
            Sol.mNetInterval=(int)ui_NetInterval.Value ;
            //日志类
            Sol.UpdateSys(ui_LogDay.Value, (LogLevel)ui_LogSet.SelectedIndex+1);
            //其他设置
            Sol.mAutoSaveProj = ui_AutoSaveProj.Checked;
            RStartSet.SetMeStart(ui_OpenStart.Checked);
            mRini.WriteValue("Config", "mOpenStart", ui_OpenStart.Checked.ToString());
            mRini.WriteValue("Config", "mStartLoadProj", ui_StartLoadProj.Checked.ToString());
            mRini.WriteValue("Config", "mAutoRun", ui_AutoRun.Checked.ToString());
            mRini.WriteValue("Config", "mSavePath", uiLink_ProjFile.Values.Text);
            mRini.WriteValue("Config", "mRuui_LogDaynInterval", ui_RunInterval.Value.ToString());
            mRini.WriteValue("Config", "mNetInterval", ui_NetInterval.Value.ToString());
            mRini.WriteValue("Config", "mLogSaveDay", ui_LogDay.Value.ToString());
            mRini.WriteValue("Config", "mLogSaveType", (ui_LogSet.SelectedIndex + 1).ToString());
            mRini.WriteValue("Config", "mAutoSaveProj", ui_AutoSaveProj.Checked.ToString());
        }
        private void uibt_Esc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
