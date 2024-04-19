using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RexHelps
{
    public static class RExcel
    {
        public static DataTable ToDataTable(this DataGridView dataGridView, string tableName = null)
        {
            DataGridView dgv = dataGridView;
            DataTable table = new DataTable(tableName);
            for (int iCol = 0; iCol < dgv.Columns.Count; iCol++)
            {
                table.Columns.Add(dgv.Columns[iCol].Name);
            }
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
        #region Table to Excel
        /// <summary>
        /// 把Excel数据导入DataTable
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static DataTable ExcelToTable(string file)
        {
            /// cuiguangyuan
            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                //XSSFWorkbook 适用XLSX格式，HSSFWorkbook 适用XLS格式
                if (fileExt == ".xlsx") { workbook = new XSSFWorkbook(fs); } else if (fileExt == ".xls") { workbook = new HSSFWorkbook(fs); } else { workbook = null; }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(0);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0; i < header.LastCellNum; i++)
                {
                    object obj = GetValueType(header.GetCell(i));
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(i);
                }
                //数据  
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Datable导出成Excel
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="file"></param>
        public static void TableToExcel(DataTable dt, string file)
        {
            try
            {
                IWorkbook workbook;
                string fileExt = Path.GetExtension(file).ToLower();
                if (fileExt == ".xlsx")
                { workbook = new XSSFWorkbook(); }
                else if (fileExt == ".xls")
                { workbook = new HSSFWorkbook(); }
                else
                {
                    return;
                }
                ISheet sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("Sheet1") : workbook.CreateSheet(dt.TableName);

                int sheetCount = 1;
                int rowCount = 0;
                IRow row;
                //数据  
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (rowCount >= 65535)      //数据大于65536个的时候，新建一个Sheet
                    {
                        rowCount = 0;
                        sheetCount++;
                        sheet = string.IsNullOrEmpty(dt.TableName) ? workbook.CreateSheet("Sheet" + sheetCount) : workbook.CreateSheet(dt.TableName);

                    }
                    if (rowCount == 0)      //当新建一个Sheet之后，重新插入表头
                    {
                        //表头  
                        row = sheet.CreateRow(0);
                        for (int x = 0; x < dt.Columns.Count; x++)
                        {
                            ICell cell = row.CreateCell(x);
                            cell.SetCellValue(dt.Columns[x].ColumnName);
                        }
                    }
                    row = sheet.CreateRow(rowCount + 1);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell cell = row.CreateCell(j);
                        cell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                    rowCount++;
                }

                //转为字节数组  
                MemoryStream stream = new MemoryStream();
                workbook.Write(stream);
                var buf = stream.ToArray();

                //保存为Excel文件  
                using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(buf, 0, buf.Length);
                    fs.Flush();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 获取单元格类型
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private static object GetValueType(ICell cell)
        {
            if (cell == null)
                return null;
            switch (cell.CellType)
            {
                case CellType.Blank: //BLANK:  
                    return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                case CellType.Numeric: //NUMERIC:  
                    return cell.NumericCellValue;
                case CellType.String: //STRING:  
                    return cell.StringCellValue;
                case CellType.Error: //ERROR:  
                    return cell.ErrorCellValue;
                case CellType.Formula: //FORMULA:  
                default:
                    return "=" + cell.CellFormula;
            }
        }
        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static Boolean CreateDirectory(String filePath)
        {
            try
            {
                if (!System.IO.File.Exists(System.IO.Path.GetDirectoryName(filePath)))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filePath));
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion
        #region DataGridView to Excel
        // <summary>
        /// DataTable导出到Excel的MemoryStream
        /// </summary>
        /// <param name="myDgv">源DataTable</param>
        /// <param name="filepath">文件路径</param>
        public static MemoryStream DataGridViewToExcel(DataGridView myDgv, string filepath)
        {

            IWorkbook workbook;
            string fileExt = Path.GetExtension(filepath).ToLower();
            if (fileExt == ".xlsx")     //根据文件扩展名，实例化XSSFWorkbook或者HSSFWorkbook
            {
                workbook = new XSSFWorkbook();
            }
            else if (fileExt == ".xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                workbook = null;
                MemoryStream ms1 = new MemoryStream();
                return ms1;
            }


            //#region 右击文件 属性信息
            //{
            //    DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            //    dsi.Company = "NPOI";
            //    workbook.DocumentSummaryInformation = dsi;

            //    SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            //    si.Author = "文件作者信息"; //填加xls文件作者信息
            //    si.ApplicationName = "创建程序信息"; //填加xls文件创建程序信息
            //    si.LastAuthor = "最后保存者信息"; //填加xls文件最后保存者信息
            //    si.Comments = "作者信息"; //填加xls文件作者信息
            //    si.Title = "标题信息"; //填加xls文件标题信息
            //    si.Subject = "主题信息";//填加文件主题信息
            //    si.CreateDateTime = System.DateTime.Now;
            //    workbook.SummaryInformation = si;
            //}
            //#endregion
            ISheet sheet = workbook.CreateSheet();
            ICellStyle dateStyle = workbook.CreateCellStyle();
            IDataFormat format = workbook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            ////取得列宽
            //int[] arrColWidth = new int[myDgv.Columns.Count];
            //foreach (DataGridViewColumn item in myDgv.Columns)
            //{
            //    //arrColWidth[item.Index] = Encoding.GetEncoding(936).GetBytes(item.HeaderText.ToString()).Length;
            //    arrColWidth[item.Index] = item.Width;
            //}
            //for (int i = 0; i < myDgv.Rows.Count; i++)
            //{
            //    for (int j = 0; j < myDgv.Columns.Count; j++)
            //    {
            //        int intTemp = Encoding.GetEncoding(936).GetBytes(myDgv.Rows[i].Cells[j].ToString()).Length;
            //        if (intTemp > arrColWidth[j])
            //        {
            //            arrColWidth[j] = intTemp;
            //        }
            //    }
            //}
            int rowIndex = 0;
            foreach (DataGridViewRow row in myDgv.Rows)
            {
                #region 新建表，填充表头，填充列头，样式
                if (rowIndex == 65536 || rowIndex == 0)
                {
                    if (rowIndex != 0)
                    {
                        sheet = workbook.CreateSheet();

                    }

                    #region 列头及样式
                    {
                        IRow headerRow = sheet.CreateRow(0);    //设置列头在第几行
                        ICellStyle headStyle = workbook.CreateCellStyle();
                        IFont font = workbook.CreateFont();

                        font.FontHeightInPoints = 10;
                        font.Boldweight = 700;
                        headStyle.SetFont(font);
                        foreach (DataGridViewColumn column in myDgv.Columns)        //遍历设置列表头
                        {
                            headerRow.CreateCell(column.Index).SetCellValue(column.HeaderText);
                            headerRow.GetCell(column.Index).CellStyle = headStyle;

                            //设置列宽
                            //sheet.SetColumnWidth(column.Index, (arrColWidth[column.Index] + 1) * 256);
                            //sheet.AutoSizeColumn(column.Index);     //自动适应列宽
                        }
                        // headerRow.Dispose();
                    }
                    #endregion

                    rowIndex = 1;   //设置正体内容在第几行显示
                }
                #endregion


                #region 填充内容
                IRow dataRow = sheet.CreateRow(rowIndex);
                if (row.Index >= 0) //edit by huangwenzhuo at 2017/12/5 16;58
                {
                    foreach (DataGridViewTextBoxColumn column in myDgv.Columns)
                    {
                        ICell newCell = dataRow.CreateCell(column.Index);

                        string drValue = myDgv[column.Index, row.Index].Value == null ? "" : myDgv[column.Index, row.Index].Value.ToString(); //edit by huangwenzhuo at 2017/12/5 16;58

                        switch (column.ValueType.ToString())
                        {
                            case "System.String"://字符串类型
                                newCell.SetCellValue(drValue);
                                break;
                            case "System.DateTime"://日期类型
                                System.DateTime dateV;
                                System.DateTime.TryParse(drValue, out dateV);
                                newCell.SetCellValue(dateV);

                                newCell.CellStyle = dateStyle;//格式化显示
                                break;
                            case "System.Boolean"://布尔型
                                bool boolV = false;
                                bool.TryParse(drValue, out boolV);
                                newCell.SetCellValue(boolV);
                                break;
                            case "System.Int16"://整型
                            case "System.Int32":
                            case "System.Int64":
                            case "System.Byte":
                                int intV = 0;
                                int.TryParse(drValue, out intV);
                                newCell.SetCellValue(intV);
                                break;
                            case "System.Decimal"://浮点型
                            case "System.Double":
                                double doubV = 0;
                                double.TryParse(drValue, out doubV);
                                newCell.SetCellValue(doubV);
                                break;
                            case "System.DBNull"://空值处理
                                newCell.SetCellValue("");
                                break;
                            default:
                                newCell.SetCellValue("");
                                break;
                        }
                    }
                }
                else
                { rowIndex--; }
                #endregion

                rowIndex++;     //下一行
            }
            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                ms.Flush();

                return ms;
            }
        }
        /// <summary>
        /// DataGridView导出到Excel文件
        /// </summary>
        /// <param name="dtSource">源DataTGridview</param>
        /// <param name="strHeaderText">表头文本</param>
        /// <param name="strFileName">保存位置</param>
        public static void DataGridViewToExcelFirst(DataGridView myDgv, string strFilePath)
        {
            using (MemoryStream ms = DataGridViewToExcel(myDgv, strFilePath))
            {

                using (FileStream fs = new FileStream(strFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
            }
        }
        #endregion
    }
}
