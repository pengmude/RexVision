using RexConst;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisionCore;
using RexView;

namespace Plugin.MeasLine
{
    public partial class MeasLineModForm: FormBase
    {
        private MeasLineModObj mObj ;
        protected Meas_Info mMeasInfo = new Meas_Info();
        //protected RImage mRImage = new RImage();//辅助显示图像
        [NonSerialized]
        protected HRegion disableRegion = new HRegion();//屏蔽区域 magical 20171028
        [NonSerialized]
        protected HRegion tempDisableRegion = new HRegion();
        /// <summary>
        /// 补正坐标系
        /// </summary>
        [NonSerialized]
        public Coord_Info Coord = new Coord_Info();
        //public MeasLineModForm()
        //{
        //    InitializeComponent();
        //}
        public MeasLineModForm(MeasLineModObj Obj):base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        /// <summary>
        /// 初始化位置补正列表
        /// </summary>
        public void InitCmb_Position()
        {
            List<string> m_PositionList = new List<string>() { "无" };//直线单元ID列表
            IEnumerable<string> resultList = from datacell in mObj.mSloVar
                                             where datacell.mDataMode == DataMode.坐标系// ||datacell.mDataMode == DataMode.位置转换2D && datacell.mModIndex != HMeasSYS.U000
                                             select "U" + datacell.mModIndex.ToString("D4");
            m_PositionList.AddRange(resultList.ToList());
            cmb_PositionUnitID.DataSource = m_PositionList;
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            Var.GetImage(ObjBase.mSloVar, out List<string> imgList);
            cmb_CurrentImg.DataSource = imgList;
        }
        private void MeasLineModForm_Load(object sender, EventArgs e)
        {
            mObj = (MeasLineModObj)ObjBase;
            read_data();
           // UpdateParam(sender, e);
        }
        public void read_data()
        {
            show_roi.Checked = mObj.ShowROI;
            show_范围.Checked = mObj.ShowArea;
            show结果.Checked = mObj.ShowResult;
            nudStartX.Value = (decimal)(mObj).m_InLine.StartX;
                nud_StartY.Value = (decimal)(mObj).m_InLine.StartY;
                nud_EndX.Value = (decimal)(mObj).m_InLine.EndX;
                nud_EndY.Value = (decimal)(mObj).m_InLine.EndY;
            InitCurrentCmbImgList();
            InitCmb_Position();
            string m_FlowID = "U" + (mObj).ModInfo.Encode.ToString("D4");
            this.Text = m_FlowID + " : " + (mObj).ModInfo.Name;
            tb_Remark.Text = (mObj).ModInfo.Remarks;
            ///初始化文本框
            cmb_PositionUnitID.SelectedIndex = 0;
            string temp_color = (mObj).m_drawColor.Substring(1, 2);
            int r = Convert.ToInt32(temp_color, 16);
            temp_color = (mObj).m_drawColor.Substring(3, 2);
            int g = Convert.ToInt32(temp_color, 16);
            temp_color = (mObj).m_drawColor.Substring(5, 2);
            int b = Convert.ToInt32(temp_color, 16);
            bt_Color.BackColor = Color.FromArgb(r, g, b);
            {
                chkCorrect.Checked = (mObj).isCorrect;
                disableRegion = (mObj).disableRegion;
                mMeasInfo = (mObj).mMeasInfo;
                if (null != mMeasInfo.ParamName)
                {
                    num_Length1.Text = (mObj).mMeasInfo.Length1.ToString();
                    num_Length2.Text = (mObj).mMeasInfo.Length2.ToString();
                    num_Threshold.Text = (mObj).mMeasInfo.Threshold.ToString();
                    num_MeasDis.Text = (mObj).mMeasInfo.MeasDis.ToString();
                    cb_Direction.SelectedIndex = mMeasInfo.PointsOrder;
                    string mTransition = (mObj).mMeasInfo.ParamValue[0].S;
                    string mSelect = (mObj).mMeasInfo.ParamValue[1].S;
                    if (mTransition == "negative")
                        cb_Transition.SelectedIndex = 0;
                    else if (mTransition == "positive")
                        cb_Transition.SelectedIndex = 1;
                    else if (mTransition == "all")
                        cb_Transition.SelectedIndex = 2;
                    else if (mTransition == "uniform")
                        cb_Transition.SelectedIndex = 3;
                    if (mSelect == "first")
                        cb_Select.SelectedIndex = 0;
                    else if (mSelect == "last")
                        cb_Select.SelectedIndex = 1;
                    else if (mSelect == "all")
                        cb_Select.SelectedIndex = 2;
                    else if (mSelect == "strongest")
                        cb_Select.SelectedIndex = 3;
                    //初始化下拉列表
                    cmb_CurrentImg.Text = (mObj).mImages;
                    if (mObj.mImages != null)
                    {
                        //DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == (mObj.mImages));
                        // mWindow.Image = (RImage)data.mDataValue;
                        mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages)).Clone();
                        mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages)).Clone();
                    }
                }
                if ((mObj).mHomMatID == -1)
                {
                    cmb_PositionUnitID.Text = "无";
                }
                else
                {
                    cmb_PositionUnitID.Text = "U" + (mObj).mHomMatID.ToString("D4");
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //mObj.LinkStr = textBox_link.Text;
            UpdateParam(sender, e);
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            //mObj.LinkStr = textBox_link.Text;
            UpdateParam(sender, e);
            mObj.RunObj();
            ShowHRoi();
        }
        /// <summary>
        /// 读取文本框中的Metrology信息
        /// </summary>
        private void setMetrologInfo()
        {
            try
            {
                mMeasInfo.Length1 = Convert.ToDouble(num_Length1.Text.Trim());
                mMeasInfo.Length2 = Convert.ToDouble(num_Length2.Text.Trim());
                mMeasInfo.Threshold = Convert.ToDouble(num_Threshold.Text.Trim());
                mMeasInfo.MeasDis = Convert.ToDouble(num_MeasDis.Text.Trim());
                mMeasInfo.PointsOrder = cb_Direction.SelectedIndex;
                string mTransition = "negative";
                //string m_PointsOrder = "positive"; //传输点的方向是顺时针还是逆时针暂时还没有设计
                string mSelect = "first";
                if (cb_Transition.SelectedIndex == 0)
                    mTransition = "negative";
                else if (cb_Transition.SelectedIndex == 1)
                    mTransition = "positive";
                else if (cb_Transition.SelectedIndex == 2)
                    mTransition = "all";
                else if (cb_Transition.SelectedIndex == 3)
                    mTransition = "uniform";
                if (cb_Select.SelectedIndex == 0)
                    mSelect = "first";
                else if (cb_Select.SelectedIndex == 1)
                    mSelect = "last";
                else if (cb_Select.SelectedIndex == 2)
                    mSelect = "all";
                else if (cb_Select.SelectedIndex == 3)
                    mSelect = "strongest";//magical 20180405 增加最强边边缘
                mMeasInfo.ParamName = new HTuple();
                mMeasInfo.ParamName.Append("measure_transition");
                mMeasInfo.ParamName.Append("measure_select");
                mMeasInfo.ParamName.Append("measure_distance");
                //mMeasInfo.ParamName.Append("max_num_iterations");
                //mMeasInfo.ParamName.Append("measure_interpolation");
                mMeasInfo.ParamValue = new HTuple();
                mMeasInfo.ParamValue.Append(mTransition);
                mMeasInfo.ParamValue.Append(mSelect);
                mMeasInfo.ParamValue.Append(mMeasInfo.MeasDis);
                //mMeasInfo.ParamValue.Append(-1);
                //mMeasInfo.ParamValue.Append("nearest_neighbor");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void UpdateParam(object sender, EventArgs e)
        {
            ROILine line = new ROILine((double)nud_StartY.Value, (double)nudStartX.Value, (double)nud_EndY.Value, (double)nud_EndX.Value);
            (mObj).m_InLine = line;
            setMetrologInfo();
            (mObj).ModInfo.Remarks = tb_Remark.Text.Trim();
            (mObj).mMeasInfo = this.mMeasInfo;
            (mObj).mImages = cmb_CurrentImg.Text;
            if (cmb_PositionUnitID.Text.Trim() == "无")
            {
                (mObj).mHomMatID = -1;
                chkCorrect.Checked = false;
                chkCorrect.Enabled = false;
                Coord = new Coord_Info();
            }
            else
            {
                chkCorrect.Enabled = true;
                mObj.mHomMatID = int.Parse(cmb_PositionUnitID.Text.Substring(1));
                DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataMode == DataMode.坐标系 && c.mModIndex == (mObj.mHomMatID));
                Coord = ((List<Coord_Info>)data.mDataValue)[0];
            }
            (mObj).isCorrect = chkCorrect.Checked;

       
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void ShowHRoi()
        {
            //if (cell.blnShield)
            //return;
            MeasLineModObj cell = mObj;
            // Circle_Info circle = new Circle_Info((double)nudCenterY.Value, (double)nudCenterX.Value, (double)nudRadus.Value);
            // cell.m_InCircle = circle;
            if (cell.mRImage != null && cell.mRImage.IsInitialized())
            {
                List<HRoi> roiList = cell.mRImage.mHRoi.Where(c => c.CellID == cell.ModInfo.Encode).ToList();
                mWindow.Image = cell.mRImage;
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
        private void bt_draw_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            //this.nudStartX.ValueChanged -= new System.EventHandler(this.UpdateParam);
            //this.nud_StartY.ValueChanged -= new System.EventHandler(this.UpdateParam);
            //this.nud_EndX.ValueChanged -= new System.EventHandler(this.UpdateParam);
            //this.nud_EndY.ValueChanged -= new System.EventHandler(this.UpdateParam);
            //this.Visible = false;
            ROILine m_DrawLine = new ROILine();
            mWindow.DrawLine((mObj).m_drawColor, out m_DrawLine.StartY, out m_DrawLine.StartX, out m_DrawLine.EndY, out m_DrawLine.EndX);
            //像素坐标转世界坐标
            m_DrawLine = Func.Line2WorldPlane(mObj.mRImage, m_DrawLine);
            ////世界坐标转当前相对坐标
            HHomMat2D hom = Cal.RstHomMat2D(Coord.X, Coord.Y, -Coord.Phi);
            m_DrawLine.StartX = hom.AffineTransPoint2d(m_DrawLine.StartX, m_DrawLine.StartY, out m_DrawLine.StartY);
            m_DrawLine.EndX = hom.AffineTransPoint2d(m_DrawLine.EndX, m_DrawLine.EndY, out m_DrawLine.EndY);
            nudStartX.Value = (decimal)m_DrawLine.StartX;
            nud_StartY.Value = (decimal)m_DrawLine.StartY;
            nud_EndX.Value = (decimal)m_DrawLine.EndX;
            nud_EndY.Value = (decimal)m_DrawLine.EndY;
            (mObj).m_InLine = m_DrawLine;
          //  m_Unit.Execute();//再检测
           // PaintMetrology();
           // this.Visible = true;
            //this.nudStartX.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.nud_StartY.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.nud_EndX.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.nud_EndY.ValueChanged += new System.EventHandler(this.UpdateParam);
            groupBox1.Enabled = true;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
        }
        private void bt_Paint_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            if (disableRegion == null || !disableRegion.IsInitialized())
            {
                disableRegion = new HRegion();
            }
            disableRegion = mWindow.SetROI(disableRegion);
            if (disableRegion != null && disableRegion.IsInitialized())
            {
                double row, col, x, y, phi;
                //disableRegion.EllipticAxis(out x, out phi);
                disableRegion.AreaCenter(out row, out col);
                Func.Points2WorldPlane(mObj.mRImage, row, col, out x, out y);
                HHomMat2D hom = Cal.RstHomMat2D(Coord.X, Coord.Y, -Coord.Phi);
                x = hom.AffineTransPoint2d(x, y, out y);
                (mObj).RegCoor = new Coord_Info(y, x, Coord.Phi);
                (mObj).disableRegion = disableRegion;
                //m_Unit.Execute();//再检测
                //PaintMetrology();
            }
            groupBox1.Enabled = true;
        }
        private void cmb_CurrentImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            mObj.mImages = cmb_CurrentImg.Text;
            if (mObj.mImages != null)
            {
               // DataCell data = mObj.mSloVar.FirstOrDefault(c => c.mDataName == (mObj.mImages));
                // mWindow.Image = (RImage)data.mDataValue;
                mWindow.Image = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
                mObj.mRImage = ((RImage)Var.GetImage(mObj.mSloVar, mObj.mImages));
            }
        }
        private void show_roi_CheckedChanged_1(object sender, EventArgs e)
        {
            mObj.ShowROI = show_roi.Checked;
        }
        private void show_范围_CheckedChanged_1(object sender, EventArgs e)
        {
            mObj.ShowArea = show_范围.Checked;
        }
        private void show结果_CheckedChanged(object sender, EventArgs e)
        {
            mObj.ShowResult = show结果.Checked;
        }
    }
}
