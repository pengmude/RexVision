using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Data;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.IO;
using Rex.UI;
using System.Reflection;

namespace VisionCore
{
    public class Tools
    {
        public static string _varpath = null;
        public static DateTime m_dtAlarmTime = DateTime.MinValue;
        static ManualResetEvent m_eventAccessAvilable = new ManualResetEvent(true);
        /// <summary>
        /// 修改控件为圆角
        /// </summary>
        /// <param name="bt">控件</param>
        public static void SetWindowRegion(Control bt, int nRadius = 3)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(-1, -1, bt.Width + 1, bt.Height + 1);
            FormPath = GetRoundedRectPath(rect, nRadius);
            bt.Region = new Region(FormPath);
        }
        /// <summary>
        /// 修改控件为圆角
        /// </summary>
        /// <param name="bt">控件</param>
        public static void SetWindowToolRegion(ToolStripButton bt, int nRadius = 3)
        {
            System.Drawing.Drawing2D.GraphicsPath FormPath;
            FormPath = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle rect = new Rectangle(-1, -1, bt.Width + 1, bt.Height + 1);
            FormPath = GetRoundedRectPath(rect, nRadius);
             //bt.r .Region = new Region(FormPath);
        }
        public static System.Drawing.Drawing2D.GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            //   左上角   
            path.AddArc(arcRect, 180, 90);
            //   右上角   
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 275, 90);
            //   右下角   
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 5, 90);
            //   左下角   
            arcRect.X = rect.Left;
            arcRect.Width += 1;
            arcRect.Height += 1;
            path.AddArc(arcRect, 90, 90);
            path.CloseFigure();
            return path;
        }
        public static void DisplayButton(Button buttonClick , List<Button> listButton)
        {
            foreach (Button button in listButton)
            {
                if (button.Handle == buttonClick.Handle)
                {
                    button.BackColor = Color.FromArgb(168, 255, 168);
                }
                else
                {
                    button.BackColor = Color.LightGray;
                }
            }
        }
        public static void DisplayToolButton(ToolStripButton buttonClick, List<ToolStripButton> listButton)
        {
            foreach (ToolStripButton button in listButton)
            {
                if (button == buttonClick/*.Handle*/)
                {
                    button.BackColor = Color.FromArgb(168, 255, 168);
                }
                else
                {
                    button.BackColor = Color.LightGray;
                }
            }
        }
        /// <summary>
        /// 写注册表值
        /// </summary>
        /// <param name="strName"></param>
        /// <param name="value"></param>
        /// <param name="strPath"></param>
        public static void SetRegKey(string strName, object value, string strPath = "Software\\HGLaser1")
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(strPath, true);
            if (null == key)
            {
                key = Registry.LocalMachine.CreateSubKey(strPath);
            }
            key.SetValue(strName, value);
            key.Close();
        }
        public static object GetRegKey(string strName, string strPath = "Software\\HGLaser1")
        {
            object obValue = "";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(strPath, false);
            string[] strKeys = { };
            if (key != null)
                strKeys = key.GetValueNames();
            if (strKeys.Contains(strName))
            {
                obValue = key.GetValue(strName);
            }
            key.Close();
            return obValue;
        }
        public static string[] GetRegNames(string strPath = "Software\\HGLaser1")
        {
            string[] strNames = { };
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(strPath, false);
            if (keyCom != null)
            {
                strNames = keyCom.GetValueNames();
                keyCom.Close();
            }
            return strNames;
        }
        public static string[] AvailableCOM
        {
            get
            {
                List<string> listValues = new List<string>();
                RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM", false);
                if (keyCom != null)
                {
                    foreach (string strName in keyCom.GetValueNames())
                    {
                        listValues.Add(keyCom.GetValue(strName).ToString());
                    }
                    keyCom.Close();
                }
                return listValues.ToArray();
            }
        }
        //public static void AddMessage(string strMsg, Log.LogType type, Color color)
        //{
        //    Log.LogItem log = new Log.LogItem();
        //    log.strMsg = strMsg;
        //    log.type = type;
        //    log.color = color;
        //    LOG.m_quForm.Enqueue(log);
        //    LOG.log.WriteLog(strMsg, type);
        //}
        //public static DialogResult TipBox(object objTip, int nWidth = 370, int nHeight = 270)
        //{
        //    FormTip formTip = new FormTip();
        //    //formTip.TopMost = true;
        //    formTip.m_strTip = objTip.ToString();
        //    string strMsg = formTip.m_strTip.Replace("\r\n", ",");
        //    //AddMessage(strMsg, Log.LogType.Error, Color.Red);
        //    formTip.Size = new Size(nWidth, nHeight);
        //    return formTip.ShowDialog();
        //}
        //public static DialogResult TipBox2(object objTip, int nWidth = 370, int nHeight = 270)
        //{
        //    FormTip2 formTip = new FormTip2();
        //    //formTip.TopMost = true;
        //    formTip.m_strTip = objTip.ToString();
        //    string strMsg = formTip.m_strTip.Replace("\r\n", ",");
        //    //AddMessage(strMsg, Log.LogType.Error, Color.Red);
        //    formTip.Size = new Size(nWidth, nHeight);
        //    return formTip.ShowDialog();
        //}
        #region 内存回收
        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        /// <summary>
        /// 释放内存
        /// </summary>
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }
        #endregion
    }
}
