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

namespace Plugin.QueueOut
{
    public partial class QueueOutModForm : FormBase
    {
        private QueueOutModObj mObj ;
        public QueueOutModForm(QueueOutModObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void DelayModForm_Load(object sender, EventArgs e)
        {
        }
        public override void  FormToObj()
        {
            mObj.dataOut.IsWait = cb_Wait.Checked;//阻塞
            mObj.dataOut.IsDeleteData = cb_Delete.Checked;//删除出队数据
            mObj.dataOut.IsLimitLength = cb_Lenght.Checked;//长度限制
            mObj.dataOut.LimitLength = (int)num_Lenght.Value;//长度限制个数
        }
        public override void ObjToForm()
        {
            cb_Wait.Checked = mObj.dataOut.IsWait;
            cb_Delete.Checked = mObj.dataOut.IsDeleteData;
            cb_Lenght.Checked = mObj.dataOut.IsLimitLength;
            num_Lenght.Value = mObj.dataOut.LimitLength;
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        private void cb_Wait_CheckStateChanged(object sender, EventArgs e)
        {
            FormToObj();
        }
        //创建队列
        private void btn_AddData_Click(object sender, EventArgs e)
        {
           Button btn = sender as Button;
            switch (btn.Text.Replace("添加","").ToLower())
            {
                case "int":
                    mObj.dataOut.DefineIntQueue();
                    break;
                case "bool":
                    mObj.dataOut.DefineBoolQueue();
                    break;
                case "double":
                    mObj.dataOut.DefineDoubleQueue();
                    break;
                case "string":
                    mObj.dataOut.DefineStringQueue();
                    break;
                case "int[]":
                    mObj.dataOut.DefineIntListQueue();
                    break;
                case "bool[]":
                    mObj.dataOut.DefineBoolListQueue();
                    break;
                case "double[]":
                    mObj.dataOut.DefineDoubleListQueue();
                    break;
                case "string[]":
                    mObj.dataOut.DefineStringListQueue();
                    break;
            }
        }
        private void btn_Chang_Click(object sender, EventArgs e)
        {

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
