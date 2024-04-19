namespace RexHelps
{
    partial class FrmInfo
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbox_Info = new System.Windows.Forms.RichTextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbox_Info);
            this.GroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(513, 275);
            this.GroupBox1.TabIndex = 252;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "提示信息：";
            // 
            // rbox_Info
            // 
            this.rbox_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbox_Info.Location = new System.Drawing.Point(3, 19);
            this.rbox_Info.Name = "rbox_Info";
            this.rbox_Info.ReadOnly = true;
            this.rbox_Info.Size = new System.Drawing.Size(507, 253);
            this.rbox_Info.TabIndex = 0;
            this.rbox_Info.Text = "";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.White;
            this.btn_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Confirm.Location = new System.Drawing.Point(12, 293);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(513, 30);
            this.btn_Confirm.TabIndex = 253;
            this.btn_Confirm.Text = "确认";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(542, 333);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInfo";
            this.Text = "FrmInfo";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RichTextBox rbox_Info;
        internal System.Windows.Forms.Button btn_Confirm;
    }
}