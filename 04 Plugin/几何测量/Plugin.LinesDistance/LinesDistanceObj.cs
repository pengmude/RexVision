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
using static VisionCore.Dis;

namespace Plugin.LinesDistance
{
    [Category("几何测量")]
    [DisplayName("线线距离")]
    [Serializable]
    public class LinesDistanceObj : ObjBase
    {
        /// <summary>输入图像</summary>
        public string mImages = "数据链接";
        /// <summary>输入直线1</summary>
        public string mLine1 = "数据链接";
        /// <summary>输入直线1</summary>
        public string mLine2 = "数据链接";
        /// <summary>输入R</summary>
        public string mLineR = "数据链接";

        /// <summary>转换值</summary>
        public bool mConverValue = false;
        /// <summary>取值模式</summary>
        public ValueMode mValueMode = ValueMode.平均值;
        /// <summary>筛选类型</summary>
        public PullType mPullType = PullType.全部点位;

        /// <summary>剔除点数</summary>
        public int mRemov = 100;
        /// <summary>提取点数</summary>
        public int mExtract = 100;
        /// <summary>剔除点百分比</summary>
        public bool mRemovPer = true;
        /// <summary>提取点百分比</summary>
        public bool mExtractPer = true;
        public override bool RunObj()
        {
            double OutDis = 0;
            if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
            {
                ModInfo.State = ModState.NoImage;
                return false;
            }
            ROILine L1 = (ROILine)(mSloVar.First(c => c.mModName.ToString() == mLine1.Split(':')[0]).mDataValue);
            ROILine L2 = (ROILine)(mSloVar.First(c => c.mModName.ToString() == mLine2.Split(':')[0]).mDataValue);
            RPoint mRPoint = new RPoint(L1.X, L1.Y);
            switch (mValueMode)
            {
                case ValueMode.最大值:
                    OutDis = DisPL(mRPoint, L2, ValueMode.最大值);
                    break;
                case ValueMode.最小值:
                    OutDis = DisPL(mRPoint, L2, ValueMode.最小值);
                    break;
                case ValueMode.平均值:
                    OutDis = DisPL(mRPoint, L2, ValueMode.平均值);
                    break;
            }
            Gen.GenCross(out HObject mCross0, L1.Y, L1.X, 5, new HTuple(45).TupleRad());
            Gen.GenContour(out HObject mResult1, L1.StartY, L1.EndY, L1.StartX, L1.EndX);
            Gen.GenContour(out HObject mResult2, L2.StartY, L2.EndY, L2.StartX, L2.EndX);
            if (ShowROI)
            {
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点, "red", mCross0));
            }
            if (ShowResult)
            {
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P1, "cyan", mResult1));
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测点P2, "cyan", mResult2));
            }
            SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Plugin, "0", 1, OutDis, DataAtrr.全局变量));
            Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + OutDis.ToString("F4"));
            ModInfo.State = ModState.OK;
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
            new LinesDistanceForm((LinesDistanceObj)baseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
