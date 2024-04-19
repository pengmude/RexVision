using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Script
{

    /// <summary>
    /// 脚本方法信息
    /// </summary>
    class ScriptMethodInfo
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name = null;
        /// <summary>
        /// 方法名称
        /// </summary>
        public string MethodName = null;
        /// <summary>
        /// 方法对象
        /// </summary>
        public MethodInfo MethodObject = null;
        /// <summary>
        /// 方法返回值
        /// </summary>
        public Type ReturnType = null;
        /// <summary>
        /// 指向该方法的委托
        /// </summary>
        public Delegate MethodDelegate = null;
        public string Description;
    }
    public class ScriptTemplate
    {
        /// <summary>
        /// vb系统关键字
        /// </summary>
        /// 
        public static string VBStringA()
        {
            string str1 = "List class extends implements import interface new case do while else if for in switch " +
                "throw get set function var try catch finally while with default break continue delete return each " +
                "const namespace package include use is as instanceof typeof author copy default deprecated eventType " +
                "example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial" +
                " serialData serialField since throws usage version langversion playerversion productversion dynamic private " +
                "public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity" +
                " NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal " +
                "default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto" +
                " group if implicit in int interface internal into is lock long new null namespace object operator out override orderby " +
                "params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string " +
                "select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield" +
                "Thread Task Int16 Int32 ";
            //string str2 = "HObject HHomMat2D HHandle Htuple RImage Himage VisionCore  DataCell List[DataCell] Line_Info Circle_Info Ellipse_Info Rect_Info Point Line Thread Task";
            return str1 ;
        }
        public static string VBStringB()
        {
            //string str1 = "List class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield";
            string str2 = "HObject HHomMat2D HHandle Htuple RImage Himage VisionCore  DataCell" +
                " List[DataCell] Line_Info Circle_Info Ellipse_Info Rect_Info Point Line " +
                "SolInfo Sol Projet ";
            return str2;
        }
    }
}
