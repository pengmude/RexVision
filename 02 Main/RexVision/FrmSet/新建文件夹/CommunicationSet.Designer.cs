namespace QuickVision.UI
{
    partial class CommunicationSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunicationSet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_ClearSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Read = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Send = new System.Windows.Forms.TextBox();
            this.cb_EComType = new System.Windows.Forms.ComboBox();
            this.btn_AddECom = new System.Windows.Forms.Button();
            this.lb_ECom = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_ECom = new System.Windows.Forms.GroupBox();
            this.btn_RemovECom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dmTcpClient1 = new DMSkin.Socket.DMTcpClient(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_1.Image")));
            this.pictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btn_Send);
            this.groupBox1.Controls.Add(this.btn_ClearSend);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Read);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Send);
            this.groupBox1.Location = new System.Drawing.Point(7, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(96, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "16进制接收";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "16进制发送";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(356, 172);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(53, 31);
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // btn_ClearSend
            // 
            this.btn_ClearSend.Location = new System.Drawing.Point(356, 120);
            this.btn_ClearSend.Name = "btn_ClearSend";
            this.btn_ClearSend.Size = new System.Drawing.Size(53, 31);
            this.btn_ClearSend.TabIndex = 4;
            this.btn_ClearSend.Text = "清空";
            this.btn_ClearSend.UseVisualStyleBackColor = true;
            this.btn_ClearSend.Click += new System.EventHandler(this.bt_ClearSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "接收数据";
            // 
            // tb_Read
            // 
            this.tb_Read.Location = new System.Drawing.Point(3, 27);
            this.tb_Read.Multiline = true;
            this.tb_Read.Name = "tb_Read";
            this.tb_Read.Size = new System.Drawing.Size(410, 75);
            this.tb_Read.TabIndex = 2;
            this.tb_Read.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_Read_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "发送数据";
            // 
            // tb_Send
            // 
            this.tb_Send.Location = new System.Drawing.Point(3, 120);
            this.tb_Send.Multiline = true;
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.Size = new System.Drawing.Size(346, 83);
            this.tb_Send.TabIndex = 0;
            // 
            // cb_EComType
            // 
            this.cb_EComType.AutoCompleteCustomSource.AddRange(new string[] {
            "TCP客户端通信",
            "TCP服务器通信",
            "UDP通信",
            "串口通信"});
            this.cb_EComType.FormattingEnabled = true;
            this.cb_EComType.Items.AddRange(new object[] {
            "TCP服务端",
            "TCP客户端",
            "UDP通信",
            "串口通信"});
            this.cb_EComType.Location = new System.Drawing.Point(10, 20);
            this.cb_EComType.Name = "cb_EComType";
            this.cb_EComType.Size = new System.Drawing.Size(121, 20);
            this.cb_EComType.TabIndex = 4;
            this.cb_EComType.Text = "TCP服务端";
            // 
            // btn_AddECom
            // 
            this.btn_AddECom.Location = new System.Drawing.Point(133, 20);
            this.btn_AddECom.Name = "btn_AddECom";
            this.btn_AddECom.Size = new System.Drawing.Size(61, 23);
            this.btn_AddECom.TabIndex = 9;
            this.btn_AddECom.Text = "增加";
            this.btn_AddECom.UseVisualStyleBackColor = true;
            this.btn_AddECom.Click += new System.EventHandler(this.bt_AddECom_Click);
            // 
            // lb_ECom
            // 
            this.lb_ECom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_ECom.FormattingEnabled = true;
            this.lb_ECom.ItemHeight = 12;
            this.lb_ECom.Location = new System.Drawing.Point(3, 79);
            this.lb_ECom.Name = "lb_ECom";
            this.lb_ECom.Size = new System.Drawing.Size(194, 148);
            this.lb_ECom.TabIndex = 12;
            this.lb_ECom.SelectedIndexChanged += new System.EventHandler(this.lb_ECom_SelectedIndexChanged);
            // 
            // gb_ECom
            // 
            this.gb_ECom.Location = new System.Drawing.Point(212, 41);
            this.gb_ECom.Name = "gb_ECom";
            this.gb_ECom.Size = new System.Drawing.Size(211, 230);
            this.gb_ECom.TabIndex = 13;
            this.gb_ECom.TabStop = false;
            this.gb_ECom.Text = "属性";
            // 
            // btn_RemovECom
            // 
            this.btn_RemovECom.Location = new System.Drawing.Point(10, 47);
            this.btn_RemovECom.Name = "btn_RemovECom";
            this.btn_RemovECom.Size = new System.Drawing.Size(184, 23);
            this.btn_RemovECom.TabIndex = 14;
            this.btn_RemovECom.Text = "删除选择";
            this.btn_RemovECom.UseVisualStyleBackColor = true;
            this.btn_RemovECom.Click += new System.EventHandler(this.bt_RemovECom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_EComType);
            this.groupBox3.Controls.Add(this.btn_RemovECom);
            this.groupBox3.Controls.Add(this.lb_ECom);
            this.groupBox3.Controls.Add(this.btn_AddECom);
            this.groupBox3.Location = new System.Drawing.Point(7, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 230);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通信列表";
            // 
            // dmTcpClient1
            // 
            this.dmTcpClient1.Isclosed = false;
            this.dmTcpClient1.IsStartTcpthreading = false;
            this.dmTcpClient1.Receivestr = null;
            this.dmTcpClient1.ReConectedCount = 0;
            this.dmTcpClient1.ReConnectionTime = 3000;
            this.dmTcpClient1.ServerIp = null;
            this.dmTcpClient1.ServerPort = 0;
            this.dmTcpClient1.Tcpclient = null;
            this.dmTcpClient1.Tcpthread = null;
            // 
            // Communication_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_ECom);
            this.Controls.Add(this.groupBox1);
            this.Name = "Communication_Set";
            this.Title = "通讯设置";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gb_ECom, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_ClearSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Send;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cb_EComType;
        private System.Windows.Forms.Button btn_AddECom;
        private System.Windows.Forms.ListBox lb_ECom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gb_ECom;
        private System.Windows.Forms.Button btn_RemovECom;
        private System.Windows.Forms.GroupBox groupBox3;
        private DMSkin.Socket.DMTcpClient dmTcpClient1;
    }
}