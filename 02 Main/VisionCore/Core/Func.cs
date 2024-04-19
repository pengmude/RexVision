using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using HalconDotNet;
using RexConst;
using RexView;
using System.Runtime.InteropServices;
using RexHelps;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.ComponentModel;
using System.Threading;
namespace VisionCore
{
    #region 测量函数
    /// <summary>测量函数</summary>
    public class Meas
    {
        /// <summary>
        /// 检测直线 增加屏蔽区域 magical20171028
        /// </summary>
        /// <param name="image">检测图像</param>
        /// <param name="line">输入检测直线区域</param>
        /// <param name="meas">形态参数</param>
        /// <param name="outLine">输出直线</param>
        /// <param name="outR">输出行点</param>
        /// <param name="outC">输出列点</param>
        /// <param name="outXld">输出检测轮廓</param>
        /// <param name="disableRegion">屏蔽区域 可选</param>
        /// <param name="isPaint">对屏蔽区域进行喷绘 可选</param>
        public static void MeasLine(HImage image, ROILine line, Meas_Info meas, out ROILine outLine, out HTuple outR, out HTuple outC, out HXLDCont outXld, HRegion disableRegion = null)
        {
            HMetrologyModel MetroModel = new HMetrologyModel();
            try
            {
                outLine = new ROILine();
                HTuple lineResult = new HTuple();
                HTuple lineInfo = (new HTuple(new double[] { line.StartY, line.StartX, line.EndY, line.EndX }));
                //最强边的计算
                if (meas.ParamValue[1] == "strongest")
                {
                    MeasLine1D(image, line, meas, out outLine, out outR, out outC, out outXld, disableRegion);
                    return;
                }
                //降低直线拟合的最低得分
                MetroModel.AddMetrologyObjectGeneric(
                    new HTuple("line"),
                    lineInfo,
                    new HTuple(meas.Length1),
                    new HTuple(meas.Length2),
                    new HTuple(1), //滤波
                    new HTuple(meas.Threshold),
                    meas.ParamName,
                    meas.ParamValue);
                MetroModel.SetMetrologyObjectParam(0, "min_score", 0.1);/// 分数阈值
                if (disableRegion != null)
                {
                    MetroModel.ApplyMetrologyModel(image);
                    //单个测量区域 刚好 有一大半在屏蔽区域,一小部分在有效区域,这时候也会测出一个点这个点在屏蔽区域内,导致精度损失约为1个像素左右.需要喷绘之后,再进行点是否在屏蔽区域判断
                    outXld = MetroModel.GetMetrologyObjectMeasures("all", "all", out outR, out outC);
                    List<double> tempOutR = new List<double>(), tempOutC = new List<double>();
                    for (int i = 0; i < outR.DArr.Length - 1; i++)
                    {
                        //0 表示没有包含
                        if (disableRegion.TestRegionPoint(outR[i].D, outC[i].D) == 0)
                        {
                            tempOutR.Add(outR[i].D);
                            tempOutC.Add(outC[i].D);
                        }
                    }
                    outR = new HTuple(tempOutR.ToArray());
                    outC = new HTuple(tempOutC.ToArray());
                }
                else
                {
                    MetroModel.ApplyMetrologyModel(image);
                    outXld = MetroModel.GetMetrologyObjectMeasures("all", "all", out outR, out outC);
                }
                lineResult = MetroModel.GetMetrologyObjectResult(new HTuple("all"), new HTuple("all"), new HTuple("result_type"), new HTuple("all_param"));
                if (lineResult.TupleLength() >= 4)
                {
                    outLine = new ROILine();
                    outLine.StartY = Math.Round(lineResult[0].D, 4);
                    outLine.StartX = Math.Round(lineResult[1].D, 4);
                    outLine.EndY = Math.Round(lineResult[2].D, 4);
                    outLine.EndX = Math.Round(lineResult[3].D, 4);
                    outLine.MidX = (outLine.StartX + outLine.EndX) / 2;
                    outLine.MidY = (outLine.StartY + outLine.EndY) / 2;
                    outLine.Phi = Math.Round(HMisc.AngleLx(outLine.StartY, outLine.StartX, outLine.EndY, outLine.EndX), 4);
                    outLine.Dist = Math.Round(HMisc.DistancePp(outLine.StartX, outLine.StartY, outLine.EndX, outLine.EndY), 4);
                    outLine.Y = outR;
                    outLine.X = outC;
                    outLine.Nx = outLine.EndX - outLine.StartX;
                    outLine.Ny = outLine.StartY - outLine.EndY;
                }
                else
                {
                    if (Fit.FitLine(outR.ToDArr().ToList(), outC.ToDArr().ToList(), out outLine))
                        outLine = line;
                }
                MetroModel.Dispose();
            }
            catch (Exception ex)
            {
                outLine = line;
                outR = new HTuple();
                outC = new HTuple();
                outXld = new HXLDCont();
                MetroModel.Dispose();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 一维测量算子,检测直线.再利用halcon的拟合直线算法拟合直线 主要用于最强边缘的测量 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="line"></param>
        /// <param name="meas"></param>
        /// <param name="outLine"></param>
        /// <param name="outR"></param>
        /// <param name="outC"></param>
        /// <param name="outXld"></param>
        /// <param name="disableRegion"></param>
        /// <param name="isPaint"></param>
        public static void MeasLine1D(HImage image, ROILine line, Meas_Info meas, out ROILine outLine, out HTuple outR, out HTuple outC, out HXLDCont outXld, HRegion disableRegion = null, bool isPaint = true)
        {
            outLine = line;
            outR = new HTuple();
            outC = new HTuple();
            outXld = new HXLDCont();
            HMeasure mea = new HMeasure();
            List<double> outRList = new List<double>();
            List<double> outCList = new List<double>();
            HImage tempImage = disableRegion != null ? disableRegion.PaintRegion(image, 0d, "fill") : image;//将屏蔽区域喷绘为0
            double angle = HMisc.AngleLx(line.StartY, line.StartX, line.EndY, line.EndX);            //注意下这里的角度
            double points = ((HMisc.DistancePp(line.StartY, line.StartX, line.EndY, line.EndX) - 2 * meas.Length2) / meas.MeasDis) + 1;
            double measDis = (HMisc.DistancePp(line.StartY, line.StartX, line.EndY, line.EndX) - 2 * meas.Length2) / points;
            for (int i = 0; i <= points; i++)
            {
                double rectRowC = line.StartY + (meas.Length2 - i * measDis) * Math.Sin(angle);
                double rectColC = line.StartX + (meas.Length2 + i * measDis) * Math.Cos(angle);
                outXld.GenRectangle2ContourXld(rectRowC, rectColC, angle - Math.PI / 2, meas.Length1, meas.Length2);
                image.GetImageSize(out int width, out int height);
                mea.GenMeasureRectangle2(rectRowC, rectColC, angle - Math.PI / 2, meas.Length1, meas.Length2, width, height, "nearest_neighbor");
                mea.MeasurePos(tempImage, 1, meas.Threshold, meas.ParamValue[0], "all", out HTuple rowEdge, out HTuple columnEdge, out HTuple amplitude, out HTuple distance);
                mea.Dispose();
                if (amplitude != null & amplitude.Length > 0)
                {
                    // amplitude.TupleSort();
                    HTuple HIndex = amplitude.TupleAbs().TupleSortIndex();
                    outRList.Add(rowEdge[HIndex[HIndex.Length - 1].I]);
                    outCList.Add(columnEdge[HIndex[HIndex.Length - 1].I]);
                }
            }
            outR = new HTuple(outRList.ToArray());
            outC = new HTuple(outCList.ToArray());
            if (disableRegion != null)
            {
                List<double> tempOutR = new List<double>(), tempOutC = new List<double>();
                for (int i = 0; i < outR.DArr.Length - 1; i++)
                {
                    if (disableRegion.TestRegionPoint(outR[i].D, outC[i].D) == 0) //0 表示没有包含
                    {
                        tempOutR.Add(outR[i].D);
                        tempOutC.Add(outC[i].D);
                    }
                }
                outR = new HTuple(tempOutR.ToArray());
                outC = new HTuple(tempOutC.ToArray());
            }
            if (outR.Length > 0)
            {
                Fit.FitLine(outRList, outCList, out outLine);
            }
            else
            {
                outLine = line;
            }
        }
        /// <summary>
        /// 检测圆
        /// </summary>
        /// <param name="image">输入图像</param>
        /// <param name="circel">输入圆</param>
        /// <param name="meas">输入形态学</param>
        /// <param name="outCircle">输出圆</param>
        /// <param name="outR">输出行坐标</param>
        /// <param name="outC">输出列坐标</param>
        /// <param name="outXld">输出检测轮廓</param>
        public static void MeasCircle(HImage image, ROICircle circel, Meas_Info meas, HRegion disableRegion, out ROICircle outCircle, out HTuple outR, out HTuple outC, out HXLDCont outXld)
        {
            HMetrologyModel MetroModel = new HMetrologyModel();
            try
            {
                outCircle = new ROICircle();
                HTuple CircleResult = new HTuple();
                HTuple Circle_Info = new HTuple();
                Circle_Info.Append(new HTuple(new double[] { circel.CenterY, circel.CenterX, circel.Radius }));
                MetroModel.AddMetrologyObjectGeneric
                    (new HTuple("circle"),
                    Circle_Info,
                    new HTuple(meas.Length1),
                    new HTuple(meas.Length2),
                    new HTuple(meas.PointsOrder + 1),
                    new HTuple(meas.Threshold),
                    meas.ParamName,
                    meas.ParamValue);
                MetroModel.ApplyMetrologyModel(image);
                outXld = MetroModel.GetMetrologyObjectMeasures("all", "all", out outR, out outC);
                if (disableRegion != null && disableRegion.IsInitialized() && disableRegion.Area > 0 && outR.Length > 0)
                {
                    List<double> tempOutR = new List<double>(), tempOutC = new List<double>();
                    for (int i = 0; i < outR.DArr.Length - 1; i++)
                    {
                        //0 表示没有包含
                        if (disableRegion.TestRegionPoint(outR[i].D, outC[i].D) == 0)
                        {
                            tempOutR.Add(outR[i].D);
                            tempOutC.Add(outC[i].D);
                        }
                    }
                    outR = new HTuple(tempOutR.ToArray());
                    outC = new HTuple(tempOutC.ToArray());
                    Fit.FitCircle1(outR.ToDArr().ToList(), outC.ToDArr().ToList(), out outCircle);
                    //outXld = outCircle.genXLD();
                }
                else
                {
                    CircleResult = MetroModel.GetMetrologyObjectResult(new HTuple("all"), new HTuple("all"), new HTuple("result_type"), new HTuple("all_param"));
                    if (CircleResult.TupleLength() >= 3)
                    {
                        outCircle.CenterY = Math.Round(CircleResult[0].D, 4);
                        outCircle.CenterX = Math.Round(CircleResult[1].D, 4);
                        outCircle.Radius = Math.Round(CircleResult[2].D, 4);
                    }
                    else
                    {
                        Fit.FitCircle1(outR.ToDArr().ToList(), outC.ToDArr().ToList(), out outCircle);
                    }
                }
                MetroModel.Dispose();
            }
            catch (Exception ex)
            {
                outCircle = circel;
                outR = new HTuple();
                outC = new HTuple();
                outXld = new HXLDCont();
                MetroModel.Dispose();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 检测椭圆
        /// </summary>
        /// <param name="image">输入图像</param>
        /// <param name="inEllipse">输入椭圆</param>
        /// <param name="meas">输入形态学</param>
        /// <param name="outEllipse">输出椭圆</param>
        /// <param name="outR">输出行坐标</param>
        /// <param name="outC">输出列坐标</param>
        /// <param name="outXld">输出检测轮廓</param>
        public static void MeasEllipse(HImage image, Ellipse_Info inEllipse, Meas_Info meas, out Ellipse_Info outEllipse, out HTuple outR, out HTuple outC, out HXLDCont outXld)
        {
            HMetrologyModel MetroModel = new HMetrologyModel();
            try
            {
                outEllipse = new Ellipse_Info();
                HTuple EllipseResult = new HTuple();
                HTuple Ellipse_Info = new HTuple();
                Ellipse_Info.Append(new HTuple(new double[] { inEllipse.CenterY, inEllipse.CenterX, inEllipse.Phi, inEllipse.Radius1, inEllipse.Radius2 }));
                //MetroModel.AddMetrologyObjectGeneric(new HTuple("ellipse"), Ellipse_Info, new HTuple(meas.Length1),
                //    new HTuple(meas.Length2), new HTuple(1), new HTuple(meas.Threshold)
                //    , meas.ParamName, meas.ParamValue);
                MetroModel.AddMetrologyObjectEllipseMeasure(new HTuple(inEllipse.CenterY), new HTuple(inEllipse.CenterX), new HTuple(inEllipse.Phi),
                    new HTuple(inEllipse.Radius1), new HTuple(inEllipse.Radius2), new HTuple(meas.Length1),
                    new HTuple(meas.Length2), new HTuple(1), new HTuple(meas.Threshold), meas.ParamName, meas.ParamValue);
                MetroModel.SetMetrologyObjectParam("all", "max_num_iterations", 70);
                MetroModel.ApplyMetrologyModel(image);
                outXld = MetroModel.GetMetrologyObjectMeasures("all", "all", out outR, out outC);
                EllipseResult = MetroModel.GetMetrologyObjectResult(new HTuple("all"), new HTuple("all"), new HTuple("result_type"), new HTuple("all_param"));
                if (EllipseResult.TupleLength() >= 4)
                {
                    outEllipse.CenterY = EllipseResult[0].D;
                    outEllipse.CenterX = EllipseResult[1].D;
                    outEllipse.Phi = EllipseResult[2].D;
                    outEllipse.Radius1 = EllipseResult[3].D;
                    outEllipse.Radius2 = EllipseResult[4].D;
                }
                MetroModel.Dispose();
            }
            catch (Exception ex)
            {
                outEllipse = inEllipse;
                outR = new HTuple();
                outC = new HTuple();
                outXld = new HXLDCont();
                MetroModel.Dispose();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 边缘对检测
        /// </summary>
        /// <param name="image">输入图像</param>
        /// <param name="inCross">输入矩形框中心</param>
        /// <param name="meas">形态学参数</param>
        /// <param name="lstLine">返回直线列表</param>
        /// <param name="lstWidth">直线长度</param>
        /// <param name="lstDistance">直线间隔</param>
        /// <param name="outXld">直线轮廓</param>
        public static void MeasPairs(HImage image, ROIRectangle2 inRectangle2, Meas_Info meas, out List<ROILine> lstLine, out List<double> lstWidth, out List<double> lstDistance, out HXLDCont outXld)
        {
            HMeasure hMeas = new HMeasure();
            image.GetImageSize(out int width, out int height);
            lstLine = new List<ROILine>();
            lstWidth = new List<double>();
            lstDistance = new List<double>();
            outXld = new HXLDCont();
            outXld.GenEmptyObj();
            try
            {
                string tempStr1 = meas.ParamValue[0].S == "negative" ? "all" : "negative_strongest";
                string tempStr2 = meas.ParamValue[1].S == "strongest" ? "all" : meas.ParamValue[1].S;
                hMeas.GenMeasureRectangle2(
                    inRectangle2.midR,
                    inRectangle2.midC,
                    inRectangle2.phi,
                    inRectangle2.length1,
                    inRectangle2.length2,
                    width,
                    height,
                    "nearest_neighbor");
                //产生测量对象句柄
                HOperatorSet.GenMeasureRectangle2(inRectangle2.midR,inRectangle2.midC,inRectangle2.phi, inRectangle2.length1,inRectangle2.length2, width, height, "nearest_neighbor", out HTuple _Measure);
                HOperatorSet.MeasurePairs(image, _Measure, 1, 30, tempStr1, tempStr2,
                    out HTuple rowEdgeFirst,      //第1条边中心的行坐标
                    out HTuple columnEdgeFirst,   //第1条边中心的列坐标
                    out HTuple amplitudeFirst,    //第1条边的边缘振幅（带符号）
                    out HTuple rowEdgeSecond,     //第2条边中心的行坐标
                    out HTuple columnEdgeSecond,  //第2条边中心的列坐标
                    out HTuple amplitudeSecond,   //第2条边的边幅值(带符号)
                    out HTuple intraDistance,     //边对的边之间的距离
                    out HTuple interDistance);    //连续边对之间的距离


                //hMeas.MeasurePos(image,    //测量图像
                //1,                            //高斯平滑0-100
                //meas.Threshold,        //最小边振幅
                //tempStr1,                     //边对的灰色值过渡类型 "all""all_strongest""negative""negative_strongest""positive""positive_strongest"
                //tempStr2,                     //选择边对 "all""first""last"
                ////out HTuple rowEdgeFirst,      //第1条边中心的行坐标
                ////out HTuple columnEdgeFirst,   //第1条边中心的列坐标
                ////out HTuple amplitudeFirst,    //第1条边的边缘振幅（带符号）
                ////out HTuple rowEdgeSecond,     //第2条边中心的行坐标
                //out HTuple columnEdgeSecond,  //第2条边中心的列坐标
                //out HTuple amplitudeSecond,   //第2条边的边幅值(带符号)
                //out HTuple intraDistance,     //边对的边之间的距离
                //out HTuple interDistance);    //连续边对之间的距离
                //hMeas.MeasurePairs(image,    //测量图像
                //    1,                            //高斯平滑0-100
                //    meas.Threshold,        //最小边振幅
                //    tempStr1,                     //边对的灰色值过渡类型 "all""all_strongest""negative""negative_strongest""positive""positive_strongest"
                //    tempStr2,                     //选择边对 "all""first""last"
                //    out HTuple rowEdgeFirst,      //第1条边中心的行坐标
                //    out HTuple columnEdgeFirst,   //第1条边中心的列坐标
                //    out HTuple amplitudeFirst,    //第1条边的边缘振幅（带符号）
                //    out HTuple rowEdgeSecond,     //第2条边中心的行坐标
                //    out HTuple columnEdgeSecond,  //第2条边中心的列坐标
                //    out HTuple amplitudeSecond,   //第2条边的边幅值(带符号)
                //    out HTuple intraDistance,     //边对的边之间的距离
                //    out HTuple interDistance);    //连续边对之间的距离
                if (rowEdgeFirst.Length > 0)
                {
                    for (int i = 0; i < rowEdgeFirst.Length; i++)
                    {
                        ROILine temp = new ROILine(rowEdgeFirst[i].D, columnEdgeFirst[i].D, rowEdgeSecond[i].D, columnEdgeSecond[i].D);
                        lstLine.Add(temp);
                        HXLDCont xld = new HXLDCont();
                        HTuple row = (new HTuple(rowEdgeFirst[i].D)).TupleConcat(rowEdgeSecond[i].D);
                        HTuple col = (new HTuple(columnEdgeFirst[i].D)).TupleConcat(columnEdgeSecond[i].D);
                        xld.GenContourPolygonXld(row, col);
                        outXld = outXld.ConcatObj(xld);
                    }
                    lstWidth = intraDistance.ToDArr().ToList();
                    lstDistance = interDistance.ToDArr().ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
            finally
            {
                hMeas.Dispose();
            }
        }

        public static void MeasRect2(HObject ho_Image, out HXLDCont ho_Arrow, out HObject ho_Rectangle2Contour,
               out HObject ho_ruleContours, HTuple hv_Row, HTuple hv_Column, HTuple hv_Phi,
               HTuple hv_Length1, HTuple hv_Length2, HTuple hv_MeasureCliperNum, HTuple hv_MeasureLength1,
               HTuple hv_MeasureLength2, HTuple hv_MeasureSigma, HTuple hv_MeasureThreshold,
               HTuple hv_MeasureTransition, HTuple hv_MeasureSelect, out HTuple hv_RectRow,
               out HTuple hv_RectCol, out HTuple hv_RectPhi, out HTuple hv_Len1, out HTuple hv_Len2,
               out HTuple hv_Rows, out HTuple hv_Columns)
        {

            // Local iconic variables 

            // Local control variables 

            HTuple hv_RowEx = null, hv_ColEx = null, hv_beginRow = null;
            HTuple hv_beginCol = null, hv_EndRow = null, hv_EndCol = null;
            HTuple hv_MetrologyHandle = null, hv_Width = null, hv_Height = null;
            HTuple hv_Index = null, hv_Rectangle2Parameter = null;
            // Initialize local and output iconic variables 
            //HOperatorSet.GenEmptyObj(out ho_Arrow);
            HOperatorSet.GenEmptyObj(out ho_Rectangle2Contour);
            HOperatorSet.GenEmptyObj(out ho_ruleContours);
            hv_RectRow = new HTuple();
            hv_RectCol = new HTuple();
            hv_RectPhi = new HTuple();
            hv_Len1 = new HTuple();
            hv_Len2 = new HTuple();
            hv_RowEx = hv_Row - ((hv_Phi.TupleSin()) * hv_Length1);
            hv_ColEx = hv_Column + ((hv_Phi.TupleCos()) * hv_Length1);

            hv_beginRow = hv_RowEx + ((hv_Phi.TupleSin()) * hv_MeasureLength1);
            hv_beginCol = hv_ColEx - ((hv_Phi.TupleCos()) * hv_MeasureLength1);
            hv_EndRow = hv_RowEx - ((hv_Phi.TupleSin()) * hv_MeasureLength1);
            hv_EndCol = hv_ColEx + ((hv_Phi.TupleCos()) * hv_MeasureLength1);
            //ho_Arrow.Dispose();
            Gen.GenArrow(out ho_Arrow, hv_beginRow, hv_beginCol, hv_EndRow, hv_EndCol,hv_MeasureLength2 * 2, hv_MeasureLength2 * 2);
            //创建2维测量
            HOperatorSet.CreateMetrologyModel(out hv_MetrologyHandle);
            HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
            HOperatorSet.SetMetrologyModelImageSize(hv_MetrologyHandle, hv_Width, hv_Height);
            //加载方向矩形2维测量
            HOperatorSet.AddMetrologyObjectRectangle2Measure(hv_MetrologyHandle, hv_Row,
                hv_Column, hv_Phi, hv_Length1, hv_Length2, hv_MeasureLength1, hv_MeasureLength2,
                hv_MeasureSigma, hv_MeasureThreshold, new HTuple(), new HTuple(), out hv_Index);
            //卡尺搜索模式 positive：白到黑   negative：黑到白
            HOperatorSet.SetMetrologyObjectParam(hv_MetrologyHandle, "all", "measure_transition",
                hv_MeasureTransition);
            //卡尺选择边缘点
            HOperatorSet.SetMetrologyObjectParam(hv_MetrologyHandle, "all", "measure_select",
                hv_MeasureSelect);
            //卡尺数量
            HOperatorSet.SetMetrologyObjectParam(hv_MetrologyHandle, "all", "num_measures",
                hv_MeasureCliperNum);
            //图像加载到2维测量中
            HOperatorSet.ApplyMetrologyModel(ho_Image, hv_MetrologyHandle);
            //拟合线结果
            HOperatorSet.GetMetrologyObjectResult(hv_MetrologyHandle, "all", "all", "result_type",
                "all_param", out hv_Rectangle2Parameter);
            if ((int)(new HTuple(hv_Rectangle2Parameter.TupleGreater(5))) != 0)
            {
                hv_RectRow = hv_Rectangle2Parameter[0];
                hv_RectCol = hv_Rectangle2Parameter[1];
                hv_RectPhi = hv_Rectangle2Parameter[2];
                hv_Len1 = hv_Rectangle2Parameter[3];
                hv_Len2 = hv_Rectangle2Parameter[4];
            }
            //拟合方向矩形图形
            ho_Rectangle2Contour.Dispose();
            HOperatorSet.GetMetrologyObjectResultContour(out ho_Rectangle2Contour, hv_MetrologyHandle,
                "all", "all", 1.5);
            //卡尺方向矩形图形
            ho_ruleContours.Dispose();
            HOperatorSet.GetMetrologyObjectMeasures(out ho_ruleContours, hv_MetrologyHandle,
                "all", "all", out hv_Rows, out hv_Columns);
            HOperatorSet.ClearMetrologyModel(hv_MetrologyHandle);
            return;
        }
    }
    #endregion
    #region 查找模板
    /// <summary>查找模板</summary>
    public class Find
    {
        static int FLevers = 0;
        static double FStarPhi = -180.0, FOverPhi = 180.0, FMinScale = 0.8, FMaxScale = 1.1;
        /// <summary>图像转换</summary>
        public static void ToHImage(HObject hobject, out HImage image)
        {
            image = null;
            HOperatorSet.GetImagePointer1(hobject, out HTuple pointer, out HTuple type, out HTuple width, out HTuple height);
            image.GenImage1(type, width, height, pointer);
        }
        /// <summary>
        /// 创建模板-金字塔等级,数值越大,细节越少,匹配时间越短,反之亦然
        /// </summary>
        /// <param name="type">模板类型</param>
        /// <param name="image">图像</param>
        /// <param name="search">搜索区域</param>
        /// <param name="temp">模板区域</param>
        /// <param name="threshold">边缘阈值</param>
        /// <param name="levers">金字塔等级</param>
        /// <param name="minScale">最小比例</param>
        /// <param name="maxScale">最大比例</param>
        /// <param name="polar">对比极性</param>
        /// <param name="starPhi">最小角度</param>
        /// <param name="overPhi">最大角度</param>
        /// <param name="TempHandle">模板句柄</param>
        public static void CreateModel(ModelType type, HImage image, RexView.ROI temp, int threshold, int levers, double starPhi, double overPhi, double minScale, double maxScale, CompType polar, ref HHandle TempHandle)
        {
            try
            {
                FLevers = levers;
                FStarPhi = starPhi;
                FOverPhi = overPhi;
                if (temp != null)
                {
                    image = image.ReduceDomain(temp.GetRegion());
                }
                else
                {
                    return;
                }
                switch (type)
                {
                    case ModelType.形状模板:
                        ((HShapeModel)TempHandle).CreateScaledShapeModelXld(image.EdgesSubPix("canny", 1, 20, threshold),//边缘运算符,滤波器,低阈值，高阈值
                              "auto",                                                                                   //金字塔的层数，可设为“auto”或0—10的整数  5
                              Math.Round(starPhi * Math.PI / 180, 3),                                                   //模板旋转的起始角度     HTuple(-45).Rad()
                              Math.Round((overPhi - starPhi) * Math.PI / 180, 3),                                        //模板旋转角度范围, >=0     HTuple(360).Rad()
                              "auto",                                                                                    //旋转角度的步长， >=0 and <=pi/16   auto
                              minScale,                                                                                  //模板最小比例 0.9
                              maxScale,                                                                                  //模板最大比例   1.1
                              "auto",                                                                                    //模板比例的步长  "auto"
                              "auto",                                                                                    //设置模板优化和模板创建方法  none
                             REnum.EnumToStr(polar),                                                                     //匹配方法设置: ignore_color_polarity"忽略颜色极性  "ignore_global_polarity"忽视全部极性  "ignore_local_polarity"无视局部极性 "use_polarity"使用极性
                              5);
                        break;
                    case ModelType.灰度模板:
                        ((HNCCModel)TempHandle).CreateNccModel(image,
                              "auto",
                              Math.Round(starPhi * Math.PI / 180, 3),
                              Math.Round((overPhi - starPhi) * Math.PI / 180, 3),
                              "auto",
                              "use_polarity");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /// <summary>
        /// 查找最佳模板
        /// </summary>
        /// <param name="_Type">模板类型</param>
        /// <param name="_Model">模式</param>
        /// <param name="image">图片</param>
        /// <param name="_region">寻找区域</param>
        /// <param name="outCoord">输出坐标</param>
        public static int FindModel(ModelType type, HImage image, HHandle model, double minScore, int number, double maxOverl, double greedDeg, out Coord_Info outCoord)
        {
            outCoord = new Coord_Info();
            try
            {
                HTuple row, col, phi, scale, score;
                if (image.IsInitialized())
                {

                    if (type == ModelType.形状模板)
                    {
                        ((HShapeModel)model).FindScaledShapeModel(image,
                            Math.Round(FStarPhi * Math.PI / 180, 3),                     //模板旋转的起始角度     HTuple(-45).Rad()
                            Math.Round((FOverPhi - FStarPhi) * Math.PI / 180, 3),        //模板旋转角度范围, >=0     HTuple(360).Rad()
                            FMinScale,                                                   //模板最小比例 0.9
                            FMaxScale,                                                   //模板最大比例   1.0
                            minScore,                                                    //最小分数
                            number,                                                      //匹配数量
                            maxOverl,                                                    //最大重叠
                            "least_squares",                                             //亚像素模式
                            FLevers,                                                     //金字塔级别
                            greedDeg,                                                    //贪心算法
                            out row,                                                     //结果行
                            out col,                                                     //结果列
                            out phi,                                                     //结果角度
                            out scale,                                                   //相关性
                            out score);                                                  //匹配分数
                        if (score.Length > 0)
                        {
                            outCoord.Y = Math.Round(row[0].D, 4);
                            outCoord.X = Math.Round(col[0].D, 4);
                            outCoord.Phi = Math.Round(phi[0].D, 4);
                        }
                        return score.Length;
                    }
                    else if (type == ModelType.灰度模板)
                    {
                        HOperatorSet.FindNccModel(image, model, Math.Round(FStarPhi * Math.PI / 180, 3), Math.Round((FOverPhi - FStarPhi) * Math.PI / 180, 3), 0.8, 1, 0.5, "true", 0, out row, out col, out phi, out score);
                        if (score.Length > 0)
                        {
                            outCoord.Y = row[0].D;
                            outCoord.X = col[0].D;
                            outCoord.Phi = phi[0].D;
                        }
                        return score.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return 0;
        }

        /// <summary>
        /// 创建模板-金字塔等级,数值越大,细节越少,匹配时间越短,反之亦然
        /// </summary>
        /// <param name="_Type">模板类型</param>
        /// <param name="_Model">模板</param>
        /// <param name="image">图像</param>
        /// <param name="_region">模板区域</param>
        public static void CreateModel(ModelType mType, HImage image, ROI SearchRegion, ROI TempRegion, int Threshold, ref HHandle TempHandle, double StartPhi, double EndPhi)
        {
            try
            {
                HRegion _region = TempRegion.genRegion();
                if (_region.IsInitialized())
                {
                    image = image.ReduceDomain(_region);
                }
                switch (mType)
                {
                    case ModelType.形状模板:
                        ((HShapeModel)TempHandle).CreateScaledShapeModelXld(image.EdgesSubPix("canny", 1, 20, Threshold), //边缘运算符,滤波器,低阈值，高阈值
                              "auto",                                                          //金字塔的层数，可设为“auto”或0—10的整数  5
                              Math.Round(StartPhi * Math.PI / 180, 3),                         //模板旋转的起始角度     HTuple(-45).Rad()
                              Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),              //模板旋转角度范围, >=0     HTuple(360).Rad()
                              "auto",                                                          //旋转角度的步长， >=0 and <=pi/16   auto
                              0.9,                                                             //模板最小比例 0.9
                              1.1,                                                             //模板最大比例   1.1
                              "auto",                                                          //模板比例的步长  "auto"
                              "auto",                                                          //设置模板优化和模板创建方法  none
                              "use_polarity",                                                  //匹配方法设置: ignore_color_polarity"忽略颜色极性  "ignore_global_polarity"忽视全部极性  "ignore_local_polarity"无视局部极性 "use_polarity"使用极性
                              5);
                        break;
                    case ModelType.灰度模板:
                        ((HNCCModel)TempHandle).CreateNccModel(image,
                              "auto",
                              Math.Round(StartPhi * Math.PI / 180, 3),
                              Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),
                              "auto",
                              "use_polarity");
                        break;
                }
                //HImage m_image = image.ReduceDomain(TempRegion.genRegion());
                //((HShapeModel)TempHandle).CreateShapeModel(m_image,
                //                            "auto",
                //                             Math.Round(StartPhi * Math.PI / 180, 3),
                //                             Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),
                //                            "auto",
                //                            "auto",
                //                            "use_polarity",
                //                             Threshold,
                //                            "auto");
                //((HShapeModel)TempHandle).CreateScaledShapeModel(m_image,
                //    "auto",                                                   //金字塔的层数，可设为“auto”或0—10的整数  5 
                //    Math.Round(StartPhi * Math.PI / 180, 3),                 //模板旋转的起始角度     HTuple(-45).Rad()
                //    Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),     //模板旋转角度范围, >=0     HTuple(360).Rad()
                //    "auto",                                                   //旋转角度的步长， >=0 and <=pi/16   auto
                //    0.9,                                                      //模板最小比例 0.8
                //    1,                                                        //模板最大比例   1.0
                //    "auto",                                                   //模板比例的步长  "auto"
                //   "auto",                                                    //设置模板优化和模板创建方法  none
                //      "use_polarity",                                         //匹配方法设置  ignore_global_polarity
                //    Threshold,                                                    //设置对比度  40
                //   10);                                                       //设置最小对比度 10
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /// <summary>
        /// 查找最佳模板
        /// </summary>
        /// <param name="_Type">模板类型</param>
        /// <param name="_Model">模式</param>
        /// <param name="image">图片</param>
        /// <param name="_region">寻找区域</param>
        /// <param name="outCoord">输出坐标</param>
        public static int FindModel(ModelType _Type, HHandle _Model, double StartPhi, double EndPhi, double _MinScore, HImage image, ROI _roi, out Coord_Info outCoord)
        {
            int num = 0;
            outCoord = new Coord_Info();
            try
            {
                HTuple row, col, Phi, scale, score;
                if (image.IsInitialized())
                {
                    HRegion _region = _roi.genRegion();
                    if (_region.IsInitialized())
                    {
                        image = image.ReduceDomain(_region);
                    }
                    if (_Type == ModelType.形状模板)
                    {
                        ((HShapeModel)_Model).FindScaledShapeModel(image,
                            Math.Round(StartPhi * Math.PI / 180, 3),                    //模板旋转的起始角度     HTuple(-45).Rad()
                            Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),         //模板旋转角度范围, >=0     HTuple(360).Rad()
                            0.8,                                                         //模板最小比例 0.9
                            1.1,                                                         //模板最大比例   1.0
                            _MinScore,                                                   //最小分数
                            1,                                                           //匹配数量
                            0.5,                                                         //最大重叠
                            "least_squares",                                             //亚像素模式
                            0,                                                           //金字塔级别
                            0.8,                                                         //贪心算法
                            out row,                                                     //结果行
                            out col,                                                     //结果列
                            out Phi,                                                     //结果角度
                            out scale,                                                   //相关性
                            out score);                                                  //匹配分数
                        if (score.Length > 0)
                        {
                            outCoord.Y = Math.Round(row[0].D, 4);
                            outCoord.X = Math.Round(col[0].D, 4);
                            outCoord.Phi = Math.Round(Phi[0].D, 4);
                        }
                        num = score.Length;
                    }
                    else if (_Type == ModelType.灰度模板)
                    {
                        HOperatorSet.FindNccModel(image, _Model, Math.Round(StartPhi * Math.PI / 180, 3), Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3), 0.8, 1, 0.5, "true", 0, out row, out col, out Phi, out score);
                        if (score.Length > 0)
                        {
                            outCoord.Y = row[0].D;
                            outCoord.X = col[0].D;
                            outCoord.Phi = Phi[0].D;
                        }
                        num = score.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return num;
        }
        /// <summary>
        /// 查找模板多个
        /// </summary>
        /// <param name="image">图片</param>
        /// <param name="StartPhi">起始角度</param>
        /// <param name="EndPhi">结束角度</param>
        /// <param name="_ScaleMin">最小缩放比率</param>
        /// <param name="_ScaleMax">最大缩放比率</param>
        /// <param name="_MinScore">最小分数</param>
        /// <param name="_NumMatch">匹配数量</param>
        /// <param name="_MaxOverlap">最大重叠</param>
        /// <param name="_SubPixel">亚像素</param>
        /// <param name="_NumLevels">金字塔等级</param>
        /// <param name="_Greediness">贪心算法</param>
        /// <param name="_Type">模板类型</param>
        /// <param name="_Model">模式</param>
        /// <param name="_roi">寻找区域</param>
        /// <param name="outCoord">输出坐标</param>
        public static void FindModel(HImage image, double StartPhi, double EndPhi, double _ScaleMin, double _ScaleMax, double _MinScore, int _NumMatch, double _MaxOverlap, string _SubPixel, int _NumLevels, double _Greediness, ModelType _Type, HHandle _Model, ROI _roi, out Coord_Info[] outCoord)
        {
            outCoord = new Coord_Info[1];
            try
            {
                HTuple row, col, Phi, scale, score;
                if (image.IsInitialized())
                {
                    HRegion _region = _roi.genRegion();
                    if (_region.IsInitialized())
                    {
                        image = image.ReduceDomain(_region);
                    }
                    if (_Type == ModelType.形状模板)
                    {
                        HShapeModel[] mod = new HShapeModel[1];
                        mod[0] = (HShapeModel)_Model;
                        ((HShapeModel)_Model).FindScaledShapeModel(
                            image, //模板                           
                            Math.Round(StartPhi * Math.PI / 180, 3),//起始角度
                            Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),//角度范围
                            _ScaleMin,//最小缩放倍率
                            _ScaleMax,//最大缩放倍率
                            _MinScore, //最小分数
                            _NumMatch, //匹配个数
                            _MaxOverlap,//最大重叠
                            _SubPixel, //亚像素模式
                            _NumLevels,//金字塔等级
                            _Greediness, //贪心算法
                            out row, out col, out Phi, out scale, out score);
                        if (score.Length > 0)
                        {
                            outCoord = new Coord_Info[score.Length];
                            for (int i = 0; i < score.Length; i++)
                            {
                                outCoord[i].Y = row[i].D;
                                outCoord[i].X = col[i].D;
                                outCoord[i].Phi = Phi[i].D;
                            }
                        }
                        else
                        {
                            outCoord[0].Y = 1;
                            outCoord[0].X = 1;
                            outCoord[0].Phi = 1;
                        }
                    }
                    else if (_Type == ModelType.灰度模板)
                    {
                        ((HNCCModel)_Model).FindNccModel(image, Math.Round(StartPhi * Math.PI / 180, 3), Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3), 0.8, 1, 0.5, "true", 0, out row, out col, out Phi, out score);
                        if (score.Length > 0)
                        {
                            outCoord = new Coord_Info[score.Length];
                            for (int i = 0; i < score.Length; i++)
                            {
                                outCoord[i].Y = row[i].D;
                                outCoord[i].X = col[i].D;
                                outCoord[i].Phi = Phi[i].D;
                            }
                        }
                        else
                        {
                            outCoord[0].Y = 1;
                            outCoord[0].X = 1;
                            outCoord[0].Phi = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /// <summary>
        /// 查找模板
        /// </summary>
        /// <param name="_Type">模板类型</param>
        /// <param name="_Model">模式</param>
        /// <param name="image">图片</param>
        /// <param name="_region">寻找区域</param>
        /// <param name="outCoord">输出坐标</param>
        public static void FindModels(HImage image, double StartPhi, double EndPhi, double ScaleMin, double ScaleMax, double MinScore, int NumMatches, double MaxOverlap, string SubPixel, int NumLevels, double Greediness, ModelType _Type, HHandle _Model, ROI _roi, out Coord_Info[] outCoord)
        {
            outCoord = new Coord_Info[1];
            // double ScaleMax = 1;//最大比例
            // double ScaleMin = 0.9;//最小比例
            // double MinScore = 0.5;//最小分数
            // int NumMatches = 50;//查询个数
            // double MaxOverlap = 0.5;//覆盖比例
            // int NumLevels = 2;//金子塔模型层数
            try
            {
                HTuple row, col, Phi, scale, score, Model_index;
                if (image.IsInitialized())
                {
                    HRegion _region = _roi.genRegion();
                    if (_region.IsInitialized())
                    {
                        image = image.ReduceDomain(_region);
                    }
                    if (_Type == ModelType.形状模板)
                    {
                        HShapeModel[] mod = new HShapeModel[1];
                        mod[0] = (HShapeModel)_Model;
                        ((HShapeModel)_Model).FindScaledShapeModels(image, Math.Round(StartPhi * Math.PI / 180, 3), Math.Round((EndPhi - StartPhi) * Math.PI / 180, 3),
                            ScaleMin, ScaleMax, MinScore, NumMatches, MaxOverlap, SubPixel, NumLevels, Greediness, out row, out col, out Phi, out scale, out score, out Model_index);
                        if (score.Length > 0)
                        {
                            outCoord = new Coord_Info[score.Length];
                            for (int i = 0; i < score.Length; i++)
                            {
                                outCoord[i].Y = row[i].D;
                                outCoord[i].X = col[i].D;
                                outCoord[i].Phi = Phi[i].D;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public static void FindBarCorde(HImage img, HObject _SymbolXLDs, HTuple _DataCodeHandle, int _CordeNum, HTuple _CodeType, out HXLDCont _Corde2DXLD, out string _DecodedDataStrings)
        {
            string m_BarCorde = "Error";
            HObject m_SymbolXLDs = new HObject();
            HTuple m_DecodedDataStrings = new HTuple();
            m_DecodedDataStrings = "";
            HOperatorSet.FindBarCode(img, out m_SymbolXLDs, _DataCodeHandle, _CodeType, out m_DecodedDataStrings);
            _Corde2DXLD = new HRegion(m_SymbolXLDs);
            for (int i = 0; i < m_DecodedDataStrings.Length; ++i)
            {
                m_BarCorde += m_DecodedDataStrings[i] + "\r\n";
            }
            _DecodedDataStrings = m_BarCorde;
        }
        /// <summary>
        /// 二维码读取
        /// </summary>
        /// <param name="img">输入图像</param>
        /// <param name="_SymbolXLDs">轮廓</param>
        /// <param name="_DataCodeHandle">句柄</param>
        /// <param name="_Corde2DXLD">输出轮廓</param>
        /// <param name="_DecodedDataStrings">条码内容</param>
        /// <returns></returns>
        ///ToDo:二维码读取
        public static void FindCorde2D(HImage img, HObject _SymbolXLDs, HTuple _DataCodeHandle, int _CordeNum, HTuple _ResultHandles, out HXLDCont _Corde2DXLD, out string _DecodedDataStrings)
        {
            string m_Corde2D = "";
            HObject m_SymbolXLDs = new HObject();
            HTuple m_ResultHandles = new HTuple();
            HTuple m_DecodedDataStrings = new HTuple();
            m_DecodedDataStrings = "";
            HOperatorSet.FindDataCode2d(img, out m_SymbolXLDs, _DataCodeHandle, "stop_after_result_num", _CordeNum, out m_ResultHandles, out m_DecodedDataStrings);
            //HOperatorSet.FindDataCode2d(img, out m_SymbolXLDs, _DataCodeHandle, new HTuple(), new HTuple(6), out m_ResultHandles, out m_DecodedDataStrings);
            _Corde2DXLD = new HXLDCont(m_SymbolXLDs);
            for (int i = 0; i < m_DecodedDataStrings.Length; ++i)
            {
                m_Corde2D += m_DecodedDataStrings[i] + "\r\n";
            }
            _DecodedDataStrings = m_Corde2D;
        }
        /// <summary>
        /// 计算面积灰度
        /// </summary>
        /// <param name="MaxImage">搜索区域</param>
        /// <param name="MinImage">灰度图像</param>
        /// <param name="MinVPT">最小阈值</param>
        /// <param name="MaxVPT">最大阈值</param>
        /// <param name="Area">面积</param>
        /// <param name="Mean">平均灰度</param>
        /// <param name="Min">最小灰度</param>
        /// <param name="Max">最大灰度</param>
        /// <param name="Range">灰度范围</param>
        public static void FindLumaCheck(HImage MaxImage, HImage MinImage, double MinVPT, double MaxVPT, out double Area, out double Mean, out double Min, out double Max, out double Range, out HXLDCont hrange)
        {
          
            HOperatorSet.Intensity(MaxImage, MinImage, out HTuple mean, out HTuple deviation);
            HOperatorSet.MinMaxGray(MinImage, MaxImage,  0, out HTuple min, out HTuple max, out HTuple range);
            HOperatorSet.ReduceDomain(MinImage, MaxImage, out HObject IMagereduce);
            HOperatorSet.Threshold(IMagereduce, out HObject region, MinVPT, MaxVPT);
            HOperatorSet.AreaCenter(region, out HTuple area_max, out HTuple row, out HTuple column);


            hrange = new HXLDCont();
            Area = (double)area_max;//面积
            Mean = (double)mean; //平均灰度
            Min = (double)min; //最小灰度
            Max = (double)max; //最大灰度
            Range = (double)range; //灰度范围
        }



        /// <summary>
        /// 根据坐标重定位矩阵的位置
        /// </summary>
        /// <param name="inRectangleList">输入原始矩阵</param>
        /// <param name="inCoordInfo">坐标系</param>
        /// <param name="outRectangleList">输出像素矩阵</param>
        public static void RectPosition(RImage img, List<Rect2_Info> inRectangleList, Coord_Info inCoordInfo, out List<Rect2_Info> outRectangleList)
        {
            try
            {
                outRectangleList = new List<Rect2_Info>();
                HHomMat2D homMat2D = new HHomMat2D();
                homMat2D = homMat2D.HomMat2dRotateLocal(inCoordInfo.Phi);
                homMat2D = homMat2D.HomMat2dTranslate(inCoordInfo.X, inCoordInfo.Y);
                foreach (Rect2_Info r in inRectangleList)
                {
                    double x, y, row, col;
                    x = homMat2D.AffineTransPoint2d(r.CenterX, r.CenterY, out y);
                    Aff.WorldPlane2Point(img, x, y, out row, out col);
                    Rect2_Info temp_R = new Rect2_Info();
                    temp_R.CenterY = row;
                    temp_R.CenterX = col;
                    temp_R.Phi = r.Phi + inCoordInfo.Phi;
                    //temp_R.Length1 = r.Length1 / (img.ScaleX + img.ScaleY) / 2;
                    //temp_R.Length2 = r.Length2 / (img.ScaleX + img.ScaleY) / 2;
                    //此处错误  应该是行列的比例整体除以2  yoga 20180827
                    temp_R.Length1 = r.Length1 / ((img.ScaleX + img.ScaleY) / 2);
                    temp_R.Length2 = r.Length2 / ((img.ScaleX + img.ScaleY) / 2);
                    outRectangleList.Add(temp_R);
                }
            }
            catch (Exception ex)
            {
                outRectangleList = new List<Rect2_Info>();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 获取矩形框的值
        /// </summary>
        /// <param name="image">输入图像</param>
        /// <param name="inRectangleList">矩形阵列</param>
        /// <param name="inPreTreatMent">预处理</param>
        /// <param name="outRectInfo">返回Rect_Info列表</param>
        public static void QueryRectInfo(RImage image, List<Rect2_Info> inRectangleList, FilterMode inPreTreatMent, out List<RectRoiInfo> outRectInfo)
        {
            try
            {
                outRectInfo = new List<RectRoiInfo>();
                HRegion m_Region = new HRegion();
                var rowList = from datacell in inRectangleList select datacell.CenterY;
                var colList = from datacell in inRectangleList select datacell.CenterX;
                var phiList = from datacell in inRectangleList select datacell.Phi;
                var length1List = from datacell in inRectangleList select datacell.Length1;
                var length2List = from datacell in inRectangleList select datacell.Length2;
                m_Region.GenRectangle2(new HTuple(rowList.ToArray()), new HTuple(colList.ToArray()), new HTuple(phiList.ToArray()), new HTuple(length1List.ToArray()), new HTuple(length2List.ToArray()));
                int count = m_Region.CountObj();
                if (inPreTreatMent == FilterMode.无)
                {
                }
                else if (inPreTreatMent == FilterMode.均值滤波)
                {
                    image = RImage.ToRImage(image.MeanImage(3, 3));
                }
                else if (inPreTreatMent == FilterMode.中值滤波)
                {
                    image = RImage.ToRImage(image.MedianImage("circle", 1, "mirrored"));
                }
                else if (inPreTreatMent == FilterMode.高斯滤波)
                {
                    image = RImage.ToRImage(image.GaussFilter(3));
                }
                else if (inPreTreatMent == FilterMode.平滑滤波)
                {
                    image = RImage.ToRImage(image.SmoothImage("deriche2", 0.5));
                }
                for (int i = 0; i < count; i++)
                {
                    RectRoiInfo _RectInfo = new RectRoiInfo();
                    m_Region[i + 1].GetRegionPoints(out HTuple rows, out HTuple cols);
                    HTuple temp_values = image.GetGrayval(rows, cols);
                    _RectInfo.X = inRectangleList[i].CenterX * image.ScaleX;
                    _RectInfo.Y = inRectangleList[i].CenterY * image.ScaleY;
                    _RectInfo.Value_Avg = temp_values.TupleMean().D;
                    _RectInfo.Value_Median = temp_values.TupleMedian().D;
                    _RectInfo.Value_Max = temp_values.TupleMax().D;
                    _RectInfo.Value_Min = temp_values.TupleMin().D;
                    _RectInfo.X_List = cols.TupleMult(image.ScaleX).ToDArr().ToList();
                    _RectInfo.Y_List = rows.TupleMult(image.ScaleY).ToDArr().ToList();
                    _RectInfo.Value_List = temp_values.ToDArr().ToList();
                    outRectInfo.Add(_RectInfo);
                }
                m_Region.Dispose();
            }
            catch (Exception ex)
            {
                outRectInfo = new List<RectRoiInfo>();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 返回筛选后的数据列表，升序排列
        /// </summary>
        /// <param name="list">原始数据列表</param>
        /// <param name="type">筛选类型 max，mid，min</param>
        /// <param name="percent">百分比 0~1</param>
        /// <returns>返回筛选后的数据，升序排列 eg （list，“max”，0.8）排序后选出最大的80%数据</returns>
        public static List<double> QueryList(List<double> list, string type, double percent)
        {
            list.Sort();
            int per = (int)(list.Count * percent);
            per = per > 0 ? per : 1;
            if (type == "max")
                list = list.Skip((int)(list.Count * (1 - percent))).ToList();
            else if (type == "mid")
                //list = list.Skip((int)(list.Count * (1 - percent / 2))).Take((int)(list.Count * percent)).ToList();
                list = list.Skip((int)Math.Round(list.Count * ((1 - percent) / 2), MidpointRounding.ToEven)).Take(per).ToList();// magical 20171016原来的算法错误!,返回错误
            else if (type == "min")
                list = list.Take(per).ToList();
            return list;
        }
        /// <summary>
        /// 首次筛选异常点排除
        /// </summary>
        /// <param name="list">点集合</param>
        /// <returns>排除异常值-21474836的点</returns>
        public static List<double> DelList(List<double> list)
        {
            int i;
            List<double> templist = list.ToList();
            for (i = 0; i <= templist.Count - 1; i++)
            {
                if (templist[i] == -21474836)
                {
                    templist.RemoveAt(i);
                    i = i - 1;
                }
            }
            return templist;
        }
    }
    #endregion
    #region 信息显示
    /// <summary>信息显示</summary>
    public class Msg : ScriptMethodsDescription
    {
        [Category("函数"), Description(SleepDescription), DisplayName("int millisecond")]
        public void Sleep(int millisecond)
        {
            Thread.Sleep(millisecond);
        }
        /// <summary>
        /// 信息提示框
        /// </summary>
        /// <param name="s">提示信息</param>
        public static void Show(string s)
        {
            MessageBox.Show(s);
        }
    }
    #endregion
    #region TCP通讯
    /// <summary>TCP通讯</summary>
    public class Tcp
    {        /// <summary>
             /// 信息提示框
             /// </summary>
             /// <param name="s">提示信息</param>
        public static void Con(string s)
        {
            MessageBox.Show(s);
        }
    }
    #endregion
    #region COM通讯
    /// <summary>COM通讯</summary>
    public class Com
    {        /// <summary>
             /// 信息提示框
             /// </summary>
             /// <param name="s">提示信息</param>
        public static void Con(string s)
        {
            MessageBox.Show(s);
        }
    }
    #endregion
    #region PLC通讯 
    /// <summary>PLC通讯</summary>
    public class Plc
    {        /// <summary>
             /// 信息提示框
             /// </summary>
             /// <param name="s">提示信息</param>
        public static void Con(string s)
        {
            MessageBox.Show(s);
        }
    }
    #endregion
    #region 变量操作
    /// <summary>变量操作</summary>
    public class Var
    {
        /// <summary>验证输入字符串为数字-返回一个bool类型的值</summary>
        public static bool IsNumber(string strln)
        {
            return Regex.IsMatch(strln, "^([0]|([1-9]+\\d{0,}?))(.[\\d]+)?$");
        }
        /// <summary>
        /// 查到数据列表中的图像
        /// </summary>
        /// <param name="imCalVar">输入变量列表</param>
        /// <param name="outVarList">输出变量列表</param>
        public static void GetImage(List<DataCell> inVar, out List<DataCell> outVar)
        {
            IEnumerable<DataCell> result = from mDataCell in inVar
                                           where mDataCell.mDataMode == DataMode.图像
                                           select mDataCell;
            outVar = result.ToList();
        }
        /// <summary>
        /// 查到数据列表中的图像输出列表字符串
        /// </summary>
        /// <param name="imCalVar">输入变量列表</param>
        /// <param name="outVarList">输出变量列表</param>
        public static void GetImage(List<DataCell> inVar, out List<string> outVar)
        {
            outVar = new List<string>();
            IEnumerable<DataCell> result = from mDataCell in inVar
                                           where mDataCell.mDataMode == DataMode.图像
                                           select mDataCell;
            foreach (DataCell data in result)
            {
                outVar.Add(data.mModName);
            }
        }
        public static object GetImage(List<DataCell> inVar, string Name)
        {
            try
            {
                if (Name.Contains(":"))
                {
                    return (RImage)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue;
                }
                else
                {
                    Log.Error(Name + ": 查找名称错误！");
                    return null;
                }
            }
            catch
            {
                Log.Error(Name + ": 查找图像失败！");
                return null;
            }
        }
        /// <summary>
        /// 通过单元ID和名称查找变量列表
        /// </summary>
        /// <param name="imCalVar">输入列表</param>
        /// <param name="inVarName">变量名称</param>
        /// <param name="outList">输出变量列表</param>
        public static void GetVar(List<DataCell> inVar, string VarName, out List<DataCell> outVar)
        {
            try
            {
                outVar = new List<DataCell>();
                IEnumerable<DataCell> resultList = from mDataCell in inVar
                                                   where mDataCell.mDataName == VarName
                                                   select mDataCell;
                outVar = resultList.ToList();
            }
            catch (Exception ex)
            {
                outVar = new List<DataCell>();
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 更新全局变量列表中的值
        /// </summary>
        /// <param name="_CellID">单元ID</param>
        /// <param name="_DataName">变量名称</param>
        /// <param name="outValue">newValue</param>
        public static void SetVarList(ref List<DataCell> imCalVar, string _DataName, object outValue)
        {
            int index = imCalVar.FindIndex(e => e.mDataName.ToUpper() == _DataName.Trim().ToUpper());
            if (index > -1)
            {
                DataCell datacell = imCalVar[index];
                datacell.mDataValue = outValue;
                imCalVar[index] = datacell;
            }
        }
        /// <summary>
        /// 更新全局变量列表中的值
        /// </summary>
        /// <param name="imCalVar">列表</param>
        /// <param name="data">值</param>
        public static void SetVar(ref List<DataCell> imCalVar, DataCell data)
        {
            int index = imCalVar.FindIndex(e => e.mModIndex == data.mModIndex && e.mDataName == data.mDataName);
            if (index > -1)
                imCalVar[index] = data;
            else
                imCalVar.Add(data);
        }
        /// <summary>
        /// 获取连接数据
        /// </summary>
        /// <param name="Name">模块名称</param>
        /// <param name="DataName">数据名称</param>
        /// <returns></returns>
        public static string GetLinkData(List<DataCell> VarList, string NameMsg)
        {
            string Name = "", DataName = "", OutData = "0";
            if (!DataName.Contains(":"))
            {
                Name = NameMsg.Split(':')[0];
                DataName = NameMsg.Split(':')[1];
                OutData = Name + "|" + DataName + "|";
            }
            try
            {
                RImage mRImage = new RImage();
                RPoint mRPoint = new RPoint();
                ROILine mROILine = new ROILine();
                DataCell mDataCell = new DataCell();
                Cal_Info mCal_Info = new Cal_Info();
                Rtn_Info mRtn_Info = new Rtn_Info();
                HHomMat2D HomMat2D = new HHomMat2D();
                ROICircle mROICircle = new ROICircle();
                Char_Info mChar_Info = new Char_Info();
                PtoP_Info mPtoP_Info = new PtoP_Info();
                Luma_Info mLuma_Info = new Luma_Info();
                Coord_Info mCoord_Info = new Coord_Info();
                if (Name.Contains("全局变量"))
                {
                    if (DataName.Contains("测量标定"))
                    {
                        mDataCell = VarList.First(c => c.mModName.ToString() == DataName);
                        return OutData + mDataCell.mDataValue.ToString();
                    }
                    mDataCell = VarList.First(c => c.mDataName.ToString() == DataName);
                    return OutData + mDataCell.mDataValue.ToString();
                }
                else if(Name.Contains("变量定义"))
                {
                    mDataCell = VarList.First(c => c.mModName == Name & c.mDataName == DataName);
                    return OutData += mDataCell.mDataValue;
                }
                mDataCell = VarList.First(c => c.mModName == Name);
                switch (Name.Substring(0, 4))
                {
                    case "变量设置":
                    case "数据计算":
                        List<Char_Info> InfoList= (List<Char_Info>)VarList.First(c => c.mModName == Name).mDataValue;
                        mChar_Info = InfoList.First(c => c.Name ==DataName);
                        OutData += mChar_Info.Result;
                        break;
                    case "亮度检查":
                        mLuma_Info = (Luma_Info)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            default:
                                Dictionary<string, object> FieldList = GetFields(mLuma_Info);
                                OutData += FieldList[DataName].ToString();
                                break;
                        }
                        break;
                    case "创建文本":
                        mRtn_Info = (Rtn_Info)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            default:
                                Dictionary<string, object> FieldList = GetFields(mRtn_Info);
                                OutData += FieldList[DataName].ToString();
                                break;
                        }
                        break;
                    case "点点构建":
                        {
                            mPtoP_Info = (PtoP_Info)mDataCell.mDataValue;
                            switch (DataName)
                            {
                                default:
                                    Dictionary<string, object> FieldList = GetFields(mPtoP_Info);
                                    OutData += FieldList[DataName].ToString();
                                    break;
                            }
                            break;
                        }
                    case "点线构建":
                        {
                            double[] data = (double[])mDataCell.mDataValue;
                            OutData += data[data.Length - 1];
                            break;
                        }
                    case "线线距离":
                        OutData += mDataCell.mDataValue;
                        break;
                    case "创建区域":
                    case "图像采集":
                        mRImage = (RImage)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            case "Coord":
                                OutData += mCoord_Info.X.ToString("F4") + "," + mCoord_Info.Y.ToString("F4") + "," + mCoord_Info.Phi.ToString("F4");
                                break;
                            default:
                                Dictionary<string, object> FieldList = GetFields(mRImage);
                                OutData += FieldList[DataName].ToString();
                                break;
                        }
                        break;
                    case "模板匹配":
                    case "位置补正":
                        mCoord_Info = (Coord_Info)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            case "Coord":
                                OutData += mCoord_Info.X.ToString("F4") + "," + mCoord_Info.Y.ToString("F4") + "," + mCoord_Info.Phi.ToString("F4");
                                break;
                            default:
                                Dictionary<string, object> FieldList = GetFields(mCoord_Info);
                                OutData += FieldList[DataName].ToString();
                                break;
                        }
                        break;
                    case "圆心测量":
                        mROICircle = (ROICircle)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            case "Circle":
                                OutData += mROICircle.CenterX.ToString("F4") + "," + mROICircle.CenterY.ToString("F4") + "," + mROICircle.Radius.ToString("F4");
                                break;
                            default:
                                Dictionary<string, object> FieldList = GetFields(mROICircle);
                                OutData += FieldList[DataName].ToString();
                                break;
                        }
                        break;
                    case "拟合直线":
                    case "直线测量":
                        mROILine = (ROILine)mDataCell.mDataValue;
                        switch (DataName)
                        {
                            case "Line":
                                OutData += mROILine.StartX.ToString("F4") + "," + mROILine.StartY.ToString("F4") + "," + mROILine.EndX.ToString("F4") + "," + mROILine.EndY.ToString("F4") + "," + mROILine.MidX.ToString("F4") + "," + mROILine.MidY.ToString("F4") + "," + mROILine.Phi.ToString("F4");
                                break;
                            default:
                                Dictionary<string, object> FieldList = GetFields(mROILine);
                                if (FieldList[DataName].GetType().ToString() == "System.Double[]")
                                {
                                    double[] str = (double[])FieldList[DataName];
                                    for (int i = 0; i < str.Length; ++i)
                                    {
                                        OutData += str[i].ToString("F4") + ",";
                                    }
                                }
                                else
                                {
                                    OutData += FieldList[DataName];
                                }
                                break;
                        }
                        break;
                    case "仿射变换":
                    case "手臂控制":
                        {
                            mRPoint = (RPoint)mDataCell.mDataValue;
                            switch (DataName)
                            {
                                default:
                                    Dictionary<string, object> FieldList = GetFields(mRPoint);
                                    OutData += FieldList[DataName].ToString();
                                    break;
                            }
                            break;
                        }
                    case "N点标定":
                    case "九点标定":
                        {
                            mCal_Info = (Cal_Info)mDataCell.mDataValue;
                            switch (DataName)
                            {
                                case "BaselineX":
                                    OutData += mCal_Info.BaselineX.ToString("F4");
                                    break;
                                default:
                                    int lenght = Marshal.SizeOf(mCal_Info);
                                    Dictionary<string, object> FieldList = GetFields(mCal_Info);
                                    foreach (KeyValuePair<string, object> kvp in FieldList)
                                    {
                                        OutData += kvp.Value;
                                    }
                                    break;
                            }
                            break;
                        }
                    case "平移矩阵":
                    case "旋转矩阵":
                        HomMat2D = (HHomMat2D)mDataCell.mDataValue;
                        HomMat2D.HomMat2dToAffinePar(out double sy, out double phi, out double theta, out double tx, out double ty);
                        OutData += (phi * 180 / Math.PI).ToString("F6");
                        break;
                    default:
                        OutData += mDataCell.mDataValue;
                        break;
                }
                return OutData;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return OutData; }
        }
        /// <summary>
        /// 获取类中的属性
        /// </summary>
        /// <returns>所有属性名称</returns>
        public List<string> GetProperties<T>(T t)
        {
            List<string> ListStr = new List<string>();
            if (t == null)
            {
                return ListStr;
            }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties.Length <= 0)
            {
                return ListStr;
            }
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name; //名称
                object value = item.GetValue(t, null);  //值

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    ListStr.Add(name);
                }
                else
                {
                    GetProperties(value);
                }
            }
            return ListStr;
        }
        /// <summary>
        ///  获取类中的字段
        /// </summary>
        /// <returns>所有字段名称</returns>
        public static Dictionary<string, object> GetFields<T>(T t)
        {
            Dictionary<string, object> ListStr = new Dictionary<string, object>();
            if (t == null)
            {
                return ListStr;
            }
            FieldInfo[] fields = t.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (fields.Length <= 0)
            {
                return ListStr;
            }
            foreach (FieldInfo item in fields)
            {
                string name = item.Name; //名称
                object value = item.GetValue(t);  //值
                if (item.FieldType.IsValueType || item.FieldType.Name.StartsWith("String") || item.FieldType.Name.StartsWith("Boolean")|| item.FieldType.Name.StartsWith("Double"))
                {
                    ListStr.Add(name, value);
                }
                else if (item.FieldType.IsValueType || item.FieldType.Name.StartsWith("Double[]"))
                {
                    ListStr.Add(name, value);
                }
                else
                {
                    GetFields(value);
                }
            }
            return ListStr;
        }
        /// <summary>
        ///  获取类中的字段
        /// </summary>
        /// <returns>所有字段名称</returns>
        public static List<string> GetField<T>(T t)
        {

            List<string> ListStr = new List<string>();
            if (t == null)
            {
                return ListStr;
            }
            FieldInfo[] fields = t.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (fields.Length <= 0)
            {
                return ListStr;
            }
            foreach (FieldInfo item in fields)
            {
                string name = item.Name; //名称
                object value = item.GetValue(t);  //值

                if (item.FieldType.IsValueType || item.FieldType.Name.StartsWith("String") || item.FieldType.Name.StartsWith("Double[]") || item.FieldType.Name.StartsWith("Boolean"))
                {
                    ListStr.Add(name.Replace("<", "").Replace(">", "").Replace("k__BackingField", ""));
                }
                else
                {
                    GetFields(value);
                }
            }
            return ListStr;
        }
    }
    #endregion
    #region 距离计算
    /// <summary>距离计算</summary>
    public class Dis
    {
        /// <summary>
        /// 计算标准差
        /// </summary>
        /// <param name="array">标准差数组</param>
        /// <returns>返回标准差值</returns>
        public static double StandardDev(double[] array)
        {
            double dStdev = 0d;
            try
            {
                int N = array.Length;
                double sum = 0;//总和  
                double avg;//平均值  
                for (int i = 0; i < N; i++)
                {
                    sum += array[i];//求总和  
                }
                avg = sum / N;//计算平均值  
                double Spow = 0;
                for (int i = 0; i < N; i++)
                {
                    Spow += (array[i] - avg) * (array[i] - avg);//平方累加  
                }
                dStdev = Math.Sqrt(Spow / N);
                return dStdev;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return dStdev;
            }
        }
        /// <summary>
        /// 计算rms误差
        /// </summary>
        /// <param name="hom2d"></param>
        /// <param name="x_Image"></param>
        /// <param name="y_Image"></param>
        /// <param name="x_Robot"></param>
        /// <param name="y_Robot"></param>
        /// <returns></returns>
        public static double CalRMS(HHomMat2D hom2d, HTuple x_Image, HTuple y_Image, HTuple x_Robot, HTuple y_Robot)
        {
            try
            {
                double count = 0;
                for (int i = 0; i < x_Image.Length; i++)
                {
                    double tempX, tempY;
                    tempX = hom2d.HomMat2dInvert().AffineTransPoint2d(x_Robot[i].D, y_Robot[i].D, out tempY);
                    double dis = HMisc.DistancePp(tempY, tempX, y_Image[i], x_Image[i]);
                    count = count + dis * dis;
                }
                double RMS = Math.Sqrt(count / x_Image.Length);
                return RMS;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        /// <summary>点集合到线的距离</summary>
        public static void DisPL(List<double> rows, List<double> cols, ROILine Line1, out List<double> dis)
        {
            dis = new List<double>() { -999.999 };
            HTuple disT = HMisc.DistancePl(new HTuple(rows.ToArray()), new HTuple(cols.ToArray()), new HTuple(Line1.StartY), new HTuple(Line1.StartX), new HTuple(Line1.EndY), new HTuple(Line1.EndX));
            dis = disT.ToDArr().ToList();
        }
        /// <summary>点集合到线的距离</summary>
        public static double DisPL(double X, double Y, ROILine line)
        {
            return HMisc.DistancePl(X, Y, line.StartX, line.StartY, line.EndX, line.EndY);
        }
        /// <summary>点集合到线的距离</summary>
        public static double[] DisPL(double[] X, double[] Y, ROILine line)
        {
            double[] DisList = new double[X.Length];
            for (int i = 0; i < X.Length; i++)
            {
                DisList[i] = HMisc.DistancePl(X[i], Y[i], line.StartX, line.StartY, line.EndX, line.EndY);
            }
            return DisList;
        }
        /// <summary>点集合到线的距离</summary>
        public static double DisPL(RPoint point, ROILine line, ValueMode mode)
        {
            try
            {
                double[] DisList = new double[point.X1.Length];
                for (int i = 0; i < point.X1.Length; i++)
                {
                    DisList[i] = HMisc.DistancePl(point.X1[i], point.Y1[i], line.StartX, line.StartY, line.EndX, line.EndY);
                }
                switch (mode)
                {
                    case ValueMode.最大值:
                        return DisList.Max();
                    case ValueMode.最小值:
                        return DisList.Min();
                    case ValueMode.平均值:
                        return DisList.Average();
                }
            }
            catch { }
            return 0.0;
        }
        /// <summary>线线距离</summary>
        public static double DisLL(ROILine line1, ROILine line2, ValueMode mode)
        {
            HMisc.DistanceSl(line1.StartX, line1.StartY, line1.EndX, line1.EndY, line2.StartX, line2.StartY, line2.EndX, line2.EndY, out double Mindistance, out double Maxdistance);
            //HOperatorSet.DistanceCc(line1.GetXLD(), line2.GetXLD(), "point_to_point", out HTuple Mindistance, out HTuple Maxdistance);//point_to_segment
            switch (mode)
            {
                case ValueMode.最大值:
                    return Maxdistance;
                case ValueMode.最小值:
                    return Mindistance;
            }
            return 0;
        }
        /// <summary>计算两条直线的距离</summary>
        public static double DisLL(ROILine Line1, ROILine Line2)
        {
            ROILine line_C = new ROILine();
            //Line 向量夹角
            double L1 = (Line1.EndX - Line1.StartX) * (Line2.EndX - Line2.StartX) + (Line1.EndY - Line1.StartY) * (Line2.EndY - Line2.StartY);
            double L2 = Math.Sqrt(Math.Pow(Line1.EndX - Line1.StartX, 2) + Math.Pow(Line1.EndY - Line1.StartY, 2)) * Math.Sqrt(Math.Pow(Line2.EndX - Line2.StartX, 2) + Math.Pow(Line2.EndY - Line2.StartY, 2));
            double cosT = L1 / L2;
            if (Math.Abs(Math.Acos(cosT)) > Math.PI / 2)
            {
                line_C.StartY = (Line1.StartY + Line2.EndY) / 2;
                line_C.StartX = (Line1.StartX + Line2.EndX) / 2;
                line_C.EndY = (Line1.EndY + Line2.StartY) / 2;
                line_C.EndX = (Line1.EndX + Line2.StartX) / 2;
            }
            else
            {
                line_C.StartY = (Line1.StartY + Line2.StartY) / 2;
                line_C.StartX = (Line1.StartX + Line2.StartX) / 2;
                line_C.EndY = (Line1.EndY + Line2.EndY) / 2;
                line_C.EndX = (Line1.EndX + Line2.EndX) / 2;
            }
            double Distance1 = HMisc.DistancePl((Line1.StartY + Line1.EndY) / 2, (Line1.StartX + Line1.EndX) / 2, line_C.StartY, line_C.StartX, line_C.EndY, line_C.EndX);
            double Distance2 = HMisc.DistancePl((Line2.StartY + Line2.EndY) / 2, (Line2.StartX + Line2.EndX) / 2, line_C.StartY, line_C.StartX, line_C.EndY, line_C.EndX);
            return Distance1 + Distance2;
        }
        /// <summary>点集合到点集合的距离</summary>
        public static void DisPP(List<double> rows1, List<double> cols1, List<double> rows2, List<double> cols2, out List<double> dis)
        {
            dis = new List<double>();
            try
            {
                List<int> MinLenght = new List<int>();
                MinLenght.Add(rows1.Count);
                MinLenght.Add(cols1.Count);
                MinLenght.Add(rows2.Count);
                MinLenght.Add(cols2.Count);
                int index = MinLenght.Min();
                while (index < rows1.Count)
                {
                    rows1.RemoveAt(rows1.Count - 1);
                }
                while (index < cols1.Count)
                {
                    cols1.RemoveAt(cols1.Count - 1);
                }
                while (index < rows2.Count)
                {
                    rows2.RemoveAt(rows2.Count - 1);
                }
                while (index < cols2.Count)
                {
                    cols2.RemoveAt(cols2.Count - 1);
                }
                HTuple disT = HMisc.DistancePp(new HTuple(rows1.ToArray()), new HTuple(cols1.ToArray()), new HTuple(rows2.ToArray()), new HTuple(cols2.ToArray()));
                dis = disT.ToDArr().ToList();
            }
            catch (Exception ex)
            { }
        }
        /// <summary>点到点的距离</summary>
        public static double DisPP(double rows1, double cols1, double rows2, double cols2)
        {
            return HMisc.DistancePp(rows1, cols1, rows2, cols2);
        }
        /// <summary>点点距离</summary>
        public static double DisPP(RPoint point1, RPoint point2)
        {
            return HMisc.DistancePp(point1.X, point1.Y, point2.X, point2.Y);
        }
        /// <summary>两条直线交点</summary>
        /// <param name="isParallel">平行1，不平行0</param>
        public static void IntersectionLl(ROILine line1, ROILine line2, out double row, out double col, out int isParallel)
        {
            row = 0.0; col = 0.0; isParallel = 0;
            HMisc.IntersectionLl(line1.StartY, line1.StartX, line1.EndY, line1.EndX, line2.StartY, line2.StartX, line2.EndY, line2.EndX, out row, out col, out isParallel);
        }
        /// <summary>两条直线交点</summary>
        /// <param name="isParallel">平行1，不平行0</param>
        public static void IntersectionLc(ROILine line, ROICircle circle, out double row, out double col)
        {
            //HOperatorSet.IntersectionLineCircle(HTuple lineRow1, HTuple lineColumn1, HTuple lineRow2, HTuple lineColumn2, 
            //HTuple circleRow, HTuple circleColumn, HTuple circleRadius, HTuple circleStartPhi, HTuple circleEndPhi, HTuple circlePointOrder, out HTuple row, out HTuple column);
            HOperatorSet.IntersectionLineCircle(line.StartX, line.StartY, line.EndX, line.EndY,
                circle.CenterX, circle.CenterY, circle.Radius, circle.StartPhi, circle.EndPhi, "positive", out HTuple mRow, out HTuple mCol);
            row = mRow;
            col = mCol;
        }
        /// <summary>
        /// 求已知直线的垂线
        /// </summary>
        /// <param name="srcLine"></param>
        /// <returns>结果垂线</returns>
        public static ROILine VerticalLine(ROILine srcLine)
        {
            ROILine outLine = new ROILine();
            double rawx1 = srcLine.StartY;
            double rawy1 = srcLine.StartX;
            double rawx2 = srcLine.EndY;
            double rawy2 = srcLine.EndX;
            double k = 0;
            double minusy = rawy2 - rawy1;
            double minusx = rawx2 - rawx1;
            k = -1.0 / (minusy / minusx);
            double y1 = (rawy2 + rawy1) / 2.0;
            double x1 = (rawx2 + rawx1) / 2.0;
            double x2 = Math.Min(rawx1, rawx2) + Math.Abs(rawx1 - rawx2) / 4.0;
            double y2 = k * (x2 - x1) + y1;
            outLine.StartY = x1;
            outLine.StartX = y1;
            outLine.EndY = x2;
            outLine.EndX = y2;
            return outLine;
        }
        /// <summary>
        /// 计算两直线夹角
        /// </summary>
        /// <param name="Line1"></param>
        /// <param name="Line2"></param>
        /// <returns>返回弧度值</returns>
        public static double LLAngle(ROILine Line1, ROILine Line2)
        {
            HTuple angle = new HTuple();
            HOperatorSet.AngleLl(new HTuple(Line1.StartY), new HTuple(Line1.StartX), new HTuple(Line1.EndY), new HTuple(Line1.EndX),
                new HTuple(Line2.StartY), new HTuple(Line2.StartX), new HTuple(Line2.EndY), new HTuple(Line2.EndX), out angle);
            return angle[0].D;
        }
        /// <summary>求点到线的垂足</summary>
        /// <param name="inRow">点inRow，即y</param>
        /// <param name="inCol">点inCol，即x</param>
        /// <param name="srcLine">直线line</param>
        /// <param name="outY">垂足outY，即y</param>
        /// <param name="outX">垂足outX，即x</param>
        public static void PLPedal(double X, double Y, ROILine line, out double outY, out double outX, out double Dis)
        {
            HMisc.ProjectionPl(X, Y, line.StartX, line.StartY, line.EndX, line.EndY, out outX, out outY);
            Dis = HMisc.DistancePl(X, Y, line.StartX, line.StartY, line.EndX, line.EndY);
        }
        /// <summary>计算弧度</summary>
        public static double GenAngle(RPoint point1, RPoint point2)
        {
            return HMisc.AngleLx(point1.Y, point1.X, point2.Y, point2.X);
            ////两点的x、y值
            //double x = x1 - x2;
            //double y = y1 - y2;
            ////斜边长度
            //double hypotenuse = Math.Sqrt(Math.Pow(x, 2f) + Math.Pow(y, 2f));
            ////求出弧度
            //double cos = x / hypotenuse;
            //double Phi = Math.Acos(cos);
            //if (y < 0)
            //{
            //    Phi = -Phi;
            //}
            //else if ((y == 0) && (x < 0))
            //{
            //    Phi = Math.PI;
            //}
            //return Phi;
        }
        /// <summary>
        /// 通过RectList来计算平面度
        /// </summary>
        /// <param name="rectList">矩阵列表</param>
        /// <param name="type">计算方法 List-所有点参与计算 min-区域最小值参与计算 max-区域最大值参与计算 avg-区域平均值参与计算 med-区域中值参与计算 </param>
        /// <returns></returns>
        public static Plane_Info CalPlaneByRectList(List<RectRoiInfo> rectList, string type)
        {
            Plane_Info Plane = new Plane_Info();
            try
            {
                type = type.Trim().ToUpper();
                List<double> xList = new List<double>();
                List<double> yList = new List<double>();
                List<double> zList = new List<double>();
                if (type == "LIST")
                {
                    foreach (RectRoiInfo rect in rectList)
                    {
                        xList = xList.Concat(rect.X_List).ToList();
                        yList = yList.Concat(rect.Y_List).ToList();
                        zList = zList.Concat(rect.Value_List).ToList();
                    }
                }
                else
                {
                    foreach (RectRoiInfo rect in rectList)
                    {
                        xList.Add(rect.X);
                        yList.Add(rect.Y);
                        if (type == "MAX")
                            zList.Add(rect.Value_Max);
                        else if (type == "MIN")
                            zList.Add(rect.Value_Min);
                        else if (type == "AVG")
                            zList.Add(rect.Value_Avg);
                        else if (type == "MED")
                            zList.Add(rect.Value_Median);
                    }
                }
                Plane = Fit.FitPlane(xList, yList, zList);
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
            }
            return Plane;
        }
        /// <summary>
        ///  求两向量之间的夹角
        /// </summary>
        /// <param name="v1">  tagVector</param>
        /// <param name="v2">tagVector</param>
        /// <param name="LinePlane"></param>
        /// <returns> 0:表示两直线之间的夹角,其它值:表示如线与平面之间,平面与平面之间的夹角(0~90)</returns>
        public static double Intersect(TagVector v1, TagVector v2, long LinePlane = 0)
        {
            //LinePlane 0 :line -line ,1:line --Plane
            double tmp, tmpSqr1, tmpSqr2;
            tmp = (v1.a * v2.a + v1.b * v2.b + v1.c * v2.c);
            //'MsgBox tm
            tmpSqr1 = Math.Sqrt(v1.a * v1.a + v1.b * v1.b + v1.c * v1.c);
            tmpSqr2 = Math.Sqrt(v2.a * v2.a + v2.b * v2.b + v2.c * v2.c);
            if (tmpSqr1 != 0)
            {
                if (tmpSqr2 != 0)
                {
                    tmp = tmp / tmpSqr1 / tmpSqr2;
                }
                else
                {
                    tmp = tmp / tmpSqr1;
                }
            }
            else
            {
                if (tmpSqr2 != 0)
                    tmp = tmp / tmpSqr2;
                else
                    tmp = 0;
            }
            if (LinePlane != 0)
            {
                tmp = Math.Abs(tmp);
            }
            if (-tmp * tmp + 1 != 0)
            {
                tmp = Math.Atan(-tmp / Math.Sqrt(-tmp * tmp + 1)) + 2 * Math.Atan(1.0);
                tmp = tmp / Math.PI * 180;
            }
            else
            {
                tmp = 90;
            }
            return tmp;
        }
        /// <summary>
        /// 求点到平面的距离
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="Plane"></param>
        /// <returns>距离值</returns>
        public static double PointToPlane(double x, double y, double z, Plane_Info Plane)
        {
            double tmp = (Plane.ax * x + Plane.by * y + Plane.cz * z + Plane.d)
            / Math.Sqrt(Plane.ax * Plane.ax + Plane.by * Plane.by + Plane.cz * Plane.cz);
            return tmp;
        }
        /// <summary>
        /// 求两条边的中心基准线
        /// </summary>
        /// <param name="line1">输入直线1</param>
        /// <param name="line2">输入直线2</param>
        /// <returns>结果基准线</returns>
        public static ROILine middleLine(ROILine line1, ROILine line2)
        {
            try
            {
                double phi1 = HMisc.AngleLx(line1.StartY, line1.StartX, line1.EndY, line1.EndX);
                double phi2 = HMisc.AngleLx(line2.StartY, line2.StartX, line2.EndY, line2.EndX);
                double angle = Math.Abs(phi1 - phi1) * 180 / Math.PI;
                if (angle < 90 || angle > 270)
                {
                    double StartY = (line1.StartY + line2.StartY) / 2;
                    double StartX = (line1.StartX + line2.StartX) / 2;
                    double EndY = (line1.EndY + line2.EndY) / 2;
                    double EndX = (line1.EndX + line2.EndX) / 2;
                    ROILine outLine = new ROILine(StartY, StartX, EndY, EndX);
                    return outLine;
                }
                else
                {
                    double StartY = (line1.StartY + line2.EndY) / 2;
                    double StartX = (line1.StartX + line2.EndX) / 2;
                    double EndY = (line1.EndY + line2.StartY) / 2;
                    double EndX = (line1.EndX + line2.StartX) / 2;
                    ROILine outLine = new ROILine(StartY, StartX, EndY, EndX);
                    return outLine;
                }
            }
            catch (Exception ex)
            {
                return line1;
            }
        }
    }
    #endregion
    #region 拟合构建
    /// <summary>拟合构建</summary>
    public class Fit
    {
        /// <summary>
        /// 用最小二乘法拟合平面
        /// </summary>
        /// <param name="lstX">x坐标序列点</param>
        /// <param name="lstY">y坐标序列点</param>
        /// <param name="lstZ">z坐标序列点</param>
        /// <returns>结果平面</returns>
        public static Plane_Info FitPlane(List<double> lstX, List<double> lstY, List<double> lstZ)
        {
            Plane_Info Plane = new Plane_Info();
            try
            {
                if (lstX.Count != lstY.Count && lstY.Count != lstZ.Count && lstZ.Count < 3)
                    return Plane;
                int n = lstZ.Count;
                double x, y, z, XY, XZ, YZ;
                double X2, Y2;
                double a, b, c, d;
                double a1, b1, z1;
                double a2, b2, z2;
                TagVector n1;     //{.ax,by,1}  s1
                TagVector n2;     //{0,0,N} XY plane  s2
                TagVector n3;     //line Projed plane
                TagVector xLine, yLine, zLine, SLine;
                TagVector VectorPlane;
                xLine.a = 1;
                xLine.b = 0;
                xLine.c = 0;
                yLine.a = 0;
                yLine.b = 1;
                yLine.c = 0;
                zLine.a = 0;
                zLine.b = 0;
                zLine.c = 1;
                x = y = z = 0;
                XY = XZ = YZ = 0;
                X2 = Y2 = 0;
                for (int i = 0; i < n; i++)
                {
                    x += lstX[i];
                    y += lstY[i];
                    z += lstZ[i];
                    XY += lstX[i] * lstY[i];
                    XZ += lstX[i] * lstZ[i];
                    YZ += lstY[i] * lstZ[i];
                    X2 += lstX[i] * lstX[i];
                    Y2 += lstY[i] * lstY[i];
                }
                z1 = n * XZ - x * z;//              'e=z-Ax-By-C  z=Ax+By+D
                a1 = n * X2 - x * x;//
                b1 = n * XY - x * y;
                z2 = n * YZ - y * z;
                a2 = n * XY - x * y;
                b2 = n * Y2 - y * y;
                a = (z1 * b2 - z2 * b1) / (a1 * b2 - a2 * b1);
                b = (a1 * z2 - a2 * z1) / (a1 * b2 - a2 * b1);
                c = 1;
                d = (z - a * x - b * y) / n;
                Plane.x = x / n;
                Plane.y = y / n;
                Plane.z = z / n;
                //'sum(Mi *Ri)/sum(Mi) ,Mi is mass . here  Mi is seted to be 1 and .z is just the average of z
                Plane.ax = -a;
                Plane.by = -b;
                Plane.cz = 1;
                Plane.d = -d; //z=Ax+By+D-----Ax+By+Z+D=0
                VectorPlane.a = Plane.ax;
                VectorPlane.b = Plane.by;
                VectorPlane.c = 1;
                Plane.xAn = Dis.Intersect(VectorPlane, xLine);
                Plane.yAn = Dis.Intersect(VectorPlane, yLine);
                Plane.zAn = Dis.Intersect(VectorPlane, zLine);
                n1.a = Plane.ax;
                n1.b = Plane.by;
                n1.c = 1;
                SLine.a = Plane.ax;
                SLine.b = Plane.by;
                SLine.c = 0;
                Plane.Angle = Dis.Intersect(xLine, SLine);// (xLine.A * SLine.A + xLine.A * SLine.B + xLine.C * SLine.C)
                                                          //if (SLine.b < 0)
                {
                    Plane.Angle = 360 - Plane.Angle;
                    double MaxF = 0d, MinF = 0d, rDist = 0d;
                    double MinZ = 0d, MaxZ = 0d;
                    for (int i = 0; i < n; i++)
                    {
                        rDist = Dis.PointToPlane(lstX[i], lstY[i], lstZ[i], Plane);
                        if (i == 0)
                        {
                            MaxF = MinF = rDist;
                            MaxZ = MinZ = lstZ[i];
                        }
                        else
                        {
                            if (MaxF < rDist)
                                MaxF = rDist;
                            if (MinF > rDist)
                                MinF = rDist;
                            if (MaxZ < lstZ[i])
                                MaxZ = lstZ[i];
                            if (MinZ > lstZ[i])
                                MinZ = lstZ[i];
                        }
                    }
                    Plane.MaxFlat = MaxF;
                    Plane.MinFlat = MinF;
                    Plane.Flat = MaxF - MinF;
                    Plane.MinZ = MinZ;
                    Plane.MaxZ = MaxZ;
                }
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
            }
            return Plane;
        }
        /// <summary>
        /// 通过最小二乘法拟合直线，计算斜率k和截距b,该算法当k趋近于1时，b！=0
        /// </summary>
        /// <remarks>y位基准值，x为测量值</remarks>
        public static void CalSlopeAndIntercept(double[] x, double[] y, out double K, out double b)
        {
            try
            {
                if (x.Length == y.Length && x.Length > 1)
                {
                    int nCount = x.Length;
                    double SumX = default(double);
                    double SumY = default(double);
                    double SumXY = default(double);
                    double SumX2 = default(double);
                    double Slope = default(double);
                    double Intercept = default(double);
                    SumX = 0;
                    SumX2 = 0;
                    for (int i = 0; i <= nCount - 1; i++)
                    {
                        SumX += System.Convert.ToDouble(x[i]); //横坐标的和
                        SumX2 += x[i] * x[i]; //横坐标的平方的和
                    }
                    SumY = 0;
                    for (int i = 0; i <= nCount - 1; i++)
                    {
                        SumY += System.Convert.ToDouble(y[i]); //纵坐标的和
                    }
                    SumXY = 0;
                    for (int i = 0; i <= nCount - 1; i++)
                    {
                        SumXY += x[i] * y[i]; //横坐标乘以纵坐标的积的和
                    }
                    Intercept = System.Convert.ToDouble((SumX2 * SumY - SumX * SumXY) / (nCount * SumX2 - SumX * SumX)); //截距
                    Slope = System.Convert.ToDouble((nCount * SumXY - SumX * SumY) / (nCount * SumX2 - SumX * SumX)); //斜率
                    K = Slope;
                    b = Intercept;
                }
                else
                {
                    K = 1;
                    b = 0;
                }
            }
            catch (Exception ex)
            {
                K = 1; b = 0;
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// /使用halcon的拟合直线算法,比fitLine更准确,因为有其自己的剔除异常点算法
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <param name="line"></param>
        /// <returns>结果直线</returns>
        public static bool FitLine(List<double> rows, List<double> cols, out ROILine line)
        {
            line = new ROILine();
            try
            {
                Gen.SortPairs(ref rows, ref cols);
                HXLDCont lineXLD = new HXLDCont(new HTuple(rows.ToArray()), new HTuple(cols.ToArray()));
                lineXLD.FitLineContourXld("tukey", -1, 0, 5, 2, out double rowBegin, out double colBegin, out double rowEnd, out double colEnd, out double nr, out double nc, out double dist);//tukey剔除算法为halcon推荐算法
                line = new ROILine(Math.Round(rowBegin, 4), Math.Round(colBegin, 4), Math.Round(rowEnd, 4), Math.Round(colEnd, 4));
                return true;
            }
            catch (Exception)
            {
                line.Status = false;
                return false;
            }
        }
        public static bool FitLine(double X1, double Y1, double X2, double Y2, out ROILine line)
        {
            List<double> rows = new List<double> { X1, X2 };
            List<double> cols = new List<double> { Y1, Y2 };
            line = new ROILine();
            try
            {
                Gen.SortPairs(ref rows, ref cols);
                HXLDCont lineXLD = new HXLDCont(new HTuple(rows.ToArray()), new HTuple(cols.ToArray()));
                //tukey剔除算法为halcon推荐算法
                lineXLD.FitLineContourXld("tukey", -1, 0, 5, 2, out double rowBegin, out double colBegin, out double rowEnd, out double colEnd, out double nr, out double nc, out double dist);
                line = new ROILine(rowBegin, colBegin, rowEnd, colEnd);
                line.Phi = nc;
                line.Dist = dist;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 最小二乘法直线拟合
        /// </summary>
        /// <param name="xv">x点序列</param>
        /// <param name="zv">y点序列</param>
        /// <param name="num">个数</param>
        /// <param name="k">斜率</param>
        /// <param name="b">b</param>
        /// <returns></returns>
        public static bool FitLine(double[] xv, double[] zv, int num, out double k, out double b)
        {
            if (num < 3)
            {
                k = 0; b = 0;
                return false;
            }
            double A = 0.0;
            double B = 0.0;
            double C = 0.0;
            double D = 0.0;
            for (int i = 0; i < num; i++)
            {
                //ss.Format("i = %d,num = %d, %0.3f,%0.3f",i,num,xv[i],zv[i]);
                //AfxMessageBox(ss);
                A += (xv[i] * xv[i]);
                B += xv[i];
                C += (zv[i] * xv[i]);
                D += zv[i];
            }
            double tmp = 0;
            tmp = (A * num - B * B);
            if (Math.Abs(tmp) > 0.000001)
            {
                k = (C * num - B * D) / tmp;
                b = (A * D - C * B) / tmp;
            }
            else
            {
                k = 1;
                b = 0;
            }
            return true;
        }
        /// <summary>
        /// 最小二乘法圆拟合
        /// </summary>
        /// <param name="rows">点云 行坐标</param>
        /// <param name="cols">点云 列坐标</param>
        /// <param name="circle">返回圆</param>
        /// <returns>是否拟合成功</returns>
        public static bool FitCircle(double[] rows, double[] cols, out Circle_Info circle)
        {
            circle = new Circle_Info();
            if (cols.Length < 3)
            {
                return false;
            }
            //本地代码验证通过------20180827 yoga
            ////原始托管代码
            double sum_x = 0.0f, sum_y = 0.0f;
            double sum_x2 = 0.0f, sum_y2 = 0.0f;
            double sum_x3 = 0.0f, sum_y3 = 0.0f;
            double sum_xy = 0.0f, sum_x1y2 = 0.0f, sum_x2y1 = 0.0f;
            int N = cols.Length;
            for (int i = 0; i < N; i++)
            {
                double x = rows[i];
                double y = cols[i];
                double x2 = x * x;
                double y2 = y * y;
                sum_x += x;
                sum_y += y;
                sum_x2 += x2;
                sum_y2 += y2;
                sum_x3 += x2 * x;
                sum_y3 += y2 * y;
                sum_xy += x * y;
                sum_x1y2 += x * y2;
                sum_x2y1 += x2 * y;
            }
            double C, D, E, G, H;
            double a, b, c;
            C = N * sum_x2 - sum_x * sum_x;
            D = N * sum_xy - sum_x * sum_y;
            E = N * sum_x3 + N * sum_x1y2 - (sum_x2 + sum_y2) * sum_x;
            G = N * sum_y2 - sum_y * sum_y;
            H = N * sum_x2y1 + N * sum_y3 - (sum_x2 + sum_y2) * sum_y;
            a = (H * D - E * G) / (C * G - D * D);
            b = (H * C - E * D) / (D * D - G * C);
            c = -(a * sum_x + b * sum_y + sum_x2 + sum_y2) / N;
            circle.CenterY = Math.Round(a / (-2), 4);
            circle.CenterX = Math.Round(b / (-2), 4);
            circle.Radius = Math.Round(Math.Sqrt(a * a + b * b - 4 * c) / 2, 4);
            return true;
        }
        /// <summary>
        /// 最小二乘法圆拟合
        /// </summary>
        /// <param name="rows">点云 行坐标</param>
        /// <param name="cols">点云 列坐标</param>
        /// <param name="circle">返回圆</param>
        /// <returns>是否拟合成功</returns>
        public static bool FitCircle1(List<double> rows, List<double> cols, out ROICircle circle)
        {
            circle = new ROICircle();
            if (cols.Count < 3)
            {
                circle.Status = false;
                return false;
            }
            //本地代码验证通过------20180827 yoga
            ////原始托管代码
            double sum_x = 0.0f, sum_y = 0.0f;
            double sum_x2 = 0.0f, sum_y2 = 0.0f;
            double sum_x3 = 0.0f, sum_y3 = 0.0f;
            double sum_xy = 0.0f, sum_x1y2 = 0.0f, sum_x2y1 = 0.0f;
            int N = cols.Count;
            for (int i = 0; i < N; i++)
            {
                double x = rows[i];
                double y = cols[i];
                double x2 = x * x;
                double y2 = y * y;
                sum_x += x;
                sum_y += y;
                sum_x2 += x2;
                sum_y2 += y2;
                sum_x3 += x2 * x;
                sum_y3 += y2 * y;
                sum_xy += x * y;
                sum_x1y2 += x * y2;
                sum_x2y1 += x2 * y;
            }
            double C, D, E, G, H;
            double a, b, c;
            C = N * sum_x2 - sum_x * sum_x;
            D = N * sum_xy - sum_x * sum_y;
            E = N * sum_x3 + N * sum_x1y2 - (sum_x2 + sum_y2) * sum_x;
            G = N * sum_y2 - sum_y * sum_y;
            H = N * sum_x2y1 + N * sum_y3 - (sum_x2 + sum_y2) * sum_y;
            a = (H * D - E * G) / (C * G - D * D);
            b = (H * C - E * D) / (D * D - G * C);
            c = -(a * sum_x + b * sum_y + sum_x2 + sum_y2) / N;
            circle.CenterY = Math.Round(a / (-2), 4);
            circle.CenterX = Math.Round(b / (-2), 4);
            circle.Radius = Math.Round(Math.Sqrt(a * a + b * b - 4 * c) / 2, 4);
            return true;
        }
        /// <summary>
        /// refer: https://github.com/amlozano1/circle_fit/blob/master/circle_fit.py
        ///     # Run algorithm 1 in "Finding the circle that best fits a set of points" (2007) by L Maisonbobe, found at
        ///     # http://www.spaceroots.org/documents/circle/circle-fitting.pdf
        /// </summary>
        /// <param name="pts">A list of points</param>
        /// <param name="epsilon">A floating point value, if abs(delta) between a set of three points is less than this value, the set will
        /// be considered aligned and be omitted from the fit</param>
        /// <returns></returns>
        public static PointF FitCenter(List<PointF> pts, double epsilon = 0.1)
        {
            double totalX = 0, totalY = 0;
            int setCount = 0;
            for (int i = 0; i < pts.Count; i++)
            {
                for (int j = 1; j < pts.Count; j++)
                {
                    for (int k = 2; k < pts.Count; k++)
                    {
                        double delta = (pts[k].X - pts[j].X) * (pts[j].Y - pts[i].Y) - (pts[j].X - pts[i].X) * (pts[k].Y - pts[j].Y);
                        if (Math.Abs(delta) > epsilon)
                        {
                            double ii = Math.Pow(pts[i].X, 2) + Math.Pow(pts[i].Y, 2);
                            double jj = Math.Pow(pts[j].X, 2) + Math.Pow(pts[j].Y, 2);
                            double kk = Math.Pow(pts[k].X, 2) + Math.Pow(pts[k].Y, 2);
                            double cx = ((pts[k].Y - pts[j].Y) * ii + (pts[i].Y - pts[k].Y) * jj + (pts[j].Y - pts[i].Y) * kk) / (2 * delta);
                            double cy = -((pts[k].X - pts[j].X) * ii + (pts[i].X - pts[k].X) * jj + (pts[j].X - pts[i].X) * kk) / (2 * delta);
                            totalX += cx;
                            totalY += cy;
                            setCount++;
                        }
                    }
                }
            }
            if (setCount == 0)
            {
                //failed
                return PointF.Empty;
            }
            return new PointF((float)totalX / setCount, (float)totalY / setCount);
        }
    }
    #endregion
    #region 仿射变换
    /// <summary>仿射变换</summary>
    public class Aff
    {
        /// <summary>图片缩放</summary>
        public static HHomMat2D GetHomImg(double ScaleX, double ScaleY)
        {
            HHomMat2D hom = new HHomMat2D();
            hom = hom.HomMat2dScaleLocal(ScaleX, ScaleY);
            return hom;
        }
        /// <summary> 获取校正相机夹角和校正轴矩阵</summary>
        public static HHomMat2D GetAngle(double angle)
        {
            HHomMat2D homA = new HHomMat2D();
            homA = homA.HomMat2dRotateLocal(angle);//校正相机和轴夹角
            //homA = homA.HomMat2dSlantLocal(Y * Math.Sin(PhiY), "x");//校正XY轴夹角
            return homA;
        }
        /// <summary>
        /// 设置原点
        /// </summary>
        /// <param name="x">x坐标</param>
        /// <param name="y">y坐标</param>
        /// <param name="Phi">跟现有坐标弧度角</param>
        /// <returns></returns>
        public static HHomMat2D RstHomMat2D(double x, double y, double Phi)
        {
            HHomMat2D hom = new HHomMat2D();
            //本地代码验证通过------20180827 yoga
            try
            {
                hom = hom.HomMat2dRotateLocal(-Phi);
                hom = hom.HomMat2dTranslateLocal(-x, -y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            //HTuple homTmp;
            //Wrapper.Fun.setOrig(x, y, Phi, out homTmp);
            //hom = new HHomMat2D(homTmp);
            return hom;
        }
        /// <summary>
        /// 转换坐标点(世界坐标)
        /// </summary>
        /// <param name="hom">变换矩阵</param>
        /// <param name="lstX">输入Xlist</param>
        /// <param name="lstY">输入Ylist</param>
        /// <param name="outX">输出XList</param>
        /// <param name="outY">输出YList</param>
        public static void HomAffineTransPoints(HHomMat2D hom, List<double> lstX, List<double> lstY, out List<double> outX, out List<double> outY)
        {
            outX = new List<double>();
            outY = new List<double>();
            try
            {
                HTuple x = new HTuple();
                HTuple y = new HTuple();
                x = hom.AffineTransPoint2d(new HTuple(lstX.ToArray()), new HTuple(lstY.ToArray()), out y);
                outX = x.ToDArr().ToList();
                outY = y.ToDArr().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        /// <summary>
        /// 像素坐标转换为机械坐标和角度
        /// </summary>
        /// <param name="X">像素坐标x</param>
        /// <param name="Y">像素坐标y</param>
        /// <param name="Phi">像素坐标角度</param>
        /// <param name="hom9Calib">九点标定矩阵</param>
        /// <param name="homRoteCalib">选择中心标定矩阵</param>
        /// <param name="outX">输出机械坐标X</param>
        /// <param name="outY">输出机械坐标Y</param>
        /// <param name="outPhi">输出机械坐标角度</param>
        public static void Pixel2MachineCoord(double X, double Y, double Phi, HHomMat2D hom9Calib, HHomMat2D homRoteCalib, out double outX, out double outY, out double outPhi)
        {
            outX = 0f;
            outY = 0f;
            outPhi = 0f;
            try
            {
                HTuple pointAndPhi = new HTuple(X, Y, Phi);
                //本地代码验证通过------20180827 yoga
                //原始托管代码
                double tmpX, tmpY, tmpPhi;
                tmpX = hom9Calib.AffineTransPoint2d(X, Y, out tmpY);//图像坐标转换为世界坐标
                HHomMat2D hom = homRoteCalib.HomMat2dInvert();//反转变成世界坐标到机械坐标的转换
                outX = hom.AffineTransPoint2d(tmpX, tmpY, out outY);//世界坐标系到机械坐标系转换
                double sx, sy, angle, theta, tx, ty;
                sx = hom9Calib.HomMat2dToAffinePar(out sy, out angle, out theta, out tx, out ty);
                outPhi = angle + Phi;
            }
            catch (Exception ex)
            { }
        }
        /// <summary>
        /// 像素坐标转换为世界坐标和角度
        /// </summary>
        /// <param name="X">像素坐标x</param>
        /// <param name="Y">像素坐标y</param>
        /// <param name="Phi">像素坐标角度</param>
        /// <param name="hom9Calib">九点标定矩阵</param>
        /// <param name="outX">输出机械坐标X</param>
        /// <param name="outY">输出机械坐标Y</param>
        /// <param name="outPhi">输出机械坐标角度</param>
        public static void Pixel2WorldCoord(double X, double Y, double Phi, HHomMat2D hom9Calib, out double outX, out double outY, out double outPhi)
        {
            outX = 0f;
            outY = 0f;
            outPhi = 0f;
            try
            {
                //本地代码验证通过------20180827 yoga
                //原始托管代码
                outX = hom9Calib.AffineTransPoint2d(X, Y, out outY);//图像坐标转换为世界坐标
                double sx, sy, angle, theta, tx, ty;
                sx = hom9Calib.HomMat2dToAffinePar(out sy, out angle, out theta, out tx, out ty);
                outPhi = angle + Phi;
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 从当前像素坐标到目标像素坐标需要的转换
        /// </summary>
        /// <param name="fromX">当前世界坐标x</param>
        /// <param name="fromY">当前世界坐标y</param>
        /// <param name="fromPhi">当前世界坐标Phi</param>
        /// <param name="RoteCenterX">世界坐标旋转中心X</param>
        /// <param name="RoteCenterY">世界坐标旋转中心Y</param>
        /// <param name="aimX">目标世界坐标x</param>
        /// <param name="aimY">目标世界坐标y</param>
        /// <param name="aimPhi">目标世界坐标phi</param>
        /// <param name="offsetX">纠偏机械坐标offsetX</param>
        /// <param name="offsetY">纠偏机械坐标offsetY</param>
        /// <param name="offsetPhi">纠偏机械坐标offsetPhi</param>
        public static void CalCorrectionOffset(double fromX, double fromY, double fromPhi, double RoteCenterX, double RoteCenterY, double aimX, double aimY, double aimPhi, out double offsetX, out double offsetY, out double offsetPhi)
        {
            offsetX = 0f;
            offsetY = 0f;
            offsetPhi = 0f;
            try
            {
                //角度差
                offsetPhi = aimPhi - fromPhi;//弧度
                                             //根据旋转中心 旋转
                HHomMat2D hom_旋转中心旋转 = new HHomMat2D();
                hom_旋转中心旋转 = hom_旋转中心旋转.HomMat2dRotate(offsetPhi, RoteCenterX, RoteCenterY);
                double new_x;
                double new_y;
                new_x = hom_旋转中心旋转.AffineTransPoint2d(fromX, fromY, out new_y);
                //计算xy最终偏移
                offsetX = aimX - new_x;
                offsetY = aimY - new_y;
            }
            catch (Exception ex)
            { }
        }
        /// <summary>
        /// 建立仿射-对点应用任意加法2D变换使用
        /// </summary>
        public static HHomMat2D AffHomMat2D(double mFormX, double mFormY,double mFormPhi, double mToX, double mToY,double mToPhi)
        {
            HHomMat2D tempMat2D = new HHomMat2D();
            tempMat2D.VectorAngleToRigid(mFormX, mFormY,  0, mToX, mToY,  0);
            return  tempMat2D;
        }
        /// <summary>
        /// 对点应用任意加法 2D 变换
        /// </summary>
        public static void Affine2d(HTuple HomMat2D, double x0, double y0, out double X0, out double Y0)
        {
            HHomMat2D TempHomMat2D = new HHomMat2D(HomMat2D);
            Y0 = TempHomMat2D.AffineTransPoint2d(y0, x0, out X0);
        }
        /// <summary>
        /// 对点应用任意加法 2D 变换
        /// </summary>
        public static void Affine2d(HTuple HomMat2D, double x0, double y0, double x1, double y1, out double X0, out double Y0, out double X1, out double Y1)
        {
            HHomMat2D TempHomMat2D = new HHomMat2D(HomMat2D);
            Y0 = TempHomMat2D.AffineTransPoint2d(y0, x0, out X0);
            Y1 = TempHomMat2D.AffineTransPoint2d(y1, x1, out X1);
        }
        /// <summary>
        /// 图像旋转变换
        /// </summary>
        /// <param name="img"></param>
        /// <param name="ImgAdjustMode"></param>
        /// <returns></returns>
        public static HImage AffineImage(HImage img, ImageAdjust ImgAdjustMode)
        {
            HImage tempImg = new HImage();
            switch (ImgAdjustMode)
            {
                case ImageAdjust.None:
                    tempImg = img.Clone();
                    break;
                case ImageAdjust.垂直镜像:
                    tempImg = img.MirrorImage("row");
                    break;
                case ImageAdjust.水平镜像:
                    tempImg = img.MirrorImage("column");
                    break;
                case ImageAdjust.顺时针90度:
                    tempImg = img.RotateImage(270.0, "nearest_neighbor");
                    break;
                case ImageAdjust.逆时针90度:
                    tempImg = img.RotateImage(90.0, "nearest_neighbor");
                    break;
                case ImageAdjust.旋转180度:
                    tempImg = img.RotateImage(180.0, "nearest_neighbor");
                    break;
            }
            return tempImg;
        }
        /// <summary>
        /// 根据位置变换直线坐标
        /// </summary>
        /// <param name="homMat">变换关系</param>
        /// <param name="line">直线</param>
        public static ROILine AffineLine(HHomMat2D homMat, ROILine line)
        {
            ROILine outLine = new ROILine();
            double row, col;
            row = homMat.AffineTransPoint2d(line.StartY, line.StartX, out col);
            outLine.StartY = row;
            outLine.StartX = col;
            row = homMat.AffineTransPoint2d(line.EndY, line.EndX, out col);
            outLine.EndY = row;
            outLine.EndX = col;
            return outLine;
        }
        /// <summary>
        /// 根据位置变换圆
        /// </summary>
        /// <param name="homMat">变换关系</param>
        /// <param name="circle">圆</param>
        /// <returns>结果圆</returns>
        public static Circle_Info AffineCircle(HHomMat2D homMat, Circle_Info circle)
        {
            Circle_Info outCircle = new Circle_Info();
            double row, col, Phi;
            row = homMat.AffineTransPoint2d(circle.CenterY, circle.CenterX, out col);
            Phi = ((HTuple)homMat[0]).TupleAcos().D;
            outCircle.Radius = circle.Radius;
            outCircle.CenterY = row;
            outCircle.CenterX = col;
            outCircle.StartPhi = circle.StartPhi + Phi;
            outCircle.EndPhi = circle.EndPhi + Phi;
            return outCircle;
        }
        /// <summary>
        /// 根据位置变换椭圆
        /// </summary>
        /// <param name="homMat">变换关系</param>
        /// <param name="ellipse">椭圆</param>
        /// <returns>结果椭圆</returns>
        public static Ellipse_Info AffineEllipse(HHomMat2D homMat, Ellipse_Info ellipse)
        {
            Ellipse_Info outEllipse = new Ellipse_Info();
            double row, col, Phi;
            row = homMat.AffineTransPoint2d(ellipse.CenterY, ellipse.CenterX, out col);
            Phi = ((HTuple)homMat[0]).TupleAcos().D;
            outEllipse.Radius1 = ellipse.Radius1;
            outEllipse.Radius2 = ellipse.Radius2;//修复bug magical20170821 原来都是Radius1
            outEllipse.CenterY = row;
            outEllipse.CenterX = col;
            outEllipse.Phi = ellipse.Phi + Phi;
            return outEllipse;
        }
        /// <summary>
        /// 根据位置变换矩形
        /// </summary>
        /// <param name="homMat">变换关系</param>
        /// <param name="rect">矩阵</param>
        public static Rect2_Info AffineRectangle2(HHomMat2D homMat, Rect2_Info rect)
        {
            Rect2_Info outRect = new Rect2_Info();
            double row, col, Phi;
            row = homMat.AffineTransPoint2d(rect.CenterY, rect.CenterX, out col);
            Phi = ((HTuple)homMat[0]).TupleAcos().D;
            outRect.Length1 = rect.Length1;
            outRect.Length2 = rect.Length2;
            outRect.CenterY = row;
            outRect.CenterX = col;
            outRect.Phi = rect.Phi + Phi;
            return outRect;
        }
        /// <summary>
        /// 转换直线，与图像边缘交点
        /// </summary>
        /// <param name="Width">图像宽度</param>
        /// <param name="Height">图像高度</param>
        /// <param name="line">输入直线</param>
        /// <param name="moveRow">平移行坐标</param>
        /// <param name="moveCol">平移列坐标</param>
        /// <param name="outLine">输出直线</param>
        public static void TransLine(int Width, int Height, ROILine line, double moveRow, double moveCol, out ROILine outLine)
        {
            outLine = line;
            try
            {
                double[] row = { 0, Height, Height, 0, 0 };
                double[] col = { 0, 0, Width, Width, 0 };
                HXLDCont xld = new HXLDCont();
                HTuple outY = new HTuple();
                HTuple outX = new HTuple();
                HTuple IsOverlapping = new HTuple();
                //平移
                line.StartY += moveRow;
                line.StartX += moveCol;
                line.EndY += moveRow;
                line.EndX += moveCol;
                xld.GenContourPolygonXld(new HTuple(row), new HTuple(col));
                HOperatorSet.IntersectionLineContourXld(xld, line.StartY, line.StartX, line.EndY, line.EndX, out outY, out outX, out IsOverlapping);
                if (outY.Length > 0)
                {
                    outLine = new ROILine(outY[0].D, outX[0].D, outY[1].D, outX[1].D);
                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 点转换为世界坐标
        /// </summary>
        /// <param name="Calib">相机标定参数</param>
        /// <param name="rows">行序列</param>
        /// <param name="cols">列序列</param>
        /// <param name="X">输出 X</param>
        /// <param name="Y">输出 Y</param>
        public static void ConvPix2World(List<double> Calib, List<double> rows, List<double> cols, out List<double> X, out List<double> Y)
        {
            X = new List<double>();
            Y = new List<double>();
            HTuple _x = new HTuple();
            HTuple _y = new HTuple();
            try
            {
                HTuple CamPar = new HTuple(Calib.Take(8).ToArray());
                HTuple CamPose = new HTuple();
                for (int i = 8; i < Calib.Count; i++)
                {
                    CamPose.Append(new HTuple(Calib[i]));
                }
                //18此函数取消
                //HMisc.ImagePointsToWorldPlane(CamPar, new HPose(CamPose), new HTuple(rows.ToArray()), new HTuple(cols.ToArray()), "mm", out _x, out _y);
                HOperatorSet.ImagePointsToWorldPlane(CamPar, new HPose(CamPose), new HTuple(rows.ToArray()), new HTuple(cols.ToArray()), "mm", out _x, out _y);
                X = _x.DArr.ToList();
                Y = _y.DArr.ToList();
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 图像坐标点转换为世界坐标点
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="rows">输入坐标行</param>
        /// <param name="cols">输入坐标列</param>
        /// <param name="wX">输出世界坐标行</param>
        /// <param name="wY">输出世界坐标列</param>
        public static void Points2WorldPlane(RImage img, List<double> rows, List<double> cols, out List<double> wX, out List<double> wY)
        {
            wX = new List<double>();
            wY = new List<double>();
            try
            {
                HTuple xImg, yImg;
                double xAxis, yAxis;
                //相机缩放比率校正
                //xImg = img.getHomImg().AffineTransPoint2d(new HTuple(cols.ToArray()), new HTuple(rows.ToArray()), out yImg);
                Pixel2WorldPlane(img, rows, cols, out xImg, out yImg);
                xAxis = img.GetAngle().AffineTransPoint2d(img.X, img.Y, out yAxis);
                wX = xImg.TupleAdd(xAxis).ToDArr().ToList();
                wY = yImg.TupleAdd(yAxis).ToDArr().ToList();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 图像坐标点转换为世界坐标点
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="row">输入坐标行</param>
        /// <param name="col">输入坐标列</param>
        /// <param name="wX">输出世界坐标行</param>
        /// <param name="wY">输出世界坐标列</param>
        public static void Points2WorldPlane(RImage img, double row, double col, out double wX, out double wY)
        {
            wX = 0f;
            wY = 0f;
            try
            {
                double xImg, yImg;
                double xAxis, yAxis;
                //相机缩放比率校正
                //xImg = img.getHomImg().AffineTransPoint2d(new HTuple(cols.ToArray()), new HTuple(rows.ToArray()), out yImg);
                Pixel2WorldPlane(img, row, col, out xImg, out yImg);
                xAxis = img.GetAngle().AffineTransPoint2d(img.X, img.Y, out yAxis);
                wX = xImg + xAxis;
                wY = yImg + yAxis;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 直线转换世界坐标系
        /// </summary>
        /// <param name="img">图片信息</param>
        /// <param name="line">输入直线</param>
        /// <returns>返回世界坐标系直线</returns>
        public static ROILine Line2WorldPlane(RImage img, ROILine line)
        {
            ROILine outLine = new ROILine();
            try
            {
                Points2WorldPlane(img, line.StartY, line.StartX, out outLine.StartX, out outLine.StartY);
                Points2WorldPlane(img, line.EndY, line.EndX, out outLine.EndX, out outLine.EndY);
                outLine = new ROILine(outLine.StartY, outLine.StartX, outLine.EndY, outLine.EndX);
                return outLine;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outLine;
            }
        }
        /// <summary>
        /// 矩形转换成世界坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="inRectangle2">输入矩形</param>
        /// <returns>返回世界坐标系矩形</returns>
        public static ROIRectangle2 Rectangle2WorldPlane(RImage img, ROIRectangle2 inRectangle2)
        {
            ROIRectangle2 outRectangle2 = new ROIRectangle2();
            try
            {
                Points2WorldPlane(img, inRectangle2.midR, inRectangle2.midC, out inRectangle2.midR, out inRectangle2.midC);
                outRectangle2.phi = inRectangle2.phi * (img.ScaleY + img.ScaleX) / 2;
                return outRectangle2;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outRectangle2;
            }
        }
        /// <summary>
        /// 圆转换成世界坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="circel">输入圆</param>
        /// <returns>返回世界坐标系圆</returns>
        public static Circle_Info Circle2WorldPlane(RImage img, Circle_Info circel)
        {
            Circle_Info outCircle = new Circle_Info();
            try
            {
                Points2WorldPlane(img, circel.CenterY, circel.CenterX, out outCircle.CenterX, out outCircle.CenterY);
                outCircle.Radius = circel.Radius * (img.ScaleY + img.ScaleX) / 2;
                return outCircle;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outCircle;
            }
        }
        /// <summary>
        /// 圆转换成世界坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="circel">输入圆</param>
        /// <returns>返回世界坐标系圆</returns>
        public static ROICircle Circle2WorldPlane(RImage img, ROICircle circel)
        {
            ROICircle outCircle = new ROICircle();
            try
            {
                Points2WorldPlane(img, circel.CenterY, circel.CenterX, out outCircle.CenterX, out outCircle.CenterY);
                outCircle.Radius = circel.Radius * (img.ScaleY + img.ScaleX) / 2;
                return outCircle;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outCircle;
            }
        }
        /// <summary>
        /// 椭圆转换成世界坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="circel">输入椭圆</param>
        /// <returns>返回世界坐标系椭圆</returns>
        public static Ellipse_Info Ellipse2WorldPlane(RImage img, Ellipse_Info inEllipse)
        {
            Ellipse_Info outEllipse = new Ellipse_Info();
            try
            {
                Points2WorldPlane(img, inEllipse.CenterY, inEllipse.CenterX, out outEllipse.CenterX, out outEllipse.CenterY);
                outEllipse.Radius1 = inEllipse.Radius1 * (img.ScaleY + img.ScaleX) / 2;
                outEllipse.Radius2 = inEllipse.Radius2 * (img.ScaleY + img.ScaleX) / 2;
                return outEllipse;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outEllipse;
            }
        }
        /// <summary>
        /// 图像坐标点转换为mm坐标点，使用区域标定的方法
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="rows">输入坐标行</param>
        /// <param name="cols">输入坐标列</param>
        /// <param name="X">输出mm坐标行</param>
        /// <param name="Y">输出mm坐标列</param>
        public static void Pixel2WorldPlane(RImage img, List<double> rows, List<double> cols, out HTuple X, out HTuple Y)
        {
            X = new HTuple();
            Y = new HTuple();
            try
            {
                double xImg, yImg;
                //缩放校正
                for (int i = 0; i < rows.Count; i++)
                {
                    if (img.IsCal)
                    {
                        HTuple row = HTuple.TupleGenConst(img.BoardRow.Length, rows[i]);
                        HTuple col = HTuple.TupleGenConst(img.BoardRow.Length, cols[i]);
                        HTuple distance = HMisc.DistancePp(row, col, img.BoardRow, img.BoardCol);
                        int index = distance.TupleFindFirst(distance.TupleMin()).I;
                        xImg = img.BoardX[index].D + (cols[i] - img.BoardCol[index].D) * img.ScaleX;
                        yImg = img.BoardY[index].D + (rows[i] - img.BoardRow[index].D) * img.ScaleY;
                    }
                    else
                    {
                        xImg = cols[i] * img.ScaleX;
                        yImg = rows[i] * img.ScaleY;
                    }
                    X = X.TupleConcat(xImg);
                    Y = Y.TupleConcat(yImg);
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 图像坐标点转换为mm坐标
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="row">输入坐标行</param>
        /// <param name="col">输入坐标列</param>
        /// <param name="wX">输出mm坐标行</param>
        /// <param name="wY">输出mm坐标列</param>
        public static void Pixel2WorldPlane(RImage img, double row, double col, out double X, out double Y)
        {
            X = 0f; Y = 0f;
            try
            {
                if (img.IsCal)
                {
                    //缩放校正
                    HTuple rows = HTuple.TupleGenConst(img.BoardRow.Length, row);
                    HTuple cols = HTuple.TupleGenConst(img.BoardRow.Length, col);
                    HTuple distance = HMisc.DistancePp(rows, cols, img.BoardRow, img.BoardCol);
                    int index = distance.TupleFindFirst(distance.TupleMin()).I;
                    X = img.BoardX[index].D + (col - img.BoardCol[index].D) * img.ScaleX;
                    Y = img.BoardY[index].D + (row - img.BoardRow[index].D) * img.ScaleY;
                }
                else
                {
                    X = col * img.ScaleX;
                    Y = row * img.ScaleY;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// mm坐标转换为图像坐标
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="X">当前图像mm坐标X</param>
        /// <param name="Y">当前图像mm坐标Y</param>
        /// <param name="row">图像坐标row</param>
        /// <param name="col">图像坐标col</param>
        public static void ImagePlane2Pixel(RImage img, double X, double Y, out double row, out double col)
        {
            row = 0f; col = 0f;
            try
            {
                if (img.IsCal)
                {
                    //缩放校正
                    HTuple Xs = HTuple.TupleGenConst(img.BoardRow.Length, X);
                    HTuple Ys = HTuple.TupleGenConst(img.BoardRow.Length, Y);
                    HTuple distance = HMisc.DistancePp(Xs, Ys, img.BoardX, img.BoardY);
                    int index = distance.TupleFindFirst(distance.TupleMin()).I;
                    col = img.BoardCol[index].D + (X - img.BoardX[index].D) / img.ScaleX;
                    row = img.BoardRow[index].D + (Y - img.BoardY[index].D) / img.ScaleY;
                }
                else
                {
                    col = X / img.ScaleX;
                    row = Y / img.ScaleY;
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 世界坐标转换为当前图像的像素坐标
        /// </summary>
        /// <param name="img">坐标信息图像</param>
        /// <param name="wX">世界坐标X</param>
        /// <param name="wY">世界坐标Y</param>
        /// <param name="row">图像坐标row</param>
        /// <param name="col">图像坐标col</param>
        public static void WorldPlane2Point(RImage img, double wX, double wY, out double row, out double col)
        {
            row = 0f; col = 0f;
            double xImg, yImg;
            try
            {
                double xAxis, yAxis;
                xAxis = img.GetAngle().AffineTransPoint2d(img.X, img.Y, out yAxis);
                xImg = wX - xAxis;
                yImg = wY - yAxis;
                ImagePlane2Pixel(img, xImg, yImg, out row, out col);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
        /// <summary>
        /// 直线转换世界坐标系
        /// </summary>
        /// <param name="img">图片信息</param>
        /// <param name="line">输入世界坐标直线</param>
        /// <returns>返回图像坐标系直线</returns>
        public static ROILine Line2PixelPlane(RImage img, ROILine line)
        {
            ROILine outLine = new ROILine();
            try
            {
                WorldPlane2Point(img, line.StartX, line.StartY, out outLine.StartY, out outLine.StartX);
                WorldPlane2Point(img, line.EndX, line.EndY, out outLine.EndY, out outLine.EndX);
                outLine = new ROILine(outLine.StartY, outLine.StartX, outLine.EndY, outLine.EndX);
                return outLine;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outLine;
            }
        }
        /// <summary>
        /// 世界坐标矩形转换成当前图像坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="inRectangle2">输入矩形</param>
        /// <returns>返回当前图像坐标系矩形</returns>
        public static Rect2_Info Rectangle2PixelPlane(RImage img, Rect2_Info inRectangle2)
        {
            Rect2_Info outRectangle2 = new Rect2_Info();
            try
            {
                WorldPlane2Point(img, inRectangle2.CenterX, inRectangle2.CenterY, out outRectangle2.CenterY, out outRectangle2.CenterX);
                outRectangle2.Phi = inRectangle2.Phi * 2 / (img.ScaleY + img.ScaleX);
                return outRectangle2;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outRectangle2;
            }
        }
        /// <summary>
        /// 世界坐标圆转换成当前图像坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="circel">输入圆</param>
        /// <returns>返回当前图像坐标系圆</returns>
        public static Circle_Info Circle2PixelPlane(RImage img, Circle_Info circel)
        {
            Circle_Info outCircle = new Circle_Info();
            try
            {
                WorldPlane2Point(img, circel.CenterX, circel.CenterY, out outCircle.CenterY, out outCircle.CenterX);
                outCircle.Radius = circel.Radius * 2 / (img.ScaleY + img.ScaleX);
                return outCircle;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outCircle;
            }
        }
        /// <summary>
        /// 世界坐标圆转换成当前图像坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="circel">输入圆</param>
        /// <returns>返回当前图像坐标系圆</returns>
        public static ROICircle Circle2PixelPlane(RImage img, ROICircle circel)
        {
            ROICircle outCircle = new ROICircle();
            try
            {
                WorldPlane2Point(img, circel.CenterX, circel.CenterY, out outCircle.CenterY, out outCircle.CenterX);
                outCircle.Radius = circel.Radius * 2 / (img.ScaleY + img.ScaleX);
                return outCircle;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outCircle;
            }
        }
        /// <summary>
        /// 世界坐标系椭圆转换成图像坐标系
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="inEllipse">输入椭圆</param>
        /// <returns>返回当前图像坐标系椭圆</returns>
        public static Ellipse_Info Ellipse2PixelPlane(RImage img, Ellipse_Info inEllipse)
        {
            Ellipse_Info outEllipse = new Ellipse_Info();
            try
            {
                WorldPlane2Point(img, inEllipse.CenterX, inEllipse.CenterY, out outEllipse.CenterY, out outEllipse.CenterX);
                outEllipse.Radius1 = inEllipse.Radius1 * 2 / (img.ScaleY + img.ScaleX);
                outEllipse.Radius2 = inEllipse.Radius2 * 2 / (img.ScaleY + img.ScaleX);
                return outEllipse;
            }
            catch (Exception ex)
            {
                RLog.Instance.VTLogError(ex.ToString());
                return outEllipse;
            }
        }
    }
    #endregion
    #region 综合函数
    /// <summary>综合函数</summary>
    public class Gen
    {
        /// <summary>
        /// 获取坐标中心箭头-长
        /// </summary>
        /// <param name="img"></param>
        /// <param name="coord"></param>
        /// <returns></returns>
        public static HXLDCont GetCoord(RImage img, Coord_Info coord)
        {
            img.GetImageSize(out int Width, out int Height);
            HTuple row1 = new HTuple(new double[] { 0, 0 });
            HTuple col1 = new HTuple(new double[] { 0, 0 });
            HTuple row2 = new HTuple(new double[] { 0, Width / 20 });
            HTuple col2 = new HTuple(new double[] { Height / 20, 0 });
            Gen.GenArrow(out HXLDCont CoordXLD, row1, col1, row2, col2, 5, 5);
            Aff.WorldPlane2Point(img, coord.X, coord.Y, out double row, out double col);
            HHomMat2D hom = new HHomMat2D();
            hom.VectorAngleToRigid(0, 0, 0, row, col, coord.Phi);
            return CoordXLD.AffineTransContourXld(hom);
        }
        /// <summary>
        /// 获取坐标中心箭头-短
        /// </summary>
        /// <param name="img"></param>
        /// <param name="coord"></param>
        /// <returns></returns>
        public static HXLDCont GetCoordShort(RImage img, Coord_Info coord)
        {
            int Width, Height;
            double row, col;
            img.GetImageSize(out Width, out Height);
            HTuple row1 = new HTuple(new double[] { 0, 0 });
            HTuple col1 = new HTuple(new double[] { 0, 0 });
            HTuple row2 = new HTuple(new double[] { 0, Height / 2 });
            HTuple col2 = new HTuple(new double[] { Width / 2, 0 });
            Gen.GenArrow(out HXLDCont CoordXLD, row1, col1, row2 / 30, col2 / 20, 4, 4);
            Aff.WorldPlane2Point(img, coord.X, coord.Y, out row, out col);
            HHomMat2D hom = new HHomMat2D();
            hom.VectorAngleToRigid(0, 0, 0, row, col, coord.Phi);
            CoordXLD = CoordXLD.AffineTransContourXld(hom);
            return CoordXLD;
        }
        /// <summary>
        /// 获取区域中心
        /// </summary>
        /// <param name="img">图像信息</param>
        /// <param name="inEllipse">输入椭圆</param>
        /// <returns>返回当前图像坐标系椭圆</returns>
        public static void GetAreaCenter(HRegion region, out double area, out double row, out double col)
        {
            HTuple _ROW = null, _COL = null, _Area = null;
            HOperatorSet.AreaCenter(region, out _Area, out _ROW, out _COL);
            row = _ROW;
            col = _COL;
            area = _Area;
        }
        /// <summary>创建点xld</summary>
        /// <param name="MeasCross"></param>
        /// <param name="RowList"></param>
        /// <param name="ColList"></param>
        /// <param name="size"></param>
        /// <param name="angle"></param>
        public static void GenCross(out HObject MeasCross, HTuple RowList, HTuple ColList, HTuple size, HTuple angle)
        {
            HOperatorSet.GenCrossContourXld(out MeasCross, RowList, ColList, size, angle);
        }
        /// <summary>创建结果xld-圆 </summary>
        /// <param name="ResultXLD"></param>
        /// <param name="CenterX"></param>
        /// <param name="CenterY"></param>
        /// <param name="Radius"></param>
        public static void GenCircle(out HObject ResultXLD, double CenterX, double CenterY, double Radius)
        {
            HOperatorSet.GenCircleContourXld(out ResultXLD, CenterY, CenterX, Radius, 0, 6.28318, "positive", 1);
        }
        /// <summary>创建结果xld-线</summary>
        /// <param name="ResultXLD"></param>
        /// <param name="StartX"></param>
        /// <param name="StartY"></param>
        /// <param name="EndX"></param>
        /// <param name="EndY"></param>
        public static void GenContour(out HObject ResultXLD, double StartX, double StartY, double EndX, double EndY)
        {
            HOperatorSet.GenContourPolygonXld(out ResultXLD, new HTuple(StartX, StartY), new HTuple(EndX, EndY));
        }
        /// <summary>创建箭头xld</summary>
        /// <param name="ho_Arrow">返回箭头轮廓</param>
        /// <param name="hv_Row1">起始点row</param>
        /// <param name="hv_Column1">起始点col</param>
        /// <param name="hv_Row2">终点row</param>
        /// <param name="hv_Column2">终点col</param>
        /// <param name="hv_HeadLength">箭头长度</param>
        /// <param name="hv_HeadWidth">箭头宽度</param>
        public static void GenArrow(out HXLDCont ho_Arrow, HTuple hv_Row1, HTuple hv_Column1, HTuple hv_Row2, HTuple hv_Column2, HTuple hv_HeadLength, HTuple hv_HeadWidth)
        {
            HTuple hv_Length = null, hv_ZeroLengthIndices = null;
            HTuple hv_DR = null, hv_DC = null, hv_HalfHeadWidth = null;
            HTuple hv_RowP1 = null, hv_ColP1 = null, hv_RowP2 = null;
            HTuple hv_ColP2 = null, hv_Index = null;
            // Initialize local and output iconic Vars 
            ho_Arrow = new HXLDCont();
            HXLDCont ho_TempArrow = new HXLDCont();
            HOperatorSet.DistancePp(hv_Row1, hv_Column1, hv_Row2, hv_Column2, out hv_Length);
            //
            //Mark arrows with identical start and end point
            //(set Length to -1 to avoid division-by-zero exception)
            hv_ZeroLengthIndices = hv_Length.TupleFind(0);
            if ((int)(new HTuple(hv_ZeroLengthIndices.TupleNotEqual(-1))) != 0)
            {
                if (hv_Length == null)
                    hv_Length = new HTuple();
                hv_Length[hv_ZeroLengthIndices] = -1;
            }
            //
            //Calculate auxiliary Vars.
            hv_DR = (1.0 * (hv_Row2 - hv_Row1)) / hv_Length;
            hv_DC = (1.0 * (hv_Column2 - hv_Column1)) / hv_Length;
            hv_HalfHeadWidth = hv_HeadWidth / 2.0;
            //
            //Calculate end points of the arrow head.
            hv_RowP1 = (hv_Row1 + ((hv_Length - hv_HeadLength) * hv_DR)) + (hv_HalfHeadWidth * hv_DC);
            hv_ColP1 = (hv_Column1 + ((hv_Length - hv_HeadLength) * hv_DC)) - (hv_HalfHeadWidth * hv_DR);
            hv_RowP2 = (hv_Row1 + ((hv_Length - hv_HeadLength) * hv_DR)) - (hv_HalfHeadWidth * hv_DC);
            hv_ColP2 = (hv_Column1 + ((hv_Length - hv_HeadLength) * hv_DC)) + (hv_HalfHeadWidth * hv_DR);
            //
            //Finally create output XLD contour for each input point pair
            for (hv_Index = 0; (int)hv_Index <= (int)((new HTuple(hv_Length.TupleLength())) - 1); hv_Index = (int)hv_Index + 1)
            {
                if ((int)(new HTuple(((hv_Length.TupleSelect(hv_Index))).TupleEqual(-1))) != 0)
                {
                    //Create_ single points for arrows with identical start and end point
                    ho_TempArrow.Dispose();
                    ho_TempArrow.GenContourPolygonXld(hv_Row1.TupleSelect(hv_Index),
                        hv_Column1.TupleSelect(hv_Index));
                }
                else
                {
                    //Create arrow contour
                    ho_TempArrow.Dispose();
                    ho_TempArrow.GenContourPolygonXld(((((((((((hv_Row1.TupleSelect(
                        hv_Index))).TupleConcat(hv_Row2.TupleSelect(hv_Index)))).TupleConcat(
                        hv_RowP1.TupleSelect(hv_Index)))).TupleConcat(hv_Row2.TupleSelect(hv_Index)))).TupleConcat(
                        hv_RowP2.TupleSelect(hv_Index)))).TupleConcat(hv_Row2.TupleSelect(hv_Index)),
                        ((((((((((hv_Column1.TupleSelect(hv_Index))).TupleConcat(hv_Column2.TupleSelect(
                        hv_Index)))).TupleConcat(hv_ColP1.TupleSelect(hv_Index)))).TupleConcat(
                        hv_Column2.TupleSelect(hv_Index)))).TupleConcat(hv_ColP2.TupleSelect(
                        hv_Index)))).TupleConcat(hv_Column2.TupleSelect(hv_Index)));
                }
                if (!ho_Arrow.IsInitialized())
                {
                    ho_Arrow = ho_TempArrow;
                }
                ho_Arrow = ho_Arrow.ConcatObj(ho_TempArrow);
            }
            ho_TempArrow.Dispose();
            return;
        }
        /// <summary>
        /// 点排序
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public static void SortPairs(ref List<double> rows, ref List<double> cols)
        {
            HTuple hv_T1 = new HTuple(rows.ToArray());
            HTuple hv_T2 = new HTuple(cols.ToArray());
            //相同的方法 直接使用htuple返回结果
            SortPairs(ref hv_T1, ref hv_T2);
            rows = hv_T1.ToDArr().ToList();
            cols = hv_T2.ToDArr().ToList();
            return;
            //HTuple hv_Sorted1 = new HTuple();
            //HTuple hv_Sorted2 = new HTuple();
            //HTuple hv_SortMode = new HTuple();
            //HTuple hv_Indices1 = new HTuple(), hv_Indices2 = new HTuple();
            //if ((rows.Max() - rows.Min()) > (cols.Max() - cols.Min()))
            //    hv_SortMode = new HTuple("1");
            //else
            //    hv_SortMode = new HTuple("2");
            //if ((int)((new HTuple(hv_SortMode.TupleEqual("1"))).TupleOr(new HTuple(hv_SortMode.TupleEqual(
            //    1)))) != 0)
            //{
            //    HOperatorSet.TupleSortIndex(hv_T1, out hv_Indices1);
            //    hv_Sorted1 = hv_T1.TupleSelect(hv_Indices1);
            //    hv_Sorted2 = hv_T2.TupleSelect(hv_Indices1);
            //}
            //else if ((int)((new HTuple((new HTuple(hv_SortMode.TupleEqual("column"))).TupleOr(
            //    new HTuple(hv_SortMode.TupleEqual("2"))))).TupleOr(new HTuple(hv_SortMode.TupleEqual(
            //    2)))) != 0)
            //{
            //    HOperatorSet.TupleSortIndex(hv_T2, out hv_Indices2);
            //    hv_Sorted1 = hv_T1.TupleSelect(hv_Indices2);
            //    hv_Sorted2 = hv_T2.TupleSelect(hv_Indices2);
            //}
            //rows = hv_Sorted1.ToDArr().ToList();
            //cols = hv_Sorted2.ToDArr().ToList();
        }
        /// <summary>
        /// 点排序
        /// </summary>
        /// <param name="hv_T1"></param>
        /// <param name="hv_T2"></param>
        public static void SortPairs(ref HTuple hv_T1, ref HTuple hv_T2)
        {
            HTuple hv_Sorted1 = new HTuple();
            HTuple hv_Sorted2 = new HTuple();
            HTuple hv_SortMode = new HTuple();
            HTuple hv_Indices1 = new HTuple(), hv_Indices2 = new HTuple();
            if ((hv_T1.TupleMax().D - hv_T1.TupleMin().D) > (hv_T2.TupleMax().D - hv_T2.TupleMin().D))
                hv_SortMode = new HTuple("1");
            else
                hv_SortMode = new HTuple("2");
            if ((int)((new HTuple(hv_SortMode.TupleEqual("1"))).TupleOr(new HTuple(hv_SortMode.TupleEqual(
                1)))) != 0)
            {
                HOperatorSet.TupleSortIndex(hv_T1, out hv_Indices1);
                hv_Sorted1 = hv_T1.TupleSelect(hv_Indices1);
                hv_Sorted2 = hv_T2.TupleSelect(hv_Indices1);
            }
            else if ((int)((new HTuple((new HTuple(hv_SortMode.TupleEqual("column"))).TupleOr(
                new HTuple(hv_SortMode.TupleEqual("2"))))).TupleOr(new HTuple(hv_SortMode.TupleEqual(
                2)))) != 0)
            {
                HOperatorSet.TupleSortIndex(hv_T2, out hv_Indices2);
                hv_Sorted1 = hv_T1.TupleSelect(hv_Indices2);
                hv_Sorted2 = hv_T2.TupleSelect(hv_Indices2);
            }
            hv_T1 = hv_Sorted1;
            hv_T2 = hv_Sorted2;
        }
    }
    #endregion
    #region 数据存储
    /// <summary>数据存储</summary>
    public class Csv
    {
        /// <summary>
        /// 保存CSV
        /// </summary>
        /// <param name="FullPath">路径</param>
        /// <param name="FileName">名称</param>
        /// <param name="date">时间</param>
        /// <param name="dataRow">标题行</param>
        /// <param name="dataCol">内容列</param>
        /// <returns></returns>
        public static bool Save(string FullPath, string FileName, string dataRow, string dataCol)
        {
            try
            {
                FileStream mFileStream;
                StreamWriter mStreamWriter;
                string date = DateTime.Now.ToString("yyyy-MM-d");
                if (!Directory.Exists(FullPath))
                {
                    Directory.CreateDirectory(FullPath); //在指定路径中创建所有目录。 ////DateTime.Now.ToString("yyyyMMddHHmmss");
                }
                string name = Path.GetFileNameWithoutExtension(FullPath + "\\" + FileName);//返回不具有扩展名的指定路径字符串的文件名。
                string path = FullPath + "\\" + date + " " + name + ".csv";
                if (!File.Exists(path))
                {
                    using (File.Create(path)) { }//在指定路径中创建文件。
                    mFileStream = new FileStream(path, FileMode.Append);
                    mStreamWriter = new StreamWriter(mFileStream, Encoding.UTF8);
                    mStreamWriter.WriteLine(dataRow);
                    mStreamWriter.WriteLine(dataCol);
                    mStreamWriter.Flush();
                    mStreamWriter.Close();
                    mFileStream.Close();
                }
                else
                {
                    mFileStream = new FileStream(path, FileMode.Append);
                    mStreamWriter = new StreamWriter(mFileStream, Encoding.UTF8);
                    mStreamWriter.WriteLine(dataCol);
                    mStreamWriter.Flush();
                    mStreamWriter.Close();
                    mFileStream.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
    #endregion
}
