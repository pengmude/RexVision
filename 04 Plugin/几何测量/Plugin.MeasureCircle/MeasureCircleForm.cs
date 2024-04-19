using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HalconDotNet;

using VisionCore;

using RexView;
using RexConst;
using RexHelps;
using Rex.UI;

namespace Plugin.MeasCircle
{
    public partial class MeasCircleForm: FormBase
    {
        MeasCircleObj mObj;
        /// <summary> 区域列表 </summary>
        Dictionary<string, RexView.ROI> mRoiList = new Dictionary<string, RexView.ROI>();
        public MeasCircleForm(MeasCircleObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            InitImage();
            btn_Run_Click(null, null);
            mWindowH.hControl.MouseUp += Hwindow_MouseUp;
        }
        protected void InitImage()
        {
            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
            ShowHRoi();
            InitCircle();
        }
        public void InitCircle()
        {
            if (mObj.TranCircle.FlagLineStyle != null)
            {
                mWindowH.WindowH.genCircle(mObj.ModInfo.Name, mObj.TranCircle.CenterX, mObj.TranCircle.CenterY, mObj.TranCircle.Radius, ref mRoiList);
            }
            else if (mObj.mRImage != null)
            {
                mWindowH.WindowH.genCircle(mObj.ModInfo.Name, mObj.mRImage.Height / 2, mObj.mRImage.Width / 2, 30, ref mRoiList);
            }
            else
            {
                mWindowH.WindowH.genCircle(mObj.ModInfo.Name, 500, 500, 100, ref mRoiList);
            }
        }
        private void Hwindow_MouseUp(object sender, MouseEventArgs e)
        {
            RexView.ROI roi = mWindowH.WindowH.smallestActiveROI(out string info, out string index);
            if (index.Length > 0)
            {
                mObj.mIntCircle = (ROICircle)roi;
                btn_Run_Click(null, null);
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ShowHRoi();
            ObjToForm();
            this.Close();
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
                if(mObj.TranCircle.Radius>0)
                {
                    mWindowH.WindowH.DispROI(mObj.ModInfo.Name, mObj.TranCircle);
                }
                else
                {
                    mWindowH.WindowH.DispROI(mObj.ModInfo.Name, mObj.mIntCircle);
                }
            }
        }
        public override void  FormToObj()
        {
            mObj.mMeasInfo = RexMeas1.GetMeasInfo();
            mObj.mImages = uiLink_Image.Values.Text;
            mObj.mCoordName = uiLink_Coord.Values.Text;
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
        }
        public override void ObjToForm()
        {
            try
            {
                RexMeas1.SetMeasInfo(mObj.mMeasInfo);
                uiLink_Image.Values.Text = mObj.mImages;
                uiLink_Coord.Values.Text = mObj.mCoordName;
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
                uitb_Remark.Text = mObj.ModInfo.Remarks;

                mObj.Coord = (Coord_Info)mObj.mSloVar.FirstOrDefault(c => c.mModName == mObj.mCoordName.Split(':')[0]).mDataValue;
                nudCenterX.Value = mObj.mOutCircle.CenterX;//结果需要转换(decimal)(mObj.mOutCircle.CenterX * mObj.mRImage.ScaleX)
                nudCenterY.Value =mObj.mOutCircle.CenterY;
                nudRadus.Value = mObj.mOutCircle.Radius;
              
            }
            catch (Exception ex)
            {
              Log.Error( mObj.ModInfo.Name + ex.Message );
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
                }
                InitImage();
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
                        mUILinkData.Values.Text = "数据链接";
                        break;
                    case "UILinkText":
                        UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                        mUILinkText.Values.Text = "数据链接";
                        if (mUILinkText.Name.Contains("Coord"))
                        {
                            mObj.Coord = new Coord_Info();
                        }
                        break;
                }
                return;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
