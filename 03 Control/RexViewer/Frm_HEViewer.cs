using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RexConst;
using RexView.jig;
using System.IO;
using System.Diagnostics;
using System.Threading;
using RexView;

namespace RexView
{
    public partial class Frm_HEViewer : Form
    {
        /// <summary>
        /// 当前窗口中的he
        /// </summary>
        private RImage m_HImageExt = new RImage();
        /// <summary>
        /// 显示在窗体中的roi
        /// </summary>
        private List<HRoi> ROIlist = new List<HRoi>();
        /// <summary>
        /// 显示模式
        /// </summary>
        private enShowModel showModel = enShowModel.显示效果图;
        /// <summary>
        /// 是否是在线模式
        /// </summary>
        private bool onLineFlag = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_onLineFlag">是否在线模式</param>
        public Frm_HEViewer(bool _onLineFlag)
        {
            InitializeComponent();

            if (_onLineFlag)
            {
                setOnLine();
            }
        }

        #region "在线模式"
        /// <summary>
        /// 如果是在线显示,则屏蔽某些按钮,并重新绑定某些事件
        /// </summary>
        public void setOnLine()
        {
            onLineFlag = true;
            panel_selectfile.Enabled = false;
            panel_export.Enabled = false;
            //在线模式不允许最小化 否则会报错 magical 20171030
            this.MinimizeBox = false;
        }

        /// <summary>
        /// 当前he容器
        /// </summary>
        private Dictionary<string, RImage> heDic = new Dictionary<string, RImage>();

