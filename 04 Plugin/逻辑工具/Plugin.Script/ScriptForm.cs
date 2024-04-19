using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using VisionCore;
using ScintillaNET;
using NPOI.SS.Formula.Functions;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using RexFind;

namespace Plugin.Script
{
    /// <summary>
    /// 脚本工具
    /// </summary>
    public partial class ScriptForm : FormBase
    {
        /// <summary>
        /// 自动提示的关键字
        /// </summary>
        public string m_AutoStr;
        /// <summary>
        /// 脚本方法字典
        /// </summary>
        private Dictionary<string, ScriptMethodInfo> methodDic = new Dictionary<string, ScriptMethodInfo>();
        private ScriptObj mObj;
        private FindReplace MyFindReplace;
        public ScriptForm(ScriptObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
            InitScintilla();
            MethodTreeView_Load();

        }
        private void ModForm_Load(object sender, EventArgs e)
        {
            if (mObj.InCode.Length > 0)
            {
                scintilla.Text = mObj.InCode;
            }
            else
            {
                scintilla.Text = "//声明" + "\r\n" + "public static  void Main()" + "\r\n" + "{\r\n//执行" + "\r\n\r\n\r\n\r\n\r\n" + "}";
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            mObj.InCode = scintilla.Text;
            this.Close();
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        private void btn_Compile_Click(object sender, EventArgs e)
        {
            mObj.InCode = scintilla.Text;
            string str = mObj.Compile();
            string[] msg = str.Split('\r');
            tb_Compile.Items.Clear();
            for (int i = 0; i < msg.Length; ++i)
            {
                tb_Compile.Items.Add(msg[i]);
            }
        }
        /// <summary>
        /// 初始化染色控件
        /// </summary>
        private void InitScintilla()
        {
            // 字体包裹模式
            scintilla.WrapMode = WrapMode.None;
            //高亮显示
            InitSyntaxColoring();
            //自定义关键字代码提示功能
            scintilla.AutoCIgnoreCase = true;//代码提示的时候,不区分大小写
            AutoComplete();
            // 这两种操作会导致乱码
            scintilla.ClearCmdKey(Keys.Control | Keys.S);
            scintilla.ClearCmdKey(Keys.Control | Keys.F);

            MyFindReplace = new FindReplace();
            MyFindReplace.Scintilla = scintilla1;
            MyFindReplace.FindAllResults += MyFindReplace_FindAllResults;
            MyFindReplace.KeyPressed += MyFindReplace_KeyPressed;

            //incrementalSearcher1.FindReplace = MyFindReplace;

            //findAllResultsPanel1.Scintilla = scintilla1;
            scintilla.AutoCCompleted += m_MyEditer_AutoCCompleted;
        }
        /// <summary>
        /// 自动补全时出现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_MyEditer_AutoCCompleted(object sender, AutoCSelectionEventArgs e)
        {
            string tip = ShowTipByWord();
            //tip提示
            if (!string.IsNullOrWhiteSpace(tip))
            {
                scintilla.CallTipShow(scintilla.CurrentPosition, tip);
            }
        }
        /// <summary>
        /// 设置语法高亮规则
        /// </summary>
        private void InitSyntaxColoring()
        {
            // 设置默认格式
            // Configure the default style
            scintilla.StyleResetDefault();
            scintilla.CaretForeColor = Color.Black;
            scintilla.Styles[Style.Default].Font = "Consolas";//字体Consolas
            scintilla.Styles[Style.Default].Size = 12;
            scintilla.Styles[Style.Default].BackColor = Color.White;//文本颜色
            scintilla.Styles[Style.Default].ForeColor = Color.Black;//字体颜色
            scintilla.SetSelectionBackColor(true, Color.LightBlue);
            scintilla.StyleClearAll();
            // Configure the CPP (C#) lexer styles
            scintilla.Styles[Style.Cpp.Identifier].ForeColor = Color.Black;
            scintilla.Styles[Style.Cpp.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Cpp.CommentLine].ForeColor = Color.LimeGreen;
            scintilla.Styles[Style.Cpp.CommentDoc].ForeColor = Color.ForestGreen;//.FromArgb(47, 174, 53);
            scintilla.Styles[Style.Cpp.Number].ForeColor = Color.DarkViolet;//数字颜色
            scintilla.Styles[Style.Cpp.String].ForeColor = Color.RoyalBlue;//字符串颜色
            scintilla.Styles[Style.Cpp.Operator].ForeColor = Color.DarkRed;///运算符
            scintilla.Styles[Style.Cpp.Character].ForeColor = Color.Tomato;
            scintilla.Styles[Style.Cpp.Preprocessor].ForeColor = Color.DodgerBlue;
            scintilla.Styles[Style.Cpp.Regex].ForeColor = Color.Fuchsia;
            scintilla.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.Lavender;// Color.FromArgb(119, 167, 219);
            scintilla.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            scintilla.Styles[Style.Cpp.Word2].ForeColor = Color.SteelBlue;
            scintilla.Styles[Style.Cpp.CommentDocKeyword].ForeColor = Color.LightGreen;
            scintilla.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = Color.Red;
            scintilla.Styles[Style.Cpp.GlobalClass].ForeColor = Color.DodgerBlue;
            scintilla.Lexer = Lexer.Cpp;
            // 可以设置两种颜色的关键字 输入只支持小写
            string s1 = ScriptTemplate.VBStringA();
            string s2 = GetMethodsString() + " " + ScriptTemplate.VBStringB();
            scintilla.SetKeywords(0, s1);
            scintilla.SetKeywords(1, s2);
            //行号字体颜色
            scintilla.Styles[Style.LineNumber].ForeColor = Color.CadetBlue;// ColorTranslator.FromHtml("#8DA3C1");
            //行号相关设置
            var nums = scintilla.Margins[1];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;
            scintilla.SetFoldMarginColor(true, Color.White);
            scintilla.SetFoldMarginHighlightColor(true, Color.LightBlue);
            // Enable code folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            // Configure a margin to display folding symbols
            scintilla.Margins[0].Type = MarginType.Symbol;
            scintilla.Margins[0].Mask = 0;
            scintilla.Margins[0].Sensitive = true;
            scintilla.Margins[0].Width = 1;
            scintilla.Margins[0].Cursor = MarginCursor.Arrow;
            scintilla.Markers[0].Symbol = MarkerSymbol.Circle;//0
            scintilla.Markers[0].SetForeColor(Color.LightBlue);
            scintilla.Markers[0].SetBackColor(Color.Red);

            scintilla.Margins[1].Type = MarginType.Number;
            scintilla.Margins[1].Mask = 2;
            scintilla.Margins[1].Sensitive = true;
            scintilla.Margins[1].Width = 25;
            scintilla.Margins[1].Cursor = MarginCursor.Arrow;
            scintilla.Markers[1].Symbol = MarkerSymbol.ShortArrow;//1
            scintilla.Markers[1].SetForeColor(Color.Red);
            scintilla.Markers[1].SetBackColor(Color.Red);

            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = 1;//TODO 1213
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 15;
            scintilla.Margins[2].Cursor = MarginCursor.Arrow;

            //Configure a margin to display folding symbols
            scintilla.Margins[4].Type = MarginType.ForeColor;
            scintilla.Margins[4].Mask = Marker.MaskFolders;
            scintilla.Margins[4].Sensitive = true;
            scintilla.Margins[4].Width = 15;
            scintilla.Margins[4].Cursor = MarginCursor.Arrow;
            // Set colors for all folding markers
            for (int i = 25; i <= 31; ++i)
            {
                scintilla.Markers[i].SetForeColor(Color.Lavender); // styles for [+] and [-]
                scintilla.Markers[i].SetBackColor(Color.Black); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.CirclePlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.CircleMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.CirclePlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.CircleMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;
            InitBookmarkMargin(scintilla);
            InitNumberMargin(scintilla);
        }
        private void InitNumberMargin(Scintilla scintilla)
        {
            scintilla.Styles[Style.LineNumber].BackColor = Color.LightBlue;////IntToColor(BACK_COLOR);
            scintilla.Styles[Style.LineNumber].ForeColor = Color.Black;//
            scintilla.Styles[Style.IndentGuide].BackColor = Color.LightBlue;//
            scintilla.Styles[Style.IndentGuide].ForeColor = Color.Green;//
            var nums = scintilla.Margins[0];
            nums.Width = 15;
            nums.Type = MarginType.Symbol;
            nums.Sensitive = true;
            nums.Mask = 0;
            scintilla.MarginClick += TextArea_MarginClick;
        }
        private void InitBookmarkMargin(Scintilla scintilla)
        {
            var margin = scintilla.Margins[0];
            margin.Width = 15;
            margin.Sensitive = true;
            margin.Type = MarginType.Number;
            margin.Mask = (1 << 3);
            margin.Cursor = MarginCursor.Arrow;

            var marker = scintilla.Markers[2];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(Color.Lime);
            marker.SetForeColor(Color.Green);
            marker.SetAlpha(100);
        }
        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            try
            {
                if (e.Margin == 11)
                {
                    // Do we have a marker for this line?
                    var line = scintilla.Lines[scintilla.LineFromPosition(e.Position)];
                    var lines = scintilla.Lines[scintilla.LineFromPosition(e.Position - 1)];
                    var s = line.MarkerGet();
                    var a = line.MarkerGet();
                    for (int i = 0; i < line.Index + 100; ++i)
                    {
                        var liness = scintilla.Lines[i];
                        liness.MarkerDelete(1);
                    }
                    lines.MarkerDelete(1);
                    line.MarkerDelete(1);
                    line.MarkerAdd(1);
                }
                if (e.Margin == 1)
                {
                    var line = scintilla.Lines[scintilla.LineFromPosition(e.Position)];
                    var lines = scintilla.Lines[scintilla.LineFromPosition(e.Position) - 1];
                    var s = line.MarkerGet();
                    if (line.MarkerGet() == 0 || line.MarkerGet() > 4)
                    {
                        line.MarkerAdd(0);
                    }
                    else
                    {
                        line.MarkerDelete(0);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        /// <summary>
        /// 代码提示功能
        /// </summary>
        public void AutoComplete()
        {
            //绑定输入事件
            scintilla.CharAdded += Scintilla_CharAdded;
            string s = GetMethodsString();
            string str = ScriptTemplate.VBStringA() + " " + ScriptTemplate.VBStringB() + " " + s;
            //获取分割字符串成list
            List<string> autoStrList = str.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //对list排序重新转换为string
            m_AutoStr = string.Join(" ", autoStrList.OrderBy(x => x.ToUpper()));
        }
        /// <summary>
        /// 输入结束事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = scintilla.CurrentPosition;
            var wordStartPos = scintilla.WordStartPosition(currentPos, true);
            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                if (!scintilla.AutoCActive)
                {
                    //此处必须是按照字母排序才能显示出来
                    scintilla.AutoCShow(lenEntered, m_AutoStr);
                }
            }
            //  ShowTipByWord();
        }
        /// <summary>
        /// 根据word 在tip窗口显示提示
        /// </summary>
        private string ShowTipByWord()
        {
            // Find the word start
            var currentPos = scintilla.CurrentPosition;
            var wordStartPos = scintilla.WordStartPosition(currentPos, true);
            var wordEndPos = scintilla.WordEndPosition(currentPos, true);
            string word = scintilla.GetTextRange(wordStartPos, wordEndPos - wordStartPos);
            string tip = "";
            if (!string.IsNullOrWhiteSpace(word))
            {
                if (methodDic.ContainsKey(word))
                {
                    tip = methodDic[word].Description;
                    string[] msg = tip.Split('\r');
                    tb_Compile.Items.Clear();
                    for (int i = 0; i < msg.Length; ++i)
                    {
                        tb_Compile.Items.Add(msg[i]);
                    }
                }
            }
            return tip;//返回提示信息
        }
        /// <summary>
        /// 获取当前程序集指定方法
        /// </summary>
        /// <returns></returns>
        public string GetMethodsString()
        {
            List<string> strList = new List<string>();
            List<Type> typeList = new List<Type>();
            typeList.Add(typeof(object));
            typeList.Add(typeof(Math));
            typeList.Add(typeof(string));
            typeList.Add(typeof(List<double>));
            typeList.Add(typeof(Enumerable));
            typeList.Add(typeof(MessageBox));
            typeList.Add(typeof(ECom));
            typeList.Add(typeof(Msg));
            typeList.Add(typeof(Tcp));
            typeList.Add(typeof(Plc));
            typeList.Add(typeof(Var)); ;
            typeList.Add(typeof(Csv));
            foreach (Type item in typeList)
            {
                if (item.IsEnum == true)
                {
                    string[] rolearry = Enum.GetNames(item);
                    strList.AddRange(rolearry);
                    strList.Add(item.Name);
                }
                else
                {
                    //添加type的方法
                    MethodInfo[] methods = item.GetMethods();
                    foreach (MethodInfo m in methods)
                    {
                        strList.Add(m.ToString().Split(' ')[1].Split('(')[0].Replace("set_", "").Replace("get_", "").Split('[')[0]);
                    }
                    strList.Add(item.Name);
                }
            }
            //自定义提示
            strList.Add("List(OfInteger)");
            strList.Add("List(OfDouble)");
            strList.Add("List(OfBoolean)");
            strList.Add("List(OfString)");
            return string.Join(" ", strList.Distinct().ToList().OrderBy(x => x.ToUpper())); ;
        }







        private void MethodTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                switch (MethodTreeView.SelectedNode.FirstNode.Text)
                {
                    case "Show(String s);":
                        scintilla1.Text = "123";
                        break;
                }
            }
            catch { }

        }
        private void MethodTreeView_Click(object sender, EventArgs e)
        {

        }
        private void MethodTreeView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                scintilla.InsertText(scintilla.CurrentPosition, MethodTreeView.SelectedNode.Parent.Text.Split(' ')[1] + "." + MethodTreeView.SelectedNode.Text );
            }
            catch (Exception ex)
            {
                scintilla1.Text = ex.Message;
            }
        }

