using System;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using VisionCore;
using System.Diagnostics;

namespace PCComm
{
   public delegate string SerialPortDataReceivedFunction(SerialPort serialPort);//解析 串口数据的规则

    class MySerialPort
    {
        public event ReceiveString OnReceiveString;//接受数据事件

        public SerialPortDataReceivedFunction DataReceivedFunction { get; set; } = null;//数据接收委托


        #region Manager Enums


        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };
        #endregion

        #region Manager Variables
        //property variables
        private string _baudRate = string.Empty;
        private string _parity = string.Empty;
        private string _stopBits = string.Empty;
        private string _dataBits = string.Empty;
        private string _portName = string.Empty;
        //global manager variables
        private Color[] MessageColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        private SerialPort comPort = new SerialPort();
        #endregion

        #region Manager Properties



        /// <summary>
        /// Return port status
        /// </summary>
        public bool isPortOpen
        {
            get { return comPort.IsOpen;  }
        }

        /// <summary>
        /// Property to hold the BaudRate
        /// of our manager class
        /// </summary>
        public string BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// property to hold the Parity
        /// of our manager class
        /// </summary>
        public string Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// property to hold the StopBits
        /// of our manager class
        /// </summary>
        public string StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        }

        /// <summary>
        /// property to hold the DataBits
        /// of our manager class
        /// </summary>
        public string DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        /// <summary>
        /// property to hold the PortName
        /// of our manager class
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }


        #endregion

        #region Manager Constructors

        /// <summary>
        /// Comstructor to set the properties of our
        /// serial port communicator to nothing
        /// </summary>
        public MySerialPort()
        {
            _baudRate = string.Empty;
            _parity = string.Empty;
            _stopBits = string.Empty;
            _dataBits = string.Empty;
            _portName = "COM1";
            comPort.Encoding = Encoding.Default;
            //add event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
           
        }
        #endregion

        #region WriteData
        public bool WriteData(string msg, bool isSendByHex)
        {
            try
            {
                if (!(comPort.IsOpen == true))
                {
                    DisplayData(MessageType.Error, $"[{PortName}] 串口未打开!");
                    return false;
                }
                if (isSendByHex == true)
                {
                    byte[] bytes = HexTool.HexToByte(HexTool.StrToHexStr(msg));
                    comPort.Write(bytes, 0, bytes.Length);
                }
                else
                {
                    comPort.Write(msg);
                }

                //send the message to the port
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
 
        }
        #endregion



        #region DisplayData
        /// <summary>
        /// method to display the data to & from the port
        /// on the screen
        /// </summary>
        /// <param name="type">MessageType of the message</param>
        /// <param name="msg">Message to display</param>
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            switch (type)
            {
                case MessageType.Incoming:
                   // Log.Debug(msg);
                    break;
                case MessageType.Outgoing:
                   //Log.Debug(msg);
                    break;
                case MessageType.Normal:
                   // Log.Info(msg);
                    break;
                case MessageType.Warning:
                    MessageBox.Show(msg);
                    break;
                case MessageType.Error:
                    MessageBox.Show(msg);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region OpenPort
        public bool OpenPort()
        {
            try
            {
                ClosePort();

                //set the properties of our SerialPort Object
                comPort.BaudRate = int.Parse(_baudRate);    //BaudRate
                comPort.DataBits = int.Parse(_dataBits);    //DataBits
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _stopBits);    //StopBits
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), _parity);    //Parity
                comPort.PortName = _portName;   //PortName
                //now open the port
                comPort.Open();
                //display message
                DisplayData(MessageType.Normal, "Port opened at " + DateTime.Now + "\n");
                //return true
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message + "\n");
                return false;
            }
        }

        /// <summary>
        /// Close Port
        /// </summary>
        public void ClosePort()
        {
            if (comPort.IsOpen == true) comPort.Close();
        }

        #endregion

        #region comPort_DataReceived
        /// <summary>
        /// method that will be called when theres data waiting in the buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string msg="";

            if (DataReceivedFunction==null)
            {
                Thread.Sleep(50);//一定要延迟, 才能直接去读.因为流还没有写完,就会触发事件进入 magical 2019-3-1 20:21:43
                msg = comPort.ReadExisting().Trim();
            }
            else
            {
                msg = DataReceivedFunction.Invoke(comPort);
            }
       
            if (msg.Length < 6)
            {
                ;
                // string s = comPort.ReadExisting().Trim();
            }

            //display the data to the user
            if (msg.Length > 0)
                DisplayData(MessageType.Incoming, msg + "\n");
        
            OnReceiveString?.Invoke(msg);
        }
        #endregion
    }
}
