using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VisionCore;
using DockContrl;

namespace RexVision
{
    public delegate void SetEComDg(ECom eCom,EComType eComType);
    public partial class NetSet : DockForm
    {
        public static event SetEComDg SetEComEvent;
        ECom SelectECom;
        ComControl Com_Control;
        UDPControl UDPControl;
        TcpControlC TcpControlC;
        TcpControlS TcpControlS;
        List<ECom> EComList = new List<ECom>();
        public NetSet()
        {
            InitializeComponent();
            Com_Control = new ComControl();
            UDPControl = new UDPControl();
            TcpControlC = new TcpControlC();
            TcpControlS = new TcpControlS();
            this.Set_MinMax();
        }
        public NetSet(List<ECom> eComList)
        {
            InitializeComponent();
            uirb_EndChar.SelectedIndex = 0;
            EComList = eComList;
            EComChang(null, EComType.Load);
            Com_Control = new ComControl();
            UDPControl = new UDPControl();
            TcpControlC = new TcpControlC();
            TcpControlS = new TcpControlS();
        }
        private void EComChang(ECom eCom, EComType type)
        {
            if (eCom == null & type != EComType.Load) { return; }
            lb_ECom.Items.Clear();
            gb_ECom.Controls.Clear();
            switch (type)
            {
                case EComType.Add:
                    EComList.Add(eCom);
                    foreach (ECom com in EComList)
                    {
                        lb_ECom.Items.Add(com.Key);
                    }
                    break;
                case EComType.Load:
                    if (EComList.Count > 0)
                    {
                        foreach (ECom com in EComList)
                        {
                            lb_ECom.Items.Add(com.Key);
                        }
                    }
                    break;
                case EComType.Remov:
                    EComList.Remove(eCom);
                    EComManageer.DeleteECom(eCom.Key);
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
                    //eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    //不需要设置监听的ip 默认是0.0.0.0 就可以监听所有ip段
                    eCommunacation.LocalPort = 8000;//设置端口
                    break;
                case "TCP客户端":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.TcpClient);//创建tcp客户端
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    //eCommunacation.ReceiveString += ECommunacation_ReceiveString;
                    //设置通讯参数
                    eCommunacation.RemoteIP = "127.0.0.1";//
                    eCommunacation.RemotePort = 8001;
                    break;
                case "串口通信":
                    m_CurKey = EComManageer.CreateECom(CommunicationModel.COM);//创建串口
                    eCommunacation = EComManageer.GetECommunacation(m_CurKey);
                    //eCommunacation.ReceiveString += ECommunacation_ReceiveString;
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
            SetEComEvent(eCommunacation, EComType.Add);
            EComChang(eCommunacation, EComType.Add);
        }
        private void bt_RemovECom_Click(object sender, EventArgs e)
        {
            if (lb_ECom.SelectedIndex >= 0 && lb_ECom.SelectedIndex < EComList.Count)
            {
                int index = lb_ECom.SelectedIndex;
                SetEComEvent(EComList[index], EComType.Remov);
                EComChang(EComList[index], EComType.Remov);
           
            }
            else
            {
                MessageBox.Show("未选择要删除的通讯！");
            }
        }
        private void bt_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectECom == null) return;
                if (SelectECom.IsConnected)
                {
                    if (tb_Send.Text.Contains("光源"))
                    {
                        string[] sendStr = tb_Send.Text.Split(' ');
                        switch (sendStr[0])
                        {
                            case "光源开":
                                SelectECom.SendStr(DigtalChanlSwitch("1", sendStr[1], sendStr[2]));
                                break;
                            case "光源关":
                                SelectECom.SendStr(DigtalChanlSwitch("2", sendStr[1], sendStr[2]));
                                break;
                        }
                    }
                    else
                    {
                        switch (uirb_EndChar.SelectedIndex)
                        {
                            case 0:
                                SelectECom.SendStr(tb_Send.Text + "\r");
                                break;
                            case 1:
                                SelectECom.SendStr(tb_Send.Text + "\n");
                                break;
                            case 2:
                                SelectECom.SendStr(tb_Send.Text + "\r\n");
                                break;
                            case 3:
                                SelectECom.SendStr(tb_Send.Text);
                                break;
                            default:
                                 SelectECom.SendStr(tb_Send.Text);
                                break;
                        }
                    }
                }
            }
            catch { }
        }
        private void bt_ClearSend_Click(object sender, EventArgs e)
        {
            tb_Send.Text = "";
        }
        private void lb_ECom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_ECom.SelectedItem == null) { return; }
            int index = lb_ECom.SelectedIndex;
            if (index > EComList.Count) { return; }
            SelectECom = EComList[index];
            gb_ECom.Controls.Clear();
            switch (SelectECom.CommunicationModel)
            {
                case CommunicationModel.TcpClient:
                    TcpControlC.Location = new Point(10, 30);
                    TcpControlC.Get_ECom(SelectECom);
                    gb_ECom.Controls.Add(TcpControlC);
                    break;
                case CommunicationModel.TcpServer:
                    TcpControlS.Location = new Point(10, 30);
                    TcpControlS.Get_ECom(SelectECom);
                    gb_ECom.Controls.Add(TcpControlS);
                    break;
                case CommunicationModel.UDP:
                    UDPControl.Location = new Point(10, 30);
                    UDPControl.Get_ECom(SelectECom);
                    gb_ECom.Controls.Add(UDPControl);
                    break;
                case CommunicationModel.COM:
                    Com_Control.Location = new Point(10, 30);
                    Com_Control.Get_ECom(SelectECom);
                    gb_ECom.Controls.Add(Com_Control);
                    break;
            }
        }
        private void tb_Read_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_Read.Text = "";
        }
        //private void ECommunacation_ReceiveString(string str)
        //{
        //    //tb_Read.Invoke(new Action(() => { tb_Read.Text = DateTime.Now.ToString("hh:mm:ss ") + str + "\r\n" + tb_Read.Text; }));
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            //项目原因暂不加，后期增加长度判断，变化时才刷新
            if (SelectECom != null)
            {
                if (SelectECom.m_ReadData.Length > 0)
                {
                    tb_Read.Text = DateTime.Now.ToString("hh:mm:ss ") + SelectECom.m_ReadData + "\r\n" + tb_Read.Text;
                }
            }
        }

        public static void Openlight(int CH, int Value)
        {
            //Light.Write(DigtalChanlSwitch("1", CH.ToString(), Value.ToString()));
        }
        public static void Setlight(int CH, int Value)
        {
            //Light.Write(DigtalChanlSwitch("3", CH.ToString(), Value.ToString()));
        }
        public static void Closelight(int CH, int Value)
        {
            //Light.Write(DigtalChanlSwitch("2", CH.ToString(), Value.ToString()));
        }
        public static void Readlight(int CH, int Value)
        {
            //Light.Write(DigtalChanlSwitch("4", CH.ToString(), Value.ToString()));
        }
        private static string DigtalChanlSwitch(string CodeD, string channalD, string LightnessD)
        {

            string Str;

            int Lgt = Convert.ToInt32(LightnessD);
            var Lst = Convert.ToString(Lgt, 16);
            var Lstr1 = Lst.ToUpper();
            string b = string.Empty;
            if (Lgt < 16)
            {

                var Lstr2 = Lstr1.Substring(0, 1);
                // --------------------------校验和转换----------------------------
                Tempfunction(CodeD, channalD, "0", "0", Lstr2);
                //b = Conversion.Hex(b);
                var b1 = Convert.ToString(Ks, 16);
                var b2 = b1.ToUpper();
                Str = "$" + CodeD + channalD + "0" + "0" + Lstr1 + b2;
            }
            else
            {
                var Lstr2 = Lstr1.Substring(0, 1);
                var Lstr3 = Lstr1.Substring(1, 1);
                // --------------------------校验和转换----------------------------
                Tempfunction(CodeD, channalD, "0", Lstr2, Lstr3);
                var b1 = Convert.ToString(Ks, 16);
                var b2 = b1.ToUpper();
                Str = "$" + CodeD + channalD + "0" + Lstr1 + b2;
            }
            return Str;
        }
        static int Ks = 0;
        private static void Tempfunction(string Temp1, string Temp2, string Temp3, string Temp4, string Temp5)
        {

            switch (Temp1)
            {
                case "0":
                    {
                        Ks = +0x30;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46;
                        break;
                    }
            }
            switch (Temp2)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }

            switch (Temp3)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }
            switch (Temp4)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }
            int fistword = +0x24;
            switch (Temp5)
            {

                case "0":
                    {
                        Ks = fistword ^ +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = fistword ^ +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = fistword ^ +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = fistword ^ +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = fistword ^ +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = fistword ^ +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = fistword ^ +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = fistword ^ +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = fistword ^ +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = fistword ^ +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = fistword ^ +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = fistword ^ +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = fistword ^ +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = fistword ^ +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = fistword ^ +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = fistword ^ +0x46 ^ Ks;
                        break;
                    }
            }
        }
    }
}
