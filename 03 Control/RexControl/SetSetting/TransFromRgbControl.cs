using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RexControl;

namespace RexControl
{
    /// <summary>
    /// 彩色图转灰度图
    /// </summary>
    public partial class TransFromRgbControl : UserControl
    {
        public TransFromRgbControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 彩色图转灰度图事件
        /// </summary>
        public  event TransFromRgbHandle UserControlValueChanged;
        /// <summary>
        /// 彩色图转灰度图委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void TransFromRgbHandle(string str);
        private void ucNumTextBox_Numchanged(object sender, EventArgs e)
        {
            try
            {
                string m_OutStr = "";
                string trackName = sender.GetType().ToString();
                string[] split = trackName.Split(new Char[] { '.' });
                if (split.Length < 3)
                {
                    try
                    {
                        ComboBox comboBox = (ComboBox)sender;
                        switch (comboBox.Name)
                        {
                            case "uccomboBox1":
                                m_OutStr = "转灰类型:" + comboBox1.Text.ToString();
                                break;
                            case "uccomboBox2":
                                m_OutStr = "显示通道:" + comboBox2.Text.ToString();
                                break;
                        }
                    }
                    catch { }
                }
                UserControlValueChanged?.Invoke(("彩色转灰:" + m_OutStr));
            }
            catch { }
        }
        //显示默认或加载保存数据到窗体
        public void ShowControlValue(double Wight, double Height, double Skew, string Type)
        {
            //comboBox1.Text = (int)Wight;
            //comboBox2.Text = (int)Height;
        }
    }
}
