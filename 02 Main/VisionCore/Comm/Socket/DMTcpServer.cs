using VisionCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using VisionCore;
namespace DMSkin.Socket
{
    [Serializable]
    public class DMTcpServer : Component
    {
        public DMTcpServer()
        {
            this._ServerIp = "0.0.0.0";
            this._ServerPort = 8000;
            this.ClientSocketList = new List<System.Net.Sockets.Socket>();
            this.CreateIContainer();
            this.ClientSocketList = new List<System.Net.Sockets.Socket>();
            this.ClientSocketList.Clear();
        }

        public DMTcpServer(IContainer container)
        {
            this._ServerIp = "0.0.0.0";
            this._ServerPort = 8000;
            this.ClientSocketList = new List<System.Net.Sockets.Socket>();
            container.Add(this);
            this.CreateIContainer();
            this.ClientSocketList = new List<System.Net.Sockets.Socket>();
            this.ClientSocketList.Clear();
        }

        /// <summary>
        /// 本机监听IP,默认是本地IP
        /// </summary>
        [Description("本机监听IP,默认是本地IP")]
        [Category("TCP服务端")]
        public string ServerIp
        {
            get
            {
                return this._ServerIp;
            }
            set
            {
                this._ServerIp = value;
            }
        }

        /// <summary>
        /// 本机监听端口,默认是8000
        /// </summary>
        [Category("TCP服务端")]
        [Description("本机监听端口,默认是8000")]
        public int ServerPort
        {
            get
            {
                return this._ServerPort;
            }
            set
            {
                this._ServerPort = value;
            }
        }

