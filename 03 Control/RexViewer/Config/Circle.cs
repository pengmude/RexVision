using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RexView
{
    [Serializable]
    public class Circle
    {
        [XmlElement(ElementName = "Row")]
        public double Row { get; set; }
        [XmlElement(ElementName = "Column")]
        public double Column { get; set; }
        [XmlElement(ElementName = "Radius")]
        public double Radius { get; set; }
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; } = "yellow";
        public Circle()
        {
        }
        /// <summary>
        /// 圆
        /// </summary>
        /// <param name="row">行</param>
        /// <param name="column">列</param>
        /// <param name="radius">角度</param>
        public Circle(double row, double column, double radius)
        {
            Row = row;
            Column = column;
            Radius = radius;
        }
    }
}
