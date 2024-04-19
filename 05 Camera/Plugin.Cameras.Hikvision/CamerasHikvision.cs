using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ComponentModel;
using VisionCore;
using MvCamCtrl.NET;
using System.Runtime.InteropServices;
using System.IO;

namespace Plugin.Cameras.Hikvision
{
    [Category("Hikvision相机")]
    [DisplayName("Hikvision相机")]
    [Serializable]
    public class CamerasHikvision : CamerasBase
    {
        [NonSerialized]
        private MyCamera mMyCamera = new MyCamera();
        [NonSerialized]
        private MyCamera.MV_CC_DEVICE_INFO CurDevice;
        [NonSerialized]
        private MyCamera.cbOutputExdelegate ImageCallback;
        [NonSerialized]
        private Stopwatch mStopwatch = new Stopwatch();
        public CamerasHikvision() : base(){}
        /// <summary>搜索相机</summary>
        public override List<CamerasInfo> SearchCameras()
        {
            List<CamerasInfo>  mCamInfoList = new List<CamerasInfo>();
            MyCamera.MV_CC_DEVICE_INFO_LIST mDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            if (MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref mDeviceList) != 0)
            {
                MessageBox.Show("查找设备失败");
                return mCamInfoList;
            }
            // ch:在窗体列表中显示设备名 | en:Display device name in the form list
            for (int i = 0; i < mDeviceList.nDeviceNum; i++)
            {
                CamerasInfo _camInfo = new CamerasInfo();
                MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(mDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
                if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
                    MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
                    if (gigeInfo.chUserDefinedName != "")
                    {
                        _camInfo.m_CamName = "Hikvision: " + gigeInfo.chUserDefinedName + " (" + gigeInfo.chSerialNumber + ")";
                    }
                    else
                    {
                        _camInfo.m_CamName = "Hikvision: " + gigeInfo.chManufacturerName + " " + gigeInfo.chModelName + " (" + gigeInfo.chSerialNumber + ")";
                    }
                    _camInfo.m_ExtInfo = device;
                    _camInfo.m_SerialNO = gigeInfo.chSerialNumber;
                    _camInfo.m_MaskName = gigeInfo.chSerialNumber;
                }
                else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stUsb3VInfo, 0);
                    MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_USB3_DEVICE_INFO));
                    if (usbInfo.chUserDefinedName != "")
                    {
                        _camInfo.m_CamName = "Hikvision: " + usbInfo.chUserDefinedName + " (" + usbInfo.chSerialNumber + ")";
                    }
                    else
                    {
                        _camInfo.m_CamName = ("Hikvision: " + usbInfo.chManufacturerName + " " + usbInfo.chModelName + " (" + usbInfo.chSerialNumber + ")");
                    }
                    _camInfo.m_ExtInfo = device;
                    _camInfo.m_SerialNO = usbInfo.chSerialNumber;
                    _camInfo.m_MaskName = usbInfo.chSerialNumber;
                }

                mCamInfoList.Add(_camInfo);
            }
            return mCamInfoList;
        }
        /// <summary>连接相机</summary>
        public override void ConnectDev()
        {
            try
            {
                base.ConnectDev();
                // 如果设备已经连接先断开
                DisConnectDev();
                int nRet = -1;
                // ch:打开设备 | en:Open device
                if (null == mMyCamera)
                {
                    mMyCamera = new MyCamera();
                    if (null == mMyCamera)
                    {
                        return;
                    }
                }
                nRet = mMyCamera.MV_CC_CreateDevice_NET(ref CurDevice);
                if (MyCamera.MV_OK != nRet)
                {
                    return;
                }
                nRet = mMyCamera.MV_CC_OpenDevice_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    mMyCamera.MV_CC_DestroyDevice_NET();
                    ShowErrorMsg("Device open fail!", nRet);
                    Log.Info( "Device open fail!"+nRet.ToString() );
                    return;
                }
                SetSetting();
                // ch:设置采集连续模式 | en:Set Continues Aquisition Mode
                //mMyCamera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);// ch:工作在连续模式 | en:Acquisition On Continuous Mode
                // ch:注册回调函数 | en:Register image callback
                ImageCallback = new MyCamera.cbOutputExdelegate(ImageCallbackFunc);
                nRet = mMyCamera.MV_CC_RegisterImageCallBackEx_NET(ImageCallback, IntPtr.Zero);
                if (MyCamera.MV_OK != nRet)
                {
                    Console.WriteLine("Register image callback failed!");
                }
                // ch:开启抓图 || en: start grab image
                nRet = mMyCamera.MV_CC_StartGrabbing_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    Console.WriteLine("Start grabbing failed:{0:x8}", nRet);
                }
                mConnected = true;
            }
            catch (Exception ex)
            {
                mConnected = false;
            }
        }
        /// <summary>断开相机</summary>
        public override void DisConnectDev()
        {
            if (mConnected)
            {
                int nRet = mMyCamera.MV_CC_CloseDevice_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    return;
                }
                nRet = mMyCamera.MV_CC_DestroyDevice_NET();
                if (MyCamera.MV_OK != nRet)
                {
                    return;
                }
                mConnected = false;
            }
        }
        /// <summary>采集图像</summary>
        /// <param name="byHand">是否手动采图</param>
        public override bool CaptureImage(bool byHand)
        {
            try
            {
                int nRet = 0;
                if (byHand)
                {
                    //获取触发模式和触发源
                    //MyCamera.MVCC_ENUMVALUE stTriggerMode = new MyCamera.MVCC_ENUMVALUE();
                    //MyCamera.MVCC_ENUMVALUE stTriggerSource = new MyCamera.MVCC_ENUMVALUE();
                    //nRet = mMyCamera.MV_CC_GetTriggerMode_NET(ref stTriggerMode);
                    //nRet = mMyCamera.MV_CC_GetTriggerSource_NET(ref stTriggerSource);
                    TrigMode temp = (TrigMode)mTrigMode;
                    //设置内触发
                    SetTriggerMode(TrigMode.软触发);
                    nRet = mMyCamera.MV_CC_SetCommandValue_NET("TriggerSoftware");
                    //恢复旧模式
                    SetTriggerMode(temp);

                }
                else
                {
                    if (mTrigMode ==TrigMode.软触发)
                    {
                        SignalWait.Reset();
                        SignalWait.WaitOne();
                        nRet = mMyCamera.MV_CC_SetCommandValue_NET("TriggerSoftware");
                    }
                }

                if (nRet != MyCamera.MV_OK)
                {
                    ShowErrorMsg("Set CaptureImage Time Fail!", nRet);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        /// <summary>未使用</summary>
        public override void LoadSetting(string filePath)
        {
            if (File.Exists(filePath))
                mMyCamera.MV_CC_FeatureLoad_NET(filePath);
        }
        /// <summary>未使用</summary>
        public override void SaveSetting(string filePath)
        {
            mMyCamera.MV_CC_FeatureSave_NET(filePath);
        }
        /// <summary> 相机设置</summary>
        public override void SetSetting()
        {
            int nRet = 0;
            //设置采集模式
            SetTriggerMode((TrigMode)mTrigMode);
            //设置曝光时间
            nRet = mMyCamera.MV_CC_SetFloatValue_NET("ExposureTime", mExposeTime);
            //置帧率
            nRet = mMyCamera.MV_CC_SetFloatValue_NET("AcquisitionFrameRate", float.Parse(mFramerate));
            //设置ip
            //apiReturn = myApi.Gige_Camera_setIPAddress(m_Handle, uint.Parse(_UniqueLabel), uint.Parse(_DevDirExt));

        }
        public void GetSetting()
        {
            int nRet = 0;
            MyCamera.MVCC_ENUMVALUE stTriggerMode = new MyCamera.MVCC_ENUMVALUE();
            MyCamera.MVCC_ENUMVALUE stTriggerSource = new MyCamera.MVCC_ENUMVALUE();
            MyCamera.MVCC_ENUMVALUE stTriggerActivation = new MyCamera.MVCC_ENUMVALUE();
            nRet = mMyCamera.MV_CC_GetTriggerMode_NET(ref stTriggerMode);
            nRet = mMyCamera.MV_CC_GetTriggerSource_NET(ref stTriggerSource);
            if (stTriggerMode.nCurValue == (uint)TrigMode.内触发)
                mTrigMode = (int)TrigMode.内触发;
            else if (stTriggerSource.nCurValue == 7)//软触发
                mTrigMode = TrigMode.软触发;
            else if (stTriggerSource.nCurValue == 0) //Line0 触发
            {
                nRet += mMyCamera.MV_CC_GetEnumValue_NET("TriggerActivation", ref stTriggerActivation);
                if (stTriggerActivation.nCurValue == 0)
                    mTrigMode = TrigMode.上升沿;
                else
                    mTrigMode = TrigMode.下降沿;
            }

            MyCamera.MVCC_FLOATVALUE stParam = new MyCamera.MVCC_FLOATVALUE();
            nRet = mMyCamera.MV_CC_GetFloatValue_NET("ExposureTime", ref stParam);
            mExposeTime = stParam.fCurValue;
            mMyCamera.MV_CC_GetFloatValue_NET("ResultingFrameRate", ref stParam);
            mFramerate = stParam.fCurValue.ToString();
            //base.GetSetting();
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
                Log.Error("HikVision:" + ex.Message);
            }
        }
        /// <summary>设置宽度</summary>
        public void SetWidth()
        {
            if (mWidth > 100 & mWidth <= mWidthMax)
            {
               
            }
        }
        /// <summary>设置高度</summary>
        public void SetHeight()
        {
            if (mHeight > 100 & mHeight <= mHeightMax)
            {
            
            }
        }
        /// <summary>设置增益 </summary>
        public void SetGain(long value)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                Log.Error("HikVision:"  +ex.Message);
            }
        }
        /// <summary>设置曝光</summary>
        public void SetExposureTime(double dValue)
        {
            mExposeTime = (float)dValue;
            int nRet = mMyCamera.MV_CC_SetFloatValue_NET("ExposureTime", mExposeTime);
            if (nRet != MyCamera.MV_OK)
            {
                Log.Error("HikVision:" +"ExposureTime Err");
            }
        }
        /// <summary>设置触发</summary>
        public override bool SetTriggerMode(TrigMode mode)
        {
            int nRet = 0;
            if (mode == TrigMode.内触发)
                nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 0);
            else
                nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerMode", 1);
            // ch:触发源选择:0 - Line0; | en:Trigger source select:0 - Line0;
            //           1 - Line1;
            //           2 - Line2;
            //           3 - Line3;
            //           4 - Counter;
            //           7 - Software;
            switch (mode)
            {
                case TrigMode.内触发:   // no acquisition
                    break;
                case TrigMode.软触发:   // freerunning
                    {
                        nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerSource", 7);
                        break;
                    }
                case TrigMode.上升沿:   // Software trigger
                    {
                        nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerSource", 0);
                        nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerActivation", 0);
                        break;
                    }
                case TrigMode.下降沿:   // Software trigger
                    {
                        nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerSource", 0);
                        nRet += mMyCamera.MV_CC_SetEnumValue_NET("TriggerActivation", 1);
                        break;
                    }
            }
            if (nRet != MyCamera.MV_OK)
                return false;
            else
                return true;
        }
        #region 相机事件
        /// <summary>采集回调</summary>
        private void ImageCallbackFunc(IntPtr pData, ref MyCamera.MV_FRAME_OUT_INFO_EX pFrameInfo, IntPtr pUser)
        {
            try
            {
                if (pFrameInfo.enPixelType == MyCamera.MvGvspPixelType.PixelType_Gvsp_Mono8)
                {
                    Image.GenImage1("byte", pFrameInfo.nWidth, pFrameInfo.nHeight, pData);
                }
                else
                {
                    Image = new HalconDotNet.HImage("byte", pFrameInfo.nWidth, pFrameInfo.nHeight, pData);
                }
               EventWait.Set();
               ImageGrab?.Invoke(Image);
            }
            catch (Exception ex)
            {
                EventWait.Set();
            }
        }
        /// <summary>断开连接时触发</summary>
        private void OnConnectionLost(object sender, EventArgs e)
        {
            // Close the mMyCamera object.
            DisConnectDev();
        }
        #endregion
        public void FindCBySN(string Ctemp)
        {
            MyCamera.MV_CC_DEVICE_INFO_LIST m_pDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            int nRet;
            // ch:创建设备列表 en:Create Device List
            System.GC.Collect();
            nRet = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref m_pDeviceList);
            if (0 != nRet)
            {
                MessageBox.Show("没有找到任何设备,请确认相机是否连接好");
                return;
            }

            // ch:在窗体列表中显示设备名 | en:Display device name in the form list
            for (int i = 0; i < m_pDeviceList.nDeviceNum; i++)
            {
                MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
                if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
                    MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
                    if (Ctemp == gigeInfo.chSerialNumber)//判断是否等于指定相机序号
                    {
                        CurDevice = device;
                        return;
                    }
                }
                else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
                {
                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stUsb3VInfo, 0);
                    MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_USB3_DEVICE_INFO));
                    if (Ctemp == usbInfo.chSerialNumber)//判断是否等于指定相机序号
                        if (Ctemp == usbInfo.chSerialNumber)//判断是否等于指定相机序号
                        {
                            CurDevice = device;
                            return;
                        }

                }
            }
            MessageBox.Show("没有找当前到设备,请确认相机是否连接好");
            return;
        }

        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            mStopwatch = new Stopwatch();
            mMyCamera = new MyCamera();
            FindCBySN(mSerialNo);
        }
        private void ShowErrorMsg(string csMessage, int nErrorNum)
        {
            string errorMsg;
            if (nErrorNum == 0)
            {
                errorMsg = csMessage;
            }
            else
            {
                errorMsg = csMessage + ": Error =" + String.Format("{0:X}", nErrorNum);
            }

            switch (nErrorNum)
            {
                case MyCamera.MV_E_HANDLE: errorMsg += " Error or invalid handle "; break;
                case MyCamera.MV_E_SUPPORT: errorMsg += " Not supported function "; break;
                case MyCamera.MV_E_BUFOVER: errorMsg += " Cache is full "; break;
                case MyCamera.MV_E_CALLORDER: errorMsg += " Function calling order error "; break;
                case MyCamera.MV_E_PARAMETER: errorMsg += " Incorrect parameter "; break;
                case MyCamera.MV_E_RESOURCE: errorMsg += " Applying resource failed "; break;
                case MyCamera.MV_E_NODATA: errorMsg += " No data "; break;
                case MyCamera.MV_E_PRECONDITION: errorMsg += " Precondition error, or running environment changed "; break;
                case MyCamera.MV_E_VERSION: errorMsg += " Version mismatches "; break;
                case MyCamera.MV_E_NOENOUGH_BUF: errorMsg += " Insufficient memory "; break;
                case MyCamera.MV_E_UNKNOW: errorMsg += " Unknown error "; break;
                case MyCamera.MV_E_GC_GENERIC: errorMsg += " General error "; break;
                case MyCamera.MV_E_GC_ACCESS: errorMsg += " Node accessing condition error "; break;
                case MyCamera.MV_E_ACCESS_DENIED: errorMsg += " No permission "; break;
                case MyCamera.MV_E_BUSY: errorMsg += " Device is busy, or network disconnected "; break;
                case MyCamera.MV_E_NETER: errorMsg += " Network error "; break;
            }
            Log.Error("HikVision:" + errorMsg);
        }
    }
}