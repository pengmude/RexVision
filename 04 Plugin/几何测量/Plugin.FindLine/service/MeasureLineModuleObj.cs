using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore.core;
using VisionCore.core.UserDefine;
using VisionCore.service;
using HalconDotNet;
using CPublicDefine;
namespace Plugin.MeasureLine
{
    [Category("几何查找")]
    [DisplayName("查找直线")]
    [Serializable]
    public class MeasureLineModuleObj : ModuleObjBase
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
        ///// <summary>
        ///// 记录当前图片
        ///// </summary>
        //[NonSerialized]
        //public HImageExt m_Image = new HImageExt();
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
        //public string LinkStr { get; set; }
        private Line_INFO _inlineInfo = new Line_INFO();
        private Line_INFO _outLineInfo = new Line_INFO();
        /// <summary>
        /// 绘制直线
        /// </summary>
        public Line_INFO m_InLine
        {
            set { this._inlineInfo = value; }
            get { return this._inlineInfo; }
        }
        /// <summary>
        /// 输出直线
        /// </summary>
        public Line_INFO m_OutLine
        {
            get { return _outLineInfo; }
        }
        public override bool ExeModule()
        {
            Line_INFO tempLine = new Line_INFO();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                double startX, startY, endX, endY;
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
                    startX = homMat2D.AffineTransPoint2d(m_InLine.StartX, m_InLine.StartY, out startY);
                    endX = homMat2D.AffineTransPoint2d(m_InLine.EndX, m_InLine.EndY, out endY);
                    tempLine = new Line_INFO(startY, startX, endY, endX);
                    tempLine = HMeasureSet.Line2PixelPlane(m_Image, tempLine);
                }
                else
                {
                    coord = new Coordinate_INFO();
                    tempLine = HMeasureSet.Line2PixelPlane(m_Image, m_InLine);
                }
                HXLDCont CoordXLD = HMeasureSet.GetCoord(m_Image, coord);
                MeasureROI roi坐标系 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.参考坐标系.ToString(), "green", new HObject(CoordXLD));
                m_Image.UpdateRoiList(roi坐标系);
                //获取图像坐标
                if (isCorrect)
                {
                    if (disableRegion != null || disableRegion.IsInitialized())
                    {
                        double row, col, regRow, regCol;
                        F_DATA_CELL data = m_VariableList.FirstOrDefault(c => c.m_Data_CellID == m_homMatUnitID);
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
                //显示搜索方向 magical 20180404              
                double lineCenterRow, lineCenterCol;
                lineCenterRow = (tempLine.StartY + tempLine.EndY) / 2;
                lineCenterCol = (tempLine.StartX + tempLine.EndX) / 2;
                double lineAngle = HMisc.AngleLx(tempLine.StartY, tempLine.StartX, tempLine.EndY, tempLine.EndX) - Math.PI / 2;
                HHomMat2D hom = new HHomMat2D();
                hom.VectorAngleToRigid(0, 0, 0, lineCenterRow, lineCenterCol, lineAngle);
                double arrowRow, arrowCol;
                arrowRow = hom.AffineTransPoint2d(0, m_MetrologyInfo.Length1, out arrowCol);
                HMeasureSet.GenArrowContourXld(out m_ArrowXLD, lineCenterRow, lineCenterCol, arrowRow, arrowCol, m_MetrologyInfo.Length2, m_MetrologyInfo.Length2);
                // magical end
                //增加屏蔽区域 disableRegion magical 20171028 
                HMeasureSet.MeasureLine(m_Image, tempLine, m_MetrologyInfo, out _outLineInfo, out m_row, out m_col, out m_MeasureXLD, tempDisableRegion);
                m_MeasureCross.GenCrossContourXld(m_row, m_col, (HTuple)m_MetrologyInfo.Length2, new HTuple(_outLineInfo.Nx + new HTuple(30).TupleRad()));
                m_ResultXLD.GenContourPolygonXld(new HTuple(_outLineInfo.StartY, _outLineInfo.EndY), new HTuple(_outLineInfo.StartX, _outLineInfo.EndX));
                MeasureROI roi搜索方向 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.搜索方向.ToString(), "red", new HObject(m_ArrowXLD));
                m_Image.UpdateRoiList(roi搜索方向);
                //添加检测roi  magical 20170821
                //m_Image.measureROIlist.Clear();
                MeasureROI roi检测范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测范围.ToString(), "green", new HObject(m_MeasureXLD.GenRegionContourXld("margin").Union1().ShapeTrans("rectangle2")));
                MeasureROI roi检测点 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测点.ToString(), "blue", new HObject(m_MeasureCross));
                MeasureROI roi检测结果 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测结果.ToString(), "red", new HObject(m_ResultXLD));
                MeasureROI roi屏蔽范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.屏蔽范围.ToString(), "red", new HObject(tempDisableRegion));
                //m_Image.UpdateRoiList(roi检测范围);
                //m_Image.UpdateRoiList(roi检测点);
                //m_Image.UpdateRoiList(roi检测结果);
                m_Image.UpdateRoiList(roi屏蔽范围);
                if (showROIEnable) { m_Image.UpdateRoiList(roi检测点); }
                if (showFindAreaEnable) { m_Image.UpdateRoiList(roi检测范围); }
                if (showResultEnable) { m_Image.UpdateRoiList(roi检测结果); }
                //end magical
                //世界坐标系
                Line_INFO lineW = HMeasureSet.Line2WorldPlane(m_Image, _outLineInfo);
                List<Line_INFO> temp_LineW = new List<Line_INFO>() { lineW };
                F_DATA_CELL dataLineW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.单量, DataType.直线, ConstVavriable.outLine
                            , "检测直线", "0", 1, temp_LineW, DataAtrribution.全局变量);
                List<Double> xW, yW;
                HMeasureSet.Points2WorldPlane(m_Image, m_row.ToDArr().ToList(), m_col.ToDArr().ToList(), out xW, out yW);
                F_DATA_CELL dataRowW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.数组, DataType.数值型, ConstVavriable.outY
                                            , "轮廓行序列号", "0", yW.Count
                                            , yW, DataAtrribution.全局变量);
                F_DATA_CELL dataColW = new F_DATA_CELL(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, DataGroup.数组, DataType.数值型, ConstVavriable.outX
                                            , "轮廓列序列号", "0", xW.Count
                                            , xW, DataAtrribution.全局变量);
                UpdateVariableValue(ref m_VariableList,dataLineW);
                UpdateVariableValue(ref m_VariableList, dataRowW);
               UpdateVariableValue(ref m_VariableList, dataColW);
                this.ModuleParam.State = ModuleState.OK;
                Retsult_ = 1;
            }
            catch (System.Exception ex)
            {
              //  Helper.LogHandler.Instance.VTLogError(this.ModuleParam.PluginName + " 单元 U" + this.ModuleParam.ModuleEncode.ToString("D4") + " 错误 " + ex.ToString());
                double length = HMisc.DistancePp(tempLine.StartY, tempLine.StartX, tempLine.EndY, tempLine.EndX);
                m_MeasureXLD.GenRectangle2ContourXld(tempLine.MidY, tempLine.MidX, tempLine.Phi, length / 2, m_MetrologyInfo.Length1);
                MeasureROI roi检测范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测范围.ToString(), "green", new HObject(m_MeasureXLD));
                MeasureROI roi屏蔽范围 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.屏蔽范围.ToString(), "red", new HObject(tempDisableRegion));
                MeasureROI roi检测结果 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测结果.ToString(), "red", new HObject(new HXLDCont()));
                MeasureROI roi检测点 = new MeasureROI(this.ModuleParam.ModuleEncode.ToString(), this.ModuleParam.PluginName, this.ModuleParam.ModuleRemarks, enMeasureROIType.检测点.ToString(), "blue", new HObject(new HXLDCont()));
                m_Image.UpdateRoiList(roi屏蔽范围);
                if (showROIEnable) { m_Image.UpdateRoiList(roi检测点); }
                if (showFindAreaEnable) { m_Image.UpdateRoiList(roi检测范围); }
                if (showResultEnable) { m_Image.UpdateRoiList(roi检测结果); }
                F_DATA_CELL dataLineW = new F_DATA_CELL();
                dataLineW.InitValue(this.ModuleParam.ModuleName, this.ModuleParam.ModuleEncode, ConstVavriable.outLine, DataType.直线, "");
                UpdateVariableValue(ref m_VariableList, dataLineW);
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
        override public void SetShowModule(ModuleObjBase basemodule)
        {
            MeasureLineModuleForm set_form = new MeasureLineModuleForm((MeasureLineModuleObj)basemodule);
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
