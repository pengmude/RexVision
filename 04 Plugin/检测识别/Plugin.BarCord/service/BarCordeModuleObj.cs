using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using VisionCore;
using HalconDotNet;

using System.Runtime.Serialization;

using RexHelps;
using RexConst;

namespace Plugin.BarCorde
{
    [Category("检测识别")]
    [DisplayName("读条形码")]
    [Serializable]
    public class BarCordeModObj : ObjBase
    {
        public FindMode m_FindMode;
        public enum FindMode
        {
            [EnumDescription("standard_recognition")]
            标准,
            [EnumDescription("enhanced_recognition")]
            增强,
            [EnumDescription("maximum_recognition")]
            最强
        }
        /// <summary>
        /// 返回结果
        /// </summary>
        string m_DecodedDataStrings = "";

        /// <summary>
        /// 模板区域
        /// </summary>
        public ROI m_ModelRegion;
        public double m_ModelRegionSpaceX;
        public double m_ModelRegionSpaceY;
        /// <summary>
        /// 模板句柄
        /// </summary>
        HTuple m_DataCodeHandle = new HTuple();
        [NonSerialized]
        HObject m_SymbolXLD = null;
        [NonSerialized]
        HTuple m_ResultHandles = new HTuple();       
        [NonSerialized]
        HDataCode2D m_dataCode2d =new HDataCode2D();
        [NonSerialized]
        private Dictionary<string, HDataCode2D> m_dataCode2DDic;
        /// <summary>
        /// 二维码类型
        /// </summary>
        public int m_CordeNum ;        
        /// <summary>
        /// 二维码类型
        /// </summary>
        public string m_WandCodeType="";
        /// <summary>
        /// 设置参数
        /// </summary>
        public string default_parameters = "";
        #region 检测基本单元参数
        /// <summary>
        /// 选取的处理图像
        /// </summary>
        public string mImages = "";
        /// <summary>
        /// 检测形态信息
        /// </summary>
        public Meas_Info mMeasInfo = new Meas_Info();
        /// <summary>
        /// 位置补正的单元ID
        /// </summary>
        public int mHomMatID = -1;
        /// <summary>
        /// //屏蔽区域 magical 20171028
        /// </summary>
        public HRegion disableRegion = new HRegion(0d, 0d, 0d);
        /// <summary>
        /// 第一次加载图像时参考坐标 存储图像坐标
        /// </summary>
        public Coord_Info RegCoor = new Coord_Info();
        /// <summary>
        /// 是否对屏蔽区域补正 ，补正屏蔽产品上需要屏蔽的区域，不补正屏蔽载具上的区域
        /// </summary>
        public bool isCorrect;
        /// <summary>
        /// 画笔颜色
        /// </summary>
        public string m_drawColor = "#FF0000";
        //输出轮廓线
        [NonSerialized]
        public HXLDCont m_Corde2DXLD = new HXLDCont();   ///检测形态轮廓
        [NonSerialized]
        public HXLDCont m_MeasXLD = new HXLDCont();   ///检测形态轮廓
        [NonSerialized]
        public HXLDCont m_MeasCross = new HXLDCont(); ///检测点十字
        [NonSerialized]
        public HXLDCont m_ResultXLD = new HXLDCont();    ///检测结果轮廓
        [NonSerialized]
        public HXLDCont m_ArrowXLD = new HXLDCont();  ///检测方向
        //输出检测点
        [NonSerialized]
        protected HTuple m_row = new HTuple();
        [NonSerialized]
        protected HTuple m_col = new HTuple();

        public HTuple point_Row
        {
            get { return m_row; }
        }
        public HTuple points_Col
        {
            get { return m_col; }
        }
        #endregion
        public override bool RunObj()
        {
            Circle_Info tempCircle = new Circle_Info();
            HRegion tempDisableRegion = new HRegion();//仿射变换后的屏蔽区域
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                Coord_Info coord = new Coord_Info();
                if (mHomMatID != -1)
                {
                    DataCell data = mSloVar.FirstOrDefault(c => c.mModIndex == mHomMatID);
                    coord = ((List<Coord_Info>)data.mDataValue)[0];
                    HHomMat2D homMat2D = new HHomMat2D();
                    homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                    homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);

                    //tempCircle = (Circle_Info)m_InCircle.Clone();
                    //tempCircle.CenterX = homMat2D.AffineTransPoint2d(m_InCircle.CenterX, m_InCircle.CenterY, out tempCircle.CenterY);
                    //tempCircle = Find.Circle2PixelPlane(mRImage, tempCircle);
                }
                else
                {
                    //coord = new Coord_Info();
                    //tempCircle = Find.Circle2PixelPlane(mRImage, m_InCircle);
                }
                HXLDCont CoordXLD = Gen.GetCoord(mRImage, coord);
                //获取图像坐标
                if (isCorrect)
                {
                    HRoi roi坐标系 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name.ToString(),ModInfo.Remarks, HRoiType.参考坐标, "green", new HObject(m_Corde2DXLD));
                    mRImage.ShowHRoi(roi坐标系);
                    if (disableRegion.IsInitialized())
                    {
                        double row, col, regRow, regCol;
                        DataCell data = mSysVar.FirstOrDefault(c => c.mModIndex == mHomMatID);
                        coord = ((List<Coord_Info>)data.mDataValue)[0];
                        HHomMat2D homMat2D = new HHomMat2D();
                        homMat2D = homMat2D.HomMat2dRotateLocal(-coord.Phi);
                        homMat2D = homMat2D.HomMat2dTranslate(coord.X, coord.Y);
                        regCol = homMat2D.AffineTransPoint2d(RegCoor.X, RegCoor.Y, out regRow);
                        Aff.WorldPlane2Point(mRImage, regCol, regRow, out regRow, out regCol);

                        HHomMat2D homMat = new HHomMat2D();
                        disableRegion.AreaCenter(out row, out col);
                        homMat.VectorAngleToRigid(row, col, RegCoor.Phi, regRow, regCol, coord.Phi);

                        tempDisableRegion = homMat.AffineTransRegion(disableRegion, "nearest_neighbor");
                    }

                }
                else
                {
                    tempDisableRegion = disableRegion;
                }
                //HObject m_SymbolXLD = null;
                //HDataCode2D m_dataCode2d = new HDataCode2D();
                //HTuple m_ResultHandles = new HTuple();
                //HOperatorSet.CreateBarCodeModel(new HTuple(), new HTuple());

