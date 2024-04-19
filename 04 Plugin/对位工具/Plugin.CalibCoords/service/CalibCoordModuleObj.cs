using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using VisionCore.core;
using VisionCore.core.camera;
using VisionCore.core.UserDefine;
namespace Plugin.CalibCoord
{
    [Category("标定工具集")]
    [DisplayName("九点标定")]
    [Serializable]
    public class CalibCoordModuleObj : ModuleObjBase
    {
        /// <summary>
        ///  当前图像名称
        /// </summary>
        public string m_CurrentImgName = string.Empty;
        /// <summary>
        /// 轴个数=CaliAxisCount+1
        /// </summary>
        private int iCaliAxisCount = 0;
        public int CaliAxisCount
        {
            get { return iCaliAxisCount; }
            set { iCaliAxisCount = value; }
        }
        /// <summary>
        /// 采集设备ID
        /// </summary>
        private string _DeviceID;
        [NonSerialized]
        public AcqAreaDeviceBase AcqDevice;
        public int AcqUnitID { get; set; }
        public string DeviceID
        {
            set
            {
                _DeviceID = value;
                AcqDevice = (AcqAreaDeviceBase)g_AcqDeviceList.FirstOrDefault(c => c.m_DeviceID == _DeviceID);
            }
            get { return _DeviceID; }
        }
        public DataTable m_DTCoord = BuidTable();
        public DataTable m_DTCoordSingle = BuidSingleTable();


        /// <summary>
        /// 坐标变换
        /// </summary>
        public HHomMat2D m_homMat2D = new HHomMat2D();
        /// <summary>
        ///单轴标定时相机和X轴的夹角
        /// </summary>
        public double PhiSingle = 0.0;

        /// <summary>
        /// 单轴标定，是否移动x轴 true 为x轴移动，false y轴移动
        /// </summary>
        public bool blnXSingle = false;

        public bool blnRbootMode = false;
        /// <summary>
        /// 是否标定过
        /// </summary>
        [NonSerialized]
        public bool m_Calibrated = false;

      
        public static DataTable BuidSingleTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("相机行坐标", Type.GetType("System.Double"));
            dt.Columns.Add("相机列坐标", Type.GetType("System.Double"));
            return dt;
        }

