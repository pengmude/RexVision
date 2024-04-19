namespace RexVision
{
    partial class FrmLock
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_password.Location = new System.Drawing.Point(41, 84);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(156, 26);
            this.tbx_password.TabIndex = 6;
            this.tbx_password.Click += new System.EventHandler(this.tbx_password_Click);
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_password_TextChanged);
            // 
            // btn_unlock
            // 
            this.btn_unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unlock.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_unlock.Location = new System.Drawing.Point(204, 85);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(50, 26);
            this.btn_unlock.TabIndex = 5;
            this.btn_unlock.Text = "解锁";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "锁定中......";
            // 
            // FrmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 158);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.btn_unlock);
            this.Controls.Add(this.label1);
            this.Name = "FrmLock";
            this.Text = "FrmLock";
            this.Load += new System.EventHandler(this.FrmLock_Load);
            this.Shown += new System.EventHandler(this.FrmLock_Shown);
            this.Click += new System.EventHandler(this.FrmLock_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLock_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLock_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmLock_MouseUp);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLock_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Label label1;
    }
}