using System;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    /// <summary>
    /// 工具箱
    /// </summary>
    public partial class FrmTool : DockContent
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void FrmModTree_Load(object sender, EventArgs e)
        {
           ModTree1.Init(PluginToolService.mPluginDic);
        }
    }
}
