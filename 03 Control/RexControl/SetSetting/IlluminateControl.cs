using System;
using System.Windows.Forms;



namespace RexControl
{
    /// <summary>
    /// 对比度
    /// </summary>
    public partial class IlluminateControl : UserControl
    {
        public IlluminateControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 对比度事件
        /// </summary>
        public  event IlluminateHandle UserControlValueChanged;
        /// <summary>
        /// 对比度委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void IlluminateHandle(string str);
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label3.Text = trackBar1.Value.ToString();
                label4.Text = trackBar2.Value.ToString();
                label5.Text = trackBar3.Value.ToString();
                string m_OutStr = "";
                {
                    try
                    {
                        TrackBar trackBar = (TrackBar)sender;
                        switch (trackBar.Name)
                        {
                            case "trackBar1":
                                m_OutStr = "宽度:" + trackBar1.Value.ToString();
                                break;
                            case "trackBar2":
                                m_OutStr = "高度:" + trackBar2.Value.ToString();
                                break;
                            case "trackBar3":
                                m_OutStr = "对比因子:" + trackBar3.Value.ToString();
                                break;
                        }
                    }
                    catch { }
                }


                UserControlValueChanged?.Invoke("对比度:" + m_OutStr);
            }
            catch { }
        }
        /// <summary>
        /// 显示默认或加载保存数据到窗体
        /// </summary>
        /// <param name="Wight"></param>
        /// <param name="Height"></param>
        /// <param name="Reverse"></param>
        public void ShowControlValue(double Wight, double Height, double Factor)
        {
            trackBar1.Value = (int)Wight;
            trackBar2.Value = (int)Height;
            trackBar3.Value = (int)Factor;

            label3.Text = Wight.ToString();
            label4.Text = Height.ToString();
            label5.Text = Factor.ToString();
        }
    }
}
