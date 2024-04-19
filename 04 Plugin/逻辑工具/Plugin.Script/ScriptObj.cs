
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.Script
{
    [Category("逻辑工具")]
    [DisplayName("脚本编辑")]
    [Serializable]
    public class ScriptObj : ObjBase
    {
        public string InCode = "";
        [NonSerialized]
        public CSharpEngine m_CSharpEngine = new CSharpEngine();     
        public string Compile()
        {
            return m_CSharpEngine.Compile(InCode);
        }
        protected override void AfterSetModParam()
        {
            //因为是先反射创建后,再赋值ModInfo,所以在这里才能拿到ProjID,Name
            Task.Run(
            () =>
            {//将耗时操作放到线程中执行 约200ms
                  //m_CSharpEngine.Compile();
                  //m_CSharpEngine.mSysVar = mSysVar;
                  //m_CSharpEngine.mSloVar = mSloVar;
            });
        }
        public override bool RunObj()
        {
            try
            {
                m_CSharpEngine.Execute("Main", ThrowException: true);
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error( ModInfo.Name + ex.Message);
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
           new ScriptForm((ScriptObj)baseMod).ShowDialog();
        }
        override public void SetInfo()
        {

            if (m_CSharpEngine == null)
            {
                m_CSharpEngine = new CSharpEngine();
            }
            AfterSetModParam();
        }

    }
}
