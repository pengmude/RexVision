using HalconDotNet;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using ROI = RexView.ROI;
namespace Plugin.Matching
{
    public partial class MatchingForm : FormBase
    {
        bool Studying = false;
        MatchingObj mObj;
        public MatchingForm(MatchingObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void MatchingForm_Load(object sender, EventArgs e)
        {
            InitImage();
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;
            mWindowH.hControl.MouseMove += Hwindow_MouseMoved;// new MouseEventHandler(MouseMoved);
        }
        private void InitImage()
        {
            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            ShowHRoi();
            InitHRoi();
            ShowTemp();
            ShowHText();
        }
        private void Hwindow_MouseMoved(object sender, MouseEventArgs e)
        {
            ShowHText();
        }
        private void Hwindow_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ROI roi = mWindowH.WindowH.smallestActiveROI(out string info, out string index);

                if (index.Length < 1) return;
                mObj.mRoiList[index] = roi;
                ShowHText();
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        private void InitHRoi()
        {
            //mObj.mRoiList.Clear();
               RImage mImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            if (mObj.mRoiList.ContainsKey(mObj.ModInfo.Name + ROIDefine.Search))
            {
                ROIRectangle1 ROIRect1 = (ROIRectangle1)mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Search];
                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Search, ROIRect1.row1, ROIRect1.col1, ROIRect1.row2, ROIRect1.col2, ref mObj.mRoiList);
            }
            else if (mImage != null)
            {
                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Search, 5, 5, mImage.Height - 5, mImage.Width - 5, ref mObj.mRoiList);
            }
            else
            {
                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Search, 5, 5, 250, 250, ref mObj.mRoiList);
            }
        }
        private void bt_Run_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mObj.mRoiList.ContainsKey(mObj.ModInfo.Name + ROIDefine.Templet)) { Log.Error("请先设置模板!"); return; }
                FormToObj();
                mObj.RunObj();
                ShowHRoi();
                ObjToForm();
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        private void ShowHText()
        {
            if (mObj.mRoiList.Count == 0 || mObj.mRImage == null || mObj.mModelImage == null) return;
            HTuple info = mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Search].GetModelData();
            uiLink_StartX.Values.Text = info.DArr[1].ToString("f0");
            uiLink_StartY.Values.Text = info.DArr[0].ToString("f0");
            uiLink_EndX.Values.Text = info.DArr[2].ToString("f0");
            uiLink_EndY.Values.Text = info.DArr[3].ToString("f0");
            if (info.DArr[2] > mObj.mRImage.Height || info.DArr[3] > mObj.mRImage.Width)
            {
                //ROIRectangle1 ROIRect1 = new ROIRectangle1(double.Parse(mObj.mStarX), double.Parse(mObj.mStarY), mObj.mRImage.Height - 5, mObj.mRImage.Width - 5);
                //mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Search] = ROIRect1;
            }
            ShowTool.SetFont(mWindowH.hControl.HalconWindow, 10, "mono", "false", "false");
            ShowTool.SetMsg(mWindowH.hControl.HalconWindow, "搜索区域", "image", info.DArr[1] + 5, info.DArr[0] + 5, "cyan", "false");

            if (Studying & mObj.mRoiList.ContainsKey(mObj.ModInfo.Name + ROIDefine.Templet))
            {
                HTuple info1 = mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Templet].GetModelData();
                ShowTool.SetMsg(mWindowH.hControl.HalconWindow, "学习区域", "image", info1.DArr[1], info1.DArr[0], "cyan", "false");
            }
        }
        private void ShowTemp()
        {
            try
            {
                if (mObj.mRImage == null || mObj.mModelImage == null) return;
                //模板区域
                HRegion ModeRegion = mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Templet].GetRegion();
                HRegion OutModeRegion = ((HShapeModel)mObj.mModelImage).GetShapeModelContours(1);
                //在模板窗口显示模板
                HOperatorSet.ReduceDomain(mObj.mRImage, ModeRegion, out HObject CutImage);
                HOperatorSet.CropDomain(CutImage, out HObject OutImage);
                //求中心
                HOperatorSet.AreaCenter(ModeRegion, out HTuple FormArea, out HTuple FormY, out HTuple FormX);
                HOperatorSet.AreaCenter(OutImage, out HTuple ToArea, out HTuple ToY, out HTuple ToX);
                //检测结果-对XLD应用任意加法 2D 变换
                HOperatorSet.VectorAngleToRigid(0, 0, 0, ToY - (FormY - mObj.mMathCoord.Y), ToX - (FormX - mObj.mMathCoord.X), 0, out HTuple tempMat2D);
                HXLDCont contour_xld = ((HShapeModel)mObj.mModelImage).GetShapeModelContours(1).AffineTransContourXld(new HHomMat2D(tempMat2D));
                //显示
                //hWindow_HE1.WindowH.displayImage(new HImage(OutImage));
                hWindow_HE1.HobjectToHimage(OutImage);
                hWindow_HE1.WindowH.DispHobject(contour_xld, "green");
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        private void ShowHRoi()
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
                ShowHText();
            }
        }
        public override void FormToObj()
        {
            mObj.mModelType = (ModelType)uirb_ModeType.SelectedIndex;
            mObj.mLinkType = (LinkType)uirb_LinkType.SelectedIndex;
            mObj.mSortType = (SortType)uicb_SortType.SelectedIndex;
            mObj.mMinScore = uidd_MatchScore.Value;
            mObj.mMathNumb = (int)uidd_MatchNum.Value;
            mObj.mGreedDeg = uidd_GreedDeg.Value;
            mObj.mMaxOverl = uidd_MaxOverl.Value;

            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mLinkRoi = uiLink_LinkRoi.Values.Text;
            mObj.mStarX = uiLink_StartX.Values.Text;
            mObj.mStarY = uiLink_StartY.Values.Text;
            mObj.mEndX = uiLink_EndX.Values.Text;
            mObj.mEndY = uiLink_EndY.Values.Text;
            //mObj.mStartPhi = (double)nud_StartPhi.Value;
            //mObj.mEndPhi = (double)nud_EndPhi.Value;
            //mObj.mGray = (int)num_Gray.Value;
            switch (uirb_LinkType.SelectedIndex)
            {
                case 0:
                    uiLink_Panel.Visible = true;
                    uiLink_LinkRoi.Visible = false;
                    break;
                case 1:
                    uiLink_Panel.Visible = false;
                    uiLink_LinkRoi.Visible = true;
                    break;
            }
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
        }
        public override void ObjToForm()
        {
            try
            {
                uirb_ModeType.SelectedIndex = (int)mObj.mModelType;
                uirb_LinkType.SelectedIndex = (int)mObj.mLinkType;
                uicb_SortType.SelectedIndex = (int)mObj.mSortType;
                uidd_MatchScore.Value = mObj.mMinScore;
                uidd_MatchNum.Value = mObj.mMathNumb;
                uidd_GreedDeg.Value = mObj.mGreedDeg;
                uidd_MaxOverl.Value = mObj.mMaxOverl;

                uiLink_Image.Values.Text = mObj.mImages;
                uiLink_LinkRoi.Values.Text = mObj.mLinkRoi;
                uiLink_StartX.Values.Text = mObj.mStarX;
                uiLink_StartY.Values.Text = mObj.mStarY;
                uiLink_EndX.Values.Text = mObj.mEndX;
                uiLink_EndY.Values.Text = mObj.mEndY;

                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
                uitb_Remark.Text = mObj.ModInfo.Remarks;

                uitb_X.Text = mObj.mMathCoord.X.ToString();
                uitb_Y.Text = mObj.mMathCoord.Y.ToString();
                uitb_R.Text = mObj.mMathCoord.Phi.ToString();
            }
            catch (Exception ex)
            {
                Log.Info(mObj.ModInfo.Name + ex.Message);
            }
        }
        private void uirb_ModeType_ValueChanged(object sender, int index, string text)
        {
            mObj.mModelType = (ModelType)uirb_ModeType.SelectedIndex;
        }
        private void uirb_LinkType_ValueChanged(object sender, int index, string text)
        {
            switch (uirb_LinkType.SelectedIndex)
            {
                case 0:
                    uiLink_Panel.Visible = true;
                    uiLink_LinkRoi.Visible = false;
                    break;
                case 1:
                    uiLink_Panel.Visible = false;
                    uiLink_LinkRoi.Visible = true;
                    break;
            }
        }
        private void uibt_Press_Click(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            UIPanel ParentUIPanel = (UIPanel)UIBtn.Parent;
            if (UIBtn != null)
            {
                switch (UIBtn.Text)
                {
                    case "确定":
                        {
                            Studying = false; ;
                            switch (mObj.mModelType)
                            {
                                case (ModelType)0:
                                    mObj.mModelImage = new HShapeModel();
                                    break;
                                case (ModelType)1:
                                    mObj.mModelImage = new HNCCModel();
                                    break;
                            }
                            mObj.CreateModel();
                            bt_Run_Click(null, null);
                            ShowTemp();
                        }
                        break;
                    case "取消":
                        {

                        }
                        break;
                    case "学习":
                        {
                            Studying = true;
                            RImage mImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
                            if (mObj.mRoiList.ContainsKey(mObj.ModInfo.Name + ROIDefine.Templet))
                            {
                                ROIRectangle1 ROIRect1 = (ROIRectangle1)mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Templet];
                                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Templet, ROIRect1.row1, ROIRect1.col1, ROIRect1.row2, ROIRect1.col2, ref mObj.mRoiList);
                            }
                            else if (mImage != null)
                            {
                                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Templet, mImage.Height / 2, mImage.Width / 2, mImage.Height / 2 + 50, mImage.Width / 2 + 50, ref mObj.mRoiList);
                            }
                            else
                            {
                                mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Templet, 5, 5, 250, 250, ref mObj.mRoiList);
                            }
                            ShowHText();
                        }
                        break;
                    case "编辑":
                        {
                            if (!mObj.mRoiList.ContainsKey(mObj.ModInfo.Name + ROIDefine.Templet)) { Log.Error("请先设置模板!"); return; }
                            new MatchEditForm(mObj).ShowDialog();
                        }
                        break;
                }
                return;
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
                            if (mUILinkText.Name.Contains("Image"))
                            {
                                ////mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mUILinkText.Values.Text);
                                ////ShowHRoi();
                                //////mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Search, 5, 5, mObj.mRImage.Height - 5, mObj.mRImage.Width - 5, ref mObj.mRoiList);
                                //////ShowTool.SetFont(mWindowH.hControl.HalconWindow, 10, "mono", "false", "false");
                                //////ShowTool.SetMsg(mWindowH.hControl.HalconWindow, "搜索区域", "image",  5, 5, "cyan", "false");
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
                        mUILinkText.Values.Text = "0";
                        break;
                }
                return;
            }
        }
        private void uiLink_Chang(object sender, EventArgs e)
        {
            UITextBox UIBtn = (UITextBox)sender;
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
                        switch (mUILinkText.Name)
                        {
                            case "uiLink_StartX":
                                mObj.mStarX = mObj.IsNumber(mUILinkText.Values.Text) == true ? mUILinkText.Values.Text : GetVar(mUILinkText.Values.Text);
                                break;
                            case "uiLink_StartY":
                                mObj.mStarY = mObj.IsNumber(mUILinkText.Values.Text) == true ? mUILinkText.Values.Text : GetVar(mUILinkText.Values.Text);
                                break;
                            case "uiLink_EndX":
                                mObj.mEndX = mObj.IsNumber(mUILinkText.Values.Text) == true ? mUILinkText.Values.Text : GetVar(mUILinkText.Values.Text);
                                break;
                            case "uiLink_EndY":
                                mObj.mEndY = mObj.IsNumber(mUILinkText.Values.Text) == true ? mUILinkText.Values.Text : GetVar(mUILinkText.Values.Text);
                                break;
                        }
                        //ROIRectangle1 ROIRect1 = new ROIRectangle1(double.Parse(mObj.mStarX), double.Parse(mObj.mStarY), double.Parse(mObj.mEndX), double.Parse(mObj.mEndY));
                        //mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Search] = ROIRect1;
                        //ShowHRoi();
                        break;
                }
                return;
            }
        }
        private string GetVar(string str)
        {
            try
            {
                return Var.GetLinkData(mObj.mSloVar, str).Split('|')[2];
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            return "0";
            }
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Templet] == null || mObj.mRoiList[mObj.ModInfo.Name + ROIDefine.Templet] == null)
            {
                MessageBox.Show("请设置模板区域和搜索区域");
                btn_Run.Enabled = true;
                return;
            }
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
