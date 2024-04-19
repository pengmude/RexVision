using Ookii.Dialogs.WinForms;
using Rex.UI;
using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.VarSet
{
    public partial class VarSetForm : FormBase
    {
         VarSetObj mObj;
        public VarSetForm(VarSetObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DataSaveForm_Load(object sender, EventArgs e) { }
        public override void FormToObj()
        {
            mObj.mChar_Info.Clear();
            for (int i = 0; i < dgv_File.RowCount; ++i)
            {
                int index = (int)dgv_File.Rows[i].Cells[0].Value;
                string name = dgv_File.Rows[i].Cells[1].Value.ToString();
                string link1 = dgv_File.Rows[i].Cells[2].Value.ToString();
                string mchar = dgv_File.Rows[i].Cells[3].Value.ToString();
                string link2 = dgv_File.Rows[i].Cells[4].Value.ToString();
                string resut = dgv_File.Rows[i].Cells[5].Value.ToString();
                string marks = dgv_File.Rows[i].Cells[6].Value.ToString();
                mObj.mChar_Info.Add(new Char_Info(index, name, link1,mchar, link2, resut, marks));
            }
        }
        public override void ObjToForm()
        {
    
            dgv_File.DataSource = mObj.mChar_Info.ToArray();
            uitb_Remark.Text = mObj.ModInfo.Remarks;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgv_File_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int mSelectRow = dgv_File.CurrentRow.Index;
            int mSelectCol = dgv_File.CurrentCell.ColumnIndex;
            if (mSelectCol == 2)
            {
                PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
                LikeDataForm.ShowDialog();
                if (LikeDataForm.m_OutLinkData.Length > 3)
                {
                    string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                    mObj.mChar_Info[mSelectRow].Link1 = m_IntStr[0] + ":" + m_IntStr[1];
                    ObjToForm();
                }
            }
           else if (mSelectCol == 4)
            {
                PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
                LikeDataForm.ShowDialog();
                if (LikeDataForm.m_OutLinkData.Length > 3)
                {
                    string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                    mObj.mChar_Info[mSelectRow].Link2 = m_IntStr[0] + ":" + m_IntStr[1];
                    ObjToForm();
                }
            }

        }
        private void uibt_Click(object sender, EventArgs e)
        {
            int setrow = 0;
            int index = dgv_File.CurrentRow != null ? dgv_File.CurrentRow.Index : 0;
            UIButton btn = sender as UIButton;
            switch (btn.Text)
            {
                case "添加":
                    dgv_Add(dgv_File.RowCount);
                    break;
                case "删除":
                    dgv_Remov(index);
                    break;
                case "上移":
                    dgv_Up(index);
                    setrow = index - 1;
                    break;
                case "下移":
                    dgv_Down(index);
                    setrow = index + 1;
                    break;
            }
            dgv_File.DataSource = mObj.mChar_Info.ToArray();
            dgv_File.BindingContext[dgv_File.DataSource].Position = setrow;
        }
        private void uiLink_FileName_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                //uiLink_FileName.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
            }
        }
        private void dgv_Add(int index)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
            mObj.mChar_Info.Add(new Char_Info(mObj.mChar_Info.Count, "Set" + mObj.mChar_Info.Count, m_IntStr[0] + ":" + m_IntStr[1], "加","","", ""));
        }
        private void dgv_Remov(int index)
        {
            mObj.mChar_Info.RemoveAt(index);
        }
        private void dgv_Up(int index)
        {
            if (index < 1) { return; }
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[index - 1];
            mObj.mChar_Info[index - 1] = temp;
        }
        private void dgv_Down(int index)
        {
            if (index < 0 || mObj.mChar_Info.Count < 2 || (mObj.mChar_Info.Count - 1) <= index) { return; }
            var temp = mObj.mChar_Info[index];
            mObj.mChar_Info[index] = mObj.mChar_Info[index + 1];
            mObj.mChar_Info[index + 1] = temp;
        }
        private void dgv_File_DataError(object sender, DataGridViewDataErrorEventArgs e){}
    }
}
