using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RexHelps
{
    public class RParam
    {  
        public static string SetMeasModel(string str)
        {
            string ret = "negative";
            switch (str)
            {
                case "由白到黑":
                    ret = "negative";
                    break;
                case "由黑到白":
                    ret = "positive";
                    break;
                case "规格一致":
                    ret = "uniform";
                    break;
                case "所有信息":
                    ret = "all";
                    break;
            }

            return ret;
        }
        public static int SetMeasDir(string str)
        {
            int ret = 0;
            switch (str)
            {
                case "默认值":
                    ret = 0;
                    break;
                case "顺时针":
                    ret =1;
                    break;
                case "逆时针":
                    ret = 2;
                    break;
            }
            return ret;
        }
        public static string SetMeasSelect(string str)
        {
            string ret = "first";
            switch (str)
            {
                case "第一点":
                    ret ="first";
                    break;
                case "最末点":
                    ret = "last";
                    break;
                case "所有点":
                    ret = "all";
                    break;
                case "最强点":
                    ret = "strongest";
                    break;
            }
            return ret;
        }

        public static string GetMeasModel(string str)
        {
            string ret = "由白到黑";
            switch (str)
            {
                case "negative":
                    ret = "由白到黑";
                    break;
                case "positive":
                    ret = "由黑到白";
                    break;
                case "uniform":
                    ret = "规格一致";
                    break;
                case "all":
                    ret = "所有信息";
                    break;
            }

            return ret;
        }
        public static string GetMeasDir(string str)
        {
            string ret = "默认值";
            switch (str)
            {
                case "0":
                    ret = "默认值";
                    break;
                case "1":
                    ret = "顺时针";
                    break;
                case "2":
                    ret = "逆时针";
                    break;
            }
            return ret;
        }
        public static string GetMeasSelect(string str)
        {
            string ret = "第一点";
            switch (str)
            {
                case "first":
                    ret = "第一点";
                    break;
                case "last":
                    ret = "最末点";
                    break;
                case "all":
                    ret = "所有点";
                    break;
                case "strongest":
                    ret = "最强点";
                    break;
            }
            return ret;
        }
    }
}
