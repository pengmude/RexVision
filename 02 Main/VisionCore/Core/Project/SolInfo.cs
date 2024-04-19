using System;
using System.Collections.Generic;
using HalconDotNet;
using System.Drawing;
using System.Runtime.Serialization;
using RexConst;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using RexHelps;
namespace VisionCore
{
    /// <summary>
    /// 自定义结构体
    /// </summary>
    [Serializable]
    public abstract class ROI
    {
        public string sColor { get; set; } = "cyan";
        public abstract HRegion genRegion();
        public abstract HXLDCont genXLD();
        public abstract HTuple getTuple();
    }
    /// <summary>
    /// 直线信息
    /// </summary>
    [Serializable]
    public class Line_Info : ROI, ICloneable
    {
        public bool Status;
        public double StartX;//起点列坐标
        public double StartY;//起点行坐标
        public double EndX;//终点列坐标
        public double EndY; //终点行坐标
        public double MidX;//中间点列坐标
        public double MidY;//中间点行坐标
        public double Phi;//方向
        public double Dist;//距离
        public double Nx;//列向量
        public double Ny;//行向量
        public double[] X;//列向量
        public double[] Y;//行向量
        public Line_Info()
        {
        }
        public Line_Info(double m_start_Row, double m_start_Col, double m_end_Row, double m_end_Col)
        {
            this.StartY = m_start_Row;
            this.StartX = m_start_Col;
            this.EndY = m_end_Row;
            this.EndX = m_end_Col;
            this.Ny = m_start_Col - m_end_Col;
            this.Nx = m_end_Row - m_start_Row;
            this.Dist = m_start_Col * m_end_Row - m_end_Col * m_start_Row;
            Phi = HMisc.AngleLx(StartY, StartX, EndY, EndX);
            MidY = (StartY + EndY) / 2;
            MidX = (StartX + EndX) / 2;
            Status = true;
        }
        public override HRegion genRegion()
        {
            HRegion h = new HRegion();
            h.GenRegionLine(StartY, StartX, EndY, EndX);
            return h;
        }
        public override HXLDCont genXLD()
        {
            HXLDCont xld = new HXLDCont();
            Gen.GenArrow(out xld, StartY, StartX, EndY, EndX, 10, 10);
            return xld;
        }
        public override HTuple getTuple()
        {
            double[] line = new double[] { StartY, StartX, EndY, EndX };
            return new HTuple(line);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    };
    /// <summary>
    /// 面信息
    /// </summary>
    [Serializable]
    public struct Plane_Info
    {
        public double x, y, z;     //The distance from the origin to the centroid, as Measd along the x-axis.
        public double ax, by, cz, d;//Z + A*x + B*y + C =0  z's coefficient is just 1
        public double Angle;
        public double xAn, yAn, zAn;
        public double Flat, MinFlat, MaxFlat;
        public double MinZ, MaxZ;
    };
    [Serializable]
    public struct TagVector
    {
        public double a, b, c;
    };
    /// <summary>
    /// 圆信息
    /// </summary>
    [Serializable]
    public class Circle_Info : ROI, ICloneable
    {
        public bool Status;
        public double CenterY, CenterX, Radius;
        public double StartPhi = 0.0, EndPhi = Math.PI * 2;
        public string PointOrder = "positive";
        public Circle_Info()
        {
        }
        public Circle_Info(double m_Row_center, double m_Col_center, double m_Radius)
        {
            this.CenterY = m_Row_center;
            this.CenterX = m_Col_center;
            this.Radius = m_Radius;
            Status = true;
        }
        public Circle_Info(double m_Row_center, double m_Col_center, double m_Radius, double m_StartPhi, double m_EndPhi, string m_PointOrder)
        {
            this.CenterY = m_Row_center;
            this.CenterX = m_Col_center;
            this.Radius = m_Radius;
            this.StartPhi = m_StartPhi;
            this.EndPhi = m_EndPhi;
        }
        public override HRegion genRegion()
        {
            HRegion h = new HRegion();
            h.GenCircle(CenterY, CenterX, Radius);
            return h;
        }
        public override HXLDCont genXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenCircleContourXld(CenterY, CenterX, Radius, StartPhi, EndPhi, PointOrder, 1.0);
            return xld;
        }
        public override HTuple getTuple()
        {
            double[] circle = new double[] { CenterY, CenterX, Radius };
            return new HTuple(circle);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    /// <summary>
    /// 椭圆信息
    /// </summary>
    [Serializable]
    public class Ellipse_Info : ROI, ICloneable
    {
        public bool Status;
        public double CenterY, CenterX, Phi, Radius1, Radius2;
        double StartPhi = 0.0, EndPhi = Math.PI * 2;
        public string PointOrder = "positive";
        public Ellipse_Info()
        {
        }
        public Ellipse_Info(double m_Row_center, double m_Col_center, double m_Phi, double m_Radius1, double m_Radius2)
        {
            this.CenterY = m_Row_center;
            this.CenterX = m_Col_center;
            this.Phi = m_Phi;
            this.Radius1 = m_Radius1;
            this.Radius2 = m_Radius2;
            Status = true;
        }
        public override HRegion genRegion()
        {
            HRegion h = new HRegion();
            h.GenEllipse(CenterY, CenterX, Phi, Radius1, Radius2);
            return h;
        }
        public override HXLDCont genXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenEllipseContourXld(CenterY, CenterX, Phi, Radius1, Radius2, StartPhi, EndPhi, PointOrder, 1.0);
            return xld;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override HTuple getTuple()
        {
            double[] ellipse = new double[] { CenterY, CenterX, Phi, Radius1, Radius2 };
            return new HTuple(ellipse);
        }
    }
    /// <summary>
    /// 添加自定义形状
    /// </summary>
    [Serializable]
    public class DrawRoi_Info : ROI
    {
        HRegion mHRegion;
        public DrawRoi_Info()
        {
        }
        public DrawRoi_Info(HRegion hregion)
        {
            mHRegion = hregion;
        }
        public override HRegion genRegion()
        {
            return mHRegion;
        }
        public override HXLDCont genXLD()
        {
            if (mHRegion != null && mHRegion.IsInitialized())
            {
                return mHRegion.GenContourRegionXld("border_holes");
            }
            else
            {
                return new HXLDCont();
            }
        }
        public override HTuple getTuple()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// 矩形信息
    /// </summary>
    [Serializable]
    public class Rect_Info : ROI
    {
        public bool Status;
        public double StartY, StartX, EndY, EndX;
        public Rect_Info()
        {
        }
        public Rect_Info(double m_Row_Start, double m_Col_Start, double m_Row_End, double m_Column_End)
        {
            this.StartY = m_Row_Start;
            this.StartX = m_Col_Start;
            this.EndY = m_Row_End;
            this.EndX = m_Column_End;
            Status = true;
        }
        public override HRegion genRegion()
        {
            HRegion h = new HRegion();
            h.GenRectangle1(StartY, StartX, EndY, EndX);
            return h;
        }
        public override HXLDCont genXLD()
        {
            HXLDCont xld = new HXLDCont();
            HTuple row = new HTuple(StartY, EndY, EndY, StartY, StartY);
            HTuple col = new HTuple(StartX, StartX, EndX, EndX, StartX);
            xld.GenContourPolygonXld(row, col);
            return xld;
        }
        public override HTuple getTuple()
        {
            double[] rect1 = new double[] { StartY, StartX, EndY, EndX };
            return new HTuple(rect1);
        }
    }
    /// <summary>
    /// 旋转矩形信息
    /// </summary>
    [Serializable]
    public class Rect2_Info : ROI, ICloneable
    {
        public bool Status;
        public double CenterY;
        public double CenterX;
        public double Phi;
        public double Length1;
        public double Length2;
        public Rect2_Info()
        {
        }
        public Rect2_Info(double m_Row_center, double m_Col_center, double m_Phi, double m_Length1, double m_Length2)
        {
            this.CenterY = m_Row_center;
            this.CenterX = m_Col_center;
            this.Phi = m_Phi;
            this.Length1 = m_Length1;
            this.Length2 = m_Length2;
            Status = true;
        }
        public override HRegion genRegion()
        {
            HRegion h = new HRegion();
            h.GenRectangle2(CenterY, CenterX, Phi, Length1, Length2);
            return h;
        }
        public override HXLDCont genXLD()
        {
            HXLDCont xld = new HXLDCont();
            xld.GenRectangle2ContourXld(CenterY, CenterX, Phi, Length1, Length2);
            return xld;
        }
        public override HTuple getTuple()
        {
            double[] rect2 = new double[] { CenterY, CenterX, Phi, Length1, Length2 };
            return new HTuple(rect2);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    /// <summary>
    /// 3D点数据
    /// </summary>
    [Serializable]
    public struct Point3DF //3D点数据
    {
        public float X;
        public float Y;
        public float Z;
        public Point3DF(float _x, float _y, float _z)
        {
            this.X = _x;
            this.Y = _y;
            this.Z = _z;
        }
    }
    /// <summary>
    /// 矩形阵列返回的信息
    /// </summary>
    [Serializable]
    public struct RectRoiInfo
    {
        public bool Status;
        public double X;//mm坐标
        public double Y;//mm坐标
        public double Value_Avg;///均值
        public double Value_Median;///中指
        public double Value_Max;///最大值
        public double Value_Min;///最小值
        public List<double> X_List;//x mm坐标
        public List<double> Y_List;//y mm坐标
        public List<double> Value_List;
        public RectRoiInfo(double _x, double _y, double _avg, double _median, double _max, double _min, List<double> _xList, List<double> _yList, List<double> _valueList)
        {
            X = _x;
            Y = _y;
            Value_Avg = _avg;
            Value_Median = _median;
            Value_Max = _max;
            Value_Min = _min;
            X_List = _xList;
            Y_List = _yList;
            Value_List = _valueList;
            Status = true;
        }
    }
    /// <summary>
    /// 十字坐标信息
    /// </summary>
    [Serializable]
    public struct Coord_Info
    {
        public bool Status;
        public double Y, X, Phi;
        public Coord_Info(double _row, double _col, double _phi)
        {
            Y = _row;
            X = _col;
            Phi = _phi;//坐标系X轴与图像X轴正方向的夹角
            Status = true;
        }
    }
    /// <summary>
    /// 标定信息
    /// </summary>
    [Serializable]
    public struct Cal_Info
    {
        public bool Status;
        /// <summary>平移X</summary>
        public double ParallelX;
        /// <summary>平移Y</summary>
        public double ParallelY;
        /// <summary>像素当量X</summary>
        public double PixelX;
        /// <summary>像素当量Y</summary>
        public double PixelY;
        /// <summary>旋转角度</summary>
        public double RotationAngle;
        /// <summary>倾斜角度</summary>
        public double TiltAngle;
        /// <summary>RMS平分</summary>
        public double RMS;
        /// <summary>旋转中心X</summary>
        public double RrotationCenterX;
        /// <summary>旋转中心Y</summary>
        public double RrotationCenterY;
        /// <summary>旋转启用</summary>
        public bool RotatingEnabled;
        /// <summary>方向一致</summary>
        public bool SameDirection;
        /// <summary>相机固定</summary>
        public bool CameraFix;
        /// <summary>MarkX</summary>
        public double MarkX;
        /// <summary>MarkY</summary>
        public double MarkY;
        /// <summary>基准X</summary>
        public double BaselineX;
        /// <summary>基准Y</summary>
        public double BaselineY;
        /// <summary>基准角度</summary>
        public double BaselineAngel;
        public string GetName()
        {
            return "ParallelX";
        }
        /// <summary>
        /// 标定信息
        /// 方便流程取数据：平移X,平移Y,像素当量X,像素当量Y,旋转角度,倾斜角度,RMS,旋转中心X,旋转中心Y,旋转启用,方向一致,相机固定,MarkX,MarkY,基准X,基准Y,基准角度 
        /// </summary>
        /// <param name="_ParallelX">平移X</param>
        /// <param name="_ParallelY">平移Y</param>
        /// <param name="_PixelX">像素当量X</param>
        /// <param name="_PixelY">像素当量Y</param>
        /// <param name="_RotationAngle">旋转角度</param>
        /// <param name="_TiltAngle">倾斜角度</param>
        /// <param name="_RMS">RMS平分</param>
        /// <param name="_RrotationCenterX">旋转中心X</param>
        /// <param name="_RrotationCenterY">旋转中心Y</param>
        /// <param name="_RotatingEnabled">旋转启用</param>
        /// <param name="_SameDirection">方向一致</param>
        public Cal_Info(double _ParallelX, double _ParallelY, double _PixelX, double _PixelY, double _RotationAngle, double _TiltAngle, double _RMS, double _RrotationCenterX, double _RrotationCenterY, bool _RotatingEnabled, bool _SameDirection,
            bool _CameraFix, double _MarkX, double _MarkY, double _BaselineX, double _BaselineY, double _BaselineAngel)
        {
            ParallelX = _ParallelX;
            ParallelY = _ParallelY;
            PixelX = _PixelX;
            PixelY = _PixelY;
            RotationAngle = _RotationAngle;
            TiltAngle = _TiltAngle;
            RMS = _RMS;
            RrotationCenterX = _RrotationCenterX;
            RrotationCenterY = _RrotationCenterY;
            RotatingEnabled = _RotatingEnabled;
            SameDirection = _SameDirection;
            CameraFix = _CameraFix;
            MarkX = _MarkX;
            MarkY = _MarkY;
            BaselineX = _BaselineX;
            BaselineY = _BaselineY;
            BaselineAngel = _BaselineAngel;
            Status = true;
        }
    }
    /// <summary>
    /// 测量信息- 长/2,宽/2,阈值,间隔,参数名,参数值,点顺序 (0位默认，1 顺时针，2 逆时针)
    /// </summary>
    [Serializable]
    public struct Meas_Info
    {
        /// <summary>长/2</summary>
        public double Length1;
        /// <summary>宽/2</summary>
        public double Length2;
        /// <summary>阈值</summary>
        public double Threshold;
        /// <summary>间隔</summary>
        public double MeasDis;
        /// <summary>参数名</summary>
        public HTuple ParamName;
        /// <summary>参数值</summary>
        public HTuple ParamValue;
        /// <summary>点顺序 0位默认,1顺时针,2逆时针</summary>
        public int PointsOrder;
        public Meas_Info(double _length1, double _length2, double _threshold, double _MeasDis, HTuple _paraName, HTuple _paraValue, int _pointsOrder)
        {
            Length1 = _length1;
            Length2 = _length2;
            Threshold = _threshold;
            MeasDis = _MeasDis;
            ParamName = _paraName;
            ParamValue = _paraValue;
            PointsOrder = _pointsOrder;
        }
    }
    /// <summary>
    /// 变量数据单元
    /// </summary>
    [Serializable]
    public struct DataCell : ICloneable
    {
        /// <summary>模块名称</summary>
        public string mModName { set; get; }
        /// <summary>单元编号</summary>
        public int mModIndex { set; get; }
        /// <summary>变量分类</summary>
        public DataType mDataType { set; get; }
        /// <summary>变量类型</summary>
        public DataMode mDataMode { set; get; }
        /// <summary>变量名称</summary>
        public string mDataName { set; get; }
        /// <summary>变量注释</summary>
        public string mDataTip { set; get; }
        /// <summary>变量的值</summary>
        public object mDataValue { set; get; }
        /// <summary>变量初值</summary>
        private string mDataInit;
        /// <summary>变量个数</summary>
        private int mDataNum;
        /// <summary>变量属性</summary>
        public DataAtrr mDataAtrr;
        /// <summary>
        /// 数据单元
        /// </summary>
        /// <param name="_ModName">模块名称</param>
        /// <param name="_CellID">单元编号</param>
        /// <param name="_Group">变量类型</param>
        /// <param name="_type">数据类型</param>
        /// <param name="_Name">名称</param>
        /// <param name="_Tip">注释</param>
        /// <param name="_InitValue">初始值</param>
        /// <param name="_Num">数量</param>
        /// <param name="_Value">值</param>
        /// <param name="_Atrr">变量归属</param>
        public DataCell(string _ModName, int _Index, DataType _Type, DataMode _Mode, string _Name, string _Tip, string _InitValue, int _Num, object _Value, DataAtrr _Atrr)
        {
            mModName = _ModName;
            mModIndex = _Index;
            mDataType = _Type;
            mDataMode = _Mode;
            mDataName = _Name;
            mDataTip = _Tip;
            mDataInit = _InitValue;
            mDataNum = _Num;
            mDataValue = _Value;
            mDataAtrr = _Atrr;
        }
        public void InitValue(string mModName, DataMode _DataType, string _InitValue)
        {
            try
            {if (mModName.Equals("全局变量")) return;
                mDataMode = _DataType;
                mDataInit = _InitValue;
                switch (mDataMode)
                {
                    case DataMode.Int:
                        mDataValue = int.Parse(_InitValue);
                        break;
                    case DataMode.Bool:
                        mDataValue = Convert.ToBoolean(_InitValue.ToUpper());
                        break;
                    case DataMode.Double:
                        mDataValue = (double.Parse(_InitValue));
                        break;
                    case DataMode.String:
                        mDataValue = _InitValue;
                        break;
                    case DataMode.点点:
                        mDataValue = new PtoP_Info();
                        break;
                    case DataMode.点2D:
                        mDataValue = new RPoint();
                        break;
                    case DataMode.点3D:
                        mDataValue = new Point3DF();
                        break;
                    case DataMode.矩形阵列:
                        mDataValue = new Rect_Info();
                        break;
                    case DataMode.旋转矩形:
                        mDataValue = new Rect2_Info();
                        break;
                    case DataMode.图像:
                        mDataValue = new RImage();
                        break;
                    case DataMode.椭圆:
                        mDataValue = new Ellipse_Info();
                        break;
                    case DataMode.位置转换2D:
                        mDataValue = new HHomMat2D();
                        break;
                    case DataMode.圆:
                        mDataValue = new Circle_Info();
                        break;
                    case DataMode.直线:
                        mDataValue = new Line_Info();
                        break;
                    case DataMode.坐标系:
                        mDataValue = new Coord_Info();
                        break;
                    case DataMode.平面:
                        mDataValue = new Plane_Info();
                        break;
                    case DataMode.标定信息:
                        mDataValue = new Cal_Info();
                        break;
                    case DataMode.自定义:
                        mDataValue = _InitValue;
                        break;
                    default:
                        RLog.Instance.VTLogError("未处理数据类型 " + mDataMode.ToString() + " 数据信息 ");
                        break;
                }
            }
            catch { }
        }
        /// <summary>
        /// 初始化值
        /// </summary>
        /// <param name="_Mod_Name">模块名称</param>
        /// <param name="_CellID">单元编号</param>
        /// <param name="_Name">变量名称</param>
        /// <param name="_DataType">数据类型</param>
        /// <param name="_InitValue">初始值</param>
        public void InitValue(string _Mod_Name, int _CellID, string _Name, DataMode _DataType, string _InitValue)
        {
            mModIndex = _CellID;
            mDataName = _Name;
            mModName = _Mod_Name;
            InitValue(mModName,_DataType, _InitValue);
        }
        public object GetValue()
        {
            object _value = null;
            if (mDataType == DataType.单量)
            {
                switch (mDataMode)
                {
                    case DataMode.Int:
                        _value = ((List<double>)mDataValue)[0];
                        break;
                    case DataMode.Bool:
                        _value = ((List<bool>)mDataValue)[0];
                        break;
                    case DataMode.Double:
                        mDataValue = new List<double>();
                        break;
                    case DataMode.String:
                        _value = ((List<string>)mDataValue)[0];
                        break;
                    case DataMode.点2D:
                        _value = ((List<RPoint>)mDataValue)[0];
                        break;
                    case DataMode.点3D:
                        _value = ((List<Point3DF>)mDataValue)[0];
                        break;
                    case DataMode.矩形阵列:
                        _value = ((List<Rect_Info>)mDataValue)[0];
                        break;
                    case DataMode.旋转矩形:
                        _value = ((List<Rect2_Info>)mDataValue)[0];
                        break;
                    case DataMode.图像:
                        _value = ((List<RImage>)mDataValue)[0];
                        break;
                    case DataMode.椭圆:
                        _value = ((List<Ellipse_Info>)mDataValue)[0];
                        break;
                    case DataMode.位置转换2D:
                        _value = ((List<HHomMat2D>)mDataValue)[0];
                        break;
                    case DataMode.圆:
                        _value = ((List<Circle_Info>)mDataValue)[0];
                        break;
                    case DataMode.直线:
                        _value = ((List<Line_Info>)mDataValue)[0];
                        break;
                    case DataMode.坐标系:
                        _value = ((List<Coord_Info>)mDataValue)[0];
                        break;
                    case DataMode.平面:
                        _value = ((List<Plane_Info>)mDataValue)[0];
                        break;
                    case DataMode.标定信息:
                        _value = ((List<Cal_Info>)mDataValue)[0];
                        break;
                    default:
                        RLog.Instance.VTLogError("未处理数据类型 " + mDataMode.ToString());
                        break;
                }
            }
            else
            {
                _value = mDataValue;
            }
            return _value;
        }
        public void SetNull(DataMode _DataType)
        {
            switch (mDataMode)
            {
                case DataMode.Int:
                    mDataValue = new List<int>();
                    break;
                case DataMode.Bool:
                    mDataValue = new List<bool>();
                    break;
                case DataMode.Double:
                    mDataValue = new List<double>();
                    break;
                case DataMode.String:
                    mDataValue = new List<string>();
                    break;
                case DataMode.点2D:
                    mDataValue = new List<RPoint>();
                    break;
                case DataMode.点3D:
                    mDataValue = new List<Point3DF>();
                    break;
                case DataMode.矩形阵列:
                    mDataValue = new List<Rect_Info>();
                    break;
                case DataMode.旋转矩形:
                    mDataValue = new List<Rect2_Info>();
                    break;
                case DataMode.图像:
                    mDataValue = new List<RImage>();
                    break;
                case DataMode.椭圆:
                    mDataValue = new List<Ellipse_Info>();
                    break;
                case DataMode.位置转换2D:
                    mDataValue = new List<HHomMat2D>();
                    break;
                case DataMode.圆:
                    mDataValue = new List<Circle_Info>();
                    break;
                case DataMode.直线:
                    mDataValue = new List<Line_Info>();
                    break;
                case DataMode.坐标系:
                    mDataValue = new List<Coord_Info>();
                    break;
                case DataMode.平面:
                    mDataValue = new List<Plane_Info>();
                    break;
                case DataMode.标定信息:
                    mDataValue = new List<Cal_Info>();
                    break;
                default:
                    RLog.Instance.VTLogError("未处理数据类型 " + mDataMode.ToString());
                    break;
            }
        }
        /// <summary>
        /// 根据类型设置值
        /// </summary>
        /// <param name="_DataType">类型</param>
        /// <param name="_value">值不为list</param>
        public void SetValue(DataMode _DataType, object _value)
        {
            if (_value.GetType().Name.Contains("List"))
            {
                mDataValue = _value;
            }
            else
            {
                switch (mDataMode)
                {
                    case DataMode.Int:
                        mDataValue = new List<Double>() { (int)_value };
                        break;
                    case DataMode.Bool:
                        mDataValue = new List<bool>() { (bool)_value };
                        break;
                    case DataMode.Double:
                        mDataValue = new List<Double>() { (double)_value };
                        break;
                    case DataMode.String:
                        mDataValue = new List<string>() { (string)_value };
                        break;
                    case DataMode.点2D:
                        mDataValue = new List<RPoint>() { (RPoint)_value };
                        break;
                    case DataMode.点3D:
                        mDataValue = new List<Point3DF>() { (Point3DF)_value };
                        break;
                    case DataMode.矩形阵列:
                        mDataValue = new List<Rect_Info>() { (Rect_Info)_value };
                        break;
                    case DataMode.旋转矩形:
                        mDataValue = new List<Rect2_Info>() { (Rect2_Info)_value };
                        break;
                    case DataMode.图像:
                        mDataValue = new List<RImage>() { (RImage)_value };
                        break;
                    case DataMode.椭圆:
                        mDataValue = new List<Ellipse_Info>() { (Ellipse_Info)_value };
                        break;
                    case DataMode.位置转换2D:
                        mDataValue = new List<HHomMat2D>() { (HHomMat2D)_value };
                        break;
                    case DataMode.圆:
                        mDataValue = new List<Circle_Info>() { (Circle_Info)_value };
                        break;
                    case DataMode.直线:
                        mDataValue = new List<Line_Info>() { (Line_Info)_value };
                        break;
                    case DataMode.坐标系:
                        mDataValue = new List<Coord_Info>() { (Coord_Info)_value };
                        break;
                    case DataMode.平面:
                        mDataValue = new List<Plane_Info>() { (Plane_Info)_value };
                        break;
                    case DataMode.标定信息:
                        mDataValue = new List<Cal_Info>() { (Cal_Info)_value };
                        break;
                    default:
                        RLog.Instance.VTLogError("未处理数据类型 " + mDataMode.ToString() + " 数据信息 " + _value.GetType().ToString());
                        break;
                }
            }
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            mDataInit = "0";
        }
        [OnDeserialized()]
        internal void OnDeSerializedMethod(StreamingContext context)
        {
            if (mModName != null)
            {
                InitValue(mModName, mDataMode, mDataInit);
            }
        }
        public object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }
    }
    /// <summary>
    /// 测量信息- 长/2,宽/2,阈值,间隔,参数名,参数值,点顺序 (0位默认，1 顺时针，2 逆时针)
    /// </summary>
    [Serializable]
    public class Text_Info
    {
        /// <summary>名称</summary>
        public string Name { set; get; }
        /// <summary>链接</summary>
        public string Likes { set; get; }
        /// <summary>值</summary>
        public string Value { set; get; }
        public Text_Info(string _Name, string _Likes, string _Value)
        {
            Name = _Name;
            Likes = _Likes;
            Value = _Value;
        }
    }
    /// <summary>
    /// 返回信息- 
    /// </summary>
    [Serializable]
    public class Rtn_Info
    {
        public bool Status;
        /// <summary>值</summary>
        public string Value;
        public Rtn_Info() { }
        public Rtn_Info(string _Value)
        {
            Value = _Value;
            Status = true;
        }
    } 
    /// <summary>显示信息- </summary>
    [Serializable]
    public class Set_Info
    {       
        /// <summary>状态</summary>
        public string Status;
        /// <summary>对齐</summary>
        public AlignMode Align;
        /// <summary>位置</summary>
        public int X,Y;
        /// <summary>内容</summary>
        public string Msg;
        /// <summary>前缀</summary>
        public string Prefix;
        /// <summary>后缀</summary>
        public string Suffix;
        /// <summary>OK颜色</summary>
        public Color OK;
        /// <summary>NG颜色</summary>
        public Color NG;
        public Set_Info() { }
        public Set_Info(string _Status,AlignMode _Align, int _X, int _Y,string _Msg, string _Prefix, string _Suffix, Color _OK, Color _NG)
        {
            Status = _Status;
            Align = _Align;
            X = _X;
            Y = _Y;
            Msg = _Msg;
            Prefix = _Prefix;
            Suffix = _Suffix;
            OK = _OK;
            NG = _NG;
        }
    }
    /// <summary>亮度信息- </summary>
    [Serializable]
    public class Luma_Info
    {
        public bool Status;
        /// <summary>面积</summary>
        public double Area;
        /// <summary>平均</summary>
        public double Mean;
        /// <summary>最小</summary>
        public double Min;
        /// <summary>最大</summary>
        public double Max;
        /// <summary>范围</summary>
        public double Range;
        public Luma_Info() { }
        public Luma_Info(double _Area, double _Mean, double _Min, double _Max, double _Range)
        {
            Area = _Area;
            Mean = _Mean;
            Min = _Min;
            Max = _Max;
            Range = _Range;
        }
    }

    
    /// <summary>保存信息- </summary>
    [Serializable]
    public class Save_Info
    {
        /// <summary>索引</summary>
        public int Index { set; get; }
        /// <summary>名称</summary>
        public string Name { set; get; }
        /// <summary>内容</summary>
        public string Msg { set; get; }
        /// <summary>注释</summary>
        public string Remark { set; get; }
        public Save_Info() { }
        public Save_Info(int _Index, string _Name, string _Msg, string _Remark)
        {
            Index = _Index;
            Name = _Name;
            Msg = _Msg;
            Remark = _Remark;
        }
    }
    /// <summary>保存信息- </summary>
    [Serializable]
    public class Char_Info
    {
        public bool Status = false;
        /// <summary>索引</summary>
        public int Index { set; get; }
        /// <summary>名称</summary>
        public string Name { set; get; }
        /// <summary>链接1</summary>
        public string Link1 { set; get; }
        /// <summary>运算符号</summary>
        public string CharType { set; get; }
        /// <summary>链接2</summary>
        public string Link2 { set; get; }

        /// <summary>结果</summary>
        public string Result { set; get; }
        /// <summary>注释</summary>
        public string Remark { set; get; }
        public Char_Info() { }
        public Char_Info(int _Index, string _Name, string _Link1, string _CharType, string _Link2,string _Result,string _Remark)
        {
            Index = _Index;
            Name = _Name;
            Link1 = _Link1;
            CharType = _CharType;
            Link2 =_Link2;
            Result = _Result;
            Remark = _Remark;
        }
    }
    /// <summary>点到点信息保存- </summary>
    [Serializable]
    public class PtoP_Info
    {
        public bool Status = false;
        /// <summary>名称</summary>
        public string Name;
        /// <summary>中心X</summary>
        public double CentreX;
        /// <summary>中心Y</summary>
        public double CentreY;
        /// <summary>角度</summary>
        public double Angle;
        /// <summary>距离</summary>
        public double Dis;
        public PtoP_Info() { }
        /// <summary>
        /// 点到点信息
        /// </summary>
        /// <param name="_Name">名称</param>
        /// <param name="_CentreX">中心X</param>
        /// <param name="_CentreY">中心Y</param>
        /// <param name="_Angle">角度</param>
        /// <param name="_Dis">距离</param>
        public PtoP_Info(string _Name, double _CentreX, double _CentreY, double _Angle, double _Dis)
        {
            Name = _Name;
            CentreX = _CentreX;
            CentreY = _CentreY;
            Angle = _Angle;
            Dis = _Dis;
        }
    }
    /// <summary>
    /// 九点信息
    /// 索引 像素X,Y;机械X,Y
    /// </summary>
    [Serializable]
    public class NPoint
    {
        /// <summary>索引</summary>
        public int Index { set; get; }
        /// <summary>像素X</summary>
        public double ImageX { set; get; }
        /// <summary>像素Y</summary>
        public double ImageY { set; get; }
        /// <summary>机械X</summary>
        public double RobotX { set; get; }
        /// <summary>机械Y</summary>
        public double RobotY { set; get; }
        /// <summary>
        /// 九点信息
        /// 索引 像素X,Y;机械X,Y
        /// </summary>
        public NPoint() { }
        /// <summary>
        /// 九点信息
        /// 索引 像素X,Y;机械X,Y
        /// </summary>
        public NPoint(int _Index,double _ImageX, double _ImageY, double _RobotX,double _RobotY)
        {
            Index = _Index;
            ImageX = _ImageX;
            ImageY = _ImageY;
            RobotX = _RobotX;
            RobotY = _RobotY;
        }
    }
        [Serializable]
    public class RPoint
    {
        public bool Status = false;
        public double X;
        public double Y;
        public double R;
        public double[] X1;
        public double[] Y1;
        public RPoint() { }
        public RPoint(double x, double y,double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }
        public RPoint(double[] x, double[] y)
        {
            this.X1 = x;
            this.Y1 = y;
        }
        /// <summary>重写点</summary>
        public static RPoint operator -(RPoint p1, RPoint p2)
        {
            return new RPoint(p1.X - p2.X, p1.Y - p2.Y, p1.R - p2.R);
        }
        /// <summary>获得点矢量长度</summary>
        public double GetDistance
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public string ToShowTip()
        {
            return X.ToString() + " | " + Y.ToString();
        }
    }
}
