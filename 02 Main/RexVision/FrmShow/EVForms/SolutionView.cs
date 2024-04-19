using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VisionCore.core;

namespace EasyVision.EVControl.EVForms
{

    /// <summary>
    /// 整个解决方案显示列表,编辑流程
    /// </summary>
    public partial class SolutionView : UserControl
    {
        private ProjectInfo m_ProjectInfo;//流程信息
       // public Solution Solution.s_Instance;//工程类
        /// <summary>
        /// 工程tab列表
        /// </summary>
        List<ProjectTab> m_ProjectTabList = new List<ProjectTab>();
        /// <summary>
        /// 当前显示的模块
        /// </summary>
        public ModuleFlow CurrentFlow
        {
            get
            {
                int index = this.tabProject.SelectedIndex;
                if (index>-1)
                {
                    return m_ProjectTabList[index].ModelFlow;
                }
                return null;
            }
        }


        public SolutionView()
        {
            InitializeComponent();

           // Solution.s_Instance.CreateSolution = CreateSolution;
            //Solution.s_RefreshSolutionView = RefreshSolutionView;

        }

        /// <summary>
        ///项目运行结束时候  刷新项目状态
        /// </summary>
        /// <param name="projectIndex"></param>
        private void RefreshSolutionView(int projectIndex)
        {
            if (Solution.s_Instance == null) { return; }
            if (Solution.s_Instance.m_ProjectList.Count > 0 && this.m_ProjectTabList.Count > 0)
            {
                this.BeginInvoke(new Action(()=> {
                    this.m_ProjectTabList[m_ProjectInfo.ProjectID].ModelFlow.Refresh();
                }));
            }
        }
        public void SetSolution()
        {
            CreateSolution(Solution.s_Instance.m_ProjectList);
        }
        //新建解决方案的时候 清空项目列表 并创建一个新的
        private void CreateSolution(List<Project> projectList)
        {
            m_ProjectTabList.Clear();
            tabProject.TabPages.Clear();
            if (projectList != null && projectList.Count > 0)
            {
                foreach (Project project in projectList)
                {
                    AddProjectTab(project);
                }
         
            }
            else
            {
                //m_Solution = new Solution();
                int id = Solution.s_Instance.CreateProject();
                Project project = Solution.GetProjectById(id);
                AddProjectTab(project);
            }
        }

        private void AddProjectTab(Project project)
        {
            if (Solution.s_Instance == null) { return; }
            if (project == null)
            {
                MessageBox.Show("添加失败");
                return;
            }
            ProjectTab tab = new ProjectTab(project);
            m_ProjectTabList.Add(tab);
            this.tabProject.Controls.Add(tab.TabPage);
            m_ProjectTabList[this.tabProject.SelectedIndex]. ModelFlow.show_ref();
           
        }
        ///流程列表
        private Project m_project = null;
        public Project M_Project
        {
            set
            {
                Project pro = value;
                {
                    m_project = pro;
                }
            }
            get { return m_project; }
        }
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            //m_Solution = new Solution();
            int id = Solution.s_Instance.CreateProject();
            AddProjectTab(Solution.GetProjectById(id));
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            int index = this.tabProject.SelectedIndex;
            if (index > -1)
            {
                string name = this.tabProject.SelectedTab.Text;
                if (Solution.DeleteProject(name))
                {
                    m_ProjectTabList.RemoveAt(index);
                    this.tabProject.Controls.RemoveAt(index);
                }             
            }

        }
        int GetUnitJudge(int index)
        {
            return -1;
        }
        private void SetFlowJudge()
        {
            //int unitJudge = 0;
            //int num3 = this.CurrentFlow.UnitCount - 1;
            //for (int i = 0; i <= num3; i++)
            //{
            //    ModuleFlowItem unitFlowItem = this.CurrentFlow.GetUnitFlowItem(i);
            //    unitJudge = 0;
            //    if (unitFlowItem != null)
            //    {
            //        unitJudge = GetUnitJudge(i);
            //        unitFlowItem.SubtextColor = Color.Black;
            //        if (unitJudge == 1)
            //        {
            //            unitFlowItem.Judge = 1;
            //        }
            //        else if (unitJudge <= -1)
            //        {
            //            unitFlowItem.Judge = -1;
            //            unitFlowItem.SubtextColor = Color.Red;
            //        }
            //        else if (unitJudge == 0)
            //        {
            //            unitFlowItem.Judge = 0;
            //        }
            //    }
            //}
        }
        private void SolutionView_Load(object sender, EventArgs e)
        {
        }

        private void tsbSettingProject_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            int index = this.tabProject.SelectedIndex;
            if (index > -1)
            {
                string name = this.tabProject.SelectedTab.Text;

                ProjectInfo info = Solution.GetProjectByName(name,true);
                FrmProjectSetting frm = new FrmProjectSetting(info.Clone());
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ProjectInfo infoNew = frm.ProjectInfo;
                    if (Solution.ChangeProjectInfo(infoNew))
                    {
                        this.tabProject.SelectedTab.Text = infoNew.ProjectName;
                        this.m_ProjectTabList[index].ModelFlow.ProjectInfo = infoNew;
                    }
                }
            }
        }

        private void tsbSettingModule_Click(object sender, EventArgs e)
        {
        }

        private void tabProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            if (tabProject.SelectedIndex == -1)
            {
                tabProject.SelectedIndex = 0;
            }
            else
            {
                Solution.m_ProjectIndex = tabProject.SelectedIndex;
            }
        }

        //刷新状态
        private void timer_refreshModuleState_Tick(object sender, EventArgs e)
        {
          //  if (Solution.s_Instance == null) { return; }
            try
            {
                timer_refreshModuleState.Enabled = false;
                if (Solution.s_Instance.m_ProjectList.Count > 0 && this.m_ProjectTabList.Count > 0)
                {
                    bool flag = Solution.GetStates();

                    if (flag == true)// 正在运行的时候刷新
                    {
                        this.m_ProjectTabList[Solution.m_ProjectIndex].ModelFlow.Refresh();
                        this.m_ProjectTabList[Solution.m_ProjectIndex].ModelFlow.UseAble = false;
                    }
                    else
                    {
                        this.m_ProjectTabList[Solution.m_ProjectIndex].ModelFlow.UseAble = true;
                    }
                }
                
            }
            catch { }
            timer_refreshModuleState.Enabled = true;
        }

        private void tool_Start_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            Solution.ExecuteOnce(tabProject.SelectedIndex);
        }

        private void tool_StartFor_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            Solution.StartRun(tabProject.SelectedIndex);
        }

        private void tool_Stop_Click(object sender, EventArgs e)
        {
            if (Solution.s_Instance == null) { return; }
            Solution.StopRun(tabProject.SelectedIndex);
        }
    }
}
