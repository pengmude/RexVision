using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.LumaCheck
{
    public partial class LumaCheckForm : FormBase
    {
        private LumaCheckObj mObj;
        public LumaCheckForm(LumaCheckObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            ShowHRoi();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ShowHRoi();
            ObjToForm();
        }
        /// <summary>显示当前图片和检测内容</summary>
        public void ShowHRoi()
        {
            if (mObj.mRImage != null)
            {
                mWindowH.HobjectToHimage(mObj.mRImage);
                List<HRoi> roiList = mObj.mRImage.mHRoi.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                foreach (HRoi roi in roiList)
                {
                    if (roi.CellType.Contains(mObj.ModInfo.Plugin))
                    {
                        if (roi.roiType == HRoiType.文字显示)
                        {
                            HText roiText = (HText)roi;
                            ShowTool.SetFont(mWindowH.hControl.HalconWindow, roiText.size, roiText.font, "false", "false");
                            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                        }
                        else
                        {
                            mWindowH.WindowH.DispHobject(roi.hobject, roi.drawColor);
                        }
                    }
                }
            }
        }
        public override void FormToObj()
        {
            mObj.mImages = uilk_Image.Values.Text;
            mObj.mRoi = uilk_Roi.Values.Text;
            mObj.mMinThreshod = uidd_MinThreshold.Value;
            mObj.mMaxThreshod = uidd_MaxThreshold.Value;
            mObj.ShowROI = uicb_Roi.Checked;
            mObj.ShowArea = uicb_Area.Checked;
            mObj.ShowResult = uicb_Result.Checked;
            mObj.ModInfo.Remarks = uitb_Remark.Text;
        }
        public override void ObjToForm()
        {
            uilk_Roi.Values.Text = mObj.mRoi;
            uilk_Image.Values.Text = mObj.mImages;
            uidd_MinThreshold.Value = mObj.mMinThreshod;
            uidd_MaxThreshold.Value = mObj.mMaxThreshod;
            uicb_Roi.Checked = mObj.ShowROI;
            uicb_Area.Checked = mObj.ShowArea;
            uicb_Result.Checked = mObj.ShowResult;
            uitb_Remark.Text = mObj.ModInfo.Remarks;

            uicb_Roi.Checked = mObj.ShowROI;
            uitb_Area.Text = mObj.mLuma_Info.Area.ToString("F0");
            uitb_Mean.Text = mObj.mLuma_Info.Mean.ToString("F0");
            uitb_Min.Text = mObj.mLuma_Info.Min.ToString("F0");
            uitb_Max.Text = mObj.mLuma_Info.Max.ToString("F0");
            uitb_Range.Text = mObj.mLuma_Info.Range.ToString("F0");

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
                    mObj.mImages = uilk_Image.Values.Text;
                    mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
                    ShowHRoi();
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
                        mUILinkText.Values.Text = "数据链接";
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
