using EasyVision.Common.EVStruct;
using EasyVision.Common.Helper;
using EasyVision.Common.Log4Net;
using EasyVision.EVControl.Properties;
using EasyVision.Service.Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVision.EVControl.EVForms
{
    /// <summary>
    /// 单元类型
    /// </summary>
    public enum UnitType
    {
        /// <summary>
        ///模块
        /// </summary>
        Module,
        /// <summary>
        /// 模块文件夹
        /// </summary>
        Folder,
        /// <summary>
        /// 空白模块,占位用
        /// </summary>
        Empty

    }
    /// <summary>
    /// 鼠标当前区域
    /// </summary>
    public enum CheckArea
    {
        /// <summary>
        /// 空白区域
        /// </summary>
        Space,
        /// <summary>
        /// 模块图标
        /// </summary>
        Icon,
        /// <summary>
        /// 多选框
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 注释
        /// </summary>
        Remarks
    }
    /// <summary>
    /// 流程的一个单元数据
    /// </summary>
    public class ModuleFlowItem : TreeNode
    {

        private static List<string> list_item_deftitle;
        /// <summary>
        /// 对象识别ID集合,模块类型名称
        /// </summary>
        private static List<string> m_ItemIdentList;

        private static Bitmap m_FolderIconClose;
        private static Bitmap m_FolderIconOpen;

        private ModuleInfo m_ModuleInfo;
        public EasyVision.Common.EVStruct.ModuleInfo ModuleInfo
        {
            get { return m_ModuleInfo; }
        }
        //private static ImageList imglist;
        private static Dictionary<string, Icon> m_ImageIconDic;
        private bool m_Checked;
        /// <summary>
        /// 是否模块可选择
        /// </summary>
        internal static bool m_Checkable = false;
        internal bool Click;
        internal static int ControlWidth = 120;

        internal static bool dragList = false;
        internal static bool dragInNew = false;
        /// <summary>
        /// 拖拽目标位置的UnitNo
        /// </summary>
        internal static int m_DragToUnitNo = -1;
        /// <summary>
        /// 拖拽目标位置的UnitNo
        /// </summary>
        internal static int m_DragFromUnitNo = -1;
        internal static int FlowHeight = 0;
        internal static bool m_IsNext;
        private int height;

        private static int loadPointNum = 1;//模块运行的时候 显示的点数

        public const string Plugin_FolderEnd_Name = "FolderEnd";

        /// <summary>
        /// 结果判定 如果ok>0 ng<0
        /// </summary>
        private int judge;
        internal static bool judgeEnabled = true;
        public int last_unitno;
        private int left_pos;

        private bool select;
        private Color subtextcolor;

        private int top_pos;
        private int m_ModuleNo;
        private UnitType m_UnitType;
        private int width;


        private Point m_RemarksPoint;//注释的左上点
        public System.Drawing.Point RemarksPoint
        {
            get { return m_RemarksPoint; }
        }
        public bool Disabled
        {
            get
            {
                return !this.ModuleInfo.IsUse;
            }

        }
        public ModuleFlowItem(ModuleInfo info, int _ModulenNo) : base(info.ModuleName)
        {
            this.subtextcolor = Color.Gray;
            this.top_pos = -1;
            this.left_pos = -1;
            this.m_ModuleNo = -1;

            this.m_ModuleNo = _ModulenNo;
            this.m_ModuleInfo = info;

            if (Regex.IsMatch(info.ModuleName, "文件夹[0-9]*$") || info.ModuleName.StartsWith("如果") || info.ModuleName.StartsWith("否则"))
            {
                this.m_UnitType = UnitType.Folder;
            }
            else if (info.PluginName == Plugin_FolderEnd_Name)
            {
                this.m_UnitType = UnitType.Empty;
            }
            else
            {
                this.m_UnitType = UnitType.Module;
            }
            if (m_ImageIconDic == null)
            {
                this.MakeProcUnitList();//这一句必须放在前面 不然会出现折叠的时候只显示 -  ,具体原因不明 magical 20181018 
                m_ImageIconDic = new Dictionary<string, Icon>();
            }
            if (m_ImageIconDic.ContainsKey(ModuleInfo.PluginName) == false)
            {
                GetModelIcon(ModuleInfo.PluginName);
            }

        }
        /// <summary>
        /// 获取模块图标
        /// </summary>
        /// <param name="ident"></param>
        public void GetModelIcon(string ident)
        {
            if (PluginsManger.m_PluginInfoDic.ContainsKey(ident))
            {
                Icon icon = PluginsManger.m_PluginInfoDic[ident].IconImage;
                if (icon != null)
                {
                    m_ImageIconDic.Add(ident, icon);
                }
            }

        }
        /// <summary>
        /// 画出结果图标
        /// </summary>
        /// <param name="g"></param>
        /// <param name="top"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        private void DrawJudge(Graphics g, int top, Pen pen, SolidBrush brush)
        {
            if (this.ModuleInfo.PluginName != "")
            {

                brush.Color = Color.Black;
                int x = ControlWidth - this.height - this.height / 8;

                int y = top + (this.height / 4);
                pen.Width = 2.5f;

                if (this.Disabled == false)
                {
                    //画出判断符号

                    switch (this.ModuleInfo.State)
                    {
                        case ModuleState.None:
                            break;
                        case ModuleState.OK:
                            pen.Color = Color.Green;

                            g.DrawLine(pen, (int)(x + (this.height / 4)), (int)((y + (this.height / 4)) + (this.height / 4)), (int)(x + (this.height / 8)), (int)(y + (this.height / 4)));
                            g.DrawLine(pen, (int)(x + (this.height / 4)), (int)((y + (this.height / 4)) + (this.height / 4)), (int)((x + (this.height / 2))), (int)(y + (this.height / 8)));
                            break;
                        case ModuleState.NG:
                            pen.Color = Color.Red;
                            g.DrawLine(pen, (int)(x + (this.height / 8)), (int)((y + (this.height / 8))), (int)(x + (this.height / 2)), (int)(y + (this.height / 2)));
                            g.DrawLine(pen, (int)(x + (this.height / 8)), (int)((y + (this.height / 2))), (int)((x + (this.height / 2))), (int)(y + (this.height / 8)));
                            break;
                        case ModuleState.Start:
                            if (EVSolution.GetCurProjectState(false))
                            {
                                Brush bg = new SolidBrush(Color.DarkOrange);//声明的画刷
                                for (int i = 0; i < loadPointNum; i++)
                                {
                                    g.FillEllipse(bg, x + i * 3, y + this.height / 4, 3, 3);
                                }
                                loadPointNum++;
                                if (loadPointNum > 8)
                                {
                                    loadPointNum = 1;
                                }

                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    g.DrawImage(Resources.unuse, new Rectangle(x + 2, y, 20, 20), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);

                }

                //还原
                pen.Color = Color.Black;
                pen.Width = 1f;
            }
        }

        private void DrawCheckBox(Graphics g, int top, Pen pen, SolidBrush brush)
        {
            if (this.ModuleInfo.PluginName != "")
            {
                brush.Color = Color.Black;
                int x = ControlWidth - this.height * 2;
                int y = top + (this.height / 4);
                g.FillRectangle(brush, x, y, this.height / 2, this.height / 2);
                brush.Color = Color.White;
                g.FillRectangle(brush, (int)(x + 2), (int)(y + 2), (int)((this.height / 2) - 4), (int)((this.height / 2) - 4));
                if (this.m_Checked)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                    g.DrawLine(pen, (int)(x + (this.height / 8)), (int)((y + (this.height / 4)) + (this.height / 8)), (int)(x + (this.height / 8)), (int)(y + (this.height / 4)));
                    g.DrawLine(pen, (int)(x + (this.height / 8)), (int)((y + (this.height / 4)) + (this.height / 8)), (int)((x + (this.height / 4)) + (this.height / 8)), (int)(y + (this.height / 8)));
                }
                pen.Color = Color.Black;
                pen.Width = 1f;
            }
        }

        public new void Expand()
        {
            this.Expand(true);
        }

        internal void Expand(bool setUnit)
        {
            base.Expand();
        }
        /// <summary>
        /// 检查鼠标的位置,并返回状态
        /// </summary>
        /// <param name="e">鼠标信息</param>
        /// <returns>位置枚举</returns>
        internal CheckArea HitCheck(MouseEventArgs e)
        {
            if (m_Checkable && (e.X > (ControlWidth - this.Height * 2)) && (e.X < (ControlWidth - this.Height * 2 + this.Height / 2.0)))
            {
                return CheckArea.MultiSelect;
            }
            if ((e.X > this.left_pos) && (e.X < (this.left_pos + this.height)))
            {
                return CheckArea.Icon;
            }
            if (m_RemarksPoint.X < e.X && e.X < m_RemarksPoint.X + 90 && m_RemarksPoint.Y - 5 < e.Y && e.Y < m_RemarksPoint.Y + 9 + 5)
            {
                return CheckArea.Remarks;
            }
            return CheckArea.Space;
        }

        /// <summary>
        /// 文件夹折叠图标
        /// </summary>
        private void MakeProcUnitList()
        {
            m_ItemIdentList = new List<string>();
            list_item_deftitle = new List<string>();

            int width = 32;
            int coldif = 4;
            int rowdif = 3;
            m_FolderIconOpen = new Bitmap(width, width);
            m_FolderIconClose = new Bitmap(width, width);
            //画出图标图像  文件打开样式/文件关闭样式 40*40
            using (Graphics g = Graphics.FromImage(m_FolderIconOpen))
            {
                using (Pen pen = new Pen(Color.Gray))
                {
                    pen.Color = Color.DodgerBlue;

                    int tempWidth = (int)(width / 3);
                    //画做左侧连接线
                    g.DrawLine(pen, (int)(width / 4) + tempWidth / 2 - coldif, 0, (int)(width / 4) + tempWidth / 2 - coldif, this.height);

                    //绘制折叠框白色填充
                    g.FillRectangle(new SolidBrush(Color.White),
                        new Rectangle((int)(width / 4) - coldif, (int)(width / 4 + rowdif), tempWidth, tempWidth));

                    pen.Width = 1f;

                    g.DrawLine(pen, (int)(width / 4) - coldif, (int)(width / 4) + rowdif + tempWidth / 2, (int)(width / 4) + tempWidth - coldif, (int)(width / 4) + rowdif + tempWidth / 2);

                    pen.Color = Color.DodgerBlue;
                    //绘制折叠框边框
                    g.DrawRectangle(pen, new Rectangle((int)(width / 4) - coldif, (int)(width / 4) + rowdif, tempWidth, tempWidth));
                }

            }
            using (Graphics g = Graphics.FromImage(m_FolderIconClose))
            {
                using (Pen pen = new Pen(Color.Gray))
                {
                    int tempWidth = (int)(width / 3);
                    //绘制折叠框白色填充
                    g.FillRectangle(new SolidBrush(Color.White),
                        new Rectangle((int)(width / 4) - coldif, (int)(width / 4 + rowdif), tempWidth, tempWidth));
                    pen.Color = Color.DodgerBlue;
                    pen.Width = 1f;

                    g.DrawLine(pen, (int)(width / 4) - coldif, (int)(width / 4) + rowdif + tempWidth / 2, (int)(width / 4) + tempWidth - coldif, (int)(width / 4) + rowdif + tempWidth / 2);
                    g.DrawLine(pen, (int)(width / 4) + tempWidth / 2 - coldif, 0, (int)(width / 4) + tempWidth / 2 - coldif, this.height);
                    pen.Color = Color.DodgerBlue;
                    //绘制折叠框边框
                    g.DrawRectangle(pen, new Rectangle((int)(width / 4) - coldif, (int)(width / 4) + rowdif, tempWidth, tempWidth));
                }
            }
        }


        /// <summary>
        /// 画出一个单元对象
        /// </summary>
        /// <param name="g"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="nest"></param>
        /// <param name="parent_top"></param>
        internal void PaintItem(Graphics g, ref int left, ref int top, int w, int h, int nest, ref int parent_top, bool selected)
        {

            int num = 3 + ((h * 3) / 8);
            int num2 = (int)(h * 0.1);
            this.top_pos = top;
            this.left_pos = (nest * num) + left;
            this.width = w;
            this.height = h;
            selected |= this.IsSelected;

            int num8 = this.Click ? 20 : 20;//偏移量x 改为一样 就没有动画效果  

            if ((top > FlowHeight) || (top < -this.height))//滚动情况
            {
                if ((nest > 0) && ((parent_top < FlowHeight) || (top < this.height)))
                {
                    using (Pen pen = new Pen(Color.Black))
                    {
                        //g.DrawLine(pen, ((this.left_pos - num) + 3) + (this.height / 4), top, ((this.left_pos - num) + 3) + (this.height / 4), (parent_top + this.height) - num2);
                    }
                }
                top += h;
                if (this.m_UnitType == UnitType.Folder)
                {
                    int num3 = parent_top;
                    parent_top = top;
                    if (this.IsExpanded)
                    {
                        foreach (ModuleFlowItem item in base.Nodes)
                        {
                            item.PaintItem(g, ref left, ref top, this.width - num, h, nest + 1, ref parent_top, selected);
                        }
                    }
                    parent_top = num3;
                }
            }
            else
            {
                Font font;
                if (base.TreeView != null)
                {
                    font = base.TreeView.Font;
                }
                else
                {
                    font = new Font("宋体", 11f, FontStyle.Regular);
                }
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    using (Pen pen2 = new Pen(Color.Black))
                    {
                        //-------------------画出顶部分割线
                        pen2.Color = Color.DodgerBlue;

                        //否则 结束 的顶部分割线 靠右一点
                        if (ModuleInfo.ModuleName.StartsWith("否则") || ModuleInfo.ModuleName.StartsWith("结束"))
                        {
                             g.DrawLine(pen2, left + (nest * num) - 4 + 20 - 3 + 17, top, ControlWidth, top);
                        }
                        else
                        {
                             g.DrawLine(pen2, left + (nest * num) - 4 + 20 - 3, top, ControlWidth, top);
                        }

                        //-------------------选中的背景效果 整体填充
                        if (this.IsSelected && !EVSolution.GetCurProjectState(false)) //运行的时候 不再显示选择效果
                        {
                            brush.Color = Color.PeachPuff;
                            g.FillRectangle(brush, this.left_pos + 12, top + 1, this.width, h - 1);
                        }

                        if (this.Disabled == false && EVSolution.GetCurProjectState()) //留运行时的背景色 运行的时候显示
                        {
                            if (this.ModuleInfo.State == ModuleState.Start)
                            {
                                brush.Color = ColorTranslator.FromHtml("#90d7ec");
                                g.FillRectangle(brush, this.left_pos + 12, top + 1, this.width, h - 1);
                            }
                        }
                        else if (this.Disabled == true)
                        {
                            brush.Color = ColorTranslator.FromHtml("#f6f5ec");
                            g.FillRectangle(brush, this.left_pos + 12, top + 1, this.width, h - 1);
                        }

                        brush.Color = Color.Black;
                        //-------------------画出文字 编号.标题 0.图像输入
                         g.DrawString(this.m_ModuleNo.ToString() + "." + this.ModuleInfo.ModuleName, font, brush, (float)((this.left_pos + this.height) + 4 + 20), (float)(top + (h / 4)) - 3);
                        //-------------------画出描述文字 subtext 
                        using (Font font2 = new Font(font.Name, 9f, FontStyle.Regular))
                        {
                            brush.Color = this.subtextcolor;
                            m_RemarksPoint = new Point(((this.left_pos + this.height) + 4) + 20, (top + (h / 2) + (h / 8)));
                             g.DrawString(this.ModuleInfo.ModuleRemarks, font2, brush, m_RemarksPoint.X, m_RemarksPoint.Y);
                            brush.Color = Color.Black;
                        }


                        //最左侧树列表的竖线
                        int num4 = this.top_pos + (this.height / 2);
                        pen2.Color = Color.DodgerBlue;

                        if (nest > 0)//层级大于0 说明在文件夹内
                        {
                            //树列表的横线
                            //g.DrawLine(pen2, this.left_pos-5+ 20-3, num4, ((this.left_pos - num) + 3) + (this.height / 4)+20 + 20 - 3, num4);
                            //树列表的竖线
                            ////  g.DrawLine(pen2, ((this.left_pos - num) ) + (this.height / 4) + 20, num4, ((this.left_pos - num) ) + (this.height / 4) + 20, (parent_top + this.height) - num2+3);
                            if (this.ModuleInfo.ModuleName.Contains("文件夹结束"))
                            {//  先不画
                             //  g.DrawLine(pen2, ((this.left_pos - num)) + (this.height / 4) + 20, this.top_pos, ((this.left_pos - num)) + (this.height / 4) + 20, this.top_pos + this.height / 2);
                            }
                            else
                            {
                                 g.DrawLine(pen2, ((this.left_pos - num)) + (this.height / 4) + 20, this.top_pos, ((this.left_pos - num)) + (this.height / 4) + 20, this.top_pos + this.height);
                            }
                            for (int i = 0; i < nest; i++)
                            {
                                //最左侧树列表的竖线
                                 g.DrawLine(pen2, ((this.left_pos - num) + 3) + (this.height / 4) - i * 17, top, ((this.left_pos - num) + 3) + (this.height / 4) - i * 17, (top + this.height));
                            }


                        }
                        else
                        {
                            //最左侧树列表的竖线
                             g.DrawLine(pen2, ((this.left_pos - num)) + (this.height / 4) + 20, top, ((this.left_pos - num)) + (this.height / 4) + 20, (top + this.height));
                        }
                        //最左侧树列表的竖线 12为固定左边距离
                         g.DrawLine(pen2, 12, top, 12, (top + this.height));

                        //-------------------拖拽插入的效果
                        if ((dragList || dragInNew) && (this.m_ModuleNo == m_DragToUnitNo) && m_DragToUnitNo != m_DragFromUnitNo)
                        {
                            // Debug.WriteLine($"{dragList}||{dragInNew}) && ({this.m_ModuleNo} =={ m_DragToUnitNo})");
                            brush.Color = Color.DodgerBlue;
                            int posYTmp = top + this.height - 1;

                            g.FillRectangle(brush, 0, posYTmp, ControlWidth, 2);
                            brush.Color = Color.Black;
                        }

                        this.DrawJudge(g, top, pen2, brush);


                        switch (m_UnitType)
                        {
                            case EVForms.UnitType.Module:



                                bool drawIcon = true;
                                if (this.ModuleInfo.PluginName == "")
                                {
                                    drawIcon = false;
                                }
                                //-------------------画图标
                                if (drawIcon)
                                {
                                    //-------------------画出图标背景阴影 
                                    brush.Color = Color.Gray;
                                    //g.FillRectangle(brush, (int)((this.left_pos + num2) + 2), (int)((((int)top) + num2) + 2), (int)(this.height - (num2 * 2)), (int)(this.height - (num2 * 2)));
                                    int num5 = 2;
                                    //if (this.Click)
                                    //{
                                    //    num5 = 2;
                                    //    brush.Color = Color.LightSalmon;
                                    //}
                                    //else
                                    //{
                                    //    brush.Color = Color.Red;
                                    //}
                                    //-------------------开始画图标
                                    if (m_ImageIconDic.ContainsKey(ModuleInfo.PluginName))
                                    {
                                        Icon image2 = m_ImageIconDic[ModuleInfo.PluginName];
                                        //-------------------依据判定结果获取图标 
                                        //图标绘制只有一个 已经添加了结果显示图标 √ × 
   
                                        if (ModuleInfo.ModuleName.StartsWith("结束")) { image2 = Resources.end; }

                                        g.DrawIcon(image2, new Rectangle((this.left_pos + num2) + num5 + num8, (top + num2) + num5, this.height - (num2 * 2), this.height - (num2 * 2)));
                                    }
                                    else
                                    {
                                        //-------------------没有图标就用框代替
                                        g.FillRectangle(brush, (int)(this.left_pos + num2) + num8, (int)(((int)top) + num2), (int)(this.height - (num2 * 2)), (int)(this.height - (num2 * 2)));

                                    }
                                    //-------------------画多选框
                                    if (m_Checkable)
                                    {
                                        this.DrawCheckBox(g, top, pen2, brush);
                                    }

                                }

                                top += h;
                                break;
                            case EVForms.UnitType.Folder:

                                MakeProcUnitList();

                                pen2.Color = Color.Black;
                                int width = this.height - (num2 * 2);
                                int num7 = this.Click ? 2 : 0;//偏移量y

                                int x = (this.left_pos + num2) + num8;
                                int y = (this.top_pos + num2) + num7;
                                //-------------------填充  画背景图
                                brush.Color = Color.Gray;
                                //    g.FillRectangle(brush, x + 2, y + 2, width, width);
                                if (this.IsExpanded || this.Nodes.Count == 0)//当文件夹内没有子类的时候 画一个 一
                                {
                                    //-------------------画 文件打开图标

                                    if (m_ImageIconDic.ContainsKey(ModuleInfo.PluginName))
                                    {
                                        //-------------------依据判定结果获取图标 
                                        //图标绘制只有一个 已经添加了结果显示图标 √ × 

                                        Icon image2 = m_ImageIconDic[ModuleInfo.PluginName];

                                        if (ModuleInfo.ModuleName.StartsWith("如果")) { image2 = Resources._if; }
                                        else if (ModuleInfo.ModuleName.StartsWith("否则如果")) { image2 = Resources.elseif; }
                                        else if (ModuleInfo.ModuleName.StartsWith("否则")) { image2 = Resources._else; }
                                        g.DrawIcon(image2, new Rectangle(x, y, width, width));
                                    }

                                     g.DrawImage(m_FolderIconOpen, new Rectangle(x - num8, y, width, width), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);

                                    //画出下划线
                                    pen2.Color = Color.DodgerBlue;
                                     g.DrawLine(pen2, this.left_pos + width / 3 + 3, this.top_pos + this.height, this.left_pos + this.width, this.top_pos + this.height);
                                    //-------------------画多选框
                                    if (m_Checkable)
                                    {
                                        this.DrawCheckBox(g, top, pen2, brush);
                                    }
                                    int parent_topTmp = parent_top;
                                    parent_top = top;
                                    top += h;
                                    //-------------------画子对象
                                    foreach (ModuleFlowItem item2 in this.Nodes)
                                    {
                                        item2.PaintItem(g, ref left, ref top, this.width - num, h, nest + 1, ref parent_top, selected);
                                    }
                                    parent_top = parent_topTmp;
                                }
                                else
                                {
                                    //-------------------画文件夹关闭按钮
                                    if (m_ImageIconDic.ContainsKey(ModuleInfo.PluginName))
                                    {
                                        //-------------------依据判定结果获取图标 
                                        //图标绘制只有一个 已经添加了结果显示图标 √ × 

                                        Icon image2 = m_ImageIconDic[ModuleInfo.PluginName];
                                        if (ModuleInfo.ModuleName.StartsWith("如果")) { image2 = Resources._if; }
                                        else if (ModuleInfo.ModuleName.StartsWith("否则如果")) { image2 = Resources.elseif; }
                                        else if (ModuleInfo.ModuleName.StartsWith("否则")) { image2 = Resources._else; }
                                             g.DrawIcon(image2, new Rectangle(x, y, width, width));
                                    }

                                     g.DrawImage(m_FolderIconClose, new Rectangle(x - num8, y, width, width), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
                                    pen2.Color = Color.DodgerBlue;
                                    //折叠后仍然需要在底部画出一条线 因为下一个没有画出这条断线
                                     g.DrawLine(pen2, left + (nest * num) - 4 + 20 - 3, top + this.height, ControlWidth, top + this.height);

                                    if (m_Checkable)
                                    {
                                        this.DrawCheckBox(g, top, pen2, brush);
                                    }


                                    top += h;
                                }
                                break;
                            case EVForms.UnitType.Empty:
                                top += h;
                                break;
                            default:
                                break;
                        }


                    }
                }
                if (base.TreeView == null)
                {
                    font.Dispose();
                    font = null;
                }
   
            }
        }

        public override string ToString()
        {
            return (this.m_ModuleNo.ToString() + "." + this.ModuleInfo.ModuleName);
        }

        public new bool Checked
        {
            get
            {
                return this.m_Checked;
            }
            set
            {
                if ((this.ModuleInfo.PluginName != "") && (this.ModuleInfo.PluginName != "FolderEnd"))
                {
                    this.m_Checked = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
        }

        public new bool IsSelected
        {
            get
            {
                return this.select;
            }
            internal set
            {
                this.select = value;
            }
        }


        public int Judge
        {
            get
            {
                return this.judge;
            }
            set
            {
                this.judge = value;
            }
        }

        public int Left
        {
            get
            {
                return this.left_pos;
            }
        }

        public new int Level
        {
            get
            {
                int num = 0;
                for (TreeNode node = this.Parent; node != null; node = node.Parent)
                {
                    num++;
                }
                return num;
            }
        }

        public int Level_Under
        {
            get
            {
                int num = 0;
                if (base.Nodes.Count > 0)
                {
                    num = 1;
                }
                int num2 = 0;
                foreach (ModuleFlowItem item in base.Nodes)
                {
                    int num3 = item.Level_Under;
                    if (num2 < num3)
                    {
                        num2 = num3;
                    }
                }
                return (num + num2);
            }
        }

        public ModuleFlowItem Parent
        {
            get
            {
                return (ModuleFlowItem)base.Parent;
            }
        }
        /// <summary>
        /// 描述文字的颜色
        /// </summary>
        public Color SubtextColor
        {
            get
            {
                return this.subtextcolor;
            }
            set
            {
                this.subtextcolor = value;
            }
        }
        /// <summary>
        /// 模块标题
        /// </summary>
        public string Title
        {
            get
            {
                return this.ModuleInfo.ModuleName;
            }
        }

        public int Top
        {
            get
            {
                return this.top_pos;
            }
        }

        public int ModuleNo
        {
            get
            {
                return this.m_ModuleNo;
            }
            set
            {
                this.m_ModuleNo = value;
            }
        }

        public UnitType UnitType
        {
            get
            {
                return this.m_UnitType;
            }
        }

        public int Width
        {
            get
            {
                return this.width;
            }
        }
    }
}
