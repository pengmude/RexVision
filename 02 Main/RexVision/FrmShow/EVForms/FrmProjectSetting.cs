using EasyVision.Common.EVStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVision.EVControl.EVForms
{
    public partial class FrmProjectSetting : Form
    {
        private ProjectInfo m_ProjectInfo;
        public ProjectInfo ProjectInfo
        {
            get { return m_ProjectInfo; }
           private set { m_ProjectInfo = value; }
        }
        public FrmProjectSetting(ProjectInfo projectInfo)
        {
            InitializeComponent();
            this.ProjectInfo = projectInfo;
        }

        private void FrmProjectSetting_Load(object sender, EventArgs e)
        {
            if (ProjectInfo.ProjectName!=null)
            {
                this.txtProjectName.Text = ProjectInfo.ProjectName;
            }
            
        }

        private void FrmProjectSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
             ProjectInfo.ProjectName= this.txtProjectName.Text;
        }
    }
}
