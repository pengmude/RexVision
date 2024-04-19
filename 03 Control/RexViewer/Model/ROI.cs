using System;
using HalconDotNet;

namespace RexView
{
    /// <summary>
    ///这个类是一个基类，包含用于处理的虚拟方法
    ///ROI因此，继承类需要定义/重写这些
    ///为ROIController提供必要信息的方法
    ///它(= ROIs)的形状和位置。示例项目提供
    ///导出矩形、直线、圆和圆弧的ROI形状。
    ///要使用其他形状，必须从基类派生一个新类
    ///实现它的方法。
    /// </summary>    
    [Serializable]
    public class ROI
    {  
        /// <summary> 要显示roi的图像宽度</summary>
        private int ImageWidth;
        /// <summary> 要显示roi的图像宽度</summary>
        private int ImageHight;
        /// <summary>ROI颜色 </summary>
        public string Color = "cyan";
        /// <summary> ROI类型</summary>
        public ROIType Type;
        /// <summary>继承ROI类的类成员 </summary>
        protected int NumHandles;
        /// <summary>激活ID</summary>
        protected int ActiveHandleId;
        /// <summary>参数来定义ROI的线条样式。</summary>
        public HTuple FlagLineStyle;
        /// <summary>常数为负ROI标志。+</summary>
        public const int POSITIVE_FLAG = HWndCtrl.MODE_ROI_POS;
        /// <summary>常数为负ROI标志。-</summary>
        public const int NEGATIVE_FLAG = HWndCtrl.MODE_ROI_NEG;
        /// <summary> 标记定义ROI为“正”或“负”。. </summary>
        protected int OperatorFlag;
        /// <summary> "+"方式直接直线 </summary>
        protected HTuple posOperation = new HTuple();
        /// <summary> "-"方式的虚线/// </summary>
        protected HTuple negOperation = new HTuple(new int[] { 2, 2 });
        /// <summary>抽象ROI类的构造函数。</summary>
        public ROI() { }
        public virtual void CreateLine(double beginRow, double beginCol, double endRow, double endCol) { }
        public virtual void CreateCoordLine(double beginRow, double beginCol, double endRow, double endCol) { }
        public virtual void CreateCircle(double row, double col, double radius) { }
        public virtual void CreateCircleAre(double row, double col, double radius) { }
        public virtual void CreateRectangle1(double row1, double col1, double row2, double col2) { }
        public virtual void CreateRectangle2(double row, double col, double phi, double length1, double length2) { }
        public virtual void CreatePoint(double row, double col) { }
        /// <summary>在鼠标位置创建一个新的ROI实例。</summary>
        public virtual void CreateROI(double midX, double midY) { }
        /// <summary>将ROI绘制到提供的窗口中。</summary>
        public virtual void Draw(HWindow window) { }
        /// <summary> 返回ROI句柄的距离,最近的图像点(x,y)
        public virtual double DistToClosestHandle(double x, double y){return 0.0;}
        /// <summary>将ROI对象的活动句柄绘制到提供的窗口中。 </summary>
        public virtual void DisplayActive(HWindow window) { }
        /// <summary> 重新计算ROI的形状。翻译是,在ROI对象的活动句柄上执行,为图像坐标(x,y)。/// </summary>
        public virtual void moveByHandle(double x, double y) { }
        /// <summary>获取ROI描述的HALCON轮廓</summary>
        public virtual HXLDCont GetXLD() { return null; }
        /// <summary>获取ROI描述的HALCON区域</summary>
        public virtual HRegion GetRegion(){return null;}
        /// <summary> 从起点得到距离 </summary>
        public virtual double GetDistanceFromStartPoint(double row, double col){return 0.0;}
        /// <summary>获取所描述的模型信息 </summary> 
        public virtual HTuple GetModelData(){return null;}
        /// <summary>为ROI定义的句柄数。</summary>
        public int GetNumHandles(){return NumHandles;}
        /// <summary>获取ROI的活动句柄,返回索引</summary>
        public int GetActHandleIdx(){return ActiveHandleId;}
        /// <summary>获取ROI对象的符号，线的样式：+|- </summary>
        public int GetOperatorFlag(){return OperatorFlag;}
        /// <summary>设置ROI对象的符号，线的样式：+|- </summary>
        public void SetOperatorFlag(int flag)
        {
            OperatorFlag = flag;
            switch (OperatorFlag)
            {
                case POSITIVE_FLAG:
                    FlagLineStyle = posOperation;
                    break;
                case NEGATIVE_FLAG:
                    FlagLineStyle = negOperation;
                    break;
                default:
                    FlagLineStyle = posOperation;
                    break;
            }
        }
    }//end of class
}//end of namespace
