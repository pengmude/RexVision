using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DMSkin.Socket
{
    public class UdpLibrary : IDisposable
    {
        public UdpLibrary()
        {
            this.PortNum = 1234;
        }
        public UdpLibrary(int port)
        {
            this.PortNum = port;
        }

        /// <summary>
        /// UDP监听端口
        /// </summary>
        [Category("UDP服务端")]
        [Description("UDP监听端口")]
        public int Port
        {
            get
            {
                return this.PortNum;
            }
            set
            {
                this.PortNum = value;
            }
        }

        [Category("UDP服务端")]
        [Description("UDP客户端")]
        internal UdpClient UdpClientObj
        {
            get
            {
                return this._UdpClient;
            }
        }

        public bool Start()
        {
            if (!this.IsConnected)
            {
                try
                {
                    this._UdpClient = new UdpClient(new IPEndPoint(IPAddress.Any, this.Port));
                    this.IsConnected = true;
                    this.ReceiveInternal();
                }
                catch (Exception ex)
                {
                     Debug.WriteLine(ex.Message);
                    this.IsConnected = false;
                }
       
                return IsConnected;
            }
            else
            {
                return false;
            }
        }
        public void Stop()
        {
            try
            {
                this.IsConnected = false;
                this.UdpClientObj.Close();
                this._UdpClient = null;
            }
            catch
            {
            }
        }
        public void Send(IDataCell cell, IPEndPoint remoteIP)
        {
            byte[] buffer = cell.ToBuffer();
            this.SendInternal(buffer, remoteIP);
        }
        public void Send(byte[] buffer, IPEndPoint remoteIP)
        {
            this.SendInternal(buffer, remoteIP);
        }

        protected void SendInternal(byte[] buffer, IPEndPoint remoteIP)
        {
            if (!this.IsConnected)
            {
                throw new ApplicationException("UDP Closed.");
            }
            try
            {
                this.UdpClientObj.BeginSend(buffer, buffer.Length, remoteIP, new AsyncCallback(this.SendCallBack), null);
            }
            catch (SocketException ex)
            {
                throw ex;
            }
        }
        protected void ReceiveInternal()
        {
            if (!this.IsConnected)
            {
                return ;
            }
            try
            {
                if (this.UdpClientObj != null)
                {
                    this.UdpClientObj.BeginReceive(new AsyncCallback(this.ReceiveCallBack), null);
                }
                else
                {
                }
            }
            catch (SocketException ex)
            {
                throw ex;
            }
        }

        private void SendCallBack(IAsyncResult input)
        {
            try
            {
                this.UdpClientObj.EndSend(input);
            }
            catch (SocketException ex)
            {
                throw ex;
            }
        }

        private void ReceiveCallBack(IAsyncResult input)
        {
            if (!this.IsConnected)
            {
                return;
            }
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Any, 0);
            byte[] buffer = null;
            try
            {
                buffer = this.UdpClientObj.EndReceive(input, ref remoteIP);
            }
            catch (SocketException ex)
            {
                throw ex;
            }
            finally
            {
                this.ReceiveInternal();
            }
            this.OnReceiveData(new ReceiveDataEventArgs(buffer, remoteIP));
        }

        public void Dispose()
        {
            this.IsConnected = false;
            if (this._UdpClient != null)
            {
                this._UdpClient.Close();
                this._UdpClient = null;
            }
        }

        public event ReceiveDataEventHandler ReceiveData
        {
            add
            {
                ReceiveDataEventHandler receiveDataEventHandler = this._ReceiveDataEventHandler;
                ReceiveDataEventHandler temp;
                do
                {
                    temp = receiveDataEventHandler;
                    ReceiveDataEventHandler value2 = (ReceiveDataEventHandler)Delegate.Combine(temp, value);
                    receiveDataEventHandler = Interlocked.CompareExchange<ReceiveDataEventHandler>(ref this._ReceiveDataEventHandler, value2, temp);
                }
                while (receiveDataEventHandler != temp);
            }
            remove
            {
                ReceiveDataEventHandler receiveDataEventHandler = this._ReceiveDataEventHandler;
                ReceiveDataEventHandler temp;
                do
                {
                    temp = receiveDataEventHandler;
                    ReceiveDataEventHandler value2 = (ReceiveDataEventHandler)Delegate.Remove(temp, value);
                    receiveDataEventHandler = Interlocked.CompareExchange<ReceiveDataEventHandler>(ref this._ReceiveDataEventHandler, value2, temp);
                }
                while (receiveDataEventHandler != temp);
            }
        }

        [Description("UDP服务端接收数据事件")]
        [Category("UDPServer事件")]
        protected virtual void OnReceiveData(ReceiveDataEventArgs e)
        {
            if (this._ReceiveDataEventHandler != null)
            {
                this._ReceiveDataEventHandler(this, e);
            }
        }

        private UdpClient _UdpClient;
        private int PortNum;
        private bool IsConnected;
        private ReceiveDataEventHandler _ReceiveDataEventHandler;
    }
}
