using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using EasyVision.Common;

using EasyVision.Common.EVStruct;
using EasyVision.Service.Project;
using EasyVision.EVControl.Plugin;
using gCursorLib;
using System.Text.RegularExpressions;
using EasyVision.Service;
using EasyVision.Common.Log4Net;
using EasyVision.Common.Helper;
using D2D = SharpDX.Direct2D1;
using WIC = SharpDX.WIC;
using DW = SharpDX.DirectWrite;
using DXGI = SharpDX.DXGI;
using SharpDX;
using EasyVision.EVControl.SharpDX;
using SharpDX.Mathematics.Interop;

namespace EasyVision.EVControl.EVForms
{
    [Flags]
    public enum UnitFlowMode
    {
        DisplayJudgeIcon = 1,
        DisplayTerminator = 4,
        HiddenUnit = 2,
        IconButtonDisable = 0x10,
        NGUnitSearchEnabled = 0x20,
        TreeViewDisable = 8
    }
    public partial class ModuleFlow : UserControl
    {
        #region 委托
        public delegate void ItemButtonClickHandle(ModuleFlowItem item);

        public delegate void ItemDragDropHandl(ModuleFlowItem from, ModuleFlowItem to);

        public delegate void SelectedItemChangeHandle(ModuleFlowItem item);

        private delegate int WndProcDelegate(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);

        public delegate void ItemButtonDoubleClickHandle(ModuleFlowItem item);

        #endregion

        #region 字段

        /// <summary>
        /// 当前的鼠标信息,由于拖拽造成不响应鼠标事件,在timer中定时触发
        /// </summary>
        private MouseEventArgs me;
        /// <summary>
        /// 鼠标滚动响应标识
        /// </summary>
        private bool _blnCanWheelScroll;
        /// <summary>
        /// 拖拽时候的模块源,创建模块时候的源头要重新new一个模块
        /// </summary>
        private ModuleFlowItem ui_from;
        /// <summary>
        /// 画布图像,所有自绘图像都是在此处绘制后贴在控件上
        /// </summary>
        private Bitmap m_Buff;

        /// <summary>
        /// 模块单元的高度
        /// </summary>
        private int m_ItemHeight = 38;
        /// <summary>
        /// 选择模块是否修改
        /// </summary>
        private bool m_ChangeSelectItem;
        /// <summary>
        /// 滚轮消息用句柄
        /// </summary>
        private IntPtr hMainForm = IntPtr.Zero;
        /// <summary>
        /// 滚轮消息用委托
        /// </summary>
        private WndProcDelegate newWndProc;
        /// <summary>
        /// 滚轮消息用句柄
        /// </summary>
        private IntPtr orgWndProc = IntPtr.Zero;
        /// <summary>
        /// 模块树结构
        /// </summary>
        private TreeView m_ModelTreeView;

        /// <summary>
        /// 是否多选
        /// </summary>
        private bool m_MultiSelect;

        /// <summary>
        /// 当前鼠标所在木块名称
        /// </summary>
        private string m_CurModuleName;

        /// <summary>
        /// 运行状态禁用部分功能
        /// </summary>
        public bool UseAble { get; set; }
        /// <summary>
        /// 编辑textbox
        /// </summary>
        protected System.Windows.Forms.TextBox m_TxtEdit = new System.Windows.Forms.TextBox()
        {
            BorderStyle = BorderStyle.None
        };

        /// <summary>
        /// 当前选中的ModuleFlowItem
        /// </summary>
        private ModuleFlowItem m_CurSelectedItem;
        private Project m_Project;
        private int _UnitCount = -1;
        private ModuleFlowItem beforeSelectItem;

        public bool m_ItemDragEnabled;
        private bool MakingUnitFlow;

        private UnitFlowMode m_Mode;
        private ModuleFlowItem MouseOverItem;
        private int move;

        private Point m_MouseDownPos;//鼠标按下时候的位置
        private Point m_MouseUpPos;//鼠标拖拽丢放的位置
        private bool ref_enabled = true;
        private int scnno = -1;
        private int tick_count;


        /// <summary>
        /// 用于流程刷新的序号
        /// </summary>
        private int sfcIndex = -1;
        /// <summary>
        /// 用于保存是否展开的状态 用key作为容器,刷新前清除容器,需要保证键值唯一
        /// </summary>
        private Dictionary<string, bool> m_NodesStatusDic = new Dictionary<string, bool>();

        #endregion

        #region 事件
        /// <summary>
        /// 模块按钮按单击事件
        /// </summary>
        public event ItemButtonClickHandle ItemButtonClick;

        /// <summary>
        /// 模块按钮按单击事件
        /// </summary>
        public event ItemButtonDoubleClickHandle ItemButtonDoubleClick;
        /// <summary>
        /// 模块拖拽完成事件
        /// </summary>
        public event ItemDragDropHandl ItemDragDrop;
        /// <summary>
        /// 当前模块修改
        /// </summary>

        public event SelectedItemChangeHandle SelectedItemChange;
        #endregion

        #region 属性

        public Common.EVStruct.ProjectInfo ProjectInfo
        {
            get { return m_Project.ProjectInfo; }
            set { m_Project.ProjectInfo = value; }
        }
        public override Font Font
        {
            get
            {
                if (this.m_ModelTreeView != null)
                {
                    return this.m_ModelTreeView.Font;
                }
                return null;
            }
            set
            {
                if (this.m_ModelTreeView != null)
                {
                    this.m_ModelTreeView.Font = value;
                }
            }
        }

        public int ItemHeight
        {
            get
            {
                return this.m_ItemHeight;
            }
            set
            {
                this.m_ItemHeight = Math.Max(value, 5);
                this.VscrollBar.SmallChange = this.m_ItemHeight;
                this.Refresh();
                this.EnsureVisible(this.SelectUnitNo);
            }
        }

