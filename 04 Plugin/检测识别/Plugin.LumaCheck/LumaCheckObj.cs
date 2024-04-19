using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;

using RexView;
using RexConst;

namespace Plugin.LumaCheck
{
    [Category("检测识别")]
    [DisplayName("亮度检查")]
    [Serializable]
    public class LumaCheckObj : ObjBase
    {
        /// <summary>图像</summary>
        public string mImages;
        /// <summary>区域</summary>
        public string mRoi;
        /// <summary>最小灰度</summary>
        public double mMinThreshod = 0;
        /// <summary>最大灰度</summary>
        public double mMaxThreshod = 255;
        /// <summary>检测信息</summary>
        public Luma_Info mLuma_Info = new Luma_Info();
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
                RImage CheckImage = (RImage)Var.GetImage(mSloVar, mRoi);
                Find.FindLumaCheck(mRImage, CheckImage, mMinThreshod, mMaxThreshod, out double Area, out double Mean, out double Min, out double Max, out double Range, out HXLDCont mHRange);
                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Plugin, ModInfo.Remarks, HRoiType.检测结果, "red", new HObject(mHRange)));
                DataCell mDataCell = mSloVar.First(c => c.mModName == mRoi.Split(':')[0]);
                switch(mDataCell.mDataMode)
                {
                    case DataMode.圆:
                        {
                            ROICircle mRect = new ROICircle();
                            mRect.CenterX = CheckImage.X;
                            mRect.CenterY = CheckImage.Y;
                            mRect.Radius = CheckImage.Width/2;
                            if (ShowROI)
                            {
                                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.搜索范围, "cyan", new HObject(mRect.GetRegion())));
                            }
                            break;
                        }
                    case DataMode.矩形:
                        {
                            ROIRectangle2 mRect = new ROIRectangle2();
                            mRect.midR = CheckImage.X;
                            mRect.midC = CheckImage.Y;
                            mRect.phi = CheckImage.Z;
                            mRect.length1 = CheckImage.Width;
                            mRect.length2 = CheckImage.Height;
                            if (ShowROI)
                            {
                                mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.搜索范围, "cyan", new HObject(mRect.GetRegion())));
                            }
                            break;
                        }
                }      
                mLuma_Info=new Luma_Info(Area, Mean, Min, Max, Range);
                mLuma_Info.Status = true;
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.StringArr, ConstVar.Circle, ModInfo.Plugin, "0", 1, mLuma_Info, DataAtrr.全局变量));
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":面积" + Area.ToString("F0") + ",平均" + Mean.ToString("F0") + ",最小" + Min.ToString("F0") + ",最大" + Max.ToString("F0") + ",范围" + Range.ToString("F0"));
                ModInfo.State = ModState.OK;
                return true;
            }
            catch { mLuma_Info.Status = false; ModInfo.State = ModState.NG; return false; }
        }
        public override void RunForm(ObjBase BaseMod)
        {
            new LumaCheckForm((LumaCheckObj)BaseMod).ShowDialog();
        }
        override public void SetInfo() { }
    }
}
