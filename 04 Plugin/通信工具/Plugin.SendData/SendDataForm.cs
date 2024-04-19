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

namespace Plugin.SendData
{
    public partial class SendDataForm: FormBase
    {
        private SendDataObj mObj ;
        public SendDataForm(SendDataObj Obj) : base(Obj)
        {
            this.Set_MinMax();
            mObj = Obj;
            InitializeComponent();
        }
        private void SendDataModForm_Load(object sender, EventArgs e)
        {
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
            mObj.ModInfo.Remarks= ui_Describle.Text ;
            mObj.mEndChar=ui_EndChar.Text ;
            mObj.mSendText=ui_SendText.Values.Text ;
        }
        public override void ObjToForm()
        {
            ui_PortSelect.Text = mObj.mPortSelect;
            ui_Describle.Text = mObj.ModInfo.Remarks;
            ui_EndChar.Text = mObj.mEndChar;
            ui_SendText.Values.Text = mObj.mSendText;
        }
        private void ui_PortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mPortSelect = ui_PortSelect.Text;
        }
        private void ui_SendText_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            { 
                ui_SendText.Values.Text = mObj.mSendText = LikeDataForm.m_OutLinkData.Replace("|", ":");
        }
        }
        private void ui_Describle_TextChanged(object sender, EventArgs e)
        {
            mObj.ModInfo.Remarks = ui_Describle.Text;
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
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
