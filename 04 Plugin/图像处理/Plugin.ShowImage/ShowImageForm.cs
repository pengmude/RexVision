using RexConst;
using System;
using System.Collections.Generic;
using VisionCore;


namespace Plugin.ShowImage
{
    public partial class ShowImageForm : FormBase
    {
        private bool GetImage;
        private ShowImageModObj mObj;
        public ShowImageForm(ShowImageModObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ShowImageForm_Load(object sender, EventArgs e)
        {
            InitCurrentCmbImgList();
            UpDataForm();
            UpDataParam();
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_CurrentImgName.DataSource = imgList;
        }
        protected void UpDataForm()
        {
            if (mObj!=null)
            {
                string m_FlowID = "U" + mObj.ModInfo.Encode.ToString("D4");//ID-工具-备注
                this.Text = mObj.ModInfo.Name;
                uitb_Remark.Text = mObj.ModInfo.Remarks;
                cmb_Screen.Text = mObj.m_Screen.ToString();
            }
        }
        protected void UpDataParam()
        {
            if (mObj != null)
            {
                mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
                mObj.mImages = cmb_CurrentImgName.Text;
                mObj.m_Screen = int.Parse(cmb_Screen.Text==""? "0": cmb_Screen.Text);
                if (mObj.mImages != null)
                {
                    mWindow.Image = mObj.mRImage;
                }
            }
        }
        /// <summary>
        /// 更新显示到窗体
        /// </summary>
        public void UpDateWindow()
        {
            try
            {
                if (mObj.m_OutImage != null)
                {
                    mWindow.HWindowID.SetDraw("margin");
                    mWindow.HWindowID.SetColor("#0000FF");
                    mWindow.Image = mObj.m_OutImage;
                }
            }
            catch { }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            ObjBase.RunObj();
            UpDateWindow();
            GetImage = true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.m_Screen = cmb_Screen.SelectedIndex;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetImage == true)
            {
                GetImage = false;
                try
                {
                    //mWindow.Image = ((ShowImageObj)ObjBase).mRImage;
                    //mWindow.DispImageFit();
                }
                catch (Exception ex)
                {
                }
            }
        }

    }
}
