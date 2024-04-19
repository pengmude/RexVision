using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HalconDotNet;
using RexConst;
using RexView;
using RexVision.Properties;

namespace RexForm
{
    /// <summary>显示字典</summary>
    public class ViewDic
    {
        public static Dictionary<int, HWindow_HE> mViewDic = new Dictionary<int, HWindow_HE>();
        public static HWindow_HE GetView(int key)
        {
            return mViewDic[key];
        }
    }
    public enum ViewMode
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Night
    }
    /// <summary>自定义画布</summary>
    public partial class CanvasView : UserControl
    {
        /// <summary>全部显示</summary>
        private bool mShowAll = true;
        /// <summary>画布样式</summary>
        private ViewMode mViewMode = ViewMode.One;
        public CanvasView()
        {
            InitializeComponent();
            ViewMode = ViewMode.One;
            for (int i = 1; i < 9; i++)
            {
                GetImageBox(i);
            }
        }
        public ViewMode ViewMode
        {
            get { return mViewMode; }
            set
            {
                mViewMode = value;

                ShowCanvasAll();
            }
        }
        public void Show(RImage rImage)
        {
            if (rImage.Screen > 0 && rImage.Screen < 10)
            {
                ViewDic.mViewDic[rImage.Screen].ShowHImage(rImage);
            }
        }
        public HWindow_HE GetImageBox(int key)
        {
            if (!ViewDic.mViewDic.ContainsKey(key))
            {
                HWindow_HE mWindowH = new HWindow_HE();
                mWindowH.Dock = DockStyle.Fill;
                mWindowH.Margin = new Padding(0, 0, 0, 0);
                mWindowH.DoubleClick += ImageDoubleClick;
                //mWindowH.BackgroundImage = ((System.Drawing.Image)(Resources.));
                mWindowH.BackgroundImageLayout =ImageLayout.Center;
                ViewDic.mViewDic.Add(key, mWindowH);
            }
            return ViewDic.mViewDic[key];
        }
        private void ShowCanvasAll()
        {
            mShowAll = true;
            HideAlltbPane();
            HWindow_HE mWindowH;
            int index = 0;
            switch (mViewMode)
            {
                case ViewMode.One:
                    mWindowH = GetImageBox(1);
                    tbPanel1.Controls.Add(mWindowH, 0, 0);
                    tbPanel1.SetRowSpan(mWindowH, 1);
                    tbPanel1.SetColumnSpan(mWindowH, 1);
                    tbPanel1.Visible = true;
                    tbPanel1.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Two:
                    for (int i = 1; i < 3; i++)
                    {
                        mWindowH = GetImageBox(i);
                        tbPanel2.Controls.Add(mWindowH, i - 1, 0);
                        tbPanel2.SetRowSpan(mWindowH, 1);
                        tbPanel2.SetColumnSpan(mWindowH, 1);
                        tbPanel2.Visible = true;
                        tbPanel2.Dock = DockStyle.Fill;
                    }
                    break;
                case ViewMode.Three:
                    for (int i = 1; i < 4; i++)
                    {
                        mWindowH = GetImageBox(i);
                        if (i == 1)
                        {
                            tbPanel3.Controls.Add(mWindowH, 0, 0);
                            tbPanel3.SetRowSpan(mWindowH, 2);
                            tbPanel3.SetColumnSpan(mWindowH, 1);
                        }
                        else
                        {
                            tbPanel3.Controls.Add(mWindowH, 1, i - 2);
                            tbPanel3.SetRowSpan(mWindowH, 1);
                            tbPanel3.SetColumnSpan(mWindowH, 1);
                        }
                        tbPanel3.Visible = true;
                    }
                    tbPanel3.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Four:

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            index++;
                            mWindowH = GetImageBox(index);
                            tbPanel4.Controls.Add(mWindowH, j, i);

                            tbPanel4.SetRowSpan(mWindowH, 1);
                            tbPanel4.SetColumnSpan(mWindowH, 1);
                            mWindowH.Dock = DockStyle.Fill;
                        }
                    }
                    tbPanel4.Visible = true;
                    tbPanel4.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Five:
                    for (int i = 1; i < 6; i++)
                    {
                        mWindowH = GetImageBox(i);

                        if (i == 1)
                        {
                            tbPanel6.Controls.Add(mWindowH, 0,0);
                            tbPanel6.SetRowSpan(mWindowH, 1);
                            tbPanel6.SetColumnSpan(mWindowH, 2);
                        }
                        else if (i == 2)
                        {
                            tbPanel6.Controls.Add(mWindowH, 1, 0);
                            tbPanel6.SetRowSpan(mWindowH, 1);
                            tbPanel6.SetColumnSpan(mWindowH, 1);
                        }
                        else
                        {
                            tbPanel6.Controls.Add(mWindowH, i-3, 1);
                            tbPanel6.SetRowSpan(mWindowH, 1);
                            tbPanel6.SetColumnSpan(mWindowH, 1);
                        }


                    }
                    tbPanel6.Visible = true;
                    tbPanel6.Dock = DockStyle.Fill;

                    break;
                case ViewMode.Six:
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            index++;
                            mWindowH = GetImageBox(index);
                            tbPanel6.Controls.Add(mWindowH, j, i);
                            tbPanel6.SetRowSpan(mWindowH, 1);
                            tbPanel6.SetColumnSpan(mWindowH, 1);
                            mWindowH.Dock = DockStyle.Fill;
                        }
                    }
                    tbPanel6.Visible = true;
                    tbPanel6.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Seven:

                    for (int i = 1; i < 8; i++)
                    {
                        mWindowH = GetImageBox(i);

                        if (i == 1)
                        {
                            tbPanel8.Controls.Add(mWindowH, 0, 0);
                            tbPanel8.SetRowSpan(mWindowH, 1);
                            tbPanel8.SetColumnSpan(mWindowH, 2);
                        }
                        else if (i == 2)
                        {
                            tbPanel8.Controls.Add(mWindowH, 1, 0);
                            tbPanel8.SetRowSpan(mWindowH, 1);
                            tbPanel8.SetColumnSpan(mWindowH, 1);
                        }
                        else if (i == 3)
                        {
                            tbPanel8.Controls.Add(mWindowH, 2, 0);
                            tbPanel8.SetRowSpan(mWindowH, 1);
                            tbPanel8.SetColumnSpan(mWindowH, 1);
                        }
                        else
                        {
                            tbPanel8.Controls.Add(mWindowH, i - 4, 1);
                            tbPanel8.SetRowSpan(mWindowH, 1);
                            tbPanel8.SetColumnSpan(mWindowH, 1);
                        }


                    }
                    tbPanel8.Visible = true;
                    tbPanel8.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Eight:
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            index++;
                            mWindowH = GetImageBox(index);
                            tbPanel8.Controls.Add(mWindowH, j, i);
                            tbPanel8.SetRowSpan(mWindowH, 1);
                            tbPanel8.SetColumnSpan(mWindowH, 1);
                        }
                    }
                    tbPanel8.Visible = true;
                    tbPanel8.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Night:
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            index++;
                            mWindowH = GetImageBox(index);
                            tbPanel9.Controls.Add(mWindowH, j, i);
                            tbPanel9.SetRowSpan(mWindowH, 1);
                            tbPanel9.SetColumnSpan(mWindowH, 1);
                        }
                    }
                    tbPanel9.Visible = true;
                    tbPanel9.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }
        private void ShowCanvasFull(HWindow_HE window)
        {
            mShowAll = false;
            HideAlltbPane();
            tbPanel1.Controls.Add(window, 0, 0);
            tbPanel1.SetRowSpan(window, 1);
            tbPanel1.SetColumnSpan(window, 1);
            tbPanel1.Visible = true;
            window.Dock = DockStyle.Fill;
            tbPanel1.Dock = DockStyle.Fill;
        }
        private void ImageDoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (mShowAll)
                {
                    ShowCanvasFull((HWindow_HE)sender);
                }
                else
                {
                    ShowCanvasAll();
                }
            }
            catch { }
        }
        private void HideAlltbPane()
        {
            tbPanel1.Visible = false;
            tbPanel2.Visible = false;
            tbPanel3.Visible = false;
            tbPanel4.Visible = false;
            tbPanel6.Visible = false;
            tbPanel8.Visible = false;
            tbPanel9.Visible = false;
        }
    }
}
