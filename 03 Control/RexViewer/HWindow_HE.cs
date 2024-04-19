using System;
using System.ComponentModel;
using System.Windows.Forms;
using HalconDotNet;
using RexConst;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace RexView
{
    /// <summary>
    /// halcon鼠标缩放控件
    /// 
    /// 描述:
    ///      1, 必须首先通过this.HobjectToHimage(HObject hobject)传入图片,此图片称为"背景图"
    ///      2, 有了背景图,就可以通过本控件自定义的 this.DispObj(HObject hObj)显示HObject,类似原方法
    ///      3,默认显示红色,DispObj(HObject hObj,string color)可显示其他颜色
    /// </summary>
    public partial class HWindow_HE : UserControl
    {
        #region 私有变量定义.
        private HWindow /**/                 hv_window;                      //halcon窗体控件的句柄 this.mCtrl_HWindow.HalconWindow;
        private ContextMenuStrip /**/        hv_MenuStrip;                   //右键菜单控件
        // 窗体控件右键菜单内容
        ToolStripMenuItem fit_strip;//自适应
        ToolStripMenuItem saveImg_strip;//保存图像
        ToolStripMenuItem saveWindow_strip;//保存截图
        ToolStripMenuItem barVisible_strip;//显示状态
        ToolStripMenuItem blnCross_strip;//显示十字
        ToolStripMenuItem histogram_strip;
        private HImage  /**/                 hv_image;                      //缩放时操作的图片  此处千万不要使用hv_image = new HImage(),不然在生成控件dll的时候,会导致无法序列化,去你妈隔壁,还好老子有版本控制,不然都找不到这种恶心问题
        private int /**/                     hv_imageWidth, hv_imageHeight; //图片宽,高
        private string /**/                  str_imgSize;                   //图片尺寸大小 5120X3840
        private bool    /**/                 drawModel = false;             //绘制模式下,不允许缩放和鼠标右键菜单
        #endregion
        public ViewWindow WindowH;    /**/                    //ViewWindow
        public HWindowControl hControl;   /**/                        // 当前halcon窗口
        public double positionX, positionY;
 
        public static bool IsDesignMode()//是否处于设计模式判断
        {
            bool returnFlag = false;

#if DEBUG
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                returnFlag = true;
            }
            else if (Process.GetCurrentProcess().ProcessName == "devenv")
            {
                returnFlag = true;
            }
#endif

            return returnFlag;
        }
        /// <summary>
        /// 初始化控件
        /// </summary>
        public HWindow_HE()
        {
            InitializeComponent();
            //
            WindowH = new ViewWindow(mCtrl_HWindow);
            hControl = this.mCtrl_HWindow;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }
            hv_window = this.mCtrl_HWindow.HalconWindow;
            //设定鼠标按下时图标的形状
            //'arrow'  'default' 'crosshair' 'text I-beam' 'Slashed circle' 'Size All'
            //'Size NESW' 'Size S' 'Size NWSE' 'Size WE' 'Vertical Arrow' 'Hourglass'
            // hv_window.SetMshape("Hourglass");
            fit_strip = new ToolStripMenuItem("适应图像显示");
            fit_strip.Click += new EventHandler((s, e) => DispImageFit(mCtrl_HWindow));
            barVisible_strip = new ToolStripMenuItem("显示图像信息");
            barVisible_strip.CheckOnClick = true;
            barVisible_strip.CheckedChanged += new EventHandler(barVisible_strip_CheckedChanged);
            blnCross_strip = new ToolStripMenuItem("显示隐藏十字");
            blnCross_strip.CheckOnClick = true;
            blnCross_strip.CheckedChanged += new EventHandler(blnCross_strip_CheckedChanged);
            m_CtrlHStatusLabelCtrl.Visible = false;
            mCtrl_HWindow.Height = this.Height;
            saveImg_strip = new ToolStripMenuItem("保存原始图像");
            saveImg_strip.Click += new EventHandler((s, e) => SaveImage());
            saveWindow_strip = new ToolStripMenuItem("保存缩略图像");
            saveWindow_strip.Click += new EventHandler((s, e) => SaveWindowDump());
            histogram_strip = new ToolStripMenuItem("显示直方图(H)");
            histogram_strip.CheckOnClick = true;
            histogram_strip.Checked = false;
            hv_MenuStrip = new ContextMenuStrip();
            hv_MenuStrip.Items.Add(fit_strip);
            hv_MenuStrip.Items.Add(barVisible_strip);
            hv_MenuStrip.Items.Add(blnCross_strip);
            hv_MenuStrip.Items.Add(new ToolStripSeparator());
            hv_MenuStrip.Items.Add(saveImg_strip);
            hv_MenuStrip.Items.Add(saveWindow_strip);
            barVisible_strip.Enabled = true;
            fit_strip.Enabled = false;
            histogram_strip.Enabled = false;
            saveImg_strip.Enabled = false;
            saveWindow_strip.Enabled = false;
            mCtrl_HWindow.ContextMenuStrip = hv_MenuStrip;
            mCtrl_HWindow.SizeChanged += new EventHandler((s, e) => DispImageFit(mCtrl_HWindow));
        }
        /// <summary>
        /// 绘制模式下,不允许缩放和鼠标右键菜单
        /// </summary>
        public bool DrawModel
        {
            get { return drawModel; }
            set
            {
                //缩放控制
                WindowH.setDrawModel(value);
                //绘制模式 不现实右键
                if (value == true)
                {
                    mCtrl_HWindow.ContextMenuStrip = null;
                }
                else
                {
                    //恢复
                    mCtrl_HWindow.ContextMenuStrip = hv_MenuStrip;
                }
                drawModel = value;
            }
        }
        /// <summary>
        /// 设置image,初始化控件参数
        /// </summary>
        public HImage Image
        {
            get { return this.hv_image; }
            set
            {
                if (value != null)
                {
                    if (this.hv_image != null)
                    {
                        this.hv_image.Dispose();
                    }
                    this.hv_image = value;
                    hv_image.GetImageSize(out hv_imageWidth, out hv_imageHeight);
                    str_imgSize = String.Format("W:{0},H:{1}", hv_imageWidth, hv_imageHeight);
                    //DispImageFit(mCtrl_HWindow);
                    try
                    {
                        barVisible_strip.Enabled = true;
                        fit_strip.Enabled = true;
                        histogram_strip.Enabled = true;
                        saveImg_strip.Enabled = true;
                        saveWindow_strip.Enabled = true;
                    }
                    catch (Exception)
                    {
                    }
                    WindowH.displayImage(hv_image);
                    PaintCross();
                }
            }
        }
        /// <summary>
        /// 获得halcon窗体控件的句柄
        /// </summary>
        public IntPtr HWindowHalconID
        {
            get { return this.mCtrl_HWindow.HalconWindow; }
        }
        public HWindowControl getHWindowControl()
        {
            return this.mCtrl_HWindow;
        }
        void blnCross_strip_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void PaintCross()
        {
            if (blnCross_strip.Checked)
            {
                //显示十字线
                HXLDCont xldCross = new HXLDCont();
                mCtrl_HWindow.HalconWindow.SetColor("green");
                HRegion hRegion = new HRegion(0, 0, (HTuple)hv_imageHeight, (HTuple)hv_imageWidth);
                HOperatorSet.AreaCenter(hRegion, out HTuple _Area, out HTuple _ROW, out HTuple _COL);
                _ROW = hv_imageHeight / 2;
                _COL = hv_imageWidth / 2;
                //小十字
                mCtrl_HWindow.HalconWindow.DispLine(_ROW - 5, _COL, _ROW + 5, _COL);
                mCtrl_HWindow.HalconWindow.DispLine(_ROW, _COL - 5, _ROW, _COL + 5);
                //大十字-横
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW, (double)_COL + 50, (double)_ROW, (double)_COL * 2);
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW, 0, (double)_ROW, (double)_COL - 50);
                //大十字-竖
                mCtrl_HWindow.HalconWindow.DispLine(0, (double)_COL, (double)_ROW - 50, (double)_COL);
                mCtrl_HWindow.HalconWindow.DispLine((double)_ROW+50, (double)_COL, (double)_ROW*2, (double)_COL);
            }
        }
       /// <summary>
            /// 状态条 显示/隐藏 CheckedChanged事件
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void barVisible_strip_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem strip = sender as ToolStripMenuItem;
            this.SuspendLayout();
            if (strip.Checked)
            {
                m_CtrlHStatusLabelCtrl.Visible = true;
                //mCtrl_HWindow.Height = this.Height - m_CtrlHStatusLabelCtrl.Height - m_CtrlHStatusLabelCtrl.Margin.Top - m_CtrlHStatusLabelCtrl.Margin.Bottom;
                mCtrl_HWindow.HMouseMove += HWindowControl_HMouseMove;
            }
            else
            {
                m_CtrlHStatusLabelCtrl.Visible = false;
                //mCtrl_HWindow.Height = this.Height;
                mCtrl_HWindow.HMouseMove -= HWindowControl_HMouseMove;
            }
            //DispImageFit(mCtrl_HWindow);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public void showStatusBar()
        {
            barVisible_strip.Checked = true;
        }
        /// <summary>
        /// 保存窗体截图到本地
        /// </summary>
        private void SaveWindowDump()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG图像|*.png|BMP图像|*.bmp|JPG图像|*.jpg";//|所有文件|*.*
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName)) { return; }
                HOperatorSet.DumpWindow(hv_window, Path.GetExtension(sfd.FileName).Replace(".", ""), sfd.FileName);//截取窗口图 
            }
        }
        /// <summary>
        /// 保存原始图片到本地
        /// </summary>
        private void SaveImage()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG图像|*.png|BMP图像|*.bmp|JPG图像|*.jpg";//|所有文件|*.*
            sfd.FilterIndex = 1;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName)) { return; }
                FileInfo _FileInfo = new FileInfo(sfd.FileName);
                HOperatorSet.WriteImage(hv_image, Path.GetExtension(sfd.FileName).Replace(".", ""), 0, sfd.FileName);

            }
        }
        /// <summary>
        /// 图片适应大小显示在窗体
        /// </summary>
        /// <param name="hw_Ctrl">halcon窗体控件</param>
        private void DispImageFit(HWindowControl hw_Ctrl)
        {
            try
            {
                this.WindowH.ResetWindowImage();
                PaintCross();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 鼠标在空间窗体里滑动,显示鼠标所在位置的灰度值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HWindowControl_HMouseMove(object sender, HMouseEventArgs e)
        {
            if (hv_image != null)
            {
                try
                {
                    PaintCross();
                    string str_value;
                    HOperatorSet.CountChannels(hv_image, out HTuple channel_count);
                    hv_window.GetMpositionSubPix(out positionY, out positionX, out int button_state);
                    string str_position = string.Format("X: {0:0000}, Y: {1:0000}", positionX, positionY);
                    bool _isXOut = (positionX < 0 || positionX >= hv_imageWidth);
                    bool _isYOut = (positionY < 0 || positionY >= hv_imageHeight);
                    if (!_isXOut && !_isYOut)
                    {
                        if (channel_count == 1)
                        {
                            double grayVal = hv_image.GetGrayval((int)positionY, (int)positionX);
                            str_value = string.Format("Val: {0:000.0}", grayVal);
                        }
                        else if (channel_count == 3)
                        {
                            HImage _RedChannel = hv_image.AccessChannel(1);
                            HImage _GreenChannel = hv_image.AccessChannel(2);
                            HImage _BlueChannel = hv_image.AccessChannel(3);
                            double grayValRed = _RedChannel.GetGrayval((int)positionY, (int)positionX);
                            double grayValGreen = _GreenChannel.GetGrayval((int)positionY, (int)positionX);
                            double grayValBlue = _BlueChannel.GetGrayval((int)positionY, (int)positionX);
                            _RedChannel.Dispose();
                            _GreenChannel.Dispose();
                            _BlueChannel.Dispose();
                            str_value = String.Format("|  {0:000.0}, {1:000.0}, {2:000.0}", "R:" + grayValRed, "G:" + grayValGreen, "B:" + grayValBlue);
                        }
                        else
                        {
                            str_value = "";
                        }
                        m_CtrlHStatusLabelCtrl.Text = str_imgSize + "    " + str_position + "    " + str_value;
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }
        public void ClearWindow()
        {
            try
            {
                this.Invoke(new Action(() =>
                        {
                            //this.hv_image = null;
                            m_CtrlHStatusLabelCtrl.Visible = false;
                            barVisible_strip.Enabled = false;
                            fit_strip.Enabled = false;
                            //histogram_strip.Enabled = false;
                            saveImg_strip.Enabled = false;
                            saveWindow_strip.Enabled = false;
                            mCtrl_HWindow.HalconWindow.ClearWindow();
                            WindowH.ClearWindow();
                            PaintCross();
                        }));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// Hobject转换为的临时Himage,显示背景图
        /// </summary>
        /// <param name="hobject">传递Hobject,必须为图像</param>
        public void HobjectToHimage(HObject hobject)
        {
            if (hobject == null || !hobject.IsInitialized())
            {
                ClearWindow();
                return;
            }
            this.Image = new HImage(hobject);
        }
        #region 缩放后,再次显示传入的HObject
        /// <summary>
        /// 默认红颜色显示
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>
        public void DispObj(HObject hObj)
        {
            lock (this)
            {
                WindowH.DispHobject(hObj, null);
            }
        }
        /// <summary>
        /// 重新开辟内存保存 防止被传入的HObject在其他地方dispose后,不能重现
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>
        /// <param name="color">颜色</param>
        public void DispObj(HObject hObj, string color)
        {
            lock (this)
            {
                WindowH.DispHobject(hObj, color);
            }
        }
        private void mCtrl_HWindow_Click(object sender, EventArgs e)
        {
            //int button_state;
            //hv_window.GetMpositionSubPix(out PositionY, out PositionX, out button_state);
        }
        #endregion
        /// <summary>
        /// 鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mCtrl_HWindow_MouseLeave(object sender, EventArgs e)
        {
            //避免鼠标离开窗口,再返回的时候,图表随着鼠标移动
            WindowH.mouseleave();
        }
        /// <summary>
        /// 显示he文件
        /// </summary>
        /// <param name="he"></param>
        public void ShowHImage(RImage hobject)
        {
            try
            {
                if (hobject == null) return;
                HobjectToHimage(hobject);
                foreach (HRoi roi in hobject.mHRoi)
                {
                    if (roi != null)
                    {
                        lock (this)
                        {
                            WindowH.DispHobject(roi.hobject, roi.drawColor);
                        }
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            DispObj(roi.hobject, roi.drawColor);
                        }
                    }
                }
                foreach (HText roi in hobject.mHText)
                {
                    if (roi != null && roi.roiType == HRoiType.文字显示)
                    {
                        lock (this)
                        {
                            WindowH.DispText(roi);
                        }
                    }
                    else
                    {
                        if (roi != null && roi.hobject.IsInitialized())
                        {
                            DispObj(roi.hobject, roi.drawColor);
                        }
                    }
                }
            }
            catch { }
        }






        #region 涂抹部分
        /// <summary>灰度值，坐标位置</summary>
        public  string message;
        ///<summary>喷涂区域</summary>
        public HRegion BrushRegion;
        ///<summary>掩膜区域</summary>
        public HRegion MaskRegion;
        private int StateView;
        public List<HObjectEntry> HObjList;
        #endregion
        /// <summary>
        /// 擦除区域
        /// </summary>
        /// <param name="Row"></param>
        /// <param name="Column"></param>
        /// <param name="zoomWndFactor"></param>
        public HRegion Eraser(double Row, double Column, double zoomWndFactor)
        {
            BrushRegion = new HRegion();
            HRegion tmpDiff = new HRegion();
            tmpDiff.GenEmptyRegion();
            if (10 * zoomWndFactor < 1)
            {
                BrushRegion.GenCircle(Row, Column, 0.5);
            }
            else
            {
                BrushRegion.GenCircle(Row, Column, 10 * zoomWndFactor);
            }
            if (Row >= 0 && Column >= 0)
            {
                if (MaskRegion == null)
                {
                    MaskRegion = new HRegion();
                    MaskRegion = tmpDiff.Difference(BrushRegion);
                }

                else
                    MaskRegion = MaskRegion.Difference(BrushRegion);
                return BrushRegion;
            }
            else
            {
                return BrushRegion;
            }
        }
        /// <summary>
        ///  喷涂区域
        /// </summary>
        /// <param name="Row"></param>
        /// <param name="Column"></param>
        /// <param name="zoomWndFactor"></param>
        public HRegion Paint(double Row, double Column, double zoomWndFactor)
        {
            BrushRegion = new HRegion();
            HRegion tmpAdd = new HRegion();
            tmpAdd.GenEmptyRegion();
            if (10 * zoomWndFactor < 1)
            {
                BrushRegion.GenCircle(Row, Column, 0.5);
            }
            else
            {
                BrushRegion.GenCircle(Row, Column, 10 * zoomWndFactor);
            }
            if (Row >= 0 && Column >= 0)
            {
                if (MaskRegion == null)
                {
                    MaskRegion = new HRegion();
                    MaskRegion = tmpAdd.Union2(BrushRegion);
                }

                else
                    MaskRegion = MaskRegion.Union2(BrushRegion);
                return BrushRegion;
            }
            else
            {
                return BrushRegion;
            }
        }


        //是否涂抹
        private bool blnDraw = false;
        private HRegion brushRegion = new HRegion();
        // 获取图像的当前显示部分
        private int current_beginRow, current_beginCol, current_endRow, current_endCol;
        /// <summary>
        /// 绘制任意屏蔽区域
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public HRegion SetROI(HRegion region, int drawMode)
        {
            hv_window.SetDraw("fill");//margin
            this.mCtrl_HWindow.Focus();//必须先聚焦
            try
            {
                mCtrl_HWindow.HMouseMove -= HWindowControl_HMouseMove;
                blnDraw = true;
                double Row = 0, Column = 0;
                #region "循环,等待涂抹"
                brushRegion.GenRectangle1(0.0, 0, 3, 3);
                //鼠标状态
                int hv_Button = 0;
                // 4为鼠标右键
                while (hv_Button != 4)
                {
                    //一直在循环,需要让halcon控件也响应事件,不然到时候跳出循环,之前的事件会一起爆发触发,
                    Application.DoEvents();
                    //获取鼠标坐标
                    try
                    {
                        hv_window.GetMpositionSubPix(out Row, out Column, out hv_Button);
                        hv_window.GetPart(out current_beginRow, out current_beginCol, out current_endRow, out current_endCol);
                        double d = Math.Sqrt(Math.Pow(current_endRow - current_beginRow, 2) + Math.Pow(current_endCol - current_beginCol, 2));
                        //brushRegion.GenCircle(Row, Column, d / 50.0);
                        brushRegion.GenRectangle1(Row - 2, Column - 2, Row + 2, Column + 2);
                    }
                    catch (HalconException ex)
                    {
                        Debug.WriteLine(ex.Message);
                        hv_Button = 0;
                    }
                    //check if mouse cursor is over window
                    if (Row >= 0 && Column >= 0)
                    {
                        //1为鼠标左键
                        if (hv_Button == 1)
                        {
                            //画出笔刷
                            switch (drawMode)
                            {
                                case 0:
                                    {
                                        if (region.IsInitialized())
                                            region = region.Union2(brushRegion);
                                        else
                                            region = brushRegion;
                                    }
                                    break;
                                case 1:
                                    region = region.Difference(brushRegion);
                                    break;
                                default:
                                    MessageBox.Show("设置错误");
                                    break;
                            }//end switch
                        }//end if
                    }
                    HOperatorSet.SetSystem("flush_graphic", "false");//magical 20171028 防止画面闪烁
                    hv_window.DispObj(hv_image);
                    //hv_window.SetLineWidth(1.2);
                    hv_window.SetColor("magenta");//这一段也必须放在中间  
                    //hv_window.SetRgba(255, 0, 0, 120);
                    hv_window.SetColor("orange");   
                    if (region != null)
                        hv_window.DispObj(region);
                    HOperatorSet.SetSystem("flush_graphic", "true");//很奇怪必须放在这里,不能把下面的给包含进去 magical20171028

                    double a = 1; double b = 50;
                    //brushRegion.FillUpShape("red", a, b);
                    if (drawMode == 0)
                    {
                        hv_window.SetColor("red");
                    }
                    else
                        hv_window.SetColor("green");
                    if (brushRegion != null)
                        hv_window.DispObj(brushRegion);
                    hv_window.SetColor("#00ff00a0");
                    //hv_window.SetRgba(255, 0, 0, 120);
                }//end while
                #endregion
                blnDraw = false;
                mCtrl_HWindow.HMouseMove += HWindowControl_HMouseMove;
                return region;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
