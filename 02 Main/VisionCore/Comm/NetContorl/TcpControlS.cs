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

namespace VisionCore
{
    public partial class TcpControlS : NetBase
    {
        public TcpControlS()
        {
            InitializeComponent();
        }
        public override bool Get_ECom(ECom eCom)
        {
            mECom = eCom;
            uilb_Key.Text = mECom.Key;
            uicb_Enable.Checked = mECom.IsConnected;
            textBox2.Text = mECom.LocalPort.ToString();
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mECom == null) { return; }
            if (mECom.IsConnected)
            { textBox2.Enabled = false; }
            else { textBox2.Enabled = true; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int d = int.Parse(textBox2.Text);
            if (d==0 )
            {
                MessageBox.Show($"输入有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else {
                mECom.LocalPort = d;
            }
        }
    }
}
