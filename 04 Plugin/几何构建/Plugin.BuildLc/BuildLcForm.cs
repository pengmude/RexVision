using Rex.UI;
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

namespace Plugin.BuildLc
{
    public partial class BuildLcForm : FormBase
    {
        private BuildLcObj mObj ;
        public BuildLcForm(BuildLcObj Obj):base(Obj)
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
        }
        /// <summary>初始化当前图像列表</summary>
        protected void InitImage()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            mObj.mRImage = (RImage)Var.GetImage(mObj.mSloVar, mObj.mImages);
        }
        public override void  FormToObj()
        {
            mObj.mImages= uilk_Image.Values.Text;
            mObj.mPointX = uilk_PointX.Values.Text;
            mObj.mPointY = uilk_PointY.Values.Text;
            mObj.mLine1 = uilk_Line1.Values.Text;
            mObj.mLine2 = uilk_Line2.Values.Text;
            mObj.mLineR = uilk_LineR.Values.Text;
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
                uilk_PointX.Values.Text= mObj.mPointX;
                uilk_PointY.Values.Text= mObj.mPointY;
                uilk_Line1.Values.Text= mObj.mLine1;
                uilk_Line2.Values.Text= mObj.mLine2;
                uilk_LineR.Values.Text = mObj.mLineR;
                tb_X.TextStr = mObj.OutResult[0].ToString();
                tb_Y.TextStr = mObj.OutResult[1].ToString();
                tb_L.TextStr = mObj.OutResult[2].ToString();
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
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