        public void MethodTreeView_Load()
        {
            //VisionCore.Find.Find m_HMens = new VisionCore.Find.Find();
            //Type ty = m_HMens.GetType();
            //MethodInfo[] methods1 = ty.GetMethods();

            MethodTreeView.Nodes.Clear();
            List<Type> m_TypeList = GetTypes();
            int m_Nodes = 0;
            foreach (Type type in m_TypeList)
            {
                switch (type.Name)
                {
                    case "Msg":
                        MethodTreeView.Nodes.Add("提示信息 " + type.Name);
                        break;
                    case "Tcp":
                        MethodTreeView.Nodes.Add("网口通讯 " + type.Name);
                        break;
                    case "Plc":
                        MethodTreeView.Nodes.Add("PLC操作 " + type.Name);
                        break;
                    case "Var":
                        MethodTreeView.Nodes.Add("变量操作 " + type.Name);
                        break;
                    case "Csv":
                        MethodTreeView.Nodes.Add("数据保存 " + type.Name);
                        break;
                }
                MethodInfo[] m_Methods = type.GetMethods();
                foreach (MethodInfo method in m_Methods)
                {
                    ParameterInfo[] parameterInfos = method.GetParameters();
                    string methodname = method.ToString().Split(' ')[1].Split('(')[0] + "(";
                    for (int i = 0; i < parameterInfos.Length; i++)
                    {
                        ParameterInfo parameterInfo = parameterInfos[i];
                        string parametertype = parameterInfo.ParameterType.ToString();
                        if (parametertype.Contains("Collections.Generic.List`1"))
                        {
                            parametertype = parametertype.Replace("Collections.Generic.List`1", "List");
                        }
                        for (int j = 0; j < mObj.m_CSharpEngine.SourceImports.Count; ++j)
                        {

                            string Str = mObj.m_CSharpEngine.SourceImports[j];
                            if (parametertype.Contains(Str))
                            {
                                parametertype = parametertype.Replace(Str + ".", "").Replace("String", "string").Replace("Double", "double");
                            }
                        }

                        if (i == 0)
                        {
                            methodname += parametertype.Replace("System.", "") + " "; ;
                        }
                        else
                        {
                            methodname += " " + parametertype.Replace("System.", "") + " "; ;
                        }
                        if (i == parameterInfos.Length - 1)
                        {
                            methodname += parameterInfo.Name;
                        }
                        else
                        {
                            methodname += parameterInfo.Name + ",";
                        }

                    }
                    methodname += ");";

                    if (!methodname.Contains("Equals") & !methodname.Contains("GetHashCode") & !methodname.Contains("GetType") & !methodname.Contains("ToString"))//ToString
                    {
                        MethodTreeView.Nodes[m_Nodes].Nodes.Add(methodname);
                    }
                }
                ++m_Nodes;
            }
            MethodTreeView.ExpandAll();
        }

