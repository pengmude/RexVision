namespace RexVision
{
    partial class FrmCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCanvas));
            this.canvasView1 = new RexForm.CanvasView();
            this.SuspendLayout();
            // 
            // canvasView1
            // 
            this.canvasView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.canvasView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canvasView1.Location = new System.Drawing.Point(0, 0);
            this.canvasView1.Margin = new System.Windows.Forms.Padding(0);
            this.canvasView1.Name = "canvasView1";
            this.canvasView1.Padding = new System.Windows.Forms.Padding(2);
            this.canvasView1.Size = new System.Drawing.Size(538, 430);
            this.canvasView1.TabIndex = 0;
            this.canvasView1.ViewMode = RexForm.ViewMode.One;
            // 
            // FrmCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 430);
            this.Controls.Add(this.canvasView1);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCanvas";
            this.Text = "图像显示";
            this.ResumeLayout(false);

        }

        #endregion

        private RexForm.CanvasView canvasView1;
    }
}