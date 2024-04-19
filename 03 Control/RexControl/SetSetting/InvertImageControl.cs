using System;
using System.Windows.Forms;


namespace RexControl
{
    /// <summary>
    /// 反色
    /// </summary>
    public partial class InvertImageControl : UserControl
    {
        public InvertImageControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 反色事件
        /// </summary>
        public  event InvertImageHandle UserControlValueChanged;
        /// <summary>
        /// 反色委托
        /// </summary>
        /// <param name="str"></param>
        public delegate void InvertImageHandle(string str);
        private void ucNumTextBox_Numchanged(object sender, EventArgs e)
        {
            //try
            //{
            //    string m_OutStr = "";
            //    label2.Text = trackBar1.Value.ToString();
            //    {
            //        try
            //        {
            //            TrackBar CheckBox = (TrackBar)sender;
            //            switch (CheckBox.Name)
            //            {
            //                case "trackBar1":
            //                    m_OutStr = "大小:" + trackBar1.Value.ToString();
            //                    break;
            //            }
            //        }
            //        catch { }
            //    }
            //    UserControlValueChanged?.Invoke(("高斯滤波:" + m_OutStr));
            //}
            //catch { }
        }
        /// <summary>
        /// 显示默认或加载保存数据到窗体
        /// </summary>
        /// <param name="Size"></param>
        public void ShowControlValue(double Size)
        {
            //trackBar1.Value = (int)Size;
            //label2.Text = Size.ToString();
        }
    }
}
