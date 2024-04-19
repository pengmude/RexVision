using HalconDotNet;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using VisionCore;


namespace Plugin.SendData
{
    [Category("通讯工具")]
    [DisplayName("发送数据")]
    [Serializable]
    public class SendDataObj : ObjBase
    {
        /// <summary>通信端口</summary>
        public string mPortSelect = "";
        /// <summary>发送模块</summary>
        public string mSendText = "";
        /// <summary>结束符号</summary>
        public string mEndChar = "";
        /// <summary>发送内容</summary>
        public string mSendStr = "";
        public override bool RunObj()
        {
          ECom IECom = mECom.FirstOrDefault(c => c.Key == mPortSelect);
            if (mECom != null& mSendText.Length>2)
            {
                if (!mSendText.Contains(":"))
                {
                    if (mSendText.Contains("光源"))
                    {
                        string[] sendStr = mSendText.Split(' ');
                        switch(sendStr[0])
                        {
                            case "光源开":
                                mSendStr = (DigtalChanlSwitch("1", sendStr[1], sendStr[2]));
                                break;
                            case "光源关":
                                mSendStr = (DigtalChanlSwitch("2", sendStr[1], sendStr[2]));
                                break;
                        }
                    }
                    else
                    {
                        mSendStr = mSendText;
                    }
                }
                else
                {
                    switch (mSendText.Split(':')[0])
                    {
                        case "全局变量":
                            mSendStr = Var.GetLinkData(mSysVar, mSendText).Split('|')[2];
                            break;
                        default:
                            mSendStr = Var.GetLinkData(mSloVar, mSendText).Split('|')[2];
                            break;
                    }
                }
                switch(mEndChar)
                {
                    case "\\r":
                        IECom.SendStr(mSendStr + "\r");
                        break;
                    case "\\n":
                        IECom.SendStr(mSendStr + "\n");
                        break;
                    case "\\r\\n":
                        IECom.SendStr(mSendStr + "\r\n");
                        break;
                    default:
                        IECom.SendStr(mSendStr+ mEndChar);
                        break;
                }
                ModInfo.State = ModState.OK;
                return true;
            }
            else
            {
                if (mECom == null)
                {
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "端口为空,请检查!");
                }
                else if (mSendText.Length == 0)
                {
                    Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ":    " + ModInfo.Name + ":" + "命令为空,请检查!");
                }
                ModInfo.State = ModState.NG;
                return false;
            }
        }
        public override void RunForm(ObjBase BaseMod)
        {
            new SendDataForm((SendDataObj)BaseMod).ShowDialog();
        }
        override public void SetInfo(){}

        private static string DigtalChanlSwitch(string CodeD, string channalD, string LightnessD)
        {

            string Str;

            int Lgt = Convert.ToInt32(LightnessD);
            var Lst = Convert.ToString(Lgt, 16);
            var Lstr1 = Lst.ToUpper();
            string b = string.Empty;
            if (Lgt < 16)
            {

                var Lstr2 = Lstr1.Substring(0, 1);
                // --------------------------校验和转换----------------------------
                Tempfunction(CodeD, channalD, "0", "0", Lstr2);
                //b = Conversion.Hex(b);
                var b1 = Convert.ToString(Ks, 16);
                var b2 = b1.ToUpper();
                Str = "$" + CodeD + channalD + "0" + "0" + Lstr1 + b2;
            }
            else
            {
                var Lstr2 = Lstr1.Substring(0, 1);
                var Lstr3 = Lstr1.Substring(1, 1);
                // --------------------------校验和转换----------------------------
                Tempfunction(CodeD, channalD, "0", Lstr2, Lstr3);
                var b1 = Convert.ToString(Ks, 16);
                var b2 = b1.ToUpper();
                Str = "$" + CodeD + channalD + "0" + Lstr1 + b2;
            }
            return Str;
        }

        static int Ks = 0;
        private static void Tempfunction(string Temp1, string Temp2, string Temp3, string Temp4, string Temp5)
        {

            switch (Temp1)
            {
                case "0":
                    {
                        Ks = +0x30;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46;
                        break;
                    }
            }
            switch (Temp2)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }

            switch (Temp3)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }
            switch (Temp4)
            {
                case "0":
                    {
                        Ks = +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = +0x46 ^ Ks;
                        break;
                    }
            }
            int fistword = +0x24;
            switch (Temp5)
            {

                case "0":
                    {
                        Ks = fistword ^ +0x30 ^ Ks;
                        break;
                    }

                case "1":
                    {
                        Ks = fistword ^ +0x31 ^ Ks;
                        break;
                    }

                case "2":
                    {
                        Ks = fistword ^ +0x32 ^ Ks;
                        break;
                    }

                case "3":
                    {
                        Ks = fistword ^ +0x33 ^ Ks;
                        break;
                    }

                case "4":
                    {
                        Ks = fistword ^ +0x34 ^ Ks;
                        break;
                    }

                case "5":
                    {
                        Ks = fistword ^ +0x35 ^ Ks;
                        break;
                    }

                case "6":
                    {
                        Ks = fistword ^ +0x36 ^ Ks;
                        break;
                    }

                case "7":
                    {
                        Ks = fistword ^ +0x37 ^ Ks;
                        break;
                    }

                case "8":
                    {
                        Ks = fistword ^ +0x38 ^ Ks;
                        break;
                    }

                case "9":
                    {
                        Ks = fistword ^ +0x39 ^ Ks;
                        break;
                    }

                case "A":
                    {
                        Ks = fistword ^ +0x41 ^ Ks;
                        break;
                    }

                case "B":
                    {
                        Ks = fistword ^ +0x42 ^ Ks;
                        break;
                    }

                case "C":
                    {
                        Ks = fistword ^ +0x43 ^ Ks;
                        break;
                    }

                case "D":
                    {
                        Ks = fistword ^ +0x44 ^ Ks;
                        break;
                    }

                case "E":
                    {
                        Ks = fistword ^ +0x45 ^ Ks;
                        break;
                    }

                case "F":
                    {
                        Ks = fistword ^ +0x46 ^ Ks;
                        break;
                    }
            }
        }
    }
}
