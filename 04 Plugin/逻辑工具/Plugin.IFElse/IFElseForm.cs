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

namespace Plugin.IFElse
{
    public partial class IFElseForm: FormBase
    {
        private IFElseObj mObj ;
        public IFElseForm(IFElseObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void IFElseForm_Load(object sender, EventArgs e)
        {
        }
        public override void FormToObj()
        {
            mObj.mFuncStr1 = uiLink_FuncStr1.Values.Text;
            mObj.mFuncType1 = (FuncType)uicomb_FuncType1.SelectedIndex;
            mObj.mFuncData1 = uicomb_FuncData1.Text;

            mObj.mFuncStr2 = uiLink_FuncStr2.Values.Text;
            mObj.mFuncType2 = (FuncType)uicomb_FuncType2.SelectedIndex;
            mObj.mFuncData2 = uicomb_FuncData2.Text;
        }
        public override void ObjToForm()
        {
            uiLink_FuncStr1.Values.Text = mObj.mFuncStr1;
            uicomb_FuncType1.SelectedIndex = (int)mObj.mFuncType1;
            uicomb_FuncData1.Text = mObj.mFuncData1;

            uiLink_FuncStr2.Values.Text = mObj.mFuncStr2;
            uicomb_FuncType2.SelectedIndex = (int)mObj.mFuncType2;
            uicomb_FuncData2.Text = mObj.mFuncData2;
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
        private void uiLinkText1_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                UISymbolButton UIBtn = (UISymbolButton)sender;
                if (UIBtn != null)
                {
                    switch (UIBtn.Parent.GetType().Name)
                    {
                        case "UILinkData":
                            UILinkData mUILinkData = (UILinkData)UIBtn.Parent;
                            mUILinkData.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                        case "UILinkText":
                            UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                            mUILinkText.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            switch (mUILinkText.Name)
                            {
                                case "uiLink_IF":
                                    uiLink_FuncStr1.Values.Text = mUILinkText.Values.Text;
                                    break;
                            }
                            break;
                    }
                    return;
                }
            }
        }
        private void uiLinkText1_BtnDec(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            if (UIBtn != null)
            {
                switch (UIBtn.Parent.GetType().Name)
                {
                    case "UILinkData":
                        UILinkData mUILinkData = (UILinkData)UIBtn.Parent;
                        mUILinkData.Values.Text = "数据链接";
                        break;
                    case "UILinkText":
                        UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                        mUILinkText.Values.Text = "数据链接";
                        break;
                }
                return;
            }
        }

        private void panel_center_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
