using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
namespace VisionCore
{
    ///目前的系统的枚举类型
    /// <summary>变量模式</summary>
    public enum DataMode         ///复数全部用list来存储
    {
        自定义,
        点点,                    ///点点信息
        点2D,                    ///2D点
        点3D,                    ///3D点
        直线,                    ///直线
        圆,                      ///圆
        椭圆,                    ///椭圆
        坐标系,                  ///坐标系
        矩形阵列,                ///矩形阵列 rectInfo
        图像,                    ///图像
        标定信息,                ///Calibrate_Info
        平移矩阵,                ///
        旋转矩阵,                ///
        位置转换2D,              ///HHomMat2D
        旋转矩形,                ///旋转矩形    rectangle2_info
        平面,                    ///面
        矩形,                    ///矩形 rectangle_info
        间隙,                    ///间隙
        PLC,
        None,
        Int,
        IntArr,
        Bool,
        BoolArr,
        Double,
        DoubleArr,
        String,
        StringArr
    }
    /// <summary>变量分类</summary>
    public enum DataType
    {
        单量 = 0,
        数组,
    }
    /// <summary>变量归属</summary>
    public enum DataAtrr
    {
        全局变量,              ///全局变量，但无需保存
        系统变量,              ///系统变量，需要保存到本地
        数据队列,
    }
    /// <summary>通过:指定,文件,相机获取图片 </summary>
    public enum ImageSource
    {
        指定图像,
        文件目录,
        相机采集
    } /// <summary>运算符号</summary>
    public enum CharType
    {
        加,
        减,
        乘,
        除
    }
    /// <summary>取值模式</summary>
    public enum ValueMode
    {
        最大值,
        最小值,
        平均值
    }
    /// <summary>提取类型</summary>
    public enum PullType
    {
        全部点位,
        剔除提取
    }
    /// <summary>图片滤波方法</summary>
    public enum FilterMode
    {
        无,
        中值滤波,
        均值滤波,
        高斯滤波,
        平滑滤波
    }
    /// <summary>运行模式</summary>
    [Serializable]
    public enum RunMode
    {
        单次执行,
        循环执行,
        停止执行,
        主动执行
    }
    /// <summary>运行方式</summary>
    [Serializable]
    public enum RunType
    {
        主动执行,
        调用时执行,
        停止时执行,
        加载时执行
    }
    /// <summary>连接模式</summary>
    public enum EnviMode
    {
        联机模式,
        脱机模式
    }
    /// <summary>循环模式</summary>
    public enum ForMode
    {
        递增,
        递减,
        无限
    }
    /// <summary>定位模板类型</summary>
    public enum ModelType
    {
        形状模板,
        灰度模板
    }
    /// <summary>对比极性类型</summary>
    public enum CompType
    {
        [EnumDescription("use_polarity")]
        一致,
        [EnumDescription("ignore_color_polarity")]
        不一致,
        [EnumDescription("ignore_global_polarity")]
        局部一致
    }
    /// <summary>对比极性类型</summary>
    public enum FuncType
    {
        [EnumDescription("=")]
        等于,
        [EnumDescription("!=")]
        不等于,
        [EnumDescription(">")]
        大于,
        [EnumDescription(">=")]
        大于等于,
        [EnumDescription("<")]
        小于,
        [EnumDescription("<=")]
        小于等于,
        [EnumDescription("<")]
        包含,
        [EnumDescription("<=")]
        不包含
    }
    /// <summary>定位模板类型</summary>
    public enum EditType
    {
        正常显示,
        绘制涂抹,
        涂抹清除
    }
    /// <summary>链接类型</summary>
    public enum LinkType
    {
        手动输入,
        链接区域
    }
    /// <summary>排序类型</summary>
    public enum SortType
    {
        分数,
        X,
        Y
    }

