using HalconDotNet;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using VisionCore;


using RexConst;
using RexView;
using System.Collections.Generic;
using System.Linq;

namespace Plugin.CreateROI
{
    [Category("检测识别")]
    [DisplayName("创建区域")]
    [Serializable]
    public class CreateROIObj : ObjBase
    {
        /// <summary>图像</summary>
        public string mImages = "数据链接";
        /// <summary>位置补正模块</summary>
        public string mCoordName = "数据链接";
        /// <summary>补正坐标系</summary>
        public Coord_Info Coord;
        /// <summary>第一次加载图像时参考坐标 存储图像坐标</summary>
        public Coord_Info mRegCoord = new Coord_Info();
        /// <summary>裁切图像</summary>
        public bool mCropImage = true;
        /// <summary>中心X</summary>
        public string mCentreX = "数据链接";
        /// <summary>中心Y</summary>
        public string mCentreY = "数据链接";
        /// <summary>区域形状类型</summary>
        public ROIType mROIType;
        /// <summary>输入圆信息</summary>
        public ROICircle mIntCircle ;
        /// <summary>变换前-圆信息</summary>
        public ROICircle TranCircle;
        /// <summary>输入圆信息</summary>
        public ROIRectangle2 mIntRect2;
        /// <summary>变换前-圆信息</summary>
        public ROIRectangle2 TranRect2;
        public override bool RunObj()
        {
            try
            {
                HObject mHObject=new HObject();
                HRegion mHRegion = new HRegion();
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                if (mCentreX.Contains("数据链接"))
                {
                    mCentreX = "0";
                }
                if (mCentreY.Contains("数据链接"))
                {
                    mCentreY = "0";
                }
                double X1 = IsNumber(mCentreX) == true ? double.Parse(mCentreX) : double.Parse(Var.GetLinkData(mSloVar, mCentreX).Split('|')[2]);
                double Y1 = IsNumber(mCentreY) == true ? double.Parse(mCentreY) : double.Parse(Var.GetLinkData(mSloVar, mCentreY).Split('|')[2]);
                Coord_Info coord = new Coord_Info();
                switch (mCoordName)
                {
                    case "":
                    case "数据链接":
                    case "链接数据":
                        {
                            coord = new Coord_Info();
                            switch (mROIType)
                            {
                                case (ROIType)0:
                                    TranRect2 = (ROIRectangle2)mIntRect2.Clone();
                                    HOperatorSet.ReduceDomain(mRImage, TranRect2.GetRegion(), out mHObject);
                                    TranRect2.midR = X1;
                                    TranRect2.midC = Y1;
                                    mHRegion = TranRect2.GetRegion();
                                    break;
                                case (ROIType)1:
                                    TranCircle = mIntCircle;
                                    TranCircle.CenterX = X1;
                                    TranCircle.CenterY = Y1;
                                    HOperatorSet.ReduceDomain(mRImage, TranCircle.GetRegion(), out mHObject);
                                    mHRegion = TranCircle.GetRegion();
                                    break;
                            }
                            break;
                        }
                    default:
                        coord = (Coord_Info)mSloVar.FirstOrDefault(c => c.mModName == mCoordName.Split(':')[0]).mDataValue;
                        HOperatorSet.VectorAngleToRigid(Coord.X, Coord.Y, -Coord.Phi, coord.X, coord.Y, -coord.Phi, out HTuple mHomMat2D);      //放射变换
                        switch (mROIType)
                        {
                            case (ROIType)0:
                                TranRect2 = (ROIRectangle2)mIntRect2.Clone();
                                Aff.Affine2d(mHomMat2D, mIntRect2.midR, mIntRect2.midC, out TranRect2.midR, out TranRect2.midC);
                                TranRect2.phi = mIntRect2.phi - coord.Phi;
                                HOperatorSet.ReduceDomain(mRImage, TranRect2.GetRegion(), out mHObject); 
                                mHRegion = TranRect2.GetRegion();
                                break;
                            case (ROIType)1:
                                TranCircle = (ROICircle)mIntCircle.Clone();
                                Aff.Affine2d(mHomMat2D, mIntCircle.CenterY, mIntCircle.CenterX, out TranCircle.CenterY, out TranCircle.CenterX);
                                HOperatorSet.ReduceDomain(mRImage, TranCircle.GetRegion(), out mHObject);
                                mHRegion = TranCircle.GetRegion();
                                break;
                        }
                        break;
                }
                HOperatorSet.CropDomain(mHObject, out HObject imagePart);
                RImage mOutRimage = new RImage(imagePart);
                mOutRimage.Status = true;
                mOutRimage.GetImageSize(out mOutRimage.Width, out mOutRimage.Height);
                switch (mROIType)
                {
                    case (ROIType)0:
                        mOutRimage.X = TranRect2.midR;
                        mOutRimage.Y = TranRect2.midC;
                        mOutRimage.Z = TranRect2.phi;
                        mOutRimage.Width =  (int)TranRect2.length1;
                        mOutRimage.Height = (int)TranRect2.length2;
                        break;
                    case (ROIType)1:
                        mOutRimage.X = TranCircle.CenterX;
                        mOutRimage.Y = TranCircle.CenterY;
                        mOutRimage.Z = TranCircle.Radius;
                        break;

                }
                if (ShowROI)
                {
                    mRImage.ShowHRoi(new HRoi(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.检测中心, "cyan", new HObject(mHRegion)));
                }
                switch (mROIType)
                {
                    case (ROIType)0:
                        SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.矩形, ConstVar.ROI, ModInfo.Plugin, "0", 1, mOutRimage, DataAtrr.全局变量));
                        break;
                    case (ROIType)1:
                        SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.圆, ConstVar.ROI, ModInfo.Plugin, "0", 1, mOutRimage, DataAtrr.全局变量));
                        break;
                }
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mOutRimage.X + "," + mOutRimage.Y );
                ModInfo.State = ModState.OK;
                return ModInfo.Result=true;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                ModInfo.State = ModState.NG;
                return ModInfo.Result = false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
          new CreateROIForm((CreateROIObj)baseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
