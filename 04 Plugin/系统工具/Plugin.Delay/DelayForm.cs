using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.Delay
{
    public partial class DelayForm: FormBase
    {
        private DelayObj mObj ;
        public DelayForm(DelayObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DelayForm_Load(object sender, EventArgs e){}
        public override void  FormToObj()
        {        
            mObj.mDelayTime = (int)uidd_Time.Value;
            mObj.mEventWait = new AutoResetEvent(false);//采集信号
        }
        public override void ObjToForm()
        {
            uidd_Time.Value = mObj.mDelayTime;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();
            ObjToForm();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            mObj.Stop();
            this.Close();
        }
    }
}
