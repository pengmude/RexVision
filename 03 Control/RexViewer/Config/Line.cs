using System;
using System.Xml.Serialization;
namespace RexView
{
    [Serializable]
    public class Line
    {
        [XmlElement(ElementName = "RowBegin")]
        public double RowBegin { get; set; }
        [XmlElement(ElementName = "ColumnBegin")]
        public double ColumnBegin { get; set; }
        [XmlElement(ElementName = "RowEnd")]
        public double RowEnd { get; set; }
        [XmlElement(ElementName = "ColumnEnd")]
        public double ColumnEnd { get; set; }
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";
        /// <summary>
        /// 直线
        /// </summary>
        public Line()
        {
        }
        /// <summary>
        /// 直线
        /// </summary>
        /// <param name="rowBegin">起始X</param>
        /// <param name="columnBegin">起始Y</param>
        /// <param name="rowEnd">结束X</param>
        /// <param name="columnEnd">结束Y</param>
        public Line(double rowBegin, double columnBegin, double rowEnd, double columnEnd)
        {
            RowBegin = rowBegin;
            ColumnBegin = columnBegin;
            RowEnd = rowEnd;
            ColumnEnd = columnEnd;
        }
    }
}
