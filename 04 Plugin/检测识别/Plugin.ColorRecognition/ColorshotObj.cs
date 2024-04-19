using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;


using RexConst;

namespace Plugin.Colorshot
{
    [Category("检测识别")]
    [DisplayName("颜色识别")]
    [Serializable]
    public class ColorshotObj : ObjBase
    {
        /// <summary>
        /// 阵列列表
        /// </summary>
        public List<Rect2_Info> m_Rectangle2List = new List<Rect2_Info>();
        /// <summary>
        /// 是否阵列
        /// </summary>
        public bool m_cbarray = false;
        /// <summary>
        /// 阵列的行
        /// </summary>
        public int m_arrayRow = 1;
        /// <summary>
        /// 阵列的列
        /// </summary>
        public int m_arrayCol = 1;
        /// <summary>
        /// 阵列行间距
        /// </summary>
        public double m_arrayStepX = 1;
        /// <summary>
        /// 阵列列间距
        /// </summary>
        public double m_arrayStepY = 1;
        /// <summary>
        /// 模板角度范围- 
        /// </summary>
        public double m_StartPhi = -180f;
        /// <summary>
        /// 模板角度范围+
        /// </summary>
        public double m_EndPhi = 180f;
        /// <summary>
        /// 最小缩放比率
        /// </summary>
        public double m_ScaleMin = 0.9;
        /// <summary>
        /// 最大缩放比率
        /// </summary>
        public double m_ScaleMax = 1.1;
        /// <summary>
        /// 最小分数
        /// </summary>
        public double m_MinScore = 0.5;
        /// <summary>
        /// 匹配数量
        /// </summary>
        public int m_MatchNum = 1;
        /// <summary>
        /// 最大重叠
        /// </summary>
        public double m_MaxOverlap = 0.5;
        /// <summary>
        /// 亚像素模式
        /// </summary>
        public string m_SubPixel = "least_squares";
        /// <summary>
        /// 金字塔等级
        /// </summary>
        public int m_NumLevels = 0;
        /// <summary>
        /// 贪心算法
        /// </summary>
        public double m_Greediness = 0.9;
        /// <summary>
        /// 模板类型
        /// </summary>
        public ModelType m_ModelType;
        /// <summary>
        /// 模板
        /// </summary>
        public HHandle m_Model;
        /// <summary>
        /// 当前图像名称
        /// </summary>
        public string mImages = string.Empty;
        /// <summary>
        /// 阵列模板区域
        /// </summary>
        public ROI m_ArrayRegionA;
        public ROI m_ArrayRegionB;
        public double m_ArrayRegionSpaceX;
        public double m_ArrayRegionSpaceY;
        /// <summary>
        /// 屏蔽区域
        /// </summary>
        public ROI m_DisableRegion;
        /// <summary>
        /// 模板区域
        /// </summary>
        public ROI m_ModelRegion;
        public double m_ModelRegionSpaceX;
        public double m_ModelRegionSpaceY;
        /// <summary>
        /// 搜索区域
        /// </summary>
        public ROI m_SearchRegion;
        /// <summary>
        /// 注册模板位置信息 像素坐标
        /// </summary>
        public Coord_Info m_PositionInfo = new Coord_Info();
        /// <summary>
        /// 结果区域框显示
        /// </summary>
        public bool m_RegionFor = false;
        /// <summary>
        /// 是否屏蔽角度,如果屏蔽,则角度返回的是0 magical 20171012
        /// </summary>
        public bool disableAngle = false;
        /// <summary>
        /// 模板图像
        /// </summary>
        public RImage ImageMod;
        /// <summary>
        /// 生成模板
        /// </summary>
        public void CreateModel()
        {
            if ((ImageMod=mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
            {
                ModInfo.State = ModState.NoImage;
                return ;
            }
        }
        public override bool RunObj()
        {
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                //SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, ModInfo.Encode, DataType.数组, DataMode.Double, ConstVar.Coord, ModInfo.Plugin, "0", 1, list, DataAtrr.全局变量));
                ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            return true;
        }
        public override void RunForm(ObjBase baseMod)
        {
           new ColorshotForm((ColorshotObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
        }
    }
}
