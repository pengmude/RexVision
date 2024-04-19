using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace RexHelps
{
    /// <summary>
    /// 绑定任意datagridview 配上list<T>类型
    /// </summary>
    /// <typeparam name="T">任意类型</typeparam>
    public class ToolStripMenu<T> where T : ICloneable
    {
        public ToolStripMenu()
        {
            InitMenuStrip();
        }

        private ContextMenuStrip m_MenuStrip = new ContextMenuStrip();
        /// <summary>
        /// 当前选中索引
        /// </summary>
        private int currentIndex = -1;
        /// <summary>
        /// 复制项
        /// </summary>
        private T copyItem = default(T);
        /// <summary>
        /// 剪切项索引
        /// </summary>
        private int cutIndex = -1;

        private DataGridView _DataGrid;
        /// <summary>
        /// 绑定菜单栏的datagridview
        /// </summary>
        public DataGridView DataGrid
        {
            set
            {
                _DataGrid = value;
                _DataGrid.ContextMenuStrip = m_MenuStrip;
            }
        }

        private List<T> _DataSource;
        /// <summary>
        /// 绑定菜单栏的数据源
        /// </summary>
        public List<T> lstDataSource
        {
            set
            {
                _DataSource = value;
                UpdateGridView();
            }
        }

        public readonly ToolStripMenuItem strip_Add = new ToolStripMenuItem("添加");
        public readonly ToolStripMenuItem strip_Edit = new ToolStripMenuItem("修改");

        ToolStripMenuItem strip_ShiftUp = new ToolStripMenuItem("上移");
        ToolStripMenuItem strip_ShiftDown = new ToolStripMenuItem("下移");
        ToolStripMenuItem strip_Copy = new ToolStripMenuItem("复制");
        ToolStripMenuItem strip_Cut = new ToolStripMenuItem("剪切");
        ToolStripMenuItem strip_Insert = new ToolStripMenuItem("插入");
        ToolStripMenuItem strip_RemoveAt = new ToolStripMenuItem("删除");
        //ToolStripMenuItem strip_RemoveAll = new ToolStripMenuItem("删除所有");
        private void InitMenuStrip()
        {
            strip_Add.Visible = false;
            strip_Copy.Visible = false;
            strip_ShiftUp.Click += new EventHandler((s, e) => OnStrip_ShiftUp(s, e));
            strip_ShiftDown.Click += new EventHandler((s, e) => OnStrip_ShiftDown(s, e));
            strip_Copy.Click += new EventHandler((s, e) => OnStrip_Copy(s, e));
            strip_Cut.Click += new EventHandler((s, e) => OnStrip_Cut(s, e));
            strip_Insert.Click += new EventHandler((s, e) => OnStrip_Insert(s, e));
            //多选，删除多行
            strip_RemoveAt.Click += new EventHandler((s, e) => OnStrip_RemoveAt(s, e));

            m_MenuStrip.Items.Add(strip_ShiftUp);
            m_MenuStrip.Items.Add(strip_ShiftDown);
            m_MenuStrip.Items.Add(strip_Add);
            m_MenuStrip.Items.Add(strip_Edit);
            m_MenuStrip.Items.Add(strip_Copy);
            m_MenuStrip.Items.Add(strip_Cut);
            m_MenuStrip.Items.Add(strip_Insert);
            m_MenuStrip.Items.Add(strip_RemoveAt);
            //m_MenuStrip.Items.Add(strip_RemoveAll);
            m_MenuStrip.Opening += new CancelEventHandler((s, e) => On_MenuStrip_Opening());

        }
        /// <summary>
        /// 设置子菜单的可见状态
        /// </summary>
        /// <param name="blnShiftUp">上移菜单</param>
        /// <param name="blnShiftDown">下移</param>
        /// <param name="blnAdd">添加</param>
        /// <param name="blnEdit">编辑</param>
        /// <param name="blnCopy">复制</param>
        /// <param name="blnCut">剪切</param>
        /// <param name="blnInsert">插入</param>
        /// <param name="blnRemoveAt">移除</param>
        public void SetMenuStripVisible(bool blnShiftUp, bool blnShiftDown, bool blnAdd, bool blnEdit, bool blnCopy, bool blnCut, bool blnInsert, bool blnRemoveAt)
        {
            strip_ShiftUp.Visible = blnShiftUp;
            strip_ShiftDown.Visible = blnShiftDown;
            strip_Add.Visible = blnAdd;
            strip_Edit.Visible = blnEdit;
            strip_Copy.Visible = blnCopy;
            strip_Cut.Visible = blnCut;
            strip_Insert.Visible = blnInsert;
            strip_RemoveAt.Visible = blnRemoveAt;
        }
        private void On_MenuStrip_Opening()
        {
            try
            {
                foreach (ToolStripMenuItem menu in m_MenuStrip.Items)
                {
                    menu.Enabled = true;
                }
                if (cutIndex < 0 && copyItem == null)
                {
                    strip_Insert.Enabled = false;
                }

                if (_DataGrid.CurrentRow != null)
                {
                    currentIndex = _DataGrid.CurrentRow.Index;
                    if (currentIndex == 0)
                    {
                        strip_ShiftUp.Enabled = false;
                    }
                    if (currentIndex == _DataGrid.Rows.Count - 1)
                    {
                        strip_ShiftDown.Enabled = false;
                    }
                }
                else
                {
                    currentIndex = -1;
                    strip_ShiftUp.Enabled = false;
                    strip_ShiftDown.Enabled = false;
                    strip_Edit.Enabled = false;
                    strip_Copy.Enabled = false;
                    strip_Cut.Enabled = false;
                    strip_RemoveAt.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void OnStrip_Copy(object sender, EventArgs e)
        {
            this._DataGrid.CurrentCell = null;
            this._DataGrid.CurrentCell = this._DataGrid.Rows[currentIndex].Cells[0];
            copyItem = (T)_DataSource[currentIndex];
            cutIndex = -1;
        }

        private void OnStrip_ShiftUp(object sender, EventArgs e)
        {
            int CurrentIndex = _DataGrid.CurrentRow.Index;
            var temp = _DataSource[CurrentIndex];
            _DataSource[CurrentIndex] = _DataSource[CurrentIndex - 1];
            _DataSource[CurrentIndex - 1] = temp;
            UpdateGridView();
            this._DataGrid.CurrentCell = this._DataGrid.Rows[CurrentIndex - 1].Cells[0];
        }

        private void OnStrip_ShiftDown(object sender, EventArgs e)
        {
            int CurrentIndex = _DataGrid.CurrentRow.Index;
            var temp = _DataSource[CurrentIndex];
            _DataSource[CurrentIndex] = _DataSource[CurrentIndex + 1];
            _DataSource[CurrentIndex + 1] = temp;
            UpdateGridView();
            this._DataGrid.CurrentCell = this._DataGrid.Rows[CurrentIndex + 1].Cells[0];
        }

        private void OnStrip_Cut(object sender, EventArgs e)
        {
            this._DataGrid.CurrentCell = null;
            this._DataGrid.CurrentCell = this._DataGrid.Rows[currentIndex].Cells[0];
            cutIndex = currentIndex;
            copyItem = default(T);
        }

        private void OnStrip_Insert(object sender, EventArgs e)
        {
            //剪切粘贴
            if (cutIndex > -1)
            {
                var temp = _DataSource[cutIndex];
                if (currentIndex < 0)
                {
                    _DataSource.RemoveAt(cutIndex);
                    _DataSource.Add(temp);
                }
                else
                {
                    if (currentIndex <= cutIndex)
                    {
                        _DataSource.RemoveAt(cutIndex);
                        _DataSource.Insert(currentIndex, temp);
                    }
                    else
                    {
                        _DataSource.Insert(currentIndex, temp);
                        _DataSource.RemoveAt(cutIndex);
                    }
                }
                UpdateGridView();
                this._DataGrid.CurrentCell = this._DataGrid.Rows[currentIndex <= cutIndex ? currentIndex : currentIndex - 1].Cells[0];
            }
            else if (copyItem != null)//复制粘贴
            {
                if (currentIndex < 0)
                    _DataSource.Add((T)copyItem.Clone());
                else
                    _DataSource.Insert(currentIndex, (T)copyItem.Clone());
                UpdateGridView();
                this._DataGrid.CurrentCell = this._DataGrid.Rows[currentIndex].Cells[0];
            }
            cutIndex = -1;
            copyItem = default(T);
        }

        private void OnStrip_RemoveAt(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("确定要刪除嘛?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    int count = _DataGrid.SelectedRows.Count;
                    List<int> lstIndex = new List<int>();
                    if (count > 0)
                    {
                        for (int i = count - 1; i > -1; i--)
                        {
                            int index = _DataGrid.SelectedRows[i].Index;
                            lstIndex.Add(index);
                        }
                        if (lstIndex.Count > 0)
                        {
                            lstIndex.Sort();
                            for (int i = lstIndex.Count - 1; i > -1; i--)
                            {
                                _DataSource.RemoveAt(lstIndex[i]);
                            }
                            UpdateGridView();
                            if (lstIndex[0] < _DataSource.Count)
                            {
                                this._DataGrid.CurrentCell = this._DataGrid.Rows[lstIndex[0]].Cells[0];
                            }
                        }
                        cutIndex = -1;
                        copyItem = default(T);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateGridView()
        {
            try
            {
                _DataGrid.DataSource = new BindingList<T>(_DataSource);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
