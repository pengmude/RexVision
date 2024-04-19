
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VisionCore;

using RexConst;

namespace Plugin.MeasCalib
{
    public partial class MeasCalibForm: FormBase
    {
        private MeasCalibObj mObj;
        public MeasCalibForm(MeasCalibObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            if (ObjBase == null) return;
            InitCurrentCmbImgList();
            UpdateParam(null, null);
            UPData();
            ShowHRoi();
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_registerImg.DataSource = imgList;
            if (mObj.mImages != null & mObj.Image==null)
            {
                mObj.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages)).Clone();
                mWindow.Image = mObj.Image;
            }
        }
        /// <summary>
        /// 更新类参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateParam(object sender, EventArgs e)
        {
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.mImages = cmb_registerImg.Text;
        }
        /// <summary>
        /// 更新显示到窗体框
        /// </summary>
        public void ShowHRoi()
        {
            try
            {
                if (mObj.mRImage != null/* && cell.mRImage.IsInitialized()*/)
                {
                    mWindow.HWindowID.SetDraw("margin");
                    mWindow.HWindowID.SetColor("#0000FF");
                    if (mObj.xldMark!=null &mObj.xldMark.IsInitialized())
                    {
                        mWindow.HWindowID.DispXld(mObj.xldMark);
                    }
                    if (mObj.DetectRegion != null && mObj.DetectRegion.IsInitialized())
                    {
                        mWindow.HWindowID.SetColor("green");
                        mWindow.HWindowID.DispXld(mObj.DetectRegion);
                    }
                    if (mObj.DisableRegion != null && mObj.DisableRegion.IsInitialized())
                    {
                        mWindow.HWindowID.SetColor("red");
                        mWindow.HWindowID.DispXld(mObj.DisableRegion);
                    }

                    List<HText> roiTextList =mObj.Image.mHText.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                    foreach (HText roi in roiTextList)
                    {
                        if (roi != null && roi.roiType == HRoiType.文字显示)
                        {
                           ShowMsg.SetFont(mWindow.HWindowID, roi.size, roi.font, "true", "false");
                           ShowMsg.SetMsg(mWindow.HWindowID, roi.text, "image", roi.row, roi.col, roi.drawColor, "false");
                        }
                    }
                }
            }
            catch { }
        }
        /// <summary>
        ///  更新数据到窗体
        /// </summary>
        public void UPData()
        {
            try
            {
                string m_FlowID = "U" + mObj.ModInfo.Encode.ToString("D4");//ID-工具-备注
                this.Text = mObj.ModInfo.Name;
                uitb_Remark.Text = mObj.ModInfo.Remarks;
                if (mObj.Calibrated)
                {
                    cmb_registerImg.Text = mObj.mImages;
                    cmb_BoardType.SelectedIndex = mObj.BoardType;
                    numericUpDown.Value = (decimal)mObj.Distance;
                    lScaleX.Text = "X=" + mObj.Image.ScaleX.ToString("F6");
                    lScaleY.Text = "Y=" + mObj.Image.ScaleY.ToString("F6");
                    lRMS.Text = "RMS=" + mObj.RMS.ToString("F6");
                }
            }
            catch { }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mObj.Distance = (double)numericUpDown.Value;
                mObj.BoardType = cmb_BoardType.SelectedIndex;
                mObj.mImages = cmb_registerImg.Text;
                mObj.Calib();//再检测
                mObj.RunObj();
                ShowHRoi();
                UpdateParam(null, null);
                UPData();
            }
            catch { }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                mObj.Distance = (double)numericUpDown.Value;
                mObj.BoardType = cmb_BoardType.SelectedIndex;
                mObj.mImages = cmb_registerImg.Text;
                mObj.RunObj();
                ShowHRoi();
                UPData();
            }
            catch { }
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        private void bt_ROI_Click(object sender, EventArgs e)
        {
            double row1, col1, row2, col2;
            mWindow.HWindowID.SetDraw("margin");
            Button button = sender as Button;
            switch (button.Text)
            {
                case "兴趣区域":
                    mWindow.DrawRectangle1("green", out row1, out col1, out row2, out col2);
                    mObj.DetectRegion = new HRegion(row1, col1, row2, col2);
                    break;
                case "屏蔽区域":
                    if (mObj.DisableRegion == null || !mObj.DisableRegion.IsInitialized())
                    {
                        mObj.DisableRegion = new HRegion();
                    }
                    mObj.DisableRegion = mWindow.SetROI(mObj.DisableRegion);
                    break;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mObj.mRImage != null)
            {
                mObj.Image = mObj.mRImage;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (mObj.Image != null)
            {
                mWindow.Image = mObj.Image;
            }
        }
        private void cmb_registerImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mImages = cmb_registerImg.Text;
            if ((mObj.mImages != null))
            {
                mWindow.Image = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
                mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            }
        }


    }
}
