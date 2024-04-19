using HalconDotNet;
using System;
using System.ComponentModel;
using System.Linq;
using VisionCore;


using RexConst;
using RexView;

namespace Plugin.FitLine
{
    [Category("几何构建")]
    [DisplayName("拟合直线")]
    [Serializable]
    public class FitLineObj : ObjBase
    {
        /// <summary>图像</summary>
        public string mImages;
        /// <summary> 点1X</summary>
        public string mP1X;
        /// <summary>点1Y</summary>
        public string mP1Y;
        /// <summary>点2X</summary>
        public string mP2X;
        /// <summary>点2Y</summary>
        public string mP2Y;
        /// <summary>拟合直线</summary>
        public ROILine mOutLine;
        public override bool RunObj()
        {
            double X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                X1 = IsNumber(mP1X) == true ? double.Parse(mP1X) : double.Parse(Var.GetLinkData(mSloVar, mP1X).Split('|')[2]);
                Y1 = IsNumber(mP1Y) == true ? double.Parse(mP1Y) : double.Parse(Var.GetLinkData(mSloVar, mP1Y).Split('|')[2]);
                X2 = IsNumber(mP2X) == true ? double.Parse(mP2X) : double.Parse(Var.GetLinkData(mSloVar, mP2X).Split('|')[2]);
                Y2 = IsNumber(mP2Y) == true ? double.Parse(mP2Y) : double.Parse(Var.GetLinkData(mSloVar, mP2Y).Split('|')[2]);
                Fit.FitLine( X1, Y1, X2, Y2, out mOutLine);
                HOperatorSet.GenContourPolygonXld(out HObject m_ResultXLD, new HTuple(mOutLine.StartY, mOutLine.EndY), new HTuple(mOutLine.StartX, mOutLine.EndX));
                Gen.GenArrow(out HXLDCont m_ArrowXLD, mOutLine.StartY, mOutLine.StartX, mOutLine.EndY, mOutLine.EndX, 5, 5);
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.搜索方向, "cyan", new HObject(m_ArrowXLD)));
                mRImage.ShowHRoi(new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测结果, "cyan", new HObject(m_ResultXLD)));
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.直线, ConstVar.Line, ModInfo.Plugin, "0", 1, mOutLine, DataAtrr.全局变量));
                ModInfo.State = ModState.OK;
                return true;
            }
            catch { ModInfo.State = ModState.NG; return false; }
        }
        public override void RunForm(ObjBase BaseMod)
        {
            new FitLineForm((FitLineObj)BaseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
