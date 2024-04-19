using CPublicDefine;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VisionCore.core;
using VisionCore.core.camera;
using VisionCore.core.UserDefine;

namespace Plugin.CalibCoord
{
    public partial class CalibCoordModuleForm : ModuleFormBase
    {
        [NonSerialized]
        public AcqAreaDeviceBase AcqDevice;
        public ModuleObjBase m_ModuleObjBase;
        private CalibCoordModuleObj m_ModuleObj;

        HXLDCont m_MeasureXLD = new HXLDCont();
        HXLDCont m_MeasureCross = new HXLDCont();
        HXLDCont m_ResultXLD = new HXLDCont();
        public CalibCoordModuleForm(CalibCoordModuleObj m_ModuleObj_) : base(m_ModuleObj_)
        {
            InitializeComponent();
        }
        private void ModuleForm_Load(object sender, EventArgs e)
        {
            m_ModuleObj = (CalibCoordModuleObj)ModuleObjBase;
            if (ModuleObjBase == null) return;
            InitCmbDevice();
            cmb_Device.Tag = "0";
            cmb_Device.Text = m_ModuleObj.DeviceID;
            dgv_Points.DataSource = m_ModuleObj.m_DTCoord;
            dgv_SingleData.DataSource = m_ModuleObj.m_DTCoordSingle;
            cmb_AxisCount.SelectedIndex = m_ModuleObj.CaliAxisCount;
            chk_axisX.Checked = m_ModuleObj.blnXSingle;
            chkRbootMode.Checked = m_ModuleObj.blnRbootMode;
            if (m_ModuleObj.m_Calibrated)
            {
                txt_CameraAxisPhi.Text = (m_ModuleObj.PhiSingle * 180 / Math.PI).ToString("#0.000000");

                //需要每次标定才能得到对应的值
                if (m_ModuleObj.CaliAxisCount == 1)
                {
                    double sx, sy, phi, theta, tx, ty;
                    sx = m_ModuleObj.m_homMat2D.HomMat2dToAffinePar(out sy, out phi, out theta, out tx, out ty);

                    Label_sx.Text = sx.ToString("#0.000000");
                    Label_sy.Text = sy.ToString("#0.000000");
                    Label_phi.Text = (new HTuple(phi)).TupleDeg().D.ToString("#0.000000");
                    Label_theta.Text = (new HTuple(theta)).TupleDeg().D.ToString("#0.000000");
                    Label_tx.Text = tx.ToString("#0.000000");
                    Label_ty.Text = ty.ToString("#0.000000");

                }
                measureControlOneAxis.ShowDefultValue();
                measureControlXY.ShowDefultValue();
            }
        }
        private void InitCmbDevice()
        {
            List<string> m_PositionList = new List<string>() { "无" };//直线单元ID列表
            IEnumerable<string> resultList = from datacell in ModuleObjBase.m_VariableList
                                             where datacell.m_Data_Type == DataType.图像
                                             select "U" + datacell.m_Data_CellID.ToString("D4");
            m_PositionList.AddRange(resultList.ToList());
            cmb_Device.DataSource = m_PositionList;
            cmb_Device.SelectedIndex = 0;


            if (m_ModuleObj.AcqUnitID == -1)
            {
                cmb_Device.Text = "无";
            }
            else
            {
                cmb_Device.Text = "U" + m_ModuleObj.AcqUnitID.ToString("D4");
            }

        }
        private void dgv_Points_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //m_ModuleObj.m_Calibrated = false;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {

