
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace RexView
{
    class SerialTool
    {
        /// <summary>
        /// BinaryFormatter序列化
        /// </summary>
        /// <param name="item">对象</param>
        public static void ToBinary<T>(T item, string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                formatter.Serialize(stream, item);
                stream.Close();
            }
        }

        /// <summary>
        /// BinaryFormatter反序列化
        /// </summary>
        /// <param name="str">字符串序列</param>
        public static T FromBinary<T>(string fileName)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    T temp = (T)formatter.Deserialize(stream);
                    stream.Close();
                    return temp;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return default(T);
            }
        }
    }
}
