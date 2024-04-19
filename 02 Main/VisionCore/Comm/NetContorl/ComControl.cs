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
    public partial class ComControl : NetBase
    {
        
        public ComControl()
        {
            InitializeComponent();
        }
        public override bool Get_ECom(ECom eCom)
        {

            mECom = eCom;
            uilb_Key.Text = mECom.Key;
            uicb_Enable.Checked = mECom.IsConnected;
            uitb_Remark.Text = mECom.Remarks;
            comboBox1.Text = mECom.PortName;
            comboBox2.Text = mECom.BaudRate;
            comboBox3.Text = mECom.Parity;
            comboBox4.Text = mECom.DataBits;
            comboBox5.Text = mECom.StopBits;
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           mECom.PortName = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             mECom.BaudRate = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
             mECom.Parity= comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
              mECom.DataBits= comboBox4.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
              mECom.StopBits= comboBox5.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mECom == null) { return; }
            if(mECom.IsConnected)
            {
                uilb_Key.Enabled = false;
                uicb_Enable.Checked = true;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
            }
            else
            {
                uilb_Key.Enabled = true;
                uicb_Enable.Checked = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
            }
        }
    }
}
