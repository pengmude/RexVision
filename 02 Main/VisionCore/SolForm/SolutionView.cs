using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace VisionCore
{
    /// <summary>整个解决方案显示列表,编辑流程</summary>
    public partial class SolView : UserControl
    {
        /// <summary>当前模块</summary>
        public static ModFlow mCurModFlow;
        /// <summary>工程列表</summary>
        List<ProjTab> mProjTabList = new List<ProjTab>();
        public SolView()
        {
            InitializeComponent();
        }
        public void SetSol()//代替Load
        {
            CreateSol(Sol.mSol.mProjList);
        }
        /// <summary>新建解决方案的时候 清空项目列表 并创建一个新的</summary>
        /// <param name="ProjList"></param>
        private void CreateSol(List<Proj> ProjList)
        {
            mProjTabList.Clear();
            TabProj.TabPages.Clear();
            if (ProjList != null && ProjList.Count > 0)
            {
                foreach (Proj Proj in ProjList)
                {
                    AddProjTab(Proj);
                    Proj.ChangeEvent();
                }
            }
            else
            {
                AddProjTab(Sol.GetProj(Sol.mSol.CreateProj()));
            }
        }
        /// <summary>项目运行结束时候  刷新项目状态</summary>
        /// <param name="ProjIndex"></param>
        private void RefreshStatus(int ProjIndex)
        {
            if (Sol.mSol == null) { return; }
            if (Sol.mSol.mProjList.Count > 0 && mProjTabList.Count > 0)
            {
                BeginInvoke(new Action(() => { mProjTabList[ProjIndex].ModelFlow.Refresh(); }));
            }
        }
        /// <summary>添加解决方案</summary>
        /// <param name="Proj"></param>
        private void AddProjTab(Proj Proj)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            if (Proj == null) { MessageBox.Show($"添加失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            ProjTab mProjTab = new ProjTab(Proj);
            mProjTabList.Add(mProjTab);
            TabProj.Controls.Add(mProjTab.TabPage);
            mProjTabList[TabProj.SelectedIndex].ModelFlow.ShowRef();
        }
        private void tsbt_ProjAdd_Click(object sender, EventArgs e)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            AddProjTab(Sol.GetProj(Sol.mSol.CreateProj()));
        }
        private void tsbt_ProjDelete_Click(object sender, EventArgs e)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            int index = TabProj.SelectedIndex;
            if (index > -1)
            {
                string name = TabProj.SelectedTab.Text;
                if (Sol.DeleteProj(name))
                {
                    mProjTabList.RemoveAt(index);
                    TabProj.Controls.RemoveAt(index);
                }
            }
        }
        private void tsbt_ProjSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
                if (TabProj.SelectedIndex > -1)
                {
                    ProjSetForm mProjSetForm = new ProjSetForm(Sol.mSol);
                    mProjSetForm.ShowDialog();
                    if (mProjSetForm.mChangName)
                    {
                        for (int i = 0; i < mProjSetForm.SolNameArry.Length; ++i)
                        {
                            ProjInfo mProjInfo = Sol.GetProj(mProjSetForm.SolNameArry[i]);
                            if (Sol.ChangeProInfo(mProjInfo))
                            {
                                TabProj.TabPages[i].Text = mProjInfo.Name;
                                mProjTabList[i].ModelFlow.ProjInfo = mProjInfo;
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void tsbt_ProjRun_Click(object sender, EventArgs e)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            Sol.OnceRun(TabProj.SelectedIndex);
        }
        private void tsbt_ProjFor_Click(object sender, EventArgs e)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            Sol.StartRun(TabProj.SelectedIndex);
        }
        private void tsbt_ProjStop_Click(object sender, EventArgs e)
        {
            if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
            Sol.StopRun(TabProj.SelectedIndex);
        }
        private void TabProj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Sol.mSol == null) { MessageBox.Show($"项目为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand); return; }
                if (TabProj.SelectedIndex == -1)
                {
                    TabProj.SelectedIndex = 0;
                }
                else
                {
                    Sol.mModIndex = TabProj.SelectedIndex;
                    mCurModFlow = mProjTabList[TabProj.SelectedIndex].ModelFlow;
                }
                //RefreshStatus(TabProj.SelectedIndex);
            }
            catch (Exception ex)
            {
                Log.Error("SolView Select:" + TabProj.SelectedIndex+ ":" + ex.Message);
            }
        }
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            try
            {
                timer_refresh.Enabled = false;
                if (Sol.mSol != null)
                {
                    if (Sol.mSol.mProjList.Count > 0 && this.mProjTabList.Count > 0)
                    {
                        if (Sol.GetStates())// 正在运行的时候刷新
                        {
                            this.mProjTabList[Sol.mModIndex].ModelFlow.Refresh();
                            this.mProjTabList[Sol.mModIndex].ModelFlow.UseAble = false;
                        }
                        else
                        {
                            this.mProjTabList[Sol.mModIndex].ModelFlow.Refresh();
                            this.mProjTabList[Sol.mModIndex].ModelFlow.UseAble = true;
                        }
                    }
                }
                timer_refresh.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.Error("SolView Time:" + +Sol.mModIndex+":" + ex.Message);
            }
        }
    }
}
