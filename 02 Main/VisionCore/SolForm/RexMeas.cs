
using System;
using System.Windows.Forms;

using VisionCore;
using RexHelps;
using HalconDotNet;
using Rex.UI;

namespace VisionCore
{
    public partial class RexMeas : UserControl
    {
        public RexMeas()
        {
            InitializeComponent();
            InitSelectValue();
        }
        /// <summary>测量信息</summary>
        public Meas_Info GetMeasInfo()
        {
            Meas_Info mMeasInfo = new Meas_Info();
            try
            {
                mMeasInfo.Length1 = uidd_L1.Value;
                mMeasInfo.Length2 = uidd_L2.Value;
                mMeasInfo.Threshold = uidd_VPT.Value;
                mMeasInfo.MeasDis = uidd_MeasDis.Value;
                mMeasInfo.PointsOrder = uicb_Dir.SelectedIndex; ;
                mMeasInfo.ParamName = new HTuple();
                mMeasInfo.ParamName.Append("measure_transition");
                mMeasInfo.ParamName.Append("measure_select");
                mMeasInfo.ParamName.Append("measure_distance");
                mMeasInfo.ParamValue = new HTuple();
                mMeasInfo.ParamValue.Append(RParam.SetMeasModel(uicb_Mode.Text));
                mMeasInfo.ParamValue.Append(RParam.SetMeasSelect(uicb_Filter.Text));
                mMeasInfo.ParamValue.Append(uidd_MeasDis.Value);///*RParam.SetMeasDir(uicb_Dir.Text)*/)
                return mMeasInfo;
            }
            catch (Exception ex)
            {
                Log.Info( "MeasInfo:" + ex.Message);
                return mMeasInfo;
            }
        }
        public bool SetMeasInfo(Meas_Info mMeasInfo)
        {
            try
            {
                uidd_L1.Value = mMeasInfo.Length1>0? mMeasInfo.Length1 : uidd_L1.Value;
                uidd_L2.Value = mMeasInfo.Length2 > 0 ? mMeasInfo.Length2: uidd_L2.Value;
                uidd_VPT.Value = mMeasInfo.Threshold > 0 ? mMeasInfo.Threshold : uidd_VPT.Value;
                uidd_MeasDis.Value = mMeasInfo.MeasDis > 0 ? mMeasInfo.MeasDis : uidd_MeasDis.Value;
                uicb_Dir.SelectedIndex = mMeasInfo.PointsOrder;
                uicb_Mode.Text = RParam.GetMeasModel(Convert.ToString(mMeasInfo.ParamValue[0].OArr[0]));
                uicb_Filter.Text = RParam.GetMeasSelect(Convert.ToString(mMeasInfo.ParamValue[1].OArr[0]));
                uidd_MeasDis.Value =int.Parse( Convert.ToString(mMeasInfo.ParamValue[2].OArr[0]));
                return true;
            }
            catch (Exception ex)
            {
                Log.Info( "MeasInfo:" +ex.Message);
                return false;
            }
        }
        public void InitSelectValue()
        {
            uicb_Mode.SelectedIndex = 0;
            uicb_Filter.SelectedIndex = 0;
            uicb_Dir.SelectedIndex = 0;
        }

        private void uidd_MeasDis_ValueChanged(object sender, double value)
        {
            UIDoubleUpDownB uIDouble= sender as UIDoubleUpDownB;



        }
        private void uicb_Filter_TextChanged(object sender, EventArgs e)
        {
            UIComboBox comboBox = sender as UIComboBox;

        }
    }
}
