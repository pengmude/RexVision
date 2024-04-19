
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace RexVision
{
    /// <summary>
    /// 运行日志
    /// </summary>
    public partial class FrmLog : DockContent
    {
        public FrmLog()
        {
            InitializeComponent();
            //注册日志显示窗口
            Log.InitializeRichTextBox(this.richTextBox_log);
        }

        private void richTextBox_log_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //richTextBox_log.Text = "";
        }
    }
}
