using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore.core;
using VisionCore.service;
using HalconDotNet;
using VisionCore.core.UserDefine;
using CPublicDefine;
using System.Runtime.Serialization;

namespace Plugin.MeasureCircle
{
    [Category("几何查找")]
    [DisplayName("查找圆形")]
    [Serializable]
    public class MeasureCircleModuleObj : ModuleObjBase
    {
        #region 检测基本单元参数
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string m_CurrentImgName = "";
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Metrology_INFO m_MetrologyInfo = new Metrology_INFO();
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public int m_homMatUnitID = -1;

        /// <summary>
        /// //屏蔽区域 magical 20171028
        /// </summary>
        public HRegion disableRegion = new HRegion(0d, 0d, 0d);
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Coordinate_INFO RegCoor = new Coordinate_INFO();
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool isCorrect;
        /// <summary>
        /// 画笔颜色
        /// </summary>
        public string m_drawColor = "#FF0000";
        //输出轮廓线
        [NonSerialized]
        public HXLDCont m_MeasureXLD = new HXLDCont();   ///检测形态轮廓
        [NonSerialized]
        public HXLDCont m_MeasureCross = new HXLDCont(); ///检测点十字
        [NonSerialized]
        public HXLDCont m_ResultXLD = new HXLDCont();    ///检测结果轮廓
        [NonSerialized]
        public HXLDCont m_ArrowXLD = new HXLDCont();  ///检测方向       
        //输出检测点
        [NonSerialized]
        protected HTuple m_row = new HTuple();
        [NonSerialized]
        protected HTuple m_col = new HTuple();

        public HTuple point_Row
        {
            get { return m_row; }
        }
        public HTuple points_Col
        {
            get { return m_col; }
        }
        #endregion

        #region 圆检测参数
        private Circle_INFO _inCircleInfo = new Circle_INFO();
        private Circle_INFO _outCircleInfo = new Circle_INFO();

        /// <summary>
        /// 绘制圆
        /// </summary>
        public Circle_INFO m_InCircle
        {
            set { this._inCircleInfo = value; }
            get { return this._inCircleInfo; }
        }

        /// <summary>
        /// 输出圆
        /// </summary>
        public Circle_INFO m_OutCircle
        {
            get { return _outCircleInfo; }
        }

        #endregion


