using HalconDotNet;
using Rex.UI;
using RexConst;
using RexHelps;
using RexView;
using RexView.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using ROI = RexView.ROI;
namespace Plugin.Matching
{
    public partial class MatchEditForm : FormBase
    {
        MatchingObj mObj;
        ROIPoint coordline;
        public MatchEditForm(MatchingObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
            uicb_CompPolar.DataSource = Enum.GetNames(typeof(CompType));
            uicb_CompPolar.SelectedIndex = 0;
        }
        private void MatchSetForm_Load(object sender, EventArgs e)
        {
            ShowTemp();
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;
            mWindowH.hControl.MouseMove += Hwindow_MouseMoved;// new MouseEventHandler(MouseMoved);
        }
        private void Hwindow_MouseMoved(object sender, MouseEventArgs e)
        {

        }
        private void Hwindow_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                ROI roi = mWindowH.WindowH.smallestActiveROI(out string info, out string index);

                if (index.Length < 1) return;
                mObj.mRoiList[index] = roi;
                coordline = (ROIPoint)mObj.mRoiList[index];
                mObj.mChangCoord.X = mObj.mModeCoord.X + coordline.midR;
                mObj.mChangCoord.Y = mObj.mModeCoord.Y + coordline.midC;
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        private void bt_Run_Click(object sender, EventArgs e)
        {
            try
            {
                FormToObj();
                mObj.CreateModel();
                mObj.RunObj();
                ObjToForm();
                ShowTemp();
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
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

                coordline = new ROIPoint(ToY - (FormY - mObj.mMathCoord.Y), ToX - (FormX - mObj.mMathCoord.X));

                //mWindowH.WindowH.genCoordLine(mObj.ModInfo.Name, 25, 25, 25, 200, ref mObj.mRoiList);
                //mWindowH.WindowH.genCoordLine(mObj.ModInfo.Name, ToY - (FormY - mObj.mMathCoord.Y), ToX - (FormX - mObj.mMathCoord.X), ToY - (FormY - mObj.mMathCoord.Y), 20, ref mRoi);
                //检测中心-为输入点生成一个十字形状的 XLD 轮廓
                HOperatorSet.GenCrossContourXld(out HObject cross, ToY - (FormY - mObj.mMathCoord.Y), ToX - (FormX - mObj.mMathCoord.X), 10, 0);
                //显示
                //mWindowH.WindowH.displayImage(new HImage(OutImage));

                mWindowH.HobjectToHimage(OutImage);
                mWindowH.WindowH.DispHobject(contour_xld, "green");
                mWindowH.WindowH.DispHobject(cross, "green");
                mWindowH.WindowH.DispROI(mObj.ModInfo.Name, coordline);
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        public override void FormToObj()
        {
            try
            {
                mObj.mThreshold = (int)uidd_Threshold.Value;
                mObj.mMinLenght = uidd_MinLenght.Value;
                mObj.mStarLevels = (int)uidd_StarLevels.Value;
                mObj.mOverLevels = (int)uidd_OverLevels.Value;
                mObj.mStarPhi = uidd_StarPhi.Value;
                mObj.mOverPhi = uidd_OverPhi.Value;
                mObj.mMinScale = uidd_MinScale.Value;
                mObj.mMaxScale = uidd_MaxScale.Value;
                mObj.mCompType = (CompType)uicb_CompPolar.SelectedIndex;
                mObj.mEditType = (EditType)uirb_EditType.SelectedIndex;
                mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        public override void ObjToForm()
        {
            try
            {

                uidd_Threshold.Value = mObj.mThreshold;
                uidd_MinLenght.Value = mObj.mMinLenght;
                uidd_StarLevels.Value = mObj.mStarLevels;
                uidd_OverLevels.Value = mObj.mOverLevels;
                uidd_StarPhi.Value = mObj.mStarPhi;
                uidd_OverPhi.Value = mObj.mOverPhi;
                uidd_MinScale.Value = mObj.mMinScale;
                uidd_MaxScale.Value = mObj.mMaxScale;
                uicb_CompPolar.SelectedIndex = (int)mObj.mCompType;
                uirb_EditType.SelectedIndex = (int)mObj.mEditType;
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
                uitb_Remark.Text = mObj.ModInfo.Remarks;
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ex.Message);
            }
        }

        private void uirb_ModeType_ValueChanged(object sender, int index, string text)
        {
            //   HRegion finalRegion = new HRegion();
            //finalRegion.GenRectangle1(0.0,0, 25, 25);
            //mObj.mEditType = (EditType)uirb_EditType.SelectedIndex;
            switch (uirb_EditType.SelectedIndex)
            {
                case 0:
                    //mWindowH.hControl.SetViewState(HWndCtrl.MODE_VIEW_NONE);                   
                    //mWindowH.DrawModel = false;
                    //mWindowH.Focus();
                    ////mWindowH.HobjectToHimage(IImage);
                    ShowTemp();
                    //mWindowH.WindowH.DispHobject(finalRegion, "green");
                    break;
                case 1:
                    //mHWndCtrl.SetViewState(HWndCtrl.MODE_PAINT);
                    ShowTemp();
                    //mWindowH.DrawModel = true;
                    ////RexView.ROI ModelSearch = mRoiList[ModInfo.Name + ROIDefine.Search];
                    ////mWindowH.WindowH.genRect1(mObj.ModInfo.Name + ROIDefine.Templet, 5, 5, 250, 250, ref mObj.mRoiList);
                    //finalRegion = this.mWindowH.SetROI(finalRegion, 0);
                    break;
                case 2:
                    //mHWndCtrl.SetViewState(HWndCtrl.MODE_ERASER);
                    ShowTemp();
                    //mWindowH.DrawModel = true;
                    //finalRegion = this.mWindowH.SetROI(finalRegion, 1);
                    break;
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
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
