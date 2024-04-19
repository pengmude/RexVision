using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RexHelps
{
    public partial class FrmInfo : Form
    {
        public FrmInfo(string InfoContent,string title="提示信息",string btnText="确认")
        {
            InitializeComponent();
            GroupBox1.Text = title;
            btn_Confirm.Text = btnText;
            rbox_Info.Text = InfoContent;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
