using System;
using System.Windows.Forms;
using VisionCore;
namespace RexVision
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (System.Threading.Mutex m = new System.Threading.Mutex(true, "Global\\" + Application.ProductName, out bool createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //注册日志系统
                    Log.RegisterLog();
                    // TODO:加载插件
                    PluginCamService.InitPlugin();
                    PluginToolService.InitPlugin();
                    Application.Run(new FormMain());
                }
                else
                {
                    MessageBox.Show("程序已运行!");
                }
            }
        }
    }
}
