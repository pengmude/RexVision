using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore.core;
using HalconDotNet;
using VisionCore.core.UserDefine;
using CPublicDefine;
using System.Diagnostics;
using VisionCore.Tools;
using VisionCore;

namespace Plugin.MeasureCircle
{
    public partial class MeasureCircleModuleForm : ModuleFormBase
    {
        private MeasureCircleModuleObj m_ModuleObj;
        protected Metrology_INFO m_MetrologyInfo = new Metrology_INFO();
        [NonSerialized]
        protected HRegion disableRegion = new HRegion();//屏蔽区域 magical 20171028
        [NonSerialized]
        protected HRegion tempDisableRegion = new HRegion();
        /// <summary>
        /// 补正坐标系
        /// </summary>
        [NonSerialized]
        public Coordinate_INFO Coord = new Coordinate_INFO();
        public MeasureCircleModuleForm(MeasureCircleModuleObj m_ModuleObj_) : base(m_ModuleObj_)
        {
            m_ModuleObj = m_ModuleObj_;
            InitializeComponent();
        }
        //public MeasureCircleModuleForm()
        //{
        //    InitializeComponent();
        //}
        private void ModuleForm_Load(object sender, EventArgs e)
        {
            if (ModuleObjBase == null) return;
            show_roi.Checked = m_ModuleObj.showROIEnable;
            show_范围.Checked = m_ModuleObj.showFindAreaEnable;
            show结果.Checked = m_ModuleObj.showResultEnable;
            FormToData();
            UpdateParam(sender, e);
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            UpdateParam(sender, e);
            this.Close();
        }
        private void button_run_Click(object sender, EventArgs e)
        {
            UpdateParam(sender, e);
            m_ModuleObj.ExeModule();
            UpdateWindow();
        }
        private void bt_Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true; //是否显示ColorDialog有半部分
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)//确定事件响应
            {
                Color color_from = colorDialog.Color;
                bt_Color.BackColor = color_from;
                string m_DrawColor = color_from.ToArgb().ToString("X02");
                m_DrawColor = m_DrawColor.Substring(2);
                m_DrawColor = m_DrawColor.Insert(0, "#");
                m_ModuleObj.m_drawColor = m_DrawColor;
            }
        }
        /// <summary>
        /// 读取文本框中的Metrology信息
        /// </summary>
        private void setMetrologInfo()
        {
            try
            {
                m_MetrologyInfo.Length1 = Convert.ToDouble(num_Length1.Text.Trim());
                m_MetrologyInfo.Length2 = Convert.ToDouble(num_Length2.Text.Trim());
                m_MetrologyInfo.Threshold = Convert.ToDouble(num_Threshold.Text.Trim());
                m_MetrologyInfo.MeasureDis = Convert.ToDouble(num_MeasureDis.Text.Trim());
                m_MetrologyInfo.PointsOrder = cb_Direction.SelectedIndex;
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
                m_MetrologyInfo.ParamName = new HTuple();
                m_MetrologyInfo.ParamName.Append("measure_transition");
                m_MetrologyInfo.ParamName.Append("measure_select");
                m_MetrologyInfo.ParamName.Append("measure_distance");
                //m_MetrologyInfo.ParamName.Append("max_num_iterations");
                //m_MetrologyInfo.ParamName.Append("measure_interpolation");
                m_MetrologyInfo.ParamValue = new HTuple();
                m_MetrologyInfo.ParamValue.Append(mTransition);
                m_MetrologyInfo.ParamValue.Append(mSelect);
                m_MetrologyInfo.ParamValue.Append(m_MetrologyInfo.MeasureDis);
                //m_MetrologyInfo.ParamValue.Append(-1);
                //m_MetrologyInfo.ParamValue.Append("nearest_neighbor");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 更新参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateParam(object sender, EventArgs e)
        {
            //Circle_INFO circle = new Circle_INFO((double)nudCenterY.Value, (double)nudCenterX.Value, (double)nudRadus.Value);
            //m_ModuleObj.m_InCircle = circle;
            setMetrologInfo();
            m_ModuleObj.ModuleParam.ModuleRemarks = txt_UnitDescrible.Text.Trim();
            m_ModuleObj.m_MetrologyInfo = this.m_MetrologyInfo;
            m_ModuleObj.m_CurrentImgName = cmb_CurrentImg.Text;
            if ((m_ModuleObj.m_CurrentImgName != null) && (hWindow_Fit.Image != null))
            {
                hWindow_Fit.Image = ((HImageExt)HMeasureSet.getVariableValue(m_ModuleObj.m_VariableList, m_ModuleObj.m_CurrentImgName));
            }
            if (cmb_PositionUnitID.Text.Trim() == "无" || cmb_PositionUnitID.Text.Trim() == "")
            {
                m_ModuleObj.m_homMatUnitID = -1;
                chkCorrect.Checked = false;
                chkCorrect.Enabled = false;
                Coord = new Coordinate_INFO();
            }
            else
            {
                chkCorrect.Enabled = true;
                m_ModuleObj.m_homMatUnitID = int.Parse(cmb_PositionUnitID.Text.Substring(1));
                F_DATA_CELL data = m_ModuleObj.m_VariableList.FirstOrDefault(c => c.m_Data_Type == DataType.坐标系 && c.m_Data_CellID == (m_ModuleObj.m_homMatUnitID));
                Coord = ((List<Coordinate_INFO>)data.m_Data_Value)[0];
            }
            m_ModuleObj.isCorrect = chkCorrect.Checked;
            //m_ModuleObj.ExeModule();//再检测
            //FormToData();
            // UpdateWindow();
            //PaintMetrology();
        }
        /// <summary>
        /// 初始化位置补正列表
        /// </summary>
        public void InitCmb_Position()
        {
            List<string> m_PositionList = new List<string>() { "无" };//直线单元ID列表
            IEnumerable<string> resultList = from datacell in m_ModuleObj.m_VariableList
                                             where datacell.m_Data_Type == DataType.坐标系// ||datacell.m_Data_Type == DataType.位置转换2D && datacell.m_Data_CellID != HMeasureSYS.U000
                                             select "U" + datacell.m_Data_CellID.ToString("D4");
            m_PositionList.AddRange(resultList.ToList());
            cmb_PositionUnitID.DataSource = m_PositionList;
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            List<string> imgList = new List<string>();
            HMeasureSet.getVariableImageListString(ModuleObjBase.m_VariableList, out imgList);
            cmb_CurrentImg.DataSource = imgList;
        }
        private void bt_Paint_Click(object sender, EventArgs e)
        {
            if (disableRegion == null || !disableRegion.IsInitialized())
            {
                disableRegion = new HRegion();
            }
            disableRegion = hWindow_Fit.SetROI(disableRegion);
            if (disableRegion != null && disableRegion.IsInitialized())
            {
                double row, col, x, y;
                //disableRegion.EllipticAxis(out x, out phi);
                disableRegion.AreaCenter(out row, out col);
                HMeasureSet.Points2WorldPlane(m_ModuleObj.m_Image, row, col, out x, out y);
                HHomMat2D hom = VBA_Function.setOrig(Coord.X, Coord.Y, -Coord.Phi);
                x = hom.AffineTransPoint2d(x, y, out y);
                m_ModuleObj.RegCoor = new Coordinate_INFO(y, x, Coord.Phi);
                m_ModuleObj.disableRegion = disableRegion;
            }
        }
        private void bt_draw_Click(object sender, EventArgs e)
        {
            Circle_INFO m_DrawCircle = new Circle_INFO();
            hWindow_Fit.DrawCircle(m_ModuleObj.m_drawColor, out m_DrawCircle.CenterY, out m_DrawCircle.CenterX, out m_DrawCircle.Radius);
            //像素坐标转世界坐标
            m_DrawCircle = HMeasureSet.Circle2WorldPlane(m_ModuleObj.m_Image, m_DrawCircle);
            ////世界坐标转当前相对坐标
            HHomMat2D hom = VBA_Function.setOrig(Coord.X, Coord.Y, -Coord.Phi);
            m_DrawCircle.CenterX = hom.AffineTransPoint2d(m_DrawCircle.CenterX, m_DrawCircle.CenterY, out m_DrawCircle.CenterY);
            (m_ModuleObj).m_InCircle = m_DrawCircle;
            nudCenterX.Value = (decimal)(m_ModuleObj).m_InCircle.CenterX;
            nudCenterY.Value = (decimal)(m_ModuleObj).m_InCircle.CenterY;
            nudRadus.Value = (decimal)(m_ModuleObj).m_InCircle.Radius;
        }
        /// <summary>
        /// 单击单元时更新窗口 显示当前图片和检测内容
        /// </summary>
        /// <param name="cell"></param>
        public void UpdateWindow()
        {
            //if (cell.blnShield)
            //return;
            MeasureCircleModuleObj cell = m_ModuleObj;
            //Circle_INFO circle = new Circle_INFO((double)nudCenterY.Value, (double)nudCenterX.Value, (double)nudRadus.Value);
            //cell.m_InCircle = circle;
            if (cell.m_Image != null && cell.m_Image.IsInitialized())
            {
                List<MeasureROI> roiList = cell.m_Image.measureROIlist.Where(c => c.CellID == cell.ModuleParam.ModuleEncode.ToString()).ToList();
                hWindow_Fit.Image = cell.m_Image;
                foreach (MeasureROI roi in roiList)
                {
                    if (roi != null && roi.roiType == enMeasureROIType.文字显示.ToString())
                    {
                        MeasureROIText roiText = (MeasureROIText)roi;
                        ShowControl.ShowMsg.set_display_font(hWindow_Fit.HWindowID, roiText.size, roiText.font, "false", "false");
                        ShowControl.ShowMsg.disp_message(hWindow_Fit.HWindowID, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            hWindow_Fit.HWindowID.SetColor(roi.drawColor);
                            hWindow_Fit.HWindowID.DispObj(roi.hobject);
                        }
                    }
                }
            }
        }
        public override void FormToData()
        {
            m_ModuleObj = (MeasureCircleModuleObj)ModuleObjBase;
            InitCurrentCmbImgList();
            InitCmb_Position();
            string m_FlowID = "U" + m_ModuleObj.ModuleParam.ModuleEncode.ToString("D4");
            this.Text = m_ModuleObj.ModuleParam.ModuleName;
            txt_UnitDescrible.Text = m_ModuleObj.ModuleParam.ModuleRemarks;
            ///初始化文本框
            cmb_PositionUnitID.SelectedIndex = 0;
            string temp_color = m_ModuleObj.m_drawColor.Substring(1, 2);
            int r = Convert.ToInt32(temp_color, 16);
            temp_color = m_ModuleObj.m_drawColor.Substring(3, 2);
            int g = Convert.ToInt32(temp_color, 16);
            temp_color = m_ModuleObj.m_drawColor.Substring(5, 2);
            int b = Convert.ToInt32(temp_color, 16);
            bt_Color.BackColor = Color.FromArgb(r, g, b);
            {
                chkCorrect.Checked = m_ModuleObj.isCorrect;
                disableRegion = m_ModuleObj.disableRegion;
                m_MetrologyInfo = m_ModuleObj.m_MetrologyInfo;
                if (null != m_MetrologyInfo.ParamName)
                {
                    num_Length1.Text = m_ModuleObj.m_MetrologyInfo.Length1.ToString();
                    num_Length2.Text = m_ModuleObj.m_MetrologyInfo.Length2.ToString();
                    num_Threshold.Text = m_ModuleObj.m_MetrologyInfo.Threshold.ToString();
                    num_MeasureDis.Text = m_ModuleObj.m_MetrologyInfo.MeasureDis.ToString();
                    cb_Direction.SelectedIndex = m_MetrologyInfo.PointsOrder;
                    string mTransition = m_ModuleObj.m_MetrologyInfo.ParamValue[0].S;
                    string mSelect = m_ModuleObj.m_MetrologyInfo.ParamValue[1].S;
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
                    if (m_ModuleObj.m_homMatUnitID == -1)
                    {
                        cmb_PositionUnitID.Text = "无";
                    }
                    else
                    {
                        cmb_PositionUnitID.Text = "U" + (m_ModuleObj.m_homMatUnitID.ToString("D4"));
                    }
                    nudCenterX.Value = (decimal)(m_ModuleObj).m_InCircle.CenterX;
                    nudCenterY.Value = (decimal)(m_ModuleObj).m_InCircle.CenterY;
                    nudRadus.Value = (decimal)(m_ModuleObj).m_InCircle.Radius;
                    //初始化下拉列表
                    cmb_CurrentImg.Text = m_ModuleObj.m_CurrentImgName;
                    if (m_ModuleObj.m_CurrentImgName != null)
                    {
                        try
                        {
                            m_ModuleObj.m_Image = ((HImageExt)HMeasureSet.getVariableValue(m_ModuleObj.m_VariableList, m_ModuleObj.m_CurrentImgName));
                            hWindow_Fit.Image = ((HImageExt)HMeasureSet.getVariableValue(m_ModuleObj.m_VariableList, m_ModuleObj.m_CurrentImgName)).Clone();
                        }
                        catch
                        {
                            DisplayMsg.SendLog(LogLevel.Error, "图像读取失败" + "\r\n");
                        }
                    }
                }
            }
            //this.num_Length1.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.num_Length2.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.num_Threshold.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.num_MeasureDis.ValueChanged += new System.EventHandler(this.UpdateParam);
            //this.cb_Select.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
            //this.cb_Direction.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
            //this.cb_Transition.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
            //this.chkCorrect.CheckedChanged += new System.EventHandler(this.UpdateParam);
            //this.cmb_CurrentImg.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
            //this.cmb_PositionUnitID.SelectedIndexChanged += new System.EventHandler(this.UpdateParam);
        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void show_roi_CheckedChanged(object sender, EventArgs e)
        {
            m_ModuleObj.showROIEnable = show_roi.Checked;
        }
        private void show_范围_CheckedChanged(object sender, EventArgs e)
        {
            m_ModuleObj.showFindAreaEnable = show_范围.Checked;
        }
        private void show结果_CheckedChanged(object sender, EventArgs e)
        {
            m_ModuleObj.showResultEnable = show结果.Checked;
        }
        private void cmb_CurrentImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ModuleObj.m_CurrentImgName = cmb_CurrentImg.Text;
            if ((m_ModuleObj.m_CurrentImgName != null) && (hWindow_Fit.Image != null))
            {
                hWindow_Fit.Image = ((HImageExt)HMeasureSet.getVariableValue(m_ModuleObj.m_VariableList, m_ModuleObj.m_CurrentImgName));
            }
        }
    }
}
