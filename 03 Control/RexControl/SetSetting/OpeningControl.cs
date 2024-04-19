using System;
using System.Windows.Forms;



namespace RexControl
{
    /// <summary>
    /// 灰度开运算
    /// </summary>
    public partial class OpeningControl : UserControl
    {
        public OpeningControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 灰度开运算事件
        /// </summary>
        public  event OpeningHandle UserControlValueChanged;
        /// <summary>
        /// 灰度开运算委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void OpeningHandle(string str);
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
                UserControlValueChanged?.Invoke(("灰度开运算:" + m_OutStr));
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
            ucNumTextBox1.Num = (int)Wight;
            ucNumTextBox2.Num = (int)Height;
        }

    }
}
