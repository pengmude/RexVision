using EasyVision.Common.Log4Net;
using EasyVision.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVision
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {

                FrmMainMdi f = new FrmMainMdi();// 正式UI

                //初始化环境
                EVSDK.InitiaEnvironment();

                Application.Run(f);

            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}
