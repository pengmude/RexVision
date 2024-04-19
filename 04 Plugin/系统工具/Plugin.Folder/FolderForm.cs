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

namespace Plugin.Folder
{
    public partial class FolderForm: FormBase
    {

        private FolderObj mObj ;


        public FolderForm(FolderObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }


        private void DelayModForm_Load(object sender, EventArgs e)
        {
            mObj = (FolderObj)ObjBase;
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
        }
    }
}
