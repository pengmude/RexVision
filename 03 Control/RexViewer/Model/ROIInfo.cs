using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using HalconDotNet;

namespace RexView
{
    public class ROIInfo
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Rectangle1 Rectangle1 { get; set; }
        public Rectangle2 Rectangle2 { get; set; }
        public Circle Circle { get; set; }
        public Line Line { get; set; }
        public CoordLine CoordLine { get; set; }
        protected internal ROIInfo()
        {
        }
        protected internal ROIInfo(string id, ROI roi)
        {
            this.ID = id;
            HTuple m_roiData = null;

            m_roiData = roi.GetModelData();

            switch (roi.Type)
            {
                case ROIType.Rectangle1:
                    this.Name = "Rectangle1";

                    if (m_roiData != null)
                    {
                        this.Rectangle1 = new Rectangle1(m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        this.Rectangle1.Color = roi.Color;
                    }
                    break;
                case ROIType.Rectangle2:
                    this.Name = "Rectangle2";

                    if (m_roiData != null)
                    {
                        this.Rectangle2 = new Rectangle2(m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D, m_roiData[4].D);
                        this.Rectangle2.Color = roi.Color;
                    }
                    break;
                case ROIType.Circle:
                    this.Name = "Circle";

                    if (m_roiData != null)
                    {
                        this.Circle = new Circle(m_roiData[0].D, m_roiData[1].D, m_roiData[2].D);
                        this.Circle.Color = roi.Color;
                    }
                    break;
                case ROIType.Line:
                    this.Name = "Line";

                    if (m_roiData != null)
                    {
                        this.Line = new Line(m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        this.Line.Color = roi.Color;
                    }
                    break;
                case ROIType.CoordLine:
                    this.Name = "CoordLine";

                    if (m_roiData != null)
                    {
                        this.CoordLine = new CoordLine(m_roiData[0].D, m_roiData[1].D, m_roiData[2].D, m_roiData[3].D);
                        this.CoordLine.Color = roi.Color;
                    }
                    break;
                default:
                    break;
            }
        }
        protected internal ROIInfo(string id, Rectangle1 rectangle1)
        {
            this.ID = id;
            this.Name = "Rectangle1";
            this.Rectangle1 = rectangle1;
        }
        protected internal ROIInfo(string id, Rectangle2 rectangle2)
        {
            this.ID = id;
            this.Name = "Rectangle2";
            this.Rectangle2 = rectangle2;
        }
        protected internal ROIInfo(string id, Circle circle)
        {
            this.ID = id;
            this.Name = "Circle";
            this.Circle = circle;
        }
        protected internal ROIInfo(string id, Line line)
        {
            this.ID = id;
            this.Name = "Line";
            this.Line = line;
        }
        protected internal ROIInfo(string id, CoordLine coordline)
        {
            this.ID = id;
            this.Name = "CoordLine";
            this.CoordLine = coordline;
        }
    }
    [Serializable]
    public enum ROIType
    {
        /// <summary>
        /// 直线
        /// </summary>
        Line = 10,
        /// <summary>
        /// 圆
        /// </summary>
        Circle,
        /// <summary>
        /// 圆弧
        /// </summary>
        CircleArc,
        /// <summary>
        /// 矩形
        /// </summary>
        Rectangle1,
        /// <summary>
        /// 带角度矩形
        /// </summary>
        Rectangle2,
        /// <summary>
        /// 坐标中心
        /// </summary>
        CoordLine,
        /// <summary>
        /// 坐标中心
        /// </summary>
        Point,
    }
    [Serializable]
    public enum ROIDefine
    {
        /// <summary>
        /// 空
        /// </summary>
        None,
        /// <summary>
        /// 输入
        /// </summary>
        Int,
        /// <summary>
        /// 输出
        /// </summary>
        Out,
        /// <summary>
        /// 变换
        /// </summary>
        Affine,
        /// <summary>
        /// 搜索区域
        /// </summary>
        Search,
        /// <summary>
        /// 模板区域
        /// </summary>
        Templet,
        /// <summary>
        /// 屏蔽区域
        /// </summary>
        Disable,
        /// <summary>
        /// 直线
        /// </summary>
        Line,
        /// <summary>
        /// 圆
        /// </summary>
        Circle,
        /// <summary>
        /// 圆弧
        /// </summary>
        CircleArc,
        /// <summary>
        /// 矩形
        /// </summary>
        Rectangle1,
        /// <summary>
        /// 带角度矩形
        /// </summary>
        Rectangle2
    }
    /// <summary>
    /// ROI运算
    /// </summary>
    public enum ROIOperation
    {
        /// <summary>
        /// ROI求和模式
        /// </summary>
        Positive = 21,
        /// <summary>
        /// ROI求差模式
        /// </summary>
        Negative,
        /// <summary>
        /// ROI模式为无
        /// </summary>
        None
    }
    public enum ViewMessage
    {
        /// <summary>Constant describing an update of the model region</summary>
        UpdateROI = 50,

        ChangedROISign,

        /// <summary>Constant describing an update of the model region</summary>
        MovingROI,
        DeletedActROI,
        DelectedAllROIs,

        ActivatedROI,

        MouseMove,
        CreatedROI,
        /// <summary>
        /// Constant describes delegate message to signal new image
        /// </summary>
        UpdateImage,
        /// <summary>
        /// Constant describes delegate message to signal error
        /// when reading an image from file
        /// </summary>
        ErrReadingImage,
        /// <summary> 
        /// Constant describes delegate message to signal error
        /// when defining a graphical context
        /// </summary>
        ErrDefiningGC
    }
    public enum ShowMode
    {
        /// <summary>
        /// 包含ROI显示
        /// </summary>
        IncludeROI = 1,
        /// <summary>
        /// 不包含ROI显示
        /// </summary>
        ExcludeROI
    }
}
