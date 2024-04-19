namespace RexVision
{
    partial class FrmLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog));
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_tip = new System.Windows.Forms.ToolStripButton();
            this.tsb_warn = new System.Windows.Forms.ToolStripButton();
            this.tsb_error = new System.Windows.Forms.ToolStripButton();
            this.ctms_Clear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.ctms_Clear.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BackColor = System.Drawing.Color.White;
            this.richTextBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_log.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(718, 273);
            this.richTextBox_log.TabIndex = 290;
            this.richTextBox_log.Text = "";
            this.richTextBox_log.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_log_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_tip,
            this.tsb_warn,
            this.tsb_error});
            this.toolStrip1.Location = new System.Drawing.Point(0, 248);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 291;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // tsb_tip
            // 
            this.tsb_tip.CheckOnClick = true;
            this.tsb_tip.Image = ((System.Drawing.Image)(resources.GetObject("tsb_tip.Image")));
            this.tsb_tip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_tip.Name = "tsb_tip";
            this.tsb_tip.Size = new System.Drawing.Size(67, 22);
            this.tsb_tip.Text = "提示(0)";
            // 
            // tsb_warn
            // 
            this.tsb_warn.CheckOnClick = true;
            this.tsb_warn.Image = ((System.Drawing.Image)(resources.GetObject("tsb_warn.Image")));
            this.tsb_warn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_warn.Name = "tsb_warn";
            this.tsb_warn.Size = new System.Drawing.Size(67, 22);
            this.tsb_warn.Text = "警告(0)";
            // 
            // tsb_error
            // 
            this.tsb_error.CheckOnClick = true;
            this.tsb_error.Image = ((System.Drawing.Image)(resources.GetObject("tsb_error.Image")));
            this.tsb_error.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_error.Name = "tsb_error";
            this.tsb_error.Size = new System.Drawing.Size(67, 22);
            this.tsb_error.Text = "错误(0)";
            // 
            // ctms_Clear
            // 
            this.ctms_Clear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空历史ToolStripMenuItem});
            this.ctms_Clear.Name = "ctms_Clear";
            this.ctms_Clear.Size = new System.Drawing.Size(125, 26);
            // 
            // 清空历史ToolStripMenuItem
            // 
            this.清空历史ToolStripMenuItem.Name = "清空历史ToolStripMenuItem";
            this.清空历史ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空历史ToolStripMenuItem.Text = "清空历史";
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 273);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox_log);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLog";
            this.Text = "运行日志";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctms_Clear.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_tip;
        private System.Windows.Forms.ToolStripButton tsb_warn;
        private System.Windows.Forms.ToolStripButton tsb_error;
        private System.Windows.Forms.ContextMenuStrip ctms_Clear;
        private System.Windows.Forms.ToolStripMenuItem 清空历史ToolStripMenuItem;
    }
}