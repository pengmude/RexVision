using System;
using HalconDotNet;

namespace RexView
{
    /// <summary>
    ///�������һ�����࣬�������ڴ�������ⷽ��
    ///ROI��ˣ��̳�����Ҫ����/��д��Щ
    ///ΪROIController�ṩ��Ҫ��Ϣ�ķ���
    ///��(= ROIs)����״��λ�á�ʾ����Ŀ�ṩ
    ///�������Ρ�ֱ�ߡ�Բ��Բ����ROI��״��
    ///Ҫʹ��������״������ӻ�������һ������
    ///ʵ�����ķ�����
    /// </summary>    
    [Serializable]
    public class ROI
    {  
        /// <summary> Ҫ��ʾroi��ͼ����</summary>
        private int ImageWidth;
        /// <summary> Ҫ��ʾroi��ͼ����</summary>
        private int ImageHight;
        /// <summary>ROI��ɫ </summary>
        public string Color = "cyan";
        /// <summary> ROI����</summary>
        public ROIType Type;
        /// <summary>�̳�ROI������Ա </summary>
        protected int NumHandles;
        /// <summary>����ID</summary>
        protected int ActiveHandleId;
        /// <summary>����������ROI��������ʽ��</summary>
        public HTuple FlagLineStyle;
        /// <summary>����Ϊ��ROI��־��+</summary>
        public const int POSITIVE_FLAG = HWndCtrl.MODE_ROI_POS;
        /// <summary>����Ϊ��ROI��־��-</summary>
        public const int NEGATIVE_FLAG = HWndCtrl.MODE_ROI_NEG;
        /// <summary> ��Ƕ���ROIΪ�������򡰸�����. </summary>
        protected int OperatorFlag;
        /// <summary> "+"��ʽֱ��ֱ�� </summary>
        protected HTuple posOperation = new HTuple();
        /// <summary> "-"��ʽ������/// </summary>
        protected HTuple negOperation = new HTuple(new int[] { 2, 2 });
        /// <summary>����ROI��Ĺ��캯����</summary>
        public ROI() { }
        public virtual void CreateLine(double beginRow, double beginCol, double endRow, double endCol) { }
        public virtual void CreateCoordLine(double beginRow, double beginCol, double endRow, double endCol) { }
        public virtual void CreateCircle(double row, double col, double radius) { }
        public virtual void CreateCircleAre(double row, double col, double radius) { }
        public virtual void CreateRectangle1(double row1, double col1, double row2, double col2) { }
        public virtual void CreateRectangle2(double row, double col, double phi, double length1, double length2) { }
        public virtual void CreatePoint(double row, double col) { }
        /// <summary>�����λ�ô���һ���µ�ROIʵ����</summary>
        public virtual void CreateROI(double midX, double midY) { }
        /// <summary>��ROI���Ƶ��ṩ�Ĵ����С�</summary>
        public virtual void Draw(HWindow window) { }
        /// <summary> ����ROI����ľ���,�����ͼ���(x,y)
        public virtual double DistToClosestHandle(double x, double y){return 0.0;}
        /// <summary>��ROI����Ļ������Ƶ��ṩ�Ĵ����С� </summary>
        public virtual void DisplayActive(HWindow window) { }
        /// <summary> ���¼���ROI����״��������,��ROI����Ļ�����ִ��,Ϊͼ������(x,y)��/// </summary>
        public virtual void moveByHandle(double x, double y) { }
        /// <summary>��ȡROI������HALCON����</summary>
        public virtual HXLDCont GetXLD() { return null; }
        /// <summary>��ȡROI������HALCON����</summary>
        public virtual HRegion GetRegion(){return null;}
        /// <summary> �����õ����� </summary>
        public virtual double GetDistanceFromStartPoint(double row, double col){return 0.0;}
        /// <summary>��ȡ��������ģ����Ϣ </summary> 
        public virtual HTuple GetModelData(){return null;}
        /// <summary>ΪROI����ľ������</summary>
        public int GetNumHandles(){return NumHandles;}
        /// <summary>��ȡROI�Ļ���,��������</summary>
        public int GetActHandleIdx(){return ActiveHandleId;}
        /// <summary>��ȡROI����ķ��ţ��ߵ���ʽ��+|- </summary>
        public int GetOperatorFlag(){return OperatorFlag;}
        /// <summary>����ROI����ķ��ţ��ߵ���ʽ��+|- </summary>
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
