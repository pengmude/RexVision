using System;
using System.IO;

namespace RexHelps
{
    public class RLog
    {
        string logFile = string.Empty;

        private RLog()
        {
            Initialize();
        }

        public static readonly RLog Instance = new RLog();

        public void Initialize()
        {
            try
            {
                logFile = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\" + Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath) + ".log";
            }
            catch (Exception ex)
            {
                //ex.Message.ToString();
                System.Windows.Forms.MessageBox.Show("RexHelps.RLog.Initialize:" + ex.ToString());
            }
        }

        public void Initialize(string input)
        {
            try
            {
                if (input != "")
                {
                    logFile = input;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("RexHelps.RLog.Initialize:" + ex.ToString());
            }
        }

        public void VTLogInfo(string input)
        {
            VTLog(/*"[INFO] " + */input);
        }

        public void VTLogWarning(string input)
        {
            VTLog(/*"[WARNING] " + */input);
        }

        public void VTLogError(string input)
        {
            VTLog(/*"[ERROR] " +*/ input);
        }

        /// <summary>
        /// 追加一行信息
        /// </summary>
        /// <param name="text"></param>
        public void VTLog(string text)
        {
            text += "\r\n";
            using (FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
                    //sw.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + text);
                    //sw.Close();
                }
                //fs.Close();
            }
        }
    }
}
