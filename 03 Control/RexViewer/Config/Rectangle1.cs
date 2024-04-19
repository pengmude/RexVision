using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Rectangle1
    {
        [XmlElement(ElementName = "Row1")]
        public double Row1 { get; set; }
        [XmlElement(ElementName = "Column1")]
        public double Column1 { get; set; }
        [XmlElement(ElementName = "Row2")]
        public double Row2 { get; set; }
        [XmlElement(ElementName = "Column2")]
        public double Column2 { get; set; }
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";
        public Rectangle1()
        {
        }
        /// <summary>
        /// 矩形
        /// </summary>
        /// <param name="row1">起始X</param>
        /// <param name="column1">起始Y</param>
        /// <param name="row2">结束X</param>
        /// <param name="column2">结束Y</param>
        public Rectangle1(double row1, double column1, double row2, double column2)
        {
           Row1 = row1;
           Column1 = column1;
           Row2 = row2;
           Column2 = column2;
        }

    }
}
