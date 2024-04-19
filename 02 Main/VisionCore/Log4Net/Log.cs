using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionCore
{
    public class Log
    {
        /// <summary>
        /// 日志记录
        /// </summary>
        private static ILog log4Net = LogManager.GetLogger("logLogger");
        /// <summary>
        /// 模块参数修改记录
        /// </summary>
        private static readonly ILog LogModify = LogManager.GetLogger("modifyLogger");
        /// <summary>初始化注册RichTextBox</summary>
        public static void RegisterLog()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Application.StartupPath + "\\log4net.config"));
            //按理说可以通过配置log4net来达到天数控制,但是这个有时候会调整天数,故自己写逻辑
        }
        /// <summary>初始化时注册,让控件显示日志信息</summary>
        public static void InitializeRichTextBox(RichTextBox RichTextBoxLog)
        {
            if (RichTextBoxLog == null)
                return;
            var LogPattern = "%d{yyyy-MM-dd HH:mm:ss} %-5p %m%n";
            var LogListAppender = new TextBoxBaseAppender();
            LogListAppender.RichTextBoxLog = RichTextBoxLog;
            LogListAppender.Layout = new PatternLayout(LogPattern);
            log4net.Config.BasicConfigurator.Configure(LogListAppender);
        }

        /// <summary>记录模块参数变更记录  用于记录额外的一些重要记录,比如关键参数修改记录-->记录在log/modify文件下</summary>
        public static void ModParamModify(string str)
        {
            LogModify.Info(str);
        }
        /// <summary>调试</summary>
        public static void Debug(string str)
        {
            log4Net.Debug(str);
        }
        /// <summary>提示</summary>
        public static void Info(string str)
        {
            log4Net.Info(str);
        }
        /// <summary>警告</summary>
        public static void Warn(string str)
        {
            log4Net.Warn(str);
        }
        /// <summary>错误</summary>
        public static void Error(string str) // error为关键字
        {
            log4Net.Error(str);
        }
        /// <summary>异常</summary>
        public static void Fatal(string str)
        {
            log4Net.Fatal(str);
        }
        /// <summary>打印</summary>
        public static void Print(LogLevel LogLevel, string str)
        {
            switch (LogLevel)
            {
                case LogLevel.Debug:
                    {
                        Log.Debug(str);
                        break;
                    }
                case LogLevel.Info:
                    {
                        Log.Info(str);
                        break;
                    }
                case LogLevel.Warn:
                    {
                        Log.Warn(str);
                        break;
                    }
                case LogLevel.Error:
                    {
                        Log.Error(str);
                        break;
                    }
                case LogLevel.Fatal:
                    {
                        Log.Fatal(str);
                        break;
                    }
                default:
                    {
                        Log.Debug(str);
                        break;
                    }
            }
        }
        /// <summary>更新日志等级-Debug,Info,Warn,Error,Fatal</summary>
        public static void UpLogLevel(LogLevel logLevel)
        {
            try
            {
                //LogLevel logLevel = (LogLevel)Enum.Parse(typeof(LogLevel), str);

                Level level = Level.Debug;//log4net 自带的类
                switch (logLevel)
                {
                    case LogLevel.Debug:
                        {
                            level = Level.Debug;
                            break;
                        }
                    case LogLevel.Info:
                        {
                            level = Level.Info;
                            break;
                        }
                    case LogLevel.Warn:
                        {
                            level = Level.Warn;
                            break;
                        }
                    case LogLevel.Error:
                        {
                            level = Level.Error;
                            break;
                        }
                    case LogLevel.Fatal:
                        {
                            level = Level.Fatal;
                            break;
                        }
                    default:
                        {
                            level = Level.Debug;
                            break;
                        }
                }

                ((Hierarchy)LogManager.GetRepository()).Root.Level = level;
                ((Hierarchy)LogManager.GetRepository()).RaiseConfigurationChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Log.Error("Log:" + ex.Message);
                throw;
            }

        }
        /// <summary>删除指定日期前的日志</summary>
        public static void DeleteLog(int dayNum)
        {
            Task.Run(() =>
            {
                try
                {
                    DateTime tempDate;
                    DirectoryInfo dir = new DirectoryInfo(GetFolder());
                    FileInfo[] fileInfo = dir.GetFiles();
                    // 遍历
                    foreach (FileInfo NextFile in fileInfo)
                    {
                        tempDate = NextFile.LastWriteTime;
                        int days = (DateTime.Now - tempDate).Days;
                        if (days > dayNum)// 删除dayNum天前
                            File.Delete(NextFile.FullName);
                    }
                }
                catch (Exception ex)
                {
                    Error("Log:" + ex.Message);
                }
            });
        }
        /// <summary>获取日志存储文件夹</summary>
        private static string GetFolder()
        {
            var repository = LogManager.GetRepository();
            var appenders = repository.GetAppenders();
            var targetApder = appenders.First(p => p.Name == "LogFile") as RollingFileAppender;
            return Path.GetDirectoryName(targetApder.File);
        }
    }
}