                m_ModuleObj.m_Calibrated = false;
                m_ModuleObj.CaliAxisCount = cmb_AxisCount.SelectedIndex;
                m_ModuleObj.blnXSingle = chk_axisX.Checked;
                m_ModuleObj.blnRbootMode = chkRbootMode.Checked;
                m_ModuleObj.DeviceID = cmb_Device.Text;
                m_ModuleObj.ExeModule();
                txt_CameraAxisPhi.Text = (m_ModuleObj.PhiSingle * 180 / Math.PI).ToString("#0.000000");
                //txt_CameraAxisPhi.Text = (((CCalib_Coord)m_Unit).PhiSingle * 180 / Math.PI).ToString("#0.000000");
                //如果标定未成功  后续显示结果会bug yoga 2018-9-3 11:48:59
                if (m_ModuleObj.m_Calibrated == false)
                {
                    MessageBox.Show("标定未成功!");
                    return;
                }
                double sx, sy, phi, theta, tx, ty;
                sx = m_ModuleObj.m_homMat2D.HomMat2dToAffinePar(out sy, out phi, out theta, out tx, out ty);
                //逆时针为正，顺时针为负
                Label_sx.Text = sx.ToString("#0.000000");
                Label_sy.Text = sy.ToString("#0.000000");
                Label_phi.Text = (new HTuple(phi)).TupleDeg().D.ToString("#0.000000"); //坐标系X轴角度差
                Label_theta.Text = (new HTuple(theta)).TupleDeg().D.ToString("#0.000000");//新坐标系相对于90度直角坐标系角度
                Label_tx.Text = tx.ToString("#0.000000");
                Label_ty.Text = ty.ToString("#0.000000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            this.Close();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
           
            m_ModuleObj.ExeModule();
        }
        private void bt_FindCircle_Click(object sender, EventArgs e)
        {
            measureControlOneAxis.ShowDefultValue();
            measureControlXY.ShowDefultValue();
     
            bt_FindCircle.Enabled = false;
            Circle_INFO m_DrawCircle = new Circle_INFO();

            if (hWindow_Fit.Image == null || hWindow_Fit.Image.IsInitialized() == false)
            {
                MessageBox.Show("当前无图像数据!!");
                bt_FindCircle.Enabled = true;
                return;
            }
            //显示当前图像,擦除之前绘制的圆形,方便重新绘制--yoga20180821
            hWindow_Fit.HWindowID.DispObj(hWindow_Fit.Image);

            hWindow_Fit.HWindowID.SetDraw("margin");
            hWindow_Fit.DrawCircle("#00FF00", out m_DrawCircle.CenterY, out m_DrawCircle.CenterX, out m_DrawCircle.Radius);

            DetectCircle(m_DrawCircle);

            //double x, y, z;
            //GetCurrentPosi(out x, out y, out z);
            //txt_currPosiX.Text = x.ToString("#0.0000") + "," + y.ToString("#0.0000") + "," + z.ToString("#0.0000");

            bt_FindCircle.Enabled = true;
        }
        private void bt_MarkS_Click(object sender, EventArgs e)
        {
            bt_MarkS.Enabled = false;
            Circle_INFO m_DrawCircle = new Circle_INFO();
            if (hWindow_Fit.Image == null || hWindow_Fit.Image.IsInitialized() == false)
            {
                MessageBox.Show("当前无图像数据!!");
                bt_FindCircle.Enabled = true;
                return;
            }
            //显示当前图像,擦除之前绘制的圆形,方便重新绘制--yoga20180821
            hWindow_Fit.HWindowID.DispObj(hWindow_Fit.Image);
            hWindow_Fit.HWindowID.SetDraw("margin");
            hWindow_Fit.DrawCircle("#00FF00", out m_DrawCircle.CenterY, out m_DrawCircle.CenterX, out m_DrawCircle.Radius);

            DetectCircle(m_DrawCircle);
            bt_MarkS.Enabled = true;
        }
        private void DetectCircle(Circle_INFO circle)
        {
            Circle_INFO CircleInfo = new Circle_INFO();
            HTuple row, col;
            //Metrology_INFO m_MetrologyInfo = new Metrology_INFO(15, 4, 30, 4, new HTuple(), new HTuple(), 0);
            Metrology_INFO m_MetrologyInfo;
            if (tab_Main.SelectedTab.Name == "A")
            {
                m_ModuleObj.CaliAxisCount = 1;
                m_MetrologyInfo = measureControlXY.GetMetrologInfo();
            }
            else
            {
                m_ModuleObj.CaliAxisCount = 0;
                m_MetrologyInfo = measureControlOneAxis.GetMetrologInfo();
            }  
            HMeasureSet.MeasureCircle(hWindow_Fit.Image, circle, m_MetrologyInfo, null, out CircleInfo, out row, out col, out m_MeasureXLD);
            txt_Row.Text = CircleInfo.CenterY.ToString("0.000000");
            txt_Col.Text = CircleInfo.CenterX.ToString("0.000000");
            txt_rowS.Text = CircleInfo.CenterY.ToString("0.000000");
            txt_colS.Text = CircleInfo.CenterX.ToString("0.000000");
            m_MeasureCross.GenCrossContourXld(row, col, (HTuple)m_MetrologyInfo.Length2, new HTuple(45).TupleRad());
            m_ResultXLD.GenCircleContourXld(CircleInfo.CenterY, CircleInfo.CenterX, CircleInfo.Radius, 0, 6.28318, "positive", 1);
            UpdateWindow();
            //iPaintMetrology();
        }

