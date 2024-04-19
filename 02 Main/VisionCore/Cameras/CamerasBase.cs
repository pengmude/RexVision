using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;
using System.Threading;
using System.Runtime.Serialization;
using System.Windows.Forms;
using RexConst;
namespace VisionCore
{
    public delegate void ImageGrabcallback(HImage img);
    [Serializable]
    public class CamerasBase
    {
        #region 属性
        /// <summary>回调事件 </summary>
        [NonSerialized]
        public ImageGrabcallback ImageGrab = null;
        /// <summary>采集图像 </summary>
        [NonSerialized]
        public HImage Image = new RImage();
        /// <summary>采集信号 </summary>
        [NonSerialized]
        public AutoResetEvent EventWait = new AutoResetEvent(false);
        /// <summary>软触发时收到图像信号-同步</summary>
        [NonSerialized]
        public AutoResetEvent SignalWait = new AutoResetEvent(false);
        /// <summary>软触发时收到图像信号-异步</summary>
        [NonSerialized]
        public AutoResetEvent GetSignalWait = new AutoResetEvent(false);
        /// <summary>触发模式 </summary>
        public TrigMode mTrigMode = TrigMode.内触发;
        /// <summary>最新编号 </summary>
        public static  int mLastNo = 0;
        /// <summary>设备自己编号 </summary>
        public string mCameraNo { set; get; }
        /// <summary>设备内部编号</summary>
        public string mSerialNo { set; get; }
        /// <summary>设备内部IP</summary>
        public string mCameraIP { set; get; }
        /// <summary>备注</summary>
        public string mRemark { get; set; }
        /// <summary>初始连接状态</summary>
        public bool mConnected { set; get; } = false;
        /// <summary>最大高度</summary>
        public int mWidthMax { set; get; } = 0;
        /// <summary>最大高度 </summary>
        public int mHeightMax { set; get; } = 0;
        /// <summary>曝光 </summary>
        public float mExposeTime { set; get; } = 0;
        public float mExposeTimeMax { set; get; } = 0;
        public float mExposeTimeMin{ set; get; } = 0;
        /// <summary>宽度</summary>
        public int mWidth { set; get; } = 0;
        /// <summary>高度</summary>
        public int mHeight { set; get; } = 0;
        /// <summary>增益</summary>
        public float mGain { set; get; } = 0;
        public float mGainMax { set; get; } = 0;
        public float mGainMin { set; get; } = 0;
        /// <summary>帧率 </summary>
        public string mFramerate { set; get; } = "0";
        #endregion
        #region 构造函数
        /// <summary> 创建相机实体</summary>
        public CamerasBase() { }
        public CamerasBase(string _SerialNo)
        {
            mLastNo++;
            mCameraNo = "Dev" + mLastNo;
        }
        #endregion
        #region 虚函数
        /// <summary> 搜索相机</summary>    
        public virtual List<CamerasInfo> SearchCameras() { return null; }
        /// <summary> 建立连接</summary>
        public virtual void ConnectDev()
        {
            LoadSetting(Application.StartupPath + @"\CameraConfig" + this.mSerialNo);
        }
        /// <summary> 断开连接</summary>
        public virtual void DisConnectDev() { }
        /// <summary>抓捕图像</summary>
        /// <param name="byHand">是否手动采图</param>
        public virtual bool CaptureImage(bool byHand) { return true; }
        /// <summary> 导出设置</summary>
        public virtual void SaveSetting(string filePath) { }
        /// <summary> 导入设置</summary>
        public virtual void LoadSetting(string filePath) { }
        /// <summary> 相机设置</summary>
        public virtual void SetSetting() { }
        /// <summary>设置触发模式 </summary>
        public virtual bool SetTriggerMode(TrigMode mode)
        {
            return true;
        }
        /// <summary>参数设置</summary>
        public virtual void CameraChanged(ChangType changTyp){}
        #endregion
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            SignalWait = new AutoResetEvent(false);//采集信号
            GetSignalWait = new AutoResetEvent(false);//软触收到图像信号
        }
    }
}
