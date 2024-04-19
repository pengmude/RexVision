using System;
using System.Collections;
using System.Collections.Generic;
using RexConst;
using System.Diagnostics;
using HalconDotNet;
using System.Windows.Forms;

namespace RexView
{
    public delegate void FuncDelegate();
    public delegate void IconicDelegate(int val);
    /// <summary>
    ///这个类作为HALCON窗口的包装类
    ///HWindow。HWndCtrl负责可视化。
    ///您可以使用GUI组件移动和缩放可见图像部分
    ///输入或用鼠标。类HWndCtrl使用图形堆栈
    ///来管理显示的图标对象。每个对象都是链接的
    ///指向一个图形上下文，该上下文决定如何绘制对象。
    ///可以通过调用ChangeGraphicSettings()来更改上下文。
    ///图形化的“模式”是由类GraphicsContext和
    ///映射HDevelop中提供的大多数dev_set_*操作符。
    /// </summary>
    public class HWndCtrl
    {
        /// <summary>显示ROI</summary>
        public const int MODE_INCLUDE_ROI = 1;
        /// <summary>不显示ROI</summary>
		public const int MODE_EXCLUDE_ROI = 2;
        /// <summary>对鼠标事件不执行任何操作</summary>
        public const int MODE_VIEW_NONE = 10;
        /// <summary>缩放在鼠标事件上执行</summary>
        public const int MODE_VIEW_ZOOM = 11;
        /// <summary>在鼠标事件上执行移动</summary>
        public const int MODE_VIEW_MOVE = 12;
        /// <summary>对鼠标事件进行放大</summary>
        public const int MODE_VIEW_ZOOMWINDOW = 13;
        /// <summary>擦除</summary>
        public const int MODE_ERASER = 14;
        /// <summary>喷涂</summary>
        public const int MODE_PAINT = 15;
        /// <summary>设置ROI模式的常数:ROI正符号。</summary>
        public const int MODE_ROI_POS = 21;
        /// <summary>设置ROI模式的常数:负的ROI符号。</summary>
        public const int MODE_ROI_NEG = 22;
        /// <summary>设置ROI模式的常数:没有模型区域计算为/// 所有ROI对象的总和.</summary>
        public const int MODE_ROI_NONE = 23;
        /// <summary>描述为新图像发出信号的委托消息</summary>
        public const int EVENT_UPDATE_IMAGE = 31;
        /// <summary>常量描述从文件中读取图像时发出错误信号的委托消息 </summary>
        public const int ERR_READING_IMG = 32;
        /// <summary>常量在定义图形上下文时，将委托消息描述为信号错误</summary>
        public const int ERR_DEFINING_GC = 33;
        /// <summary>描述模型区域更新的常数</summary>
        public const int EVENT_UPDATE_ROI = 50;
        public const int EVENT_CHANGED_ROI_SIGN = 51;
        /// <summary>描述模型区域更新的常数</summary>
        public const int EVENT_MOVING_ROI = 52;
        public const int EVENT_DELETED_ACTROI = 53;
        public const int EVENT_DELETED_ALL_ROIS = 54;
        public const int EVENT_ACTIVATED_ROI = 55;
        public const int EVENT_CREATED_ROI = 56;
        /// <summary> 可以放置在图形上的HALCON对象的最大数量,堆栈不丢失。对于每个额外的对象，第一个条目,被再次从栈中移除。</summary>
        private const int MAXNUMOBJLIST = 2;//原始值为50 实际上2都可以,因这里只是存储背景图片
        private int ViewState;
        private bool MousePressed = false;
        private double StartX, StartY;
        /// <summary>HALCON window</summary>
        private HWindowControl ViewPort;
        /// <summary>ROIController的实例，它管理ROI交互</summary>
        private ROIController ROIManager;
        /// <summary>绘制例程和是否响应鼠标事件 </summary>
        private int DispROI;
        /// <summary>缩放事件开关</summary>
        public bool drawModel = false;
        #region 基本参数，如窗口尺寸和显示图像部分
        private int WindowWidth, WindowHeight, ImageWidth, ImageHeight, PrevCompX, PrevCompY;
        private int[] CompRangeX;
        private int[] CompRangeY;
        /// <summary> 图像坐标，用于描述HALCON窗口中显示的图像部分 </summary>
        private double ImgRow1, ImgCol1, ImgRow2, ImgCol2, StepSizeX, StepSizeY;
        /// <summary>抛出异常时的错误消息</summary>
        public string ExceptionText = "";
        /// <summary>委托发送通知消息到其他类 </summary>
        public FuncDelegate AddInfoDelegate;
        /// <summary>通知HWndCtrl实例的失败任务 </summary>
        public IconicDelegate NotifyIconObserver;
        private HWindow ZoomWindow;
        /// <summary> 缩放操作</summary>
        private double ZoomWndFactor, ZoomAddOn;
        private int ZoomWndSize;
        /// <summary> 绘制到HALCON窗口的HALCON对象列表 </summary>
        private ArrayList HObjImageList;
        /// <summary>用于描述图形上下文的实例， HALCON窗口。根据图形设置</summary>
        private GraphicsContext mGC;
        #region 涂抹部分
        /// <summary>灰度值，坐标位置</summary>
        string message;
        HRegion BrushRegion;
        private int StateView;
        public List<HObjectEntry> HObjList;
        #endregion
        #endregion
        /// <summary>初始化图像尺寸、鼠标委托和实例的图形上下文设置。 </summary>
        protected internal HWndCtrl(HWindowControl view)
        {
            ViewPort = view;
            ViewState = MODE_VIEW_NONE;
            WindowWidth = ViewPort.Size.Width;
            WindowHeight = ViewPort.Size.Height;
            ZoomWndFactor = (double)ImageWidth / ViewPort.Width;
            ZoomAddOn = Math.Pow(0.9, 5);
            ZoomWndSize = 150;
            /*default*/
            CompRangeX = new int[] { 0, 100 };
            CompRangeY = new int[] { 0, 100 };
            PrevCompX = PrevCompY = 0;
            DispROI = MODE_INCLUDE_ROI;//1;
            ViewPort.HMouseUp += new HMouseEventHandler(this.MouseUp);
            ViewPort.HMouseDown += new HMouseEventHandler(this.MouseDown);
            ViewPort.HMouseWheel += new HMouseEventHandler(this.MouseWheel);
            ViewPort.HMouseMove += new HMouseEventHandler(this.MouseMoved);
            AddInfoDelegate = new FuncDelegate(dummyV);
            NotifyIconObserver = new IconicDelegate(dummy);
            // graphical stack 
            HObjImageList = new ArrayList(20);
            mGC = new GraphicsContext();
            mGC.gcNotification = new GCDelegate(ExceptionGC);
        }
        private void MouseWheel(object sender, HMouseEventArgs e)
        {
            //关闭缩放事件
            if (drawModel)
            {
                return;
            }
            double scale;
            if (e.Delta > 0)
                scale = 0.9;
            else
                scale = 1 / 0.9;
            ZoomImage(e.X, e.Y, scale);
        }
        /// <summary>读取图像的尺寸以调整自己的窗口设置 </summary>
        private void SetImagePart(HImage image)
        {
            string s;
            int w, h;

            image.GetImagePointer1(out s, out w, out h);
            SetImagePart(0, 0, h, w);
        }
        /// <summary>根据左边提供的值调整窗口设置，右上角和右下角 </summary>
        private void SetImagePart(int r1, int c1, int r2, int c2)
        {
            ImgRow1 = r1;
            ImgCol1 = c1;
            ImgRow2 = ImageHeight = r2;
            ImgCol2 = ImageWidth = c2;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)ImgCol1;
            rect.Y = (int)ImgRow1;
            rect.Height = (int)ImageHeight;
            rect.Width = (int)ImageWidth;
            ViewPort.ImagePart = rect;
        }
        /// <summary>设置HALCON窗口中的鼠标事件的视图模式(缩放，移动，放大或无)。 </summary>
        public void SetViewState(int mode)
        {
            ViewState = mode;
            if (ROIManager != null)
                ROIManager.ResetROI();
        }
        /********************************************************************/
        private void dummy(int val)
        {
        }
        private void dummyV()
        {
        }
        /*******************************************************************/
        private void ExceptionGC(string message)
        {
            ExceptionText = message;
            NotifyIconObserver(ERR_DEFINING_GC);
        }

