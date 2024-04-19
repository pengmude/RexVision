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

namespace Plugin.ReadData
{
    public partial class ReadDataForm: FormBase
    {
        private ReadDataObj mObj;
        public ReadDataForm(ReadDataObj Obj) : base(Obj)
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
            ui_PortSelect.Text = mObj.mKey;
        }
        private void ui_PortSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mKey = ui_PortSelect.Text;
        }
        public override void  FormToObj()
        {
            mObj.mKey = ui_PortSelect.Text;
            mObj.mEndChar = ui_EndChar.Text;
        }
        public override void ObjToForm()
        {
            ui_PortSelect.Text = mObj.mKey;
            ui_EndChar.Text = mObj.mEndChar;
            ui_Describle.Text = mObj.ModInfo.Remarks;
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
            mObj.Stop();
            FormToObj();
            ObjToForm();
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mObj.Stop();
            Close();
        }

 
    }
}
