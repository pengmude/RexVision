using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore
{
    /// <summary>
    /// 对象深拷贝
    /// </summary>
    public class CloneObject
    {
        /// <summary>
        /// 对象深拷贝
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="obj">对象</param>
        /// <returns>内存地址不同，数据相同的对象</returns>
        public static T DeepCopy<T>(T obj)
        {
            object retval=null;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    //序列化成流
                    bf.Serialize(ms, obj);
                    ms.Seek(0, SeekOrigin.Begin);
                    //反序列化成对象
                    retval = bf.Deserialize(ms);
                }               
            }           
            catch { }
            return (T)retval;
        }

        /// <summary>
        /// 深拷贝函数
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static object DeepCopyObject(object obj)
        {
            if (obj != null)
            {
                object obj2 = Activator.CreateInstance(obj.GetType());
                foreach (FieldInfo info in obj.GetType().GetFields())
                {
                    if (info.FieldType.GetInterface("IList", false) == null)
                    {
                        info.SetValue(obj2, info.GetValue(obj));
                    }
                    else
                    {
                        IList list = (IList)info.GetValue(obj2);
                        if (list != null)
                        {
                            foreach (object obj3 in (IList)info.GetValue(obj))
                            {
                                list.Add(DeepCopyObject(obj3));
                            }
                        }
                    }
                }
                return obj2;
            }
            return null;
        }

    }
}
