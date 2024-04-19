using HalconDotNet;
using Rex.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.NPointCal
{
    public partial class NPointCalForm : FormBase
    {
        NPointCalObj mObj;
        public NPointCalForm(NPointCalObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e) { }
        public override void FormToObj()
        {
            //输入设置
            mObj.mDeviceID = uiLink_Image.Values.Text;
            mObj.mCalType = (CalType)uirb_CalType.SelectedIndex;
            mObj.mInputX = uiLink_InPutX.Values.Text;
            mObj.mInputY = uiLink_InPutY.Values.Text;
            //场景选择
            mObj.mCamerType = (CamerType)uirb_CamerType.SelectedIndex;
            mObj.mAngleType = (AngleType)uirb_AngleType.SelectedIndex;
            mObj.mRotateCentre = uicb_RotationCentre.Checked;
            mObj.mMarkX = uidd_MarkX.Value;
            mObj.mMarkY = uidd_MarkY.Value;
            //坐标映射
            mObj.mSpaceX = uidd_SpaceX.Value;
            mObj.mSpaceY = uidd_SpaceY.Value;
            mObj.mBaseX = uidd_BaseX.Value;
            mObj.mBaseY = uidd_BaseY.Value;
            //旋转相关
            mObj.mBaseAngle = uidd_BaseAngle.Value;
            mObj.mAngleNot = uicb_AngleNot.Checked;
            mObj.mPointType = (PointType)uirb_PointType.SelectedIndex;
            mObj.mAutoClear=uicb_AutoClear.Checked;

            //mObj.mNPoint.Clear();
            //for (int i = 0; i < dgv_NPoint.RowCount; ++i)
            //{
            //    NPoint mNPoint = new NPoint();
            //    mNPoint.Index = (int)dgv_NPoint.Rows[i].Cells[0].Value;
            //    mNPoint.ImageX = (double)dgv_NPoint.Rows[i].Cells[1].Value;
            //    mNPoint.ImageY = (double)dgv_NPoint.Rows[i].Cells[2].Value;
            //    mNPoint.RobotX = (double)dgv_NPoint.Rows[i].Cells[3].Value;
            //    mNPoint.RobotY = (double)dgv_NPoint.Rows[i].Cells[4].Value;
            //    mObj.mNPoint.Add(mNPoint);
            //}
        }
        public override void ObjToForm()
        {
            //输入设置
            uiLink_Image.Values.Text = mObj.mDeviceID;
            uirb_CalType.SelectedIndex = (int)mObj.mCalType;
            uiLink_InPutX.Values.Text = mObj.mInputX;
            uiLink_InPutY.Values.Text = mObj.mInputY;
            //场景选择
            uirb_CamerType.SelectedIndex = (int)mObj.mCamerType;
            uirb_AngleType.SelectedIndex = (int)mObj.mAngleType;
            uicb_RotationCentre.Checked = mObj.mRotateCentre;
            uidd_MarkX.Value = mObj.mMarkX;
            uidd_MarkY.Value = mObj.mMarkY;
            //坐标映射
            uidd_SpaceX.Value = mObj.mSpaceX == 0 ? uidd_SpaceX.Value : mObj.mSpaceX;
            uidd_SpaceY.Value = mObj.mSpaceY == 0 ? uidd_SpaceY.Value : mObj.mSpaceY;
            uidd_BaseX.Value = mObj.mBaseX == 0 ? uidd_BaseX.Value : mObj.mBaseX;
            uidd_BaseY.Value = mObj.mBaseY == 0 ? uidd_BaseY.Value : mObj.mBaseY;
            //旋转相关
            uidd_BaseAngle.Value = mObj.mBaseAngle;
            uicb_AngleNot.Checked = mObj.mAngleNot;
            uirb_PointType.SelectedIndex = (int)mObj.mPointType;
            uicb_AutoClear.Checked = mObj.mAutoClear;
            dgv_NPoint.DataSource = mObj.mNPoint.ToArray(); 
        }
        private void ShowResult()
        {          
            HOperatorSet.HomMat2dToAffinePar(mObj.mHomMat2DTransl, out HTuple PixelX, out HTuple PixelY, out HTuple RotationAngle, out HTuple TiltAngle, out HTuple TranslateX, out HTuple TranslateY);
            uitb_PixelX.Text = PixelX.D.ToString("F6");//像素当量X
            uitb_PixelY.Text = PixelY.D.ToString("F6");//像素当量Y
            uitb_RotationAngle.Text = RotationAngle.TupleDeg().D.ToString("F6"); //旋转角度
            uitb_TiltAngle.Text = TiltAngle.TupleDeg().D.ToString("F6");   //倾斜角度
            uitb_TranslX.Text = TranslateX.D.ToString("F6");//平移X
            uitb_TranslY.Text = TranslateY.D.ToString("F6");//平移Y
            uitb_RMS.Text = mObj.mCalibRms.ToString("F6");
            uitb_RotationCenterX.Text = mObj.mRotateCenterX.ToString("F6");//旋转中心X
            uitb_RotationCenterY.Text = mObj.mRotateCenterY.ToString("F6");//旋转中心Y
        }
        private void uibt_Clear_Click(object sender, EventArgs e)
        {
            List<NPoint> point = new List<NPoint>();
            switch((PointType)uirb_PointType.SelectedIndex)
            {
                case PointType.Three:
                    for(int i=1;i<4;++i)
                    {
                        point.Add(new NPoint(i,0,0,0,0));
                    }
                    break;
                case PointType.Nine:
                    for (int i = 1; i < 10; ++i)
                    {
                        point.Add(new NPoint(i, 0, 0, 0, 0));
                    }
                    break;
                case PointType.FourTeen:
                    for (int i = 1; i < 14; ++i)
                    {
                        point.Add(new NPoint(i, 0, 0, 0, 0));
                    }
                    break;
            }
            dgv_NPoint.DataSource = point.ToArray();
        }
        private void uibt_Edit_Click(object sender, EventArgs e)
        {
            NPointEditForm mNPointEditForm = new NPointEditForm(dgv_NPoint, (CalType)uirb_CalType.SelectedIndex);
            mNPointEditForm.ShowDialog();
            dgv_NPoint.DataSource = mNPointEditForm.mEditNPoint;
        }
        private void uicb_ValueChanged(object sender, bool value)
        {
            InitControl();
        }
        private void uirb_ValueChanged(object sender, int index, string text)
        {
            InitControl();
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
                            mObj.mDeviceID = mUILinkData.Values.Text;
                            break;
                        case "UILinkText":
                            UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                            mUILinkText.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                    }
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
        private void InitControl()
        {
            uipl_5Point.Visible = uicb_RotationCentre.Checked;
            uipl_CeckCal.Visible = uicb_CheckCalResult.Checked;
            dgv_NPoint.ReadOnly = !dgv_NPoint.ReadOnly;
            switch ((CamerType)uirb_CamerType.SelectedIndex)
            {
                case CamerType.固定:
                    uipl_Mark.Visible = false;
                    uipl_Angle.Visible = false;
                    break;
                case CamerType.移动:
                    uipl_Mark.Visible = !uicb_RotationCentre.Checked;
                    uipl_Angle.Visible = true;
                    break;
            }
        }
        private void uirb_PointType_ValueChanged(object sender, int index, string text)
        {
            switch ((PointType)uirb_PointType.SelectedIndex)
            {
                case PointType.Three:
                    InitNPoint(3);
                    break;
                case PointType.Nine:
                    InitNPoint(9);
                    break;
                case PointType.FourTeen:
                    InitNPoint(14);
                    break;
            }
        }
        private void InitNPoint(int index)
        {
            int StarNo = mObj.mNPoint.Count + 1;
            if (mObj.mNPoint.Count < index)
            {
                for (int i = StarNo; i < index + 1; ++i)
                {
                    RPoint BasePoint = new RPoint(uidd_BaseX.Value, uidd_BaseY.Value, 0);
                    RPoint SpacePoint = new RPoint(uidd_SpaceX.Value, uidd_SpaceY.Value, 0);
                    RPoint ResultPoint = CalHelp.GetPoint(i, BasePoint, SpacePoint);
                    mObj.mNPoint.Add(new NPoint(i, 0, 0, ResultPoint.X, ResultPoint.Y));
                }
            }
            else if (mObj.mNPoint.Count > index)
            {
                List<NPoint> points = new List<NPoint>();
                foreach (var key in mObj.mNPoint)
                {
                    if (key.Index <= index)
                    {
                        points.Add(mObj.mNPoint[key.Index-1]);
                    }
                }
                mObj.mNPoint = points;
            }
            dgv_NPoint.DataSource = mObj.mNPoint.ToArray();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_NPoint.DataSource = mObj.mNPoint.ToArray();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
            ShowResult();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


