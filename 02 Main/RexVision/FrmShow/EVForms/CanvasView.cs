using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyVision.EVControl.Canvas;
namespace EasyVision.EVControl.EVForms
{
    public enum ViewMode
    {
        One,
        Two,
        Three,
        Four,
        SixOne,
        SixTwo,
        Night
    }
    public partial class CanvasView : UserControl
    {
        private ViewMode m_ViewMode = ViewMode.One;
        private Dictionary<int, EWindowControl> m_ImageBoxDic = new Dictionary<int, EWindowControl>();
        private bool isShowAllCanvas = true;
        public ViewMode ViewMode
        {
            get { return m_ViewMode; }
            set
            {
                m_ViewMode = value;

                ShowAllCanvas();
            }
        }


        public CanvasView()
        {
            InitializeComponent();
            ViewMode = ViewMode.One;
        }

        public EWindowControl GetImageBox(int key)
        {
            if (m_ImageBoxDic.ContainsKey(key) == false)
            {
                EWindowControl imageBox = new EWindowControl();
                imageBox.RunKey = key;
                imageBox.DoubleClick += ImageBox_DoubleClick;
                m_ImageBoxDic.Add(key, imageBox);
            }
            return m_ImageBoxDic[key];
        }
        private void ShowAllCanvas()
        {
            isShowAllCanvas = true;
            hideAllTableLayoutPane();
            EWindowControl imageBox;
            int index = 0;
            switch (m_ViewMode)
            {
                case ViewMode.One:
                    imageBox = GetImageBox(1);
                    this.tableLayoutPanel1.Controls.Add(imageBox, 0, 0);
                    this.tableLayoutPanel1.SetRowSpan(imageBox, 1);
                    this.tableLayoutPanel1.SetColumnSpan(imageBox, 1);
                    this.tableLayoutPanel1.Visible = true;
                    imageBox.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Two:
                    for (int i = 1; i < 3; i++)
                    {
                        imageBox = GetImageBox(i);
                        this.tableLayoutPanel2.Controls.Add(imageBox, i - 1, 0);
                        this.tableLayoutPanel2.SetRowSpan(imageBox, 1);
                        this.tableLayoutPanel2.SetColumnSpan(imageBox, 1);
                        this.tableLayoutPanel2.Visible = true;
                        imageBox.Dock = DockStyle.Fill;
                        tableLayoutPanel2.Dock = DockStyle.Fill;
                    }
                    break;
                case ViewMode.Three:
                    for (int i = 1; i < 4; i++)
                    {
                        imageBox = GetImageBox(i);
                        if (i == 1)
                        {
                            this.tableLayoutPanel3.Controls.Add(imageBox, 0, 0);
                            this.tableLayoutPanel3.SetRowSpan(imageBox, 2);
                            this.tableLayoutPanel3.SetColumnSpan(imageBox, 1);
                        }
                        else
                        {
                            this.tableLayoutPanel3.Controls.Add(imageBox, 1, i - 2);
                            this.tableLayoutPanel3.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel3.SetColumnSpan(imageBox, 1);
                        }
                        this.tableLayoutPanel3.Visible = true;
                        imageBox.Dock = DockStyle.Fill;
                    }
                    tableLayoutPanel3.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Four:

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            index++;
                            imageBox = GetImageBox(index);
                            this.tableLayoutPanel4.Controls.Add(imageBox, j, i);

                            this.tableLayoutPanel4.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel4.SetColumnSpan(imageBox, 1);
                            imageBox.Dock = DockStyle.Fill;
                        }
                    }
                    this.tableLayoutPanel4.Visible = true;

                    tableLayoutPanel4.Dock = DockStyle.Fill;
                    break;
                case ViewMode.SixOne:

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            index++;
                            imageBox = GetImageBox(index);
                            this.tableLayoutPanel6_1.Controls.Add(imageBox, j, i);

                            this.tableLayoutPanel6_1.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel6_1.SetColumnSpan(imageBox, 1);
                            imageBox.Dock = DockStyle.Fill;
                        }
                    }
                    this.tableLayoutPanel6_1.Visible = true;

                    tableLayoutPanel6_1.Dock = DockStyle.Fill;

                    break;
                case ViewMode.SixTwo:
                    for (int i = 1; i < 7; i++)
                    {
                        imageBox = GetImageBox(i);
                        if (i == 1)
                        {
                            this.tableLayoutPanel6_2_9.Controls.Add(imageBox, 0, 0);

                            this.tableLayoutPanel6_2_9.SetRowSpan(imageBox, 2);
                            this.tableLayoutPanel6_2_9.SetColumnSpan(imageBox, 2);
                        }
                        else if (i == 2)
                        {
                            this.tableLayoutPanel6_2_9.Controls.Add(imageBox, 2, 0);

                            this.tableLayoutPanel6_2_9.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel6_2_9.SetColumnSpan(imageBox, 1);
                        }
                        else if (i == 3)
                        {
                            this.tableLayoutPanel6_2_9.Controls.Add(imageBox, 2, 1);

                            this.tableLayoutPanel6_2_9.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel6_2_9.SetColumnSpan(imageBox, 1);
                        }
                        else
                        {
                            this.tableLayoutPanel6_2_9.Controls.Add(imageBox, i - 4, 2);

                            this.tableLayoutPanel6_2_9.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel6_2_9.SetColumnSpan(imageBox, 1);
                        }
                        imageBox.Dock = DockStyle.Fill;
                    }
                    this.tableLayoutPanel6_2_9.Visible = true;

                    tableLayoutPanel6_2_9.Dock = DockStyle.Fill;
                    break;
                case ViewMode.Night:
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            index++;
                            imageBox = GetImageBox(index);
                            this.tableLayoutPanel6_2_9.Controls.Add(imageBox, j, i);

                            this.tableLayoutPanel6_2_9.SetRowSpan(imageBox, 1);
                            this.tableLayoutPanel6_2_9.SetColumnSpan(imageBox, 1);
                            imageBox.Dock = DockStyle.Fill;
                        }
                    }
                    this.tableLayoutPanel6_2_9.Visible = true;

                    tableLayoutPanel6_2_9.Dock = DockStyle.Fill;
                    break;
                default:
                    break;
            }
        }
        private void ShowCanvasFull(EWindowControl window)
        {
            isShowAllCanvas = false;
            hideAllTableLayoutPane();
            this.tableLayoutPanel1.Controls.Add(window, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(window, 1);
            this.tableLayoutPanel1.SetColumnSpan(window, 1);
            this.tableLayoutPanel1.Visible = true;
            window.Dock = DockStyle.Fill;
            tableLayoutPanel1.Dock = DockStyle.Fill;
        }
        private void ImageBox_DoubleClick(object sender, EventArgs e)
        {
            if (isShowAllCanvas)
            {
                ShowCanvasFull((EWindowControl)sender);
            }
            else
            {
                ShowAllCanvas();
            }

        }

        void hideAllTableLayoutPane()
        {
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel6_1.Visible = false;
            tableLayoutPanel6_2_9.Visible = false;
        }
    }
}
