using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore
{
    /// <summary>
    /// 对应 数据入队 模块
    /// </summary>
    public class DataIn
    {
        public string QueueKey = "";     //队列的key 
        public int QueueIndex = 0;     //起始索引 

        private List<object> m_DataQueueInList = new List<object>();//要插入到队列的数据,使用后就清空
        private List<DataMode> m_DataTypeInList = new List<DataMode>();
        #region 添加数据
        public void AddIntQueueIn(int value)
        {
            m_DataQueueInList.Add(value);
            m_DataTypeInList.Add(DataMode.Int);
        }

        public void AddStringQueueIn(string value)
        {
            m_DataQueueInList.Add(value);
            m_DataTypeInList.Add(DataMode.String);
        }

        public void AddIntListQueueIn(List<int> value)
        {
            m_DataQueueInList.Add(value);
            m_DataTypeInList.Add(DataMode.IntArr);
        }

        public void AddStringListQueueIn(List<string> value)
        {
            m_DataQueueInList.Add(value);
            m_DataTypeInList.Add(DataMode.StringArr);
        }

        #endregion


        // 执行
        public bool Execute()
        {
            bool flag = true;

            try
            {
                if (!DataOut.s_QueueDic.ContainsKey(QueueKey))
                {
                    Debug.WriteLine($"没有找到对应的队列 [{QueueKey}]");
                    return false;//没有就入队失败
                }

                DataOut dataOut = DataOut.s_QueueDic[QueueKey];//拿到队列
                lock (dataOut)
                {
                    int dataOutLength = dataOut.GetQueueCount();
                    //判断插入的位置是否存在
                    if (dataOutLength < (QueueIndex + m_DataQueueInList.Count()))
                    {

                        Debug.WriteLine("入队变量的长度  超过 数据出队的变量的长度");
                        return false;
                    }
                    else if (QueueIndex < 0)
                    {

                        Debug.WriteLine("入队变量的索引 为负值");
                        return false;
                    }

                    for (int i = 0; i < m_DataQueueInList.Count; i++)
                    {
                        //判断入队数据和出队数据 类型是否一致
                        if (m_DataTypeInList[i] == dataOut.GetDataType(i + QueueIndex))
                        {
                            switch (m_DataTypeInList[i])
                            {
                                case DataMode.None:
                                    break;
                                case DataMode.Int:
                                    int value1 = (int)m_DataQueueInList[i];//获取值
                                    List<int> tempList1 = (List<int>)dataOut.GetDataQueue(i + QueueIndex);//获取队列

                                    tempList1.Add(value1);//更新队列

                                    break;
                                case DataMode.IntArr:
                                    List<int> value2 = (List<int>)m_DataQueueInList[i];//获取值
                                    List<List<int>> tempList2 = (List<List<int>>)dataOut.GetDataQueue(i + QueueIndex);//获取队列

                                    tempList2.Add(value2);//更新队列
                                    break;
                                case DataMode.String:
                                    string value3 = (string)m_DataQueueInList[i];//获取值
                                    List<string> tempList3 = (List<string>)dataOut.GetDataQueue(i + QueueIndex);//获取队列

                                    tempList3.Add(value3);//更新队列
                                    break;
                                case DataMode.StringArr:
                                    List<string> value4 = (List<string>)m_DataQueueInList[i];//获取值
                                    List<List<string>> tempList4 = (List<List<string>>)dataOut.GetDataQueue(i + QueueIndex);//获取队列

                                    tempList4.Add(value4);//更新队列
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Debug.WriteLine("数据入队类型 ] 与 对应的数据出队类型 不匹配");
                            WakeAll();

                            return false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                /// MessageBox.Show(ex);
            }
            finally
            {
                m_DataQueueInList.Clear();//入队后,将数据全部清空
                m_DataTypeInList.Clear();
                WakeAll();
            }

            return flag;
        }
        private void WakeAll()
        {
            DataOut.s_QueueSignDic[QueueKey].Set();
        }
    }
}
