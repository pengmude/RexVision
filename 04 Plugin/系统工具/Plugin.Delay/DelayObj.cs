using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.Delay
{
    [Category("系统工具")]
    [DisplayName("延时工具")]
    [Serializable]
    public class DelayObj : ObjBase
    {
        [NonSerialized]
        CancellationTokenSource mCts;
        [NonSerialized]
        public AutoResetEvent mEventWait = new AutoResetEvent(false);//采集信号
        /// <summary>默认延时</summary>
        public int mDelayTime = 500;
        /// <summary>停止延时</summary>
        public void Stop()
        {
            mEventWait.Set();
            if (mCts != null)
            {
                mCts.Cancel(); //取消任务
            }
        }
        private bool WaitTimeTask(int mDelayTime, CancellationToken token)
        {
            //延时使用循环延时  否则取消时候回出现滞后响应
            if (mDelayTime < 1)
            {
                mEventWait.Set();
                return true;
            }
            for (int i = 0; i < mDelayTime/2; i++)
            {
                Thread.Sleep(1);
                if (token.IsCancellationRequested)
                {
                    mEventWait.Set();
                    Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mDelayTime );
                    return false;
                }
            }
            if (token.IsCancellationRequested == false)
            {
                mEventWait.Set();
                Log.Info( Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + mDelayTime );
                return true;
            }
            return false;
        }



        public override bool RunObj()
        {
            try
            {
                mCts = new CancellationTokenSource();
                mEventWait.Reset();
                Task<bool> longTask = new Task<bool>(() => WaitTimeTask(mDelayTime, mCts.Token), mCts.Token);
                longTask.Start();
                mEventWait.WaitOne();
                mCts.Dispose();
                mCts = null;
                ModInfo.State = ModState.OK;
                return true;
            }
            catch
            {
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            new DelayForm((DelayObj)baseMod).ShowDialog();
        }
        public override void SetInfo()
        {
            mEventWait = new AutoResetEvent(false);//采集信号
        }
    }
}
