using System;
using System.IO;
using System.Windows.Forms;
using TopControls;
using VisionCore.core;
using VisionCore.Log4Net;
using WeifenLuo.WinFormsUI.Docking;

namespace EasyVision
{
    public partial class FrmMainMdi : Form
    {
        private Solution m_Solution;
        private FrmSolutionView m_SolutionView;
        private FrmModuleTree m_ModuleTree;
        private FrmCanvasView m_CanvasView;
        private FrmDataView m_DataView;
        private FrmLog m_Log;
        private DeserializeDockContent m_deserializeDockContent;

        private int m_OldPoejctID = 0;//上一次运行状态 避免刷新ui频繁
        private bool m_OldPoejctState = false;

        public FrmMainMdi()
        {
            InitializeComponent();

          //  AutoScaleMode = AutoScaleMode.Dpi;
            CreateStandardControls();

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);


        }


        private void CreateStandardControls()
        {
            //m_solutionExplorer = new DummySolutionExplorer();
            //m_propertyWindow = new DummyPropertyWindow();
            m_SolutionView = new FrmSolutionView();
            m_CanvasView = new FrmCanvasView();
            m_ModuleTree = new FrmModuleTree();
            m_DataView = new FrmDataView();
            m_Log = new FrmLog();
            //m_outputWindow = new DummyOutputWindow();
            //m_taskList = new DummyTaskList();
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(FrmSolutionView).ToString())
                return m_SolutionView;
            else if (persistString == typeof(FrmCanvasView).ToString())
                return m_CanvasView;
            else if (persistString == typeof(FrmModuleTree).ToString())
                return m_ModuleTree;
            else if (persistString == typeof(FrmDataView).ToString())
                return m_DataView;
            else if (persistString == typeof(FrmLog).ToString())
                return m_Log;
            return null;
        }
        private void MDIFrom_Load(object sender, EventArgs e)
        {
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");

            if (File.Exists(configFile))
            {
                dockPanel.LoadFromXml(configFile, m_deserializeDockContent);
            }
        }

        private void frmMainMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Solution.s_IsSaved == false)
            {
                DialogResult dr = MessageBox.Show($"是否保存对当前解决方案 {Path.GetFileName(Solution.s_SavePath)} 的更改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SaveSolution_Click(null, null);
                }
                else if (dr == DialogResult.No)
                {
                    //do nothing
                }
                else
                {
                    e.Cancel = true;
                }

            }
            else
            {
                DialogResult dr = MessageBox.Show($"是否要退出当前程序？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SaveSolution_Click(null, null);
                }
                else
                {
                    e.Cancel = true;
                }
            }

            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
            dockPanel.SaveAsXml(configFile);
        }

        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_ModuleTree.Show(dockPanel);
        }

        private void 流程栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SolutionView.Show(dockPanel);
        }

        private void 图像显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           m_CanvasView.Show(dockPanel);
        }
        private void 数据栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_DataView.Show(dockPanel);
        }
        private void 日志栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Log.Show(dockPanel);
        }
        private void menuItemView_Click(object sender, EventArgs e)
        {
        }

        private void menuItemView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItemView_MouseEnter(object sender, EventArgs e)
        {
            图像显示ToolStripMenuItem.Checked = m_CanvasView.IsDockStateValid(DockState.Hidden) ? false : true;
        }

        #region "运行控制"

        //运行一次
        private void tsbRunOnce_Click(object sender, EventArgs e)
        {
            m_OldPoejctState = true;
            tsbRunOnce.Enabled = false;
            //获取当前选中的项目index
            Solution.ExecuteOnce();
        }

        //连续运行
        private void tsbRunCycle_Click(object sender, EventArgs e)
        {
            m_OldPoejctState = true;
            tsbRunCycle.Enabled = false;
            Solution.StartRun();
        }

        //停止
        private void tsbStop_Click(object sender, EventArgs e)
        {
            tsbStop.Enabled = false;
            Solution.StopRun();
        }
        #endregion

        private void timer_projectState_Tick(object sender, EventArgs e)
        {
            if (Solution.s_Instance.m_ProjectList.Count > 0)
            {
                bool flag = Solution.GetStates();
                tsbRunOnce.Enabled = !flag;
                tsbRunCycle.Enabled = !flag;
                tsbStop.Enabled = flag;
            }
        }

        //新建一个解决方案
        private void tsbNewSlotion_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("创建新的解决方案会覆盖掉当前已有解决方案,确认继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Solution solution = new Solution();
                if (solution != null)
                {
                    Solution.s_Instance = solution;
                    //  Solution.s_CreateSolution(null);
                   // SetSolution

                }
                //else
                {
                    Log.Warn("创建解决方案失败");
                }
            }
        }

        //另存为解决方案
        private void SaveAsSolution_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //设置文件类型 
            sfd.Filter = "解决方案（*.ev）|*.ev";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            sfd.InitialDirectory = @"C:\Users\Administrator\Desktop\temp";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                //Solution.SaveEVSolution(localFilePath);
            }
        }

        //保存解决方案
        private void SaveSolution_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Solution.s_SavePath))
            {
                //Solution.SaveEVSolution(EVSolution.s_SavePath);
            }
            else
            {
                SaveAsSolution_Click(null,null);
            }
        }


        /// <summary>
        /// 打开解决方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbOpenSolution_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();

            //设置文件类型 

            sfd.Filter = "解决方案（*.ev）|*.ev";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            sfd.InitialDirectory = @"C:\Users\Administrator\Desktop\temp";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                //EVSolution.LoadEVSolution(localFilePath);

            }
        }

        //打开系统设置窗口
        private void menuItemSysSet_Click(object sender, EventArgs e)
        {
            //SetForm frm = new SetForm();
            //frm.ShowDialog();
        }
    }
}