        public override bool ExeModule()
        {
            Circle_INFO tempCircle = new Circle_INFO();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                if (m_CurrentImgName != null)
                {
                    m_Image = ((HImageExt)HMeasureSet.getVariableValue(m_VariableList, m_CurrentImgName));
                }
                else
                {
                    ModuleParam.State = ModuleState.NoImage;
                    return false;
                }
                Coordinate_INFO coord = new Coordinate_INFO();
                if (m_homMatUnitID != -1)
                {
                    F_DATA_CELL data = m_VariableList.FirstOrDefault(c => c.m_Data_Type == DataType.坐标系 && c.m_Data_CellID == m_homMatUnitID);
                    coord = ((List<Coordinate_INFO>)data.m_Data_Value)[0];
                    HHomMat2D homMat2D = new HHomMat2D();
                    homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                    homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);

                    tempCircle = (Circle_INFO)m_InCircle.Clone();
                    tempCircle.CenterX = homMat2D.AffineTransPoint2d(m_InCircle.CenterX, m_InCircle.CenterY, out tempCircle.CenterY);
                    tempCircle = HMeasureSet.Circle2PixelPlane(m_Image, tempCircle);
                }
                else
                {
                    coord = new Coordinate_INFO();
                    tempCircle = HMeasureSet.Circle2PixelPlane(m_Image, m_InCircle);
                }
                HXLDCont CoordXLD = HMeasureSet.GetCoord(m_Image, coord);
                MeasureROI roi坐标系 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName.ToString(), this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.参考坐标系.ToString(), "green", new HObject(CoordXLD));
                m_Image.UpdateRoiList(roi坐标系);
                //获取图像坐标
                if (isCorrect)
                {
                    if (disableRegion.IsInitialized())
                    {
                        double row, col, regRow, regCol;
                        F_DATA_CELL data = g_VariableList.FirstOrDefault(c => c.m_Data_CellID == m_homMatUnitID);
                        coord = ((List<Coordinate_INFO>)data.m_Data_Value)[0];
                        HHomMat2D homMat2D = new HHomMat2D();
                        homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                        homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);
                        regCol = homMat2D.AffineTransPoint2d(RegCoor.X, RegCoor.Y, out regRow);
                        HMeasureSet.WorldPlane2Point(m_Image, regCol, regRow, out regRow, out regCol);

                        HHomMat2D homMat = new HHomMat2D();
                        disableRegion.AreaCenter(out row, out col);
                        homMat.VectorAngleToRigid(row, col, RegCoor.Phi, regRow, regCol, coord.Phi);

                        tempDisableRegion = homMat.AffineTransRegion(disableRegion, "nearest_neighbor");
                    }

                }
                else
                {
                    tempDisableRegion = disableRegion;
                }

                HMeasureSet.MeasureCircle(m_Image, tempCircle, m_MetrologyInfo, tempDisableRegion, out _outCircleInfo, out m_row, out m_col, out m_MeasureXLD);
                m_MeasureCross.GenCrossContourXld(m_row, m_col, (HTuple)m_MetrologyInfo.Length2, new HTuple(45).TupleRad());
                m_ResultXLD.GenCircleContourXld(_outCircleInfo.CenterY, _outCircleInfo.CenterX, _outCircleInfo.Radius, 0, 6.28318, "positive", 1);

                //世界坐标系
                Circle_INFO circleW = HMeasureSet.Circle2WorldPlane(m_Image, _outCircleInfo);
                //判断是否标定
                if(m_Image.blnCalibrated)
                {
                    circleW.CenterX = circleW.CenterX * m_Image.ScaleX;
                    circleW.CenterY = circleW.CenterX * m_Image.ScaleY;
                }
                //List<Circle_INFO> temp_CircleW = new List<Circle_INFO>() { circleW };
                //获取矩阵
                //F_DATA_CELL datas= m_VariableList.First(c => c.m_Data_Type == DataType.位置转换2D);
                //HHomMat2D homMat2Dx = new HHomMat2D();
                //homMat2Dx = ((List<HHomMat2D>)datas.m_Data_Value)[0];
                //图像坐标转世界坐标
                //HOperatorSet.AffineTransPoint2d(homMat2Dx, circleW.CenterY, circleW.CenterX, out HTuple m_x, out HTuple m_y);

                //circleW.CenterX = m_x;
                //circleW.CenterY = m_y;
                List<Circle_INFO> temp_CircleW = new List<Circle_INFO>() { circleW };

                F_DATA_CELL dataCircleW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.单量, DataType.圆, ConstVavriable.outCircle
                            , "检测圆", "0", 1, temp_CircleW, DataAtrribution.全局变量);
                UpdateVariableValue(ref m_VariableList, dataCircleW);

                List<Double> xW, yW;
                HMeasureSet.Points2WorldPlane(m_Image, m_row.ToDArr().ToList(), m_col.ToDArr().ToList(), out xW, out yW);
                F_DATA_CELL dataRowW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.数组, DataType.数值型, ConstVavriable.outY
                                            , "轮廓行序列号", "0", yW.Count
                                            , yW, DataAtrribution.全局变量);
                UpdateVariableValue(ref m_VariableList, dataRowW);

                F_DATA_CELL dataColW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.数组, DataType.数值型, ConstVavriable.outX
                                            , "轮廓列序列号", "0", xW.Count
                                            , xW, DataAtrribution.全局变量);
                UpdateVariableValue(ref m_VariableList, dataColW);

                //添加检测roi  magical 20170821
                MeasureROI roi检测范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.检测范围.ToString(), "green", new HObject(m_MeasureXLD));
                MeasureROI roi检测点 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.检测点.ToString(), "blue", new HObject(m_MeasureCross));
                MeasureROI roi检测结果 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.检测结果.ToString(), "red", new HObject(m_ResultXLD));
                MeasureROI roi屏蔽范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.屏蔽范围.ToString(), "red", new HObject(tempDisableRegion));

                m_Image.UpdateRoiList(roi屏蔽范围);

                if (showROIEnable) { m_Image.UpdateRoiList(roi检测点); }
                if (showFindAreaEnable) { m_Image.UpdateRoiList(roi检测范围); }
                if (showResultEnable) { m_Image.UpdateRoiList(roi检测结果); }
                this.ModuleParam.State = ModuleState.OK;
                Retsult_ = 1;
            }
            catch (System.Exception ex)
            {
                //  Helper.LogHandler.Instance.VTLogError(this.ModuleParam.PluginName + " 单元 U" + this.ModuleParam.ModuleEncode.ToString("D4") + " 错误 " + ex.ToString());
                //更新一个当前检测ROI
                m_MeasureXLD = tempCircle.genXLD();
                MeasureROI roi检测范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName.ToString(), this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.检测范围.ToString(), "green", new HObject(m_MeasureXLD));
                MeasureROI roi屏蔽范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName.ToString(), this.ModuleParam.ModuleRemarks, 
                    enMeasureROIType.屏蔽范围.ToString(), "red", new HObject(tempDisableRegion));
                m_Image.UpdateRoiList(roi检测范围);
                m_Image.UpdateRoiList(roi屏蔽范围);

                F_DATA_CELL dataCircleW = new F_DATA_CELL();
                dataCircleW.InitValue(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, ConstVavriable.outCircle, DataType.圆, "");
                UpdateVariableValue(ref m_VariableList, dataCircleW);

                F_DATA_CELL dataRowW = new F_DATA_CELL();
                dataRowW.InitValue(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, ConstVavriable.outY, DataType.数值型, "0");
                UpdateVariableValue(ref m_VariableList, dataRowW);

                F_DATA_CELL dataColW = new F_DATA_CELL();
                dataColW.InitValue(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, ConstVavriable.outX, DataType.数值型, "0");
                UpdateVariableValue(ref m_VariableList, dataColW);
                this.ModuleParam.State = ModuleState.NG;
                Retsult_ = 2;
            }
            return true;
        }


        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            m_row = new HTuple();
            m_col = new HTuple();
            m_MeasureXLD = new HXLDCont();   ///检测形态轮廓
            m_MeasureCross = new HXLDCont(); ///检测点十字
            m_ResultXLD = new HXLDCont();    ///检测结果轮廓
            disableRegion = new HRegion();
        }
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            if (disableRegion == null || !disableRegion.IsInitialized())//修复为null 错误 magical 20171103
            {
                disableRegion = new HRegion((double)0, 0, 0);
            }
        }

        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (disableRegion == null)
            {
                disableRegion = new HRegion();
            }
        }


        override public void SetShowModule(ModuleObjBase basemodule)
        {
            MeasureCircleModuleForm set_form = new MeasureCircleModuleForm((MeasureCircleModuleObj)basemodule);
            set_form.ShowDialog();

        }

        override public void SetInfo()
        {
            m_Image = new HImageExt();
            m_MeasureXLD = new HXLDCont();   ///检测形态轮廓
            m_MeasureCross = new HXLDCont(); ///检测点十字
            m_ResultXLD = new HXLDCont();    ///检测结果轮廓
            m_ArrowXLD = new HXLDCont();  ///检测方向
            m_row = new HTuple();
            m_col = new HTuple();
        }
    }
}
