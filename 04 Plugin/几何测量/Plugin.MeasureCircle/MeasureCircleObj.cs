using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using HalconDotNet;
using VisionCore;

using RexView;
using RexConst;

namespace Plugin.MeasCircle
{
    [Category("几何测量")]
    [DisplayName("圆心测量")]
    [Serializable]
    public class MeasCircleObj : ObjBase
    {
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "数据链接";
        /// <summary>
        /// 位置补正模块
        /// </summary>
        public string mCoordName = "数据链接";
        /// <summary>
        /// 补正坐标系
        /// </summary>
        public Coord_Info Coord ;
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Coord_Info m_RegCoord = new Coord_Info();
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>
        /// //屏蔽区域 
        /// </summary>
        public HRegion m_DisableRegion;
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool m_IsCorrect;
        /// <summary>
        /// 输入圆信息
        /// </summary>
        public ROICircle mIntCircle;
        /// <summary>
        /// 变换前-圆信息
        /// </summary>
        public ROICircle TranCircle = new ROICircle();
        /// <summary>
        /// 输出圆信息
        /// </summary>
        public ROICircle mOutCircle = new ROICircle();
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                TranCircle = (ROICircle)mIntCircle.Clone();
                Coord_Info coord = new Coord_Info();
                switch(mCoordName)
                {
                    case "数据链接":
                        coord = new Coord_Info();
                        TranCircle = mIntCircle;// Find.Circle2PixelPlane(mRImage, mIntCircle);
                        break;
                    default:
                        coord = (Coord_Info)mSloVar.FirstOrDefault(c => c.mModName == mCoordName.Split(':')[0]).mDataValue;
                        HOperatorSet.VectorAngleToRigid(Coord.X, Coord.Y,  -Coord.Phi, coord.X, coord.Y,  -coord.Phi, out HTuple mHomMat2D);      //放射变换
                        Aff.Affine2d(mHomMat2D, mIntCircle.CenterY, mIntCircle.CenterX, out TranCircle.CenterY, out TranCircle.CenterX);
                        break;
                }
                Meas.MeasCircle(mRImage, TranCircle, mMeasInfo, null, out mOutCircle, out HTuple RowList, out HTuple ColList, out HXLDCont m_MeasXLD);
                Gen.GenCross(out HObject MeasCross,RowList, ColList, mMeasInfo.Length2, new HTuple(45).TupleRad());
                Gen.GenCircle(out HObject mResultXLD, mOutCircle.CenterX, mOutCircle.CenterY, mOutCircle.Radius);
                if (ShowROI) { mRImage.ShowHRoi(new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测中心, "red", new HObject(MeasCross))); }
                if (ShowResult) { mRImage.ShowHRoi(new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测结果, "green", new HObject(mResultXLD))); }
                if (ShowArea) { mRImage.ShowHRoi(new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测范围, "cyan", new HObject(m_MeasXLD))); }
                ROICircle CircleData = Aff.Circle2WorldPlane(mRImage, mOutCircle);
                Aff.Points2WorldPlane(mRImage, RowList.ToDArr().ToList(), ColList.ToDArr().ToList(), out List<double> RowData, out List<double> ColData);
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.圆, ConstVar.Circle, ModInfo.Plugin, "0", 1, mOutCircle, DataAtrr.全局变量));
               Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mOutCircle.CenterX.ToString("F4") + "," + mOutCircle.CenterY.ToString("F4") + "," + mOutCircle.Radius.ToString("F4") );
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               mOutCircle.Status = false;
               ModInfo.State = ModState.NG;
               Log.Info( ModInfo.Name + ex.Message );
            }
            return true;
        }
        public override void RunForm(ObjBase BaseMod)
        {
           new MeasCircleForm((MeasCircleObj)BaseMod).ShowDialog();
        }
        public override void SetInfo()
        {
            mRImage = new RImage();
        }
    }
}
