using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Rectangle2
    {
        [XmlElement(ElementName = "Row")]
        public double Row { get; set; }
        [XmlElement(ElementName = "Column")]
        public double Column { get; set; }
        [XmlElement(ElementName = "Phi")]
        public double Phi { get; set; }
        [XmlElement(ElementName = "Lenth1")]
        public double Lenth1 { get; set; }
        [XmlElement(ElementName = "Lenth2")]
        public double Lenth2 { get; set; }
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";
        public Rectangle2()
        {
        }
        /// <summary>
        /// 旋转矩形
        /// </summary>
        /// <param name="row">起始X</param>
        /// <param name="column">起始Y</param>
        /// <param name="phi">角度</param>
        /// <param name="lenth1">长</param>
        /// <param name="lenth2">宽</param>
        public Rectangle2(double row, double column, double phi, double lenth1, double lenth2)
        {
            Row = row;
            Column = column;
            Phi = phi;
            Lenth1 = lenth1;
            Lenth2 = lenth2;
        }
    }
}
