using DockContrl;
using System;

namespace VisionCore
{/// <summary>
/// 工程设置画面
/// </summary>
    public partial class SolSetForm : DockForm
    {
        /// <summary>关联的工程类</summary>
        Sol mSol;
        public SolSetForm(Sol sol)
        {
            mSol = sol;
            this.Set_MinMax();
            InitializeComponent();

        }
        private void FormProj_Set_Load(object sender, EventArgs e)
        {
            //dgv_SolList

        }
        private void bt_ChangName_Click(object sender, EventArgs e)
        {
            //int index = lb_ProList.SelectedIndex;
            //if (index >= 0 & tb_SolName.Text.Length > 0)
            //{
            //    SolNameArry[index] = tb_SolName.Text;
            //    mSol.SetProjName(SolNameArry);
            //    lb_ProList.Items.RemoveAt(index);//先移除当前项的值
            //    lb_ProList.Items.Insert(index, tb_SolName.Text);//在当前指定项插入新的值
            //}
            //if (tb_ProName.Text.Length > 0)
            //{
            //    for (int i = 0; i < mSol.mSysVar.Count; ++i)
            //    {
            //        DataCell data = mSol.mSysVar.Find(c => c.mModName == mSol.Name);
            //        data = Sol.mSol.mSysVar[i];
            //        data.mModName = tb_ProName.Text;
            //        Sol.mSol.mSysVar[i] = data;
            //    }
            //    mSol.Name = tb_ProName.Text;
            //}
        }
        private void bt_SelectOpen_Click(object sender, EventArgs e)
        {

        }
        private void bt_StartSol_Click(object sender, EventArgs e)
        {

        }
        private void bt_AddNow_Click(object sender, EventArgs e)
        {

        }
        private void bt_AddExt_Click(object sender, EventArgs e)
        {

        }
        private void bt_Delete_Click(object sender, EventArgs e)
        {

        }
        private void bt_Up_Click(object sender, EventArgs e)
        {

        }
        private void bt_Down_Click(object sender, EventArgs e)
        {

        }
        private void bt_Enter_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
