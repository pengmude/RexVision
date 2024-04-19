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
    /// 图像旋转
    /// </summary>
    public partial class MirrorImageControl : UserControl
    {
        public MirrorImageControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 图像旋转事件
        /// </summary>
        public  event MirrorImageHandle UserControlValueChanged;
        /// <summary>
        /// 图像旋转委托
        /// </summary>
        public delegate void MirrorImageHandle(string str);
        private void ucNumTextBox_Numchanged(object sender, EventArgs e)
        {
            try
            {
                string m_OutStr = "";
                {
                    try
                    {
                        //UCNumTextBox CheckBox = (UCNumTextBox)sender;
                        //switch (CheckBox.Name)
                        //{
                        //    case "ucNumTextBox1":
                        //        m_OutStr = "宽度:" + ucNumTextBox1.Num.ToString();
                        //        break;
                        //    case "ucNumTextBox2":
                        //        m_OutStr = "高度:" + ucNumTextBox2.Num.ToString();
                        //        break;
                        //}
                    }
                    catch { }
                }
                UserControlValueChanged?.Invoke(("改图像尺寸:" + m_OutStr));
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
            //ucNumTextBox1.Num = (int)Wight;
            //ucNumTextBox2.Num = (int)Height;
        }
    }
}
