using RexConst;
using RexForm;
using System;
using System.IO;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    /// <summary>主窗体</summary>
    public partial class FrmShow : Form
    {
        private FrmLog mFrmLog = null;
        private FrmTool mFrmModTree = null;
        private FrmProj mFrmSolView = null;
        private FrmData mFrmDataView = null;
        private FrmCanvas mFrmCanvasView = null;
        private FrmNet mFormCommunicate = null;
        private string m_DockPath = string.Empty;
        private DeserializeDockContent mDockContent;
        public FrmShow()
        {
            InitializeComponent();
        }
        /// <summary>获得指定的窗体</summary>
        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FrmNet).ToString())
                return mFormCommunicate;
            if (persistString == typeof(FrmProj).ToString())
                return mFrmSolView;
            else if (persistString == typeof(FrmCanvas).ToString())
                return mFrmCanvasView;
            else if (persistString == typeof(FrmTool).ToString())
                return mFrmModTree;
            else if (persistString == typeof(FrmData).ToString())
                return mFrmDataView;
            else if (persistString == typeof(FrmLog).ToString())
                return mFrmLog;
            return null;
        }
        private void MainShow_Load(object sender, EventArgs e)
        {
            try
            {
                mFrmLog = new FrmLog();
                mFrmSolView = new FrmProj();
                mFrmModTree = new FrmTool();
                mFrmDataView = new FrmData();
                mFrmCanvasView = new FrmCanvas();
                mFormCommunicate = new FrmNet();
            }
            catch (Exception ex)
            {
                Log.Error("MainShow_Load:" + ex.Message);
            }
            mDockContent = new DeserializeDockContent(GetContentFromPersistString);
            MainDockPanel.Visible = true;
            m_DockPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            InitDockPanel();
        }
        private void MainShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainDockPanel.SaveAsXml(m_DockPath);
        }
        public void InitDockPanel()
        {
            try
            {
                if (File.Exists(m_DockPath))
                {
                    MainDockPanel.LoadFromXml(m_DockPath, mDockContent);  //根据配置文件动态加载浮动窗体
                }else
                {
                    MainDockPanel.LoadFromXml(m_DockPath, mDockContent);
                }
            }
            catch (Exception)
            {
                // 配置文件不存在或配置文件有问题时 按系统默认规则加载子窗体
                // 注：在此加入的特殊处理，来改进Dockpanel 的加载，如果dockpanel.config不存在（不小心删除了），可以按照Appconfig中预定义的dockstate显示。
                MainDockPanel.LoadFromXml(m_DockPath, mDockContent);
            }
        }
        public void SetProj()
        {
            mFrmSolView.SetSol();
        }
        public void Show默认布局()
        {
            try
            {
                if (mFrmLog != null) mFrmLog.Show(MainDockPanel, DockState.DockBottom);
                if (mFrmSolView != null)mFrmSolView.Show(MainDockPanel, DockState.DockLeft);
                if (mFrmModTree != null)mFrmModTree.Show(MainDockPanel, DockState.DockLeft);
                if (mFrmDataView != null)mFrmDataView.Show(MainDockPanel, DockState.DockBottom);
                if (mFrmCanvasView != null) mFrmCanvasView.Show(MainDockPanel, DockState.Document);
                if (mFormCommunicate != null)mFormCommunicate.Show(MainDockPanel, DockState.DockBottom);
            }
            catch { }
        }
        /// <summary>画布设置</summary>
        public void CanvasSet(int index)//设置分屏数
        {
            if (mFrmCanvasView == null) { mFrmCanvasView = new FrmCanvas(); }
            mFrmCanvasView.SetViewMode(index);
        }
        public void ShowUI(string UiName)
        {
            switch (UiName)
            {
                case "默认布局":
                    Show默认布局();
                    break;
                case "保存布局":
                    MainDockPanel.SaveAsXml(m_DockPath);
                    break;
                case "流程栏":
                    if (mFrmSolView == null) { mFrmSolView = new FrmProj(); }
                    mFrmSolView.Show(MainDockPanel, DockState.DockLeft);
                    break;
                case "工具栏":
                    if (mFrmModTree == null) { mFrmModTree = new FrmTool(); }
                    mFrmModTree.Show(MainDockPanel, DockState.DockLeft);
                    break;
                case "数据显示":
                    if (mFrmDataView == null) { mFrmDataView = new FrmData(); }
                    mFrmDataView.Show(MainDockPanel, DockState.DockBottom);
                    break;
                case "日志显示":
                    if (mFrmLog == null) { mFrmLog = new FrmLog(); }
                    mFrmLog.Show(MainDockPanel, DockState.DockBottom);
                    break;
                case "图像显示":
                    if (mFrmCanvasView == null) { mFrmCanvasView = new FrmCanvas(); }
                    mFrmCanvasView.Show(MainDockPanel, DockState.Document);
                    break;
                case "通讯监视":
                    if (mFormCommunicate == null) { mFormCommunicate = new FrmNet(); }
                    mFormCommunicate.Show(MainDockPanel, DockState.DockBottom);
                    break;
            }
        }
        public void ScreenShow(RImage Image)
        {
            mFrmCanvasView.ScreenShow(Image);
        }
    }
}
