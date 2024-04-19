using VisionCore;

namespace RexVision
{
    partial class FrmProj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProj));
            this.m_SolView = new VisionCore.SolView();
            this.SuspendLayout();
            // 
            // m_SolView
            // 
            this.m_SolView.BackColor = System.Drawing.SystemColors.Control;
            this.m_SolView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_SolView.Location = new System.Drawing.Point(0, 0);
            this.m_SolView.Margin = new System.Windows.Forms.Padding(0);
            this.m_SolView.Name = "m_SolView";
            this.m_SolView.Size = new System.Drawing.Size(239, 492);
            this.m_SolView.TabIndex = 0;
            // 
            // FrmProj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 492);
            this.Controls.Add(this.m_SolView);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProj";
            this.Text = "流程栏";
            this.ResumeLayout(false);

        }

        #endregion

        public SolView m_SolView;
    }
}