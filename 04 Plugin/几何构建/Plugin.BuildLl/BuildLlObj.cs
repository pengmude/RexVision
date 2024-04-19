using HalconDotNet;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.BuildLl
{
    [Category("几何构建")]
    [DisplayName("线线交点")]
    [Serializable]
    public class BuildLlObj : ObjBase
    {
        /// <summary>输入图像</summary>
        public string mImages = "数据链接";
        /// <summary>输入直线1X</summary>
        public string mLine1X = "数据链接";
        /// <summary>输入直线1Y</summary>
        public string mLine1Y = "数据链接";
        /// <summary>输入直线1Y</summary>
        public string mLine1R = "数据链接";
        /// <summary>输入直线2X</summary>
        public string mLine2X = "数据链接";
        /// <summary>输入直线2Y</summary>
        public string mLine2Y = "数据链接";
        /// <summary>输入直线2R</summary>
        public string mLine2R = "数据链接";
        public double[] OutResult = new double[3];
        public override bool RunObj()
        {
            if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
            {
                ModInfo.State = ModState.NoImage;
                return false;
            }
            //double X = IsNumber(mPointX) == true ? double.Parse(mPointX) : double.Parse(Var.GetLinkData(mSloVar, mPointX.Split(':')[0], mPointX.Split(':')[1]).Split('|')[2]);
            //double Y = IsNumber(mPointY) == true ? double.Parse(mPointY) : double.Parse(Var.GetLinkData(mSloVar, mPointY.Split(':')[0], mPointY.Split(':')[1]).Split('|')[2]);
            ROILine L1 = (ROILine)(mSloVar.First(c => c.mModName.ToString() == mLine1X.Split(':')[0]).mDataValue);
            ROILine L2 = (ROILine)(mSloVar.First(c => c.mModName.ToString() == mLine2X.Split(':')[0]).mDataValue);

            Dis.IntersectionLl(L1, L2, out OutResult[0], out OutResult[0], out int isParallel);

            Gen.GenCross(out HObject mCross1, OutResult[0], OutResult[1], 5, new HTuple(45).TupleRad());
            Gen.GenContour(out HObject mLine1, L1.StartX, L1.EndX, L1.StartY, L1.EndY);
            Gen.GenContour(out HObject mLine2, L2.StartX, L2.EndX, L2.StartY, L2.EndY);
            if (ShowROI)
            {
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点, "red", mCross1));
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P1, "green", new HObject(mLine1)));
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P2, "green", new HObject(mLine2)));
            }
            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, ModInfo.Plugin, "0", 1, OutResult, DataAtrr.全局变量));
            Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + OutResult[0].ToString("F4") + "," + OutResult[1].ToString("F4") );
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new BuildLlForm((BuildLlObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
