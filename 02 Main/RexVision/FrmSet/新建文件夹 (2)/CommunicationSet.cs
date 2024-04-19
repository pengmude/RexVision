using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TopControls;
using ControlLibrary;
using VisionCore.Common;

namespace QuickVision.UI
{
    public partial class CommunicationSet : TopForm
    {
        /// <summary>
        /// 通信列表
        /// </summary>
        public List<ECom> Com_ = new List<ECom>();
        ECom mECom;
        private string data_read,data_send;
        private List<string> ListStr;
        COM_Control Com_control1;
        UDP_Control UDP_Control1;
        TCP_Client_Control TCP_Client_Control1;
        TCP_Server_Control TCP_Server_Control1;
        public CommunicationSet()
        {
            InitializeComponent();
            Com_control1 = new COM_Control();
            UDP_Control1 = new UDP_Control();
            TCP_Client_Control1 = new TCP_Client_Control();
            TCP_Server_Control1 = new TCP_Server_Control();
        }
        public CommunicationSet(List<ECom> list)
        {
            InitializeComponent();
            Com_ = list;
            ListStr = list_to_string(Com_);
            // listBox1.Items.Add(list_str);
            Com_control1 = new COM_Control();
            TCP_Client_Control1 = new TCP_Client_Control();
            TCP_Server_Control1 = new TCP_Server_Control();
            UDP_Control1 = new UDP_Control();
            this.Set_MinMax();
        }
        private List<string> list_to_string(List<ECom> list)
        {
            List<string> str_l = new List<string>();
            listBox1.Items.Clear();
            if (list.Count>0)
            {
                foreach(ECom com in list)
                {
                    str_l.Add(com.Key);
                    listBox1.Items.Add(com.Key);
                }
            }
            return str_l;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string m_CurKey;
            ECom eCommunacation =null;
            switch (name)
            { 
                 case "TCP服务端":
                     m_CurKey = EComManageer.CreateECom(CommunicationModel.TcpServer);//创建tcp服务端
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    //eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    //不需要设置监听的ip 默认是0.0.0.0 就可以监听所有ip段
                    eCommunacation.LocalPort = 8000;//设置端口
                    break;
                case "TCP客户端":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.TcpClient);//创建tcp客户端
                     eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    //设置通讯参数
                    eCommunacation.RemoteIP = "127.0.0.1";//
                    eCommunacation.RemotePort = 8001;
                    break;
                case "串口通信":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.COM);//创建串口
                     eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                   // eCommunacation.ReceiveString += ECommunacation_ReceiveString;
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
                    //eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    eCommunacation.RemoteIP = "127.0.0.1";//
                    eCommunacation.RemotePort = 8002;
                    eCommunacation.LocalPort = 8003;
                    break;
            }
            if(eCommunacation==null)
            { return ; }
            Com_.Add(eCommunacation);
            ListStr = list_to_string(Com_);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            data_send = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            data_send= textBox1.Text ;
            if(mECom!=null)
            { 
            data_read= mECom.data_;
            textBox2.Text = data_read;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            int index = listBox1.SelectedIndex;
            if (index > Com_.Count) { return; }
            mECom = Com_[index];
            groupBox2.Controls.Clear();
            switch (mECom.CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    TCP_Client_Control1.Location = new Point(10, 15);
                    TCP_Client_Control1.get_tcpcom(mECom);
                    groupBox2.Controls.Add(TCP_Client_Control1);
                    break;
                case CommunicationModel.TcpServer:
                    TCP_Server_Control1.Location = new Point(10, 15);
                    TCP_Server_Control1.get_tcpcom(mECom);
                    groupBox2.Controls.Add(TCP_Server_Control1);
                    break;
                case CommunicationModel.UDP:
                    UDP_Control1.Location = new Point(10, 15);
                    UDP_Control1.get_tcpcom(mECom);
                    groupBox2.Controls.Add(UDP_Control1);
                    break;
                case CommunicationModel.COM:
                    Com_control1.Location = new Point(10,15);
                    Com_control1.get_tcpcom(mECom);
                    groupBox2.Controls.Add(Com_control1);
                    break;
            }
            data_read = mECom.data_;
            textBox2.Text = data_read;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(mECom.IsConnected)
            {
                    mECom.SendStr(textBox1.Text);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
           int num= listBox1.SelectedIndex;
            if (num>=0 && num < Com_.Count)
            { Com_.RemoveAt(num);
              groupBox2.Controls.Clear();
            }
            else
            {
                MessageBox.Show("未选择要删除的通讯！");
            }
            ListStr = list_to_string(Com_);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (mECom != null)
            {
                mECom.data_ = "";
                textBox2.Text = "";
                data_read = mECom.data_;
                textBox2.Text = data_read;
            }
        }
    }
}
