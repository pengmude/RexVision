using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexView
{
    public partial class Form2 : Form
    {
        HImage img;
        public Form2()
        {
            InitializeComponent();

             img = new HImage(@"D:\img\钻头\drill_01.bmp");


            hWindowControl1.HalconWindow.DispObj(img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRegion reg = new HRegion(350d, 380, 200);
            hWindowControl1.HalconWindow.ClearWindow();
            hWindowControl1.HalconWindow.DispObj(img);
            hWindowControl1.HalconWindow.SetRgba(255, 0, 0, 120);
            hWindowControl1.HalconWindow.DispRegion(reg);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
