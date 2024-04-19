using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyVision.Common.EVStruct;
using EasyVision.Service.Project;

namespace EasyVision.EVControl.EVForms
{
    public class ProjectTab
    {
        TabPage m_TabPage;
        private ModuleFlow m_ModelFlow;
        private ProjectInfo m_ProjectInfo;
        public ProjectInfo ProjectInfo
        {
            get { return m_ProjectInfo; }
            set
            {
                m_ProjectInfo = value;
                TabPage.Text = m_ProjectInfo.ProjectName;
                m_ModelFlow.ProjectInfo = value;
            }
        }
        public System.Windows.Forms.TabPage TabPage
        {
            get { return m_TabPage; }
            set { m_TabPage = value; }
        }
        
        public ModuleFlow ModelFlow
        {
            get { return m_ModelFlow; }
            set { m_ModelFlow = value; }
        }

        public ProjectTab(Project proj)
        {
     
            ModelFlow = new ModuleFlow(proj);
            ModelFlow.Dock = DockStyle.Fill;
            ModelFlow.MakeUnitFlow();
            TabPage = new TabPage();
            TabPage.Text = proj.ProjectInfo.ProjectName;
            TabPage.Padding = new System.Windows.Forms.Padding(3);
            TabPage.UseVisualStyleBackColor = true;
            TabPage.Controls.Add(ModelFlow);
            this.ProjectInfo = proj.ProjectInfo;
        }
    }
}
