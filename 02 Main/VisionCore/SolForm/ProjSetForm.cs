using DockContrl;
using System;

namespace VisionCore
{/// <summary>
/// 工程设置画面
/// </summary>
    public partial class ProjSetForm : DockForm
    {
        /// <summary>关联的工程类</summary>
        private Sol mSol;
        /// <summary>流程信息更改</summary>
        public bool mChangName=false;
        /// <summary>流程名称列表</summary>
        public string[] SolNameArry;
        public ProjSetForm(Sol Sol_)
        {
            mSol = Sol_;
            this.Set_MinMax();
            InitializeComponent();
            SolNameArry = mSol.GetNameList().ToArray();
        }
        private void ProjSetForm_Load(object sender, EventArgs e)
        {
            int index = 0;
             tb_SolName.TextStr = mSol.Name;
            foreach (Proj proj in mSol.mProjList)
            {
                dgv_ProjSet.AddRow();
                dgv_ProjSet.Rows[index].Cells[0].Value = proj.mProjInfo.Name;
                dgv_ProjSet.Rows[index].Cells[1].Value = proj.mRunType.ToString();
                dgv_ProjSet.Rows[index].Cells[2].Value = proj.mIsShow;
                ++index;
            }
        }
        private void bt_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgv_ProjSet.RowCount; ++i)
                {
                    Proj mProj = mSol.mProjList.Find(c => c.mProjInfo.Index == i);
                    mProj.mProjInfo.Name = dgv_ProjSet.Rows[i].Cells[0].Value.ToString();
                    string mEnum = dgv_ProjSet.Rows[i].Cells[1].Value.ToString();
                    mProj.mRunType = (RunType)Enum.Parse(typeof(RunType), mEnum);
                    mProj.mIsShow = (bool)dgv_ProjSet.Rows[i].Cells[2].Value;

                    SolNameArry[i] = dgv_ProjSet.Rows[i].Cells[0].Value.ToString();
     
                }
                mSol.SetProjName(SolNameArry);
                mSol.Name = tb_SolName.TextStr;
                mChangName = true;
                Close();
            }
            catch(Exception ex){}
        }
        private void bt_Close_Click(object sender, EventArgs e)
        {
            mChangName = false;
            Close();
        }
    }
}