        private void MyFindReplace_KeyPressed(object sender, KeyEventArgs e)
        {
            genericScintilla_KeyDown(sender, e);
        }
        private void MyFindReplace_FindAllResults(object sender, FindResultsEventArgs FindAllResults)
        {
            // Pass on find results
            //findAllResultsPanel1.UpdateFindAllResults(FindAllResults.FindReplace, FindAllResults.FindAllResults);
        }
        /// <summary>
        /// Key down event for each Scintilla. Tie each Scintilla to this event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genericScintilla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                MyFindReplace.ShowFind();
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindPrevious();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                MyFindReplace.Window.FindNext();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                MyFindReplace.ShowReplace();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                MyFindReplace.ShowIncrementalSearch();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                GoTo MyGoTo = new GoTo((Scintilla)sender);
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// Enter event tied to each Scintilla that will share a FindReplace dialog.
        /// Tie each Scintilla to this event.
        /// </summary>
        /// <param name="sender">The Scintilla receiving focus</param>
        /// <param name="e"></param>
        private void genericScintilla1_Enter(object sender, EventArgs e)
        {
            MyFindReplace.Scintilla = (Scintilla)sender;
        }



        /// <summary>  
        /// 获取一个命名空间下的所有类  
        /// </summary>  
        /// <param name="name"></param>  
        /// <returns></returns>  
        public static List<Type> GetTypes()
        {
            //如果是当前下的。用Assembly.GetExecutingAssembly().GetTypes();
            //如果是外部DLL，用Assembly.Load("namespace").GetTypes();
            //原理是反射，所以上面一定要加上using System.Reflection;
            //示例代码：
            List<Type> lt = new List<Type>();
            try
            {
                var TypeList = Assembly.Load("VisionCore").GetTypes();
                foreach (var type in TypeList)
                {
                    switch (type.Name)
                    {
                        case "Msg":
                        case "Tcp":
                        case "Plc":
                        case "Var":
                        case "Csv":
                            lt.Add(type);
                            break;


                    }
                }
            }
            catch { }
            return lt;
        }
    }
}