                HOperatorSet.CreateBarCodeModel(new HTuple(), new HTuple(),out m_DataCodeHandle);
                Find.FindBarCorde(mRImage, m_SymbolXLD, m_DataCodeHandle,m_CordeNum, m_WandCodeType, out m_Corde2DXLD,out m_DecodedDataStrings);
                SetVarList(ref mSloVar, new DataCell(this.ModInfo.Name, this.ModInfo.Encode,DataType.单量, DataMode.String,ConstVar.Corde2D, ModInfo.Plugin,"0",1, m_DecodedDataStrings,DataAtrr.全局变量));
                //添加检测roi  magical 20170821
                HText roi文字显示 = new HText(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.文字显示, "blue", m_DecodedDataStrings, "mono", 0,0,20, new HObject(CoordXLD));
                HRoi roi检测范围 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测范围, "cyan", new HObject(m_Corde2DXLD));
                HRoi roi检测中心 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks,   HRoiType.检测中心, "blue", new HObject(m_MeasCross),false);
                HRoi roi检测结果 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.检测结果, "red", new HObject(m_ResultXLD),false);
                HRoi roi屏蔽范围 = new HRoi(this.ModInfo.Encode, this.ModInfo.Name, this.ModInfo.Remarks, HRoiType.屏蔽范围, "red", new HObject(tempDisableRegion),false);
              
                mRImage.ShowHRoi(roi屏蔽范围);
                if (ShowROI) { mRImage.ShowHRoi(roi检测中心); }
                if (ShowArea) { mRImage.ShowHRoi(roi检测范围); }
                if (ShowResult) { mRImage.ShowHRoi(roi检测结果); }
                mRImage.ShowHText(roi文字显示);
                this.ModInfo.State = ModState.OK;
            }
            catch (Exception ex)
            {
               Log.Error( ModInfo.Name + ex.Message);
                this.ModInfo.State = ModState.NG;
            }
            return true;
        }
        [OnDeserializing()]
        internal void OnDeSerializingMethod(StreamingContext context)
        {
            m_row = new HTuple();
            m_col = new HTuple();
            m_MeasXLD = new HXLDCont();   ///检测形态轮廓
            m_MeasCross = new HXLDCont(); ///检测点十字
            m_ResultXLD = new HXLDCont();    ///检测结果轮廓
            disableRegion = new HRegion();
        }
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            if (disableRegion == null || !disableRegion.IsInitialized())//修复为null 错误 magical 20171103
            {
                disableRegion = new HRegion((double)0, 0, 0);
            }
        }
        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (disableRegion == null)
            {
                disableRegion = new HRegion();
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
          new BarCordeModForm((BarCordeModObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {
            mRImage = new RImage();
            m_MeasXLD = new HXLDCont();   ///检测形态轮廓
            m_MeasCross = new HXLDCont(); ///检测点十字
            m_ResultXLD = new HXLDCont();    ///检测结果轮廓
            m_ArrowXLD = new HXLDCont();  ///检测方向
            m_row = new HTuple();
            m_col = new HTuple();
        }
        public void TrainDataCodeMode()
        {
             default_parameters = REnum.EnumToStr(m_FindMode);
            if (m_WandCodeType == "auto")
                return;
            try
            {
                HOperatorSet.CreateBarCodeModel(new HTuple(), new HTuple(),out m_DataCodeHandle);
                //HOperatorSet.CreateDataCode2dModel(m_WandCodeType, "default_parameters", default_parameters, out m_DataCodeHandle);
            }
            catch (Exception ex)
            {

                //throw new Exception(ex.Message);默认值:“all_candidates”
                //默认值:“all_candidates”建议值: 0、1、2、“一般”、“all_candidate”、“all_results”、“all_undecoded”、“all_aborted
            }
        }

        public Dictionary<string, HDataCode2D> DataCode2DDic
        {
            get
            {
                if (m_dataCode2DDic == null)
                {
                    m_dataCode2DDic = new Dictionary<string, HDataCode2D>();
                }
                return m_dataCode2DDic;
            }
        }
        public HDataCode2D DataCode2d
        {
            get
            {
                if (m_dataCode2d == null)
                {
                    m_dataCode2d = new HDataCode2D();
                }
                return m_dataCode2d;
            }
            set
            {
                m_dataCode2d = value;
            }
        }

    }
}
