using DMSkin.Socket;
using PCComm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace VisionCore
{
    //通讯模式
    public enum CommunicationModel
    {
        TcpClient = 0,//客户端
        TcpServer = 1,//服务端
        UDP = 2,//udp
        COM = 3//串口
    }
    public delegate void ReceiveString(string str);
    [Serializable]
    public class ECom
    {
        [NonSerialized]
        private AutoResetEvent m_RecStrSignal = new AutoResetEvent(false);
        private Queue<string> m_RecStrQueue = new Queue<string>();//接收信号总数 为0 的时候 表示没有接收到信号
        private bool m_IsStartRec = false;//是否开始监听接收
        public string m_ReadData = "";//收到的数据
        public event ReceiveString ReceiveString;//接受数据事件
        public string Key { get; set; }//
        public int Encode { get; set; }//编号
        public CommunicationModel CommunicationModel { get; set; } = CommunicationModel.TcpServer;//通讯模式
        public bool IsConnected { get; set; }// 是否开始连接 或监听

        public bool IsSendByHex { get; set; }// 使用十六进制发送
        public bool IsReceivedByHex { get; set; }// 使用十六进制接收

        private bool m_IsPlcDisconnect = false;//plc断开连接的时候 不显示下线提示 目前只有tcp客户端才会用到

        #region "网口参数"
        public string RemoteIP { get; set; } = "127.0.0.1";         //远程ip
        public int RemotePort { get; set; } = 9000;           //远程端口
        public int LocalPort { get; set; } = 8000;           //本地端口

        private List<string> m_SocketIpPortList = new List<string>();//作为tcp服务端的时候 显示客户端的信息
        #endregion

        #region "串口参数"
        public string PortName { get; set; } = "COM1";//串口号
        public string BaudRate { get; set; } = "9600";//波特率
        public string Parity { get; set; } = "None";//校验位
        public string DataBits { get; set; } = "8";//数据位
        public string StopBits { get; set; } = "One";//停止位

        #endregion

        public string Remarks { get; set; }               //备注
        [NonSerialized]
        private DMTcpServer m_DMTcpServer;//tcp服务端
        [NonSerialized]
        private DMTcpClient m_DMTcpClient;//tcp客户端
        [NonSerialized]
        private DMUdpClient m_DMUdpClient;//udp
        [NonSerialized]
        private MySerialPort m_MySerialPort;//串口

        public DMTcpClient DMTcpClient()//返回tcp客户端
        {
            return m_DMTcpClient;
        }

        // public bool IsHasObjectConnected { get; set; }// 是否已经连接上对象

        private int m_ObjectConnectedCount = 0;//已经连接目标数量 tcp服务端会有多个的可能
        public bool IsHasObjectConnected
        {
            get
            {
                return m_ObjectConnectedCount > 0 ? true : false;
            }
            set
            {
                if (value == true)
                {
                    if (m_ObjectConnectedCount < 0)
                    {
                        m_ObjectConnectedCount = 1;
                    }
                    else
                    {
                        m_ObjectConnectedCount++;
                    }
                }
                else
                {
                    m_ObjectConnectedCount--;
                }
            }
        }

        /// <summary>
        /// 手动 设置连接状态 针对eplc添加的功能
        /// </summary>
        /// <param name="flag"></param>
        public void SetObjectConnected(bool flag)
        {
            m_ObjectConnectedCount = flag == true ? 1 : 0;
        }

        public ECom()
        {
            ReceiveString += ECommunacation_ReceiveString;
        }

        /// <summary>
        /// 添加接收的数据到队列中
        /// </summary>
        public void AddRecString(string recStr)
        {
            if (m_IsStartRec == true)
            {
                m_RecStrQueue.Enqueue(recStr);

                if (m_RecStrQueue.Count == 1)
                {
                    m_RecStrSignal.Set();
                }
            }
        }
        private void ECommunacation_ReceiveString(string str)
        {
            m_ReadData = m_ReadData + str;
            Log.Info( $"[{Key}]接收数据:{str}");
        }

        public bool Connect()
        {
           // if (CommunicationModel==null) { }
            if (IsConnected == true) return true;//已经连接 则不执行
            if (m_RecStrSignal==null) { m_RecStrSignal = new AutoResetEvent(false); }
            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (m_DMTcpClient == null)
                    {
                        m_DMTcpClient = new DMTcpClient();
                        m_DMTcpClient.OnReceviceByte += M_DMTcpClient_OnReceviceByte;
                        m_DMTcpClient.OnStateInfo += M_DMTcpClient_OnStateInfo;
                        m_DMTcpClient.OnErrorMsg += M_DMTcpClient_OnErrorMsg;
                    }
                    m_DMTcpClient.ServerIp = RemoteIP;
                    m_DMTcpClient.ServerPort = RemotePort;
                    m_DMTcpClient.StartConnection();
                    IsConnected = true;

                    break;
                case CommunicationModel.TcpServer:
                    if (m_DMTcpServer == null)
                    {
                        m_DMTcpServer = new DMTcpServer();
                        m_DMTcpServer.OnReceviceByte += M_DMTcpServer_OnReceviceByte;
                        m_DMTcpServer.OnOnlineClient += M_DMTcpServer_OnOnlineClient;
                        m_DMTcpServer.OnOfflineClient += M_DMTcpServer_OnOfflineClient;
                    }
                    m_ObjectConnectedCount = 0;
                    m_SocketIpPortList.Clear();
                    m_DMTcpServer.ServerIp = "0.0.0.0";
                    m_DMTcpServer.ServerPort = LocalPort;
                    IsConnected = m_DMTcpServer.Start();

                    break;
                case CommunicationModel.UDP:
                    if (m_DMUdpClient == null)
                    {
                        m_DMUdpClient = new DMUdpClient();

                        m_DMUdpClient.ReceiveByte += M_DMUdpClient_ReceiveByte;
                    }
                    m_DMUdpClient.RemoteIp = RemoteIP;
                    m_DMUdpClient.RemotePort = RemotePort;
                    m_DMUdpClient.LocalPort = LocalPort;
                    IsConnected = m_DMUdpClient.Start();
                    IsHasObjectConnected = IsConnected;

                    break;
                case CommunicationModel.COM:

                    if (m_MySerialPort == null)
                    {
                        m_MySerialPort = new MySerialPort();
                        m_MySerialPort.OnReceiveString += M_MySerialPort_OnReceiveString;
                    }
                    m_MySerialPort.PortName = PortName;
                    m_MySerialPort.BaudRate = BaudRate;
                    m_MySerialPort.DataBits = DataBits;
                    m_MySerialPort.StopBits = StopBits;
                    m_MySerialPort.Parity = Parity;

                    IsConnected = m_MySerialPort.OpenPort();

                    IsHasObjectConnected = IsConnected;
                    break;
                default:
                    break;
            }

            return IsConnected;
        }

        private void M_DMTcpClient_OnErrorMsg(string msg)
        {
            if (IsHasObjectConnected == true)
            {
                IsHasObjectConnected = false;
                Log.Info( $"与 服务器的连接断开  {RemoteIP}:{RemotePort}");
            }

        }

        private void M_DMTcpClient_OnStateInfo(string msg, SocketState state)
        {
            if (m_IsPlcDisconnect == true) return;

            switch (state)
            {
                case SocketState.Connecting:
                    break;
                case SocketState.Connected:
                    IsHasObjectConnected = true;
                    Log.Info( $"已成功连接服务器  {RemoteIP}:{RemotePort}");
                    break;
                case SocketState.Reconnection:
                    break;
                case SocketState.Disconnect:
                    if (IsHasObjectConnected == true)
                    {
                        IsHasObjectConnected = false;
                        Log.Info( $"与服务器的连接断开  {RemoteIP}:{RemotePort}");
                    }
                    break;
                case SocketState.StartListening:
                    break;
                case SocketState.StopListening:
                    break;
                case SocketState.ClientOnline:
                    break;
                case SocketState.ClientOnOff:
                    break;
                default:
                    break;
            }
        }

        //作为服务器 ,客户端已经下线
        private void M_DMTcpServer_OnOfflineClient(Socket temp)
        {
            IsHasObjectConnected = false;
            m_SocketIpPortList.Remove(temp.RemoteEndPoint.ToString());
            Log.Info( $"{temp.RemoteEndPoint.ToString()}客户端已断开连接");
            if (IsHasObjectConnected == true)//还有连接则提示剩余信息
            {
                Log.Info( $"当前连接的客户端数量为 {m_ObjectConnectedCount} , \r\n{string.Join("\r\n", m_SocketIpPortList)}");
            }
        }

        //作为服务器 ,客户端已经上线
        private void M_DMTcpServer_OnOnlineClient(Socket temp)
        {

            IsHasObjectConnected = true;
            m_SocketIpPortList.Add(temp.RemoteEndPoint.ToString());
           Debug.WriteLine($"{temp.RemoteEndPoint.ToString()} 客户端已经连接");

            if (m_ObjectConnectedCount > 1)//还有连接则提示剩余信息
            {
                Log.Info( $"当前连接的客户端数量为 {m_ObjectConnectedCount} , \r\n{string.Join("\r\n", m_SocketIpPortList)}");
            }
        }

        public void DisConnect()
        {
            m_IsPlcDisconnect = false;
            IsConnected = false;
            StopRecStrSignal();
            m_ObjectConnectedCount = 0;
            m_SocketIpPortList.Clear();
            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (m_DMTcpClient != null) m_DMTcpClient.StopConnection();
                    break;
                case CommunicationModel.TcpServer:
                    if (m_DMTcpServer != null) m_DMTcpServer.Stop();
                    break;
                case CommunicationModel.UDP:
                    if (m_DMUdpClient != null) m_DMUdpClient.Stop();
                    IsHasObjectConnected = false;
                    break;
                case CommunicationModel.COM:
                    if (m_MySerialPort != null) m_MySerialPort.ClosePort();
                    IsHasObjectConnected = false;
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 三菱plc连接的时候 只能有一个客户端连接,plc访问的时候 先断开 eplc 故单独使用这个
        /// </summary>
        public void PlcDisConnect()
        {
            m_IsPlcDisconnect = true;
            StopRecStrSignal();

            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (m_DMTcpClient != null) m_DMTcpClient.StopConnection();
                    break;
                default:
                    break;
            }
        }

        public bool SendStr(string str)
        {
            lock (this)
            {
                bool flag = false;
                if (IsConnected == false)
                {
                    return false;
                }

                if (IsSendByHex == true)
                {
                   Log.Info( $"16进制数据:{HexTool.StrToHexStr(str)}");
                }
                switch (CommunicationModel)
                {
                    case CommunicationModel.TcpClient:
                        if (m_DMTcpClient != null)
                        {
                            flag = (bool)m_DMTcpClient?.SendCommand(str, IsSendByHex);
                        }

                        break;
                    case CommunicationModel.TcpServer:
                        if (m_DMTcpServer != null)
                        {
                            try
                            {
                                //强制下线,而此时正在发送数据,会到导致ClientSocketList内容变了 magical 2019-3-23 21:44:30
                                foreach (Socket s in m_DMTcpServer.ClientSocketList)
                                {
                                    if (s.Connected)
                                    {
                                        m_DMTcpServer?.SendData(((IPEndPoint)s.RemoteEndPoint).Address.ToString(), ((IPEndPoint)s.RemoteEndPoint).Port, str, IsSendByHex);
                                        flag = true;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                            }
                        }
                        break;
                    case CommunicationModel.UDP:
                        if (m_DMUdpClient != null)
                        {
                            m_DMUdpClient?.SendText(str, IsSendByHex);
                            flag = true;
                        }
                        break;
                    case CommunicationModel.COM:
                        if (m_MySerialPort != null)
                        {
                            flag = (bool)m_MySerialPort?.WriteData(str, IsSendByHex);
                        }
                        break;
                    default:
                        break;
                }

                if (flag == true)
                {
                   // Debug.WriteLine($"[{Key}]发送数据:{str}");
                    Log.Info( $"[{Key}]发送数据:{str}");
                }
                else
                {
                    //Debug.WriteLine($"[{Key}]发送数据失败");
                    Log.Info( $"[{Key}]发送数据失败");
                }
                return flag;
            }
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="pReturnStr"></param>
        public void GetStr(out string pReturnStr)
        {
            string str = "";

            m_IsStartRec = true;//开始监听回调

            m_RecStrSignal.Reset();//需要加这一句,因为断开连接的时候会执行 m_RecStrSignal.Set()
           
            if (m_RecStrQueue.Count>0)
            {
                str = m_RecStrQueue.Dequeue();
            }
            else
            {
                m_RecStrSignal.WaitOne();
                if (m_RecStrQueue.Count > 0)
                {
                    str = m_RecStrQueue.Dequeue();
                }
            }
            pReturnStr =str.Trim();//最终赋值
        }

        public void StopRecStrSignal()
        {
            lock (this)
            {
                m_IsStartRec = false;
                m_RecStrQueue.Clear();
                m_RecStrSignal.Set();//停止阻塞 当项目停止的时候 停止阻塞
            }
        }

        // tcp服务端接收数据
        private void M_DMTcpServer_OnReceviceByte(System.Net.Sockets.Socket temp, byte[] dataBytes)
        {
            lock (this)
            {
                string str = Encoding.Default.GetString(dataBytes).Trim().Trim('\0');
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsReceivedByHex == true) str = HexTool.StrToHexStr(str);
                    ReceiveString?.Invoke(str);
                    AddRecString(str);
                }
            }
        }

        // tcp客户端接收数据
        private void M_DMTcpClient_OnReceviceByte(byte[] dataBytes)
        {
            lock (this)
            {
                string str = Encoding.Default.GetString(dataBytes).Trim().Trim('\0');
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsReceivedByHex == true) str = HexTool.StrToHexStr(str);
                    ReceiveString?.Invoke(str);
                    AddRecString(str);
                }
            }
        }

        //串口接收数据
        private void M_MySerialPort_OnReceiveString(string str)
        {
            lock (this)
            {
                str = str.Trim('\0');
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsReceivedByHex == true) str = HexTool.StrToHexStr(str);
                    ReceiveString?.Invoke(str);
                    AddRecString(str);
                }
            }
        }

        //udp接收数据
        private void M_DMUdpClient_ReceiveByte(ReceiveDataEventArgs e)
        {
            lock (this)
            {
                string str = Encoding.Default.GetString(e.Buffer).Trim().Trim('\0');
                if (!string.IsNullOrWhiteSpace(str))
                {
                    if (IsReceivedByHex == true) str = HexTool.StrToHexStr(str);
                    ReceiveString?.Invoke(str);
                    AddRecString(str);
                }
            }
        }

        /// <summary>
        /// 返回当前ecom的 Socket 只有网络通讯才有,目前只支持tcpclient
        /// </summary>
        /// <returns></returns>
        public Socket GetSocket()
        {
            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    if (m_DMTcpClient != null)
                    {
                        return m_DMTcpClient.Tcpclient?.Client;
                    }
                    break;
                case CommunicationModel.TcpServer:
                     //Debug.WriteLine(" TcpServer暂不支持获取 socket");
                    Log.Info( " TcpServer暂不支持获取 socket");
                    break;
                case CommunicationModel.UDP:
                     //Debug.WriteLine(" UDP暂不支持获取 socket");
                    Log.Info( " UDP暂不支持获取 socket");
                    break;
                case CommunicationModel.COM:
                    // Debug.WriteLine(" COM不支持获取 socket");
                    Log.Info( " COM不支持获取 socket");
                    break;
                default:
                    break;
            }

            return null;
        }

        public string GetInfoStr()
        {
            string str = "";
            switch (CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    str = $"远程主机: {RemoteIP}:{RemotePort}";
                    break;
                case CommunicationModel.TcpServer:
                    str = $"本地主机: 0.0.0.0:{LocalPort}\r\n客户端连接数量: {m_ObjectConnectedCount}\r\n客户端信息:\r\n{String.Join("\r\n", m_SocketIpPortList)}";

                    break;
                case CommunicationModel.UDP:
                    str = $"本地主机: 0.0.0.0:{ LocalPort}\r\n远程主机: {RemoteIP}:{RemotePort}";
                    break;
                case CommunicationModel.COM:
                    str = $"串口号: {PortName}\r\n波特率: {BaudRate}\r\n校验位: {Parity}\r\n数据位: {DataBits}\r\n停止位: {StopBits}";
                    break;
                default:
                    break;
            }

            return str;
        }
        /// <summary>
        /// 设置串口回调数据解析规则 
        /// </summary>
        /// <param name="function"></param>
        public void SetSerialPortDataReceivedFunction(SerialPortDataReceivedFunction function)
        {
            //
            if (CommunicationModel == CommunicationModel.COM)
            {
                m_MySerialPort.DataReceivedFunction = function;
            }
        }
    }
}
