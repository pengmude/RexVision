using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;

using RexView;
using RexConst;

namespace Plugin.FitCircle
{
    [Category("几何构建")]
    [DisplayName("拟合圆形")]
    [Serializable]
    public class FitCircleObj : ObjBase
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
        /// <summary>点3X</summary>
        public string mP3X;
        /// <summary>点3Y</summary>
        public string mP3Y;
        /// <summary>拟合圆形</summary>
        public ROICircle mOutCircle;
        /// <summary 执行</summary>
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                double X1 = IsNumber(mP1X) == true ? double.Parse(mP1X) : double.Parse(Var.GetLinkData(mSloVar, mP1X).Split('|')[2]);
                double Y1 = IsNumber(mP1Y) == true ? double.Parse(mP1Y) : double.Parse(Var.GetLinkData(mSloVar, mP1Y).Split('|')[2]);
                double X2 = IsNumber(mP2X) == true ? double.Parse(mP2X) : double.Parse(Var.GetLinkData(mSloVar, mP2X).Split('|')[2]);
                double Y2 = IsNumber(mP2Y) == true ? double.Parse(mP2Y) : double.Parse(Var.GetLinkData(mSloVar, mP2Y).Split('|')[2]);
                double X3 = IsNumber(mP3X) == true ? double.Parse(mP3X) : double.Parse(Var.GetLinkData(mSloVar, mP3X).Split('|')[2]);
                double Y3 = IsNumber(mP3Y) == true ? double.Parse(mP3Y) : double.Parse(Var.GetLinkData(mSloVar, mP3Y).Split('|')[2]);
                Fit.FitCircle1(new List<double>() { X1, X2, X3 }, new List<double>() { Y1, Y2, Y3 }, out mOutCircle);
                Gen.GenCircle(out HObject mResult, mOutCircle.CenterY, mOutCircle.CenterX, mOutCircle.Radius);
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "green", mResult));
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.圆, ConstVar.Circle, ModInfo.Plugin, "0", 1, mOutCircle, DataAtrr.全局变量));
                Log.Info( ModInfo.Name + ":" + mOutCircle.CenterX.ToString() + "," + mOutCircle.CenterY.ToString() + "," + mOutCircle.Radius.ToString() );
                ModInfo.State = ModState.OK;
                return true;
            }
            catch { ModInfo.State = ModState.NG; return false; }
        }
        public override void RunForm(ObjBase BaseMod)
        {
           new FitCircleForm((FitCircleObj)BaseMod) .ShowDialog();
        }
        override public void SetInfo(){}
    }
}
