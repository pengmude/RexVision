using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RexControl
{
    /// <summary>
    /// 二值化
    /// </summary>
    public partial class ThresholdControl : UserControl
    {
        public ThresholdControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 二值化事件
        /// </summary>
        public  event ThresholdHandle UserControlValueChanged;
        /// <summary>
        /// 二值化委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void ThresholdHandle(string str);
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label3.Text = trackBar1.Value.ToString();
                label4.Text = trackBar2.Value.ToString();
                string m_OutStr = "";
                string trackName = sender.GetType().ToString();
                string[] split = trackName.Split(new Char[] { '.' });
                if (split.Length > 3)
                {
                    try
                    {
                        TrackBar trackBar = (TrackBar)sender;
                        switch (trackBar.Name)
                        {
                            case "trackBar1":
                                m_OutStr = "低阈值:" + trackBar1.Value.ToString();
                                break;
                            case "trackBar2":
                                m_OutStr = "高阈值:" + trackBar2.Value.ToString();
                                break;
                        }
                    }
                    catch { }
                }
                else
                {
                    UCCheckBox CheckBox = (UCCheckBox)sender;
                    m_OutStr = "黑白反转:" + CheckBox.Checked.ToString();
                }

                UserControlValueChanged?.Invoke("二值化:" + m_OutStr);
            }
            catch { }
        }
        /// <summary>
        /// 显示默认或加载保存数据到窗体
        /// </summary>
        /// <param name="LOW"></param>
        /// <param name="High"></param>
        /// <param name="Reverse"></param>
        public void ShowControlValue(double LOW, double High, bool Reverse)
        {
            trackBar1.Value = (int)LOW;
            trackBar2.Value = (int)High;
            ucCheckBox1.Checked = Reverse;
            label3.Text = LOW.ToString();
            label4.Text = High.ToString();
        }
    }
}
