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

namespace Plugin.SplitText
{
    public partial class SplitTextForm: FormBase
    {
        private SplitTextObj mObj ;
        public SplitTextForm(SplitTextObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }
        private void GetDataModForm_Load(object sender, EventArgs e)
        {
         
        }
        public override void  FormToObj()
        {
            //mObj.m_eKey = comboBox1.Text;
            //mObj.m_eData = textBox2.Text;
        }
        public override void ObjToForm()
        {           
            //List<string> str_l = new List<string>();
            //comboBox1.Items.Clear();
            //if (mObj.mECom.Count > 0)
            //{
            //    foreach (ECom com in mObj.mECom)
            //    {
            //        str_l.Add(com.Key);
            //        comboBox1.Items.Add(com.Key);
            //    }
            //}
            //comboBox1.Text = mObj.m_eKey;
            //textBox2.Text = mObj.m_eData;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            FormToObj();
            mObj.RunObj();

        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
