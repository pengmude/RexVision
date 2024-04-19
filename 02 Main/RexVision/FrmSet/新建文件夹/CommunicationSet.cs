using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VisionCore.Common;
using TopControls;
using ControlLibrary;
using VisionCore;

namespace QuickVision.UI
{
    public partial class CommunicationSet : TopForm
    {
        ECom SelectECom;
        COM_Control Com_Control;
        UDP_Control UDP_Control;
        TCP_Client_Control TCP_Client_Control;
        TCP_Server_Control TCP_Server_Control;
        List<ECom> EComList = new List<ECom>();
        private enum EComType
        {
            Add, Load, Remov
        }
        public CommunicationSet()
        {
            InitializeComponent();
            Com_Control = new COM_Control();
            UDP_Control = new UDP_Control();
            TCP_Client_Control = new TCP_Client_Control();
            TCP_Server_Control = new TCP_Server_Control();
            this.Set_MinMax();
        }
        public CommunicationSet(List<ECom> eComList)
        {
            InitializeComponent();
            EComList = eComList;
            EComChang(null, EComType.Load);
            Com_Control = new COM_Control();
            UDP_Control = new UDP_Control();
            TCP_Client_Control = new TCP_Client_Control();
            TCP_Server_Control = new TCP_Server_Control();
        }
        private void EComChang(ECom eCom, EComType type)
        {
            if (eCom == null& type!= EComType.Load) { return; }
            lb_ECom.Items.Clear();
            gb_ECom.Controls.Clear();
            switch (type)
            {
                case EComType.Add:
                    if (EComList == null)
                    {
                        EComList = new List<ECom>();
                    }
                    EComList.Add(eCom);
                    foreach (ECom com in EComList)
                    {
                        lb_ECom.Items.Add(com.Key);
                    }
                    break;
                case EComType.Load:
                    if (EComList!=null)
                    {
                        if (EComList.Count > 0)
                        {
                            foreach (ECom com in EComList)
                            {
                                lb_ECom.Items.Add(com.Key);
                            }
                        }
                    }
                    break;
                case EComType.Remov:
                    EComList.Remove(eCom);
                    if (EComList.Count > 0)
                    {
                        foreach (ECom com in EComList)
                        {
                            lb_ECom.Items.Add(com.Key);
                        }
                    }
                    break;
            }
        }
        private void bt_AddECom_Click(object sender, EventArgs e)
        {
            string m_CurKey;
            ECom eCommunacation = null;
            switch (cb_EComType.Text)
            {
                case "TCP服务端":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.TcpServer);//创建tcp服务端
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    //不需要设置监听的ip 默认是0.0.0.0 就可以监听所有ip段
                    eCommunacation.LocalPort = 8000;//设置端口
                    break;
                case "TCP客户端":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.TcpClient);//创建tcp客户端
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    eCommunacation.RemoteIP = "127.0.0.1";//
                    eCommunacation.RemotePort = 8001;
                    break;
                case "串口通信":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.COM);//创建串口
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    eCommunacation.PortName = "COM1";//
                    eCommunacation.BaudRate = "9600";
                    eCommunacation.Parity = "None";
                    eCommunacation.DataBits = "8";
                    eCommunacation.StopBits = "One";
                    break;
                case "UDP通信":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.UDP);//创建UDP
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    eCommunacation.RemoteIP = "127.0.0.1";//
                    eCommunacation.RemotePort = 8002;
                    eCommunacation.LocalPort = 8003;
                    break;
            }
            EComChang(eCommunacation, EComType.Add);
        }
        private void bt_RemovECom_Click(object sender, EventArgs e)
        {
            if (lb_ECom.SelectedIndex >= 0 && lb_ECom.SelectedIndex < EComList.Count)
            {
                EComChang(EComList[lb_ECom.SelectedIndex], EComType.Remov);
            }
            else
            {
                MessageBox.Show("未选择要删除的通讯！");
            }
        }
        private void bt_Send_Click(object sender, EventArgs e)
        {
            if (SelectECom.IsConnected)
            {
                SelectECom.SendStr(tb_Send.Text);
            }
        }
        private void bt_ClearSend_Click(object sender, EventArgs e)
        {
            tb_Send.Text = "";
        }
        private void lb_ECom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EComList.Count < 1) { return; }
            gb_ECom.Controls.Clear();
            SelectECom = EComList[lb_ECom.SelectedIndex];
            switch (SelectECom.CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    TCP_Client_Control.Location = new Point(10, 15);
                    TCP_Client_Control.get_tcpcom(SelectECom);
                    gb_ECom.Controls.Add(TCP_Client_Control);
                    break;
                case CommunicationModel.TcpServer:
                    TCP_Server_Control.Location = new Point(10, 15);
                    TCP_Server_Control.get_tcpcom(SelectECom);
                    gb_ECom.Controls.Add(TCP_Server_Control);
                    break;
                case CommunicationModel.UDP:
                    UDP_Control.Location = new Point(10, 15);
                    UDP_Control.get_tcpcom(SelectECom);
                    gb_ECom.Controls.Add(UDP_Control);
                    break;
                case CommunicationModel.COM:
                    Com_Control.Location = new Point(10, 15);
                    Com_Control.get_tcpcom(SelectECom);
                    gb_ECom.Controls.Add(Com_Control);
                    break;
            }
        }
        private void tb_Read_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_Read.Text = "";
        }
        private void ECommunacation_ReceiveString(string str)
        {
            tb_Read.Invoke(new Action(() => { tb_Read.Text = DateTime.Now.ToString("hh:mm:ss ") + str + "\r\n" + tb_Read.Text; }));
        }
    }
}
