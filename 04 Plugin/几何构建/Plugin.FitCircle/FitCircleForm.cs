using Rex.UI;
using RexConst;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.FitCircle
{
    public partial class FitCircleForm: FormBase
    {
        private FitCircleObj mObj;
        public FitCircleForm(FitCircleObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            ShowHRoi();
            if (mWindow.Image != null)
            {
                mWindow.DispImageFit();
                mWindow.RePaint += new RexView.DelegateRePaint(ShowHRoi);
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ShowHRoi();
            ObjToForm();
        }
        /// <summary>显示当前检测内容 </summary>
        public void ShowHRoi()
        {
            try
            {
                if (mObj.mRImage != null)
                {
                    List<HRoi> roiList = mObj.mRImage.mHRoi.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                    mWindow.Image = mObj.mRImage;
                    foreach (HRoi roi in roiList)
                    {
                         if (roi.CellType.Contains(mObj.ModInfo.Plugin))
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
            catch { }
        }
        public override void  FormToObj()
        {
            mObj.mP1X = ui_P1X.Values.Text;
            mObj.mP1Y = ui_P1Y.Values.Text;
            mObj.mP2X = ui_P2X.Values.Text;
            mObj.mP2Y = ui_P2Y.Values.Text;
            mObj.mP3X = ui_P3X.Values.Text;
            mObj.mP3Y = ui_P3Y.Values.Text;
            mObj.mImages = ui_Image.Values.Text;
        }
        public override void ObjToForm()
        {
            ui_P1X.Values.Text = mObj.mP1X;
            ui_P1Y.Values.Text = mObj.mP1Y;
            ui_P2X.Values.Text = mObj.mP2X;
            ui_P2Y.Values.Text = mObj.mP2Y;
            ui_P3X.Values.Text = mObj.mP3X;
            ui_P3Y.Values.Text = mObj.mP3Y;
            ui_Image.Values.Text = mObj.mImages;
            uitb_Remark.Text = mObj.ModInfo.Remarks;

            tb_CoreX.TextStr = mObj.mOutCircle != null ? mObj.mOutCircle.CenterX.ToString("F4") : "0";
            tb_CoreY.TextStr = mObj.mOutCircle != null ? mObj.mOutCircle.CenterY.ToString("F4") : "0";
            tb_Radius.TextStr = mObj.mOutCircle != null ? mObj.mOutCircle.Radius.ToString("F4") : "0";
        }
        private void uiLink_BtnAdd(object sender, EventArgs e)
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
        private void uiLink_BtnDec(object sender, EventArgs e)
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
        private void tb_Describle_TextChanged(object sender, EventArgs e)
        {
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ShowHRoi();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
