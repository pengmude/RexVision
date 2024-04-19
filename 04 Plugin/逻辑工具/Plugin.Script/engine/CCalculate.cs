using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Script
{
	[Serializable]
	[StandardModule]
	public class CCalculate
	{
		[NonSerialized]
		public CSharpEngine m_CSharpEngine = null;
        public string m_Script { get; set; } = string.Empty;
		public CCalculate()
		{
			InitCSharpEngine();
		}
		private void InitCSharpEngine()
		{
			m_CSharpEngine = new CSharpEngine();
			m_CSharpEngine.P = this;
			m_CSharpEngine.AddReferenceAssemblyByType(GetType());
			m_CSharpEngine.VBCompilerImports.Add("RexScrip.Global");
		}
	}
}