        /// <summary>
        /// 插入需要显示的he
        /// </summary>
        public void insertHE(string name, RImage he)
        {
            try
            {
                if (this.Visible == false)
                {
                    return;
                }
              

                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        //释放要放在主线程  否则可能出现多线程图像变量读取异常 yoga 2017-9-4 10:05:08
                        //如果存在,则释放
                        if (heDic.Keys.Contains(name))
                        {
                           // heDic[name].Dispose();
                        }
                        heDic[name] = he;

                        //如果当前列表中选中的是一样的变量名称,则刷新
                        if (name.Equals(listBox_fileName.Text))
                        {
                          //  m_HImageExt.Dispose();
                            m_HImageExt = he;
                            showHeByShowModel();
                        }

                        //不存在则更新listbox
                        if (!listBox_fileName.Items.Contains(name))
                        {
                            //放在后面,会触发listBox_fileName_SelectedIndexChanged事件,所以会显示图片
                            listBox_fileName.DataSource = heDic.Keys.ToList();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /// <summary>
        /// 显示模式切换 原图 /效果图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Click(object sender, EventArgs e)
        {
            string str = ((RadioButton)sender).Text;

            switch (str)
            {
                case "只显示原图":
                    showModel = enShowModel.只显示原图;
                    break;
                case "显示效果图":
                    showModel = enShowModel.显示效果图;
                    break;
                case "显示检测范围":
                    showModel = enShowModel.显示检测范围;
                    break;
                case "显示检测点":
                    showModel = enShowModel.显示检测点;
                    break;
                case "显示检测结果":
                    showModel = enShowModel.显示检测结果;
                    break;
                case "显示搜索范围":
                    showModel = enShowModel.显示搜索范围;
                    break;
                default:
                    break;
            }
            showHeByShowModel();
        }

        private bool fitImageFlag = false;//只在第一次显示图片的时候自适应窗口

        /// <summary>
        /// 根据显示模式显示图片
        /// </summary>
        public void showHeByShowModel()
        {
            hWindowHE1.HobjectToHimage(m_HImageExt);

            switch (showModel.ToString())
            {
                case "只显示原图":
                    showModel = enShowModel.只显示原图;
                    ROIlist.Clear();
                    break;
                case "显示效果图":
                    showModel = enShowModel.显示效果图;
                    ROIlist = m_HImageExt.mHRoi.ToList();//此处一定要使用toList
                    hWindowHE1.ShowHImage(m_HImageExt);
                    break;
                case "显示检测范围":
                    showModel = enShowModel.显示检测范围;
                    ROIlist = m_HImageExt.mHRoi.Where(c => HRoiType.检测范围 == c.roiType).ToList();//此处一定要使用toList
                    break;
                case "显示检测点":
                    showModel = enShowModel.显示检测点;
                    ROIlist = m_HImageExt.mHRoi.Where(c => HRoiType.检测点 == c.roiType).ToList();//此处一定要使用toList
                    break;
                case "显示检测结果":
                    showModel = enShowModel.显示检测结果;
                    ROIlist = m_HImageExt.mHRoi.Where(c => HRoiType.检测结果== c.roiType).ToList();//此处一定要使用toList
                    break;
                case "显示搜索范围":
                    showModel = enShowModel.显示搜索范围;
                    ROIlist = m_HImageExt.mHRoi.Where(c => HRoiType.搜索范围 == c.roiType).ToList();//此处一定要使用toList
                    break;
                default:
                    break;
            }

            //显示roi
            foreach (HRoi item in ROIlist)
            {
                hWindowHE1.DispObj(item.hobject, item.drawColor);
            }

            //第一次自适应窗体
            if (fitImageFlag == false)
            {
                hWindowHE1.WindowH.ResetWindowImage();
                fitImageFlag = true;
            }
        }

        /// <summary>
        /// 单击  dataGridView_roi 显示指定的轮廓
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_roi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (he == null)
            //{
            //    return;
            //}
            try
            {
                if (e.RowIndex != -1)
                {
                    HRoi tempROi = m_HImageExt.mHRoi[e.RowIndex];

                    if (ROIlist.Contains(tempROi))
                    {
                        ROIlist.Remove(tempROi);//删除roi
                    }
                    else
                    {
                        ROIlist.Add(m_HImageExt.mHRoi[e.RowIndex]);//显示roi
                    }

                    //显示原图
                    hWindowHE1.HobjectToHimage(m_HImageExt);

                    //显示roi
                    foreach (HRoi item in ROIlist)
                    {
                        hWindowHE1.DispObj(item.hobject, item.drawColor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static string[] fileNameArr = new string[] { };//文件名称数组
        /// <summary>
        /// 选择要打开的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_openFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文件夹";
                dialog.Filter = "he文件(*.he)|*.he";
                dialog.ShowDialog();
                fileNameArr = dialog.FileNames;

                //短名称
                List<string> tempList = new List<string>();
                foreach (string fileName in dialog.FileNames)
                {
                    tempList.Add(Path.GetFileName(fileName));
                }
                //现在短名称
                listBox_fileName.DataSource = tempList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_openFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择文件路径";


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string foldPath = dialog.SelectedPath;
                    DirectoryInfo theFolder = new DirectoryInfo(foldPath);

                    //短名称   
                    FileInfo[] dirInfo = theFolder.GetFiles();
                    List<string> tempNameList = new List<string>();
                    List<string> tempPathList = new List<string>();
                    //遍历文件夹  
                    foreach (FileInfo file in dirInfo)
                    {
                        if (".he".Equals(Path.GetExtension(file.FullName)))
                        {
                            tempNameList.Add(file.ToString());
                            tempPathList.Add(file.FullName);
                        }
                    }
                    //短名称
                    fileNameArr = tempPathList.ToArray();//这个要在前面
                    listBox_fileName.DataSource = tempNameList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 打开指定的he
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_fileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox_fileName.SelectedIndex != -1)
                {
                    if (m_HImageExt != null)
                      //  m_HImageExt.Dispose();

                    if (onLineFlag)
                    {
                        m_HImageExt = heDic[listBox_fileName.Text].Clone();
                    }
                    else
                    {//离线模式
                        m_HImageExt = SerialTool.FromBinary<RImage>(fileNameArr[listBox_fileName.SelectedIndex]);
                    }

                    if (m_HImageExt != null)
                    {
                        //自适应窗口
                        fitImageFlag = false;
                        showHeByShowModel();
                        dataGridView_roi.DataSource = m_HImageExt.mHRoi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 导出图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_export_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;

                //设置进度条最大长度
                ProgressBarForm pbox_Icon = new ProgressBarForm();
                pbox_Icon.setMax(fileNameArr.Length);
              
                ThreadPool.QueueUserWorkItem(o =>
                {
                    Thread.Sleep(500);//故意停 ,否则下面的线程会在窗口弹出前就执行了
                    for (int i = 0; i < fileNameArr.Length; i++)
                    {
                        pbox_Icon.setValue(i);

                        RImage tempHE = SerialTool.FromBinary<RImage>(fileNameArr[i]);
                        //   MessageBox.Show(scaleSize.ToString());
                        int width, height;
                        tempHE.GetImageSize(out width, out height);

                        //保存图片
                        saveWindowDumpByPng(tempHE, foldPath + "/" + Path.GetFileName(fileNameArr[i]).Split('.')[0], new Size((int)(width * scaleSize), (int)(height * scaleSize)));

                        //
                        tempHE.Dispose();
                    }

                    pbox_Icon.BeginInvoke(new Action(() =>
                    {
                        pbox_Icon.Close();
                    }));
                });

                if (pbox_Icon.IsDisposed == false)
                {
                    pbox_Icon.ShowDialog();
                }

                Process.Start("explorer.exe", foldPath);
            }
        }

        private double scaleSize = 1;
        /// <summary>
        /// 调节导出图片尺寸大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_Click(object sender, EventArgs e)
        {
            scaleSize = double.Parse(((RadioButton)sender).Text);
        }

        /// <summary>
        /// 保存结果至特定分辨率的图像文件
        /// </summary>
        /// <param name="fileName">图像文件路径</param>
        /// <param name="size">图像分辨率</param>
        public void saveWindowDumpByPng(RImage tempHE, string fileName, Size size)
        {
            try
            {
                TimeTool.startTime("创建tempHWindow_HE");
                HWindow_HE tempHWindow_HE = new HWindow_HE();
                TimeTool.stopTime("创建tempHWindow_HE");

                TimeTool.startTime("显示");
                tempHWindow_HE.Size = size;
                if (showModel == enShowModel.只显示原图)
                {
                    tempHWindow_HE.HobjectToHimage(tempHE);
                }
                else if (showModel == enShowModel.显示效果图)
                {
                    tempHWindow_HE.ShowHImage(tempHE);
                }
                TimeTool.stopTime("显示");

                TimeTool.startTime("存图");
                //tempHWindow_HE.SaveWindowDump(fileName);
                TimeTool.stopTime("存图");
                tempHWindow_HE.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 如果是在线模式,则不关闭,只隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_HEViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (onLineFlag)
            //{
            //    this.Visible = false;
            //    e.Cancel = true;
            //}
        }

        /// <summary>
        /// 导出点云窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_export_cloud_Click(object sender, EventArgs e)
        {
            Frm_PointCloud frmPointCloud = new Frm_PointCloud();
            frmPointCloud.ShowDialog();
        }
    }
}
