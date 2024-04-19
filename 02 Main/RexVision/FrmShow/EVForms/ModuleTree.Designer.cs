namespace EasyVision.EVControl.EVForms
{
    partial class ModuleTree
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleTree));
            gCursorLib.TextShadower textShadower2 = new gCursorLib.TextShadower();
            this.VscrollBar = new System.Windows.Forms.VScrollBar();
            this.gCursor1 = new gCursorLib.gCursor(this.components);
            this.SuspendLayout();
            // 
            // VscrollBar
            // 
            this.VscrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VscrollBar.Location = new System.Drawing.Point(161, 0);
            this.VscrollBar.Name = "VscrollBar";
            this.VscrollBar.Size = new System.Drawing.Size(21, 357);
            this.VscrollBar.TabIndex = 6;
            this.VscrollBar.ValueChanged += new System.EventHandler(this.VscrollBar_ValueChanged);
            // 
            // gCursor1
            // 
            this.gCursor1.gBlackBitBack = false;
            this.gCursor1.gBoxShadow = true;
            this.gCursor1.gCursorImage = ((System.Drawing.Bitmap)(resources.GetObject("gCursor1.gCursorImage")));
            this.gCursor1.gEffect = gCursorLib.gCursor.eEffect.No;
            this.gCursor1.gFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.gCursor1.gHotSpot = System.Drawing.ContentAlignment.MiddleCenter;
            this.gCursor1.gIBTransp = 80;
            this.gCursor1.gImage = null;
            this.gCursor1.gImageBorderColor = System.Drawing.Color.Black;
            this.gCursor1.gImageBox = new System.Drawing.Size(24, 24);
            this.gCursor1.gImageBoxColor = System.Drawing.Color.White;
            this.gCursor1.gITransp = 0;
            this.gCursor1.gScrolling = gCursorLib.gCursor.eScrolling.No;
            this.gCursor1.gShowImageBox = false;
            this.gCursor1.gShowTextBox = false;
            this.gCursor1.gTBTransp = 80;
            this.gCursor1.gText = "";
            this.gCursor1.gTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.gCursor1.gTextAutoFit = gCursorLib.gCursor.eTextAutoFit.All;
            this.gCursor1.gTextBorderColor = System.Drawing.Color.Red;
            this.gCursor1.gTextBox = new System.Drawing.Size(100, 30);
            this.gCursor1.gTextBoxColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextFade = gCursorLib.gCursor.eTextFade.Solid;
            this.gCursor1.gTextMultiline = false;
            this.gCursor1.gTextShadow = false;
            this.gCursor1.gTextShadowColor = System.Drawing.Color.Black;
            textShadower2.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            textShadower2.Blur = 2F;
            textShadower2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            textShadower2.Offset = ((System.Drawing.PointF)(resources.GetObject("textShadower2.Offset")));
            textShadower2.Padding = new System.Windows.Forms.Padding(0);
            textShadower2.ShadowColor = System.Drawing.Color.Black;
            textShadower2.ShadowTransp = 128;
            textShadower2.Text = "Drop Shadow";
            textShadower2.TextColor = System.Drawing.Color.Blue;
            this.gCursor1.gTextShadower = textShadower2;
            this.gCursor1.gTTransp = 0;
            this.gCursor1.gType = gCursorLib.gCursor.eType.Both;
            // 
            // ModuleTree
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.VscrollBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModuleTree";
            this.Size = new System.Drawing.Size(182, 357);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.ModuleTree_GiveFeedback);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModelBoxtUI_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ModelBoxtUI_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModelBoxtUI_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ModelBoxtUI_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar VscrollBar;
        public gCursorLib.gCursor gCursor1;
    }
}