    /// <summary>标定模型</summary>
    public enum CalMode
    {
        普通镜头,
        远心镜头
    }
    /// <summary>对齐方式</summary>
    public enum AlignMode
    {
        左边,
        中间,
        右边
    }
    /// <summary>ECom操作：加载，增加，删除</summary>
    public enum EComType
    {
        Add, Load, Remov,Clear
    }
    /// <summary>内部常量定义</summary>
    public static class ConstVar
    {
        #region 单元输出变量 定义和赋值不允许重复
        //图像输出
        public const string Image = "Image";
        public const string ScaleX = "ScaleX";
        public const string ScaleY = "ScaleY";
        public const string Coord = "Coord";
        public const string PointF = "PointF";
        public const string HomMat2D = "HomMat2D";
        public const string Corde2D = "Corde2D";
        public const string BarCorde = "BarCorde";
        public const string ROI = "ROI";
        public const string Result = "Result";
        public const string Rect_Info = "Rect_Info";
        public const string X = "X";
        public const string Y = "Y";
        public const string Row = "Row";
        public const string Col = "Col";
        public const string Row1 = "Row1";
        public const string Col1 = "Col1";
        public const string StartX = "StartX";
        public const string StartY = "StartY";
        public const string EndX = "EndX";
        public const string EndY = "EndY";
        public const string Phi = "Phi";
        public const string MidX = "MidX";
        public const string MidY = "MidY";
        public const string Radius = "Radius";
        public const string Line = "Line";
        public const string Circle = "Circle";
        public const string CircleArr = "CircleArr";
        public const string Ellipse = "Ellipse";
        public const string Rectangle1 = "Rectangle1";
        public const string Rectangle2 = "Rectangle2";
        public const string LineRow = "LineRow";
        public const string LineCol = "LineCol";
        public const string CircleRow = "CircleRow";
        public const string CircleCol = "CircleCol";
        public const string EllipseRow = "EllipseRow";
        public const string EllipseCol = "EllipseCol";
        public const string Flatness1 = "Flatness1";
        public const string Flatness2 = "Flatness2";
        #endregion
    }
    //------1/11 BLG----------------------------------------------
    public enum VarType
    {
        None = -1,
        BoolVar = 0,    //bool
        BoolArray = 1,  //布尔数组
        IntVar = 2,     // int
        IntArray = 3,   //整形数组
        DblVar = 4,     //double
        DblArray = 5,   //浮点数组
        StrVar = 6,     //string
        StrArray = 7,   //字符串组
        ImgVar = 8,     //图像变量
        ImgArray = 9,   //图像数组	
        REGVar = 10,	//区域变量
        REGArray = 11,	//区域数组
        CONVar = 12,	//轮廓变量
        CONArray = 13,	//轮廓数组
        TUPVar = 14,	//数组变量
        TUPArray = 15,	//数组数组
        P2DVar = 16,	//二维点
        P2DArray = 17,	//二维点数组
        P3DVar = 18,	//三维点
        P3DArray = 19,	//三维点数组
    };
    public class VarValue
    {
        public List<string> ValList { get; set; } = new List<string>();
        public string Name { get; set; }
        public VarType Type { get; set; }
        public string NameShow
        {
            get
            {
                return Name;
            }
        }
        public string TypeShow
        {
            get
            {
                switch (Type)
                {
                    case VarType.BoolVar:
                        return "Bool";
                    case VarType.BoolArray:
                        return "Bool[]";
                    case VarType.IntVar:
                        return "Int";
                    case VarType.IntArray:
                        return "Int[]";
                    case VarType.DblVar:
                        return "Double";
                    case VarType.DblArray:
                        return "Double[]";
                    case VarType.StrVar:
                        return "String";
                    case VarType.StrArray:
                        return "String[]";
                    case VarType.ImgVar:
                        return "Image";
                    case VarType.ImgArray:
                        return "Image[]";
                    default:
                        break;
                }
                return "";
            }
        }
        /// <summary>
        /// 将数据转化为本地数据 格式为 变量值1|变量值2
        /// </summary>
        public string ValueAll
        {
            get
            {
                if (ValList.Count == 0)
                {
                    return " ";
                }
                StringBuilder sb = new StringBuilder();
                foreach (string str in ValList)
                {
                    sb.Append(str.Replace("|", "分割符号").Replace(";", "隔离符号"));
                    sb.Append("|");
                }
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1); //删除末尾的 |
                }
                return sb.ToString();
            }
            set
            {
                string st = value;
                string[] strArr = st.Split('|');
                this.ValList.Clear();
                for (int i = 0; i < strArr.Count(); i++)
                {
                    this.ValList.Add(strArr[i]);
                }
            }
        }
        public string ValueShow
        {
            get
            {
                if (ValList.Count == 1)
                {
                    return ValList[0];
                }
                else if (ValList.Count > 1)
                {
                    return $"({ValList[0]},...)[{ValList.Count}]";
                }
                return "";
            }
        }
        public string GetLinkName(string ModName, int index = 0)
        {
            //格式 模块名.变量名
            if (index == 0)
            {
                return $"{ModName}.{Name}";
            }
            else
            {
                return $"{ModName}.{Name}[{index}]";
            }
        }
    }
}
