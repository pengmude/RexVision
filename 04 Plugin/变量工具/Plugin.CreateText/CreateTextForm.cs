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

namespace Plugin.CreateText
{
    public partial class CreateTextForm : FormBase
    {
        private CreateTextObj mObj;
        public CreateTextForm(CreateTextObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void GetDataModForm_Load(object sender, EventArgs e)
        {

        }
        public override void  FormToObj()
        {
            mObj.OutTrue = tb_OutTrue.Text;
            mObj.OutFalse = tb_OutFalse.Text;
            mObj.OutNGStr = tb_OutNGStr.Text;
            mObj.OutDouble = tb_OutDouble.Value.ToString();
            mObj.OutStrSplit = tb_OutStrSplit.Text;
            mObj.OutStr = tb_OutStr.Text;
        }
        public override void ObjToForm()
        {
            dgv_Var.DataSource = mObj.mText_Info.ToList();
            tb_OutTrue.Text = mObj.OutTrue;
            tb_OutFalse.Text = mObj.OutFalse;
            tb_OutNGStr.Text = mObj.OutNGStr;
            tb_OutDouble.Value = double.Parse(mObj.OutDouble);
            tb_OutStrSplit.Text = mObj.OutStrSplit;
            tb_OutStr.Text = mObj.OutStr;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            dgv_Var.DataSource = mObj.mText_Info.ToList();
            tb_OutStr.Text = mObj.OutStr;
        }
        private void btn_VarAdd_Click(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] ReadStr = LikeDataForm.m_OutLinkData.Split('|');
                mObj.mText_Info.Add(new Text_Info(Get_Name(), ReadStr[0] + ":" + ReadStr[1], ""));
                dgv_Var.DataSource = mObj.mText_Info.ToList();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            mObj.mText_Info.RemoveAt(dgv_Var.CurrentRow.Index);
            dgv_Var.DataSource = mObj.mText_Info.ToList();
        }
        private void btn_Up_Click(object sender, EventArgs e)
        {
            int index = dgv_Var.CurrentRow.Index;
            if (index <= 0) return;
            var temp = mObj.mText_Info[index];
            mObj.mText_Info[index] = mObj.mText_Info[index - 1];
            mObj.mText_Info[index - 1] = temp;
            dgv_Var.DataSource = mObj.mText_Info.ToList();
            dgv_Var.CurrentCell = dgv_Var.Rows[index - 1].Cells[0];
        }
        private void btn_Down_Click(object sender, EventArgs e)
        {
            int index = dgv_Var.CurrentRow.Index;
            if (index >= dgv_Var.RowCount-1) return;
            var temp = mObj.mText_Info[index];
            mObj.mText_Info[index] = mObj.mText_Info[index + 1];
            mObj.mText_Info[index + 1] = temp;
            dgv_Var.DataSource = mObj.mText_Info.ToList();
            dgv_Var.CurrentCell = dgv_Var.Rows[index + 1].Cells[0];
        }
        private void dgv_VarList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Var.CurrentRow.Index;
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] ReadStr = LikeDataForm.m_OutLinkData.Split('|');
                Text_Info info = new Text_Info(Get_Name(), ReadStr[0] + ":" + ReadStr[1], "");
                mObj.mText_Info[index] = info;
                dgv_Var.DataSource = mObj.mText_Info.ToList();
            }
        }
        public string Get_Name()
        {
            for (int i = 0; i < 1000; i++)
            {
                Text_Info cell = mObj.mText_Info.Find(c => c.Name == "Var" + i.ToString());
                if (cell == null)
                {
                    return "Var" + i.ToString();
                }
            }
            return "None";
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
