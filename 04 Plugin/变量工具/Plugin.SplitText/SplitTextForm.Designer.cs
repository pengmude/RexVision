namespace Plugin.SplitText
{
    partial class SplitTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitTextForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Location = new System.Drawing.Point(1, 229);
            this.panel_bottom.Size = new System.Drawing.Size(256, 38);
            // 
            // panel_center
            // 
            this.panel_center.Margin = new System.Windows.Forms.Padding(4);
            this.panel_center.Size = new System.Drawing.Size(256, 196);
            // 
            // uitb_Remark
            // 
            this.uitb_Remark.Location = new System.Drawing.Point(1, 3);
            this.uitb_Remark.Size = new System.Drawing.Size(1, 23);
            // 
            // uIlb_describle
            // 
            this.uIlb_describle.Visible = false;
            // 
            // cb_Enable
            // 
            this.cb_Enable.Location = new System.Drawing.Point(3, 12);
            this.cb_Enable.Size = new System.Drawing.Size(35, 21);
            this.cb_Enable.Visible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(157, 6);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(157, 6);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(55, 6);
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // titlepanel
            // 
            this.titlepanel.Size = new System.Drawing.Size(256, 32);
            // 
            // SplitTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 268);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(260, 270);
            this.MinimumSize = new System.Drawing.Size(260, 270);
            this.Name = "SplitTextForm";
            this.Load += new System.EventHandler(this.GetDataModForm_Load);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
    }
}