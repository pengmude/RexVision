using HalconDotNet;
using RexConst;
using RexHelps;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.DataShow
{
    [Category("系统工具")]
    [DisplayName("数据显示")]
    [Serializable]
    public class DataShowObj : ObjBase
    {
        /// <summary>索引</summary>
        public int index = 0;
        /// <summary>输入图像</summary>
        public string mImages = "数据链接";
        /// <summary>小数位数</summary>
        public int mMsgDic = 4;
        /// <summary>字体大小</summary>
        public int mMsgSize = 10;
        /// <summary>OK标记</summary>
        public string mMsgOK = "OK";
        /// <summary>NG标记</summary>
        public string mMsgNG = "NG";
        /// <summary>显示信息</summary>
        public List<Set_Info> mShow_Info = new List<Set_Info>();
        public override bool RunObj()
        {
            string color = "cyan", State = "True", MsgStr = string.Empty;
            try
            {
                if ((mRImage = (RImage)Var.GetImage(mSloVar, mImages)) == null)
                {
                    ModInfo.State = ModState.NoImage;
                    return false;
                }
                foreach (Set_Info info in mShow_Info)
                {
                    State = info.Status.Contains(":") ? Var.GetLinkData(mSloVar, info.Status).Split('|')[2] : "True";
                    MsgStr = info.Msg.Contains(":") ? Var.GetLinkData(mSloVar, info.Msg).Split('|')[2] : info.Msg;
                    MsgStr = IsNumber(MsgStr) == true ? double.Parse(MsgStr).ToString("F" + mMsgDic).ToString() : MsgStr;
                    color = bool.Parse(State) == true ? RColor.ToHexColor(info.OK) : RColor.ToHexColor(info.NG);
                    MsgStr = info.Prefix + MsgStr + info.Suffix + " " + (bool.Parse(State) == true ? mMsgOK : mMsgNG);
                    mRImage.ShowHText(new HText(ModInfo.Encode, ModInfo.Name, ModInfo.Remarks, HRoiType.文字显示, color, MsgStr, "mono", info.X, info.Y, mMsgSize, mRImage, true));
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + MsgStr);
                }
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":" + ModInfo.Name + ":" + MsgStr + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase baseMod)
        {
            try
            {
                new DataShowForm((DataShowObj)baseMod).ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ModInfo.Name + ":" + ":" + ex.Message);
            }
        }
        override public void SetInfo() { }
    }
}
