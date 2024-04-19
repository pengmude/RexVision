using System;
using System.Windows.Forms;

namespace RexControl
{
    /// <summary>
    /// 中值滤波
    /// </summary>
    public partial class MedianImageControl : UserControl
    {
        public MedianImageControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 中值滤波事件
        /// </summary>
        public  event MedianImageHandle UserControlValueChanged;
        /// <summary>
        /// 中值滤波委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void MedianImageHandle(string str);
        private void ucNumTextBox_Numchanged(object sender, EventArgs e)
        {
            try
            {
                string m_OutStr = "";
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
                        }
                    }
                    catch { }
                }
                UserControlValueChanged?.Invoke(("中值滤波:" + m_OutStr));
            }
            catch { }
        }
        /// <summary>
        /// 显示默认或加载保存数据到窗体
        /// </summary>
        /// <param name="Wight"></param>
        /// <param name="Height"></param>
        public void ShowControlValue(double Wight, double Height)
        {
            ucNumTextBox1.Num= (int)Wight;
            ucNumTextBox2.Num = (int)Height;
        }
    }
}
