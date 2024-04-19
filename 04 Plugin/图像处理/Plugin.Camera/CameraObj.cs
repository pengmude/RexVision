using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using VisionCore;
using System.IO;
using RexConst;
using System.Windows.Forms;
using HalconDotNet;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;

namespace Plugin.Camera
{
    [Category("图像处理")]
    [DisplayName("图像采集")]
    [Serializable]
    public class CameraObj : ObjBase
    {
        /// <summary>图像索引</summary>
        public int index = 0;
        /// <summary>窗体索引</summary>
        public int mScreen = 1;
        /// <summary>循环读取</summary>
        public bool mForRead = true;
        /// <summary>畸变标定</summary>
        public string mLikeDistCal="数据链接";
        /// <summary>测量标定</summary>
        public string mLikeMeasCal = "数据链接";
        /// <summary>设备ID</summary>
        public string mCameraNo="None";
        /// <summary>图像路径</summary>
        public string mImagePath=@"D:\img";
        /// <summary>文件路径</summary>
        public string mFilePath = @"D:\img";
        /// <summary>路径集合</summary>
        public List<string> mFileInfo;
        /// <summary>选择功能 通过文件或者相机获取图片</summary>
        public ImageSource mImageSource = (ImageSource)1;
        /// <summary>选择的设备标识</summary>
        public CamerasBase mCamerasBase;
        public HText mHText = new HText("#00FEFF", " ","",5,5,10);
        public bool mShowHText = true;
        /// <summary>设备标识符</summary>
        public string CameraNo
        {
            get { return mCameraNo; }
            set
            {
                mCameraNo = value;
                mCamerasBase = mCamera.FirstOrDefault(c => c.mCameraNo == mCameraNo);
            }
        }
        public override bool RunObj()
        {
            try
            {
                //while (true)
                {
                    mRImage = new RImage(); 
                    switch (mImageSource)
                    {
                        case ImageSource.指定图像:
                            mRImage = RImage.ReadRImage(mImagePath);
                            break;
                        case ImageSource.文件目录:
                            index = index >= mFileInfo.Count ? 0 : index;
                            for (int i = index; i < mFileInfo.Count; i++)
                            {
                                mRImage = RImage.ReadRImage(mFileInfo[index]);
                                if (mForRead)
                                {
                                    ++index;
                                }
                                break;
                            }
                            break;
                        case ImageSource.相机采集:
                            if (mCamerasBase.mConnected)
                            {
                                mCamerasBase.CaptureImage(false);
                                mRImage = (RImage)mCamerasBase.Image;
                                mRImage.Name = mCamerasBase.mRemark;
                            }
                            else
                            {
                                Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mCamerasBase.mCameraNo + "相机未连接!" );
                            }
                            break;
                    }
                    string mMeasData = "";
                    try
                    {//暂且不管,么得时间
                        if (!mLikeMeasCal.Contains("数据链接"))
                        {
                            mRImage.ScaleX = mRImage.ScaleY = double.Parse(mLikeMeasCal.Split(':')[2]);
                            mMeasData = "标定:" + mRImage.ScaleX.ToString("F4") + "  ";
                        }
                        if (!mLikeDistCal.Contains("数据链接"))
                        {
                            DataCell mDist = mSysVar.FirstOrDefault(c => c.mModName == mLikeDistCal.Split(':')[0]);//mLikeDistCal
                        }
                    }
                    catch(Exception ex)
                    {
                        Log.Error(ModInfo.Name+":"+ ex.Message);
                    }
                    if (mRImage!=null&mRImage.IsInitialized())
                    {
                            mRImage.mHRoi.Clear();
                            mRImage.mHText.Clear();
                            mRImage.Screen = mScreen;
                            mRImage.GetImageSize(out mRImage.Width, out mRImage.Height);
                        mRImage.Status = true;
                        ModInfo.State = ModState.OK;
                    }
                    else
                    {
                        ModInfo.State = ModState.NG;
                    }
                    SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.图像, ConstVar.Image, ModInfo.Plugin, "0", 1, mRImage, DataAtrr.全局变量));
                    if (mShowHText)
                    {
                        mRImage.ShowHText(new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, mHText.drawColor, mHText.text + mMeasData + mRImage.Name, "mono", mHText.row, mHText.col, mHText.size, mRImage, false));

                    }
                    Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mRImage.Name );
                    return true;
                }
            }
            catch (Exception ex)
            {
                ModInfo.State = ModState.NG;
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + ex.Message);
                return  false;
            }

        }
        public override void RunForm(ObjBase BaseMod)
        {
          new CameraForm((CameraObj)BaseMod).ShowDialog();
        }
        override public void SetInfo(){}
    }
}