        public UnitFlowMode Mode
        {
            get
            {
                return this.m_Mode;
            }
            set
            {
                this.m_Mode = value;
                if ((this.m_Mode & UnitFlowMode.NGUnitSearchEnabled) != 0)
                {
                    this.VscrollBar.Top = 0;
                    this.VscrollBar.Height = (base.Height);
                }
                else
                {
                    this.VscrollBar.Top = 0;
                    this.VscrollBar.Height = base.Height;
                }
            }
        }

        public bool MultiSelect
        {
            get
            {
                return this.m_MultiSelect;
            }
            set
            {
                if (value == false)
                {
                    this.UnCheckedAllNode(this.Nodes);
                    this.Refresh();
                }
                this.m_MultiSelect = value;
            }
        }

        private TreeNodeCollection Nodes
        {
            get
            {
                if (this.m_ModelTreeView == null)
                {
                    return null;
                }
                return this.m_ModelTreeView.Nodes;
            }
        }

        public bool RefreshEnabled
        {
            get
            {
                return this.ref_enabled;
            }
            set
            {
                this.ref_enabled = value;
            //    this.Refresh();
            }
        }

        public List<ModuleFlowItem> SelectedItemArray
        {
            get
            {
                List<ModuleFlowItem> lst = new List<ModuleFlowItem>();
                if (this.m_MultiSelect)
                {
                    this.GetSelectedItems(this.Nodes, ref lst);
                    return lst;
                }
                if (this.beforeSelectItem != null)
                {
                    lst.Add(this.beforeSelectItem);
                }
                return lst;
            }
        }

        public ModuleFlowItem SelectItem
        {
            get
            {
                if ((this.beforeSelectItem != null) && this.beforeSelectItem.IsSelected)
                {
                    return this.beforeSelectItem;
                }
                return null;
            }
        }

        public int SelectUnitNo
        {
            get
            {
                try
                {
                    return this.SelectItem.ModuleNo;
                }
                catch
                {
                }
                return -1;
            }
        }

        public int UnitCount
        {
            get
            {
                return this._UnitCount;
            }
        }

        private int ViewItemCount
        {
            get
            {
                return (int)Math.Ceiling((double)(((double)(base.Height)) / ((double)this.m_ItemHeight)));
            }
        }

        private D2D.RenderTarget _renderTarget;//d2d 要画的目标对象
        private D2D.Factory factory;

        #endregion
        public ModuleFlow(Project proj)
        {
            InitializeComponent();

 

            this.m_ModelTreeView = new TreeView();
            this.Mode = this.Mode | UnitFlowMode.DisplayJudgeIcon;
            this.Mode = this.Mode | UnitFlowMode.DisplayTerminator;

            this.m_Project = proj;
            ////多选
            //m_MultiSelect = true;
            //拖拽允许
            m_ItemDragEnabled = true;
            proj.ModuleInfoListChanged += Proj_ModuleInfoListChanged;

            //
            m_TxtEdit.VisibleChanged += new EventHandler(
                  (s, e) =>
                  {
                      if (m_TxtEdit.Visible == false)
                      {
                          if (m_CurSelectedItem != null && m_CurSelectedItem.ModuleInfo.ModuleRemarks != m_TxtEdit.Text.Trim())
                          {
                              m_CurSelectedItem.ModuleInfo.ModuleRemarks = m_TxtEdit.Text.Trim();
                              //修改
                              m_Project.ChangeModuleInfo(m_CurSelectedItem.ModuleInfo);
                          }
                      }

                  });

            m_TxtEdit.LostFocus += new EventHandler(
                  (s, e) =>
                  {
                      m_TxtEdit.Visible = false;
                  });

            m_TxtEdit.KeyDown += new KeyEventHandler(
                (s, e) =>
                {
                    if (e.KeyData == Keys.Enter)
                    {
                        m_TxtEdit.Visible = false;
                    }
                });


            factory = new D2D.Factory();

            var pixelFormat = new D2D.PixelFormat(DXGI.Format.B8G8R8A8_UNorm, D2D.AlphaMode.Ignore);
            var hwndRenderTargetProperties = new D2D.HwndRenderTargetProperties();
            hwndRenderTargetProperties.Hwnd = this.Handle;
            hwndRenderTargetProperties.PixelSize = new Size2((int)Width, (int)Height);
            var renderTargetProperties = new D2D.RenderTargetProperties(D2D.RenderTargetType.Default, pixelFormat,
                96, 96, D2D.RenderTargetUsage.None, D2D.FeatureLevel.Level_DEFAULT);
            _renderTarget = new D2D.WindowRenderTarget(factory, renderTargetProperties, hwndRenderTargetProperties);
        }



        /// <summary>
        /// 获取结构树的展开状态
        /// </summary>
        /// <param name="nodes"></param>
        private void GetTreeNodesStatus(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.IsExpanded || m_CurModuleName == node.Text)//当鼠标位置的模块是折叠的 由于新加,则展开
                {
                    m_NodesStatusDic.Add(node.FullPath, true);
                }

