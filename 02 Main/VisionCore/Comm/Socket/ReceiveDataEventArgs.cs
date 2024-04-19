using System;
using System.Net;

namespace DMSkin.Socket
{
    public class ReceiveDataEventArgs : EventArgs
    {
        public ReceiveDataEventArgs()
        {
        }

        public ReceiveDataEventArgs(byte[] buffer, IPEndPoint remoteIP)
        {
            this._Buffer = buffer;
            this._RemoteIP = remoteIP;
        }

        public byte[] Buffer
        {
            get
            {
                return this._Buffer;
            }
            set
            {
                this._Buffer = value;
            }
        }

        public IPEndPoint RemoteIP
        {
            get
            {
                return this._RemoteIP;
            }
            set
            {
                this._RemoteIP = value;
            }
        }

        private byte[] _Buffer;
        private IPEndPoint _RemoteIP;
    }
}
