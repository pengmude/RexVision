using System;
using System.ComponentModel;
using System.Linq;
using HalconDotNet;
using VisionCore;


using RexView;
using RexConst;

namespace Plugin.MeasLine
{
    [Category("几何测量")]
    [DisplayName("直线测量")]
    [Serializable]
    public class MeasLineObj : ObjBase
    {
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "数据链接";
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public string mCoordName = "数据链接";
        /// <summary>
        /// 补正坐标系
        /// </summary>
        public Coord_Info Coord = new Coord_Info();
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>
        /// 输入直线信息
        /// </summary>
        public ROILine mIntLine ;
        /// <summary>
        /// 输出直线信息
        /// </summary>
        public ROILine mOutLine = new ROILine();
        /// <summary>
        /// 变换后-直线信息
        /// </summary>
        public ROILine TranLine = new ROILine();
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                TranLine = (ROILine)mIntLine.Clone();
                HHomMat2D TempHomMat2D = new HHomMat2D();
                Coord_Info coord = new Coord_Info();
                if (mCoordName!= "数据链接")
                {
                    coord=(Coord_Info)mSloVar.FirstOrDefault(c =>c.mModName == mCoordName.Split(':')[0]).mDataValue;
                    HOperatorSet.VectorAngleToRigid(Coord.X, Coord.Y, -Coord.Phi, coord.X, coord.Y, -coord.Phi, out HTuple mHomMat2D);      //放射变换
                    Aff.Affine2d(mHomMat2D, mIntLine.StartY, mIntLine.StartX, mIntLine.EndY, mIntLine.EndX, out TranLine.StartY, out TranLine.StartX,out TranLine.EndY, out TranLine.EndX);
                }
                else
                {
                    TranLine = mIntLine;// Find.Line2PixelPlane1(mRImage, mIntLine);
                }
                Meas.MeasLine(mRImage, TranLine, mMeasInfo, out mOutLine, out HTuple RowList, out HTuple ColList, out HXLDCont m_MeasXLD, null);
                Gen.GenCross(out HObject m_MeasCross, RowList, ColList,   mMeasInfo.Length2, new HTuple(45).TupleRad());
                Gen.GenContour(out HObject m_ResultXLD, mOutLine.StartY, mOutLine.EndY,mOutLine.StartX, mOutLine.EndX);
                if (ShowROI) { mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测中心, "red", new HObject(m_MeasCross))); }
                if (ShowResult) { mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "green", new HObject(m_ResultXLD))); }
                if (ShowArea) { mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测范围, "cyan", new HObject(m_MeasXLD.GenRegionContourXld("margin").Union1().ShapeTrans("rectangle2")))); }
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.直线, ConstVar.Line, ModInfo.Plugin, "0", 1, mOutLine, DataAtrr.全局变量));
                Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mOutLine.MidX.ToString("F4") + "," + mOutLine.MidY.ToString("F4") + "," + mOutLine.Phi.ToString("F4") + "," + mOutLine.Dist.ToString("F4") );
                ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
                mOutLine.Status = false;
                ModInfo.State = ModState.NG;
                Log.Error( ModInfo.Name + ex.Message);
            }
            return true;
        }
        public override  void RunForm(ObjBase baseMod)
        {
            new MeasLineForm((MeasLineObj)baseMod).ShowDialog();
        }
        public override  void SetInfo()
        {
            mRImage = new RImage();
        }
    }
}
