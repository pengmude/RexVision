namespace EasyVision.EVControl.EVForms
{
    partial class ModuleFlow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleFlow));
            gCursorLib.TextShadower textShadower1 = new gCursorLib.TextShadower();
            this.VscrollBar = new System.Windows.Forms.VScrollBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.禁用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCursor1 = new gCursorLib.gCursor(this.components);
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VscrollBar
            // 
            this.VscrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VscrollBar.Location = new System.Drawing.Point(246, 0);
            this.VscrollBar.Name = "VscrollBar";
            this.VscrollBar.Size = new System.Drawing.Size(21, 400);
            this.VscrollBar.TabIndex = 3;
            this.VscrollBar.ValueChanged += new System.EventHandler(this.VscrollBar_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.禁用ToolStripMenuItem,
            this.删除选中ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 禁用ToolStripMenuItem
            // 
            this.禁用ToolStripMenuItem.Name = "禁用ToolStripMenuItem";
            this.禁用ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.禁用ToolStripMenuItem.Text = "禁用";
            this.禁用ToolStripMenuItem.Click += new System.EventHandler(this.禁用ToolStripMenuItem_Click);
            // 
            // 删除选中ToolStripMenuItem
            // 
            this.删除选中ToolStripMenuItem.Name = "删除选中ToolStripMenuItem";
            this.删除选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除选中ToolStripMenuItem.Text = "删除模块";
            this.删除选中ToolStripMenuItem.Click += new System.EventHandler(this.删除选中ToolStripMenuItem_Click);
            // 
            // gCursor1
            // 
            this.gCursor1.gBlackBitBack = false;
            this.gCursor1.gBoxShadow = true;
            this.gCursor1.gCursorImage = ((System.Drawing.Bitmap)(resources.GetObject("gCursor1.gCursorImage")));
            this.gCursor1.gEffect = gCursorLib.gCursor.eEffect.No;
            this.gCursor1.gFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gCursor1.gHotSpot = System.Drawing.ContentAlignment.MiddleCenter;
            this.gCursor1.gIBTransp = 80;
            this.gCursor1.gImage = null;
            this.gCursor1.gImageBorderColor = System.Drawing.Color.Black;
            this.gCursor1.gImageBox = new System.Drawing.Size(32, 32);
            this.gCursor1.gImageBoxColor = System.Drawing.Color.White;
            this.gCursor1.gITransp = 0;
            this.gCursor1.gScrolling = gCursorLib.gCursor.eScrolling.No;
            this.gCursor1.gShowImageBox = false;
            this.gCursor1.gShowTextBox = false;
            this.gCursor1.gTBTransp = 80;
            this.gCursor1.gText = "";
            this.gCursor1.gTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gCursor1.gTextAutoFit = gCursorLib.gCursor.eTextAutoFit.None;
            this.gCursor1.gTextBorderColor = System.Drawing.Color.Red;
            this.gCursor1.gTextBox = new System.Drawing.Size(100, 30);
            this.gCursor1.gTextBoxColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextFade = gCursorLib.gCursor.eTextFade.Solid;
            this.gCursor1.gTextMultiline = false;
            this.gCursor1.gTextShadow = false;
            this.gCursor1.gTextShadowColor = System.Drawing.Color.Black;
            textShadower1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            textShadower1.Blur = 2F;
            textShadower1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            textShadower1.Offset = ((System.Drawing.PointF)(resources.GetObject("textShadower1.Offset")));
            textShadower1.Padding = new System.Windows.Forms.Padding(0);
            textShadower1.ShadowColor = System.Drawing.Color.Black;
            textShadower1.ShadowTransp = 128;
            textShadower1.Text = "Drop Shadow";
            textShadower1.TextColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextShadower = textShadower1;
            this.gCursor1.gTTransp = 0;
            this.gCursor1.gType = gCursorLib.gCursor.eType.Text;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 300;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_updown_Tick);
            // 
            // ModuleFlow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.VscrollBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(150, 280);
            this.Name = "ModuleFlow";
            this.Size = new System.Drawing.Size(267, 400);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ModuleFlow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ModelFlow_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.ModuleFlow_DragOver);
            this.DragLeave += new System.EventHandler(this.ModelFlow_DragLeave);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.ModuleFlow_GiveFeedback);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ModuleFlow_MouseClick);
            this.Resize += new System.EventHandler(this.ModelFlow_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar VscrollBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除选中ToolStripMenuItem;
        private gCursorLib.gCursor gCursor1;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.ToolStripMenuItem 禁用ToolStripMenuItem;
    }
}
