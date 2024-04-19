
using RexConst;
using System;
using System.Collections.Generic;
using VisionCore;


namespace Plugin.DistortionCalib
{
    public partial class DistortionCalibForm: FormBase
    {
        private DistortionCalibObj mObj;
        public DistortionCalibForm(DistortionCalibObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            if (ObjBase == null) return;
            InitCurrentCmbImgList();
            UPData();
            UpDateParam();
            UpDateWindow();
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_registerImg.DataSource = imgList;
            if (mObj.mImages != null & mObj.DistortionImage == null)
            {
                mObj.DistortionImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages)).Clone();
                mWindow.Image = mObj.DistortionImage;
            }
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
                }
            }
            catch { }
        }
        /// <summary>
        /// 更新参数到mObj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpDateParam()
        {
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.mImages = cmb_registerImg.Text;
        }
        /// <summary>
        /// 更新显示到窗体
        /// </summary>
        public void UpDateWindow()
        {
            try
            {
                if (mObj.DistortionImage != null)
                {
                    mWindow.HWindowID.SetDraw("margin");
                    mWindow.HWindowID.SetColor("#0000FF");
                    mWindow.Image = mObj.DistortionImage;
                }
            }
            catch { }
        }
        //*改变径向畸变:模式“full - size”
        //*改变径向畸变:模式“自适应”
        //*改变径向畸变:模式“保存分辨率”
        private void btn_Run_Click(object sender, EventArgs e)
        {
            try
            {
                mObj.mImages = cmb_registerImg.Text;
                mObj.DistortionMode = cB_Mode.Text;
                mObj.RunObj();
                UpDateWindow();
                UPData();
            }
            catch { }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mObj.DistortionImage != null)
            {
                mWindow.Image = mObj.mRImage;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (mObj.DistortionImage != null)
            {
                mWindow.Image = mObj.DistortionImage;
            }
        }
        private void cmb_registerImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mImages = cmb_registerImg.Text;
            if ((mObj.mImages != null))
            {
                mWindow.Image = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            }
        }
    }
}
