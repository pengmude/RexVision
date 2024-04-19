namespace RexHelps
{
    partial class frmRegistered
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
            this.tbMachineCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRegisterCode = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGetMachineCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMachineCode
            // 
            this.tbMachineCode.Location = new System.Drawing.Point(110, 49);
            this.tbMachineCode.Name = "tbMachineCode";
            this.tbMachineCode.Size = new System.Drawing.Size(272, 25);
            this.tbMachineCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "机器码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "注册码";
            // 
            // tbRegisterCode
            // 
            this.tbRegisterCode.Location = new System.Drawing.Point(110, 103);
            this.tbRegisterCode.Name = "tbRegisterCode";
            this.tbRegisterCode.Size = new System.Drawing.Size(272, 25);
            this.tbRegisterCode.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(199, 161);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 34);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGetMachineCode
            // 
            this.btnGetMachineCode.Location = new System.Drawing.Point(402, 42);
            this.btnGetMachineCode.Name = "btnGetMachineCode";
            this.btnGetMachineCode.Size = new System.Drawing.Size(75, 34);
            this.btnGetMachineCode.TabIndex = 5;
            this.btnGetMachineCode.Text = "刷新";
            this.btnGetMachineCode.UseVisualStyleBackColor = true;
            this.btnGetMachineCode.Click += new System.EventHandler(this.btnGetMachineCode_Click);
            // 
            // frmRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 275);
            this.Controls.Add(this.btnGetMachineCode);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegisterCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMachineCode);
            this.Name = "frmRegistered";
            this.Text = "视觉组件注册";
            this.Load += new System.EventHandler(this.frmRegistered_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMachineCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRegisterCode;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnGetMachineCode;
    }
}