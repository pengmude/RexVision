using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;

using HalconDotNet;

using RexConst;
using RexView;

namespace Plugin.MeasRect
{
    [Category("几何测量")]
    [DisplayName("间隙测量")]
    [Serializable]
    public class MeasRectObj : ObjBase
    {
        /// <summary>链接图像</summary>
        public string mImages = "数据链接";
        /// <summary>位置补正</summary>
        public string mCoordName = "数据链接";
        /// <summary>补正坐标系</summary>
        public Coord_Info Coord = new Coord_Info();
        /// <summary>检测形态信息</summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>屏蔽区域 </summary>
        public HRegion m_DisableRegion;
        /// <summary>第一次加载图像时参考坐标 存储图像坐标</summary>
        public Coord_Info m_RegCoord = new Coord_Info();
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool m_IsCorrect;
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public ROIRectangle2 mIntRect2 ;
        /// <summary>
        /// 输出圆信息
        /// </summary>
        public ROIRectangle2 mOutRect2 = new ROIRectangle2();
        /// <summary>
        /// 变换前-圆信息
        /// </summary>
        public ROIRectangle2 TranRect2 = new ROIRectangle2();
        /// <summary>
        /// 变换后-圆信息
        /// </summary>
        public ROIRectangle2 TempRect2 = new ROIRectangle2();
        public override bool RunObj()
        {
            TranRect2 = TempRect2 = (ROIRectangle2)mIntRect2.Clone();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                Coord_Info coord = new Coord_Info();
                if (mCoordName != "数据链接")
                {
                    coord = (Coord_Info)mSloVar.FirstOrDefault(c => c.mModName == mCoordName.Split(':')[0]).mDataValue;
                    HOperatorSet.VectorAngleToRigid(Coord.X, Coord.Y, -Coord.Phi, coord.X, coord.Y, -coord.Phi, out HTuple mHomMat2D);      //放射变换
                    Aff.Affine2d(mHomMat2D, mIntRect2.midR, mIntRect2.midC, out TranRect2.midR, out TempRect2.midC);
                    TempRect2.phi = mIntRect2.phi- coord.Phi;
                }
                else
                {
                    TranRect2 = mIntRect2;
                }
                Meas.MeasPairs(mRImage, TempRect2, mMeasInfo, out List<ROILine> m_OutLineInfo, out List<double> m_ListLineDis, out List<double> m_LineDis, out HXLDCont m_MeasXLD);

                Meas.MeasRect2((HObject)mRImage, out HXLDCont ho_Arrow, out HObject ho_Rectangle2Contour, out HObject ho_ruleContours,
                                          TempRect2.midR,
                                          TempRect2.midC,
                                          TempRect2.phi,
                                          TempRect2.length1,
                                          TempRect2.length2,
                                          44,
                                          mMeasInfo.Length1,
                                          mMeasInfo.Length2,
                                          1,
                                          mMeasInfo.Threshold,
                                            "all",
                                             "all",
                                          out HTuple  hv_resultRow,
                                          out HTuple  hv_resultColumn,
                                          out HTuple  hv_resultAngle,
                                          out HTuple  hv_resultLen1,
                                          out HTuple  hv_resultLen2,
                                          out HTuple  hv_Rows,
                                          out HTuple hv_Cols);
                HRoi[] 检测点P1 = new HRoi[1];
                HRoi[] 检测点P2 = new HRoi[m_OutLineInfo.Count];
                HRoi[] 搜索方向 = new HRoi[m_OutLineInfo.Count];
                //for (int i=0;i< new double(hv_Rows).Count;++i)
                {
                    Gen.GenCross(out HObject mCross0, hv_Rows, hv_Cols, 5, new HTuple(45).TupleRad());
                    //Gen.GenCross(out HObject mCross0, m_OutLineInfo[i].StartY, m_OutLineInfo[i].StartX, 5, new HTuple(45).TupleRad());
                    //Gen.GenCross(out HObject mCross1, m_OutLineInfo[i].EndY, m_OutLineInfo[i].EndX,  5, new HTuple(45).TupleRad());
                    //Gen.GenArrow(out HXLDCont mArrowXLD, m_OutLineInfo[i].StartY, m_OutLineInfo[i].StartX, m_OutLineInfo[i].EndY, m_OutLineInfo[i].EndX, mMeasInfo.Length2, mMeasInfo.Length2);
                    检测点P1[0] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P1, "red", new HObject(mCross0));
                    //检测点P2[i] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P2, "red", new HObject(mCross1));
                    //搜索方向[i] = new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.搜索方向, "green", new HObject(mArrowXLD));
                    //SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.间隙, ConstVar.Line, ModInfo.Plugin, "0", 1, m_OutLineInfo[i], DataAtrr.全局变量));
                }
                mRImage.ShowHRoi(检测点P1[0]);
                //for (int i = 0; i < m_OutLineInfo.Count; ++i)
                //{
                //    mRImage.ShowHRoi(检测点P1[i]);
                //    mRImage.ShowHRoi(检测点P2[i]);
                //    mRImage.ShowHRoi(搜索方向[i]);
                //}
                if (ShowROI) { mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测中心, "green", new HObject(m_MeasXLD))); }// 间隙测量
                if (ShowArea) { mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围, "cyan", new HObject(TempRect2.GetRegion()))); }
                ROIRectangle2 Rectangle2Data = Aff.Rectangle2WorldPlane(mRImage, mOutRect2);
                SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.矩形, ConstVar.Rectangle2, ModInfo.Plugin, "0", 1, mOutRect2, DataAtrr.全局变量));
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            return true;
        }
        public override void RunForm(ObjBase BaseMod)
        {
           new MeasRectForm((MeasRectObj)BaseMod) .ShowDialog();
        }
        override public void SetInfo()
        {
            mRImage = new RImage();
        }
    }
}
