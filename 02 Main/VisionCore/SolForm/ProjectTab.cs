using System.Windows.Forms;
namespace VisionCore
{
    /// <summary>新建流程页</summary>
    public class ProjTab
    {
        /// <summary>流程信息</summary>
        private ProjInfo mProjInfo;
        /// <summary>流程信息</summary>
        public ProjInfo ProjInfo
        {
            get { return mProjInfo; }
            set
            {
                mProjInfo = value;
                TabPage.Text = mProjInfo.Name;
                ModelFlow.ProjInfo = value;
            }
        }
        /// <summary>流程页</summary>
        public TabPage TabPage { get; set; }
        /// <summary>流程单元</summary>
        public ModFlow ModelFlow { get; set; }
        /// <summary>流程信息初始化</summary>
        /// <param name="proj">流程</param>
        public ProjTab(Proj proj)
        {   
            ModelFlow = new ModFlow(proj);
            ModelFlow.Dock = DockStyle.Fill;
            TabPage = new TabPage();
            TabPage.Text = proj.mProjInfo.Name;
            TabPage.Padding = new Padding(3);
            TabPage.UseVisualStyleBackColor = true;
            TabPage.Controls.Add(ModelFlow);
            this.ProjInfo = proj.mProjInfo;            
        }
    }
}
