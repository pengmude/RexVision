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

namespace Plugin.Lable
{
    public partial class LableForm: FormBase
    {

        private LableObj mObj ;


        public LableForm(LableObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
            mObj.RunObj();
        }
        private void DelayModForm_Load(object sender, EventArgs e)
        {
        }
        public override void  FormToObj()
        {
        }
        public override void ObjToForm()
        {
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
    }
}