                GetTreeNodesStatus(node.Nodes);
            }
        }

        /// <summary>
        /// 设置结构树的展开状态
        /// </summary>
        /// <param name="nodes"></param>
        private void SetTreeNodesStatus(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (m_NodesStatusDic.ContainsKey(node.FullPath))
                {
                    node.Expand();
                }
                SetTreeNodesStatus(node.Nodes);
            }
        }

        private void Proj_ModuleInfoListChanged(object sender, EventArgs e)
        {
            sfcIndex = -1;
            m_NodesStatusDic.Clear();
            GetTreeNodesStatus(this.Nodes);
            this.Nodes.Clear();
            List<ModuleInfo> moduleDic = m_Project.ModuleInfoList;

            //将父节点放入栈容器 
            Stack<ModuleFlowItem> s_ParentItemStack = new Stack<ModuleFlowItem>();

            foreach (ModuleInfo info in moduleDic)
            {
                sfcIndex++;
                ModuleFlowItem NodeItem = new ModuleFlowItem(info, sfcIndex);


                if ((info.PluginName == "条件分支" && info.ModuleName.StartsWith("结束"))) // 是结束则 取消栈里对应的if
                {
                    s_ParentItemStack.Pop();
                }
                else if ((info.PluginName == "条件分支" && info.ModuleName.StartsWith("否则")))
                {
                    s_ParentItemStack.Pop();
                }
                //~~~~~~~~~~~~~~~
                if (s_ParentItemStack.Count > 0)
                {
                    ModuleFlowItem parentItem = s_ParentItemStack.Peek();
                    parentItem.Nodes.Add(NodeItem);
                }
                else
                {
                    this.Nodes.Add(NodeItem);//根目录
                }
                //~~~~~~~~~~~~~~~
                //判断当前节点是否是父节点开始
                if ((info.PluginName == "条件分支" && info.ModuleName.StartsWith("如果")))//还需要判断那其他父节点开始
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if ((info.PluginName == "条件分支" && info.ModuleName.StartsWith("否则")))
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                else if ((info.PluginName == "文件夹" && Regex.IsMatch(info.ModuleName, "文件夹[0-9]*$")))//文件夹 开始
                {
                    s_ParentItemStack.Push(NodeItem);
                }
                //文件夹结束也放入到文件夹中
                else if ((info.PluginName == "文件夹" && info.ModuleName.StartsWith("文件夹结束")))
                {
                    s_ParentItemStack.Pop();
                }

            }

          SetTreeNodesStatus(this.Nodes);
            this.Refresh();
        }
        /// <summary>
        /// 获取文件夹节点,修改为只存在一级文件夹
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        ModuleFlowItem GetFloderNodes(string floderName)
        {
            foreach (ModuleFlowItem item1 in this.Nodes)
            {
                if (item1.ModuleInfo.ModuleName != null && item1.ModuleInfo.ModuleName == floderName)
                {
                    return item1;
                }
            }
            return null;
        }
        /// <summary>
        /// 选择模块,若当前模块存在子模块,子模块均选中
        /// </summary>
        /// <param name="u"></param>
        private void CheckedItem(ModuleFlowItem u)
        {
            if (u != null)
            {
                u.Checked = true;
                if (u.Nodes.Count > 0)
                {
                    foreach (ModuleFlowItem item in u.Nodes)
                    {
                        this.CheckedItem(item);
                    }
                }
            }
        }

        /// <summary>
        /// 获取单元号
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        private int GetUnitNo(ModuleFlowItem u)
        {
            if (u == null)
            {
                return -1;
            }
            return u.ModuleNo;
        }
        /// <summary>
        /// 取消当前单元及所有子单元的选中状态
        /// </summary>
        /// <param name="u"></param>
        private void UnCheckedItem(ModuleFlowItem u)
        {
            if (u != null)
            {
                for (TreeNode node = u.Parent; node != null; node = node.Parent)
                {
                    ((ModuleFlowItem)node).Checked = false;
                }
                u.Checked = false;
                if (u.Nodes.Count > 0)
                {
                    foreach (ModuleFlowItem item in u.Nodes)
                    {
                        this.UnCheckedItem(item);
                    }
                }
            }
        }
        public void EnsureVisible(int UnitNo)
        {
            ModuleFlowItem unitFlowItem = this.GetUnitFlowItem(UnitNo);
            ModuleFlowItem item2 = unitFlowItem;
            if (unitFlowItem != null)
            {
                int num = this.VscrollBar.Value;
                bool flag = this.ref_enabled;
                this.RefreshEnabled = false;
                while ((item2 = item2.Parent) != null)
                {
                    if (!item2.IsExpanded)
                    {
                        item2.Expand();
                        this.EnsureVisible(UnitNo);
                        this.RefreshEnabled = flag;
                        return;
                    }
                }
             //   this.Refresh();
                if (unitFlowItem.Top < 0)
                {
                    num += unitFlowItem.Top;
                }
                else if ((unitFlowItem.Top + this.m_ItemHeight) > this.VscrollBar.Height)
                {
                    num += (unitFlowItem.Top + (this.m_ItemHeight * 2)) - this.VscrollBar.Height;
                }
                num = Math.Min(this.VscrollBar.Maximum, Math.Max(0, num));
                num -= num % this.ItemHeight;
                this.VscrollBar.Value = num;
                this.RefreshEnabled = flag;
            }
        }
        /// <summary>
        /// 验证屏幕像素点是否在控件区域内
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        private bool GetClientContainState(Control ctrl, Point pt)
        {
            Rectangle clientRectangle = ctrl.ClientRectangle;
            return this.GetContainState(ctrl, clientRectangle, pt);
        }
        /// <summary>
        /// 验证屏幕像素点是否在控件区域内
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="rect"></param>
        /// <param name="pt"></param>
        /// <returns></returns>
        private bool GetContainState(Control ctrl, Rectangle rect, Point pt)
        {
            Point p = pt;
            Point point2 = ctrl.PointToClient(p);
            return rect.Contains(point2);
        }
        /// <summary>
        /// 获取鼠标位置的单元
        /// </summary>
        /// <param name="Nodes"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private ModuleFlowItem GetNodeFromPosition(TreeNodeCollection Nodes, MouseEventArgs e)
        {
            ModuleFlowItem nodeFromPosition = null;

            nodeFromPosition = GetNodeFromPositionIteration(Nodes, e);
            if (nodeFromPosition == null)
            {
                nodeFromPosition = GetLastNode(this.Nodes);
            }
            return nodeFromPosition;
        }

        private ModuleFlowItem GetNodeFromPositionIteration(TreeNodeCollection Nodes, MouseEventArgs e)
        {
            ModuleFlowItem nodeFromPosition = null;
            foreach (ModuleFlowItem item2 in Nodes)
            {
                int num = item2.Top + this.VscrollBar.Top;
                if (((num < e.Y) && ((num + this.m_ItemHeight) > e.Y)) && ((item2.Left < e.X) && (e.X < base.Width)))
                {
                    return item2;
                }
                if ((item2.UnitType == UnitType.Folder) && item2.IsExpanded)
                {
                    nodeFromPosition = this.GetNodeFromPositionIteration(item2.Nodes, e);
                }
                if (nodeFromPosition != null)
                {
                    return nodeFromPosition;
                }
            }
            return nodeFromPosition;

        }

        private ModuleFlowItem GetLastNode(TreeNodeCollection Nodes)
        {
            ModuleFlowItem item = null;
            if (Nodes.Count > 0)
            {
                item = (ModuleFlowItem)Nodes[Nodes.Count - 1];
                if (item.Nodes.Count > 0)
                {
                    item = GetLastNode(Nodes[Nodes.Count - 1].Nodes);
                }

            }

            return item;
        }
        /// <summary>
        /// 获取winAPI传递过来的消息转化为屏幕鼠标点
        /// </summary>
        /// <param name="_xy"></param>
        /// <returns></returns>
        private Point GetPoint(IntPtr _xy)
        {
            uint num = (IntPtr.Size == 8) ? ((uint)_xy.ToInt64()) : ((uint)_xy.ToInt32());
            int x = (short)num;
            return new Point(x, (short)(num >> 0x10));


        }

        private ModuleFlowItem GetSelectedItems(TreeNodeCollection Nodes, ref List<ModuleFlowItem> ar)
        {
            ModuleFlowItem selectedItems = null;
            foreach (ModuleFlowItem item2 in Nodes)
            {
                if (item2.Checked)
                {
                    ar.Add(item2);
                }
                else if (item2.Nodes.Count > 0)
                {
                    selectedItems = this.GetSelectedItems(item2.Nodes, ref ar);
                }
                if (selectedItems != null)
                {
                    return selectedItems;
                }
            }
            return selectedItems;
        }

        public ModuleFlowItem GetUnitFlowItem(int unitNo)
        {
            return this.GetUnitFlowItem(this.Nodes, unitNo);
        }

        private ModuleFlowItem GetUnitFlowItem(TreeNodeCollection Nodes, int unitno)
        {
            if (Nodes != null)
            {
                foreach (ModuleFlowItem item in Nodes)
                {
                    ModuleFlowItem item2;
                    if (item.ModuleNo == unitno)
                    {
                        return item;
                    }
                    if ((item.Nodes.Count > 0) && ((item2 = this.GetUnitFlowItem(item.Nodes, unitno)) != null))
                    {
                        return item2;
                    }
                }
            }
            return null;
        }
        private void VscrollBar_ValueChanged(object sender, EventArgs e)
        {
            base.SuspendLayout();
            int num = this.VscrollBar.Value;
            num -= num % this.ItemHeight;
            this.VscrollBar.Value = num;
            base.ResumeLayout(false);
            base.Refresh();
        }

        private void ModelFlow_Resize(object sender, EventArgs e)
        {

        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private bool isFolderEnd(string ident)
        {
            return (ident.ToUpper() == "FolderEnd".ToUpper());
        }

        private bool ItemSelect(TreeNodeCollection Nodes, int selectno)
        {
            foreach (ModuleFlowItem item in Nodes)
            {
                if (item.ModuleNo == selectno)
                {
                    item.IsSelected = true;
                    this.beforeSelectItem = item;
                    return true;
                }
                if ((item.Nodes.Count > 0) && this.ItemSelect(item.Nodes, selectno))
                {
                    return true;
                }
            }
            return false;
        }
        public void MakeUnitFlow(int scn = -1, bool refresh = true)
        {
            if (!this.MakingUnitFlow)
            {
                this.MakingUnitFlow = true;
                try
                {
                    IntPtr data = new IntPtr(0);
                    int totalUnitCount = 0;
                    int unitCount = 0;
                    int unitNo = 0;
                    int num4 = 0;


                    //item2 = new UnitFlowItem("", "ident", 1, 1, 1, 1)
                    //{
                    //    last_unitno = 1
                    //};
                    //Nodes.Add(item2);
                    //此处应该从本地获取!!!!!!!!!!

                    //if (GetUnitTitleAndItemIdentEx0(scn, ref totalUnitCount, ref unitCount, ref data) != 0)
                    //{
                    //    totalUnitCount = 0;
                    //    unitCount = 0;
                    //}

                    //totalUnitCount = 1;
                    //unitCount = 1;

                    //IntPtr buff = data;
                    //unitNo = 0;
                    //this.Nodes.Clear();
                    //this.ADDUnitItem(scn, ref unitNo, this.Nodes, data, ref buff, totalUnitCount, ref unitCount, -1);
                    //GetUnitTitleAndItemIdentEx2(data);
                    //if ((this.mode & UnitFlowMode.DisplayTerminator) != 0)
                    //{
                    //    UnitFlowItem node = new UnitFlowItem("", "", unitNo, scn, num4, 0)
                    //    {
                    //        last_unitno = unitNo
                    //    };
                    //    this.Nodes.Add(node);
                    //    if (this.Nodes.Count == 1)
                    //    {
                    //        this.UnitSelect(0);
                    //    }
                    //}
                    //this.scnno = scn;
                    if (refresh)
                    {
                        this.Refresh();
                    }
                    this._UnitCount = unitNo;
                }
                catch
                {
                }
                finally
                {
                    this.MakingUnitFlow = false;
                }
            }
        }
        /// <summary>
        /// 获取鼠标位置的单元号
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int MousePositionToUnitNo(Point p)
        {
            ModuleFlowItem nodeFromPosition = this.GetNodeFromPosition(this.Nodes, new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
            if (nodeFromPosition != null)
            {
                return nodeFromPosition.ModuleNo;
            }
            return -1;
        }

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //    if (SharedClass.DesignMode() == false)
        //    {
        //        this.SetSubClass();
        //    }
        //}
        //protected override void OnHandleDestroyed(EventArgs e)
        //{
        //    base.OnHandleDestroyed(e);
        //    if (this.hMainForm != IntPtr.Zero)
        //    {
        //        Common.WinAPI.SetWindowLong(this.hMainForm, -4, this.orgWndProc);
        //    }
        //}

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            m_TxtEdit.Visible = false;

            if (((base.Visible) && (this.VscrollBar.Visible)))
            {
                if (e.Delta > 0)
                {
                    if (this.VscrollBar.Value - this.m_ItemHeight >= this.VscrollBar.Minimum)
                    {
                        this.VscrollBar.Value -= this.m_ItemHeight;
                    }

                }
                if (e.Delta < 0)
                {
                    if (this.VscrollBar.Value + this.Height < this.VscrollBar.Maximum)
                    {
                        this.VscrollBar.Value += this.m_ItemHeight;
                    }

                }
            }
            base.OnMouseWheel(e);
        }

        /// <summary>
        /// 显示注释行
        /// </summary>
        /// <param name="e"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void ShowTextBox(ModuleFlowItem item)
        {

            Rectangle rect = new Rectangle(item.RemarksPoint.X + 2, item.RemarksPoint.Y,
                item.Width - 110 - (VscrollBar.Visible == true ? VscrollBar.Width : 0), 9);

            m_TxtEdit.Parent = this;
            m_TxtEdit.Bounds = rect;
            m_TxtEdit.Multiline = false;
            m_TxtEdit.Visible = true;
            m_TxtEdit.Text = item.ModuleInfo.ModuleRemarks;
            m_TxtEdit.Focus();
            m_TxtEdit.SelectAll();

        }

        private void ItemSelectDrag(ModuleFlowItem item)
        {
            if (this.m_ItemDragEnabled)
            {
                ModuleFlowItem.dragList = true;
                ModuleFlowItem.m_DragFromUnitNo = item.ModuleNo;
                this.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            this.UnSelectAllNode(this.Nodes);
            item.IsSelected = true;

            if (EVControl.PluginsManger.m_PluginInfoDic.ContainsKey(ui_from.ModuleInfo.PluginName) 
                && EVControl.PluginsManger.m_PluginInfoDic.ContainsKey(ui_from.ModuleInfo.PluginName))
            {
                gCursor1.gText = ui_from.ModuleInfo.ModuleName;
                gCursor1.gEffect = gCursor.eEffect.Move;
                gCursor1.gImage = EVControl.PluginsManger.m_PluginInfoDic[ui_from.ModuleInfo.PluginName].IconImage.ToBitmap();
                gCursor1.gType = gCursor.eType.Both;
                gCursor1.MakeCursor();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (UseAble == false) return;

            timer_refresh.Enabled = true;
            m_TxtEdit.Visible = false;

            m_MouseDownPos = new Point(e.X, e.Y);

            this.ui_from = m_CurSelectedItem = GetNodeFromPosition(m_ModelTreeView.Nodes, e);
            if (m_CurSelectedItem != null)
            {
                ModuleFlowItem.m_DragToUnitNo = -1;
                switch (m_CurSelectedItem.HitCheck(e))
                {
                    case CheckArea.Space:

                        ItemSelectDrag(m_CurSelectedItem);
                        break;
                    case CheckArea.Icon:
                        if ((this.m_Mode & UnitFlowMode.IconButtonDisable) == 0)
                        {
                            m_CurSelectedItem.Click = true;
                        }
                        this.UnSelectAllNode(this.Nodes);
                        break;
                    case CheckArea.Remarks:
              
                         ItemSelectDrag(m_CurSelectedItem);
                     
                        break;
                    case CheckArea.MultiSelect:

                        if (!this.m_MultiSelect)
                        {
                            if (this.m_ItemDragEnabled)
                            {
                                ModuleFlowItem.dragList = true;
                            }
                            break;
                        }
                        if (!m_CurSelectedItem.Checked)
                        {
                            this.CheckedItem(m_CurSelectedItem);
                            break;
                        }
                        this.UnCheckedItem(m_CurSelectedItem);

                        this.UnSelectAllNode(this.Nodes);
                        m_CurSelectedItem.IsSelected = true;
                        break;
                    default:
                        break;
                }

                this.m_ChangeSelectItem = false;
                if (m_CurSelectedItem.IsSelected)
                {
                    //判断现在的选择单元是否修改
                    if (m_CurSelectedItem != this.beforeSelectItem)
                    {
                        this.m_ChangeSelectItem = true;
                    }
                    this.beforeSelectItem = m_CurSelectedItem;
                }
              this.Refresh();
                // this.timerDrag.Enabled = true;
                this.move = 0;
                this.me = e;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (UseAble == false) return;

            //Debug.WriteLine("鼠标位置触发" +e.X);
            Point curDownPos = new Point(e.X, e.Y);//当前位置
            if (ModuleFlowItem.dragList && Math.Abs(m_MouseDownPos.Y - curDownPos.Y) > 15)
            {

                Cursor.Current = gCursor1.gCursor;
            }

            if (ModuleFlowItem.dragList || ModuleFlowItem.dragInNew)
            {
                ModuleFlowItem nodeFromPosition = null;
                if (e != null)
                {
                    nodeFromPosition = this.GetNodeFromPosition(this.m_ModelTreeView.Nodes, e);
                }

                bool drag = ModuleFlowItem.dragList;
                if (nodeFromPosition != null)
                {
                    //Debug.WriteLine("获取到鼠标目标位置模块 编号"+ nodeFromPosition.Title);
                    ModuleFlowItem.m_DragToUnitNo = nodeFromPosition.ModuleNo;
                    if (((this.ui_from != null) && (this.ui_from.UnitType == UnitType.Folder)) && ((nodeFromPosition.ModuleNo >= this.ui_from.ModuleNo) && (nodeFromPosition.ModuleNo <= this.ui_from.last_unitno)))
                    {
                        ModuleFlowItem.dragList = false;
                    }
                }
                else
                {
                    ModuleFlowItem.dragList = false;
                }
                this.me = e;
                if (e.Y < (this.VscrollBar.Top + this.m_ItemHeight))
                {
                    this.move = -this.m_ItemHeight;
                }
                else if (e.Y > (base.Height - this.m_ItemHeight))
                {
                    this.move = this.m_ItemHeight;
                }
                else
                {
                    this.move = 0;
                }
                this.Refresh();
                ModuleFlowItem.dragList = drag;
                if (nodeFromPosition != null)
                {
                    if (this.MouseOverItem != nodeFromPosition)
                    {
                        this.tick_count = 0;
                    }
                    if (this.tick_count > 3)
                    {
                        nodeFromPosition.Expand();
                        this.Refresh();
                        this.MouseOverItem = null;
                        return;
                    }
                    this.MouseOverItem = nodeFromPosition;
                }
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (UseAble == false) return;

            //获取当前鼠标位置的模块
            ModuleFlowItem nodeFromPosition = this.GetNodeFromPosition(this.m_ModelTreeView.Nodes, e);

            if (nodeFromPosition != null)
            {
                if (nodeFromPosition.HitCheck(e) == CheckArea.Space)
                {
                    if (this.ItemButtonDoubleClick != null)
                    {
                        this.ItemButtonDoubleClick(nodeFromPosition);
                    }
                    if (nodeFromPosition.ModuleInfo.ModuleName.StartsWith("结束") ||
                       Regex.IsMatch(nodeFromPosition.ModuleInfo.ModuleName, "否则[0-9]*$"))
                    {
                        ModuleInfo info = nodeFromPosition.ModuleInfo;
                        m_Project.AddModule(nodeFromPosition.ModuleInfo.ModuleName, ui_from.ModuleInfo, false);
                    }
                    else
                    {
                        if (!nodeFromPosition.ModuleInfo.ModuleName.StartsWith("文件夹"))
                        {
                            PluginBaseForm form1 = PluginsManger.GetSettingForm(nodeFromPosition.ModuleInfo.PluginName);
                            form1.ModuleName = nodeFromPosition.ModuleInfo.ModuleName;
                            form1.ProjectID = m_Project.ProjectInfo.ProjectID;
                            form1.ShowDialog();
                        }

                    }
                }

            }
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (UseAble == false) return;

            timer_refresh.Enabled = false;
            //获取当前鼠标位置的模块
            ModuleFlowItem mousePosItem = this.GetNodeFromPosition(this.m_ModelTreeView.Nodes, e);

            if ((ModuleFlowItem.dragList || ModuleFlowItem.dragInNew) && ui_from != null) //拖拽过程中
            {
                if (mousePosItem == null)//完全新建的情况
                {
                    m_Project.AddModule(null, ui_from.ModuleInfo, true);

                }
                else//移动情况 包含移动模块和拖动新建模块
                {
                    if (mousePosItem.ModuleNo != this.ui_from.ModuleNo)
                    {
                         m_CurModuleName = mousePosItem.ModuleInfo.ModuleName;
                        bool isNext = true;
                        ////如果目标模块是文件夹 就设置等级为0
                        //if (mousePosItem.ModuleInfo.PluginName == GlobalDefine.PLUGIN_FOLDER_NAME)
                        //{
                        //    ModuleFlowItem item = (ModuleFlowItem)mousePosItem.Nodes[0];
                        //    curModuleName = item.ModuleInfo.ModuleName;
                        //    isNext = false;
                        //}

                        if (ui_from.ModuleNo != -1)//-1表示新建的 //移动模块
                        {

                            //if (ui_from.ModuleInfo.PluginName == GlobalDefine.PLUGIN_FOLDER_NAME)
                            //{
                            //    //文件夹整体移动未实现
                            //    //foreach (ModuleFlowItem item in ui_from.Nodes)
                            //    //{
                            //    //    m_Project.ChangeModulePos(item.ModuleInfo.ModuleName, curModuleName, isNext);
                            //    //}
                            //}
                            //else
                            //{

                            //}

                            m_Project.ChangeModulePos(ui_from.ModuleInfo.ModuleName, m_CurModuleName, isNext);
                            //GetParentNodes(ui_from).Remove(ui_from);
                        }
                        else
                        {

                            m_Project.AddModule(m_CurModuleName, ui_from.ModuleInfo, isNext);
                        }
                    }
                }

            }
            ModuleFlowItem.dragList = false;
            ModuleFlowItem.dragInNew = false;
            if (mousePosItem != null)
            {
                if (this.m_ChangeSelectItem)
                {
                    if (this.SelectedItemChange != null)
                    {
                        this.SelectedItemChange(this.beforeSelectItem);
                    }
                    this.EnsureVisible(this.SelectUnitNo);
                }
                if (mousePosItem.HitCheck(e) == CheckArea.Icon)
                {
                    if (mousePosItem.UnitType == UnitType.Folder)
                    {
                        mousePosItem.Toggle();
                    }
                    else if (((this.ui_from != null) && (this.ui_from.ModuleNo == mousePosItem.ModuleNo)) && (this.ui_from.Click && ((this.ItemButtonClick != null) & (mousePosItem.ToString() != (mousePosItem.ModuleNo.ToString() + ".")))))
                    {
                        this.ui_from.Click = false;
                        this.Refresh();
                        this.ItemButtonClick(mousePosItem);
                    }
                }
            }
            this.m_ChangeSelectItem = false;
            if (this.ui_from != null)
            {
                this.ui_from.Click = false;
            }

            ui_from = null;
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Refresh();
            base.OnMouseUp(e);
        }

        private void RefreshIndex(TreeNodeCollection nodes)
        {
            foreach (ModuleFlowItem item in nodes)
            {
                sfcIndex++;
                item.ModuleNo = sfcIndex;
                if (item.Nodes.Count > 0)
                {
                    RefreshIndex(item.Nodes);
                }
            }
        }

        private void AddModuleItem(ModuleFlowItem mousePosItem, ModuleFlowItem waitMoveItem)
        {
            int index = mousePosItem.Index;
            TreeNodeCollection newbaseNodes = GetParentNodes(waitMoveItem);
            newbaseNodes.Insert(index + 1, waitMoveItem);
        }
        /// <summary>
        /// 在ui中修改模块位置
        /// </summary>
        /// <param name="mousePosItem"></param>
        /// <param name="waitMoveItem"></param>
        private void ChangeModuleItemPos(ModuleFlowItem mousePosItem, ModuleFlowItem waitMoveItem)
        {
            TreeNodeCollection baseNodes = GetParentNodes(waitMoveItem);
            baseNodes.Remove(waitMoveItem);
            AddModuleItem(mousePosItem, waitMoveItem);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            List<Project> s_ProjectList = EVSolution.s_ProjectList;
            List<ModuleInfo> a = s_ProjectList[0].ModuleInfoList;
               TimeTool.Start("刷新流程");
  
                try
                {
                    if (this.m_Buff != null)
                    {
                        //EasyVision.Common.Log4Net.Log.Debug($"流程列表开始刷新");

                        int num;
                        int top = num = -this.VscrollBar.Value;
                        int left = 0;// -this.hScrollBar.Value;

                        //if ((top + this.VscrollBar.Value) < this.VscrollBar.Height)
                        //{
                        //    this.VscrollBar.Value = 0;
                        //    this.VscrollBar.Visible = false;
                        //}
                        ModuleFlowItem.m_Checkable = this.m_MultiSelect;
                        ModuleFlowItem.judgeEnabled = (this.m_Mode & UnitFlowMode.DisplayJudgeIcon) != 0;
                        ModuleFlowItem.FlowHeight = this.Height;
                        ModuleFlowItem.ControlWidth = base.Width - (this.VscrollBar.Visible ? this.VscrollBar.Width : 0);
                        //ModuleFlowItem.ControlWidth = base.Width - this.VscrollBar.Width;
                        int num4 = 0;

                        using (Graphics graphics = Graphics.FromImage(this.m_Buff))
                        {
                            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, base.Width, this.VscrollBar.Height));

                        //lock (EVSolution.s_DrawModuleLock)
                        //{
                        EVSolution.s_DrawModuleFlag = true;
                     
                        foreach (ModuleFlowItem item in this.Nodes)
                            {
                            item.PaintItem(graphics, ref left, ref top, base.Width - 5, this.m_ItemHeight, 0, ref num4, false);
                        }
                        EVSolution.s_DrawModuleSign.Set();
                        EVSolution.s_DrawModuleFlag = false;
                        // }

                        if (this.ref_enabled)
                        {
                            if (this.Nodes.Count > 0)
                            {
                                using (Pen pen2 = new Pen(Color.DodgerBlue))
                                {
                                    //底部分割线
                                    graphics.DrawLine(pen2, 13, top, ModuleFlowItem.ControlWidth, top);
                                }
                            }

                            //  this.m_Buff.Save(@"C:\Users\Administrator\Desktop\temp\1.bmp");
                            // TimeTool.Start("流程绘制到图像2");

                            #region "根据width ,height重新生成 利用directx"

                            //重新调整渲染目标的尺寸
                           ((D2D.WindowRenderTarget) _renderTarget).Resize(new Size2((int)Width, (int)Height));

                            _renderTarget.BeginDraw();

                            _renderTarget.DrawBitmap(SharpDXTool.ConvertFromSystemBitmap(_renderTarget, this.m_Buff),
                                     new RawRectangleF(0, 0, base.Width, base.Height),
                                1, D2D.BitmapInterpolationMode.NearestNeighbor,
                                new RawRectangleF(0, 0, base.Width, this.VscrollBar.Height));

                            _renderTarget.EndDraw();

                            #endregion


                            //e.Graphics.DrawImage(this.m_Buff, 0, this.VscrollBar.Top);
                            //  TimeTool.Stop("流程绘制到图像2");
                        }
                        else
                        {
                            //e.Graphics.DrawImage(this.m_Buff, 0, this.VscrollBar.Top);
                        }

                    }


                    if ((top + this.VscrollBar.Value) < this.VscrollBar.Height)
                        {
                            this.VscrollBar.Value = 0;
                            this.VscrollBar.Visible = false;
                        }
                        else
                        {
                            this.VscrollBar.Visible = true;
                        }

                        this.VscrollBar.Maximum = Math.Max((top - num) + this.m_ItemHeight, 0);
                        this.VscrollBar.LargeChange = this.VscrollBar.Height;
                        this.VscrollBar.SmallChange = this.m_ItemHeight;
                        base.OnPaint(e);
                    }
                }
                catch (OutOfMemoryException exception)
                {
                    SharedClass.ExceptionOutOfMemory(exception);
                }
                TimeTool.Stop("刷新流程");
                // this.m_Buff.Save(@"C:\Users\Administrator\Desktop\temp\1.bmp");
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.m_Buff != null)
            {
                this.m_Buff.Dispose();
            }
            this.m_Buff = new Bitmap(Math.Max(base.Width, 1), Math.Max(base.Height, 1));

            this.RefreshEnabled = true;
            this.Refresh();
        }


        /// <summary>
        /// 获取节点应该的父节点
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        TreeNodeCollection GetParentNodes(ModuleFlowItem item)
        {
            if (item.Parent != null)
            {
                return item.Parent.Nodes;
            }
            return this.Nodes;
        }

        //丢下则创建
        private void ModuleFlow_DragDrop(object sender, DragEventArgs e)
        {
            if (UseAble == false) return;

            timer_refresh.Enabled = false;
            Point p = new Point(e.X, e.Y);
            m_MouseUpPos = this.PointToClient(p);

            me = new MouseEventArgs(MouseButtons, 0, m_MouseUpPos.X, m_MouseUpPos.Y, 0);
            this.OnMouseUp(me);
        }


        //拖动的时候鼠标滑动
        private void ModuleFlow_DragOver(object sender, DragEventArgs e)
        {
            timer_refresh.Enabled = true;
            Point p = new Point(e.X, e.Y);
            Point curr = this.PointToClient(p);
            me = new MouseEventArgs(MouseButtons, 0, curr.X, curr.Y, 0);
            this.OnMouseMove(me);
        }

        private void UnCheckedAllNode(TreeNodeCollection Nodes)
        {
            foreach (ModuleFlowItem item in Nodes)
            {
                item.Checked = false;
                if (item.Nodes.Count > 0)
                {
                    this.UnCheckedAllNode(item.Nodes);
                }
            }
        }
        public void UnitSelect(int _unitno)
        {
            int num = this.GetUnitNo(this.beforeSelectItem);
            int num2 = Math.Max(0, _unitno);
            num2 = Math.Min(Math.Max(0, this.UnitCount - 1), num2);
            this.UnSelectAllNode(this.Nodes);
            this.ItemSelect(this.Nodes, num2);
            if ((num != this.GetUnitNo(this.SelectItem)) && (this.SelectedItemChange != null))
            {
                this.SelectedItemChange(this.SelectItem);
            }
        }

        private void UnSelectAllNode(TreeNodeCollection Nodes)
        {
            foreach (ModuleFlowItem item in Nodes)
            {
                item.IsSelected = false;
                if (item.Nodes.Count > 0)
                {//取消全选
                    this.UnSelectAllNode(item.Nodes);
                }
            }
            this.beforeSelectItem = null;
        }

        private void ModelFlow_DragEnter(object sender, DragEventArgs e)
        {

            Debug.WriteLine("ModelFlow_DragEnter 拖拽进入");
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string modulePluginName = (string)e.Data.GetData(typeof(string));

                string name = "NoName";
                //Debug.WriteLine("拖拽消息:" + dat);
                e.Effect = DragDropEffects.All;
                ModuleInfo infoTmp = new ModuleInfo()
                {
                    ModuleName = name,
                    PluginName = modulePluginName,
                    IsUse = true
                };

                ModuleFlowItem item3 = new ModuleFlowItem(infoTmp, -1)
                {
                    //last_unitno = 1,
                    Judge = 1,
                };
                ModuleFlowItem.dragInNew = true;
                ModuleFlowItem.m_DragFromUnitNo = -1;
                this.ui_from = item3;
                this.beforeSelectItem = item3;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }


        private void ModelFlow_DragLeave(object sender, EventArgs e)
        {
            Debug.WriteLine("ModelFlow_DragLeave 拖拽离开");
            DragInNewStop();
        }

        private void DragInNewStop()
        {
            if (ModuleFlowItem.dragInNew)
            {
                ModuleFlowItem.dragInNew = false;
                this.beforeSelectItem = null;
            }
        }

        /// <summary>
        /// 删除当前选中模块
        /// </summary>
        public void DeleteSelectItems()
        {
            if (this.SelectItem != null)
            {
                DeleteItem(beforeSelectItem);
            }
        }
        private void 删除选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"确定要删除模块 [{this.SelectItem.ModuleInfo.ModuleName}] 吗？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
            if (dr == DialogResult.OK)
            {
                DeleteSelectItems();
            }
        }

        /// <summary>
        /// 删除模块,若存在子模块就一直执行删除动作
        /// </summary>
        /// <param name="u"></param>
        private void DeleteItem(ModuleFlowItem u)
        {
            if (u != null)
            {
                //if (u.Nodes.Count > 0)
                //{
                //    foreach (ModuleFlowItem item in u.Nodes)
                //    {
                //        this.DeleteItem(item);
                //    }
                //}
                m_Project.DeleteModule(u.ModuleInfo.ModuleName);
                //GetParentNodes(u).Remove(u);
            }
        }

        private void ModuleFlow_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (UseAble == false)
                {
                    e.Cancel = true;
                    return;
                }
                禁用ToolStripMenuItem.Checked = false;
                禁用ToolStripMenuItem.Enabled = true;
                删除选中ToolStripMenuItem.Enabled = true;

                if (this.SelectItem.ModuleInfo.ModuleName.Contains("结束"))
                {
                    禁用ToolStripMenuItem.Enabled = false;
                    删除选中ToolStripMenuItem.Enabled = false;
                }

                if (this.SelectItem.ModuleInfo.ModuleName.Contains("否则"))
                {
                    禁用ToolStripMenuItem.Enabled = false;
                }

                //if (this.SelectItem.Parent !=null && this.SelectItem.Parent.ModuleInfo.IsUse == false)//父类是禁用,则子类不能再设置 取消该功能
                //{
                //    禁用ToolStripMenuItem.Enabled = false;
                //}
                if (!this.SelectItem.ModuleInfo.IsUse)
                {
                    禁用ToolStripMenuItem.Checked = true;
                }
            }
            catch { }
        }

        private void 禁用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.SelectItem.ModuleInfo.IsUse = !this.SelectItem.ModuleInfo.IsUse;
           m_Project.ChangeModuleInfo(this.SelectItem.ModuleInfo);
        }

        private void timer_updown_Tick(object sender, EventArgs e)
        {
       
            if (this.move != 0)
            {
                this.VscrollBar.Value = Math.Max(0, Math.Min((int)(this.VscrollBar.Maximum - (base.Height / 2)), (int)(this.VscrollBar.Value + this.move)));
            }

        }

        private void ModuleFlow_MouseClick(object sender, MouseEventArgs e)
        {
            if (UseAble == false) return;

            m_MouseDownPos = new Point(e.X, e.Y);

            if (m_CurSelectedItem != null)
            {
                ModuleFlowItem.m_DragToUnitNo = -1;
                if (m_CurSelectedItem.HitCheck(e) == CheckArea.Remarks)
                {
                    //选中注释
                    if (m_CurSelectedItem.IsSelected == true && m_TxtEdit.Visible == false)//选中之后再点击 就弹出texbox
                    {
                        ShowTextBox(m_CurSelectedItem);
                    }
                }
            }
        }


    }
}
