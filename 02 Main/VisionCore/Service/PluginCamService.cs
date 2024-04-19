using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using VisionCore.Properties;

namespace VisionCore
{
    public class PluginCamService
    {
        /// <summary> 插件字典 </summary>
        public static Dictionary<string, PluginsInfo> cPluginDic = new Dictionary<string, PluginsInfo>();
        /// <summary>加载插件</summary>
        public static void InitPlugin()
        {
            string PlugInsDir = Path.Combine(Environment.CurrentDirectory, "Camera\\");
            if (Directory.Exists(PlugInsDir) == false) return;//判断是否存在
            foreach (var dllFile in Directory.GetFiles(PlugInsDir, "*.dll"))//判断是否是UI.dll
            {
                try
                {
                    FileInfo fi = new FileInfo(dllFile);
                    //判断是否是Plugin.xxxxxxx.dll
                    if (!fi.Name.StartsWith("Plugin.") || !fi.Name.EndsWith(".dll")) continue;
                    Assembly assemPlugIn = AppDomain.CurrentDomain.Load(Assembly.LoadFile(fi.FullName).GetName());// 该方法会占用文件 但可以调试
                     //判断是否包含ObjBase
                    foreach (Type type in assemPlugIn.GetTypes())  
                    {
                        if (typeof(CamerasBase).IsAssignableFrom(type))//是ObjBase的子类
                        {
                            PluginsInfo info = new PluginsInfo();
                            if (GetPluginInfo(assemPlugIn, type, ref info))//获取插件名称
                            {
                                cPluginDic[info.Name] = info;
                            }
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
        }
        /// <summary>
        /// 获取插件类别
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool GetPluginInfo(Assembly assemPlugIn, Type type, ref PluginsInfo info)
        {
            try
            {
                object[] categoryObjs = type.GetCustomAttributes(typeof(CategoryAttribute), true);
                object[] dispNameObjs = type.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                info.Category = (((CategoryAttribute)categoryObjs[0]).Category);
                info.Name = (((DisplayNameAttribute)dispNameObjs[0]).DisplayName);
                info.ModObjType = type;

                foreach (Type tempType in assemPlugIn.GetTypes())
                {
                    if (typeof(CamerasBase).IsAssignableFrom(tempType))//是FormBase的子类
                    {
                        info.ModFormType = tempType;
                        info.IconImage = Resources.图像采集;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
            return false;
        }
    }
}
