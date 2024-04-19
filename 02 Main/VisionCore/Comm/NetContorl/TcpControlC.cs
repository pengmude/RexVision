using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using System.Text.RegularExpressions;

namespace VisionCore
{
    public partial class TcpControlC : NetBase
    {
        public TcpControlC()
        {
            InitializeComponent();
        }
        public override bool Get_ECom(ECom eCom)
        {
            mECom = eCom;
            uilb_Key.Text = mECom.Key;
            uicb_Enable.Checked = mECom.IsConnected;
            uitb_Remark.Text = mECom.Remarks;
            textBox2.Text = mECom.RemotePort.ToString();
            textBox3.Text = mECom.RemoteIP;


            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mECom.RemotePort = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            Regex rx = new Regex(@"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))");
            if (rx.IsMatch(textBox3.Text))
            {
                mECom.RemoteIP = textBox3.Text;
            }
            else
            {
                MessageBox.Show("Is not IP address");
                textBox3.Text = mECom.RemoteIP;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mECom == null) { return; }
            if (  mECom.IsConnected)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox2.Enabled= true;
                textBox3.Enabled = true;
            }
        }
    }
}
