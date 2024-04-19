using Rex.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.VarDefine
{
    public partial class VarDefineForm : FormBase
    {
        VarDefineObj mObj;
        public VarDefineForm(VarDefineObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
            RefreshVarList();
        }
        private void VarDefineModForm_Load(object sender, EventArgs e){}
        private void RefreshVarList()
        {
            if (mObj.mVarList == null) return;
            if (mObj.mVarList.Count == 0) return;
            int index = 0;
            dgv_VarList.Rows.Clear();
            foreach (DataCell data in mObj.mVarList)
            {
                dgv_VarList.Rows.Add();
                dgv_VarList.Rows[index].Cells[0].Value = data.mDataMode;
                dgv_VarList.Rows[index].Cells[1].Value = data.mDataName;
                dgv_VarList.Rows[index].Cells[2].Value = data.mDataValue;
                dgv_VarList.Rows[index].Cells[3].Value = data.mDataTip;
                ++index;
            }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            mObj.mVarList.Clear();
            for (int i = 0; i < dgv_VarList.RowCount; ++i)
            {
                DataMode type = (DataMode)Enum.Parse(typeof(DataMode), dgv_VarList.Rows[i].Cells[0].Value.ToString());
                string name = dgv_VarList.Rows[i].Cells[1].Value.ToString();
                string value = dgv_VarList.Rows[i].Cells[2].Value.ToString();
                string remark = dgv_VarList.Rows[i].Cells[3].Value.ToString();
                mObj.mVarList.Add(new DataCell(mObj.ModInfo.Name, 0, DataType.单量, type, name, remark, "0", i, value, DataAtrr.全局变量));
            }
        }
        private void uibt_Add_Click(object sender, EventArgs e)
        {
            UIButton button = sender as UIButton;
            switch (button.Text)
            {
                case " 添加Int":
                case " 添加Bool":
                case " 添加Double":
                case " 添加String":
                    string type = button.Text.Replace(" 添加", "");
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dgv_VarList);
                    dr.Cells[0].Value = type;
                    dr.Cells[1].Value = "Var" + dgv_VarList.Rows.Count;
                    dr.Cells[2].Value = type.Contains("bool") ? "false" : "0";
                    dr.Cells[3].Value = "";
                    dgv_VarList.Rows.Add(dr);     //插入的数据作为第一行显示
                    break;
            }
        }
        #region DataGridView  操作
        private void 列表操作(object sender, EventArgs e)
        {
            if (dgv_VarList.SelectedRows == null || dgv_VarList.SelectedRows.Count == 0)
            {
                MessageBox.Show("单击第一列以选中行");
            }
            UIButton button = sender as UIButton;
            switch (button.Text)
            {
                case "添加":
                    AddDataGridView(dgv_VarList);
                    break;
                case "删除":
                    RemovDataGridView(dgv_VarList);
                    break;
                case "上移":
                    UpDataGridView(dgv_VarList);
                    break;
                case "下移":
                    DownDataGridView(dgv_VarList);
                    break;
                case "置顶":
                    TopDataGridView(dgv_VarList);
                    break;
                case "置底":
                    BottomDataGridView(dgv_VarList);
                    break;
            }
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void AddDataGridView(DataGridView dataGridView)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(dataGridView);
            dr.Cells[0].Value = "";
            dr.Cells[1].Value = "Var" + dataGridView.Rows.Count;
            dr.Cells[2].Value = "";
            dr.Cells[3].Value = "";
            //dataGridView.Rows.Insert(0, dr);    //添加的行作为第一行
            dataGridView.Rows.Add(dr);//添加的行作为最后一行
        }
        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void UpDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index - dgvsrc.Count];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index - dgvsrc.Count);//删除原选中行的上一行
                        dataGridView.Rows.Insert((index), dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dataGridView.Rows[index - i - 1].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void DownDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index >= 0 & (dataGridView.RowCount - 1) != index)//如果该行不是最后一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index + 1];//获取选中行的下一行
                        dataGridView.Rows.RemoveAt(index + 1);//删除原选中行的上一行
                        dataGridView.Rows.Insert((index + 1 - dgvsrc.Count), dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dgvsrc.Count; i++)//选中移动后的行
                        {
                            dataGridView.Rows[index + 1 - i].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void TopDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index > 0)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index);//删除原选中行的上一行
                        dataGridView.Rows.Insert(0, dgvr);//将选中行的上一行插入到选中行的后面                       
                        for (int i = 0; i < dataGridView.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != 0)
                            {
                                dataGridView.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 置底
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void BottomDataGridView(DataGridView dataGridView)
        {
            try
            {
                DataGridViewSelectedRowCollection dgvsrc = dataGridView.SelectedRows;//获取选中行的集合
                if (dgvsrc.Count > 0)
                {
                    int index = dataGridView.SelectedRows[0].Index;//获取当前选中行的索引
                    if (index < dataGridView.Rows.Count - 1)//如果该行不是第一行
                    {
                        DataGridViewRow dgvr = dataGridView.Rows[index];//获取选中行的上一行
                        dataGridView.Rows.RemoveAt(index);//删除原选中行的上一行
                        int nCount = dataGridView.Rows.Count;
                        dataGridView.Rows.Insert(nCount, dgvr);//将选中行的上一行插入到选中行的后面
                        for (int i = 0; i < dataGridView.Rows.Count; i++)//选中移动后的行
                        {
                            if (i != dataGridView.Rows.Count - 1)
                            {
                                dataGridView.Rows[i].Selected = false;
                            }
                            else
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="dataGridView"></param>
        public static void RemovDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows == null || dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择删除步，单击第一列以选中行");
            }
            else
            {
                if (MessageBox.Show("确定要删除选中步吗？") == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in dataGridView.SelectedRows)
                    {
                        if (dr.IsNewRow == false)
                        {
                            //如果不是已提交的行，默认情况下在添加一行数据成功后，DataGridView为新建一行作为新数据的插入位置
                            dataGridView.Rows.Remove(dr);
                        }
                    }
                }
            }
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
