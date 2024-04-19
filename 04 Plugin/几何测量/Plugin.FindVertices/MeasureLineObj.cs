using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using RexConst;
using RexView;
using VisionCore;


namespace Plugin.MeasLine
{
    [Category("几何测量")]
    [DisplayName("查找顶点")]
    [Serializable]
    public class MeasLineModObj : ObjBase
    {
        #region 检测基本单元参数
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "";
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public int mHomMatID = -1;
        /// <summary>
        /// //屏蔽区域 magical 20171028
        /// </summary>
        public HRegion disableRegion = new HRegion(0d, 0d, 0d);
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Coord_Info RegCoor = new Coord_Info();
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool isCorrect;
        /// <summary>
        /// 画笔颜色
        /// </summary>
        public string m_drawColor = "#FF0000";
        ///// <summary>
        ///// 记录当前图片
        ///// </summary>
        //[NonSerialized]
        //public RImage mRImage = new RImage();
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
        private ROILine _inlineInfo = new ROILine();
        private ROILine _outLineInfo = new ROILine();
        /// <summary>
        /// 绘制直线
        /// </summary>
        public ROILine m_InLine
        {
            set { this._inlineInfo = value; }
            get { return this._inlineInfo; }
        }
        /// <summary>
        /// 输出直线
        /// </summary>
        public ROILine m_OutLine
        {
            get { return _outLineInfo; }
        }
        public override bool RunObj()
        {
            ROILine tempLine = new ROILine();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                double startX, startY, endX, endY;
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                Coord_Info coord = new Coord_Info();
                if (mHomMatID != -1)
                {
                    DataCell data = mSloVar.FirstOrDefault(c => c.mDataMode == DataMode.坐标系 && c.mModIndex == mHomMatID);
                    coord = ((List<Coord_Info>)data.mDataValue)[0];
                    HHomMat2D homMat2D = new HHomMat2D();
                    homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                    homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);
                    startX = homMat2D.AffineTransPoint2d(m_InLine.StartX, m_InLine.StartY, out startY);
                    endX = homMat2D.AffineTransPoint2d(m_InLine.EndX, m_InLine.EndY, out endY);
                    tempLine = new ROILine(startY, startX, endY, endX);
                    tempLine = Func.Line2PixelPlane(mRImage, tempLine);
                }
                else
                {
                    coord = new Coord_Info();
                    tempLine = Func.Line2PixelPlane(mRImage, m_InLine);
                }
                HXLDCont CoordXLD = Func.GetCoord(mRImage, coord);
                HRoi roi坐标系 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.参考坐标, "green", new HObject(CoordXLD));
                mRImage.ShowHRoi(roi坐标系);
                //获取图像坐标
                if (isCorrect)
                {
                    if (disableRegion != null || disableRegion.IsInitialized())
                    {
                        double row, col, regRow, regCol;
                        DataCell data = mSloVar.FirstOrDefault(c => c.mModIndex == mHomMatID);
                        coord = ((List<Coord_Info>)data.mDataValue)[0];
                        HHomMat2D homMat2D = new HHomMat2D();
                        homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                        homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);
                        regCol = homMat2D.AffineTransPoint2d(RegCoor.X, RegCoor.Y, out regRow);
                        Func.WorldPlane2Point(mRImage, regCol, regRow, out regRow, out regCol);
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
                arrowRow = hom.AffineTransPoint2d(0, mMeasInfo.Length1, out arrowCol);
                Func.GenArrow(out HXLDCont mArrowXLD, lineCenterRow, lineCenterCol, arrowRow, arrowCol, mMeasInfo.Length2, mMeasInfo.Length2);
                Func.MeasLine(mRImage, tempLine, mMeasInfo, out _outLineInfo, out m_row, out m_col, out HXLDCont mMeasXLD, tempDisableRegion);
                Func.GenCross(out HObject mMeasCross, m_row, m_col,mMeasInfo.Length2, new HTuple(_outLineInfo.Nx + new HTuple(30).TupleRad()));
                Func.GenContour(out HObject mResultXLD, _outLineInfo.StartY, _outLineInfo.EndY, _outLineInfo.StartX, _outLineInfo.EndX);
                HRoi roi搜索方向 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.搜索方向, "red", new HObject(mArrowXLD));
                mRImage.ShowHRoi(roi搜索方向);
                //添加检测roi  magical 20170821
                //mRImage.mHRoi.Clear();
                HRoi roi检测范围 = new HRoi(ModInfo.Encode,ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围, "green", new HObject(mMeasXLD.GenRegionContourXld("margin").Union1().ShapeTrans("rectangle2")));
                HRoi roi检测点   = new HRoi(ModInfo.Encode,ModInfo.Name, ModInfo.Remarks,   HRoiType.检测点, "blue", new HObject(mMeasCross));
                HRoi roi检测结果 = new HRoi(ModInfo.Encode,ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "red", new HObject(mResultXLD));
                HRoi roi屏蔽范围 = new HRoi(ModInfo.Encode,ModInfo.Name, ModInfo.Remarks, HRoiType.屏蔽范围, "red", new HObject(tempDisableRegion));
                //mRImage.ShowHRoi(roi检测范围);
                //mRImage.ShowHRoi(roi检测点);
                //mRImage.ShowHRoi(roi检测结果);
                mRImage.ShowHRoi(roi屏蔽范围);
                if (ShowROI) { mRImage.ShowHRoi(roi检测点); }
                if (ShowArea) { mRImage.ShowHRoi(roi检测范围); }
                if (ShowResult) { mRImage.ShowHRoi(roi检测结果); }
                //end magical
                //世界坐标系
                ROILine lineW = Func.Line2WorldPlane(mRImage, _outLineInfo);
                List<ROILine> temp_LineW = new List<ROILine>() { lineW };
                DataCell dataLineW = new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.直线, ConstVar.Line, "检测直线", "0", 1, temp_LineW, DataAtrr.全局变量);
                Func.Points2WorldPlane(mRImage, m_row.ToDArr().ToList(), m_col.ToDArr().ToList(), out List<double>  xW, out List<double>  yW);
                DataCell dataRowW = new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.数组, DataMode.Double, ConstVar.Y, "轮廓行序列号", "0", yW.Count, yW, DataAtrr.全局变量);
                DataCell dataColW = new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.数组, DataMode.Double, ConstVar.X, "轮廓列序列号", "0", xW.Count, xW, DataAtrr.全局变量);
                SetVarList(ref mSloVar,dataLineW);
                SetVarList(ref mSloVar, dataRowW);
               SetVarList(ref mSloVar, dataColW);
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               ShowMsg.SendLog(LogLevel.Error, ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
          new MeasLineModForm((MeasLineModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
            mRImage = new RImage();
            m_row = new HTuple();
            m_col = new HTuple();
        }
    }
}
