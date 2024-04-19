using System;
using System.ComponentModel;
using System.Linq;
using VisionCore;

namespace Plugin.SplitText
{
    [Category("变量工具")]
    [DisplayName("分割文本")]
    [Serializable]
    public class SplitTextObj : ObjBase
    {
        /// <summary>
        /// 通信类
        /// </summary>
        [NonSerialized]
        ECom IECom = null;
        /// <summary>
        /// 通信名称
        /// </summary>
        public string m_eKey = "";
        /// <summary>
        /// 指定字符
        /// </summary>
        public string m_eData { get; set; }
        private static readonly object obLock = new object();
        /// <summary>
        /// 停止当前等待
        /// </summary>
        public void Stop()
        {
            if (IECom != null) { IECom.StopRecStrSignal(); }
        }
        public override bool RunObj()
        {
            IECom = mECom.FirstOrDefault(c => (c.Key == m_eKey));
            if (IECom != null)
            {
                ModInfo.State = ModState.Start;
                string m_GetData = string.Empty;
                do
                {
                    IECom.GetStr(out m_GetData);

                }
                while (!(m_GetData == m_eData) && !Sol.IsStop);
                this.ModInfo.State = ModState.OK;
                return true;
            }
            else
            {
                this.ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
           new SplitTextForm((SplitTextObj)BaseMod).ShowDialog();
        }
        override public void SetInfo()
        {

        }
    }
}
