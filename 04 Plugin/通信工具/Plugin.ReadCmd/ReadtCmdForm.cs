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

namespace Plugin.ReadCmd
{
    public partial class ReadtCmdForm: FormBase
    {
        private ReadCmdObj mObj ;
        public ReadtCmdForm(ReadCmdObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void GetDataModForm_Load(object sender, EventArgs e)
        {
            this.Set_MinMax();
            ui_PortSelect.Items.Clear();
            if (mObj.mECom.Count > 0)
            {
                foreach (ECom com in mObj.mECom)
                {
                    ui_PortSelect.Items.Add(com.Key);
                }
            }
        }
        public override void  FormToObj()
        {
            mObj.mKey = ui_PortSelect.Text;
            mObj.mData = ui_ReadText.Values.Text;
            mObj.mEndChar = ui_EndChar.Text;
            mObj.ModInfo.Remarks = ui_Describle.Text;
        }
        public override void ObjToForm()
        {

            ui_PortSelect.Text = mObj.mKey;
            ui_ReadText.Values.Text = mObj.mData;
            ui_EndChar.Text = mObj.mEndChar;
            ui_Describle.Text = mObj.ModInfo.Remarks;
        }
        private void ui_PortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mKey = ui_PortSelect.Text;
        }
        private void ui_Describle_TextChanged(object sender, EventArgs e)
        {
            mObj.ModInfo.Remarks = ui_Describle.Text;
        }
        private void ui_ReadText_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            { 
                ui_ReadText.Values.Text = mObj.mData = LikeDataForm.m_OutLinkData.Replace("|", ":");
        }
        }
        private void ui_ReadText_BtnDec(object sender, EventArgs e)
        {
            ui_ReadText.Values.Text = mObj.mData = "T1";
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            mObj.Stop();
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mObj.Stop();
            this.Close();
        }
    }
}
