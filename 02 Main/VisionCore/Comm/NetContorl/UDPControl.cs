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
    public partial class UDPControl : NetBase
    {
        public UDPControl()
        {
            InitializeComponent();
        }
        public override bool Get_ECom(ECom eCom)
        {
            mECom = eCom;
            uilb_Key.Text = mECom.Key;
            uicb_Enable.Checked = mECom.IsConnected;
            //设置通讯参数
            textBox3.Text= mECom.RemoteIP ;//
            textBox4.Text= mECom.RemotePort.ToString() ;
            textBox2.Text= mECom.LocalPort.ToString() ;
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mECom.LocalPort = int.Parse(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            mECom.RemotePort = int.Parse(textBox4.Text);
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
                MessageBox.Show($"Is Not IP assress", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox3.Text = mECom.RemoteIP;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mECom == null) { return; }
            if (mECom.IsConnected)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            } else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
        }
    }
}
