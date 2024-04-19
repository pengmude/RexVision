using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.NPointCal
{
    public enum PointType
    {
        Three, Nine, FourTeen
    }
    public enum CalType
    {
        自动, 手动
    }
    public enum CamerType
    {
        固定, 移动
    }
    public enum AngleType
    {
        固定, 变化
    }
    public class CalHelp
    {
        /// <summary>
        /// 自动计算九点
        /// 3点：1-3,从1开始
        /// 9点：1-9,从1开始
        /// 5点:10-14 从9开始 忽略间隔
        /// </summary>
        /// <param name="index">索引:1-9,从1开始</param>
        /// <param name="basePoint">基准X,Y</param>
        /// <param name="spacePoint">间距X,Y</param>
        /// <returns></returns>
        public static RPoint GetPoint(int index, RPoint basePoint, RPoint spacePoint)
        {
            RPoint mPoint = new RPoint();
            switch (index)
            {
                case 1:
                    mPoint.X = basePoint.X;
                    mPoint.Y = basePoint.Y;
                    break;
                case 2:
                    mPoint.X = basePoint.X + spacePoint.X;
                    mPoint.Y = basePoint.Y;
                    break;
                case 3:
                    mPoint.X = basePoint.X + spacePoint.X;
                    mPoint.Y = basePoint.Y - spacePoint.Y;
                    break;
                case 4:
                    mPoint.X = basePoint.X;
                    mPoint.Y = basePoint.Y - spacePoint.Y;
                    break;
                case 5:
                    mPoint.X = basePoint.X - spacePoint.X;
                    mPoint.Y = basePoint.Y - spacePoint.Y;
                    break;
                case 6:
                    mPoint.X = basePoint.X - spacePoint.X;
                    mPoint.Y = basePoint.Y;
                    break;
                case 7:
                    mPoint.X = basePoint.X - spacePoint.X;
                    mPoint.Y = basePoint.Y + spacePoint.Y;
                    break;
                case 8:
                    mPoint.X = basePoint.X;
                    mPoint.Y = basePoint.Y + spacePoint.Y;
                    break;
                case 9:
                    mPoint.X = basePoint.X + spacePoint.X;
                    mPoint.Y = basePoint.Y + spacePoint.Y;
                    break;
                default:
                    mPoint.X = basePoint.X + spacePoint.X;
                    mPoint.Y = basePoint.Y + spacePoint.Y;
                    break;
            }
            return mPoint;
        }
        public static DataTable BuidTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Index", Type.GetType("System.Int32"));
            dt.Columns.Add("ImageX", Type.GetType("System.Double"));
            dt.Columns.Add("ImageY", Type.GetType("System.Double"));
            dt.Columns.Add("RobotX", Type.GetType("System.Double"));
            dt.Columns.Add("RobotY", Type.GetType("System.Double"));
            return dt;
        }
        public static DataTable ToDataTable(DataGridView dgv, string tableName = null)
        {
            DataTable table = BuidTable();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow datarw = table.NewRow();
                for (int iCol = 0; iCol < dgv.Columns.Count; iCol++)
                {
                    datarw[iCol] = row.Cells[iCol].Value;
                }
                table.Rows.Add(datarw);
            }
            return table;
        }
        public static DataTable CombineTwoTable(DataTable dt1, DataTable dt2)
        {
            DataTable newDt = BuidTable();
            var results = (from d1 in dt1.AsEnumerable()
                           join d2 in dt2.AsEnumerable()
on d1.Field<string>("Index") equals d2.Field<string>("Index")
                           select newDt.LoadDataRow(new object[]{d1.Field<string>("Index"),d1.Field<string>("ImageX"),d2.Field<string>("ImageY")
                           }, true));
            newDt = results.CopyToDataTable();
            return newDt;
        }
    }
}
