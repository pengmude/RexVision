using HalconDotNet;
using RexConst;
using RexHelps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using VisionCore;


namespace Plugin.MeasEllipse
{
    public partial class MeasEllipseForm: FormBase
    {
        private MeasEllipseObj mObj ;
        public MeasEllipseForm(MeasEllipseObj Obj):base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            InitImageList();
            InitPositionList();
            ShowHRoi();

        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ShowHRoi();
            ObjToForm();
        }
        /// <summary>
        /// 初始化位置补正列表
        /// </summary>
        public void InitPositionList()
        {
            List<string> m_PositionList = new List<string>() { "无" };
            IEnumerable<string> resultList = from datacell in mObj.mSloVar
                                             where datacell.mDataMode == DataMode.坐标系
                                             select "U" + datacell.mModIndex.ToString("D4");
            m_PositionList.AddRange(resultList.ToList());
            cmb_PositionUnitID.DataSource = m_PositionList;

            int itemcount = 0;
            foreach (string aa in cmb_PositionUnitID.Items)
            {
                string bb = "U" + mObj.mHomMatID.ToString().PadLeft(4, '0');
                if (aa == bb)
                {
                    cmb_PositionUnitID.SelectedIndex = itemcount;
                }
                ++itemcount;
            }
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitImageList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_CurrentImg.DataSource = imgList;
        }
        private void cmb_PositionUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_PositionUnitID.Text.Trim() == "无")
            {
                mObj.Coord = new Coord_Info();
            }
            else
            {
                mObj.mHomMatID = int.Parse(cmb_PositionUnitID.Text.Replace("U", ""));
                DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataMode == DataMode.坐标系 && c.mModIndex == (mObj.mHomMatID));
                mObj.Coord = ((List<Coord_Info>)data.mDataValue)[0];
            }
        }
        private void cmb_CurrentImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mImages = cmb_CurrentImg.Text;
            if (mObj.mImages != null)
            {
                mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
            }
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void ShowHRoi()
        {
            if (mObj.mRImage != null && mObj.mRImage.IsInitialized())
            {
                List<HRoi> roiList = mObj.mRImage.mHRoi.Where(c => c.CellID == mObj.ModInfo.Encode).ToList();
                mWindow.Image = mObj.mRImage;
                foreach (HRoi roi in roiList)
                {
                    if (roi != null && roi.roiType == HRoiType.文字显示)
                    {
                        HText roiText = (HText)roi;
                       ShowMsg.SetFont(mWindow.HWindowID, roiText.size, roiText.font, "false", "false");
                       ShowMsg.SetMsg(mWindow.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            mWindow.HWindowID.SetColor(roi.drawColor);
                            mWindow.HWindowID.DispObj(roi.hobject);
                        }
                    }
                }
            }
        }
        public override void  FormToObj()
        {
            SetMetrologInfo();
            mObj.ModInfo.Remarks = uitb_Remark.Text.Trim();
            mObj.ShowROI = uicb_Roi.Checked;
            mObj.ShowArea = uicb_Area.Checked;
            mObj.ShowResult = uicb_Result.Checked;

        }
        public override void ObjToForm()
        {
            try
            {
                GetMetrologInfo();
                uicb_Roi.Checked = mObj.ShowROI;
                uicb_Area.Checked = mObj.ShowArea;
                uicb_Result.Checked = mObj.ShowResult;
                uitb_Remark.Text = mObj.ModInfo.Remarks;
                nudCenterX.Value = (decimal)mObj.m_OutEllipse.CenterX;
                nudCenterY.Value = (decimal)mObj.m_OutEllipse.CenterY;
                nudRadius1.Value = (decimal)mObj.m_OutEllipse.Radius1;
                nudRadius2.Value= (decimal)mObj.m_OutEllipse.Radius2;
                nud_Phi.Value = (decimal)mObj.m_OutEllipse.Phi;
                cmb_PositionUnitID.Text = "U" + mObj.mHomMatID.ToString().PadLeft(3);

                int itemcount = 0;
                foreach (string aa in cmb_PositionUnitID.Items)
                {
                    string bb = "U" + mObj.mHomMatID.ToString().PadLeft(4, '0');
                    if (aa == bb)
                    {
                        cmb_PositionUnitID.SelectedIndex = itemcount;
                    }
                    ++itemcount;
                }
            }
            catch (Exception ex)
            {
               Log.Info( mObj.ModInfo.Name + ex.Message );
            }
        }
        /// <summary>
        /// 读取Metrology信息-界面
        /// </summary>
        private void GetMetrologInfo()
        {
            try
            {
                num_Length1.Text = mObj.mMeasInfo.Length1 != 0 ? mObj.mMeasInfo.Length1.ToString() : "15";
                num_Length2.Text = mObj.mMeasInfo.Length1 != 0 ? mObj.mMeasInfo.Length2.ToString() : "5";
                num_Threshold.Text = mObj.mMeasInfo.Length1 != 0 ? mObj.mMeasInfo.Threshold.ToString() : "30";
                num_MeasDis.Text = mObj.mMeasInfo.MeasDis.ToString();
                cb_方向.SelectedIndex = mObj.mMeasInfo.PointsOrder;
                string A = mObj.mMeasInfo.ParamValue != null ? Convert.ToString(mObj.mMeasInfo.ParamValue[0].OArr[0]) : "0";
                string B = mObj.mMeasInfo.ParamValue != null ? Convert.ToString(mObj.mMeasInfo.ParamValue[1].OArr[0]) : "0";
                string C = mObj.mMeasInfo.ParamValue != null ? Convert.ToString(mObj.mMeasInfo.ParamValue[2].OArr[0]) : "10";
                cb_模式.Text = RParam.GetMeasModel(A);
                cb_筛选.Text = RParam.GetMeasSelect(B);
                num_MeasDis.Text = C;
            }
            catch (Exception ex)
            {
               Log.Info( mObj.ModInfo.Name + ex.Message );
            }
        }
        /// <summary>
        /// 设置界面信息-Metrology
        /// </summary>
        private void SetMetrologInfo()
        {
            try
            {
                mObj.mMeasInfo.Length1 = Convert.ToDouble(num_Length1.Text.Trim());
                mObj.mMeasInfo.Length2 = Convert.ToDouble(num_Length2.Text.Trim());
                mObj.mMeasInfo.Threshold = Convert.ToDouble(num_Threshold.Text.Trim());
                mObj.mMeasInfo.MeasDis = Convert.ToDouble(num_MeasDis.Text.Trim());
                mObj.mMeasInfo.PointsOrder = cb_方向.SelectedIndex;
                string mTransition = RParam.SetMeasModel(cb_模式.Text);
                string mSelect = RParam.SetMeasSelect(cb_筛选.Text);
                double mMeasDir = RParam.SetMeasDir(cb_方向.Text);
                mObj.mMeasInfo.ParamName = new HTuple();
                mObj.mMeasInfo.ParamName.Append("measure_transition");
                mObj.mMeasInfo.ParamName.Append("measure_select");
                mObj.mMeasInfo.ParamName.Append("measure_distance");
                mObj.mMeasInfo.ParamValue = new HTuple();
                mObj.mMeasInfo.ParamValue.Append(mTransition);
                mObj.mMeasInfo.ParamValue.Append(mSelect);
                mObj.mMeasInfo.ParamValue.Append(int.Parse(num_MeasDis.Text));
            }
            catch (Exception ex)
            {
               Log.Info( mObj.ModInfo.Name + ex.Message );
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