        /// <summary>
        /// Paint or don't paint the ROIs into the HALCON window by 
        /// defining the parameter to be equal to 1 or not equal to 1.
        /// </summary>
        public void SetDispLevel(int mode)
        {
            DispROI = mode;
        }

        /****************************************************************************/
        /*                          graphical element                               */
        /****************************************************************************/
        private void ZoomImage(double x, double y, double scale)
        {
            //关闭缩放事件
            if (drawModel)
            {
                return;
            }
            double lengthC, lengthR, percentC, percentR;
            int lenC, lenR;
            percentC = (x - ImgCol1) / (ImgCol2 - ImgCol1);
            percentR = (y - ImgRow1) / (ImgRow2 - ImgRow1);

            lengthC = (ImgCol2 - ImgCol1) * scale;
            lengthR = (ImgRow2 - ImgRow1) * scale;

            ImgCol1 = x - lengthC * percentC;
            ImgCol2 = x + lengthC * (1 - percentC);

            ImgRow1 = y - lengthR * percentR;
            ImgRow2 = y + lengthR * (1 - percentR);

            lenC = (int)Math.Round(lengthC);
            lenR = (int)Math.Round(lengthR);

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)Math.Round(ImgCol1);
            rect.Y = (int)Math.Round(ImgRow1);
            rect.Width = (lenC > 0) ? lenC : 1;
            rect.Height = (lenR > 0) ? lenR : 1;



