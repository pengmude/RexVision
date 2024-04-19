using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace RexControl.Text
{
    /// <summary>
    /// Class TextBoxTransparent.
    /// Implements the <see cref="HZH_Controls.RexControl.TextBoxEx" />
    /// </summary>
    /// <seealso cref="HZH_Controls.RexControl.TextBoxEx" />
    public class TextBoxTransparent : TextBoxEx
    {
        #region private variables

        /// <summary>
        /// My PictureBox
        /// </summary>
        private uPictureBox myPictureBox;
        /// <summary>
        /// My up to date
        /// </summary>
        private bool myUpToDate = false;
        /// <summary>
        /// My caret up to date
        /// </summary>
        private bool myCaretUpToDate = false;
        /// <summary>
        /// My bitmap
        /// </summary>
        private Bitmap myBitmap;
        /// <summary>
        /// My alpha bitmap
        /// </summary>
        private Bitmap myAlphaBitmap;

        /// <summary>
        /// My font height
        /// </summary>
        private int myFontHeight = 10;

        /// <summary>
        /// My timer1
        /// </summary>
        private System.Windows.Forms.Timer myTimer1;

        /// <summary>
        /// My caret state
        /// </summary>
        private bool myCaretState = true;

        /// <summary>
        /// My painted first time
        /// </summary>
        private bool myPaintedFirstTime = false;

        /// <summary>
        /// My back color
        /// </summary>
        private Color myBackColor = Color.White;
        /// <summary>
        /// My back alpha
        /// </summary>
        private int myBackAlpha = 10;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion // end private variables


        #region public methods and overrides

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxTransparent" /> class.
        /// </summary>
        public TextBoxTransparent()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitializeComponent call

            this.BackColor = myBackColor;

            this.SetStyle(ControlStyles.UserPaint, false);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);


            myPictureBox = new uPictureBox();
            this.Controls.Add(myPictureBox);
            myPictureBox.Dock = DockStyle.Fill;
        }


        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.Resize" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.EventArgs" />。</param>
        protected override void OnResize(EventArgs e)
        {

            base.OnResize(e);
            this.myBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);//(this.Width,this.Height);
            this.myAlphaBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);//(this.Width,this.Height);
            myUpToDate = false;
            this.Invalidate();
        }


        //Some of these should be moved to the WndProc later

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.KeyDown" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.KeyEventArgs" />。</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            myUpToDate = false;
            this.Invalidate();
        }

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.KeyUp" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.KeyEventArgs" />。</param>
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            myUpToDate = false;
            this.Invalidate();

        }

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.KeyPress" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.KeyPressEventArgs" />。</param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            myUpToDate = false;
            this.Invalidate();
        }

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.MouseUp" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.MouseEventArgs" />。</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.Invalidate();
        }

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.GiveFeedback" /> 事件。
        /// </summary>
        /// <param name="gfbevent">包含事件数据的 <see cref="T:System.Windows.Forms.GiveFeedbackEventArgs" />。</param>
        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
            myUpToDate = false;
            this.Invalidate();
        }


        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.MouseLeave" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.EventArgs" />。</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            //found this code to find the current cursor location
            //at http://www.syncfusion.com/FAQ/WinForms/FAQ_c50c.asp#q597q

            Point ptCursor = Cursor.Position;

            Form f = this.FindForm();
            ptCursor = f.PointToClient(ptCursor);
            if (!this.Bounds.Contains(ptCursor))
                base.OnMouseLeave(e);
        }


        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.ChangeUICues" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.Windows.Forms.UICuesEventArgs" />。</param>
        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
            myUpToDate = false;
            this.Invalidate();
        }




        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.LostFocus" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.EventArgs" />。</param>
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            myCaretUpToDate = false;
            myUpToDate = false;
            this.Invalidate();

            myTimer1.Dispose();
        }

        //--		

        /// <summary>
        /// 引发 <see cref="E:System.Windows.Forms.Control.FontChanged" /> 事件。
        /// </summary>
        /// <param name="e">包含事件数据的 <see cref="T:System.EventArgs" />。</param>
        protected override void OnFontChanged(EventArgs e)
        {
            if (this.myPaintedFirstTime)
                this.SetStyle(ControlStyles.UserPaint, false);

            base.OnFontChanged(e);

            if (this.myPaintedFirstTime)
                this.SetStyle(ControlStyles.UserPaint, true);


            myFontHeight = GetFontHeight();


            myUpToDate = false;
            this.Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:TextChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            myUpToDate = false;
            this.Invalidate();
        }



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">为 true 则释放托管资源和非托管资源；为 false 则仅释放非托管资源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //this.BackColor = Color.Pink;
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion		//end public method and overrides


        #region public property overrides

        /// <summary>
        /// 获取或设置文本框控件的边框类型。
        /// </summary>
        /// <value>The border style.</value>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set
            {
                if (this.myPaintedFirstTime)
                    this.SetStyle(ControlStyles.UserPaint, false);

                base.BorderStyle = value;

                if (this.myPaintedFirstTime)
                    this.SetStyle(ControlStyles.UserPaint, true);

                this.myBitmap = null;
                this.myAlphaBitmap = null;
                myUpToDate = false;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 获取或设置控件的背景色。
        /// </summary>
        /// <value>The color of the back.</value>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public new Color BackColor
        {
            get
            {
                return Color.FromArgb(base.BackColor.R, base.BackColor.G, base.BackColor.B);
            }
            set
            {
                myBackColor = value;
                base.BackColor = value;
                myUpToDate = false;
            }
        }
        /// <summary>
        /// 获取或设置一个值，该值指示此控件是否为多行 <see cref="T:System.Windows.Forms.TextBox" /> 控件。
        /// </summary>
        /// <value><c>true</c> if multiline; otherwise, <c>false</c>.</value>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        ///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public override bool Multiline
        {
            get { return base.Multiline; }
            set
            {
                if (this.myPaintedFirstTime)
                    this.SetStyle(ControlStyles.UserPaint, false);

                base.Multiline = value;

                if (this.myPaintedFirstTime)
                    this.SetStyle(ControlStyles.UserPaint, true);

                this.myBitmap = null;
                this.myAlphaBitmap = null;
                myUpToDate = false;
                this.Invalidate();
            }
        }


        #endregion    //end public property overrides


        #region private functions and classes

        /// <summary>
        /// Gets the height of the font.
        /// </summary>
        /// <returns>System.Int32.</returns>
        private int GetFontHeight()
        {
            Graphics g = this.CreateGraphics();
            SizeF sf_font = g.MeasureString("X", this.Font);
            g.Dispose();
            return (int)sf_font.Height;
        }


        /// <summary>
        /// Gets the bitmaps.
        /// </summary>
        private void GetBitmaps()
        {

            if (myBitmap == null
                || myAlphaBitmap == null
                || myBitmap.Width != Width
                || myBitmap.Height != Height
                || myAlphaBitmap.Width != Width
                || myAlphaBitmap.Height != Height)
            {
                myBitmap = null;
                myAlphaBitmap = null;
            }



            if (myBitmap == null)
            {
                myBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);//(Width,Height);
                myUpToDate = false;
            }


 
            //--



            Rectangle r2 = new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
            ImageAttributes tempImageAttr = new ImageAttributes();


            //Found the color map code in the MS Help

            ColorMap[] tempColorMap = new ColorMap[1];
            tempColorMap[0] = new ColorMap();
            tempColorMap[0].OldColor = Color.FromArgb(255, myBackColor);
            tempColorMap[0].NewColor = Color.FromArgb(myBackAlpha, myBackColor);

            tempImageAttr.SetRemapTable(tempColorMap);

            if (myAlphaBitmap != null)
                myAlphaBitmap.Dispose();


            myAlphaBitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);//(Width,Height);

            Graphics tempGraphics1 = Graphics.FromImage(myAlphaBitmap);

            tempGraphics1.DrawImage(myBitmap, r2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, GraphicsUnit.Pixel, tempImageAttr);

            tempGraphics1.Dispose();

            //----

            if (this.Focused && (this.SelectionLength == 0))
            {
                Graphics tempGraphics2 = Graphics.FromImage(myAlphaBitmap);
                if (myCaretState)
                {
                    ////Draw the caret
                    //Point caret = this.findCaret();
                    //Pen p = new Pen(this.ForeColor, 3);
                    //tempGraphics2.DrawLine(p, caret.X + 2, caret.Y + 0, caret.X + 2, caret.Y + myFontHeight);
                    //tempGraphics2.Dispose();
                }

            }



        }






        /// <summary>
        /// Handles the Tick event of the myTimer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void myTimer1_Tick(object sender, EventArgs e)
        {
            //Timer used to turn caret on and off for focused control

            myCaretState = !myCaretState;
            myCaretUpToDate = false;
            this.Invalidate();
        }


        /// <summary>
        /// Class uPictureBox.
        /// Implements the <see cref="System.Windows.Forms.PictureBox" />
        /// </summary>
        /// <seealso cref="System.Windows.Forms.PictureBox" />
        private class uPictureBox : PictureBox
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="uPictureBox" /> class.
            /// </summary>
            public uPictureBox()
            {
                this.SetStyle(ControlStyles.Selectable, false);
                this.SetStyle(ControlStyles.UserPaint, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                this.SetStyle(ControlStyles.DoubleBuffer, true);

                this.Cursor = null;
                this.Enabled = true;
                this.SizeMode = PictureBoxSizeMode.Normal;

            }






        }   // End uPictureBox Class


        #endregion  // end private functions and classes


        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion


        #region New Public Properties

        /// <summary>
        /// Gets or sets the back alpha.
        /// </summary>
        /// <value>The back alpha.</value>
        [
        Category("Appearance"),
        Description("The alpha value used to blend the control's background. Valid values are 0 through 255."),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)

        ]
        public int BackAlpha
        {
            get { return myBackAlpha; }
            set
            {
                int v = value;
                if (v > 255)
                    v = 255;
                myBackAlpha = v;
                myUpToDate = false;
                Invalidate();
            }
        }

        #endregion



    }  // End AlphaTextBox Class 
}
