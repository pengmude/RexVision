using Rex.UI;
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

namespace Plugin.RobotControl
{
    public partial class RobotControlForm : FormBase
    {
        private RobotControlObj mObj;
        public RobotControlForm(RobotControlObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            InitNPointVarList();
        }
        public void InitNPointVarList()
        {
            try
            {
                int index = 0;
                //标定矩阵
                DataCell data = mObj.mCalVar.FindLast(c => c.mDataTip == "九点标定" || c.mDataTip == "旋转标定");

                List<string> m_PositionList = new List<string>() { "None" };
                IEnumerable<string> resultList = from datacell in mObj.mCalVar
                                                 where datacell.mDataMode == DataMode.标定信息
                                                 select datacell.mModName;
                m_PositionList.AddRange(resultList.ToList());
                foreach (string PositionID in m_PositionList)
                {
                    uicb_NPointHomMat.Items.Add(PositionID);
                    if (PositionID == mObj.mNPointHomMat)
                    {
                        uicb_NPointHomMat.SelectedIndex = index;
                    }
                    ++index;
                }
            }
            catch { }
        }
        public override void ObjToForm()
        {
            uicb_NPointHomMat.Text = mObj.mNPointHomMat;
            uicb_CaptureMode.SelectedIndex = (int)mObj.mCaptureMode;
            uilk_RobotX.Values.Text = mObj.mRobotX;
            uilk_RobotY.Values.Text = mObj.mRobotY;
            uilk_RobotR.Values.Text = mObj.mRobotR;

            uiLink_FormX.Values.Text = mObj.mFormX;
            uiLink_FormY.Values.Text = mObj.mFormY;
            uiLink_FormR.Values.Text = mObj.mFormR;

            uilk_ParallelX.Values.Text = mObj.mParallelX;
            uilk_ParallelY.Values.Text = mObj.mParallelY;
            uilk_CompensationR.Text = mObj.mCompensationR;

            uilk_ReferX.Values.Text = mObj.mReferX;
            uilk_ReferY.Values.Text = mObj.mReferY;
            uilk_ReferR.Values.Text = mObj.mReferR;
            uilk_AngleOffset.Values.Text = mObj.mAngleOffset;

            uicb_PositionLimit.Checked = mObj.mPositionLimit;
            uilk_StandardX.Values.Text = mObj.mStandardX;
            uilk_StandardY.Values.Text = mObj.mStandardY;
            uilk_StandardR.Values.Text = mObj.mStandardR;
            uilk_MaxOffsetX.Values.Text = mObj.mMaxOffsetX;
            uilk_MaxOffsetY.Values.Text = mObj.mMaxOffsetY;
            uilk_MaxOffsetR.Values.Text = mObj.mMaxOffsetR;


            uitb_OutRobotX.Text = mObj.mRPoint.X.ToString();
            uitb_OutRobotY.Text = mObj.mRPoint.Y.ToString();
            uitb_OutRobotR.Text = mObj.mRPoint.R.ToString();
        }
        public override void  FormToObj()
        {
            mObj.mNPointHomMat = uicb_NPointHomMat.Text;
            mObj.mCaptureMode = (CaptureMode)uicb_CaptureMode.SelectedIndex;
            mObj.mRobotX = uilk_RobotX.Values.Text;
            mObj.mRobotY = uilk_RobotY.Values.Text;
            mObj.mRobotR = uilk_RobotR.Values.Text;

            mObj.mFormX = uiLink_FormX.Values.Text;
            mObj.mFormY = uiLink_FormY.Values.Text;
            mObj.mFormR = uiLink_FormR.Values.Text;

            mObj.mParallelX = uilk_ParallelX.Values.Text;
            mObj.mParallelY = uilk_ParallelY.Values.Text;
            mObj.mCompensationR = uilk_CompensationR.Text;

            mObj.mReferX = uilk_ReferX.Values.Text;
            mObj.mReferY = uilk_ReferY.Values.Text;
            mObj.mReferR = uilk_ReferR.Values.Text;
            mObj.mAngleOffset = uilk_AngleOffset.Values.Text;


            mObj.mPositionLimit = uicb_PositionLimit.Checked;
            mObj.mStandardX = uilk_StandardX.Values.Text;
            mObj.mStandardY = uilk_StandardY.Values.Text;
            mObj.mStandardR = uilk_StandardR.Values.Text;
            mObj.mMaxOffsetX = uilk_MaxOffsetX.Values.Text;
            mObj.mMaxOffsetY = uilk_MaxOffsetY.Values.Text;
            mObj.mMaxOffsetR = uilk_MaxOffsetR.Values.Text;

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
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uicb_CaptureMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((CaptureMode)uicb_CaptureMode.SelectedIndex)
            {
                case CaptureMode.固定相机一先拍照再取放:
                    uipl_RobotPos.Visible = false;
                    uipl_Refer.Visible = false;
                    uipl_Parallel.Visible = true;
                    break;
                case CaptureMode.固定相机一先抓取后拍照:
                    uipl_RobotPos.Visible = true;
                    lb_RobotR.Visible = true;
                    uilk_RobotR.Visible = true;
                    uipl_Refer.Visible = true;
                    uipl_Parallel.Visible = false;
                    break;
                case CaptureMode.移动相机一先拍照再取放:
                    uipl_RobotPos.Visible = true;
                    lb_RobotR.Visible = false;
                    uilk_RobotR.Visible = false;
                    uipl_Refer.Visible = false;
                    uipl_Parallel.Visible = true;
                    break;

            }
        }
        private void uicb_PositionLimit_ValueChanged(object sender, bool value)
        {
            uipl_PositionLimit.Visible = uicb_PositionLimit.Checked;
        }
    }
}
