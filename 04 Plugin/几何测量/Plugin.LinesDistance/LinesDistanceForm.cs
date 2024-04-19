﻿using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.LinesDistance
{
    public partial class LinesDistanceForm : FormBase
    {
        private LinesDistanceObj mObj ;
        public LinesDistanceForm(LinesDistanceObj Obj):base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void LinesDistanceForm_Load(object sender, EventArgs e)
        {
            InitImage();
            ShowHRoi();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowHRoi();
        } /// <summary>初始化当前图像列表</summary>
        protected void InitImage()
        {
            mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
        }
        public override void  FormToObj()
        {
            mObj.mImages= uilk_Image.Values.Text;
            mObj.mLine1 = uilk_Line1.Values.Text;
            mObj.mLine2 = uilk_Line2.Values.Text;
            mObj.mLineR = uilk_LineR.Values.Text;
            mObj.mValueMode = (ValueMode)Enum.Parse(typeof(ValueMode), uilk_ValueMode.Text);
            mObj.mPullType = (PullType)Enum.Parse(typeof(PullType), uilk_PullType.Text);
            mObj.mConverValue = uicb_ConverValue.Checked;
            mObj.mRemov = int.Parse(uilk_Remov.TextStr);
            mObj.mExtract = int.Parse(uilk_Extract.TextStr);
            mObj.mRemovPer = uicb_RemovPer.Checked;
            mObj.mExtractPer = uicb_ExtractPer.Checked;
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.ShowROI = uicb_Roi.Checked;
            mObj.ShowArea = uicb_Area.Checked;
            mObj.ShowResult = uicb_Result.Checked;
        }
        public override void ObjToForm()
        {
            try
            {
                uilk_Image.Values.Text = mObj.mImages;
                uilk_Line1.Values.Text= mObj.mLine1;
                uilk_Line2.Values.Text= mObj.mLine2;
                uilk_LineR.Values.Text = mObj.mLineR;
                uilk_ValueMode.Text = mObj.mValueMode.ToString();
                uilk_PullType.Text=mObj.mPullType.ToString();
                uicb_ConverValue.Checked = mObj.mConverValue;
                uilk_Remov.TextStr = mObj.mRemov.ToString();
                uilk_Extract.TextStr = mObj.mExtract.ToString();
                uicb_RemovPer.Checked = mObj.mRemovPer;
                uicb_ExtractPer.Checked= mObj.mExtractPer;
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
                uitb_Remark.Text = mObj.ModInfo.Remarks;
            }
            catch (Exception ex)
            {
                Log.Error( mObj.ModInfo.Name + ex.Message );
            }
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
        private void uilk_BtnAdd(object sender, EventArgs e)
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
                        case "UILinkText":
                            UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                            mUILinkText.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                    }
                    FormToObj();
                    return;
                }
            }
        }
        private void uilk_BtnDec(object sender, EventArgs e)
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
