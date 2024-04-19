using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RexView.jig
{
    public partial class ProgressBarForm : Form
    {


        public ProgressBarForm()
        {
            InitializeComponent();
        }

        public void setMax(int max)
        {
            progressBar1.Maximum = max;
        }

        public void setValue(int value)
        {
            this.BeginInvoke(new Action(() => {
                progressBar1.Value = value;
            }));
        }
    }
}
