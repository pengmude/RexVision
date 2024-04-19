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

namespace Plugin.For
{
    public partial class ForForm: FormBase
    {
        private ForObj mObj ;
        public ForForm(ForObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DelayModForm_Load(object sender, EventArgs e)
        {
        }
        public override void  FormToObj()
        {
            mObj.mForMode = (ForMode)uicb_ForMode.SelectedIndex;
            mObj.mStarStr = uiLink_StarStr.Values.Text;
            mObj.mOverStr = uiLink_OverStr.Values.Text;
        }
        public override void ObjToForm()
        {
            uicb_ForMode.SelectedIndex = (int)mObj.mForMode;
            uiLink_StarStr.Values.Text = mObj.mStarStr;
            uiLink_OverStr.Values.Text = mObj.mOverStr;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
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
                                    uiLink_StarStr.Values.Text = mUILinkText.Values.Text;
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
    }
}
