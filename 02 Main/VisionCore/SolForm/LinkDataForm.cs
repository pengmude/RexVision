using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DockContrl;
using VisionCore;

using System.Reflection;
using RexView;
using RexConst;

namespace VisionCore
{
    /// <summary>
    /// 数据连接模式
    /// </summary>
    public enum LinkDataForm
    {
        Script,//脚本模式
        VarLink//变量链接
    }
    /// <summary>
    /// 数据回传委托
    /// </summary>
    /// <param name="str"></param>
    public delegate void AddVarText(string str);
    public partial class PluginDataLinkForm : DockForm
    {
        /// <summary>
        /// 数据回传事件
        /// </summary>
        public event AddVarText AddVarTextEvent;
        /// <summary>
        /// 连接数据-模块名称
        /// </summary>
        public string m_ModName = string.Empty;
        /// <summary>
        /// 数据连接-变量名称
        /// </summary>
        public string m_DataName = string.Empty;
        /// <summary>
        /// 返回数据
        /// </summary>
        public string m_OutLinkData { get; private set; } = string.Empty;
        /// <summary>
        /// 变量列表
        /// </summary>
        private List<DataCell> mVarList = new List<DataCell>();
        /// <summary>
        /// 模块数据界面
        /// </summary>
        /// <param name="ProjName">项目名称</param>
        /// <param name="ModName">模块名称</param>
        /// <param name="varType">变量类型</param>
        /// <param name="dataLinkFormModel">连接</param>
        public PluginDataLinkForm(string ProjName, string ModName, VarType varType, LinkDataForm dataLinkFormModel)
        {
            try
            {
                this.Set_MinMax();
                InitializeComponent();
                m_ModName = ModName;
                Proj mProj = Sol.mSol.mProjList.FirstOrDefault(c => c.mProjInfo.Name == ProjName);
                foreach (DataCell Var in mProj.mSysVar)
                {
                    TreeNode TreeNode_A = new TreeNode(Var.mModName);
                    TreeNode TreeNode_B = null;
                    foreach (TreeNode m_Nodes in tre_ModList.Nodes)
                    {
                        if (TreeNode_A.Text == m_Nodes.Text)
                        {
                            TreeNode_B = m_Nodes;
                        }
                    }
                    if (TreeNode_B == null)
                    {
                        TreeNode TreeNode_C = new TreeNode(Var.mModName);
                        tre_ModList.Nodes.Add(TreeNode_C);
                    }
                }
                foreach (ObjBase Obj in mProj.mObjBase)
                {
                    mVarList = Obj.mSloVar;
                }
                foreach (DataCell Var in mVarList)
                {
                    TreeNode TreeNode_A = new TreeNode(Var.mModName);
                    TreeNode TreeNode_B = null;
                    foreach (TreeNode m_Nodes in tre_ModList.Nodes)
                    {
                        if (TreeNode_A.Text == m_Nodes.Text)
                        {
                            TreeNode_B = m_Nodes;
                        }
                    }
                    if (TreeNode_B == null)
                    {
                        TreeNode TreeNode_C = new TreeNode(Var.mModName);
                        tre_ModList.Nodes.Add(TreeNode_C);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        /// <summary>选择模块</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tre_ModList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DataCell mDataCell = new DataCell();
                m_DataName = tre_ModList.SelectedNode.Text;
                switch (m_DataName.Substring(0, 2))
                {
                    case "标签":
                        mDataCell = mVarList.First(c => c.mModName.ToString() == m_DataName);
                        break;
                    case "全局":
                        {
                            List<DataCell> mAllData = Sol.mSol.mSysVar.FindAll(c => c.mModName.ToString() == m_DataName);
                            dgv_VarList.Rows.Clear();
                            for (int i = 0; i < mAllData.Count; ++i)
                            {
                                dgv_VarList.Rows.Add();
                                dgv_VarList.Rows[i].Cells[0].Value = mAllData[i].mDataMode;
                                dgv_VarList.Rows[i].Cells[1].Value = mAllData[i].mDataName;
                                dgv_VarList.Rows[i].Cells[2].Value = mAllData[i].mDataValue;
                            }
                            dgv_VarList.SelectedIndex = 0;
                            return;
                        }
                    case "数据"://PLC
                        {
                            int index = 0;
                            List<Char_Info> mChar_Info = ((List<Char_Info>)mVarList.Find(c => c.mModName == m_DataName).mDataValue);
                            dgv_VarList.Rows.Clear();
                            foreach (Char_Info vars in mChar_Info)
                            {
                                dgv_VarList.Rows.Add();
                                dgv_VarList.Rows[index].Cells[0].Value = vars.Index;
                                dgv_VarList.Rows[index].Cells[1].Value = vars.Name;
                                dgv_VarList.Rows[index].Cells[2].Value = vars.Result;
                                ++index;
                            }
                            dgv_VarList.SelectedIndex = 0;
                            return;
                        }
                    case "变量":
                        {
                            if (m_DataName.Contains("变量定义"))
                            {
                                List<DataCell> mAllData = mVarList.FindAll(c => c.mModName.ToString() == m_DataName);
                                dgv_VarList.Rows.Clear();
                                for (int i = 0; i < mAllData.Count; ++i)
                                {
                                    dgv_VarList.Rows.Add();
                                    dgv_VarList.Rows[i].Cells[0].Value = mAllData[i].mDataMode;
                                    dgv_VarList.Rows[i].Cells[1].Value = mAllData[i].mDataName;
                                    dgv_VarList.Rows[i].Cells[2].Value = mAllData[i].mDataValue;
                                }
                                dgv_VarList.SelectedIndex = 0;
                                return;
                            }
                            else
                            {
                                int index = 0;
                                List<Char_Info> mChar_Info = ((List<Char_Info>)mVarList.Find(c => c.mModName == m_DataName).mDataValue);
                                dgv_VarList.Rows.Clear();
                                foreach (Char_Info vars in mChar_Info)
                                {
                                    dgv_VarList.Rows.Add();
                                    dgv_VarList.Rows[index].Cells[0].Value = vars.Index;
                                    dgv_VarList.Rows[index].Cells[1].Value = vars.Name;
                                    dgv_VarList.Rows[index].Cells[2].Value = vars.Result;
                                    ++index;
                                }
                                dgv_VarList.SelectedIndex = 0;
                                return;
                            }
                        }
                    case "亮度1"://PLC
                        {
                            int index = 0;
                            List<Luma_Info> mLuma_Info = ((List<Luma_Info>)mVarList.Find(c => c.mModName == m_DataName).mDataValue);
                            dgv_VarList.Rows.Clear();
                            foreach (Luma_Info vars in mLuma_Info)
                            {
                                dgv_VarList.Rows.Add();
                                dgv_VarList.Rows[index].Cells[0].Value = vars.Status;
                                dgv_VarList.Rows[index].Cells[1].Value = vars.Status;
                                dgv_VarList.Rows[index].Cells[2].Value = vars.Status;
                                ++index;
                            }
                            dgv_VarList.SelectedIndex = 0;
                            return;
                        }
                    default:
                        mDataCell = mVarList.First(c => c.mModName.ToString() == m_DataName);
                        break;
                }
                List<string> FieldList = null;
                switch (mDataCell.mDataMode)
                {
                    case DataMode.点点:
                        FieldList = Var.GetField(new PtoP_Info());
                        dgv_VarList.Rows.Clear();
                        for (int i = 0; i < FieldList.Count; ++i)
                        {
                            dgv_VarList.Rows.Add();
                            dgv_VarList.Rows[i].Cells[0].Value = "double";
                            dgv_VarList.Rows[i].Cells[1].Value = FieldList[i];
                            string ReadStr = mDataCell.mDataAtrr == DataAtrr.系统变量 ? Var.GetLinkData(Sol.mSol.mSysVar, m_DataName + ":" + FieldList[i]) : Var.GetLinkData(mVarList, m_DataName + ":" + FieldList[i]);
                            ReadStr = ReadStr.Replace("|", "").Replace(m_DataName, "").Replace(FieldList[i], "");
                            dgv_VarList.Rows[i].Cells[2].Value = ReadStr;
                        }
                        dgv_VarList.SelectedIndex = 0;
                        break;
                    case DataMode.点2D:
                        FieldList = Var.GetField(new RPoint());
                        break;
                    case DataMode.自定义:
                        FieldList = Var.GetField(new Rtn_Info());
                        break;
                    case DataMode.图像:
                        FieldList = Var.GetField(new RImage());
                        break;
                    case DataMode.圆:
                        FieldList = Var.GetField(new Circle_Info());
                        break;
                    case DataMode.直线:
                        FieldList = Var.GetField(new Line_Info());
                        break;
                    case DataMode.坐标系:
                        FieldList = Var.GetField(new Coord_Info());
                        break;
                    case DataMode.平移矩阵:
                    case DataMode.旋转矩阵:
                        FieldList = new List<string>() { "HHomMat2D" };
                        break;
                    case DataMode.标定信息:
                        FieldList = Var.GetField(new Cal_Info());
                        break;
                    case DataMode.StringArr:
                        FieldList = Var.GetField(new Luma_Info());
                        break;
                    default:
                        FieldList = new List<string>() { mDataCell.mDataName };
                        break;
                }
                dgv_VarList.Rows.Clear();
                for (int i = 0; i < FieldList.Count; ++i)
                {
                    dgv_VarList.Rows.Add();
                    dgv_VarList.Rows[i].Cells[0].Value = mDataCell.mDataMode;
                    dgv_VarList.Rows[i].Cells[1].Value = FieldList[i];
                    string ReadStr = mDataCell.mDataAtrr == DataAtrr.系统变量 ? Var.GetLinkData(Sol.mSol.mSysVar, m_DataName + ":" + FieldList[i]) : Var.GetLinkData(mVarList, m_DataName + ":" + FieldList[i]);
                    ReadStr = ReadStr.Replace("|", "").Replace(m_DataName, "").Replace(FieldList[i], "");
                    dgv_VarList.Rows[i].Cells[2].Value = ReadStr;
                }
                dgv_VarList.SelectedIndex = 0;
            }
            catch { }
        }
        private void dgv_VarList_SelectIndexChange(object sender, int index)
        {
            if (m_ModName.StartsWith("PLC写入"))
            {
                m_OutLinkData = dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[0].Value.ToString() + "|" + m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
            }
            else
            {
                m_OutLinkData = m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
            }
        }
        private void dgv_VarList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (m_ModName.StartsWith("PLC写入"))
            {
                m_OutLinkData = dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[0].Value.ToString() + "|" + m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
            }
            else
            {
                m_OutLinkData = m_DataName + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[1].Value.ToString() + "|" + dgv_VarList.Rows[dgv_VarList.SelectedIndex].Cells[2].Value.ToString();
            }
            this.Close();
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_NO_Click(object sender, EventArgs e)
        {
            m_OutLinkData = " | ";
            this.Close();
        }
    }
}
