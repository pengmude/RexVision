using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.RunProj
{
    public partial class RunProjForm : FormBase
    {
        RunProjObj mObj;
        public RunProjForm(RunProjObj Obj) : base(Obj)
        {
            mObj = Obj;
            this.Set_MinMax();
            InitializeComponent();
        }
        private void RunProjForm_Load(object sender, EventArgs e)
        {
        }
        public override void  FormToObj()
        {
            if (ui_OneRun.Checked) { mObj.mRunMode = RunMode.单次执行; }
            if (ui_ForRun.Checked) { mObj.mRunMode = RunMode.循环执行; }
            if (ui_StpRun.Checked) { mObj.mRunMode = RunMode.停止执行; }
            int index = 0;
            foreach (Proj proj in mObj.mRunProj)
            {
                proj.mProjInfo.Name = dgv_ProjSet.Rows[index].Cells[0].Value.ToString();
                string aaa = dgv_ProjSet.Rows[index].Cells[1].Value.ToString();
                if (dgv_ProjSet.Rows[index].Cells[1].Value.ToString() == "True")
                {
                    //proj.RunMode = (RunMode)Enum.Parse(typeof(RunMode), dgv_ProjSet.Rows[index].Cells[1].Value.ToString());
                    proj.mRunMode = mObj.mRunMode;
                    mObj.mRunModeList[index] = mObj.mRunMode;
                }
                proj.mIsShow = (bool)dgv_ProjSet.Rows[index].Cells[2].Value;
                ++index;
            }
        }
        public override void ObjToForm()
        {
            switch (mObj.mRunMode)
            {
                case RunMode.单次执行:
                    ui_OneRun.Checked = true;
                    ui_ForRun.Checked = false;
                    ui_StpRun.Checked = false;
                    break;
                case RunMode.循环执行:
                    ui_OneRun.Checked = false;
                    ui_ForRun.Checked = true;
                    ui_StpRun.Checked = false;
                    break;
                case RunMode.停止执行:
                    ui_OneRun.Checked = false;
                    ui_ForRun.Checked = false;
                    ui_StpRun.Checked = true;
                    break;
            }
            if (mObj.mRunProj.Count > 0)
            {
                int index = 0;
                dgv_ProjSet.Rows.Clear();
                foreach (Proj proj in mObj.mRunProj)
                {
                    dgv_ProjSet.AddRow();
                    dgv_ProjSet.Rows[index].Cells[0].Value = proj.mProjInfo.Name;
                    dgv_ProjSet.Rows[index].Cells[1].Value = mObj.mRunModeList[index]== mObj.mRunMode ? true:false;
                    dgv_ProjSet.Rows[index].Cells[2].Value = proj.mIsShow;
                    ++index;
                }
            }
            else
            {
                mObj.mRunProj = Sol.mSol.mProjList;
                int index = 0;
                foreach (Proj proj in Sol.mSol.mProjList)
                {
                    mObj.mRunModeList.Add(proj.mRunMode);
                    dgv_ProjSet.AddRow();
                    dgv_ProjSet.Rows[index].Cells[0].Value = proj.mProjInfo.Name;
                    dgv_ProjSet.Rows[index].Cells[1].Value = mObj.mRunMode==proj.mRunMode? true : false;
                    dgv_ProjSet.Rows[index].Cells[2].Value = proj.mIsShow;
                    ++index;
                }
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ui_StopRun_MouseDown(object sender, MouseEventArgs e)
        {
            switch((sender as UICheckBox).Text)
            {
                case "单次执行":
                    ui_ForRun.Checked = false;
                    ui_StpRun.Checked = false;
                    break;
                case "循环执行":
                    ui_OneRun.Checked = false;
                    ui_StpRun.Checked = false;
                    break;
                case "停止执行":
                    ui_OneRun.Checked = false;
                    ui_ForRun.Checked = false;
                    break;
            }
        }
        private void dgv_ProjSet_DataError(object sender, DataGridViewDataErrorEventArgs e) { }
    }
}
