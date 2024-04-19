using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VisionCore;
using System.Diagnostics;
using RexConst;
using RexHelps;
using Rex.UI;
using RexView;
using System.Windows.Forms;

namespace Plugin.CreateROI
{
    public partial class CreateROIForm : FormBase
    {
        CreateROIObj mObj;
        /// <summary> 区域列表 </summary>
        Dictionary<string, RexView.ROI> mRoiList = new Dictionary<string, RexView.ROI>();
        public CreateROIForm(CreateROIObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void CreateROIForm_Load(object sender, EventArgs e)
        {
            InitImage();
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;
        }
        private void Hwindow_MouseUp(object sender, MouseEventArgs e)
        {
            RexView.ROI roi = mWindowH.WindowH.smallestActiveROI(out string info, out string index);
            if (index.Length < 1) return;
            mRoiList[index] = roi;
            switch (uirb_RoiType.SelectedIndex)
            {
                case 0:
                    mObj.mIntRect2 = (ROIRectangle2)roi;
                    break;
                case 1:
                    mObj.mIntCircle = (ROICircle)roi;
                    break;
            }
        }
        private void uirb_RoiType_ValueChanged(object sender, int index, string text)
        {
            mObj.mROIType = (ROIType)uirb_RoiType.SelectedIndex;
            InitImage();
        }
        protected void InitImage()
        {
            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            InitHRoi();
            ShowHRoi();
        }
        public void InitHRoi()
        {
            switch (uirb_RoiType.SelectedIndex)
            {
                case 0:
                    if (mObj.TranRect2 != null)
                    {
                        mWindowH.WindowH.genRect2(mObj.ModInfo.Name + ROIType.Rectangle2, mObj.TranRect2.midR, mObj.TranRect2.midC, mObj.TranRect2.phi, mObj.TranRect2.length1, mObj.TranRect2.length2, ref mRoiList);
                    }
                    else if (mObj.mRImage != null)
                    {
                        mWindowH.WindowH.genRect2(mObj.ModInfo.Name + ROIType.Rectangle2, 200, 200, 0, 100, 50, ref mRoiList);
                    }
                    else
                    {
                        mWindowH.WindowH.genRect2(mObj.ModInfo.Name + ROIType.Rectangle2, 200, 200, 0, 100, 50, ref mRoiList);
                    }
                    break;
                case 1:
                    if (mObj.TranCircle != null)
                    {
                        mWindowH.WindowH.genCircle(mObj.ModInfo.Name + ROIType.Circle, mObj.TranCircle.CenterX, mObj.TranCircle.CenterY, mObj.TranCircle.Radius, ref mRoiList);
                    }
                    else if (mObj.mRImage != null)
                    {
                        mWindowH.WindowH.genCircle(mObj.ModInfo.Name + ROIType.Circle, 500, 500, 100, ref mRoiList);
                    }
                    else
                    {
                        mWindowH.WindowH.genCircle(mObj.ModInfo.Name + ROIType.Circle, 500, 500, 100, ref mRoiList);
                    }
                    break;
            }
        }
        public override void FormToObj()
        {
            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mCoordName = uiLink_Coord.Values.Text;
            mObj.mCropImage = uicb_CropImage.Checked;
            mObj.mROIType = (ROIType)uirb_RoiType.SelectedIndex;
            mObj.mCentreX = uiLink_CentreX.Values.Text;
            mObj.mCentreY = uiLink_CentreY.Values.Text;
            mObj.ShowROI = uicb_Roi.Checked;
            mObj.ShowArea = uicb_Area.Checked;
            mObj.ShowResult = uicb_Result.Checked;
            mObj.ModInfo.Remarks = uitb_Remark.Text;
        }
        public override void ObjToForm()
        {
            uiLink_Image.Values.Text = mObj.mImages;
            uiLink_Coord.Values.Text = mObj.mCoordName;
            uicb_CropImage.Checked = mObj.mCropImage;
            uirb_RoiType.SelectedIndex = (int)mObj.mROIType;
            uiLink_CentreX.Values.Text = mObj.mCentreX;
            uiLink_CentreY.Values.Text = mObj.mCentreY;

            uicb_Roi.Checked = mObj.ShowROI;
            uicb_Area.Checked = mObj.ShowArea;
            uicb_Result.Checked = mObj.ShowResult;
            uitb_Remark.Text = mObj.ModInfo.Remarks;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowHRoi();
        }
        /// <summary>显示当前检测内容</summary>
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

                switch (uirb_RoiType.SelectedIndex)
                {
                    case 0:
                        if (mObj.TranRect2 != null)
                        {
                            if (mObj.TranRect2.midC > 0)
                            {
                                mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Rectangle2, mObj.TranRect2);
                            }
                        }
                        else
                        {
                            mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Rectangle2, mRoiList[mObj.ModInfo.Name + ROIType.Rectangle2]);
                        }
                        break;
                    case 1:
                        if (mObj.TranCircle != null)
                        {
                            if (mObj.TranCircle.Radius > 0)
                            {
                                mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Circle, mObj.TranCircle);
                            }
                        }
                        else
                        {
                            mWindowH.WindowH.DispROI(mObj.ModInfo.Name + ROIType.Circle, mRoiList[mObj.ModInfo.Name + ROIType.Circle]);
                        }
                        break;
                }

            }
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
                            if (mUILinkText.Name.Contains("Coord"))
                            {
                                mObj.mCoordName = mUILinkText.Values.Text;
                                mObj.Coord = (Coord_Info)mObj.mSloVar.FirstOrDefault(c => c.mModName == mObj.mCoordName.Split(':')[0]).mDataValue;
                            }
                            break;
                    }
                    InitImage();
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
                InitImage();
                return;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
