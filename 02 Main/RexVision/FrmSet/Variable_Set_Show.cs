using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using VisionCore.core;

namespace MyVision.UI
{
    public partial class Variable_Set_Show : Form
    {
        F_DATA_CELL data=new F_DATA_CELL();
        public Variable_Set_Show()
        {
            InitializeComponent();
        }
        public Variable_Set_Show(F_DATA_CELL d)
        {
            InitializeComponent();
            data = d;
            textBox1.Text = data.m_Data_Name;
            label4.Text = data.m_Data_Type.ToString();
            textBox2.Text = data.m_Data_Value.ToString();
            textBox3.Text = data.m_DataTip;

        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="") { return; }

             data.m_Data_Name= textBox1.Text;
            data.InitValue(data.m_Data_Type, textBox2.Text);
            data.m_DataTip= textBox3.Text ;

            Close();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
