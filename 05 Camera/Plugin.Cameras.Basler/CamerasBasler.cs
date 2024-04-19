using System;
using System.Collections.Generic;
using Basler.Pylon;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ComponentModel;
using VisionCore;
using System.Threading;
using System.Collections.Concurrent;

namespace Plugin.Cameras.Basler
{
    [Category("Basler相机")]
    [DisplayName("Basler相机")]
    [Serializable]
    public class CamerasBasler : CamerasBase
    {
        [NonSerialized]
        private Camera mCamera;
        [NonSerialized]
        private Stopwatch mStopwatch = new Stopwatch();
        [NonSerialized]
        PixelDataConverter mConverter = new PixelDataConverter();
        /// <summary> >= Sfnc2_0_0,说明是ＵＳＢ３的相机</summary>
        [NonSerialized]
        static Version Sfnc2_0_0 = new Version(2, 0, 0);
        public CamerasBasler() : base() { }
        /// <summary>搜索相机</summary>
        public override List<CamerasInfo> SearchCameras()
        {
            List<CamerasInfo> _CamInfoList = new List<CamerasInfo>();
            List<ICameraInfo> allCameras = CameraFinder.Enumerate();
            foreach (ICameraInfo item in allCameras)
            {
                CamerasInfo mCamerasInfo = new CamerasInfo();
                mCamerasInfo.m_SerialNO = item[CameraInfoKey.SerialNumber];
                try
                {
                    mCamerasInfo.m_CameraIP = item[CameraInfoKey.DeviceIpAddress];
                }
                catch
                {
                    mCamerasInfo.m_CameraIP = "00:00:00:00";
                }
                mCamerasInfo.m_CamName = "Basler" + item[CameraInfoKey.SerialNumber];
                mCamerasInfo.m_MaskName = "Basler" + item[CameraInfoKey.SerialNumber];
                mCamerasInfo.m_Connected = false;
                _CamInfoList.Add(mCamerasInfo);
            }
            return _CamInfoList;
        }
        /// <summary>
        /// 连接相机
        /// </summary>
        public override void ConnectDev()
        {
            try
            {
                base.ConnectDev();
                DisConnectDev();// 如果设备已经连接先断开
                mCamera = new Camera(mSerialNo);
                mCamera.Open();
                mCamera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                mCamera.StreamGrabber.GrabStarted += OnGrabStarted;
                mCamera.StreamGrabber.GrabStopped += OnGrabStopped;
                mCamera.ConnectionLost += OnConnectionLost;
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    mCameraIP = mCamera.CameraInfo[CameraInfoKey.DeviceIpAddress];

                }
                else
                {
                    mCameraIP = "00:00:00:00";
                }
                mFramerate = mCamera.Parameters[PLCamera.PixelFormat].GetValue();
                mWidthMax = (int)mCamera.Parameters[PLCamera.Width].GetValue();
                mHeightMax = (int)mCamera.Parameters[PLCamera.Height].GetValue();
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    mGainMax = mCamera.Parameters[PLCamera.GainRaw].GetMaximum();
                    mGainMin = mCamera.Parameters[PLCamera.GainRaw].GetMinimum();
                    mExposeTimeMax = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMaximum();
                    mExposeTimeMin = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMinimum();
                }
                else
                {
                    mGainMax = (long)mCamera.Parameters[PLUsbCamera.Gain].GetMaximum();
                    mGainMin = (long)mCamera.Parameters[PLUsbCamera.Gain].GetMinimum();
                    mExposeTimeMax = (long)mCamera.Parameters[PLUsbCamera.ExposureTime].GetMaximum();
                    mExposeTimeMin = (long)mCamera.Parameters[PLUsbCamera.ExposureTime].GetMinimum();
                }
                mWidth = mWidth == 0 ? mWidthMax : mWidth;
                mHeight = mHeight == 0 ? mHeightMax : mHeight;
                mGain = mGain == 0 ? mGainMax - mGainMin : mGain;
                mExposeTime = mExposeTime == 0 ? mExposeTimeMin : mExposeTime;
                mConnected = true;
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler Connect:" + ex.Message);
                mConnected = false;
            }
        }

        /// <summary>
        /// 断开相机
        /// </summary>
        public override void DisConnectDev()
        {
            try
            {
                if (mCamera != null)
                {
                    mCamera.Close();
                    mCamera.Dispose();
                    mCamera = null;
                    mConnected = false;
                }
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler DisConnect:" + ex.Message);
            }
        }
        /// <summary>
        /// 采集图像
        /// </summary>
        /// <param name="byHand">是否手动采图</param>
        public override bool CaptureImage(bool byHand)
        {
            try
            {
                Log.Warn(mRemark + ":" + "相机采集:CaptureImage1");
                if (mCamera == null || mCamera.IsConnected == false)
                {
                    Log.Warn(mRemark + ":" + "相机采集:断开连接!");
                    ConnectDev();
                    if (mCamera == null || mCamera.IsConnected == false)
                    {
                        Log.Warn(mRemark + ":" + "相机采集:重连失败!" + mCamera.ToString() + " " + mCamera.IsConnected.ToString());
                        return false;
                    }
                }
                Log.Warn(mRemark + ":" + "相机采集:CaptureImage2");
                if (byHand)
                {
                    //设置触发模式
                    SetTriggerMode(TrigMode.软触发);
                    //拍一张
                    mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                    mCamera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                    //还原之前的触发模式
                    SetTriggerMode(mTrigMode);
                }
                else
                {
                    Log.Warn(mRemark + ":" + "相机采集:CaptureImage3");
                    if (mTrigMode == TrigMode.软触发)
                    {
                        Log.Warn(mRemark + ":" + "相机采集:CaptureImage4");
                        SignalWait.WaitOne();
                        //拍一张
                        mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                        mCamera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                        SignalWait.Reset();
                        Log.Warn(mRemark + ":" + "相机采集:CaptureImage5");
                    }
                    else
                    {
                        Log.Warn(mRemark + ":" + "相机采集:CaptureImage6");
                        GetSignalWait.Reset();
                        //SetTriggerMode(TrigMode.软触发);
                        //拍一张
                        mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.SingleFrame);
                        mCamera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
                        GetSignalWait.WaitOne(2000);
                        Log.Warn(mRemark + ":" + "相机采集:CaptureImage7");
                    }
                }
                Log.Warn(mRemark + ":" + "相机采集:CaptureImage8");
                return true;
            }
            catch (Exception ex)
            {
                StopGrab();
                Log.Error(mRemark + ":" + "Basler Image Capture:" + ex.Message);
                if (mTrigMode == TrigMode.软触发)
                {
                    SignalWait.Set();
                }
                else
                {
                    GetSignalWait.Set();
                }
                return false;
            }
        }
        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="filePath"></param>
        public override void LoadSetting(string filePath)
        {
            base.LoadSetting(filePath);
        }
        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="filePath"></param>
        public override void SaveSetting(string filePath)
        {
            base.SaveSetting(filePath);
        }
        /// <summary> 相机设置</summary>
        public override void SetSetting()
        {
            SetWidth();
            SetHeight();
            SetGain((long)mGain);
            SetExposureTime((long)mExposeTime);
            SetTriggerMode(mTrigMode);
        }
        public override void CameraChanged(ChangType changTyp)
        {
            try
            {
                switch (changTyp)
                {
                    case ChangType.增益:
                        SetGain((long)mGain);
                        break;
                    case ChangType.曝光:
                        SetExposureTime((long)mExposeTime);
                        break;
                    case ChangType.宽度:
                        SetWidth();
                        break;
                    case ChangType.高度:
                        SetHeight();
                        break;
                    case ChangType.触发:
                        SetTriggerMode((TrigMode)mTrigMode);
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler:" + ex.Message);
            }
        }
        /// <summary>设置宽度</summary>
        public void SetWidth()
        {
            if (mWidth > 100 & mWidth <= mWidthMax)
            {
                mCamera.Parameters[PLCamera.Width].SetValue(mWidth);
            }
        }
        /// <summary>设置高度</summary>
        public void SetHeight()
        {
            if (mHeight > 100 & mHeight <= mHeightMax)
            {
                mCamera.Parameters[PLCamera.Height].SetValue(mHeight);
            }
        }
        /// <summary>设置增益</summary>
        public void SetGain(long value)
        {
            try
            {
                //一些相机可能有自动功能启用。若要将增益值设置为特定值，
                //增益自动功能必须首先被禁用(如果增益自动可用)。
                mCamera.Parameters[PLCamera.GainAuto].TrySetValue(PLCamera.GainAuto.Off); //如果GainAuto是可写的，则设置为Off。
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    //一些参数有限制。您可以使用GetIncrement/GetMinimum/GetMaximum来确保您设置了一个有效的值。
                    //在以前的SFNC版本中，GainRaw是一个整数形参。
                    //整型参数的数据，设置之前，需要进行有效值整合，否则可能会报错
                    //long mGainMin = mCamera.Parameters[PLCamera.GainRaw].GetMinimum();
                    //long mGainMax = mCamera.Parameters[PLCamera.GainRaw].GetMaximum();
                    long incr = mCamera.Parameters[PLCamera.GainRaw].GetIncrement();
                    if (value < (long)mGainMin)
                    {
                        value = (long)mGainMin;
                    }
                    else if (value > mGainMax)
                    {
                        value = (long)mGainMax;
                    }
                    else
                    {
                        value = (long)mGainMin + (((value - (long)mGainMin) / incr) * incr);
                    }
                    mCamera.Parameters[PLCamera.GainRaw].SetValue(value);
                    //或者，在这里，如果需要，我们让pylon修正值。
                    //mCamera.Parameters[PLCamera.GainRaw].SetValue(value, IntegerValueCorrection.Nearest);
                }
                else //用于SFNC 2.0摄像机，例如USB3视觉摄像机
                {
                    //在SFNC 2.0中，增益是一个浮动参数。
                    mCamera.Parameters[PLUsbCamera.Gain].SetValue(value);
                }
                mGain = value;
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler:" + ex.Message);
            }
        }
        /// <summary>设置相机曝光时间</summary>
        public void SetExposureTime(long value)
        {
            try
            {
                //一些相机可能有自动功能启用。将曝光时间值设置为一个特定的值，
                //曝光自动功能必须首先被禁用(如果曝光自动可用)。
                mCamera.Parameters[PLCamera.ExposureAuto].TrySetValue(PLCamera.ExposureAuto.Off);//曝光自动设置为关闭，如果它是可写的。
                mCamera.Parameters[PLCamera.ExposureMode].TrySetValue(PLCamera.ExposureMode.Timed); ;//如果它是可写的，将ExposureMode设置为定时。
                if (mCamera.GetSfncVersion() < Sfnc2_0_0)
                {
                    //在以前SFNC版本,ExposureTimeRaw是一个整数参数,单位,单位us
                    //整型参数的数据，设置之前，需要进行有效值整合，否则可能会报错
                    //long mGainMin = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMinimum();
                    //long mGainMax = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetMaximum();
                    long incr = mCamera.Parameters[PLCamera.ExposureTimeRaw].GetIncrement();
                    if (value < (long)mExposeTimeMin)
                    {
                        value = (long)mExposeTimeMin;
                    }
                    else if (value > (long)mExposeTimeMax)
                    {
                        value = (long)mExposeTimeMax;
                    }
                    else
                    {
                        value = (long)mExposeTimeMin + (((value - (long)mExposeTimeMin) / incr) * incr);
                    }
                    mCamera.Parameters[PLCamera.ExposureTimeRaw].SetValue(value);
                }
                else // 用于SFNC 2.0摄像机，例如USB3视觉摄像机
                {
                    // 在SFNC 2.0中，ExposureTimeRaw被重命名为ExposureTime，是一个浮动参数, 单位us.
                    mCamera.Parameters[PLUsbCamera.ExposureTime].SetValue(value);
                }
                mExposeTime = value;
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler:" + ex.Message);
            }
        }
        /// <summary>设置触发</summary>
        public override bool SetTriggerMode(TrigMode _TrigMode)
        {
            try
            {
                if (mCamera == null) return false;
                //如果是实时采集 则先停止
                if (mCamera.StreamGrabber.IsGrabbing && mCamera.Parameters[PLCamera.AcquisitionMode].GetValue() == PLCamera.AcquisitionMode.Continuous)
                {
                    StopGrab();
                }
                switch (_TrigMode)
                {
                    case TrigMode.内触发:   // no acquisition
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                            StopGrab();
                            break;
                        }
                    case TrigMode.软触发:   // freerunning
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.Off);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Software);
                            StartGrab();
                            break;
                        }
                    case TrigMode.上升沿:   // Software trigger
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Line1);
                            mCamera.Parameters[PLCamera.TriggerActivation].SetValue(PLCamera.TriggerActivation.RisingEdge);
                            StopGrab();
                            break;
                        }
                    case TrigMode.下降沿:   // Software trigger
                        {
                            mCamera.Parameters[PLCamera.TriggerMode].SetValue(PLCamera.TriggerMode.On);
                            mCamera.Parameters[PLCamera.TriggerSource].SetValue(PLCamera.TriggerSource.Line1);
                            mCamera.Parameters[PLCamera.TriggerActivation].SetValue(PLCamera.TriggerActivation.FallingEdge);
                            StopGrab();
                            break;
                        }
                }
                return true;
            }
            catch (Exception ex)
            {
                StopGrab();
                Log.Error(mRemark + ":" + "Basler TrigMode:" + ex.Message);
                return false;
            }
        }
        #region 相机事件
        /// <summary>
        /// 断开连接时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnConnectionLost(Object sender, EventArgs e)
        {
            // Close the mCamera object.
            DisConnectDev();
            Log.Error(mRemark + ":" + "相机采集:断开连接!");
        }
        /// <summary>
        /// 开始触发时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGrabStarted(Object sender, EventArgs e)
        {
            Log.Warn(mRemark + ":" + "相机采集:触发开始");
            // Reset the stopwatch used to reduce the amount of displayed images. The mCamera may acquire images faster than the images can be displayed.
            mStopwatch.Reset();
        }
        /// <summary>
        /// 触发结束时
        /// </summary>
        private void OnGrabStopped(Object sender, GrabStopEventArgs e)
        {
            Log.Warn(mRemark + ":" + "相机采集:触发结束");
            // Reset the stopwatch.
            mStopwatch.Reset();
        }
        /// <summary>
        /// 采集回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnImageGrabbed(Object sender, ImageGrabbedEventArgs e)
        {
            try
            {
                Log.Warn(mRemark + ":" + "相机采集:回调开始1");
                // Acquire the image from the mCamera. Only show the latest image. The mCamera may acquire images faster than the images can be displayed.
                // Get the grab result.
                IGrabResult mResult = e.GrabResult;
                // Check if the image can be displayed.
                if (mResult.IsValid)
                {
                    Log.Warn(mRemark + ":" + "相机采集:回调开始2");
                    // Reduce the number of displayed images to a reasonable amount if the mCamera is acquiring images very fast.
                    if (!mStopwatch.IsRunning || mStopwatch.ElapsedMilliseconds > 33)
                    {
                        mStopwatch.Restart();
                        Bitmap bitmap = new Bitmap(mResult.Width, mResult.Height, PixelFormat.Format32bppRgb);
                        //// Lock the bits of the bitmap.
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        //// Place the pointer to the buffer of the bitmap.
                        //converter.OutputPixelFormat = PixelType.BGRA8packed;
                        IntPtr ptrBmp = bmpData.Scan0;
                        mConverter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, mResult); //Exception handling TODO
                                                                                             //bitmap.UnlockBits(bmpData);
                                                                                             //// EventSaveImageCallBack((Bitmap)bitmap.Clone());
                                                                                             ///
                        try
                        {
                            Image.GenImage1("byte", mResult.Width, mResult.Height, ptrBmp);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(mRemark + ":" + "Basler ImageGrabbed:" + ex.Message);
                        }
                        mWidth = mResult.Width;
                        mHeight = mResult.Height;
                        ImageGrab?.Invoke(Image);
                    }
                }
                Log.Warn(mRemark + ":" + "相机采集:回调结束");
            }
            catch (Exception ex)
            {
                Log.Error(mRemark + ":" + "Basler ImageGrabbed:" + ex.Message);
            }
            finally
            {
                Log.Warn(mRemark + ":" + "相机采集:委托传图");
                //使用委托传递出去
                EventWait.Set();
                GetSignalWait.Set();
                // Dispose the grab result if needed for returning it to the grab loop.
                e.DisposeGrabResultIfClone();
                Log.Warn(mRemark + ":" + "相机采集:异步信号");
            }
        }
        #endregion
        /// <summary>
        /// 开始实时采集
        /// </summary>
        public void StartGrab()
        {
            mCamera.Parameters[PLCamera.AcquisitionMode].SetValue(PLCamera.AcquisitionMode.Continuous);
            mCamera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
        }
        /// <summary>
        /// 停止实时采集
        /// </summary>
        public void StopGrab()
        {
            mCamera.StreamGrabber.Stop();
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            mStopwatch = new Stopwatch();
            mConverter = new PixelDataConverter();
        }
    }
}