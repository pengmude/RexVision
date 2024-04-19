using VisionCore;

namespace RexVision
{
    partial class FrmTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTool));
            this.ModTree1 = new ModTree();
            this.SuspendLayout();
            // 
            // ModTree1
            // 
            this.ModTree1.BackColor = System.Drawing.SystemColors.Control;
            this.ModTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModTree1.Indent = 19;
            this.ModTree1.Location = new System.Drawing.Point(0, 0);
            this.ModTree1.Margin = new System.Windows.Forms.Padding(2);
            this.ModTree1.Name = "ModTree1";
            this.ModTree1.SelectedNode = null;
            this.ModTree1.Size = new System.Drawing.Size(279, 460);
            this.ModTree1.TabIndex = 0;
            // 
            // FrmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 460);
            this.Controls.Add(this.ModTree1);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTool";
            this.Text = "工具箱";
            this.Load += new System.EventHandler(this.FrmModTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ModTree ModTree1;
    }
}