
using Rex.UI;
using RexConst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisionCore;


namespace Plugin.FitLine
{
    public partial class FitLineForm: FormBase
    {
        private FitLineObj mModObj;
        public FitLineForm(FitLineObj Obj) : base(Obj)
        {
            mModObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            UpdateWindow();
            if (mWindow.Image != null)
            {
                mWindow.DispImageFit();
                mWindow.RePaint += new RexView.DelegateRePaint(UpdateWindow);
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToMod();
            mModObj.RunMod();
            UpdateWindow();
            ModToForm();
        }
        /// <summary>单击单元时更新窗口 显示当前图片和检测内容</summary>
        public void UpdateWindow()
        {
            if (mModObj.mRImage != null && mModObj.mRImage.IsInitialized())
            {
                List<HRoi> roiList = mModObj.mRImage.mHRoi.Where(c => c.CellID == mModObj.ModInfo.Encode).ToList();
                mWindow.Image = mModObj.mRImage;
                foreach (HRoi roi in roiList)
                {
                    if (roi.CellType.Contains("拟合直线"))
                    {
                        if (roi != null && roi.roiType == HRoiType.文字显示)
                        {
                            HText roiText = (HText)roi;
                           ShowMsg.SetFont(mWindow.HWindowID, roiText.size, roiText.font, "false", "false");
                           ShowMsg.SetMsg(mWindow.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                        }
                        else
                        {
                            if (roi != null && roi.hobject.IsInitialized())
                            {
                                mWindow.HWindowID.SetColor(roi.drawColor);
                                mWindow.HWindowID.DispObj(roi.hobject);
                            }
                        }
                    }
                }
            }
        }
        public override void FormToMod()
        {
           mModObj.mP1X = ui_P1X.Values.Text;
           mModObj.mP1Y = ui_P1Y.Values.Text;
           mModObj.mP2X = ui_P2X.Values.Text;
           mModObj.mP2Y = ui_P2Y.Values.Text;
            mModObj.mImages = ui_Image.Values.Text;
        }
        public override void ModToForm()
        {
            ui_P1X.Values.Text = mModObj.mP1X;
            ui_P1Y.Values.Text = mModObj.mP1Y;
            ui_P2X.Values.Text = mModObj.mP2X;
            ui_P2Y.Values.Text = mModObj.mP2Y;
            ui_Image.Values.Text = mModObj.mImages;
            tb_Describle.Text= mModObj.ModInfo.Remarks;

            tb_CoreX.TextStr = mModObj.mOutLine!=null? mModObj.mOutLine.MidX.ToString("F4")   :"0";
            tb_CoreY.TextStr = mModObj.mOutLine != null ? mModObj.mOutLine.MidX.ToString("F4"):"0";
            tb_Angle.TextStr = mModObj.mOutLine != null ? mModObj.mOutLine.Phi.ToString("F4") :"0" ;
            tb_Dist.TextStr = mModObj.mOutLine != null ? mModObj.mOutLine.Dist.ToString("F4") :"0";
        }
        private void uiLink_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mModObj.Name, mModObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
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
        private void uiLink_BtnDec(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            if (UIBtn != null)
            {
                switch (UIBtn.Parent.GetType().Name)
                {
                    case "UILinkData":
                        UILinkData mUILinkData = (UILinkData)UIBtn.Parent;
                        mUILinkData.Values.Text = "链接数据";
                        break;
                    case "UILinkText":
                        UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                        mUILinkText.Values.Text = "0";
                        break;
                }
                return;
            }
        }
        private void tb_Describle_TextChanged(object sender, EventArgs e)
        {
            mModObj.ModInfo.Remarks = tb_Describle.Text.Trim();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
