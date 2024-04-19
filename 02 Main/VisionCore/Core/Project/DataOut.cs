using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisionCore
{
    /// <summary>
    /// 对应 数据出队 模块
    /// </summary>
    public class DataOut
    {
        //容器
        public static Dictionary<string, DataOut> s_QueueDic = new Dictionary<string, DataOut>();
        public static Dictionary<string, AutoResetEvent> s_QueueSignDic = new Dictionary<string, AutoResetEvent>();
        public string QueueKey { get; set; }
        public bool IsLimitLength = true;//是否限制长度
        public int LimitLength = 1;// 队列的长度 最小值为1
        public bool IsWait = false;//是否阻塞
        public bool IsDeleteData = true;//数据出队的时候 是否删除出队的数据
        public bool IsIgnoreError = false;//忽略错误
        private List<object> m_DataQueueList = new List<object>();//队列
        private List<DataMode> m_DataTypeList = new List<DataMode>();
        public DataOut()
        {
            QueueKey = $"DataOut{s_QueueDic.Count}";
            s_QueueDic[QueueKey] = this;
            s_QueueSignDic[QueueKey] = new AutoResetEvent(false);
        }


        #region 定义数据队列
        public void DefineIntQueue()
        {
            m_DataQueueList.Add(new List<int>());
            m_DataTypeList.Add(DataMode.Int);
            DataCell mData = new DataCell("", 1, DataType.单量, DataMode.Int, "", "注释", "0", 1, "0", DataAtrr.数据队列);
        }
        public void DefineIntListQueue()
        {
            m_DataQueueList.Add(new List<List<int>>());
            m_DataTypeList.Add(DataMode.IntArr);
        }
        public void DefineBoolQueue()
        {
            m_DataQueueList.Add(new List<bool>());
            m_DataTypeList.Add(DataMode.Bool);
        }
        public void DefineBoolListQueue()
        {
            m_DataQueueList.Add(new List<List<bool>>());
            m_DataTypeList.Add(DataMode.BoolArr);
        }
        public void DefineDoubleQueue()
        {
            m_DataQueueList.Add(new List<double>());
            m_DataTypeList.Add(DataMode.Double);
        }
        public void DefineDoubleListQueue()
        {
            m_DataQueueList.Add(new List<List<double>>());
            m_DataTypeList.Add(DataMode.DoubleArr);
        }
        public void DefineStringQueue()
        {
            m_DataQueueList.Add(new List<string>());
            m_DataTypeList.Add(DataMode.String);
        }
        public void DefineStringListQueue()
        {
            m_DataQueueList.Add(new List<List<string>>());
            m_DataTypeList.Add(DataMode.StringArr);
        }

        #endregion


        //获取队列长度
        public int GetQueueCount()
        {
            return m_DataQueueList.Count;
        }

        //根据索引获取DataMode
        public DataMode GetDataType(int index)
        {
            return m_DataTypeList[index];
        }

        // 根据索引获取 对应的 Queue
        public object GetDataQueue(int index)
        {
            return m_DataQueueList[index];
        }
        //
        public bool Execute()
        {
            bool flag = false;

            if (IsWait == true)
            {
                s_QueueSignDic[QueueKey].Reset();

                lock (this)//锁住 避免 数据入队 正在执行
                {
                    //判断能否出队成功,出队成功就不阻塞
                    bool tempFlag = IsDeleteData;//先试着出一次队出队成功就不用阻塞,出队失败就阻塞
                    IsDeleteData = false;
                    IsIgnoreError = true;//屏蔽错误提示
                    flag = FlushDataOut();
                    IsIgnoreError = false;//还原错误提示
                    IsDeleteData = tempFlag;
                }

                if (flag == false)
                {
                    s_QueueSignDic[QueueKey].WaitOne();//阻塞
                }

            }

            flag = FlushDataOut();

            return flag;
        }

        private bool FlushDataOut()
        {
            bool flag = true;
            for (int i = 0; i < m_DataTypeList.Count; i++)
            {
                int length = 0;
                switch (m_DataTypeList[i])
                {
                    case DataMode.Int:
                        List<int> tempList1 = (List<int>)m_DataQueueList[i];
                        length = tempList1.Count();
                        if (length > 0)
                        {

                            if (IsLimitLength == false || (IsLimitLength == true && length >= LimitLength))
                            {
                                if (IsLimitLength == true) tempList1.RemoveRange(0, length - LimitLength);//长度限制,删除多余的数据

                                int value;
                                if (IsDeleteData == true)
                                {
                                    value = tempList1.First();
                                    tempList1.RemoveAt(0);//删除第一个
                                }
                                else
                                {
                                    value = tempList1.First();
                                }

                                if (IsIgnoreError == false) Debug.WriteLine($"输出出队数据{value}");
                            }
                            else
                            {

                                flag = false;
                            }
                        }
                        else
                        {
                            if (IsIgnoreError == false) Debug.WriteLine($"{m_DataTypeList[i].ToString() }数据出队失败");
                            flag = false;
                        }
                        break;
                    case DataMode.IntArr:
                        List<List<int>> tempList2 = (List<List<int>>)m_DataQueueList[i];
                        length = tempList2.Count();
                        if (length > 0)
                        {

                            if (IsLimitLength == false || (IsLimitLength == true && length >= LimitLength))
                            {
                                if (IsLimitLength == true) tempList2.RemoveRange(0, length - LimitLength);//长度限制,删除多余的数据

                                List<int> value;
                                if (IsDeleteData == true)
                                {
                                    value = tempList2.First();
                                    tempList2.RemoveAt(0);//删除第一个
                                }
                                else
                                {
                                    value = tempList2.First();
                                }

                                if (IsIgnoreError == false) Debug.WriteLine($"输出出队数据 int[]{String.Join(",", value)}");
                            }
                            else
                            {

                                flag = false;
                            }
                        }
                        else
                        {
                            if (IsIgnoreError == false) Debug.WriteLine($"{m_DataTypeList[i].ToString() }数据出队失败");
                            flag = false;
                        }
                        break;
                    case DataMode.String:
                        List<string> tempList3 = (List<string>)m_DataQueueList[i];
                        length = tempList3.Count();
                        if (length > 0)
                        {

                            if (IsLimitLength == false || (IsLimitLength == true && length >= LimitLength))
                            {
                                if (IsLimitLength == true) tempList3.RemoveRange(0, length - LimitLength);//长度限制,删除多余的数据

                                string value;
                                if (IsDeleteData == true)
                                {
                                    value = tempList3.First();
                                    tempList3.RemoveAt(0);//删除第一个
                                }
                                else
                                {
                                    value = tempList3.First();
                                }

                                if (IsIgnoreError == false) Debug.WriteLine($"输出出队数据{value}");
                            }
                            else
                            {

                                flag = false;
                            }
                        }
                        else
                        {
                            if (IsIgnoreError == false) Debug.WriteLine($"{m_DataTypeList[i].ToString() }数据出队失败");
                            flag = false;
                        }
                        break;
                    case DataMode.StringArr:
                        List<List<string>> tempList4 = (List<List<string>>)m_DataQueueList[i];
                        length = tempList4.Count();
                        if (length > 0)
                        {

                            if (IsLimitLength == false || (IsLimitLength == true && length >= LimitLength))
                            {
                                if (IsLimitLength == true) tempList4.RemoveRange(0, length - LimitLength);//长度限制,删除多余的数据

                                List<string> value;
                                if (IsDeleteData == true)
                                {
                                    value = tempList4.First();
                                    tempList4.RemoveAt(0);//删除第一个
                                }
                                else
                                {
                                    value = tempList4.First();
                                }

                                if (IsIgnoreError == false)
                                    Debug.WriteLine($"输出出队数据 string[]{String.Join(",", value)}");
                            }
                            else
                            {

                                flag = false;
                            }
                        }
                        else
                        {
                            if (IsIgnoreError == false)
                                Debug.WriteLine($"{m_DataTypeList[i].ToString() }数据出队失败");
                            flag = false;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (flag == false)
            {
                if (IsIgnoreError == false)
                    Debug.WriteLine($"输出出队数据失败");
            }
            return flag;
        }

        /// <summary>
        /// 清空队列
        /// </summary>
        public void Clear()
        {
            lock (this)
            {
                m_DataQueueList.Clear();
                m_DataTypeList.Clear();
                s_QueueSignDic[QueueKey].Set();
            }
        }
    }
}