        /// <summary>
        /// 开启服务
        /// </summary>
        public bool Start()
        {
            try
            {
                if (!this.IsStartListening)
                {
                    this.ServerSocket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    this.ServerSocket.Bind(new IPEndPoint(IPAddress.Parse(this.ServerIp), this.ServerPort));
                    this.ServerSocket.Listen(10000);
                    this.IsStartListening = true;
                    this.OnTcpServerStateInfoEnterHead(string.Format("服务端Ip:{0},端口:{1}已启动监听", this.ServerIp, this.ServerPort), SocketState.StartListening);
                   // ShowMsg.send_log(string.Format("服务端Ip:{0},端口:{1}已启动监听", this.ServerIp, this.ServerPort));
                    this.StartSockst = new Thread(new ThreadStart(this.StartSocketListening));
                    this.StartSockst.Start();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (SocketException ex)
            {
                 MessageBox.Show(ex.Message);
                this.OnTcpServerErrorMsgEnterHead(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 停止服务
        /// </summary>
        public void Stop()
        {
            try
            {
                this.IsStartListening = false;
                if (this.StartSockst != null)
                {
                    this.StartSockst.Interrupt();
                    this.StartSockst.Abort();
                }
                if (this.ServerSocket != null)
                {
                    this.ServerSocket.Close();
                }
                this.OnTcpServerStateInfoEnterHead(string.Format("服务端Ip:{0},端口:{1}已停止监听", this.ServerIp, this.ServerPort), SocketState.StopListening);
                for (int i = 0; i < this.ClientSocketList.Count; i++)
                {
                    this.OnTcpServerOfflineClientEnterHead(this.ClientSocketList[i]);
                    this.ClientSocketList[i].Shutdown(SocketShutdown.Both);
                }
               // GC.Collect();
            }
            catch (SocketException)
            {
            }
        }
        /// <summary>
        /// 开始监听
        /// </summary>
        public void StartSocketListening()
        {
            try
            {

                while (this.IsStartListening)
                {
                    System.Net.Sockets.Socket socket = this.ServerSocket.Accept();
                    try
                    {
                        Thread.Sleep(10);
                        this.ClientSocketList.Add(socket);
                        string text = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
                        string text2 = ((IPEndPoint)socket.RemoteEndPoint).Port.ToString();
                        this.OnTcpServerStateInfoEnterHead(string.Concat(new string[]
                        {
                            "<",
                            text,
                            "：",
                            text2,
                            ">---上线"
                        }), SocketState.ClientOnline);
                        this.OnTcpServerOnlineClientEnterHead(socket);
                        this.OnTcpServerReturnClientCountEnterHead(this.ClientSocketList.Count);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(this.ClientSocketCallBack), socket);
                       // Log.Tip($"{text} 客户端已经连接");
                    }
                    catch (Exception)
                    {
                        socket.Shutdown(SocketShutdown.Both);
                        this.OnTcpServerOfflineClientEnterHead(socket);
                        this.ClientSocketList.Remove(socket);
                    }
                }
            }
            catch (Exception ex)
            {
                this.OnTcpServerErrorMsgEnterHead(ex.Message);
            }
        }
        /// <summary>
        /// 客户端数据接收 自动剔除僵尸客户端
        /// </summary>
        /// <param name="obj"></param>
        public void ClientSocketCallBack(object obj)
        {
            System.Net.Sockets.Socket socket = (System.Net.Sockets.Socket)obj;
            while (this.IsStartListening)
            {
                Thread.Sleep(10);
                byte[] array = new byte[1024];
                try
                {
                    int num = socket.Receive(array);
                    if (num > 0)
                    {
                        byte[] array2 = new byte[num];
                        Array.Copy(array, 0, array2, 0, num);
                        this.OnTcpServerReceviceByte(socket, array2);
                    }
                    else if (num == 0)
                    {
                        SocketExitMethod(socket);

                        break;
                    }
                }
                catch(Exception ex)
                {
                    string ip = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
                    string port = ((IPEndPoint)socket.RemoteEndPoint).Port.ToString();

                     Debug.WriteLine($" {ip}:{port} 异常信息为:{ex.Message}");
                    SocketExitMethod(socket);
                    break;
                }
            }
        }

        private void SocketExitMethod(System.Net.Sockets.Socket socket)
        {
            this.ClientSocketList.Remove(socket);
            string text = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
            string text2 = ((IPEndPoint)socket.RemoteEndPoint).Port.ToString();
            this.OnTcpServerStateInfoEnterHead(string.Concat(new string[]
            {
                            "<",
                            text,
                            "：",
                            text2,
                            ">---下线"
            }), SocketState.ClientOnOff);
            this.OnTcpServerOfflineClientEnterHead(socket);
            this.OnTcpServerReturnClientCountEnterHead(this.ClientSocketList.Count);
            // Log.Warn($"{text} 客户端已断开连接");
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        /// <param name="strData">发送字符串</param>
        public void SendData(string ip, int port, string strData, bool isSendByHex)
        {
            System.Net.Sockets.Socket socket = this.ResoultSocket(ip, port);
            try
            {
                if (socket != null)
                {
                    byte[] bytes;
                    if (isSendByHex == true)
                    {
                        bytes = HexTool.HexToByte(HexTool.StrToHexStr(strData));
                    }
                    else
                    {
                        bytes = Encoding.Default.GetBytes(strData);
                    }

                    List<System.Net.Sockets.Socket> temp = new List<System.Net.Sockets.Socket>();
                    temp.Add(socket);
                    //需要先判断发送的socket是否可用,如果对面没有接收,会导致在发送缓存区满了后,一直阻塞在这里 magical 2019-3-23 21:31:55
                    System.Net.Sockets.Socket.Select(null, temp, null, 1000);
                    foreach (System.Net.Sockets.Socket tempSocket in temp)
                    {
                        tempSocket.Send(bytes);
                    }
                }
            }
            catch (SocketException ex)
            {
                if (socket != null)
                {
                    socket.Shutdown(SocketShutdown.Both);
                }
                this.OnTcpServerErrorMsgEnterHead(ex.Message);
            }
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        /// <param name="dataBytes">发送字符集</param>
        public void SendData(string ip, int port, byte[] dataBytes)
        {
            System.Net.Sockets.Socket socket = this.ResoultSocket(ip, port);
            try
            {
                if (socket != null)
                {
                    socket.Send(dataBytes);
                }
            }
            catch (SocketException ex)
            {
                if (socket != null)
                {
                    socket.Shutdown(SocketShutdown.Both);
                }
                this.OnTcpServerErrorMsgEnterHead(ex.Message);
            }
        }
        /// <summary>
        /// 解析数据包
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">端口号</param>
        /// <returns></returns>
        public System.Net.Sockets.Socket ResoultSocket(string ip, int port)
        {
            System.Net.Sockets.Socket result = null;
            try
            {
                foreach (System.Net.Sockets.Socket socket in this.ClientSocketList)
                {
                    if (((IPEndPoint)socket.RemoteEndPoint).Address.ToString().Equals(ip) && port == ((IPEndPoint)socket.RemoteEndPoint).Port)
                    {
                        result = socket;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                this.OnTcpServerErrorMsgEnterHead(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// 接收原始Byte数组数据事件
        /// </summary>
        [Description("接收原始Byte数组数据事件")]
        [Category("TcpServer事件")]
        public event DMTcpServer.ReceviceByteEventHandler OnReceviceByte
        {
            add
            {
                DMTcpServer.ReceviceByteEventHandler receviceByteEventHandler = this._ReceviceByteEventHandler;
                DMTcpServer.ReceviceByteEventHandler temp;
                do
                {
                    temp = receviceByteEventHandler;
                    DMTcpServer.ReceviceByteEventHandler value2 = (DMTcpServer.ReceviceByteEventHandler)Delegate.Combine(temp, value);
                    receviceByteEventHandler = Interlocked.CompareExchange<DMTcpServer.ReceviceByteEventHandler>(ref this._ReceviceByteEventHandler, value2, temp);
                }
                while (receviceByteEventHandler != temp);
            }
            remove
            {
                DMTcpServer.ReceviceByteEventHandler receviceByteEventHandler = this._ReceviceByteEventHandler;
                DMTcpServer.ReceviceByteEventHandler temp;
                do
                {
                    temp = receviceByteEventHandler;
                    DMTcpServer.ReceviceByteEventHandler value2 = (DMTcpServer.ReceviceByteEventHandler)Delegate.Remove(temp, value);
                    receviceByteEventHandler = Interlocked.CompareExchange<DMTcpServer.ReceviceByteEventHandler>(ref this._ReceviceByteEventHandler, value2, temp);
                }
                while (receviceByteEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerReceviceByte(System.Net.Sockets.Socket temp, byte[] dataBytes)
        {
            if (this._ReceviceByteEventHandler != null)
            {
                this._ReceviceByteEventHandler(temp, dataBytes);
            }
        }

        /// <summary>
        /// 错误消息
        /// </summary>
        [Category("TcpServer事件")]
        [Description("错误消息")]
        public event DMTcpServer.ErrorMsgEventHandler OnErrorMsg
        {
            add
            {
                DMTcpServer.ErrorMsgEventHandler errorMsgEventHandler = this._ErrorMsgEventHandler;
                DMTcpServer.ErrorMsgEventHandler temp;
                do
                {
                    temp = errorMsgEventHandler;
                    DMTcpServer.ErrorMsgEventHandler value2 = (DMTcpServer.ErrorMsgEventHandler)Delegate.Combine(temp, value);
                    errorMsgEventHandler = Interlocked.CompareExchange<DMTcpServer.ErrorMsgEventHandler>(ref this._ErrorMsgEventHandler, value2, temp);
                }
                while (errorMsgEventHandler != temp);
            }
            remove
            {
                DMTcpServer.ErrorMsgEventHandler errorMsgEventHandler = this._ErrorMsgEventHandler;
                DMTcpServer.ErrorMsgEventHandler temp;
                do
                {
                    temp = errorMsgEventHandler;
                    DMTcpServer.ErrorMsgEventHandler value2 = (DMTcpServer.ErrorMsgEventHandler)Delegate.Remove(temp, value);
                    errorMsgEventHandler = Interlocked.CompareExchange<DMTcpServer.ErrorMsgEventHandler>(ref this._ErrorMsgEventHandler, value2, temp);
                }
                while (errorMsgEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerErrorMsgEnterHead(string msg)
        {
            if (this._ErrorMsgEventHandler != null)
            {
                this._ErrorMsgEventHandler(msg);
            }
        }
        /// <summary>
        /// 用户上线下线时更新客户端在线数量事件
        /// </summary>
        [Description("用户上线下线时更新客户端在线数量事件")]
        [Category("TcpServer事件")]
        public event DMTcpServer.ReturnClientCountEventHandler OnReturnClientCount
        {
            add
            {
                DMTcpServer.ReturnClientCountEventHandler returnClientCountEventHandler = this._ReturnClientCountEventHandler;
                DMTcpServer.ReturnClientCountEventHandler temp;
                do
                {
                    temp = returnClientCountEventHandler;
                    DMTcpServer.ReturnClientCountEventHandler value2 = (DMTcpServer.ReturnClientCountEventHandler)Delegate.Combine(temp, value);
                    returnClientCountEventHandler = Interlocked.CompareExchange<DMTcpServer.ReturnClientCountEventHandler>(ref this._ReturnClientCountEventHandler, value2, temp);
                }
                while (returnClientCountEventHandler != temp);
            }
            remove
            {
                DMTcpServer.ReturnClientCountEventHandler returnClientCountEventHandler = this._ReturnClientCountEventHandler;
                DMTcpServer.ReturnClientCountEventHandler temp;
                do
                {
                    temp = returnClientCountEventHandler;
                    DMTcpServer.ReturnClientCountEventHandler value2 = (DMTcpServer.ReturnClientCountEventHandler)Delegate.Remove(temp, value);
                    returnClientCountEventHandler = Interlocked.CompareExchange<DMTcpServer.ReturnClientCountEventHandler>(ref this._ReturnClientCountEventHandler, value2, temp);
                }
                while (returnClientCountEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerReturnClientCountEnterHead(int count)
        {
            if (this._ReturnClientCountEventHandler != null)
            {
                this._ReturnClientCountEventHandler(count);
            }
        }
        /// <summary>
        /// 监听状态改变时返回监听状态事件
        /// </summary>
        [Description("监听状态改变时返回监听状态事件")]
        [Category("TcpServer事件")]
        public event DMTcpServer.StateInfoEventHandler OnStateInfo
        {
            add
            {
                DMTcpServer.StateInfoEventHandler stateInfoEventHandler = this._StateInfoEventHandler;
                DMTcpServer.StateInfoEventHandler temp;
                do
                {
                    temp = stateInfoEventHandler;
                    DMTcpServer.StateInfoEventHandler value2 = (DMTcpServer.StateInfoEventHandler)Delegate.Combine(temp, value);
                    stateInfoEventHandler = Interlocked.CompareExchange<DMTcpServer.StateInfoEventHandler>(ref this._StateInfoEventHandler, value2, temp);
                }
                while (stateInfoEventHandler != temp);
            }
            remove
            {
                DMTcpServer.StateInfoEventHandler stateInfoEventHandler = this._StateInfoEventHandler;
                DMTcpServer.StateInfoEventHandler temp;
                do
                {
                    temp = stateInfoEventHandler;
                    DMTcpServer.StateInfoEventHandler value2 = (DMTcpServer.StateInfoEventHandler)Delegate.Remove(temp, value);
                    stateInfoEventHandler = Interlocked.CompareExchange<DMTcpServer.StateInfoEventHandler>(ref this._StateInfoEventHandler, value2, temp);
                }
                while (stateInfoEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerStateInfoEnterHead(string msg, SocketState state)
        {
            this._StateInfoEventHandler?.Invoke(msg, state);
          VisionCore. Log.Info( string.Format(msg));
        }
        /// <summary>
        /// 新客户端上线时返回客户端事件
        /// </summary>
        [Category("TcpServer事件")]
        [Description("新客户端上线时返回客户端事件")]
        public event DMTcpServer.AddClientEventHandler OnOnlineClient
        {
            add
            {
                DMTcpServer.AddClientEventHandler addClientEventHandler = this._AddClientEventHandler1;
                DMTcpServer.AddClientEventHandler temp;
                do
                {
                    temp = addClientEventHandler;
                    DMTcpServer.AddClientEventHandler value2 = (DMTcpServer.AddClientEventHandler)Delegate.Combine(temp, value);
                    addClientEventHandler = Interlocked.CompareExchange<DMTcpServer.AddClientEventHandler>(ref this._AddClientEventHandler1, value2, temp);
                }
                while (addClientEventHandler != temp);
            }
            remove
            {
                DMTcpServer.AddClientEventHandler addClientEventHandler = this._AddClientEventHandler1;
                DMTcpServer.AddClientEventHandler temp;
                do
                {
                    temp = addClientEventHandler;
                    DMTcpServer.AddClientEventHandler value2 = (DMTcpServer.AddClientEventHandler)Delegate.Remove(temp, value);
                    addClientEventHandler = Interlocked.CompareExchange<DMTcpServer.AddClientEventHandler>(ref this._AddClientEventHandler1, value2, temp);
                }
                while (addClientEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerOnlineClientEnterHead(System.Net.Sockets.Socket temp)
        {
            if (this._AddClientEventHandler1 != null)
            {
                this._AddClientEventHandler1(temp);
            }
        }
        /// <summary>
        /// 客户端下线时返回客户端事件
        /// </summary>
        [Description("客户端下线时返回客户端事件")]
        [Category("TcpServer事件")]
        public event DMTcpServer.AddClientEventHandler OnOfflineClient
        {
            add
            {
                DMTcpServer.AddClientEventHandler addClientEventHandler = this._AddClientEventHandler2;
                DMTcpServer.AddClientEventHandler temp;
                do
                {
                    temp = addClientEventHandler;
                    DMTcpServer.AddClientEventHandler value2 = (DMTcpServer.AddClientEventHandler)Delegate.Combine(temp, value);
                    addClientEventHandler = Interlocked.CompareExchange<DMTcpServer.AddClientEventHandler>(ref this._AddClientEventHandler2, value2, temp);
                }
                while (addClientEventHandler != temp);
            }
            remove
            {
                DMTcpServer.AddClientEventHandler addClientEventHandler = this._AddClientEventHandler2;
                DMTcpServer.AddClientEventHandler temp;
                do
                {
                    temp = addClientEventHandler;
                    DMTcpServer.AddClientEventHandler value2 = (DMTcpServer.AddClientEventHandler)Delegate.Remove(temp, value);
                    addClientEventHandler = Interlocked.CompareExchange<DMTcpServer.AddClientEventHandler>(ref this._AddClientEventHandler2, value2, temp);
                }
                while (addClientEventHandler != temp);
            }
        }

        protected virtual void OnTcpServerOfflineClientEnterHead(System.Net.Sockets.Socket temp)
        {
            if (this._AddClientEventHandler2 != null)
            {
                this._AddClientEventHandler2(temp);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this._IContainer != null)
            {
                this._IContainer.Dispose();
            }
            base.Dispose(disposing);
        }

        private void CreateIContainer()
        {
            this._IContainer = new Container();
        }

        public System.Net.Sockets.Socket ServerSocket;
        public Thread StartSockst;
        private string _ServerIp;
        private int _ServerPort;
        public bool IsStartListening;
        private List<System.Net.Sockets.Socket> m_ClientSocketList;
        public System.Collections.Generic.List<System.Net.Sockets.Socket> ClientSocketList //强制下线一个 但别的线程正在遍历该list 会出错
        {
            get
            {
                return m_ClientSocketList;
            }
            set
            {
                m_ClientSocketList = value;
            }
        }
        // public List<System.Net.Sockets.Socket> ClientSocketList;
        private IContainer _IContainer;

        private DMTcpServer.ReceviceByteEventHandler _ReceviceByteEventHandler;
        private DMTcpServer.ErrorMsgEventHandler _ErrorMsgEventHandler;
        private DMTcpServer.ReturnClientCountEventHandler _ReturnClientCountEventHandler;
        private DMTcpServer.StateInfoEventHandler _StateInfoEventHandler;
        private DMTcpServer.AddClientEventHandler _AddClientEventHandler1;
        private DMTcpServer.AddClientEventHandler _AddClientEventHandler2;

        public delegate void ReceviceByteEventHandler(System.Net.Sockets.Socket temp, byte[] dataBytes);
        public delegate void ErrorMsgEventHandler(string msg);
        public delegate void ReturnClientCountEventHandler(int count);
        public delegate void StateInfoEventHandler(string msg, SocketState state);
        public delegate void AddClientEventHandler(System.Net.Sockets.Socket temp);
        public delegate void OfflineClientEventHandler(System.Net.Sockets.Socket temp);
    }
}