        public static DataTable BuidTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("机械X坐标", Type.GetType("System.Double"));
            dt.Columns.Add("机械Y坐标", Type.GetType("System.Double"));
            dt.Columns.Add("相机行坐标", Type.GetType("System.Double"));
            dt.Columns.Add("相机列坐标", Type.GetType("System.Double"));
            return dt;
        }
        public override bool ExeModule()
        {
            if (m_Calibrated)
            {
                m_Calibrated = true;
                //return true;
            }
            try
            {
                if (CaliAxisCount == 0)
                {
                    Line_INFO Line = new Line_INFO();
                    double[] rowY = m_DTCoordSingle.AsEnumerable().Select(r => r.Field<double>("相机行坐标")).ToArray();
                    double[] colX = m_DTCoordSingle.AsEnumerable().Select(r => r.Field<double>("相机列坐标")).ToArray();
                    VBA_Function.fitLineByH(rowY.ToList(), colX.ToList(), out Line);
                    //计算直线角度  -90-90度 yoga 2017-9-3 19:10:57
                    HTuple angle = 0;
                    HOperatorSet.LineOrientation(Line.StartY, Line.StartX, Line.EndY, Line.EndX, out angle);
                    if (!blnXSingle)
                    {

                        if (angle > 0)
                        {
                            angle = angle - Math.PI / 2;
                        }
                        else
                        {

                            angle = angle + Math.PI / 2;
                        }
                    }
                    //使用halcon算法算出的角度与tan算出的角度正负相反  yoga 2017-9-4 8:39:55
                    angle = angle.D * (-1.0);
                    PhiSingle = angle.D;
                    m_homMat2D = new HHomMat2D();
                    m_homMat2D = m_homMat2D.HomMat2dRotateLocal(angle);
                }
                else if (CaliAxisCount == 1)
                {

                    //若为机械手标定 行列要交换   图像直接标定与x夹角不需要交换行列 yoga 2018-9-3 08:51:49
                    if (blnRbootMode == false)
                    {
                        double[] X = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械X坐标") * (-1)).ToArray();
                        double[] Y = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械Y坐标") * (-1)).ToArray();
                        double[] row = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机行坐标")).ToArray();
                        double[] col = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机列坐标")).ToArray();
                        m_homMat2D = new HHomMat2D();
                        m_homMat2D.VectorToHomMat2d(new HTuple(row), new HTuple(col), new HTuple(Y), new HTuple(X));
                    }
                    else
                    {
                        double[] X = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械X坐标")).ToArray();
                        double[] Y = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械Y坐标")).ToArray();
                        double[] row = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机行坐标")).ToArray();
                        double[] col = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机列坐标")).ToArray();
                        m_homMat2D = new HHomMat2D();
                        m_homMat2D.VectorToHomMat2d(new HTuple(col), new HTuple(row), new HTuple(X), new HTuple(Y));
                    }

                    //double[] X = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械X坐标")).ToArray();
                    //double[] Y = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("机械Y坐标")).ToArray();
                    //double[] rowY = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机行坐标")).ToArray();
                    //double[] colX = m_DTCoord.AsEnumerable().Select(r => r.Field<double>("相机列坐标")).ToArray();

                    //m_homMat2D = new HHomMat2D();
                    //m_homMat2D.VectorToHomMat2d(new HTuple(colX), new HTuple(rowY), new HTuple(X), new HTuple(Y));

                }
                F_DATA_CELL dataMat2D = new F_DATA_CELL(ModuleParam.ModuleEncode, DataGroup.单量, DataType.位置转换2D, ConstVavriable.outHomMat2D
            , "相机和机械转换", "0", 1, new List<HHomMat2D>() { m_homMat2D }, DataAtrribution.全局变量);
                #region

                List<double> X1 = new List<double>();
                List<double> Y1 = new List<Double>();
                HTuple _x = new HTuple();
                HTuple _y = new HTuple();
                try
                {
                    //HTuple CamPar = new HTuple(Calib.Take(8).ToArray());
                    //HTuple CamPose = new HTuple();
                    //for (int i = 8; i < Calib.Count; i++)
                    //{
                    //    CamPose.Append(new HTuple(Calib[i]));
                    //}
                    ////18此函数取消
                    ////HMisc.ImagePointsToWorldPlane(CamPar, new HPose(CamPose), new HTuple(rows.ToArray()), new HTuple(cols.ToArray()), "mm", out _x, out _y);
                    //HOperatorSet.ImagePointsToWorldPlane(CamPar, new HPose(CamPose), new HTuple(rows.ToArray()), new HTuple(cols.ToArray()), "mm", out _x, out _y);
                    //X = _x.DArr.ToList();
                    //Y = _y.DArr.ToList();
                }
                catch (System.Exception ex)
                {

                }
                #endregion
                UpdateVariableValue(ref  m_VariableList, dataMat2D);
  
                m_Calibrated = true;
                //blnSuccessed = true;
            }
            catch (System.Exception ex)
            {
                Helper.LogHandler.Instance.VTLogError(this.ModuleParam.ModuleRemarks.ToString() + " 单元 U" + this.ModuleParam.ModuleEncode.ToString("D4") + " 错误 " + ex.ToString());
                m_Calibrated = false;
                //blnSuccessed = false;
            }
            return true;
        }

    override public void set_show(ModuleObjBase basemodule)
        {
            CalibCoordModuleForm set_form = new CalibCoordModuleForm((CalibCoordModuleObj)basemodule);
            set_form.ShowDialog();

        }
    }
}
