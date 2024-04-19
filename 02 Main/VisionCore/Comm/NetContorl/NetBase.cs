using System;
using System.Windows.Forms;
using VisionCore;

namespace VisionCore
{
    public partial class NetBase : UserControl
    {
        /// <summary>通信控件</summary>
        protected ECom mECom;
        /// <summary>启用通信</summary>
        public bool Enable { get; set; }
        /// <summary>备注</summary>
        public string Remarks { get; set; }
        /// <summary>通信名字</summary>
        public string Key { get; set; }
        public NetBase()
        {
            InitializeComponent();
        }
        private void uicb_Enable_ValueChanged(object sender, bool value)
        {
            if (mECom == null) { return; }
            if (uicb_Enable.Checked == false)
            {
                mECom.DisConnect();
            }
            else
            {
                mECom.Connect();
            }
        }
        private void uitb_Remark_TextChanged(object sender, EventArgs e)
        {
            if (mECom == null) { return; }
            mECom.Remarks = uitb_Remark.Text;
        }
        public virtual bool Get_ECom(ECom ecom)
        {
            mECom = ecom;
            uilb_Key.Text = mECom.Key;
            return true;
        }  
    }
}
