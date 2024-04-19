using VisionCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace DMSkin.Socket
{
    public class DMTcpClient : Component
    {
        public DMTcpClient()
        {
            this._ReConnectionTime = 3000;
            this.CreateContainer();
        }

        public DMTcpClient(IContainer container)
        {
            this._ReConnectionTime = 3000;
            container.Add(this);
            this.CreateContainer();
        }
        /// <summary>
        /// 服务器IP地址
        /// </summary>
        [Description("服务端IP")]
        [Category("TcpClient属性")]
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
        /// 服务器监听端口
        /// </summary>
        [Description("服务端监听端口")]
        [Category("TcpClient属性")]
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
        /// TcpClient操作类
        /// </summary>
        [Description("TcpClient操作类")]
        [Browsable(false)]
        [Category("TcpClient隐藏属性")]
        public TcpClient Tcpclient
        {
            get
            {
                return this._Tcpclient;
            }
            set
            {
                this._Tcpclient = value;
            }
        }
        /// <summary>
        /// TcpClient连接服务端线程
        /// </summary>
        [Description("TcpClient连接服务端线程")]
        [Category("TcpClient隐藏属性")]
        [Browsable(false)]
        public Thread Tcpthread
        {
            get
            {
                return this._Tcpthread;
            }
            set
            {
                this._Tcpthread = value;
            }
        }
        /// <summary>
        /// TcpClient隐藏属性
        /// </summary>
        [Browsable(false)]
        [Category("TcpClient隐藏属性")]
        [Description("是否启动Tcp连接线程")]
        public bool IsStartTcpthreading
        {
            get
            {
                return this._IsStartTcpthreading;
            }
            set
            {
                this._IsStartTcpthreading = value;
            }
        }
        /// <summary>
        /// 连接是否关闭（用来断开重连）
        /// </summary>
        [Description("连接是否关闭（用来断开重连）")]
        [Category("TcpClient属性")]
        public bool Isclosed
        {
            get
            {
                return this._Isclosed;
            }
            set
            {
                this._Isclosed = value;
            }
        }
        /// <summary>
        /// 设置断开重连时间间隔单位（毫秒）（默认3000毫秒）
        /// </summary>
        [Category("TcpClient属性")]
        [Description("设置断开重连时间间隔单位（毫秒）（默认3000毫秒）")]
        public int ReConnectionTime
        {
            get
            {
                return this._ReConnectionTime;
            }
            set
            {
                this._ReConnectionTime = value;
            }
        }
        /// <summary>
        /// 接收Socket数据包 缓存字符串
        /// </summary>
        [Description("接收Socket数据包 缓存字符串")]
        [Category("TcpClient隐藏属性")]
        [Browsable(false)]
        public string Receivestr
        {
            get
            {
                return this._Receivestr;
            }
            set
            {
                this._Receivestr = value;
            }
        }
        /// <summary>
        /// 重连次数
        /// </summary>
        [Description("重连次数")]
        [Category("TcpClient隐藏属性")]
        [Browsable(false)]
        public int ReConectedCount
        {
            get
            {
                return this._ReConectedCount;
            }
            set
            {
                this._ReConectedCount = value;
            }
        }
        /// <summary>
        /// 开始连接
        /// </summary>
        public void StartConnection()
        {
            try
            {
                this.CreateConnection();
            }
            catch (Exception ex)
            {
                this.OnTcpClientErrorMsgEnterHead("错误信息：" + ex.Message);
            }
        }
        /// <summary>
        /// 创建连接 延时时间 ms  开始连接的时候不要延时,断线后需要延时
        /// </summary>
        private void CreateConnection(bool delayFlag = false)
        {
            if (this.Isclosed)
            {
                return;
            }
            if(delayFlag == true) Thread.Sleep(this.ReConnectionTime);

            this.Isclosed = true;
            this.Tcpclient = new TcpClient();
            this.Tcpthread = new Thread(new ThreadStart(this.MinitorConnection));
            this.IsStartTcpthreading = true;
            this.Tcpthread.Start();
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void StopConnection()
        {
            this.IsStartTcpthreading = false;
            this.Isclosed = false;
            if (this.Tcpclient != null)
            {
                this.Tcpclient.Close();
                this.Tcpclient = null;//设置为null 则不会激活断线重连  magical 2019-3-9 12:47:16
            }
            if (this.Tcpthread != null)
            {
                this.Tcpthread.Interrupt();
                this.Tcpthread.Abort();
            }
            this.OnTcpClientStateInfoEnterHead("断开连接", SocketState.Disconnect);
        }

        private void MinitorConnection()
        {
            byte[] array = new byte[5024];//增大缓存区 magical 2019-2-25 16:49:19
            try
            {
                while (this.IsStartTcpthreading)
                {
                    if (!this.Tcpclient.Connected)
                    {
                        try
                        {
                            if (this.ReConectedCount != 0)
                            {
                                this.OnTcpClientStateInfoEnterHead(string.Format("正在第{0}次重新连接服务器... ...", this.ReConectedCount), SocketState.Reconnection);
                              //  Log.Debug($"正在第{ this.ReConectedCount}次重新连接 {ServerIp} :{ ServerPort} 服务器... ...");
                            }
                            else
                            {
                                this.OnTcpClientStateInfoEnterHead("正在连接服务器... ...", SocketState.Connecting);
                            }
                            this.Tcpclient.Connect(IPAddress.Parse(this.ServerIp), this.ServerPort);
                            this.OnTcpClientStateInfoEnterHead("已连接服务器", SocketState.Connected);
                        }
                        catch
                        {
                            this.ReConectedCount++;
                            this.Isclosed = false;
                            this.IsStartTcpthreading = false;
                           continue;
                        }
                    }
                  
                    int num = this.Tcpclient.Client.Receive(array);
                    if (num == 0)
                    {
                        this.OnTcpClientStateInfoEnterHead("与服务器断开连接... ...", SocketState.Disconnect);
                        this.Isclosed = false;
                        this.ReConectedCount = 1;
                        this.IsStartTcpthreading = false;
                    }
                    else 
                    {
                        this.Receivestr = Encoding.Default.GetString(array, 0, num);
                        if (this.Receivestr.Trim() != "")
                        {
                            byte[] array2 = new byte[num];
                            Array.Copy(array, 0, array2, 0, num);
                            this.OnTcpClientReceviceByte(array2);
                        }
                    }
                }
                this.CreateConnection(true);//断线重连
            }
            catch (Exception ex)
            {
                if (Tcpclient != null)//
                {
                    this.OnTcpClientErrorMsgEnterHead("错误信息：" + ex.Message);
                  Debug.WriteLine($"{this.ServerIp}:{this.ServerPort} 发生异常, 异常信息为: {ex.Message} ");
                    this.Isclosed = false;
                    this.ReConectedCount = 1;
                    this.CreateConnection(true);//断线重连
                }
            }
        }

        /// <summary>
        /// 发送字符串
        /// </summary>
        /// <param name="cmdstr"></param>
        /// <param name="IsSendByHex">使用十六进制</param>
        /// <returns></returns>
        public bool SendCommand(string cmdstr,bool isSendByHex)
        {
            try
            {
                byte[] bytes;
                if (isSendByHex == true)
                {
                    bytes = HexTool.HexToByte(HexTool.StrToHexStr(cmdstr));
                }
                else
                {
                     bytes = Encoding.Default.GetBytes(cmdstr);
                }

                List<System.Net.Sockets.Socket> tempList = new List<System.Net.Sockets.Socket>();
                tempList.Add(this.Tcpclient.Client);
                //需要先判断发送的socket是否可用,如果对面没有接收,会导致在发送缓存区满了后,一直阻塞在这里 magical 2019-3-23 21:31:55
                System.Net.Sockets.Socket.Select(null, tempList, null, 1000);
                foreach (System.Net.Sockets.Socket tempSocket in tempList)
                {
                    tempSocket.Send(bytes);
                }

                return true;
            }
            catch (Exception ex)
            {
                this.OnTcpClientErrorMsgEnterHead(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// 发送文件
        /// </summary>
        /// <param name="filename"></param>
        public void SendFile(string filename)
        {
            this.Tcpclient.Client.BeginSendFile(filename, new AsyncCallback(this.SendFile), this.Tcpclient);
        }

        private void SendFile(IAsyncResult input)
        {
            try
            {
                TcpClient tcpClient = (TcpClient)input.AsyncState;
                tcpClient.Client.EndSendFile(input);
            }
            catch (SocketException)
            {
            }
        }
        /// <summary>
        /// 发送byte（）
        /// </summary>
        /// <param name="byteMsg"></param>
        public void SendCommand(byte[] byteMsg)
        {
            try
            {
                this.Tcpclient.Client.Send(byteMsg);
            }
            catch (Exception ex)
            {
                this.OnTcpClientErrorMsgEnterHead("错误信息：" + ex.Message);
            }
        }

        [Category("TcpClient事件")]
        [Description("接收Byte数据事件")]
        public event DMTcpClient.ReceviceByteEventHandler OnReceviceByte
        {
            add
            {
                DMTcpClient.ReceviceByteEventHandler receviceByteEventHandler = this._ReceviceByteEventHandler;
                DMTcpClient.ReceviceByteEventHandler temp;
                do
                {
                    temp = receviceByteEventHandler;
                    DMTcpClient.ReceviceByteEventHandler value2 = (DMTcpClient.ReceviceByteEventHandler)Delegate.Combine(temp, value);
                    receviceByteEventHandler = Interlocked.CompareExchange<DMTcpClient.ReceviceByteEventHandler>(ref this._ReceviceByteEventHandler, value2, temp);
                }
                while (receviceByteEventHandler != temp);
            }
            remove
            {
                DMTcpClient.ReceviceByteEventHandler receviceByteEventHandler = this._ReceviceByteEventHandler;
                DMTcpClient.ReceviceByteEventHandler temp;
                do
                {
                    temp = receviceByteEventHandler;
                    DMTcpClient.ReceviceByteEventHandler value2 = (DMTcpClient.ReceviceByteEventHandler)Delegate.Remove(temp, value);
                    receviceByteEventHandler = Interlocked.CompareExchange<DMTcpClient.ReceviceByteEventHandler>(ref this._ReceviceByteEventHandler, value2, temp);
                }
                while (receviceByteEventHandler != temp);
            }
        }

        protected virtual void OnTcpClientReceviceByte(byte[] date)
        {
            if (this._ReceviceByteEventHandler != null)
            {
                this._ReceviceByteEventHandler(date);
            }
        }

        [Category("TcpClient事件")]
        [Description("返回错误消息事件")]
        public event DMTcpClient.ErrorMsgEventHandler OnErrorMsg
        {
            add
            {
                DMTcpClient.ErrorMsgEventHandler errorMsgEventHandler = this._ErrorMsgEventHandler;
                DMTcpClient.ErrorMsgEventHandler temp;
                do
                {
                    temp = errorMsgEventHandler;
                    DMTcpClient.ErrorMsgEventHandler value2 = (DMTcpClient.ErrorMsgEventHandler)Delegate.Combine(temp, value);
                    errorMsgEventHandler = Interlocked.CompareExchange<DMTcpClient.ErrorMsgEventHandler>(ref this._ErrorMsgEventHandler, value2, temp);
                }
                while (errorMsgEventHandler != temp);
            }
            remove
            {
                DMTcpClient.ErrorMsgEventHandler errorMsgEventHandler = this._ErrorMsgEventHandler;
                DMTcpClient.ErrorMsgEventHandler temp;
                do
                {
                    temp = errorMsgEventHandler;
                    DMTcpClient.ErrorMsgEventHandler value2 = (DMTcpClient.ErrorMsgEventHandler)Delegate.Remove(temp, value);
                    errorMsgEventHandler = Interlocked.CompareExchange<DMTcpClient.ErrorMsgEventHandler>(ref this._ErrorMsgEventHandler, value2, temp);
                }
                while (errorMsgEventHandler != temp);
            }
        }

        protected virtual void OnTcpClientErrorMsgEnterHead(string msg)
        {
            if (this._ErrorMsgEventHandler != null)
            {
                this._ErrorMsgEventHandler(msg);
            }
        }
        /// <summary>
        /// 连接状态改变时返回连接状态事件
        /// </summary>
        [Description("连接状态改变时返回连接状态事件")]
        [Category("TcpClient事件")]
        public event DMTcpClient.StateInfoEventHandler OnStateInfo
        {
            add
            {
                DMTcpClient.StateInfoEventHandler stateInfoEventHandler = this._StateInfoEventHandler;
                DMTcpClient.StateInfoEventHandler temp;
                do
                {
                    temp = stateInfoEventHandler;
                    DMTcpClient.StateInfoEventHandler value2 = (DMTcpClient.StateInfoEventHandler)Delegate.Combine(temp, value);
                    stateInfoEventHandler = Interlocked.CompareExchange<DMTcpClient.StateInfoEventHandler>(ref this._StateInfoEventHandler, value2, temp);
                }
                while (stateInfoEventHandler != temp);
            }
            remove
            {
                DMTcpClient.StateInfoEventHandler stateInfoEventHandler = this._StateInfoEventHandler;
                DMTcpClient.StateInfoEventHandler temp;
                do
                {
                    temp = stateInfoEventHandler;
                    DMTcpClient.StateInfoEventHandler value2 = (DMTcpClient.StateInfoEventHandler)Delegate.Remove(temp, value);
                    stateInfoEventHandler = Interlocked.CompareExchange<DMTcpClient.StateInfoEventHandler>(ref this._StateInfoEventHandler, value2, temp);
                }
                while (stateInfoEventHandler != temp);
            }
        }

        protected virtual void OnTcpClientStateInfoEnterHead(string msg, SocketState state)
        {
            if (this._StateInfoEventHandler != null)
            {
                this._StateInfoEventHandler(msg, state);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this._Container != null)
            {
                this._Container.Dispose();
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 创建container对象
        /// </summary>
        private void CreateContainer()
        {
            this._Container = new Container();
        }

        private string _ServerIp;
        private int _ServerPort;
        private TcpClient _Tcpclient;
        private Thread _Tcpthread;
        private bool _IsStartTcpthreading;
        private bool _Isclosed;
        private int _ReConnectionTime;
        private string _Receivestr;
        private int _ReConectedCount;

        private DMTcpClient.ReceviceByteEventHandler _ReceviceByteEventHandler;
        private DMTcpClient.ErrorMsgEventHandler _ErrorMsgEventHandler;
        private DMTcpClient.StateInfoEventHandler _StateInfoEventHandler;

        private IContainer _Container;

        public delegate void ReceviceByteEventHandler(byte[] date);
        public delegate void ErrorMsgEventHandler(string msg);
        public delegate void StateInfoEventHandler(string msg, SocketState state);
    }
}
