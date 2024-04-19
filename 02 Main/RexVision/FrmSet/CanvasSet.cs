using DockContrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RexVision
{

    public partial class CanvasSet : DockForm
    {     
        /// <summary>原有数量</summary>
        public int OrgQty = 0;
        /// <summary>更改数量</summary>
        public int NewQty = 0;
        public CanvasSet()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 画布设置
        /// </summary>
        /// <param name="SetQty">设置数量</param>
        public CanvasSet(int SetQty)
        {
            NewQty = SetQty;
            OrgQty = SetQty;
            this.Set_MinMax();
            InitializeComponent();
        }
        private void CanvasSet_Load(object sender, EventArgs e)
        {
            if (NewQty == 0) { rb_1.Checked = true; }
            if (NewQty == 1) { rb_2.Checked = true; }
            if (NewQty == 2) { rb_3.Checked = true; }
            if (NewQty == 3) { rb_4.Checked = true; }
            if (NewQty == 4) { rb_5.Checked = true; }
            if (NewQty == 5) { rb_6.Checked = true; }
            if (NewQty == 6) { rb_7.Checked = true; }
            if (NewQty == 7) { rb_8.Checked = true; }
            if (NewQty == 8) { rb_9.Checked = true; }
        }
        private void rb_ValueChanged(object sender, bool value)
        {
            if (rb_1.Checked == true) { NewQty = 0; }
            if (rb_2.Checked == true) { NewQty = 1; }
            if (rb_3.Checked == true) { NewQty = 2; }
            if (rb_4.Checked == true) { NewQty = 3; }
            if (rb_5.Checked == true) { NewQty = 4; }
            if (rb_6.Checked == true) { NewQty = 5; }
            if (rb_7.Checked == true) { NewQty = 6; }
            if (rb_8.Checked == true) { NewQty = 7; }
            if (rb_9.Checked == true) { NewQty = 8; }
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Esc_Click(object sender, EventArgs e)
        {
            NewQty = OrgQty;
            Close();
        }
    }
}
