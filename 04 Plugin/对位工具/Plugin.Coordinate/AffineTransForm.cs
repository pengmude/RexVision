
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

namespace Plugin.AffineTrans
{
    public partial class AffineTransForm: FormBase
    {
        private AffineTransObj mObj;
        public AffineTransForm(AffineTransObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void AffineTransForm_Load(object sender, EventArgs e)
        {
            this.Set_MinMax();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        public override void FormToObj()
        {
            mObj.mFormX = uiLink_FormX.Values.Text;
            mObj.mFormY = uiLink_FormY.Values.Text;
            mObj.mFormR = uiLink_FormR.Values.Text;
            mObj.mToX = uiLink_ToX.Values.Text;
            mObj.mToY = uiLink_ToY.Values.Text;
            mObj.mToR = uiLink_ToR.Values.Text;
            mObj.mMapPointX = uilk_MapPointX.Values.Text;
            mObj.mMapPointY = uilk_MapPointY.Values.Text;
        }
        public override void ObjToForm()
        {
            uiLink_FormX.Values.Text = mObj.mFormX;
            uiLink_FormY.Values.Text = mObj.mFormY;
            uiLink_FormR.Values.Text = mObj.mFormR;
            uiLink_ToX.Values.Text = mObj.mToX;
            uiLink_ToY.Values.Text = mObj.mToY;
            uiLink_ToR.Values.Text = mObj.mToR;
            uilk_MapPointX.Values.Text = mObj.mMapPointX;
            uilk_MapPointY.Values.Text = mObj.mMapPointY;
            uitb_TranslX.Text = mObj.mRPoint.X.ToString();
            uitb_TranslY.Text = mObj.mRPoint.Y.ToString();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void uiRadioButton1_ValueChanged(object sender, bool value)
        {

        }
        private void uiLink_ToR_BtnAdd(object sender, EventArgs e)
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
                            break;
                    }
                    return;
                }
            }
        }
        private void uiLink_ToR_BtnDec(object sender, EventArgs e)
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
                        mUILinkText.Values.Text = "0";
                        break;
                }
                return;
            }
        }
    }
}
