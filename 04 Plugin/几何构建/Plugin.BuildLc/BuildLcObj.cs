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

namespace Plugin.BuildLc
{
    [Category("几何构建")]
    [DisplayName("线圆构建")]
    [Serializable]
    public class BuildLcObj : ObjBase
    {
        /// <summary>输入图像</summary>
        public string mImages = "数据链接";
        /// <summary>输入点X</summary>
        public string mPointX = "数据链接";
        /// <summary>输入点Y</summary>
        public string mPointY = "数据链接";
        /// <summary>输入直线1</summary>
        public string mLine1 = "数据链接";
        /// <summary>输入直线1</summary>
        public string mLine2 = "数据链接";
        /// <summary>输入R</summary>
        public string mLineR = "数据链接";
        public double[] OutResult = new double[3];
        public override bool RunObj()
        {
            if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
            {
                ModInfo.State = ModState.NoImage;
                return false;
            }
            double X = IsNumber(mPointX) == true ? double.Parse(mPointX) : double.Parse(Var.GetLinkData(mSloVar, mPointX).Split('|')[2]);
            double Y = IsNumber(mPointY) == true ? double.Parse(mPointY) : double.Parse(Var.GetLinkData(mSloVar, mPointY).Split('|')[2]);
            ROILine L2 = (ROILine)(mSloVar.First(c => c.mModName.ToString() == mLine2.Split(':')[0]).mDataValue);
            Dis.PLPedal(X, Y, L2, out OutResult[0], out OutResult[1], out OutResult[2]);

            Gen.GenCross(out HObject mCross0, Y, X, 5, new HTuple(45).TupleRad());
            Gen.GenCross(out HObject mCross1, OutResult[0], OutResult[1], 5, new HTuple(45).TupleRad());
            Gen.GenContour(out HObject mResult, Y, OutResult[0], X, OutResult[1]);
            if (ShowROI)
            {
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P1, "blue", mCross0));
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P2, "blue", mCross1));
            }
            if (ShowResult){mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "cyan",mResult));}
            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点2D, ConstVar.Result, ModInfo.Plugin, "0", 1, OutResult, DataAtrr.全局变量));
            Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + OutResult[0].ToString("F4") + "," + OutResult[1].ToString("F4") + "," + OutResult[2].ToString("F4") );
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new BuildLcForm((BuildLcObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
