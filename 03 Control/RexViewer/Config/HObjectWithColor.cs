using HalconDotNet;
namespace RexView
{
    /// <summary>
    /// 显示xld和region 带有颜色
    /// </summary>
    class HObjectWithColor
    {
        public string Color { get; set; }
        public HObject HObject { get; set; }
        /// <summary>
        /// HObject
        /// </summary>
        /// <param name="_hbj">类型</param>
        /// <param name="_color">颜色</param>
        public HObjectWithColor(HObject _hbj, string _color)
        {
            HObject = _hbj;
            Color = _color;
        }
    }
}
