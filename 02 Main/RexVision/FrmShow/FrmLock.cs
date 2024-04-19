using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace RexVision
{
    public partial class FrmLock : Form
    {
        Point PanrtFormWH = new Point();
        Point PanrtFormXY = new Point();
        public FrmLock()
        {
            InitializeComponent();
        }
        public FrmLock(Point xy, int w, int h)
        {
            PanrtFormXY = xy;
            PanrtFormWH = new Point(w, h);
            InitializeComponent();
        }
        #region 窗体拖动
        private static bool IsDrag = false;
        private int enterX, enterY;
        private void FrmLock_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                IsDrag = true;
                enterX = e.Location.X;
                enterY = e.Location.Y;
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void FrmLock_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                IsDrag = false;
                enterX = 0;
                enterY = 0;
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void FrmLock_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsDrag)
                {
                    Left += e.Location.X - enterX;
                    Top += e.Location.Y - enterY;
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        #endregion
        /// <summary>
        /// X向自动增加
        /// </summary>
        private bool Xadd = true;
        /// <summary>
        /// Y向自动增加
        /// </summary>
        private bool Yadd = true;
        /// <summary>
        /// 窗体是否移动
        /// </summary>
        private bool isMove = true;
        /// <summary>
        /// 一段时间不操作则自动恢复飘动
        /// </summary>
        private int waitTime = 0;
        /// <summary>
        /// 是否停止刷新
        /// </summary>
        private bool stopUpdata = false;
        private void FrmLock_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMove)
                {
                    isMove = false;
                    this.Opacity = 1;
                    this.tbx_password.Focus();
                }
                else
                {
                    isMove = true;
                    this.Opacity = 0.4;
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void FrmLock_Load(object sender, EventArgs e)
        {
            try
            {
                tbx_password.Select();
                this.TopMost = true;
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void UpdataStatu(object o)
        {
            try
            {
                while (!stopUpdata)
                {
                    BeginInvoke(new Action(() =>
                    {
                        tbx_password.Focus();
                    }));
                    Application.DoEvents();
                        if (!isMove)
                        {
                            waitTime++;
                            if (waitTime > 5000000)
                            {
                                isMove = true;
                                waitTime = 0;
                            }
                            continue;
                        }
                    BeginInvoke(new Action(() =>
                    {
                        if (Xadd)
                            this.Location = new Point(this.Location.X + 1, this.Location.Y);
                        if (Yadd)
                            this.Location = new Point(this.Location.X, this.Location.Y + 1);
                        if (!Xadd)
                            this.Location = new Point(this.Location.X - 1, this.Location.Y);
                        if (!Yadd)
                            this.Location = new Point(this.Location.X, this.Location.Y - 1);

                        if (this.Location.X >= PanrtFormXY.X + PanrtFormWH.X - this.Width - 10)
                            Xadd = false;
                        if (this.Location.Y >= PanrtFormXY.Y + PanrtFormWH.Y - this.Height - 10)
                            Yadd = false;
                        if (this.Location.X <= PanrtFormXY.X + 10)
                            Xadd = true;
                        if (this.Location.Y <= PanrtFormXY.Y)
                            Yadd = true;

                        Application.DoEvents();
                        Thread.Sleep(15);
                    }));
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (isMove)
                {
                    isMove = false;
                    this.Opacity = 1;
                    this.tbx_password.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void btn_unlock_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_password.Text.Trim() == "123")
                {
                    // frm_MVision.locked = false;
                    // frm_MainVision.Instance.toolStripBtnLock.Image = Resources.锁定;
                    this.Close();
                }
                else
                {
                    tbx_password.Clear();
                    label1.Text = "密码错误！";
                    label1.ForeColor = Color.Red;
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    label1.Text = "锁定中......";
                    label1.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void tbx_password_Click(object sender, EventArgs e)
        {
            try
            {
                if (isMove)
                {
                    isMove = false;
                    this.Opacity = 1;
                    this.tbx_password.Focus();
                }
            }
            catch (Exception ex)
            {
                Log.Error("FrmLock:" + ex.Message);
            }
        }
        private void FrmLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopUpdata = true;
        }
        private void FrmLock_Shown(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(UpdataStatu);
        }

    }
}

