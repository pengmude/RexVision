using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows.Forms;
using VisionCore;
using RexConst;
using System.Linq;


namespace Plugin.MeasCalib
{
    [Category("标定工具")]
    [DisplayName("测量标定")]
    [Serializable]
    public class MeasCalibObj : ObjBase
    {
        #region 区域标定映射
        /// <summary>
        /// 采集当前图像时候的位置X
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// 采集当前图像时候的位置Y
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// 采集当前图像时候的位置Z
        /// </summary>
        public double Z { get; set; }
        /// <summary>
        /// Y轴和直角坐标系旋转重叠后 X轴和直角坐标系X轴夹角
        /// </summary>
        public double PhiX { get; set; }
        /// <summary>
        /// X轴和直角坐标系旋转重叠后 Y轴和直角坐标系Y轴夹角
        /// </summary>
        public double PhiY { get; set; }
        /// <summary>
        /// 是否标定
        /// </summary>
        public bool Calibrated { get; set; }
        /// <summary>
        ///  需要畸变标定的图像名称
        /// </summary>
        public string mImages;
        /// <summary>
        /// 标定板类型 0-圆孔 1-棋盘 
        /// </summary>
        public int BoardType { get; set; } = 0;
        /// <summary>
        /// 标定用的图像
        /// </summary>
        public RImage Image = new RImage();
        /// <summary>
        /// 兴趣区域 
        /// </summary>
        public HRegion DetectRegion = new HRegion();
        /// <summary>
        /// 屏蔽区域 
        /// </summary>
        public HRegion DisableRegion = new HRegion();
        /// <summary>
        /// 棋盘格间距/孔板孔间距
        /// </summary>
        public double Distance { get; set; } = 1;
        /// <summary>
        /// X方向像素比率
        /// </summary>   
        public double ScaleX { get; set; }
        /// <summary>
        /// Y方向像素比率
        /// </summary>   
        public double ScaleY { get; set; }
        /// <summary>
        /// RMS误差
        /// </summary>
        public double RMS { get; set; }
        /// <summary>
        /// 标定板行坐标
        /// </summary>
        public HTuple BoardRow { get; set; }
        /// <summary>
        /// 标定板列坐标
        /// </summary>
        public HTuple BoardCol { get; set; }
        /// <summary>
        /// 标定板X坐标
        /// </summary>
        public HTuple BoardX { get; set; }
        /// <summary>
        /// 标定板Y坐标
        /// </summary>
        public HTuple BoardY { get; set; }
        /// <summary>
        /// 显示轮廓
        /// </summary>
        [NonSerialized]
        public HXLDCont xldMark;
        public List<HRoi> mHRoi = new List<HRoi>();
        #endregion
        /// <summary>
        /// 生成标定数据
        /// </summary>
        public void Calib()
        {

            try
            {
                double Scale = 1f;
                HHomMat2D hom = new HHomMat2D();
                HHomMat2D homPhi = new HHomMat2D();//孔板放置夹角
                HTuple Row = new HTuple(), Col = new HTuple(), PositionX = new HTuple(), PositionY = new HTuple();
                HTuple tmpRow = new HTuple(), tmpCol = new HTuple(); HTuple tmpX = new HTuple(), tmpY = new HTuple();
                if (Image.IsInitialized())
                {
                    HRegion roi = DetectRegion;
                    if (DisableRegion != null && DisableRegion.IsInitialized())
                        roi = DetectRegion.Difference(DisableRegion);
                    HImage tmpIMG = Image.ReduceDomain(roi);
                    int seed = 0;
                    if (BoardType == 0)//孔板
                    {
                        HXLDCont xld = tmpIMG.ThresholdSubPix(new HTuple(60));
                        //根据面积、长度和圆度剔除异常圆
                        //area_center_xld(Border, Area, Row, Column, PointOrder)
                        // 长度增加异常长度剔除  yoga 2017-8-31 9:34:24
                        HTuple Length = xld.LengthXld();
                        int errCount = (int)(Length.Length * 0.8);
                        List<double> length = new List<double>(Length.ToDArr());
                        length.Sort();
                        length.RemoveRange(0, errCount);

                        HTuple Radius = new HTuple(), StartPhi = new HTuple(), EndPhi = new HTuple(), order = new HTuple();
                        double avgLength = length.Average();
                        xld = xld.SelectShapeXld("contlength", "and", 0.7 * avgLength, 1.3 * avgLength);
                        xld = xld.SelectShapeXld("circularity", "and", 0.8, 1);
                        xld.FitCircleContourXld("algebraic", -1, 0, 0, 3, 2, out Row, out Col, out Radius, out StartPhi, out EndPhi, out order);
                        if (Row == null || Row.Length < 1)
                        {
                            MessageBox.Show("标志点查找失败,请检查设置");
                            return;
                        }
                        //显示轮廓
                        xldMark = new HXLDCont();
                        xldMark.GenCircleContourXld(Row, Col, Radius, StartPhi, EndPhi, order, 1.0);
                        HXLDCont cross = new HXLDCont();
                        cross.GenCrossContourXld(Row, Col, 3, 0);
                        xldMark = xldMark.ConcatObj(cross);
                        //计算像素比  随机取一个点 到其他点的距离，取最小的作为点间距 ，不允许孤立的点
                        Random m_Random = new Random();
                        seed = m_Random.Next(Row.Length);
                        seed = 0;
                        //排序
                        Gen.SortPairs(ref Row, ref Col);
                        HTuple chooseRow = HTuple.TupleGenConst(Row.Length - 1, Row[seed]);
                        HTuple chooseCol = HTuple.TupleGenConst(Col.Length - 1, Col[seed]);
                        tmpRow = Row.TupleRemove(seed);
                        tmpCol = Col.TupleRemove(seed);
                        double distance = HMisc.DistancePp(chooseRow, chooseCol, tmpRow, tmpCol).TupleMin().D;
                        Scale = (double)Distance / distance;
                        for (int i = 0; i < Row.Length; i++)
                        {
                            if (i == seed)
                            {
                                PositionX = PositionX.TupleConcat(0f);
                                PositionY = PositionY.TupleConcat(0f);
                                continue;
                            }
                            int sRow = (int)((Row[i].D - Row[seed].D) / distance + ((Row[i].D - Row[seed].D) > 0 ? 1 : -1) * 0.5);//四舍五入
                            int sCol = (int)((Col[i].D - Col[seed].D) / distance + ((Col[i].D - Col[seed].D) > 0 ? 1 : -1) * 0.5);//四舍五入
                            PositionX = PositionX.TupleConcat(sCol * Distance);
                            PositionY = PositionY.TupleConcat(sRow * Distance);
                        }
                        HTuple chooseX = HTuple.TupleGenConst(PositionX.Length - 1, PositionX[seed]);
                        HTuple chooseY = HTuple.TupleGenConst(PositionY.Length - 1, PositionY[seed]);
                        tmpX = PositionX.TupleRemove(seed);
                        tmpY = PositionY.TupleRemove(seed);

                        //计算出像素当量
                        double PixCount = HMisc.DistancePp(chooseRow, chooseCol, tmpRow, tmpCol).TupleSum().D;
                        double mmCount = HMisc.DistancePp(chooseY, chooseX, tmpY, tmpX).TupleSum().D;
                        Scale = mmCount / PixCount;
                        //计算标定板角度偏差
                        hom = new HHomMat2D();
                        hom.VectorToHomMat2d(PositionX, PositionY, Col, Row);
                        //Find hMeasSetS = new Find();
                        RMS = Dis.CalRMS(hom, PositionX, PositionY, Col, Row);
                        double sx, sy, phi, theta, tx, ty;
                        sx = hom.HomMat2dToAffinePar(out sy, out phi, out theta, out tx, out ty);

                        hom = new HHomMat2D();
                        hom = hom.HomMat2dRotate(phi, 0, 0);
                        hom = hom.HomMat2dTranslate(Scale * Col[seed].D, Scale * Row[seed].D);
                        PositionX = hom.AffineTransPoint2d(PositionX, PositionY, out PositionY);
                        homPhi = homPhi.HomMat2dRotate(phi, Col[seed].D, Row[seed].D);
                    }
                    else if (BoardType == 1)//棋盘格
                    {

                    }
                    //计算比例
                    tmpCol = homPhi.AffineTransPoint2d(Col, Row, out tmpRow);
                    Image.ScaleX = Scale;
                    Image.ScaleY = Scale;
                    Image.BoardRow = Row;
                    Image.BoardCol = Col;
                    Image.BoardX = PositionX;
                    Image.BoardY = PositionY;
                    string CalibratedTime="标定时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:MM");
                    Image.mHText.Clear();
                    //roi文字显示----------------------------------------------------------------------------------------------------------------------------------------------------------
                    Image.ShowHText(new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, "red", CalibratedTime, "mono", 10, 10, 20, new HObject(Image)));
                    SetVarList(ref mSysVar, new DataCell(ModInfo.Name, this.ModInfo.Encode, DataType.单量, DataMode.Double, ConstVar.Result, ModInfo.Plugin, "0", 1, Math.Round(Scale,6), DataAtrr.系统变量));

                    ModInfo.State = ModState.OK;
                    Calibrated = true;
                }
            }
            catch (Exception ex)
            {
                ModInfo.State = ModState.NG;
                MessageBox.Show(ex.ToString());
            }


        }


        public override bool RunObj()
        {
            try
            {
                if (Calibrated)//判断是否标定
                {
                    if (mRImage == null)
                    {
                       Log.Info( Name + ":" + ModInfo.Name + ":未找到图像！" );
                        this.ModInfo.State = ModState.NG;
                        return false;
                    }
                    Image.IsCal = true; 
                    ModInfo.State = ModState.OK;
                   Log.Info( Name + ":" + ModInfo.Name + ":标定成功！" );
                }
                else
                {
                   Log.Info( Name + ":" + ModInfo.Name + ":标定成功！" );
                    return false;
                }
            }
            catch (Exception ex)
            {
                ModInfo.State = ModState.NG;
               Log.Error( Name + ":" + ModInfo.Name + ex.ToString() );
                return false;
            }
            return true;
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="context"></param>
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context)
        {
            if (DisableRegion == null || !DisableRegion.IsInitialized())//修复为null 错误 magical 20171103
            {
                DisableRegion = null;
            }
            if (DetectRegion == null || !DetectRegion.IsInitialized())
            {
                DetectRegion = null;
            }
            if (xldMark == null || !xldMark.IsInitialized())
            {
                xldMark = null;
            }
            if (Image == null || !Image.IsInitialized())
            {
                Image = null;
            }
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="context"></param>
        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (DetectRegion == null)
            {
                DetectRegion = new HRegion();
            }
            if (DisableRegion == null)
            {
                DisableRegion = new HRegion();
            }
            if (xldMark == null)
            {
                xldMark = new HXLDCont();
            }
            if (Image == null)
            {
                Image = new RImage();
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            new MeasCalibForm((MeasCalibObj)baseMod).ShowDialog();
        }
    }
}
