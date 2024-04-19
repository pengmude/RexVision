using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;
using HalconDotNet;

using System.Runtime.Serialization;

using RexConst;

namespace Plugin.MeasEllipse
{
    [Category("几何测量")]
    [DisplayName("椭圆测量")]
    [Serializable]
    public class MeasEllipseObj : ObjBase
    {
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "";
        /// <summary>
        /// 补正坐标系
        /// </summary>
        public Coord_Info Coord = new Coord_Info();
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public int mHomMatID;
        /// <summary>
        /// //屏蔽区域 
        /// </summary>
        public HRegion m_DisableRegion;
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Coord_Info m_RegCoord = new Coord_Info();
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool m_IsCorrect;
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Ellipse_Info m_IntEllipse = new Ellipse_Info();
        /// <summary>
        /// 输出圆信息
        /// </summary>
        public Ellipse_Info m_OutEllipse = new Ellipse_Info();
        /// <summary>
        /// 变换前-圆信息
        /// </summary>
        public Ellipse_Info TranEllipse = new Ellipse_Info();
        /// <summary>
        /// 变换后-圆信息
        /// </summary>
        public Ellipse_Info TempEllipse = new Ellipse_Info();
        public override bool RunObj()
        {
            TempEllipse = TempEllipse = (Ellipse_Info)m_IntEllipse.Clone();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                HHomMat2D TempHomMat2D = Aff.RstHomMat2D(Coord.X, Coord.Y, -Coord.Phi);
                HHomMat2D TranHomMat2D = Aff.RstHomMat2D(0, 0, 0);
                Coord_Info coord = new Coord_Info();
                if (mHomMatID != -1)
                {
                    DataCell data = mSloVar.FirstOrDefault(c => c.mDataMode == DataMode.坐标系 && c.mModIndex == mHomMatID);
                    coord = ((List<Coord_Info>)data.mDataValue)[0];
                    //对点应用任意加法 2D 变换
                    TranEllipse.CenterX = TempHomMat2D.AffineTransPoint2d(m_IntEllipse.CenterX, m_IntEllipse.CenterY, out TranEllipse.CenterY);
                    //输入转换角度
                    TranHomMat2D = TranHomMat2D.HomMat2dRotateLocal(-coord.Phi);
                    //输入转换矩阵
                    TranHomMat2D = TranHomMat2D.HomMat2dTranslate(coord.X, coord.Y);
                    //对点应用任意加法 2D 变换
                    TempEllipse.CenterX = TranHomMat2D.AffineTransPoint2d(TranEllipse.CenterX, TranEllipse.CenterY, out TempEllipse.CenterY);
                }
                else
                {
                    coord = new Coord_Info();
                    TempEllipse = Aff.Ellipse2PixelPlane(mRImage, m_IntEllipse);
                }
                //获取图像坐标
                if (m_IsCorrect)
                {
                    if (m_DisableRegion.IsInitialized())
                    {
                        double row, col, regRow, regCol;
                        regCol = TranHomMat2D.AffineTransPoint2d(m_RegCoord.X, m_RegCoord.Y, out regRow);
                        Aff.WorldPlane2Point(mRImage, regCol, regRow, out regRow, out regCol);
                        HHomMat2D homMat = new HHomMat2D();
                        m_DisableRegion.AreaCenter(out row, out col);
                        homMat.VectorAngleToRigid(row, col, m_RegCoord.Phi, regRow, regCol, coord.Phi);
                        tempDisableRegion = homMat.AffineTransRegion(m_DisableRegion, "nearest_neighbor");
                    }
                }
                else
                {
                    tempDisableRegion = m_DisableRegion;
                    tempDisableRegion = new HRegion(0d, 0d, 0d);
                }
                HXLDCont m_MeasCross = new HXLDCont(); ///检测点十字
                HXLDCont m_ResultXLD = new HXLDCont();    ///检测结果轮廓
                Meas.MeasEllipse(mRImage, TempEllipse, mMeasInfo, out m_OutEllipse, out HTuple m_row, out HTuple m_col, out HXLDCont m_MeasXLD);
                m_MeasCross.GenCrossContourXld(m_row, m_col, (HTuple)mMeasInfo.Length2, new HTuple(45).TupleRad());
                m_ResultXLD.GenEllipseContourXld(m_OutEllipse.CenterY, m_OutEllipse.CenterX, m_OutEllipse.Phi, m_OutEllipse.Radius1, m_OutEllipse.Radius2, 0, 6.28318, "positive", 1);          
            
                Gen.GenArrow(out HXLDCont m_ArrowXLD, TempEllipse.CenterX, TempEllipse.CenterY, TempEllipse.CenterX+20, TempEllipse.CenterY+20, mMeasInfo.Length2, mMeasInfo.Length2);
                HRoi roi检测范围 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测范围, "cyan", new HObject(m_MeasXLD));
                HRoi roi检测中心 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测中心, "red", new HObject(m_MeasCross));
                HRoi roi检测结果 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测结果, "green", new HObject(m_ResultXLD));
                HRoi roi屏蔽范围 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.屏蔽范围, "red", new HObject(tempDisableRegion));
                mRImage.ShowHRoi(roi屏蔽范围);
                if (ShowROI) { mRImage.ShowHRoi(roi检测中心); }
                if (ShowArea) { mRImage.ShowHRoi(roi检测范围); }
                if (ShowResult) { mRImage.ShowHRoi(roi检测结果); }


                Aff.Points2WorldPlane(mRImage, m_row.ToDArr().ToList(), m_col.ToDArr().ToList(), out List<double> RowData, out List<double> ColData);
                SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.椭圆, ConstVar.Ellipse, "检测椭圆", "0", 1, m_OutEllipse, DataAtrr.全局变量));
                SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.数组, DataMode.Double, ConstVar.X, "轮廓行序列号", "0", RowData.Count, RowData, DataAtrr.全局变量));
                SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.数组, DataMode.Double, ConstVar.Y, "轮廓列序列号", "0", ColData.Count, ColData, DataAtrr.全局变量));
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            return true;
        }
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            if (m_DisableRegion == null || !m_DisableRegion.IsInitialized())//修复为null 错误 magical 20171103
            {
                m_DisableRegion = new HRegion((double)0, 0, 0);
            }
        }
        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (m_DisableRegion == null)
            {
                m_DisableRegion = new HRegion((double)0, 0, 0);
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
          new MeasEllipseForm((MeasEllipseObj)BaseMod).ShowDialog();
        }
        override public void SetInfo()
        {
            mRImage = new RImage();
        }
    }
}
