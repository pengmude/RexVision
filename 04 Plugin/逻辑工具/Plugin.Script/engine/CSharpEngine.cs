using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Text;
using System.Threading;
using VisionCore;

using HalconDotNet;
namespace Plugin.Script
{
    [Serializable]
    /// <summary>
    /// 基于VB.NET的脚本引擎
    /// </summary>
    /// <remarks>
    /// 本对象能动态的设置和编译CSharp模块代码，并动态的执行其中定义的方法
    /// 编制 袁永福
    /// </remarks>
    /// 
    public class CSharpEngine : IDisposable
    {
        /// <summary>
        /// 脚本方法信息
        /// </summary>
        private class ScriptMethodInfo
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
        }
        public string 回传换行 = "\r\n";
        /// <summary>
        /// 脚本在运行过程中可否输出调试信息
        /// </summary>
        public bool OutputDebug { get; set; } = true;
        /// <summary>
        /// CSharp编译器参数
        /// </summary>
        private CompilerParameters myCompilerParameters = new CompilerParameters();

        /// <summary>
        /// 编译脚本生成的程序集
        /// </summary>
        private Assembly myAssembly = null;
        /// <summary>
        /// 所有缓存的程序集
        /// </summary>
        private static Hashtable myAssemblies = new Hashtable();
        /// <summary>
        /// 所有脚本方法的信息列表
        /// </summary>
        private ArrayList myScriptMethods = new ArrayList();
        private bool bolClosedFlag = false;
        /// <summary>
        /// 是否调试成功
        /// </summary>
        public bool bDebuged { get; private set; } = false;
        public CCalculate P
        {
            get;
            set;
        }
        /// <summary>
        /// 引用的名称列表
        /// </summary>
        public StringCollection ReferencedAssemblies => myCompilerParameters.ReferencedAssemblies;
        /// <summary>
        /// 源代码中使用的名称空间导入
        /// </summary>
        public StringCollection SourceImports { get; } = new StringCollection();
        /// <summary>
        /// VB编译器使用的名称空间导入
        /// </summary>
        public StringCollection VBCompilerImports { get; } = new StringCollection();
        /// <summary>
        /// 编译器输出文本
        /// </summary>
        public string CompilerOutput { get; private set; } = null;
        /// <summary>
        /// 脚本版本
        /// </summary>
        public int ScriptVersion { get; private set; } = 0;
        /// <summary>
        /// 获得脚本中所有的方法的名称组成的数组
        /// </summary>
        public string[] ScriptMethodNames
        {
            get
            {
                ArrayList names = new ArrayList();
                foreach (ScriptMethodInfo info in myScriptMethods)
                {
                    names.Add(info.MethodName);
                }
                return (string[])names.ToArray(typeof(string));
            }
        }
        /// <summary>
        /// 添加指定的类型所在的引用
        /// </summary>
        /// <param name="SourceType">对象类型</param>
        public void AddReferenceAssemblyByType(Type SourceType)
        {
            if (SourceType == null)
            {
                throw new ArgumentNullException("SourceType");
            }
            Uri uri = new Uri(SourceType.Assembly.CodeBase);
            string path = null;
            if (uri.Scheme == Uri.UriSchemeFile)
            {
                path = uri.LocalPath;
            }
            else
            {
                path = uri.AbsoluteUri;
            }
            if (myCompilerParameters.ReferencedAssemblies.Contains(path) == false)
            {
                myCompilerParameters.ReferencedAssemblies.Add(path);
            }
        }
        /// <summary>
        /// 初始化对象
        /// </summary>
        public CSharpEngine()
        {
            Init();
        }
        /// <summary>
        /// 初始化脚本引擎
        /// </summary>
        private void Init()
        {

            SourceImports.Add("System");
            SourceImports.Add("System.Linq");
            SourceImports.Add("System.Text");
            SourceImports.Add("System.Drawing");
            SourceImports.Add("System.Threading");
            SourceImports.Add("System.Diagnostics");
            SourceImports.Add("System.Windows.Forms");
            SourceImports.Add("System.Threading.Tasks");
            SourceImports.Add("System.Collections.Generic");
            SourceImports.Add("System.Text.RegularExpressions");
            SourceImports.Add("Microsoft.CSharp");
            SourceImports.Add("Microsoft.VisualBasic");
            SourceImports.Add("HalconDotNet");
            SourceImports.Add("VisionCore");
            //SourceImports.Add("VisionCore.Find");
            //SourceImports.Add("VisionCore.Msg");
            //SourceImports.Add("VisionCore.Tcp");
            //SourceImports.Add("VisionCore.Plc");
            //SourceImports.Add("VisionCore.Var");
            //SourceImports.Add("VisionCore.Aff");
            //SourceImports.Add("VisionCore.Dis");
            //SourceImports.Add("VisionCore.Fit");
            //SourceImports.Add("VisionCore.Cal");
            //SourceImports.Add("VisionCore.Csv");

            VBCompilerImports.Add("System.Linq");
            VBCompilerImports.Add("System.Drawing");
            VBCompilerImports.Add("System.Windows.Forms");
            VBCompilerImports.Add("Microsoft.VisualBasic");
            VBCompilerImports.Add("System.Collections.Generic");
            myCompilerParameters.ReferencedAssemblies.Add("System.dll");
            myCompilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
            myCompilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
            myCompilerParameters.ReferencedAssemblies.Add("System.Core.dll");
            myCompilerParameters.ReferencedAssemblies.Add("System.Data.dll");
            myCompilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
            myCompilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            myCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            myCompilerParameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
            myCompilerParameters.ReferencedAssemblies.Add("VisionCore.dll");
            myCompilerParameters.ReferencedAssemblies.Add("Visiondotnet.dll");
        }
        /// <summary>
        /// 清空脚本
        /// </summary>
        public void Clear()
        {
            myScriptMethods.Clear();
        }
        /// <summary>
        /// 编译脚本
        /// </summary>
        /// <returns>编译是否成功</returns>
        public string Compile(string strScriptText)
        {
            string strErrorMsg = string.Empty;
            if (bolClosedFlag)
            {

                return "对象被释放!";
            }
            ScriptVersion++;
            bDebuged = false;
            myScriptMethods.Clear();
            myAssembly = null;
            // 生成编译用的完整的源代码
            string nsName = "Plugin.Script";//命名空间
            string Name = "RunScript";//类命
            StringBuilder stringBuilder = new StringBuilder();
            StringEnumerator enumerator = SourceImports.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    string current = enumerator.Current;
                    stringBuilder.Append("using " + current + ";"+ 回传换行);
                }
            }
            finally
            {
                (enumerator as IDisposable)?.Dispose();
            }
            stringBuilder.Append("namespace " + nsName + "{" + 回传换行);
            stringBuilder.Append("[" + "Serializable" + "]" + 回传换行);
            stringBuilder.Append("class " + Name + "{" + 回传换行);
            stringBuilder.Append(strScriptText+回传换行);
            stringBuilder.Append("}}");
            string strRuntimeSource = stringBuilder.ToString();
            // 检查程序集缓存区
            myAssembly = (Assembly)myAssemblies[strRuntimeSource];
            if (myAssembly == null)
            {
                // 设置编译参数
                myCompilerParameters.GenerateExecutable = false;
                myCompilerParameters.GenerateInMemory = true;
                myCompilerParameters.IncludeDebugInformation = false;
                myCompilerParameters.OutputAssembly = "CScript";
                CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider();
                CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(myCompilerParameters, strRuntimeSource);
                StringBuilder stringBuilder2 = new StringBuilder();
                StringEnumerator enumerator2 = compilerResults.Output.GetEnumerator();
                try
                {
                    while (enumerator2.MoveNext())
                    {
                        string current2 = enumerator2.Current;
                        stringBuilder2.Append("\r\n" + current2);
                    }
                }
                finally
                {
                    (enumerator2 as IDisposable)?.Dispose();
                }
                CompilerOutput = stringBuilder2.ToString();
                if (OutputDebug && CompilerOutput.Length > 0)
                {
                    int num = 0;
                    for (int i = 0; i < compilerResults.Errors.Count; i++)
                    {
                        if (!compilerResults.Errors[i].IsWarning)
                        {
                            strErrorMsg += Environment.NewLine + "第 " + (compilerResults.Errors[i].Line - SourceImports.Count - 5).ToString() + " 行:  " + compilerResults.Errors[i].ErrorText;
                            num++;
                        }
                    }
                    strErrorMsg = (CompilerOutput = "检测出 " + num.ToString() + " 个错误:" + strErrorMsg);
                }
                cSharpCodeProvider.Dispose();
                if (!compilerResults.Errors.HasErrors)
                {
                    myAssembly = compilerResults.CompiledAssembly;
                }
                if (myAssembly != null)
                {
                    myAssemblies[strRuntimeSource] = myAssembly;
                }
                if (OutputDebug)
                {
                    // 输出调试信息
                    Console.WriteLine(" Compile CSharp script \r\n" + strRuntimeSource);
                    foreach (string dll in myCompilerParameters.ReferencedAssemblies)
                    {
                        Console.WriteLine("引用:" + dll);
                    }
                }
            }
            else
            {
                // 检索脚本中定义的类型
                Type ModType = myAssembly.GetType(nsName + "." + Name);
                if (ModType != null)
                {
                    MethodInfo[] array = ModType.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    foreach (MethodInfo methodInfo in array)
                    {
                        // 遍历类型中所有的静态方法
                        // 对每个方法创建一个脚本方法信息对象并添加到脚本方法列表中。
                        ScriptMethodInfo scriptMethodInfo = new ScriptMethodInfo();
                        scriptMethodInfo.MethodName = methodInfo.Name;
                        scriptMethodInfo.MethodObject = methodInfo;
                        scriptMethodInfo.Name = ModType.Name;
                        scriptMethodInfo.ReturnType = methodInfo.ReturnType;
                        myScriptMethods.Add(scriptMethodInfo);
                        if (OutputDebug)
                        {
                            strErrorMsg += ("方法:\"" + methodInfo.Name + "\"") + "\r\n";
                        }
                    }
                    bDebuged = true;
                }
                strErrorMsg = ("编译成功!") + "\r\n"+ strErrorMsg;
            }
            return strErrorMsg;
        }
        /// <summary>
        /// 关闭对象
        /// </summary>
        public void Close()
        {
            ScriptVersion++;
            bolClosedFlag = true;
            myScriptMethods.Clear();
            myAssembly = null;
            if (OutputDebug)
            {
                Console.WriteLine("CSharpEngine closed");
            }
        }
        /// <summary>
        /// 判断是否存在指定名称的脚本方法
        /// </summary>
        /// <param name="MethodName">方法名称</param>
        /// <returns>是否存在指定的方法</returns>
        public bool HasMethod(string MethodName)
        {
            if (myScriptMethods.Count > 0)
            {
                foreach (ScriptMethodInfo info in myScriptMethods)
                {
                    if (string.Compare(info.MethodName, MethodName, true) == 0)
                    {
                        return true;
                    }//if
                }//foreach
            }//if
            return false;
        }
        /// <summary>
        /// 执行脚本方法
        /// </summary>
        /// <param name="MethodName">方法名称</param>
        /// <param name="Parameters">参数</param>
        /// <param name="ThrowException">若发生错误是否触发异常</param>
        /// <returns>执行结果</returns>
        ///  //public object Execute( string MethodName , object[] Parameters , bool ThrowException )
        public bool Execute(string MethodName, bool ThrowException)
        {
            // 若发生错误则不抛出异常，安静的退出
            // 检查参数
            if (MethodName == null)
            {
                return false;
            }
            else if (MethodName.Trim().Length == 0)
            {
                return false;
            }
            if (myScriptMethods.Count > 0)
            {
                foreach (ScriptMethodInfo myScriptMethod in myScriptMethods)
                {
                    // 遍历所有的脚本方法信息，不区分大小写的找到指定名称的脚本方法
                    if (string.Compare(myScriptMethod.MethodName, MethodName, true) == 0)
                    {
                        try
                        {    // 执行脚本方法
                            object obj = myScriptMethod.MethodObject.Invoke(null, null);
                            // 返回脚本方法返回值
                            //return obj;
                        }
                        catch (Exception ex)
                        {
                            // 若发生错误则输出调试信息
                            Console.WriteLine(MethodName + ":" + ex.Message);
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// 销毁对象
        /// </summary>
        public void Dispose()
        {
            Close();
        }
    }
}