        private void cmb_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Device.Text.Trim() == "无" || cmb_Device.Text.Trim().Length < 1)
            {
                m_ModuleObj.AcqUnitID = -1;
            }
            else
            {

                m_ModuleObj.AcqUnitID = int.Parse(cmb_Device.Text.Substring(1));
            }
        }
        //private Project m_project = null;
        //public List<ModuleObjBase> project_;//当前工程
        private void bt_DisImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Device.Text != "无")
                {

                
                    string  device_id = cmb_Device.Text.Substring(1);
                    device_id = "Dev1";
                    AcqAreaDeviceBase AcqDevice = ModuleObjBase.g_AcqDeviceList.FirstOrDefault(c => c.m_DeviceID == device_id);
                    if (AcqDevice != null)
                    {
                        AcqDevice.CaptureImage(true);
                        hWindow_Fit.Image = AcqDevice.m_Image;
                    }
                    else
                    {
                        //F_DATA_CELL data1 = ModuleObjBase.m_VariableList.FirstOrDefault(c => c.m_Data_Name == "0:outImage");
                        F_DATA_CELL data = ModuleObjBase.m_VariableList.FirstOrDefault(c => c.m_Data_CellID == m_ModuleObj.AcqUnitID);
                        hWindow_Fit.Image = ((HImageExt)data.m_Data_Value);
                        //hWindow_Fit.Image = ModuleObjBase.m_Image;
                    }
                    hWindow_Fit.DispImageFit();
                    m_ResultXLD = new HXLDCont();
                    m_MeasureCross = new HXLDCont();
                    m_MeasureXLD = new HXLDCont();
                    UpdateWindow();
                }
            }
            catch { }
        }
        /// <summary>
        /// 初始化当前图像列表
        /// </summary>
        protected void InitCurrentCmbImgList()
        {
            List<string> m_CurrentImageNames = new List<string>();//当前图像名称列表
            List<F_DATA_CELL> imgList = new List<F_DATA_CELL>();
            HMeasureSet.getVariableImageList(ModuleObjBase.m_VariableList, out imgList);
            foreach (F_DATA_CELL datacell in imgList)
            {
                m_CurrentImageNames.Add(datacell.m_Data_Name);
            }
            string ss= m_CurrentImageNames[0];

        }
        private void bt_AddData_Click(object sender, EventArgs e)
        {
            DataRow row = m_ModuleObj.m_DTCoord.NewRow();
            //string[] tmp = txt_currPosi.Text.Split(',');
            //if (tmp.Length > 2)
            if (txt_currPosiX.Text.Length > 0 & txt_currPosiY.Text.Length > 0)
            {
                row[0] = double.Parse(txt_currPosiX.Text.Trim());
                row[1] = double.Parse(txt_currPosiY.Text.Trim());
                row[2] = double.Parse(txt_Row.Text.Trim());
                row[3] = double.Parse(txt_Col.Text.Trim());
                m_ModuleObj.m_DTCoord.Rows.Add(row);
                dgv_Points.DataSource = m_ModuleObj.m_DTCoord;
            }
        }
        private void bt_addRow_Click(object sender, EventArgs e)
        {
            DataRow row = m_ModuleObj.m_DTCoordSingle.NewRow();
            row[0] = double.Parse(txt_rowS.Text.Trim());
            row[1] = double.Parse(txt_colS.Text.Trim());
            m_ModuleObj.m_DTCoordSingle.Rows.Add(row);
            dgv_Points.DataSource = m_ModuleObj.m_DTCoord;
        }
        /// <summary>
        /// 绘画出模型
        /// </summary>
        protected void UpdateWindow()
        {
            //此处必须先显示图像,否则会出现残留,后续的xld直接绘制,当前却没有清除  --yoga20180821
            if (hWindow_Fit.Image != null/* &&hWindow_Fit.Image.IsInitialized()*/)
            {

                HSystem.SetSystem("flush_graphic", "false");
               hWindow_Fit.HWindowID.ClearWindow();

               hWindow_Fit.HWindowID.DispObj(hWindow_Fit.Image);
               hWindow_Fit.HWindowID.SetColor("#FF0000");
                if (m_ResultXLD.IsInitialized())
                {
                   hWindow_Fit.HWindowID.DispXld(m_ResultXLD);
                }

               hWindow_Fit.HWindowID.SetColor("#00FF00");
                if (m_MeasureXLD.IsInitialized())
                {
                   hWindow_Fit.HWindowID.DispXld(m_MeasureXLD);
                }

               hWindow_Fit.HWindowID.SetColor("#0000FF");
                if (m_MeasureCross.IsInitialized())
                {
                   hWindow_Fit.HWindowID.DispXld(m_MeasureCross);
                }

                HSystem.SetSystem("flush_graphic", "true");
               hWindow_Fit.HWindowID.DispLine(-100.0, -100.0, -100.0, -100.0);
            }

        }


    }
}
