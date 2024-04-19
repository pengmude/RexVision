using System.Windows.Forms;

namespace RexVision
{
    partial class CameraSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraSet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new Rex.CTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel2 = new Rex.UI.UITitlePanel();
            this.uicb_TrigMode = new Rex.UI.UIComboBox();
            this.uitb_SerialNo = new RexControl.CTextBox();
            this.uitb_CameraNote = new RexControl.CTextBox();
            this.uitb_Camera = new RexControl.CTextBox();
            this.uidu_Gain = new RexControl.CNumericUpDown();
            this.uidu_Timer = new RexControl.CNumericUpDown();
            this.uidu_Height = new RexControl.CNumericUpDown();
            this.uidu_Width = new RexControl.CNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_CameraList = new Rex.UI.UIDataGridView();
            this.m_DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_CameraIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_bConnected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Connect = new Rex.UI.UIButton();
            this.bt_Disconnect = new Rex.UI.UIButton();
            this.bt_Save = new Rex.UI.UIButton();
            this.bt_Series = new Rex.UI.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uiTitlePanel1 = new Rex.UI.UITitlePanel();
            this.bt_Remov = new Rex.UI.UIButton();
            this.cb_DeviceName = new Rex.UI.UIComboBox();
            this.cb_DeviceType = new Rex.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_AddList = new Rex.UI.UIButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTitlePanel3 = new Rex.UI.UITitlePanel();
            this.uiLabel1 = new Rex.UI.UILabel();
            this.dgv_SDK = new Rex.UI.UIDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mWindow = new RexView.HWindow_Fit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).BeginInit();
            this.titlepanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CameraList)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTitlePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SDK)).BeginInit();
            this.tbPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_Icon
            // 
            this.pbox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbox_Icon.Image")));
            this.pbox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // titlepanel
            // 
            this.titlepanel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.titlepanel.Size = new System.Drawing.Size(828, 32);
            // 
            // titlelabel
            // 
            this.titlelabel.Size = new System.Drawing.Size(74, 21);
            this.titlelabel.Text = "相机设置";
            // 
            // tabControl1
            // 
            this.tabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(79)))), ((int)(((byte)(125)))));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.tabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.tabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.uiTitlePanel2);
            this.tabPage1.Controls.Add(this.uiTitlePanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(354, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设备信息";
            // 
            // uiTitlePanel2
            // 
            this.uiTitlePanel2.Controls.Add(this.uicb_TrigMode);
            this.uiTitlePanel2.Controls.Add(this.uitb_SerialNo);
            this.uiTitlePanel2.Controls.Add(this.uitb_CameraNote);
            this.uiTitlePanel2.Controls.Add(this.uitb_Camera);
            this.uiTitlePanel2.Controls.Add(this.uidu_Gain);
            this.uiTitlePanel2.Controls.Add(this.uidu_Timer);
            this.uiTitlePanel2.Controls.Add(this.uidu_Height);
            this.uiTitlePanel2.Controls.Add(this.uidu_Width);
            this.uiTitlePanel2.Controls.Add(this.label4);
            this.uiTitlePanel2.Controls.Add(this.label2);
            this.uiTitlePanel2.Controls.Add(this.label3);
            this.uiTitlePanel2.Controls.Add(this.dgv_CameraList);
            this.uiTitlePanel2.Controls.Add(this.bt_Connect);
            this.uiTitlePanel2.Controls.Add(this.bt_Disconnect);
            this.uiTitlePanel2.Controls.Add(this.bt_Save);
            this.uiTitlePanel2.Controls.Add(this.bt_Series);
            this.uiTitlePanel2.Controls.Add(this.label8);
            this.uiTitlePanel2.Controls.Add(this.label9);
            this.uiTitlePanel2.Controls.Add(this.label11);
            this.uiTitlePanel2.Controls.Add(this.label5);
            this.uiTitlePanel2.Controls.Add(this.label6);
            this.uiTitlePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiTitlePanel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel2.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel2.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uiTitlePanel2.Location = new System.Drawing.Point(0, 84);
            this.uiTitlePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel2.Name = "uiTitlePanel2";
            this.uiTitlePanel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel2.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel2.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiTitlePanel2.Size = new System.Drawing.Size(354, 302);
            this.uiTitlePanel2.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel2.TabIndex = 37;
            this.uiTitlePanel2.Text = "设备列表";
            this.uiTitlePanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // uicb_TrigMode
            // 
            this.uicb_TrigMode.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uicb_TrigMode.Items.AddRange(new object[] {
            "内触发",
            "软触发",
            "上升沿",
            "下降沿"});
            this.uicb_TrigMode.Location = new System.Drawing.Point(234, 224);
            this.uicb_TrigMode.Margin = new System.Windows.Forms.Padding(0);
            this.uicb_TrigMode.MinimumSize = new System.Drawing.Size(63, 0);
            this.uicb_TrigMode.Name = "uicb_TrigMode";
            this.uicb_TrigMode.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.uicb_TrigMode.Radius = 2;
            this.uicb_TrigMode.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uicb_TrigMode.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uicb_TrigMode.Size = new System.Drawing.Size(116, 23);
            this.uicb_TrigMode.StyleCustomMode = true;
            this.uicb_TrigMode.TabIndex = 55;
            this.uicb_TrigMode.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uicb_TrigMode.SelectedIndexChanged += new System.EventHandler(this.uicb_TrigMode_SelectedIndexChanged);
            // 
            // uitb_SerialNo
            // 
            this.uitb_SerialNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_SerialNo.DefaultText = "";
            this.uitb_SerialNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_SerialNo.Location = new System.Drawing.Point(234, 198);
            this.uitb_SerialNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_SerialNo.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_SerialNo.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_SerialNo.Name = "uitb_SerialNo";
            this.uitb_SerialNo.PasswordChar = false;
            this.uitb_SerialNo.Size = new System.Drawing.Size(116, 22);
            this.uitb_SerialNo.TabIndex = 53;
            this.uitb_SerialNo.TextStr = "";
            // 
            // uitb_CameraNote
            // 
            this.uitb_CameraNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_CameraNote.DefaultText = "暂无备注";
            this.uitb_CameraNote.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_CameraNote.Location = new System.Drawing.Point(234, 174);
            this.uitb_CameraNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_CameraNote.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_CameraNote.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_CameraNote.Name = "uitb_CameraNote";
            this.uitb_CameraNote.PasswordChar = false;
            this.uitb_CameraNote.Size = new System.Drawing.Size(116, 22);
            this.uitb_CameraNote.TabIndex = 52;
            this.uitb_CameraNote.TextStr = "";
            this.uitb_CameraNote.TextStrChanged += new RexControl.DTextStrChanged(this.uitb_CameraNote_TextStrChanged);
            // 
            // uitb_Camera
            // 
            this.uitb_Camera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uitb_Camera.DefaultText = "";
            this.uitb_Camera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uitb_Camera.Location = new System.Drawing.Point(64, 174);
            this.uitb_Camera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uitb_Camera.MaximumSize = new System.Drawing.Size(400, 22);
            this.uitb_Camera.MinimumSize = new System.Drawing.Size(20, 22);
            this.uitb_Camera.Name = "uitb_Camera";
            this.uitb_Camera.PasswordChar = false;
            this.uitb_Camera.Size = new System.Drawing.Size(116, 22);
            this.uitb_Camera.TabIndex = 51;
            this.uitb_Camera.TextStr = "";
            // 
            // uidu_Gain
            // 
            this.uidu_Gain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uidu_Gain.DecimalPlaces = 0;
            this.uidu_Gain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidu_Gain.Incremeent = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uidu_Gain.Location = new System.Drawing.Point(64, 274);
            this.uidu_Gain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uidu_Gain.MaximumSize = new System.Drawing.Size(300, 26);
            this.uidu_Gain.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.uidu_Gain.MinimumSize = new System.Drawing.Size(50, 26);
            this.uidu_Gain.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uidu_Gain.Name = "uidu_Gain";
            this.uidu_Gain.Size = new System.Drawing.Size(116, 26);
            this.uidu_Gain.TabIndex = 50;
            this.uidu_Gain.Tag = "增益";
            this.uidu_Gain.Value = 1D;
            this.uidu_Gain.ValueChanged += new RexControl.DValueChanged(this.uidu_Gain_ValueChanged);
            // 
            // uidu_Timer
            // 
            this.uidu_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uidu_Timer.DecimalPlaces = 0;
            this.uidu_Timer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidu_Timer.Incremeent = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.uidu_Timer.Location = new System.Drawing.Point(64, 248);
            this.uidu_Timer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uidu_Timer.MaximumSize = new System.Drawing.Size(300, 26);
            this.uidu_Timer.MaxValue = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.uidu_Timer.MinimumSize = new System.Drawing.Size(50, 26);
            this.uidu_Timer.MinValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uidu_Timer.Name = "uidu_Timer";
            this.uidu_Timer.Size = new System.Drawing.Size(116, 26);
            this.uidu_Timer.TabIndex = 49;
            this.uidu_Timer.Tag = "曝光";
            this.uidu_Timer.Value = 1000D;
            this.uidu_Timer.ValueChanged += new RexControl.DValueChanged(this.uidu_Timer_ValueChanged);
            // 
            // uidu_Height
            // 
            this.uidu_Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uidu_Height.DecimalPlaces = 0;
            this.uidu_Height.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidu_Height.Incremeent = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uidu_Height.Location = new System.Drawing.Point(64, 222);
            this.uidu_Height.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uidu_Height.MaximumSize = new System.Drawing.Size(300, 26);
            this.uidu_Height.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uidu_Height.MinimumSize = new System.Drawing.Size(50, 26);
            this.uidu_Height.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.uidu_Height.Name = "uidu_Height";
            this.uidu_Height.Size = new System.Drawing.Size(116, 26);
            this.uidu_Height.TabIndex = 48;
            this.uidu_Height.Tag = "高度";
            this.uidu_Height.Value = 100D;
            this.uidu_Height.ValueChanged += new RexControl.DValueChanged(this.uidu_Height_ValueChanged);
            // 
            // uidu_Width
            // 
            this.uidu_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uidu_Width.DecimalPlaces = 0;
            this.uidu_Width.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidu_Width.Incremeent = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uidu_Width.Location = new System.Drawing.Point(64, 196);
            this.uidu_Width.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uidu_Width.MaximumSize = new System.Drawing.Size(300, 26);
            this.uidu_Width.MaxValue = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uidu_Width.MinimumSize = new System.Drawing.Size(50, 26);
            this.uidu_Width.MinValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.uidu_Width.Name = "uidu_Width";
            this.uidu_Width.Size = new System.Drawing.Size(116, 26);
            this.uidu_Width.TabIndex = 47;
            this.uidu_Width.Tag = "宽度";
            this.uidu_Width.Value = 100D;
            this.uidu_Width.ValueChanged += new RexControl.DValueChanged(this.uidu_Width_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(196, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(26, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "宽度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(26, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "高度：";
            // 
            // dgv_CameraList
            // 
            this.dgv_CameraList.AllowUserToAddRows = false;
            this.dgv_CameraList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_CameraList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CameraList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CameraList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_CameraList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CameraList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CameraList.ColumnHeadersHeight = 25;
            this.dgv_CameraList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_DeviceID,
            this.m_SerialNo,
            this.m_CameraIP,
            this.m_Remark,
            this.m_bConnected});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CameraList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_CameraList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_CameraList.EnableHeadersVisualStyles = false;
            this.dgv_CameraList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_CameraList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_CameraList.Location = new System.Drawing.Point(0, 25);
            this.dgv_CameraList.MultiSelect = false;
            this.dgv_CameraList.Name = "dgv_CameraList";
            this.dgv_CameraList.ReadOnly = true;
            this.dgv_CameraList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CameraList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_CameraList.RowHeadersVisible = false;
            this.dgv_CameraList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_CameraList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_CameraList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_CameraList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_CameraList.RowTemplate.Height = 29;
            this.dgv_CameraList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CameraList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_CameraList.SelectedIndex = -1;
            this.dgv_CameraList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CameraList.ShowGridLine = true;
            this.dgv_CameraList.Size = new System.Drawing.Size(354, 142);
            this.dgv_CameraList.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_CameraList.Style = Rex.UI.UIStyle.Custom;
            this.dgv_CameraList.StyleCustomMode = true;
            this.dgv_CameraList.TabIndex = 30;
            this.dgv_CameraList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CameraList_CellClick);
            // 
            // m_DeviceID
            // 
            this.m_DeviceID.DataPropertyName = "mCameraNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.m_DeviceID.DefaultCellStyle = dataGridViewCellStyle3;
            this.m_DeviceID.FillWeight = 35.65465F;
            this.m_DeviceID.HeaderText = "名称";
            this.m_DeviceID.Name = "m_DeviceID";
            this.m_DeviceID.ReadOnly = true;
            // 
            // m_SerialNo
            // 
            this.m_SerialNo.DataPropertyName = "mSerialNo";
            this.m_SerialNo.FillWeight = 32.20251F;
            this.m_SerialNo.HeaderText = "编号";
            this.m_SerialNo.Name = "m_SerialNo";
            this.m_SerialNo.ReadOnly = true;
            // 
            // m_CameraIP
            // 
            this.m_CameraIP.DataPropertyName = "mCameraIP";
            this.m_CameraIP.FillWeight = 55.74195F;
            this.m_CameraIP.HeaderText = "地址";
            this.m_CameraIP.Name = "m_CameraIP";
            this.m_CameraIP.ReadOnly = true;
            // 
            // m_Remark
            // 
            this.m_Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_Remark.DataPropertyName = "mRemark";
            this.m_Remark.FillWeight = 60.59137F;
            this.m_Remark.HeaderText = "备注";
            this.m_Remark.Name = "m_Remark";
            this.m_Remark.ReadOnly = true;
            // 
            // m_bConnected
            // 
            this.m_bConnected.DataPropertyName = "mConnected";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.m_bConnected.DefaultCellStyle = dataGridViewCellStyle4;
            this.m_bConnected.FillWeight = 30F;
            this.m_bConnected.HeaderText = "状态";
            this.m_bConnected.Name = "m_bConnected";
            this.m_bConnected.ReadOnly = true;
            // 
            // bt_Connect
            // 
            this.bt_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Connect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Connect.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Connect.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Connect.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Connect.Location = new System.Drawing.Point(199, 253);
            this.bt_Connect.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(72, 21);
            this.bt_Connect.Style = Rex.UI.UIStyle.Custom;
            this.bt_Connect.TabIndex = 9;
            this.bt_Connect.Text = "连接";
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Disconnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Disconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Disconnect.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Disconnect.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Disconnect.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Disconnect.Location = new System.Drawing.Point(199, 277);
            this.bt_Disconnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(72, 21);
            this.bt_Disconnect.Style = Rex.UI.UIStyle.Custom;
            this.bt_Disconnect.TabIndex = 10;
            this.bt_Disconnect.Text = "断开";
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Save.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Save.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Save.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Save.Location = new System.Drawing.Point(278, 277);
            this.bt_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(72, 21);
            this.bt_Save.Style = Rex.UI.UIStyle.Custom;
            this.bt_Save.TabIndex = 11;
            this.bt_Save.Text = "确定";
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Series
            // 
            this.bt_Series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Series.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Series.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Series.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Series.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Series.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Series.Location = new System.Drawing.Point(278, 253);
            this.bt_Series.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Series.Name = "bt_Series";
            this.bt_Series.Size = new System.Drawing.Size(72, 21);
            this.bt_Series.Style = Rex.UI.UIStyle.Custom;
            this.bt_Series.TabIndex = 13;
            this.bt_Series.Text = "触发";
            this.bt_Series.Click += new System.EventHandler(this.bt_Series_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(196, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "模式：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(2, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "当前相机：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(196, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(26, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "曝光：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(26, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "增益：";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.bt_Remov);
            this.uiTitlePanel1.Controls.Add(this.cb_DeviceName);
            this.uiTitlePanel1.Controls.Add(this.cb_DeviceType);
            this.uiTitlePanel1.Controls.Add(this.label1);
            this.uiTitlePanel1.Controls.Add(this.bt_AddList);
            this.uiTitlePanel1.Controls.Add(this.label7);
            this.uiTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 9F);
            this.uiTitlePanel1.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.uiTitlePanel1.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel1.Size = new System.Drawing.Size(354, 85);
            this.uiTitlePanel1.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel1.TabIndex = 36;
            this.uiTitlePanel1.Text = "设备选择";
            this.uiTitlePanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Remov
            // 
            this.bt_Remov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Remov.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Remov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Remov.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Remov.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Remov.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_Remov.Location = new System.Drawing.Point(268, 30);
            this.bt_Remov.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_Remov.Name = "bt_Remov";
            this.bt_Remov.Size = new System.Drawing.Size(72, 21);
            this.bt_Remov.Style = Rex.UI.UIStyle.Custom;
            this.bt_Remov.TabIndex = 36;
            this.bt_Remov.Text = "删除";
            this.bt_Remov.Click += new System.EventHandler(this.bt_Remov_Click);
            // 
            // cb_DeviceName
            // 
            this.cb_DeviceName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cb_DeviceName.Location = new System.Drawing.Point(64, 55);
            this.cb_DeviceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_DeviceName.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_DeviceName.Name = "cb_DeviceName";
            this.cb_DeviceName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cb_DeviceName.Radius = 2;
            this.cb_DeviceName.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cb_DeviceName.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cb_DeviceName.Size = new System.Drawing.Size(195, 23);
            this.cb_DeviceName.StyleCustomMode = true;
            this.cb_DeviceName.TabIndex = 34;
            this.cb_DeviceName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_DeviceName.Watermark = "设备选择";
            // 
            // cb_DeviceType
            // 
            this.cb_DeviceType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cb_DeviceType.Location = new System.Drawing.Point(64, 30);
            this.cb_DeviceType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_DeviceType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cb_DeviceType.Name = "cb_DeviceType";
            this.cb_DeviceType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.cb_DeviceType.Radius = 2;
            this.cb_DeviceType.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.cb_DeviceType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.cb_DeviceType.Size = new System.Drawing.Size(195, 23);
            this.cb_DeviceType.StyleCustomMode = true;
            this.cb_DeviceType.TabIndex = 33;
            this.cb_DeviceType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cb_DeviceType.Watermark = "型号选择";
            this.cb_DeviceType.SelectedIndexChanged += new System.EventHandler(this.cmb_DeviceType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "设备型号：";
            // 
            // bt_AddList
            // 
            this.bt_AddList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_AddList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_AddList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddList.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddList.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddList.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bt_AddList.Location = new System.Drawing.Point(268, 56);
            this.bt_AddList.MinimumSize = new System.Drawing.Size(1, 1);
            this.bt_AddList.Name = "bt_AddList";
            this.bt_AddList.Size = new System.Drawing.Size(72, 21);
            this.bt_AddList.Style = Rex.UI.UIStyle.Custom;
            this.bt_AddList.TabIndex = 7;
            this.bt_AddList.Text = "添加";
            this.bt_AddList.Click += new System.EventHandler(this.bt_Add2List_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(4, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "设备列表：";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.uiTitlePanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SDK版本";
            // 
            // uiTitlePanel3
            // 
            this.uiTitlePanel3.Controls.Add(this.uiLabel1);
            this.uiTitlePanel3.Controls.Add(this.dgv_SDK);
            this.uiTitlePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTitlePanel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel3.ForeColor = System.Drawing.Color.White;
            this.uiTitlePanel3.ForeDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.uiTitlePanel3.Location = new System.Drawing.Point(3, 3);
            this.uiTitlePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTitlePanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel3.Name = "uiTitlePanel3";
            this.uiTitlePanel3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.uiTitlePanel3.RadiusSides = Rex.UI.UICornerRadiusSides.None;
            this.uiTitlePanel3.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiTitlePanel3.Size = new System.Drawing.Size(348, 380);
            this.uiTitlePanel3.Style = Rex.UI.UIStyle.Custom;
            this.uiTitlePanel3.TabIndex = 38;
            this.uiTitlePanel3.Text = "SDK状态";
            this.uiTitlePanel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.uiTitlePanel3.TitleInterval = 5;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiLabel1.Location = new System.Drawing.Point(5, 31);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(251, 34);
            this.uiLabel1.Style = Rex.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 31;
            this.uiLabel1.Text = "相机SDK版本必须与列表中一致！             否则会出现插件加载异常或图像采集异常！";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_SDK
            // 
            this.dgv_SDK.AllowUserToAddRows = false;
            this.dgv_SDK.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SDK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_SDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SDK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SDK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_SDK.ColumnHeadersHeight = 25;
            this.dgv_SDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SDK.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SDK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_SDK.EnableHeadersVisualStyles = false;
            this.dgv_SDK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_SDK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_SDK.Location = new System.Drawing.Point(0, 71);
            this.dgv_SDK.MultiSelect = false;
            this.dgv_SDK.Name = "dgv_SDK";
            this.dgv_SDK.ReadOnly = true;
            this.dgv_SDK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SDK.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SDK.RowHeadersVisible = false;
            this.dgv_SDK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SDK.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_SDK.RowTemplate.Height = 29;
            this.dgv_SDK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_SDK.SelectedIndex = -1;
            this.dgv_SDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SDK.ShowGridLine = true;
            this.dgv_SDK.Size = new System.Drawing.Size(348, 309);
            this.dgv_SDK.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_SDK.Style = Rex.UI.UIStyle.Custom;
            this.dgv_SDK.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mCameraNo";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.FillWeight = 63.4492F;
            this.dataGridViewTextBoxColumn1.HeaderText = "型号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mSerialNo";
            this.dataGridViewTextBoxColumn2.FillWeight = 63.4492F;
            this.dataGridViewTextBoxColumn2.HeaderText = "版本";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mCameraIP";
            this.dataGridViewTextBoxColumn3.FillWeight = 30F;
            this.dataGridViewTextBoxColumn3.HeaderText = "状态";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbPanel1
            // 
            this.tbPanel1.ColumnCount = 2;
            this.tbPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tbPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanel1.Controls.Add(this.mWindow, 1, 0);
            this.tbPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tbPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPanel1.Location = new System.Drawing.Point(0, 32);
            this.tbPanel1.Name = "tbPanel1";
            this.tbPanel1.RowCount = 1;
            this.tbPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanel1.Size = new System.Drawing.Size(828, 416);
            this.tbPanel1.TabIndex = 2;
            // 
            // mWindow
            // 
            this.mWindow.BackColor = System.Drawing.Color.Transparent;
            this.mWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.mWindow.Image = null;
            this.mWindow.Location = new System.Drawing.Point(365, 3);
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(460, 410);
            this.mWindow.TabIndex = 1;
            // 
            // CameraSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 448);
            this.Controls.Add(this.tbPanel1);
            this.Name = "CameraSet";
            this.Title = "相机设置";
            this.TitleSize = new System.Drawing.Size(74, 21);
            this.Load += new System.EventHandler(this.CameraFormSet_Load);
            this.Controls.SetChildIndex(this.titlepanel, 0);
            this.Controls.SetChildIndex(this.tbPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Icon)).EndInit();
            this.titlepanel.ResumeLayout(false);
            this.titlepanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.uiTitlePanel2.ResumeLayout(false);
            this.uiTitlePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CameraList)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.uiTitlePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SDK)).EndInit();
            this.tbPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Rex.CTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Rex.UI.UIButton bt_AddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private Rex.UI.UIButton bt_Series;
        private Rex.UI.UIButton bt_Save;
        private Rex.UI.UIButton bt_Disconnect;
        private Rex.UI.UIButton bt_Connect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        public RexView.HWindow_Fit mWindow;
        private System.Windows.Forms.TableLayoutPanel tbPanel1;
        private Rex.UI.UIComboBox cb_DeviceType;
        private Rex.UI.UIComboBox cb_DeviceName;
        private System.Windows.Forms.Label label7;
        private Rex.UI.UITitlePanel uiTitlePanel2;
        private Rex.UI.UITitlePanel uiTitlePanel1;
        private Rex.UI.UIDataGridView dgv_CameraList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RexControl.CNumericUpDown uidu_Gain;
        private RexControl.CNumericUpDown uidu_Timer;
        private RexControl.CNumericUpDown uidu_Height;
        private RexControl.CNumericUpDown uidu_Width;
        private RexControl.CTextBox uitb_Camera;
        private RexControl.CTextBox uitb_SerialNo;
        private RexControl.CTextBox uitb_CameraNote;
        private Rex.UI.UIComboBox uicb_TrigMode;
        private DataGridViewTextBoxColumn m_DeviceID;
        private DataGridViewTextBoxColumn m_SerialNo;
        private DataGridViewTextBoxColumn m_CameraIP;
        private DataGridViewTextBoxColumn m_Remark;
        private DataGridViewTextBoxColumn m_bConnected;
        private Rex.UI.UITitlePanel uiTitlePanel3;
        private Rex.UI.UILabel uiLabel1;
        private Rex.UI.UIDataGridView dgv_SDK;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Rex.UI.UIButton bt_Remov;
        //private HalconControl.mWindow mWindow;
    }
}