namespace RexVision
{
    partial class NetSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetSet));
            this.groupBox1 = new Rex.UI.UIGroupBox();
            this.checkBox2 = new Rex.UI.UICheckBox();
            this.checkBox1 = new Rex.UI.UICheckBox();
            this.label2 = new Rex.UI.UILabel();
            this.tb_Read = new Rex.UI.UITextBox();
            this.label1 = new Rex.UI.UILabel();
            this.tb_Send = new Rex.UI.UITextBox();
            this.btn_Send = new Rex.UI.UIButton();
            this.btn_ClearSend = new Rex.UI.UIButton();
            this.cb_EComType = new Rex.UI.UIComboBox();
            this.btn_AddECom = new Rex.UI.UIButton();
            this.lb_ECom = new Rex.UI.UIListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_ECom = new Rex.UI.UIGroupBox();
            this.btn_RemovECom = new Rex.UI.UIButton();
            this.groupBox3 = new Rex.UI.UIGroupBox();
            this.dmTcpClient1 = new DMSkin.Socket.DMTcpClient(this.components);
            this.uiLabel1 = new Rex.UI.UILabel();
            this.uirb_EndChar = new Rex.UI.UIRadioButtonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.Image")));
            this.pbox_Icon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox_Icon.Size = new System.Drawing.Size(30, 30);
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlepanel.Size = new System.Drawing.Size(448, 30);
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.titlelabel.Location = new System.Drawing.Point(34, 7);
            this.titlelabel.Size = new System.Drawing.Size(56, 17);
            this.titlelabel.Text = "通讯设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uirb_EndChar);
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Read);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Send);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(4, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(440, 188);
            this.groupBox1.Style = Rex.UI.UIStyle.Custom;
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试";
            // 
            // checkBox2
            // 
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox2.Location = new System.Drawing.Point(65, 26);
            this.checkBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(100, 16);
            this.checkBox2.Style = Rex.UI.UIStyle.Custom;
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "16进制接收";
            // 
            // checkBox1
            // 
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.checkBox1.Location = new System.Drawing.Point(67, 108);
            this.checkBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(98, 16);
            this.checkBox1.Style = Rex.UI.UIStyle.Custom;
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "16进制发送";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.Style = Rex.UI.UIStyle.Custom;
            this.label2.TabIndex = 3;
            this.label2.Text = "接收数据";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Read
            // 
            this.tb_Read.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Read.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Read.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_Read.Location = new System.Drawing.Point(0, 44);
            this.tb_Read.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Read.Maximum = 2147483647D;
            this.tb_Read.Minimum = -2147483648D;
            this.tb_Read.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_Read.Multiline = true;
            this.tb_Read.Name = "tb_Read";
            this.tb_Read.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_Read.Size = new System.Drawing.Size(440, 58);
            this.tb_Read.Style = Rex.UI.UIStyle.Custom;
            this.tb_Read.TabIndex = 2;
            this.tb_Read.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_Read_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.Style = Rex.UI.UIStyle.Custom;
            this.label1.TabIndex = 1;
            this.label1.Text = "发送数据";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Send
            // 
            this.tb_Send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Send.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Send.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_Send.Location = new System.Drawing.Point(0, 128);
            this.tb_Send.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Send.Maximum = 2147483647D;
            this.tb_Send.Minimum = -2147483648D;
            this.tb_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_Send.Multiline = true;
            this.tb_Send.Name = "tb_Send";
            this.tb_Send.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.tb_Send.Size = new System.Drawing.Size(440, 60);
            this.tb_Send.Style = Rex.UI.UIStyle.Custom;
            this.tb_Send.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Send.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Send.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Send.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_Send.Location = new System.Drawing.Point(346, 497);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Send.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(82, 26);
            this.btn_Send.Style = Rex.UI.UIStyle.Custom;
            this.btn_Send.TabIndex = 5;
            this.btn_Send.Text = "发送";
            this.btn_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // btn_ClearSend
            // 
            this.btn_ClearSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClearSend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_ClearSend.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_ClearSend.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_ClearSend.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_ClearSend.Location = new System.Drawing.Point(246, 497);
            this.btn_ClearSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ClearSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ClearSend.Name = "btn_ClearSend";
            this.btn_ClearSend.Size = new System.Drawing.Size(82, 26);
            this.btn_ClearSend.Style = Rex.UI.UIStyle.Custom;
            this.btn_ClearSend.TabIndex = 4;
            this.btn_ClearSend.Text = "清空";
            this.btn_ClearSend.Click += new System.EventHandler(this.bt_ClearSend_Click);
            // 
            // cb_EComType
            // 
            this.cb_EComType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cb_EComType.FormattingEnabled = true;
            this.cb_EComType.Items.AddRange(new object[] {
            "TCP服务端",
            "TCP客户端",
            "串口通信",
            "UDP通信"});
            this.cb_EComType.Location = new System.Drawing.Point(10, 29);
            this.cb_EComType.Margin = new System.Windows.Forms.Padding(0);
            this.cb_EComType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_EComType.Name = "cb_EComType";
            this.cb_EComType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cb_EComType.Radius = 2;
            this.cb_EComType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cb_EComType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cb_EComType.Size = new System.Drawing.Size(121, 23);
            this.cb_EComType.StyleCustomMode = true;
            this.cb_EComType.TabIndex = 4;
            this.cb_EComType.Text = "TCP服务端";
            this.cb_EComType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_AddECom
            // 
            this.btn_AddECom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddECom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddECom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_AddECom.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_AddECom.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_AddECom.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_AddECom.Location = new System.Drawing.Point(133, 27);
            this.btn_AddECom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AddECom.Name = "btn_AddECom";
            this.btn_AddECom.Size = new System.Drawing.Size(61, 26);
            this.btn_AddECom.Style = Rex.UI.UIStyle.Custom;
            this.btn_AddECom.TabIndex = 9;
            this.btn_AddECom.Text = "增加";
            this.btn_AddECom.Click += new System.EventHandler(this.bt_AddECom_Click);
            // 
            // lb_ECom
            // 
            this.lb_ECom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_ECom.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_ECom.ItemHeight = 20;
            this.lb_ECom.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lb_ECom.Location = new System.Drawing.Point(0, 87);
            this.lb_ECom.Margin = new System.Windows.Forms.Padding(0);
            this.lb_ECom.MinimumSize = new System.Drawing.Size(1, 1);
            this.lb_ECom.Name = "lb_ECom";
            this.lb_ECom.Padding = new System.Windows.Forms.Padding(2);
            this.lb_ECom.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.lb_ECom.Size = new System.Drawing.Size(200, 198);
            this.lb_ECom.Style = Rex.UI.UIStyle.Custom;
            this.lb_ECom.TabIndex = 12;
            this.lb_ECom.Text = null;
            this.lb_ECom.SelectedIndexChanged += new System.EventHandler(this.lb_ECom_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gb_ECom
            // 
            this.gb_ECom.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gb_ECom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_ECom.Location = new System.Drawing.Point(208, 25);
            this.gb_ECom.Margin = new System.Windows.Forms.Padding(0);
            this.gb_ECom.MinimumSize = new System.Drawing.Size(1, 1);
            this.gb_ECom.Name = "gb_ECom";
            this.gb_ECom.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.gb_ECom.Size = new System.Drawing.Size(236, 285);
            this.gb_ECom.Style = Rex.UI.UIStyle.Custom;
            this.gb_ECom.TabIndex = 13;
            this.gb_ECom.TabStop = false;
            this.gb_ECom.Text = "属性";
            // 
            // btn_RemovECom
            // 
            this.btn_RemovECom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemovECom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RemovECom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_RemovECom.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_RemovECom.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_RemovECom.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btn_RemovECom.Location = new System.Drawing.Point(10, 58);
            this.btn_RemovECom.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_RemovECom.Name = "btn_RemovECom";
            this.btn_RemovECom.Size = new System.Drawing.Size(184, 26);
            this.btn_RemovECom.Style = Rex.UI.UIStyle.Custom;
            this.btn_RemovECom.TabIndex = 14;
            this.btn_RemovECom.Text = "删除选择";
            this.btn_RemovECom.Click += new System.EventHandler(this.bt_RemovECom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_EComType);
            this.groupBox3.Controls.Add(this.btn_RemovECom);
            this.groupBox3.Controls.Add(this.lb_ECom);
            this.groupBox3.Controls.Add(this.btn_AddECom);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(4, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.groupBox3.Size = new System.Drawing.Size(200, 285);
            this.groupBox3.Style = Rex.UI.UIStyle.Custom;
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
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel1.Location = new System.Drawing.Point(195, 108);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(44, 17);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "结束符";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uirb_EndChar
            // 
            this.uirb_EndChar.ColumnCount = 4;
            this.uirb_EndChar.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uirb_EndChar.Items.AddRange(new object[] {
            "\\r",
            "\\n",
            "\\r\\n",
            "无"});
            this.uirb_EndChar.ItemSize = new System.Drawing.Size(50, 20);
            this.uirb_EndChar.Location = new System.Drawing.Point(242, 108);
            this.uirb_EndChar.Margin = new System.Windows.Forms.Padding(0);
            this.uirb_EndChar.MinimumSize = new System.Drawing.Size(1, 1);
            this.uirb_EndChar.Name = "uirb_EndChar";
            this.uirb_EndChar.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.uirb_EndChar.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uirb_EndChar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uirb_EndChar.Size = new System.Drawing.Size(193, 17);
            this.uirb_EndChar.StartPos = new System.Drawing.Point(0, -17);
            this.uirb_EndChar.Style = Rex.UI.UIStyle.Custom;
            this.uirb_EndChar.TabIndex = 154;
            this.uirb_EndChar.Text = null;
            // 
            // NetSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(448, 528);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_ClearSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_ECom);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NetSet";
            this.Title = "通讯设置";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 9F);
            this.TitleSize = new System.Drawing.Size(56, 17);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gb_ECom, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.btn_ClearSend, 0);
            this.Controls.SetChildIndex(this.btn_Send, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Rex.UI.UIButton btn_Send;
        private Rex.UI.UIButton btn_ClearSend;
        private Rex.UI.UILabel label2;
        private Rex.UI.UITextBox tb_Read;
        private Rex.UI.UILabel label1;
        private Rex.UI.UITextBox tb_Send;
        private Rex.UI.UICheckBox checkBox2;
        private Rex.UI.UICheckBox checkBox1;
        private Rex.UI.UIComboBox cb_EComType;
        private Rex.UI.UIButton btn_AddECom;
        private Rex.UI.UIListBox lb_ECom;
        private System.Windows.Forms.Timer timer1;
        private Rex.UI.UIGroupBox gb_ECom;
        private Rex.UI.UIButton btn_RemovECom;
        private Rex.UI.UIGroupBox groupBox3;
        private DMSkin.Socket.DMTcpClient dmTcpClient1;
        private Rex.UI.UIGroupBox groupBox1;
        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UIRadioButtonGroup uirb_EndChar;
    }
}