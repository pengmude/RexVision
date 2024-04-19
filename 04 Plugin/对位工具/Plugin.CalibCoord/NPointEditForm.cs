using DockContrl;
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

namespace Plugin.NPointCal
{
    public partial class NPointEditForm : DockForm
    { 
        /// <summary>取消还原点数据</summary>
        UIDataGridView mdgv_back;//
        /// <summary>确定返回点数据</summary>
        public List<NPoint> mEditNPoint = new List<NPoint>();
        public NPointEditForm()
        {
            InitializeComponent();
        }
        public NPointEditForm(UIDataGridView dataGrid, CalType calType)
        {
            this.Set_MinMax();
            InitializeComponent();
            mdgv_back = dataGrid;
            switch (calType)
            {
                case CalType.自动:
                    this.uibt_OK.Enabled = false;
                    this.tb_Point.ReadOnly = true;
                    this.titlelabel.Text = "快速编辑-只读";
                    break;
                case CalType.手动:
                    this.uibt_OK.Enabled = true;
                    this.tb_Point.ReadOnly = false;
                    this.titlelabel.Text = "快速编辑";
                    break;
            }
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                string data = string.Empty;
                for (int j = 0; j < dataGrid.ColumnCount; j++)
                {
                    data += dataGrid.Rows[i].Cells[j].Value.ToString().PadLeft(2, '0') + " ";
                }
                tb_Point.Text += data + "\r\n";
            }
        }
        private void uibt_OK_Click(object sender, EventArgs e)
        {
            mEditNPoint.Clear();
            int index = tb_Point.Lines.Length;
            string[] str = tb_Point.Text.Split(' '); 
            for (int i = 0; i < index; ++i)
            {
                if (tb_Point.Lines[i].Length > 10)
                {
                    string[] NewPoint = tb_Point.Lines[i].Split(' ');
                    NPoint mNPoint = new NPoint();
                    mNPoint.Index = int.Parse(NewPoint[0]);
                    mNPoint.ImageX = double.Parse(NewPoint[1]);
                    mNPoint.ImageY = double.Parse(NewPoint[2]);
                    mNPoint.RobotX = double.Parse(NewPoint[3]);
                    mNPoint.RobotY = double.Parse(NewPoint[4]);
                    mEditNPoint.Add(mNPoint);                 
                }
                else
                {
                    Log.Error("第 " + i + " 行长度不对，请检查!");

                }
            }
            Close();
        }
        private void uibt_NO_Click(object sender, EventArgs e)
        {
            mEditNPoint.Clear();
            for (int i = 0; i < mdgv_back.RowCount; ++i)
            {
                NPoint mNPoint = new NPoint();
                mNPoint.Index = (int)mdgv_back.Rows[i].Cells[0].Value;
                mNPoint.ImageX = (double)mdgv_back.Rows[i].Cells[1].Value;
                mNPoint.ImageY = (double)mdgv_back.Rows[i].Cells[2].Value;
                mNPoint.RobotX = (double)mdgv_back.Rows[i].Cells[3].Value;
                mNPoint.RobotY = (double)mdgv_back.Rows[i].Cells[4].Value;
                mEditNPoint.Add(mNPoint);
            }
            this.Close();
        }
    }
}