            ViewPort.ImagePart = rect;

            double _zoomWndFactor = 1;
            _zoomWndFactor = scale * ZoomWndFactor;

            if (ZoomWndFactor < 0.001 && _zoomWndFactor < ZoomWndFactor)
            {
                //超过一定缩放比例就不在缩放
                ResetWindow();
                return;
            }
            if (ZoomWndFactor > 100 && _zoomWndFactor > ZoomWndFactor)
            {
                //超过一定缩放比例就不在缩放
                ResetWindow();
                return;
            }
            ZoomWndFactor = _zoomWndFactor;

            Repaint();
        }
        /// <summary>
        /// Scales the image in the HALCON window according to the 
        /// value scaleFactor
        /// </summary>
        public void ZoomImage(double scaleFactor)
        {

            double midPointX, midPointY;

            if (((ImgRow2 - ImgRow1) == scaleFactor * ImageHeight) &&
                ((ImgCol2 - ImgCol1) == scaleFactor * ImageWidth))
            {
                Repaint();
                return;
            }

            ImgRow2 = ImgRow1 + ImageHeight;
            ImgCol2 = ImgCol1 + ImageWidth;

            midPointX = ImgCol1;
            midPointY = ImgRow1;

            ZoomWndFactor = (double)ImageWidth / ViewPort.Width;
            ZoomImage(midPointX, midPointY, scaleFactor);
        }
        /// <summary>
        /// Scales the HALCON window according to the value scale
        /// </summary>
        public void ScaleWindow(double scale)
        {
            ImgRow1 = 0;
            ImgCol1 = 0;

            ImgRow2 = ImageHeight;
            ImgCol2 = ImageWidth;

            ViewPort.Width = (int)(ImgCol2 * scale);
            ViewPort.Height = (int)(ImgRow2 * scale);

            ZoomWndFactor = ((double)ImageWidth / ViewPort.Width);
        }
        /// <summary>
        /// Recalculates the image-window-factor, which needs to be added to 
        /// the scale factor for zooming an image. This way the zoom gets 
        /// adjusted to the window-image relation, expressed by the equation 
        /// ImageWidth/ViewPort.Width.
        /// </summary>
        public void SetZoomWndFactor()
        {
            ZoomWndFactor = ((double)ImageWidth / ViewPort.Width);
        }
        /// <summary>
        /// Sets the image-window-factor to the value zoomF
        /// </summary>
        public void SetZoomWndFactor(double zoomF)
        {
            ZoomWndFactor = zoomF;
        }
        /*******************************************************************/
        private void MoveImage(double MotionX, double MotionY)
        {
            ImgRow1 += -MotionY;
            ImgRow2 += -MotionY;

            ImgCol1 += -MotionX;
            ImgCol2 += -MotionX;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)Math.Round(ImgCol1);
            rect.Y = (int)Math.Round(ImgRow1);
            ViewPort.ImagePart = rect;

            Repaint();
        }
        /// <summary>
        /// Resets all parameters that concern the HALCON window display 
        /// setup to their initial values and clears the ROI list.
        /// </summary>
        protected internal void ResetAll()
        {
            ImgRow1 = 0;
            ImgCol1 = 0;
            ImgRow2 = ImageHeight;
            ImgCol2 = ImageWidth;

            ZoomWndFactor = (double)ImageWidth / ViewPort.Width;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)ImgCol1;
            rect.Y = (int)ImgRow1;
            rect.Width = (int)ImageWidth;
            rect.Height = (int)ImageHeight;
            ViewPort.ImagePart = rect;


            if (ROIManager != null)
                ROIManager.ResetVar();
        }
        protected internal void ResetWindow()
        {

            if (ImageHeight == 0)
            {
                return;
            }
            double ratio_win = (double)ViewPort.WindowSize.Width / (double)ViewPort.WindowSize.Height;
            double ratio_img = (double)ImageWidth / (double)ImageHeight;

            int _beginRow, _begin_Col, _endRow, _endCol;
            //
            if (ratio_win >= ratio_img)
            {
                _beginRow = 0;
                _endRow = ImageHeight - 1;
                _begin_Col = (int)(-ImageWidth * (ratio_win / ratio_img - 1d) / 2d);
                _endCol = (int)(ImageWidth + ImageWidth * (ratio_win / ratio_img - 1d) / 2d);
            }
            else
            {
                _begin_Col = 0;
                _endCol = ImageWidth - 1;
                _beginRow = (int)(-ImageHeight * (ratio_img / ratio_win - 1d) / 2d);
                _endRow = (int)(ImageHeight + ImageHeight * (ratio_img / ratio_win - 1d) / 2d);
            }
            //缩放比例为1
            ZoomWndFactor = 1;

            System.Drawing.Rectangle rect = ViewPort.ImagePart;
            rect.X = (int)_begin_Col;
            rect.Y = (int)_beginRow;
            rect.Width = (int)_endCol - _begin_Col;
            rect.Height = (int)_endRow - _beginRow;
            ViewPort.ImagePart = rect;

            ImgRow1 = _beginRow;
            ImgCol1 = _begin_Col;
            ImgRow2 = _endRow;
            ImgCol2 = _endCol;
        }
        /*************************************************************************/
        /*      			 Event handling for mouse	   	                     */
        /*************************************************************************/
        private void MouseDown(object sender, HMouseEventArgs e)
        {
            //关闭缩放事件
            if (drawModel) return;
            ViewPort.Cursor = System.Windows.Forms.Cursors.Hand;
            ViewState = MODE_VIEW_MOVE;
            MousePressed = true;
            string ActiveROIId = "";
            if (ROIManager != null && (DispROI == MODE_INCLUDE_ROI))
            {
                ActiveROIId = ROIManager.mouseDownAction(e.X, e.Y);
            }
            switch (ViewState)
            {
                case MODE_VIEW_MOVE:
                    StartX = e.X;
                    StartY = e.Y;
                    break;

                case MODE_VIEW_NONE:
                    break;
                case MODE_VIEW_ZOOMWINDOW:
                    ActivateZoomWindow((int)e.X, (int)e.Y);
                    break;
                default:
                    break;
            }
            //end of if
        }

        /*******************************************************************/
        private void ActivateZoomWindow(int X, int Y)
        {
            double posX, posY;
            int ZoomZone;

            if (ZoomWindow != null)
                ZoomWindow.Dispose();

            HOperatorSet.SetSystem("border_width", 10);
            ZoomWindow = new HWindow();

            posX = ((X - ImgCol1) / (ImgCol2 - ImgCol1)) * ViewPort.Width;
            posY = ((Y - ImgRow1) / (ImgRow2 - ImgRow1)) * ViewPort.Height;

            ZoomZone = (int)((ZoomWndSize / 2) * ZoomWndFactor * ZoomAddOn);
            ZoomWindow.OpenWindow((int)(posY - (ZoomWndSize / 2)), (int)(posX - (ZoomWndSize / 2)), (int)ZoomWndSize, (int)ZoomWndSize,
                                   ViewPort.HalconID, "visible", "");
            ZoomWindow.SetPart(Y - ZoomZone, X - ZoomZone, Y + ZoomZone, X + ZoomZone);
            Repaint(ZoomWindow);
            ZoomWindow.SetColor("black");
        }
        public void RaiseMouseup()
        {
            MousePressed = false;

            if (ROIManager != null && (ROIManager.ActiveROIId.Length > 0) && (DispROI == MODE_INCLUDE_ROI))
            {
                ROIManager.NotifyRCObserver(EVENT_UPDATE_ROI);
            }
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)
            {
                ZoomWindow.Dispose();
            }
        }
        /*******************************************************************/
        private void MouseUp(object sender, HMouseEventArgs e)
        {
            //关闭缩放事件
            if (drawModel)
            {
                return;
            }

            MousePressed = false;

            if (ROIManager != null && (ROIManager.ActiveROIId.Length > 0) && (DispROI == MODE_INCLUDE_ROI))
            {
                ROIManager.NotifyRCObserver(EVENT_UPDATE_ROI);
            }
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)
            {
                ZoomWindow.Dispose();
            }
        }
        /*******************************************************************/
        private void MouseMoved(object sender, HMouseEventArgs e)
        {
            //关闭缩放事件
            if (drawModel) { return; }
            double MotionX, MotionY, PosX, PosY, ZoomZone;
            if (!MousePressed) return;
            if (ROIManager != null && (ROIManager.ActiveROIId.Length > 0) && (DispROI == MODE_INCLUDE_ROI))
            {
                ROIManager.mouseMoveAction(e.X, e.Y);
            }
            else if (ViewState == MODE_VIEW_MOVE)//平移图像
            {
                MotionX = (e.X - StartX);
                MotionY = (e.Y - StartY);

                if (((int)MotionX != 0) || ((int)MotionY != 0))
                {
                    MoveImage(MotionX, MotionY);
                    StartX = e.X - MotionX;
                    StartY = e.Y - MotionY;
                }
            }
            else if (ViewState == MODE_VIEW_ZOOMWINDOW)//局部放大
            {
                HSystem.SetSystem("flush_graphic", "false");
                ZoomWindow.ClearWindow();
                PosX = ((e.X - ImgCol1) / (ImgCol2 - ImgCol1)) * ViewPort.Width;
                PosY = ((e.Y - ImgRow1) / (ImgRow2 - ImgRow1)) * ViewPort.Height;
                ZoomZone = (ZoomWndSize / 2) * ZoomWndFactor * ZoomAddOn;
                ZoomWindow.SetWindowExtents((int)(PosY - (ZoomWndSize / 2)), (int)(PosX - (ZoomWndSize / 2)), ZoomWndSize, ZoomWndSize);
                ZoomWindow.SetPart((int)(e.Y - ZoomZone), (int)(e.X - ZoomZone), (int)(e.Y + ZoomZone), (int)(e.X + ZoomZone));
                Repaint(ZoomWindow);
                HSystem.SetSystem("flush_graphic", "true");
                ZoomWindow.DispLine(-100.0, -100.0, -100.0, -100.0);
            }
            double currX, currY;
            try
            {
                if (HObjList.Count < 1 || HObjList[0].HObj == null || (HObjList[0].HObj is HImage) == false)
                {
                    return;
                }
                ViewPort.HalconWindow.GetMpositionSubPix(out currY, out currX, out int state);
                HImage hv_image = HObjList[0].HObj as HImage;
                bool _isXOut = true, _isYOut = true;
                string str_imgSize = string.Format("图像:W:{0}*H:{1}", ImageWidth, ImageHeight);
                int channel_count = hv_image.CountChannels();
                string str_position = string.Format("|X:{0:F0},Y:{1:F0}", currX, currY);
                _isXOut = (currX < 0 || currX >= ImageWidth);
                _isYOut = (currY < 0 || currY >= ImageHeight);
                //获取图片当前鼠标位置灰度值。
                string str_value = "";
                if (!_isXOut && !_isYOut)
                {
                    if (channel_count == 1)
                    {
                        double grayVal;
                        grayVal = hv_image.GetGrayval((int)currY, (int)currX);
                        str_value = string.Format("|GrayVal:{0}", grayVal);
                    }
                    else if ((int)channel_count == 3)
                    {
                        double grayValRed, grayValGreen, grayValBlue;
                        HImage _RedChannel, _GreenChannel, _BlueChannel;
                        _RedChannel = hv_image.AccessChannel(1);
                        _GreenChannel = hv_image.AccessChannel(2);
                        _BlueChannel = hv_image.AccessChannel(3);
                        grayValRed = _RedChannel.GetGrayval((int)currY, (int)currX);
                        grayValGreen = _GreenChannel.GetGrayval((int)currY, (int)currX);
                        grayValBlue = _BlueChannel.GetGrayval((int)currY, (int)currX);
                        str_value = string.Format("| R:{0}, G:{1}, B:{2})", grayValRed, grayValGreen, grayValBlue);
                    }
                    message = str_imgSize + str_position + str_value;
                    switch (StateView)
                    {
                        case MODE_ERASER://擦除区域
                            if (state == 1)
                            {   //刷子
                                BrushRegion = ROIManager.Eraser(currY, currX, ZoomWndFactor);
                            }
                            break;
                        case MODE_PAINT://喷涂区域
                            if (state == 1)
                            {   //刷子
                                BrushRegion = ROIManager.Paint(currY, currX, ZoomWndFactor);
                            }
                            break;
                        case MODE_VIEW_NONE:
                            //刷子
                            BrushRegion = new HRegion(0, 0, 0.0);
                            break;
                    }
                    Repaint();
                }
            }
            catch (Exception ex)
            {
                Repaint();
            }
        }

        /// <summary>
        /// To initialize the move function using a GUI component, the HWndCtrl
        /// first needs to know the range supplied by the GUI component. 
        /// For the x direction it is specified by xRange, which is 
        /// calculated as follows: GuiComponentX.Max()-GuiComponentX.Min().
        /// The starting value of the GUI component has to be supplied 
        /// by the parameter Init
        /// </summary>
        public void SetGUICompRangeX(int[] xRange, int Init)
        {
            CompRangeX = xRange;
            int RangeX = xRange[1] - xRange[0];
            PrevCompX = Init;
            StepSizeX = ((double)ImageWidth / RangeX) * (ImageWidth / WindowWidth);
        }

        /// <summary>
        /// To initialize the move function using a GUI component, the HWndCtrl
        /// first needs to know the range supplied by the GUI component. 
        /// For the y direction it is specified by yRange, which is 
        /// calculated as follows: GuiComponentY.Max()-GuiComponentY.Min().
        /// The starting value of the GUI component has to be supplied 
        /// by the parameter Init
        /// </summary>
        public void SetGUICompRangeY(int[] yRange, int Init)
        {
            CompRangeY = yRange;
            int RangeY = yRange[1] - yRange[0];
            PrevCompY = Init;
            StepSizeY = ((double)ImageHeight / RangeY) * (ImageHeight / WindowHeight);
        }

        /// <summary>
        /// Resets to the starting value of the GUI component.
        /// </summary>
        public void ResetGUIInitValues(int xVal, int yVal)
        {
            PrevCompX = xVal;
            PrevCompY = yVal;
        }

        /// <summary>
        /// Moves the image by the value valX supplied by the GUI component
        /// </summary>
        public void MoveXByGUIHandle(int valX)
        {
            double MotionX;

            MotionX = (valX - PrevCompX) * StepSizeX;

            if (MotionX == 0)
                return;

            MoveImage(MotionX, 0.0);
            PrevCompX = valX;
        }

        /// <summary>
        /// Moves the image by the value valY supplied by the GUI component
        /// </summary>
        public void MoveYByGUIHandle(int valY)
        {
            double MotionY;

            MotionY = (valY - PrevCompY) * StepSizeY;

            if (MotionY == 0)
                return;

            MoveImage(0.0, MotionY);
            PrevCompY = valY;
        }

        /// <summary>
        /// Zooms the image by the value valF supplied by the GUI component
        /// </summary>
        public void ZoomByGUIHandle(double valF)
        {
            double x, y, scale;
            double prevScaleC;

            x = (ImgCol1 + (ImgCol2 - ImgCol1) / 2);
            y = (ImgRow1 + (ImgRow2 - ImgRow1) / 2);

            prevScaleC = (double)((ImgCol2 - ImgCol1) / ImageWidth);
            scale = ((double)1.0 / prevScaleC * (100.0 / valF));

            ZoomImage(x, y, scale);
        }

        /// <summary>
        /// Triggers a Repaint of the HALCON window
        /// </summary>
        public void Repaint()
        {
            Repaint(ViewPort.HalconWindow);
        }
        /// <summary>
        /// Repaints the HALCON window 'window'
        /// </summary>
        public void Repaint(HWindow window)
        {
            try
            {
                window.SetDraw("margin");
                HSystem.SetSystem("flush_graphic", "false");
                window.ClearWindow();
                mGC.stateOfSettings.Clear();
                //显示图片
                for (int i = 0; i < HObjImageList.Count; i++)
                {
                    HObjectEntry entry = (HObjectEntry)HObjImageList[i];
                    mGC.ApplyContext(window, entry.gContext);
                    window.DispObj(entry.HObj);
                }
                //显示region
                ShowHObjectList();
                AddInfoDelegate();
                if (ROIManager != null && (DispROI == MODE_INCLUDE_ROI))
                {
                    ROIManager.PaintData(window);
                }
                HSystem.SetSystem("flush_graphic", "true");
                //注释了下面语句,会导致窗口无法实现缩放和拖动
                window.SetColor("black");
                window.DispLine(-100.0, -100.0, -101.0, -101.0);
            }
            catch (Exception ex)
            {
            }
        }

        /*******************************************************************
        /*                      GRAPHICSSTACK                               */
        /********************************************************************/

        /// <summary>
        /// Adds an iconic object to the graphics stack similar to the way
        /// it is defined for the HDevelop graphics stack.
        /// </summary>
        /// <param name="obj">Iconic object</param>
        public void AddIconicVar(HObject img)
        {
            //先把HObjImageList给全部释放了,源代码 会出现内存泄漏问题
            for (int i = 0; i < HObjImageList.Count; i++)
            {
                ((HObjectEntry)HObjImageList[i]).clear();
            }
            if (img == null) return;
            HOperatorSet.GetObjClass(img, out HTuple classValue);
            if (!classValue.S.Equals(classValue))
            { return; }
            if ((HImage)img is HImage)
            {
                int area = ((HImage)img).GetDomain().AreaCenter(out double r, out double c);
                ((HImage)img).GetImagePointer1(out string s, out int w, out int h);

                if (area == (w * h))
                {
                    ClearList();
                    if (w != ImageWidth || h != ImageHeight)
                    {
                        ImageWidth = w;
                        ImageHeight = h;
                        ZoomWndFactor = (double)ImageWidth / ViewPort.Width;
                        SetImagePart(0, 0, h, w);
                    }
                }//if
            }//if
            HObjectEntry entry = new HObjectEntry((HImage)img, mGC.copyContextList());
            HObjImageList.Add(entry);
            //每当传入背景图的时候 都清空HObjectList
            ClearHObjectList();
            if (HObjImageList.Count > MAXNUMOBJLIST)
            {
                //需要自己手动释放
                ((HObjectEntry)HObjImageList[0]).clear();
                HObjImageList.RemoveAt(1);
            }
        }

        /// <summary>
        /// Clears all entries from the graphics stack 
        /// </summary>
        public void ClearList()
        {
            HObjImageList.Clear();
        }

        /// <summary>
        /// Returns the number of items on the graphics stack
        /// </summary>
        public int GetListCount()
        {
            return HObjImageList.Count;
        }

        /// <summary>
        /// Changes the current graphical context by setting the specified mode
        /// (constant starting by GC_*) to the specified value.
        /// </summary>
        /// <param name="mode">
        /// Constant that is provided by the class GraphicsContext
        /// and describes the mode that has to be changed, 
        /// e.g., GraphicsContext.GC_COLOR
        /// </param>
        /// <param name="val">
        /// Value, provided as a string, 
        /// the mode is to be changed to, e.g., "blue" 
        /// </param>
        public void ChangeGraphicSettings(string mode, string val)
        {
            switch (mode)
            {
                case GraphicsContext.GC_COLOR:
                    mGC.setColorAttribute(val);
                    break;
                case GraphicsContext.GC_DRAWMODE:
                    mGC.setDrawModeAttribute(val);
                    break;
                case GraphicsContext.GC_LUT:
                    mGC.setLutAttribute(val);
                    break;
                case GraphicsContext.GC_PAINT:
                    mGC.setPaintAttribute(val);
                    break;
                case GraphicsContext.GC_SHAPE:
                    mGC.setShapeAttribute(val);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Changes the current graphical context by setting the specified mode
        /// (constant starting by GC_*) to the specified value.
        /// </summary>
        /// <param name="mode">
        /// Constant that is provided by the class GraphicsContext
        /// and describes the mode that has to be changed, 
        /// e.g., GraphicsContext.GC_LINEWIDTH
        /// </param>
        /// <param name="val">
        /// Value, provided as an integer, the mode is to be changed to, 
        /// e.g., 5 
        /// </param>
        public void ChangeGraphicSettings(string mode, int val)
        {
            switch (mode)
            {
                case GraphicsContext.GC_COLORED:
                    mGC.setColoredAttribute(val);
                    break;
                case GraphicsContext.GC_LINEWIDTH:
                    mGC.setLineWidthAttribute(val);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Changes the current graphical context by setting the specified mode
        /// (constant starting by GC_*) to the specified value.
        /// </summary>
        /// <param name="mode">
        /// Constant that is provided by the class GraphicsContext
        /// and describes the mode that has to be changed, 
        /// e.g.,  GraphicsContext.GC_LINESTYLE
        /// </param>
        /// <param name="val">
        /// Value, provided as an HTuple instance, the mode is 
        /// to be changed to, e.g., new HTuple(new int[]{2,2})
        /// </param>
        public void ChangeGraphicSettings(string mode, HTuple val)
        {
            switch (mode)
            {
                case GraphicsContext.GC_LINESTYLE:
                    mGC.setLineStyleAttribute(val);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Clears all entries from the graphical context list
        /// </summary>
        public void ClearGraphicContext()
        {
            mGC.clear();
        }

        /// <summary>
        /// Returns a clone of the graphical context list (hashtable)
        /// </summary>
        public Hashtable GetGraphicContext()
        {
            return mGC.copyContextList();
        }

        /// <summary>
        /// Registers an instance of an ROIController with this window 
        /// controller (and vice versa).
        /// </summary>
        /// <param name="rC"> 
        /// Controller that manages interactive ROIs for the HALCON window 
        /// </param>
        protected internal void SetROIController(ROIController rC)
        {
            ROIManager = rC;
            rC.SetViewController(this);
            this.SetViewState(HWndCtrl.MODE_VIEW_NONE);
        }
        /// <summary>
        /// 添加设定显示的图像
        /// </summary>
        /// <param name="image"></param>
        protected internal void addImageShow(HObject image)
        {
            AddIconicVar(image);
        }
        #region 再次显示region和 xld

        /// <summary>
        /// hObjectList用来存储存入的HObject
        /// </summary>
        private List<HObjectWithColor> hObjectList = new List<HObjectWithColor>();
        /// <summary>
        /// roiTextList用来存储存入的显示文本
        /// </summary>
        private List<HText> roiTextList = new List<HText>();

        /// <summary>
        /// 默认红颜色显示
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>
        public void DispObj(HObject hObj)
        {
            DispObj(hObj, null);
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
                try
                {
                    //显示指定的颜色
                    if (color != null)
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, color);
                    }
                    else
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }
                    if (hObj != null && hObj.IsInitialized())
                    {
                        //HObject temp = new HObject(hObj);
                        hObjectList.Add(new HObjectWithColor(hObj, color));
                        ViewPort.HalconWindow.DispObj(hObj);
                    }
                    //恢复默认的红色
                    HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                }
                catch { }
            }
        }

        /// <summary>
        /// 重新开辟内存保存 防止被传入的HObject在其他地方dispose后,不能重现
        /// </summary>
        /// <param name="hObj">传入的region.xld,image</param>
        /// <param name="color">颜色</param>
        public void DispObj(HText roiText)
        {
            lock (this)
            {
                roiTextList.Add(roiText);
                ShowTool.SetFont(ViewPort.HalconWindow, roiText.size, roiText.font, "false", "false");
                ShowTool.SetMsg(ViewPort.HalconWindow, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
            }
        }

        /// <summary>
        /// 每次传入新的背景Image时,清空hObjectList,避免内存没有被释放
        /// </summary>
        public void ClearHObjectList()
        {

            foreach (HObjectWithColor hObjectWithColor in hObjectList)
            {
                hObjectWithColor.HObject.Dispose();
            }

            hObjectList.Clear();
            roiTextList.Clear();
        }

        /// <summary>
        /// 将hObjectList中的HObject,按照先后顺序显示出来
        /// </summary>
        private void ShowHObjectList()
        {
            try
            {
                foreach (HObjectWithColor hObjectWithColor in hObjectList)
                {
                    if (hObjectWithColor.Color != null)
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, hObjectWithColor.Color);
                    }
                    else
                    {
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }
                    if (hObjectWithColor != null && hObjectWithColor.HObject.IsInitialized())
                    {
                        ViewPort.HalconWindow.DispObj(hObjectWithColor.HObject);

                        //恢复默认的红色
                        HOperatorSet.SetColor(ViewPort.HalconWindow, "red");
                    }
                }

                foreach (HText roiText in roiTextList)
                {
                    ShowTool.SetFont(ViewPort.HalconWindow, roiText.size, roiText.font, "false", "false");
                    ShowTool.SetMsg(ViewPort.HalconWindow, roiText.text, "image", roiText.row, roiText.col, roiText.drawColor, "false");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //有时候hobj被dispose了,但是其本身不为null,此时则报错. 已经使用IsInitialized解决了 
            }
        }

        #endregion
    }//end of class
}//end of namespace
