using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class TimeTool
{

    private static Dictionary<string, DateTime> dateTimeDic = new Dictionary<string, System.DateTime>();
    public static void startTime(string section)
    {

        lock (dateTimeDic)
        {
            if (!string.IsNullOrEmpty(section))
            {
                //dateTimeDic.Add(section, System.DateTime.Now) 此方法不能添加相同的键
                dateTimeDic[section] = System.DateTime.Now;
            }
        }
    }

    public static string stopTime(string section)
    {
        return stopTime(section, "debug");
    }

    public static string stopTime(string section, string logLevel)
    {
        lock (dateTimeDic)
        {
            try
            {
                if (!string.IsNullOrEmpty(section) & dateTimeDic.ContainsKey(section))
                {
                    DateTime tempNow = System.DateTime.Now;

                    TimeSpan ts = tempNow.Subtract(dateTimeDic[section]);
                    //                 //日志打印 保留0位小数点
                    //Log.Print(section + " 耗时: " + ts.TotalMilliseconds.ToString("f0") + "ms", logLevel);
                    Console.WriteLine(section + " 耗时: " + ts.TotalMilliseconds.ToString("f0") + "ms");
                    return ts.TotalMilliseconds.ToString("f0");
                }
                else
                {
                    Console.WriteLine(section + "该片段没有记录开始运行时间");
                    return "0";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(section + " 检测用时出错: " + ex.ToString());
                return "0";
            }
        }
    }
}
