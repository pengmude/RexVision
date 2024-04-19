using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Runtime.InteropServices;
using CPublicDefine;
//using System.IO;
//using Measure;
//using CPublicDefine;
//using HEViewer;

namespace Helper
{
    public class CHelper
    {
        #region 自定义函数
        ///// <summary>
        ///// 发送数据到LOG显示通知
        ///// </summary>
        ///// <param name="data"></param>
        public static void send_log(string data)
        {
            if (send_log_event!=null) { send_log_event.BeginInvoke(data,null,null); }
        }
        /// <summary>
        /// 通知显示框显示指定的图像
        /// </summary>
        /// <param name="data"></param>
        public static void send_upimg(int num , HImageExt img)
        {
            if (HImageExt_updata_event != null) { HImageExt_updata_event.BeginInvoke(num,img, null, null); }
        }
        /// <summary>
        /// 通知显示框更新结果
        /// </summary>
        /// <param name="data"></param>
        public static void 更新结果(int data)
        {
            // PostMessage(g_MainWnd, SHOW_RESULT, data, "");
        }

        #endregion


        #region 注释

        /// <summary>
        /// 回调结果数据
        /// </summary>
        /// <param name="ID">当前projectID</param>
        /// <param name="sResult">结果字符串</param>
        /// <returns>放回值</returns>
        public delegate void logupdata(string data);
        public static logupdata send_log_event;


        /// <summary>
        /// 将he插入到HeViewer magical 20170823
        /// </summary>
        /// <param name = "name" > 要显示的窗体 </ param >
        /// < param name="he">显示的图像</param>
        public delegate void HImageExt_updata(int num, HImageExt he);
        public static HImageExt_updata HImageExt_updata_event;

        //  public delegate void InsertHE2AutoRunWindow(List<HImageExt> heList, string projectName);
        // public static InsertHE2AutoRunWindow InsertHe2ExtWindow;
        //public static Frm_HEViewer frm_HEViewer = new Frm_HEViewer(true);// 效果图展示窗口  magical 20170823
        #endregion

        /// <summary>
        /// 将输入的字符串转换
        /// </summary>
        /// <param name="strName">输入字符串</param>
        /// <returns></returns>
        public static string TransChar(string strName)
        {
            string str = string.Empty;
            if (strName == "逗 号")
            {
                str = ",";
            }
            else if (strName == "分 号")
            {
                str = ";";
            }
            else if (strName == "空 格")
            {
                str = " ";
            }
            else if (strName == "# 号")
            {
                str = "#";
            }
            else if (strName == "$ 号")
            {
                str = "$";
            }
            else if (strName == "* 号")
            {
                str = "*";
            }
            else if (strName == "@ 号")
            {
                str = "@";
            }
            else if (strName == "% 号")
            {
                str = "%";
            }
            else if (strName == "& 号")
            {
                str = "&";
            }
            return str;
        }
    }
}
