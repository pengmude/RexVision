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

namespace Plugin.BuildPp
{
    [Category("几何构建")]
    [DisplayName("点点构建")]
    [Serializable]
    public class BuildPpObj : ObjBase
    {
        /// <summary>输入图像</summary>
        public string mImages = "数据链接";
        /// <summary>输入点X1</summary>
        public string mPointX1 = "数据链接";
        /// <summary>输入点Y1</summary>
        public string mPointY1 = "数据链接";
        /// <summary>输入点X2</summary>
        public string mPointX2 = "数据链接";
        /// <summary>输入点Y2</summary>
        public string mPointY2 = "数据链接";
        /// <summary>点点信息</summary>
        public PtoP_Info mPtoP_Info = new PtoP_Info();
        public override bool RunObj()
        {
            double[] OutResult = new double[4];
            if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
            {
                ModInfo.State = ModState.NoImage;
                return false;
            }
            double X1 = IsNumber(mPointX1) == true ? double.Parse(mPointX1) : double.Parse(Var.GetLinkData(mSloVar, mPointX1).Split('|')[2]);
            double Y1 = IsNumber(mPointY1) == true ? double.Parse(mPointY1) : double.Parse(Var.GetLinkData(mSloVar, mPointY1).Split('|')[2]);
            double X2 = IsNumber(mPointX2) == true ? double.Parse(mPointX2) : double.Parse(Var.GetLinkData(mSloVar, mPointX2).Split('|')[2]);
            double Y2 = IsNumber(mPointY2) == true ? double.Parse(mPointY2) : double.Parse(Var.GetLinkData(mSloVar, mPointY2).Split('|')[2]);
            RPoint mRPoint1 = new RPoint(X1,Y1,0);
            RPoint mRPoint2 = new RPoint(X2, Y2, 0);
            OutResult[0] = Math.Abs((X1+X2)/2);
            OutResult[1] = Math.Abs((Y1+Y2)/2);
            OutResult[2] = Dis.GenAngle(mRPoint1, mRPoint2);
            OutResult[3] = Dis.DisPP(mRPoint1, mRPoint2);
            mPtoP_Info = new PtoP_Info(ModInfo.Name, OutResult[0], OutResult[1], OutResult[2], OutResult[3]);
            Gen.GenCross(out HObject mCross0, Y1, X1, 5, new HTuple(45).TupleRad());
            Gen.GenCross(out HObject mCross1, Y2, X2, 5, new HTuple(45).TupleRad());
            Gen.GenContour(out HObject mResult, Y1, Y2, X1, X2);
            if (ShowROI)
            {
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P1, "blue", mCross0));
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P2, "blue", mCross1));
            }
            if (ShowResult){mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测结果, "cyan",mResult));}
            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.点点, ConstVar.Result, ModInfo.Plugin, "0", 1, mPtoP_Info, DataAtrr.全局变量));
            Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + OutResult[0].ToString("F4") + OutResult[1].ToString("F4") +","+ OutResult[2].ToString("F4") + "," + OutResult[3].ToString("F4") + "," );
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
          new BuildPpForm((BuildPpObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
