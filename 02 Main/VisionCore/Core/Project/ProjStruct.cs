using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
namespace VisionCore
{
    /// <summary>
    /// 插件信息 
    /// </summary>
    [Serializable]
    public class PluginsInfo
    {
        /// <summary>处理类</summary>
        public Type ModObjType { get; set; }
        /// <summary>UI类</summary>
        public Type ModFormType { get; set; }
        /// <summary>插件名称</summary>
        public string Name { get; set; }
        /// <summary>子类</summary>
        public string Category { get; set; }
        /// <summary>图标</summary>
        public Icon IconImage { get; set; }
    }
    /// <summary>
    /// 模块信息
    /// </summary>
    [Serializable]
    public class ModInfo
    {
        ///<summary>插件名称+模块编号</summary>
        public string Name { get; set; } = "";
        /// <summary>流程索引</summary>
        public int Index { get; set; } = -1;
        /// <summary> 模块注释 </summary>
        public string Remarks { get; set; } = "";      
        /// <summary> 模块编号  </summary>
        public int Encode { get; set; } = 0;                 
        /// <summary> 插件名称（唯一）	 </summary>
        public string Plugin { get; set; } = "";
        /// <summary>跳转标签</summary>
        public string GoLable { get; set; } = "None";
        /// <summary> 模块运行时间ms </summary>
        public double CostTime { get; set; } = 0;
        /// <summary> 是否启用 </summary>
        public bool Enable { get; set; } = true;
        /// <summary>测试结果</summary>
        public bool Result { get; set; } = true;
        /// <summary> 模块运行状态</summary>
        public ModState State { get; set; } = ModState.Start;    //模块运行状态
    }
    /// <summary>模块运行状态</summary>
    public enum ModState
    {
        /// <summary>未运行</summary>
        None = -1,
        /// <summary>执行OK</summary>
        OK,
        /// <summary>执行异常</summary>
        NG,
        /// <summary>开始运行</summary>
        Start,
        /// <summary>无图像</summary>
        NoImage
    }
    /// <summary>
    /// 回调返回的状态封装
    /// </summary>
    [Serializable]
    public struct ModStateInfo
    {
        /// <summary>流程编号</summary>
        public int ProjIndex;
        /// <summary>模块编号</summary>
        public int ModtIndex;
        /// <summary>模块状态</summary>
        public RunMode ModState;
        /// <summary>回调返回的状态封装</summary>
        /// <param name="_ProjIndex">流程ID</param>
        /// <param name="_ModtIndex">模块编号</param>
        /// <param name="_ModState">模块状态</param>
        public ModStateInfo(int _ProjIndex, int _ModtIndex, int _ModState)
        {
            ProjIndex = _ProjIndex;
            ModtIndex = _ModtIndex;
            ModState = (RunMode)_ModState;
        }
    }
    /// <summary>
    /// 流程信息
    /// </summary>
    [Serializable]
    public class ProjInfo
    {       
        /// <summary>项目名称 </summary>
        public string Name { get; set; }
        /// <summary>项目索引</summary>
        public int Index { get; set; }
        /// <summary>执行时间 </summary>
        public double CostTime { get; set; }   
        /// <summary>拷贝</summary>
        public ProjInfo Clone()
        {
            return CloneObject.DeepCopy(this);
        }
    }
}