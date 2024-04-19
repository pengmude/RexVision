//************************************************************************************
// Copyright (c) 2017117 JIGTECH All Rights Reserved.
//  CLR version:      14.0
// Company Name:      JIGTECH
//     Filename:      Junzhi.RCopyPaste.cs
//      Version:      V1.0.0.0
//       Create:      longteng
//  Create time:      2017-11-7 17:10:25
//   Descrption:      剪贴板操作
//
//************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RexHelps
{
    /// <summary>
    /// 剪贴板操作
    /// </summary>
    public class RCopyPaste
    {
        /// <summary>
        /// 拷贝数据到粘贴板中
        /// </summary>
        /// <param name="input"></param>
        public static void CopyToClipboard(object input)
        {
            Clipboard.SetDataObject(input);
        }
        /// <summary>
        /// 获取粘贴板数据
        /// </summary>
        /// <returns></returns>
        public static string GetDataFromClipboard_string()
        {
            IDataObject iData = Clipboard.GetDataObject();
            string dst = "";
            if (iData.GetDataPresent(DataFormats.Text))
            {
                dst = (string)iData.GetData(DataFormats.Text);
            }
            return dst;
        }
        /// <summary>
        /// 清空粘贴板数据
        /// </summary>
        public static void ClearClipboard()
        {
            Clipboard.Clear();
        }
    }
}
