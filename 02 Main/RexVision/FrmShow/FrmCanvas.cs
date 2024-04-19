using RexConst;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    /// <summary>
    /// 图像显示窗口
    /// </summary>
    public partial class FrmCanvas : DockContent
    {
        public FrmCanvas()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.Font;
            this.canvasView1.ViewMode = RexForm.ViewMode.One;
        }
       public void SetViewMode(int num)
        {
            if (num > 9) { return; }
            this.canvasView1.ViewMode = (RexForm.ViewMode) num;
        }
        public void ScreenShow(RImage Image)
        {
            this.canvasView1.Show(Image);
        }
    }
}
