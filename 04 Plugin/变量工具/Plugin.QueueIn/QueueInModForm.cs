using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.QueueIn
{
    public partial class QueueInModForm : FormBase
    {
        private QueueInModObj mObj ;
        public QueueInModForm(QueueInModObj Obj) : base(Obj)
        {
            InitializeComponent();
            mObj = Obj;
        }
        private void DelayModForm_Load(object sender, EventArgs e)
        {
            mObj = (QueueInModObj)ObjBase;
        }
        public override void  FormToObj()
        {
        }
        public override void ObjToForm()
        {
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
