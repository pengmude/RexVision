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
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    public partial class FrmAbout : DockForm
    {
        public FrmAbout()
        {
            InitializeComponent();
            this.Set_MinMax();
        }
    }
}
