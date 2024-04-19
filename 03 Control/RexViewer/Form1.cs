using HalconDotNet;
using Ookii.Dialogs.WinForms;
using RexHelps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RexView
{
    public partial class Form1 : Form
    {
        int num_ = 0;
        int index = 0;
        Dictionary<string, ROI> m_RegionsList;//roi集合     


        public FileInfo[] m_FileList;//图像路径
        private HWindow hv_WindowHandle;
        private HObject image = new HObject();//图片
        private HObject brush_region = new HObject();//笔刷
        private HObject final_region = new HObject();//需要获得的区域
        public Form1()
        {
            InitializeComponent();
            hv_WindowHandle = hWindow_Final1.hControl.HalconWindow;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button7.BackColor = Color.Blue;
        }


        /// <summary>
        /// 设置笔刷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click_1(object sender, EventArgs e)
        {
            string brushType = ((Button)sender).Text;//笔刷类型

            HTuple hv_Row1 = null, hv_Column1 = null, hv_Row2 = null, hv_Column2 = null;
            HObject ho_temp_brush = new HObject();
            try
            {
                //画图模式 开
                hWindow_Final1.DrawModel = true;
                hWindow_Final1.Focus();
                //锁住功能区
                //groupBox_tool.Enabled = false;
                //显示提示
                hWindow_Final1.ClearWindow();
                hWindow_Final1.HobjectToHimage(image);
                ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                ShowTool.SetMsg(hv_WindowHandle, "在窗口画出" + brushType + ",点击右键结束", "window", 20, 20, "red", "false");
                //显示为黄色
                HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                switch (brushType)
                {
                    case "矩形":

                        HOperatorSet.DrawRectangle1(hv_WindowHandle, out hv_Row1, out hv_Column1, out hv_Row2, out hv_Column2);
                        ho_temp_brush.Dispose();
                        HOperatorSet.GenRectangle1(out ho_temp_brush, hv_Row1, hv_Column1, hv_Row2, hv_Column2);
                        if (hv_Row1.D != 0)
                        {
                            brush_region.Dispose();
                            brush_region = ho_temp_brush;
                        }
                        else
                        {
                            hWindow_Final1.HobjectToHimage(image);
                            ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                            ShowTool.SetMsg(hv_WindowHandle, "未画出有效区域", "window", 20, 20, "red", "false");
                            return;
                        }
                        break;
                    case "矩形1":
                        HOperatorSet.DrawRectangle2(hv_WindowHandle, out hv_Row1, out hv_Column1, out HTuple phi, out HTuple lenght1, out HTuple length2);
                        ho_temp_brush.Dispose();
                        HOperatorSet.GenRectangle2(out ho_temp_brush, hv_Row1, hv_Column1, phi, lenght1, length2);
                        if (hv_Row1.D != 0)
                        {
                            brush_region.Dispose();
                            templateRegion = ho_temp_brush;
                        }
                        else
                        {
                            hWindow_Final1.HobjectToHimage(image);
                            ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                            ShowTool.SetMsg(hv_WindowHandle, "未画出有效区域", "window", 20, 20, "red", "false");
                            return;
                        }
                        break;
                    case "圆":
                        HOperatorSet.DrawCircle(hv_WindowHandle, out hv_Row1, out hv_Column1, out HTuple radius);
                        ho_temp_brush.Dispose();
                        HOperatorSet.GenCircle(out ho_temp_brush, hv_Row1, hv_Column1, radius);
                        //
                        if (hv_Row1.D != 0)
                        {
                            brush_region.Dispose();
                            brush_region = ho_temp_brush;
                        }
                        else
                        {
                            hWindow_Final1.HobjectToHimage(image);
                            ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                            ShowTool.SetMsg(hv_WindowHandle, "未画出有效区域", "window", 20, 20, "red", "false");
                            return;
                        }

                        break;
                    default:
                        MessageBox.Show("错误指令");
                        return;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                hWindow_Final1.HobjectToHimage(image);
                ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                ShowTool.SetMsg(hv_WindowHandle, brushType + " 笔刷创建成果", "window", 20, 20, "red", "false");
                hWindow_Final1.DispObj(ho_temp_brush, "yellow");
                hWindow_Final1.DrawModel = false;
                //解锁功能区
                //groupBox_tool.Enabled = true;
            }
        }
        /// <summary>
        /// 擦除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button81_Click(object sender, EventArgs e)
        {
            hv_WindowHandle.SetDraw("fill");
            string actionType = ((Button)sender).Name;// 画区域 或者 擦除
            hWindow_Final1.DrawModel = true;
            hWindow_Final1.Focus();
            HTuple hv_Button = null;
            HTuple hv_Row = null, hv_Column = null;
            HTuple areaBrush, rowBrush, columnBrush, homMat2D;


            HObject brush_region_affine = new HObject();
            HObject ho_Image = new HObject(image);
            try
            {
                if (!brush_region.IsInitialized())
                {
                    MessageBox.Show("请先设置笔刷");
                    return;
                }
                else
                {
                    HOperatorSet.AreaCenter(brush_region, out areaBrush, out rowBrush, out columnBrush);
                }

                //显示
                hWindow_Final1.HobjectToHimage(image);
                hWindow_Final1.DispObj(final_region);

                //画出笔刷
                switch (actionType)
                {
                    case "button_draw":
                        HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                        HOperatorSet.DispObj(final_region, hv_WindowHandle);
                        break;
                    case "button_wipe":
                        HOperatorSet.SetColor(hv_WindowHandle, "red");
                        //检查final_region是否有效
                        if (!final_region.IsInitialized())
                        {
                            MessageBox.Show("请先使用画出合适区域,在使用擦除功能");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("设置错误");
                        return;
                }

                #region "循环,等待涂抹"

                //鼠标状态
                hv_Button = 0;
                // 4为鼠标右键
                while (hv_Button != 4)
                {
                    //一直在循环,需要让halcon控件也响应事件,不然到时候跳出循环,之前的事件会一起爆发触发,
                    Application.DoEvents();

                    hv_Row = -1;
                    hv_Column = -1;

                    //获取鼠标坐标
                    try
                    {
                        HOperatorSet.GetMposition(hv_WindowHandle, out hv_Row, out hv_Column, out hv_Button);
                    }
                    catch (HalconException ex)
                    {
                        hv_Button = 0;
                    }


                    HOperatorSet.SetSystem("flush_graphic", "false");
                    HOperatorSet.DispObj(ho_Image, hv_WindowHandle);
                    if (final_region.IsInitialized())
                    {
                        //hv_WindowHandle.SetRgba(255, 0, 0, 120);
                        HOperatorSet.DispObj(final_region, hv_WindowHandle);
                    }


                    //check if mouse cursor is over window
                    if (hv_Row >= 0 && hv_Column >= 0)
                    {
                        //放射变换
                        HOperatorSet.VectorAngleToRigid(rowBrush, columnBrush, 0, hv_Row, hv_Column, 0, out homMat2D);
                        brush_region_affine.Dispose();
                        HOperatorSet.AffineTransRegion(brush_region, out brush_region_affine, homMat2D, "nearest_neighbor");
                        //hv_WindowHandle.SetRgba(255, 0, 0, 120);
                        HOperatorSet.DispObj(brush_region_affine, hv_WindowHandle);

                        HOperatorSet.SetSystem("flush_graphic", "true");
                        ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                        ShowTool.SetMsg(hv_WindowHandle, "按下鼠标左键涂画,右键结束", "window", 20, 40, "red", "false");

                        //1为鼠标左键
                        if (hv_Button == 1)
                        {

                            //画出笔刷
                            switch (actionType)
                            {
                                case "button_draw":
                                    {
                                        if (final_region.IsInitialized())
                                        {
                                            HObject ExpTmpOutVar_0;
                                            HOperatorSet.Union2(final_region, brush_region_affine, out ExpTmpOutVar_0);
                                            final_region.Dispose();
                                            final_region = ExpTmpOutVar_0;
                                        }
                                        else
                                        {
                                            final_region = new HObject(brush_region_affine);
                                        }

                                    }
                                    break;
                                case "button_wipe":
                                    {
                                        HObject ExpTmpOutVar_0;
                                        HOperatorSet.Difference(final_region, brush_region_affine, out ExpTmpOutVar_0);
                                        final_region.Dispose();
                                        final_region = ExpTmpOutVar_0;
                                    }
                                    break;
                                default:
                                    MessageBox.Show("设置错误");
                                    return;
                            }//end switch

                        }//end if
                    }
                    else
                    {
                        ShowTool.SetFont(hv_WindowHandle, 20, "mono", new HTuple("true"), new HTuple("false"));
                        ShowTool.SetMsg(hv_WindowHandle, "请将鼠标移动到窗口内部", "window", 20, 20, "red", "false");
                    }


                }//end while
                #endregion
            }
            catch (HalconException HDevExpDefaultException)
            {
                //throw HDevExpDefaultException;
            }
            finally
            {
                hWindow_Final1.HobjectToHimage(image);
                hWindow_Final1.DispObj(final_region, "blue");
                //hv_WindowHandle.SetRgba(255, 0, 0, 120);
                HOperatorSet.SetRgba(hWindow_Final1.hControl.HalconWindow, 255, 0, 0, 120);
                hWindow_Final1.DrawModel = false;
            }

        }



        private void button8_Click(object sender, EventArgs e)
        {
            actionType = "B";
            Work(null);
        }
        string actionType = "A";

            bool drawMode = true;

        HObject templateRegion;
        internal void Work(object sender)
        {
            try
            {
                 //actionType = ((RadioButton)sender).Name;// 画区域 或者 擦除
                hWindow_Final1.ContextMenuStrip = null;
                hWindow_Final1.DrawModel = true;
                hWindow_Final1.Focus();
                //////groupBox_tool.Enabled = false;

                HTuple hv_Button = null;
                HTuple hv_Row = null, hv_Column = null;
                HTuple homMat2D;


                HObject brush_region_affine = new HObject();
                HObject ho_Image = new HObject(image);
                try
                {
                    if (!brush_region.IsInitialized())
                    {
                        MessageBox.Show("请先设置笔刷");
                        return;
                    }
                    //显示
                    HOperatorSet.AreaCenter(brush_region, out HTuple areaBrush, out HTuple rowBrush, out HTuple columnBrush);
                    HOperatorSet.SmallestRectangle1(templateRegion, out HTuple row1, out HTuple col1, out HTuple row2, out HTuple col2);
                    HOperatorSet.GenRectangle1(out HObject outRectangle1, row1 - 20, col1 - 20, row2 + 20, col2 + 20);
                    int size = ((row2 - row1) + (col2 - col1)) / 2;
                    HWindowControl temp = new HWindowControl();
                    HOperatorSet.GetImageSize(ho_Image, out HTuple w, out HTuple h);
                    HOperatorSet.SetWindowExtents(temp.HalconWindow, 0, 0, w, h);
                    HOperatorSet.SetPart(temp.HalconWindow, 0, 0, h - 1, w - 1);
                    HOperatorSet.ClearWindow(temp.HalconWindow);
                    HOperatorSet.DispObj(ho_Image, temp.HalconWindow);
                    HOperatorSet.SetLineStyle(temp.HalconWindow, new HTuple());
                    HOperatorSet.SetColor(temp.HalconWindow, "green");
                    if (size < 200)
                        HOperatorSet.SetLineWidth(temp.HalconWindow, 1);
                    else
                        HOperatorSet.SetLineWidth(temp.HalconWindow, 2);
                    //HOperatorSet.DispObj(contour, temp.HalconWindow);
                    HOperatorSet.DumpWindowImage(out HObject image, temp.HalconWindow);
                    HOperatorSet.ClearWindow(hv_WindowHandle);
                    HOperatorSet.DispObj(image, hv_WindowHandle);
                    hWindow_Final1.HobjectToHimage(image);
                    ho_Image = new HObject(image);
                    HOperatorSet.ReduceDomain(image, outRectangle1, out HObject imageReduced);
                    hWindow_Final1.ClearWindow();
                    HOperatorSet.SetPart(hv_WindowHandle, row1 - 20, col1 - 20, row2 + 20, col2 + 20);
                    HOperatorSet.DispObj(imageReduced, hv_WindowHandle);
                    Application.DoEvents();
                    try
                    {
                        HObject resultImage = new HObject();
                        HOperatorSet.PaintRegion(final_region, imageReduced, out HObject image1, 10, "fill");
                        HOperatorSet.Compose3(imageReduced, image1, image1, out resultImage);
                        HOperatorSet.DispObj(resultImage, hv_WindowHandle);
                        HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                        HOperatorSet.DispObj(final_region, hv_WindowHandle);
                    }
                    catch { }
                    Application.DoEvents();
                    //画出笔刷
                    switch (actionType)
                    {
                        case "A":
                            HOperatorSet.SetColor(hv_WindowHandle, "blue");
                            break;
                        case "B":
                            HOperatorSet.SetColor(hv_WindowHandle, "red");
                            //检查final_region是否有效
                            if (!final_region.IsInitialized())
                            {
                                MessageBox.Show("请先使用画出合适区域,在使用擦除功能");
                                return;
                            }
                            break;
                        default:
                            MessageBox.Show("设置错误");
                            return;
                    }
                    #region "循环,等待涂抹"

                    //鼠标状态
                    hv_Button = 0;
                    // 4为鼠标右键
                    while (drawMode)
                    {
                        //一直在循环,需要让halcon控件也响应事件,不然到时候跳出循环,之前的事件会一起爆发触发,
                        Application.DoEvents();
                        hv_Row = -1;
                        hv_Column = -1;
                        //获取鼠标坐标
                        try
                        {
                            HOperatorSet.GetMposition(hv_WindowHandle, out hv_Row, out hv_Column, out hv_Button);
                        }
                        catch (HalconException ex)
                        {
                            try
                            {
                                hv_Button = 0;
                                HOperatorSet.DispObj(image, hv_WindowHandle);
                                HOperatorSet.DispObj(final_region, hv_WindowHandle);
                                HObject resultImage = new HObject();
                                HOperatorSet.Decompose3(image, out HObject iamgeR, out HObject iamgeG, out HObject iamgeB);
                                HOperatorSet.PaintRegion(final_region, iamgeR, out HObject image1, 20, "fill");
                                HOperatorSet.Compose3(imageReduced, iamgeG, image1, out resultImage);
                                HOperatorSet.SetPart(hv_WindowHandle, row1 - 20, col1 - 20, row2 + 20, col2 + 20);
                                HOperatorSet.DispObj(resultImage, hv_WindowHandle);
                                HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                                HOperatorSet.DispObj(final_region, hv_WindowHandle);
                                ShowTool.SetMsg(hv_WindowHandle, "涂抹结束后请重新学习", "window", 20, 20, "blue", "false");
                            }
                            catch
                            { }
                        }
                        HOperatorSet.SetSystem("flush_graphic", "false");
                        HOperatorSet.DispObj(ho_Image, hv_WindowHandle);
                        if (final_region.IsInitialized())
                        {
                            try
                            {
                                HObject resultImage = new HObject();
                                HOperatorSet.Decompose3(image, out HObject iamgeR, out HObject iamgeG, out HObject iamgeB);
                                HOperatorSet.PaintRegion(final_region, iamgeR, out HObject image1, 20, "fill");
                                HOperatorSet.Compose3(imageReduced, iamgeG, image1, out resultImage);
                                HOperatorSet.SetPart(hv_WindowHandle, row1 - 20, col1 - 20, row2 + 20, col2 + 20);
                                HOperatorSet.DispObj(resultImage, hv_WindowHandle);
                                HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                                HOperatorSet.DispObj(final_region, hv_WindowHandle);
                            }
                            catch { }
                        }
                        //check if mouse cursor is over window
                        if (hv_Row >= 0 && hv_Column >= 0)
                        {
                            //放射变换
                            HOperatorSet.VectorAngleToRigid(rowBrush, columnBrush, 0, hv_Row, hv_Column, 0, out homMat2D);
                            brush_region_affine.Dispose();
                            HOperatorSet.AffineTransRegion(brush_region, out brush_region_affine, homMat2D, "nearest_neighbor");
                            HOperatorSet.SetColor(hv_WindowHandle, "yellow");
                            HOperatorSet.SetLineStyle(hv_WindowHandle, new HTuple());
                            HOperatorSet.DispObj(brush_region_affine, hv_WindowHandle);
                            HOperatorSet.SetSystem("flush_graphic", "true");
                            ShowTool.SetFont(hv_WindowHandle, 15, "sans", new HTuple("true"), new HTuple("false"));
                            ShowTool.SetMsg(hv_WindowHandle, "按下鼠标左键开始涂抹", "window", 20, 20, "blue", "false");
                            //1为鼠标左键
                            if (hv_Button == 1)
                            {
                                //画出笔刷
                                switch (actionType)
                                {
                                    case "A":
                                        {
                                            if (final_region.IsInitialized())
                                            {
                                                HOperatorSet.Union2(final_region, brush_region_affine, out HObject ExpTmpOutVar_0);
                                                final_region.Dispose();
                                                final_region = ExpTmpOutVar_0;
                                            }
                                            else
                                            {
                                                final_region = new HObject(brush_region_affine);
                                            }
                                        }
                                        break;
                                    case "B":
                                        {
                                            HOperatorSet.Difference(final_region, brush_region_affine, out HObject ExpTmpOutVar_0);
                                            final_region.Dispose();
                                            final_region = ExpTmpOutVar_0;
                                        }
                                        break;
                                    default:
                                        MessageBox.Show("设置错误");
                                        return;
                                }//end switch

                            }//end if
                        }
                        else
                        {
                           ShowTool.SetFont(hv_WindowHandle, 15, "sans", new HTuple("true"), new HTuple("false"));
                            ShowTool.SetMsg(hv_WindowHandle, "请将鼠标移动到窗口内部", "window", 20, 20, "blue", "false");
                        }
                    }//end while
                    #endregion
                }
                catch (HalconException HDevExpDefaultException)
                {
                    throw HDevExpDefaultException;
                }
                finally
                {
                    hWindow_Final1.DispObj(final_region, "blue");
                    hWindow_Final1.DrawModel = false;
                }
            }
            catch (Exception ex)
            {
             
            }
        }





        private void button0_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog fd = new VistaFolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.SelectedPath;
                textBox1.Text = path;
                DirectoryInfo di = new DirectoryInfo(path);
                m_FileList = di.GetFiles();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ++num_;
            if (num_ < 100)
            {

                if (index >= m_FileList.Length)
                    index = 0;
                string ext = Path.GetExtension(m_FileList[index].Name).ToUpper();
                string sFullName = m_FileList[index].FullName;
                index++;
                //判断当前文件后缀名是否与给定后缀名一样
                if (ext == ".HE" || ext == ".BMP" || ext == ".JPG" || ext == ".PNG" || ext == ".TIFF")
                {
                    if (File.Exists(sFullName))
                    {

                        HOperatorSet.ReadImage(out image, sFullName);
                        hWindow_Final1.HobjectToHimage(image);

                        //mWindowH.Image = RImage.ReadImageExt(sFullName);
                        //image = RImage.ReadImageExt(sFullName);
                    }

                }

            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //hWindow_Final1.WindowH.genCircleArr(20.0, 20.0, 20.0, ref m_RegionsList);
            //m_RegionsList.Last().Color = button7.BackColor.Name.ToLower();
            //binDataGridView(dgv_ROI, m_RegionsList);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string m_Color = RColor.ToHexColor(button7.BackColor);
            switch (button.Text)
            {

                case "圆":
                    hWindow_Final1.WindowH.genCircle("Circle", 200.0, 200.0, 60.0, ref m_RegionsList);
                    binDataGridView(dgv_ROI, m_RegionsList);
                    break;
                case "线":
                    hWindow_Final1.WindowH.genLine("Line", 100.0, 100.0, 100.0, 200.0, ref m_RegionsList);
                    binDataGridView(dgv_ROI, m_RegionsList);
                    break;
                case "矩形":
                    hWindow_Final1.WindowH.genRect1("Rect1", 110.0, 110.0, 210.0, 210.0, ref m_RegionsList);
                    binDataGridView(dgv_ROI, m_RegionsList);
                    break;
                case "旋转矩形":
                    hWindow_Final1.WindowH.genRect2("ect2", 200.0, 200.0, 0.0, 60.0, 30.0, ref m_RegionsList);
                    binDataGridView(dgv_ROI, m_RegionsList);
                    break;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //hWindow_Final1.WindowH.removeActiveROI(ref this.m_RegionsList);
            //binDataGridView(this.dgv_ROI, this.m_RegionsList);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true; //是否显示ColorDialog有半部分
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)//确定事件响应
            {
                button7.BackColor = colorDialog.Color;
            }
        }
        void binDataGridView(DataGridView dgv, Dictionary<string, ROI> config)
        {
            try
            {

                dgv.DataSource = null;

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "Type";
                column1.HeaderText = "类型";
                column1.Name = "Type";
                column1.Width = 90;
                column1.ReadOnly = true;

                dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { column1 });
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.AllowUserToDeleteRows = true;
                dgv.AllowUserToAddRows = false;
                dgv.MultiSelect = false;
                dgv.AllowUserToAddRows = false;//禁止添加行
                dgv.AllowUserToDeleteRows = true;//禁止删除行
                //dgv.ContextMenuStrip = contextMenuStrip;
                dgv.DataSource = config;
                dgv.Refresh();
                if (config.Count > 0)
                {
                    dgv.Rows[config.Count - 1].Cells[0].Selected = true;
                }


            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// 将roi和DataGridView关联显示
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="config"></param>
        private void dgv_ROI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index;
            //string name = "";
            //List<double> data;

            //hWindow_Final1.WindowH.selectROI(e.RowIndex);
            //ROI roi = hWindow_Final1.WindowH.smallestActiveROI(out data, out index);

            //if (index > -1)
            //{
            //    //name = roi.GetType().Name;
            //}

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
