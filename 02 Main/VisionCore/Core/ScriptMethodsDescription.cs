using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore
{
    public class ScriptMethodsDescription
    {
        #region "注释区域"
        protected const string ShowDescription = @"
public void Show(String msg)
{
    MessageBox.Show(msg);
}
";

        protected const string SleepDescription = @"
延时多少毫秒
";


        protected const string GetStringDescription = @"
/// <summary>
/// 获取string
/// </summary>
/// <param name=""key"">模块名.变量名</param>
/// <returns></returns>
";
        protected const string GetIntDescription = @"
/// <summary>
/// 获取int
/// </summary>
/// <param name=""key"">模块名.变量名</param>
/// <returns></returns>
";
        protected const string SetValueDescription = @"
/// <summary>
/// 设置值int
/// </summary>
/// <param name=""key""></param>
/// <param name=""value""></param>
";
        protected const string LogInfoDescription = @"
//打印日志
";
        #endregion
    }
}
