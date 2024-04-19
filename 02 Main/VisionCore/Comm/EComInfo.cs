using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionCore
{
    [Serializable]
    public class EComInfo
    {
        public string Key { get; set; }//通讯设备key
        public bool IsConnected { get; set; }//是否正在连接  没有连接上 正在连接也返回true
        public CommunicationModel CommunicationModel { get; set; }
        public EComInfo(string key, bool isConnected, CommunicationModel communicationModel)
        {
            Key = key;
            IsConnected = isConnected;
            CommunicationModel = communicationModel;
        }
    }
}
