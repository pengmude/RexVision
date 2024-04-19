using System;
using System.Windows.Forms;

using RexControl;

namespace RexControl
{
    /// <summary>
    /// 均值二值化
    /// </summary>
    public partial class VarThresholdControl : UserControl
    {
        public VarThresholdControl()
        {
            InitializeComponent();
        }
        //定义事件
        public  event VarThresholdControlHandle UserControlValueChanged;
        //定义委托
        public delegate void VarThresholdControlHandle(string str);
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
                        UCNumTextBox CheckBox = (UCNumTextBox)sender;
                        switch (CheckBox.Name)
                        {
                            case "ucNumTextBox1":
                                m_OutStr = "宽度:" + ucNumTextBox1.Num.ToString();
                                break;
                            case "ucNumTextBox2":
                                m_OutStr = "高度:" + ucNumTextBox2.Num.ToString();
                                break;
                            case "ucNumTextBox3":
                                m_OutStr = "阈值偏移:" + ucNumTextBox3.Num.ToString();
                                break;
                        }
                    }
                    catch { }
                }
                else
                {
                    ComboBox comboBox = (ComboBox)sender;
                    switch (comboBox.Text.ToString())
                    {
                        case "等于":
                            m_OutStr = "比较类型:" + "equal";
                            break;
                        case "不等于":
                            m_OutStr = "比较类型:" + "not_equal";
                            break;
                        case "小于等于":
                            m_OutStr = "比较类型:" + "dark";
                            break;
                        case "大于等于":
                            m_OutStr = "比较类型:" + "light";
                            break;
                    }
                    //m_OutStr = "比较类型:" + comboBox.Text.ToString();
                }
                UserControlValueChanged?.Invoke(("均值二值化:" + m_OutStr));
            }
            catch { }
        }
        //显示默认或加载保存数据到窗体
        public void ShowControlValue(double Wight, double Height, double Skew,string Type)
        {
            ucNumTextBox1.Num = (int)Wight;
            ucNumTextBox2.Num = (int)Height;
            ucNumTextBox3.Num = (int)Skew;
            switch (Type)
            {
                case "equal":
                    comboBox1.Text = "等于";
                    break;
                case "not_equal":
                    comboBox1.Text = "不等于";
                    break;
                case "light":
                    comboBox1.Text = "小于等于";
                    break;
                case "dark":
                    comboBox1.Text = "大于等于";
                    break;
            }         
        }
    }
}
