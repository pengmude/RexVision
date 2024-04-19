using HalconDotNet;
using System;
using System.Runtime.Serialization;
namespace RexConst
{
    /// <summary>
    /// 用于展示效果的HObject
    /// </summary>
    [Serializable]
    public class HRoi
    {
        /// <summary>单元id</summary>
        public int CellID { get; set; }
        /// <summary>单元类型</summary>
        public string CellType { get; set; }
        /// <summary>单元描述</summary>
        public string CellNote { get; set; }
        /// <summary>轮廓分类</summary>
        public HRoiType roiType { get; set; }
        /// <summary>画笔颜色</summary>
        public string drawColor { get; set; }
        /// <summary>测量roi</summary>
        public HObject hobject { get; set; }
        /// <summary>循环+</summary>
        public bool fors { get; set; }
        /// <summary>测量roi</summary>
        public HRoi() { }
        /// <summary>测量roi</summary>
        /// <param name="_CellID">单元id</param>
        /// <param name="_CellType">单元类型</param>
        /// <param name="_CellNote">单元描述</param>
        /// <param name="_drawColor">画笔颜色</param>
        /// <param name="_hobject">测量roi 必须为HObject类型</param>
        public HRoi(int _CellID, string _CellType, string _CellNote, HRoiType _roiType, string _drawColor, HObject _hobject)
        {
            CellID = _CellID;
            CellType = _CellType;
            CellNote = _CellNote;
            roiType = _roiType;
            drawColor = _drawColor;
            hobject = _hobject;
        }
        /// <summary>
        /// 测量roi
        /// </summary>
        /// <param name="_CellID">单元id</param>
        /// <param name="_CellType">单元类型</param>
        /// <param name="_CellNote">单元描述</param>
        /// <param name="_roiType">Roi类型</param>
        /// <param name="_drawColor">画笔颜色</param>
        /// <param name="_hobject">测量roi 必须为HObject类型</param>
        /// <param name="_for">是否循环+</param>
        public HRoi(int _CellID, string _CellType, string _CellNote, HRoiType _roiType, string _drawColor, HObject _hobject, bool _for)
        {
            CellID = _CellID;
            CellType = _CellType;
            CellNote = _CellNote;
            roiType = _roiType;
            drawColor = _drawColor;
            hobject = _hobject;
            fors = _for;
        }
        /// <summary>
        /// 测量roi
        /// </summary>
        /// <param name="_CellID">单元id</param>
        /// <param name="_CellType">单元类型</param>
        /// <param name="_CellNote">单元描述</param>
        /// <param name="_drawColor">画笔颜色</param>
        /// <param name="_hobject">测量roi 必须为HObject类型</param>
        public HRoi(int _CellID, string _CellType, string _CellNote, HRoiType _roiType, string _drawColor, HObject[] _hobject)
        {
            int i = 0;
            CellID = _CellID;
            CellType = _CellType;
            CellNote = _CellNote;
            roiType = _roiType;
            drawColor = _drawColor;
            hobject = _hobject[i];
        }
        [OnSerializing]
        internal void OnSerializingMethod(StreamingContext context)
        {
            if (hobject != null && !hobject.IsInitialized())//修复为null 错误 magical 20171103
            {
                hobject = null;
            }
        }
    }
    [Serializable]
    public class HText : HRoi
    {
        /// <summary>文字</summary>
        public string text { get; set; }
        /// <summary>字体</summary>
        public string font = "mono";
        /// <summary>显示的位置-X</summary>
        public double row { get; set; }
        /// <summary>显示的位置-Y</summary>
        public double col { get; set; }
        /// <summary>大小</summary>
        public int size { get; set; }
        /// <summary>角度</summary>
        public int phi { get; set; }
        public HText(string _drawColor, string _text, string _font, double _row, double _col, int _size)
        {
            drawColor = _drawColor;
            text = _text;
            font = _font;
            row = _row;
            col = _col;
            size = _size;
        }
        /// <summary>
        /// 测量roi
        /// </summary>
        /// <param name="_CellID">单元id</param>
        /// <param name="_CellType">单元类型</param>
        /// <param name="_CellNote">单元描述</param>
        /// <param name="_roiType">ROI类型</param>
        /// <param name="_drawColor">画笔颜色</param>
        /// <param name="_text">文本内容</param>
        /// <param name="_font">字体</param>
        /// <param name="_row">行</param>
        /// <param name="_col">列</param>
        /// <param name="_size">大小</param>
        /// <param name="_hobject">测量roi 必须为HObject类型</param>
        public HText(int _CellID, string _CellType, string _CellNote, HRoiType _roiType, string _drawColor,string _text, string _font, double _row, double _col, int _size, HObject _hobject)
        {
            CellID = _CellID;
            CellType = _CellType;
            CellNote = _CellNote;
            roiType = _roiType;
            drawColor = _drawColor;
            text = _text;
            font = _font;
            row = _row;
            col = _col;
            size = _size;
            hobject = _hobject;
        }
        /// <summary>
        /// 测量roi
        /// </summary>
        /// <param name="_CellID">单元id</param>
        /// <param name="_CellType">单元类型</param>
        /// <param name="_CellNote">单元描述</param>
        /// <param name="_roiType">ROI类型</param>
        /// <param name="_drawColor">画笔颜色</param>
        /// <param name="_text">文本内容</param>
        /// <param name="_font">字体</param>
        /// <param name="_row">行</param>
        /// <param name="_col">列</param>
        /// <param name="_size">大小</param>
        /// <param name="_hobject">测量roi 必须为HObject类型</param>
        /// <param name="_size">循环+</param>
        public HText(int _CellID, string _CellType, string _CellNote, HRoiType _roiType, string _drawColor,string _text, string _font, double _row, double _col, int _size, HObject _hobject, bool _for)
        {
            CellID = _CellID;
            CellType = _CellType;
            CellNote = _CellNote;
            roiType = _roiType;
            drawColor = _drawColor;
            text = _text;
            font = _font;
            row = _row;
            col = _col;
            size = _size;
            hobject = _hobject;
            fors = _for;
        }
    }
    /// <summary>
    /// 轮廓分类
    /// </summary>
    public enum HRoiType
    {
        检测点,
        检测X点,
        检测Y点,
        检测点P1,
        检测点P2,
        检测范围,
        检测中心,
        检测结果,
        搜索范围,
        搜索方向,
        屏蔽范围,
        文字显示,
        参考坐标,
    }
}
