using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VisionCore
{
    /// <summary>
    /// 相机信息
    /// </summary>
    [Serializable]
    public struct CamerasInfo
    {
        /// <summary>扩展信息 </summary>
        public object m_ExtInfo;
        /// <summary>相机名称 </summary>
        public string m_CamName { set; get; }
        /// <summary>相机编号 </summary>
        public string m_SerialNO { set; get; }
        /// <summary>相机IP </summary>
        public string m_CameraIP { set; get; }
        /// <summary>相机备注 </summary>
        public string m_MaskName { set; get; }
        /// <summary>相机链接 </summary>
        public bool m_Connected { set; get; }
    }
    /// <summary>
    /// 触发模式
    /// </summary>
    [Serializable]
    public enum TrigMode
    {
        内触发 = 0,
        软触发,
        上升沿,
        下降沿
    }
    /// <summary>
    /// 曝光模式
    /// </summary>
    [Serializable]
    public enum ExposureMode
    {
        内曝光 = 0, //内部设置曝光时间
        外曝光,    //电平信号设置曝光时间
    }
    /// <summary>
    /// 触发模式
    /// </summary>
    [Serializable]
    public enum ChangType
    {
        曝光,
        触发,
        宽度,
        高度,
        增益
    }
    /// <summary>
    /// 调整模式
    /// </summary>
    [Serializable]
    public enum ImageAdjust
    {
        None = 0,
        垂直镜像,
        水平镜像,
        顺时针90度,
        逆时针90度,
        旋转180度
    }
}
