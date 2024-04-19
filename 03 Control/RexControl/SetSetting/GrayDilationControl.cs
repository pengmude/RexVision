using System;
using System.Windows.Forms;



namespace RexControl
{
    /// <summary>
    /// 灰度膨胀
    /// </summary>
    public partial class GrayDilationControl : UserControl
    {
        public GrayDilationControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 灰度膨胀事件
        /// </summary>
        public  event GrayDilationHandle UserControlValueChanged;
        /// <summary>
        /// 灰度膨胀事件
        /// </summary>
        public delegate void GrayDilationHandle(string str);
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
                UserControlValueChanged?.Invoke(("灰度膨胀:" + m_OutStr));
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
