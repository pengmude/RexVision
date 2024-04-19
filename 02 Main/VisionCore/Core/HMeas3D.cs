using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore
{
    class HMeas3D
    {
        #region PCL 平面度算法
        public struct tagPlane
        {
            //平面方程 ax+by+cz+d=0
            /// <summary>ratio of the X</summary>
            public double a;
            /// <summary>ratio of the Y</summary>
            public double b;
            /// <summary>ratio of the Z</summary>
            public double c;
            /// <summary>constant of the plane's equation</summary>
            public double d;
        };

        /// <summary>
        /// ratio of plane's equation and curvature
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct VectorInfo
        {
            /// <summary>ratio of the X</summary>
            public float _ratioX;
            /// <summary>ratio of the Y</summary>
            public float _ratioY;
            /// <summary>ratio of the Z</summary>
            public float _ratioZ;
            /// <summary>constant of the plane's equation</summary>
            public float _constant;
            /// <summary>curvature</summary>
            public float _curvature;
            /// <summary>reserve</summary>
            public float _reserve;
        };
        /// <summary>
        /// DLL function calling class
        /// </summary>	
        public static class PCL_Methods
        {
            /** \brief 将坐标存入点云，
            * \param[in] 输入点X坐标
            * \param[in] 输入点Y坐标
            * \param[in] 输入点Z坐标  
            * \param[in] 输入点I坐标
            * \param[in] 输入列数
            * \param[in] 输入行数 
            * \param[out] 返回的点云 
            */
            [DllImport("PCL_Library_Dll.dll", CallingConvention = CallingConvention.Cdecl)]
            /*使用pcl内部算法 返回平面方程和曲率，但根据使用经验，当点趋于平面是效果不好*/
            public static extern int compute_PointNormal(Single[] iX, Single[] iY, Single[] iZ, int length, ref VectorInfo _vectorInfo);

            [DllImport("PCL_Library_Dll.dll", CallingConvention = CallingConvention.Cdecl)]
            /*使用网友改编的算法 返回平面方程，Z值永远为1*/
            public static extern int compute_PointNormal2(Single[] iX, Single[] iY, Single[] iZ, int length, ref VectorInfo _vectorInfo);

            [DllImport("PCL_Library_Dll.dll", CallingConvention = CallingConvention.Cdecl)]
            /*用第一种方法计算平面度*/
            public static extern int Calculate_Flatness(Single[] iX, Single[] iY, Single[] iZ, int length, ref double _result);

            [DllImport("PCL_Library_Dll.dll", CallingConvention = CallingConvention.Cdecl)]
            /*用第二种方法计算平面度*/
            public static extern int Calculate_Flatness2(Single[] iX, Single[] iY, Single[] iZ, int length, ref double _result);

            /// <summary>
            /// 用PCL中的算法拟合平面
            /// </summary>
            /// <param name="lstX">x坐标序列点</param>
            /// <param name="lstY">y坐标序列点</param>
            /// <param name="lstZ">z坐标序列点</param>
            /// <returns></returns>
            public static tagPlane CalPlane2(List<double> lstX, List<double> lstY, List<double> lstZ)
            {
                tagPlane plane = new tagPlane();
                try
                {
                    VectorInfo vec_info = new VectorInfo();
                    Single[] iX = Array.ConvertAll<double, float>(lstX.ToArray(), a => Convert.ToSingle(a));
                    Single[] iY = Array.ConvertAll<double, float>(lstY.ToArray(), a => Convert.ToSingle(a));
                    Single[] iZ = Array.ConvertAll<double, float>(lstZ.ToArray(), a => Convert.ToSingle(a));

                    PCL_Methods.compute_PointNormal2(iX, iY, iZ, iX.Length, ref vec_info);
                    plane.a = vec_info._ratioX;
                    plane.b = vec_info._ratioY;
                    plane.c = vec_info._ratioZ;
                    plane.d = vec_info._constant;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return plane;
            }

            /// <summary>
            /// 用PCL方法计算平面度
            /// </summary>
            /// <param name="lstX">x坐标序列点</param>
            /// <param name="lstY">y坐标序列点</param>
            /// <param name="lstZ">z坐标序列点</param>
            /// <returns></returns>
            public static double CalFlatness2(List<double> lstX, List<double> lstY, List<double> lstZ)
            {
                double flatness = 0;
                try
                {
                    Single[] iX = Array.ConvertAll<double, float>(lstX.ToArray(), a => Convert.ToSingle(a));
                    Single[] iY = Array.ConvertAll<double, float>(lstY.ToArray(), a => Convert.ToSingle(a));
                    Single[] iZ = Array.ConvertAll<double, float>(lstZ.ToArray(), a => Convert.ToSingle(a));
                    PCL_Methods.Calculate_Flatness2(iX, iY, iZ, iX.Length, ref flatness);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                return flatness;
            }
            #endregion
            public class Mens3D
            {
                ///// <summary>
                ///// 区分显示三西格玛 magical 20180405
                ///// </summary>
                ///// <param name="rowList">传入的点</param>
                ///// <param name="colList">传入的点</param>
                ///// <param name="line">传入的直线,用传入的点和直线做比较</param>
                ///// <param name="rowIn3SigmaList">在三西格玛内的点</param>
                ///// <param name="colIn3SigmaList">在三西格玛内的点</param>
                ///// <param name="rowOut3SigmaList">在三西格玛外的点</param>
                ///// <param name="colOut3SigmaList">在三西格玛外的点</param>
                //public static void Cal3Sigma4Line(List<double> rowList, List<double> colList, Line_Info line, out List<double> rowIn3SigmaList, out List<double> colIn3SigmaList, out List<double> rowOut3SigmaList, out List<double> colOut3SigmaList)
                //{
                //    List<double> dis = new List<double>();
                //    Find.DistancePL(rowList, colList, line, out dis);

                //    double mean = dis.Average();//

                //    List<double> listDataV = new List<double>();
                //    foreach (double d in dis)
                //    {
                //        listDataV.Add((d - mean) * (d - mean));
                //    }
                //    double sumDataV = listDataV.Sum();
                //    double std = Math.Sqrt(sumDataV / (listDataV.Count - 1));//标准方差

                //    rowIn3SigmaList = new List<double>();
                //    colIn3SigmaList = new List<double>();
                //    rowOut3SigmaList = new List<double>();
                //    colOut3SigmaList = new List<double>();

                //    for (int i = 0; i < dis.Count; i++)
                //    {
                //        if (dis[i] >= std * 3)
                //        {
                //            rowOut3SigmaList.Add(rowList[i]);
                //            colOut3SigmaList.Add(colList[i]);
                //        }
                //        else
                //        {
                //            rowIn3SigmaList.Add(rowList[i]);
                //            colIn3SigmaList.Add(colList[i]);
                //        }
                //    }
                //}
                /// <summary>
                /// 根据镭射图像及矩形框将高度信息转化为c基准对应的ccd图像上的点
                /// </summary>
                /// <param name="inImage">输入图像  镭射图像</param>
                /// <param name="ROWPIX">ccd相机的列像素当量 作为镭射图像的行像素当量</param>
                /// <param name="colPix">镭射扫描像素当量 默认为0.2</param>
                /// <param name="DATUM_C_HIGH">镭射补偿量,用于调整C基准</param>
                /// <param name="LASER_FirstLserRow">镭射第一条线的行数</param>
                /// <param name="LASER_Column4FirstLserRow">第一条线在图像坐标系 对应的column</param>
                /// <param name="LASER_Z">镭射的高度 </param>
                /// <param name="LASER_Row4Z">镭射的高度对应的row</param>
                /// <param name="inRectInfo">镭射图像选点框输出的矩阵信息</param>
                /// <param name="outRectInfo">转换为ccd坐标后的矩阵信息</param>
                //public static void GetDatunCPoint(RImage inImage, double ROWPIX, double colPix, double DATUM_C_HIGH, double LASER_FirstLserRow, double LASER_Column4FirstLserRow,
                //double LASER_Z, double LASER_Row4Z, List<Rect_Info> inRectInfo, out List<Rect_Info> outRectInfo)
                //{

                //    //double ROWPIX = double.Parse(CProductInfo.Config["ROWPIX"]);//相机的像素当量
                //    //double DATUM_C_HIGH = double.Parse(CProductInfo.Config["DATUM_C_HIGH"]);//镭射补偿量,用于调整C基准

                //    //double LASER_FirstLserRow = double.Parse(CProductInfo.Config["LASER_FirstLserRow"]);//镭射第一条线的行数
                //    //double LASER_Column4FirstLserRow = double.Parse(CProductInfo.Config["LASER_Column4FirstLserRow"]);//第一条线在图像坐标系 对应的column

                //    //double LASER_Z = double.Parse(CProductInfo.Config["LASER_Z"]);//镭射的高度 
                //    //double LASER_Row4Z = double.Parse(CProductInfo.Config["LASER_Row4Z"]);//镭射的高度对应的row

                //    outRectInfo = new List<Rect_Info>();
                //    if (inRectInfo == null || inRectInfo.Count < 1)
                //    {
                //        return;
                //    }
                //    int count = inRectInfo.Count;

                //    HTuple rows, cols, temp_values;
                //    for (int i = 0; i < count; i++)
                //    {
                //        Rect_Info _RectInfo = new Rect_Info();
                //        temp_values = new HTuple(inRectInfo[i].Value_List.ToArray());
                //        rows = new HTuple(inRectInfo[i].Y_List.ToArray()).TupleDiv(inImage.ScaleY);
                //        cols = new HTuple(inRectInfo[i].X_List.ToArray()).TupleDiv(inImage.ScaleX);
                //        //获取z值的最大1%用于剔除异常点
                //        List<double> zList = temp_values.DArr.ToList<double>();
                //        zList.Sort();
                //        zList.Reverse();
                //        double zLimit = zList.Take((int)(zList.Count * 0.002)).ToList().Min();

                //        _RectInfo.Value_List = temp_values.ToDArr().ToList();

                //        List<double> rowCCDList = new List<double>();
                //        List<double> colCCDList = new List<double>();

                //        double rowCCDPix = ROWPIX;//CCD的像素当量
                //                                  //double colPix = 0.2;//间隔

                //        double rowCCDDif = LASER_Row4Z - LASER_Z / rowCCDPix + DATUM_C_HIGH / rowCCDPix;//镭射扫描出的row,在ccd的坐标的补偿值
                //        double colCCDDif = LASER_Column4FirstLserRow - LASER_FirstLserRow * colPix / rowCCDPix;//镭射扫描出的col,在ccd的坐标的补偿值

                //        #region 只提取每行z值最大的
                //        List<double> zTmpLis = new List<double>();
                //        int OldRow = rows[0];
                //        for (int m = 0; m < temp_values.Length; m++)
                //        {
                //            int curRow = rows[m];
                //            double z = temp_values.DArr[m];
                //            if (curRow == OldRow)//一行一行提取
                //            {
                //                if (z > -99999 && z < zLimit)//剔除异常点i
                //                {
                //                    zTmpLis.Add(z);
                //                }
                //            }
                //            else //已经换行
                //            {
                //                double zWant = zTmpLis.Max();
                //                double r = (zWant / 1000) / rowCCDPix + rowCCDDif;
                //                double c = (OldRow * colPix / rowCCDPix) + colCCDDif;
                //                rowCCDList.Add(r);
                //                colCCDList.Add(c);
                //                OldRow = curRow;
                //                zTmpLis.Clear();
                //            }

                //        }
                //        #endregion
                //        //for (int m = 0; m < temp_values.Length; m++)
                //        //{

                //        //    double z = temp_values.DArr[m];
                //        //    //均为double型数组 林玉刚 2018-9-12 15:23:39
                //        //    double col = rows.DArr[m];
                //        //    if (z > -99999 && z < zLimit)//剔除异常点i
                //        //    {
                //        //        double r = (z / 1000) / rowCCDPix + rowCCDDif;
                //        //        double c = (col * colPix / rowCCDPix) + colCCDDif;
                //        //        rowCCDList.Add(r);
                //        //        colCCDList.Add(c);
                //        //        //  sw1.WriteLine(r+ "," + c);
                //        //    }
                //        //}
                //        _RectInfo.X_List = rowCCDList;
                //        _RectInfo.Y_List = colCCDList;
                //        outRectInfo.Add(_RectInfo);
                //    }

                //}
                ///// <summary>
                ///// 使用脚本显示 一条直线
                ///// </summary>
                ///// <param name="unitID">单元号</param>
                ///// <param name="start_row">直线起点行</param>
                ///// <param name="start_col">直线起点列</param>
                ///// <param name="end_row">直线终点行</param>
                ///// <param name="end_col">直线终点列</param>
                //public static void SetLineShow(int unitID, double start_row, double start_col, double end_row, double end_col)
                //{
                //    CMeasCell cell =ProjI. .g_ProjList[m_ProIndex].m_CellList.First(c => c.m_CellID == unitID);

                //    ((CMeas_Show)cell).genLineShow(start_row, start_col, end_row, end_col);
                //}
                ///// <summary>
                ///// 使用脚本显示文本输出
                ///// 脚本实例
                ///// dim rowList, colList as new List(of double)
                ///// rowList.add(100)
                ///// colList.add(100)
                ///// h.SetCrossShow(15,rowList,colList)
                ///// h.SetLineShow(15,100,100,2000,2000)
                ///// h.SetTextShow(15,"显示的内容",500,500,"mono",50,"red")
                ///// </summary>
                ///// <param name="unitID">要显示的工具单元</param>
                ///// <param name="_text">文本信息</param>
                ///// <param name="_row">行</param>
                ///// <param name="_col">列</param>
                ///// <param name="_font">字体</param>
                ///// <param name="_size">文字大小</param>
                ///// <param name="_color">文字颜色</param>
                //public static void SetTextShow(int unitID, string _text, double _row, double _col, string _font, int _size, string _color)
                //{
                //    CMeasCell cell = HMeasSYS.g_ProjList[m_ProIndex].m_CellList.First(c => c.m_CellID == unitID);

                //    ROIText roiText = new ROIText(_text, _row, _col, _font, _size, _color);
                //    ((CMeas_Show)cell).genTextShow(roiText);
                //}
            }
        }
    }
}