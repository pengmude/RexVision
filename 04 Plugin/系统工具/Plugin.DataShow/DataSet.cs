using Rex.UI;
using RexHelps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.DataShow
{
    public partial class DataSet : FormBase
    {    
        /// <summary>索引</summary>
         int index = 0;
        DataShowObj mObj;
        public DataSet()
        {
            InitializeComponent();
        }
        public DataSet(DataShowObj _Obj, int _index, string str)
        {
            mObj = _Obj;
            index = _index;
            InitializeComponent();
            if(str.Length>1)
            {
                ObjToForm();
                FormToObj();
            }
        }
        public override void  FormToObj()
        {
            try
            {
                mObj.mShow_Info[index].Status = uiLink_Status.Values.Text;
                mObj.mShow_Info[index].Align = (AlignMode)Enum.Parse(typeof(AlignMode), uicb_Align.Text);
                mObj.mShow_Info[index].X = RString.IsNumber(uiLink_X.Values.Text) == true ? int.Parse(uiLink_X.Values.Text) : int.Parse(Var.GetLinkData(mObj.mSloVar, uiLink_X.Values.Text).Split('|')[2]);
                mObj.mShow_Info[index].Y = RString.IsNumber(uiLink_Y.Values.Text) == true ? int.Parse(uiLink_Y.Values.Text) : int.Parse(Var.GetLinkData(mObj.mSloVar, uiLink_Y.Values.Text).Split('|')[2]);
                mObj.mShow_Info[index].Msg = uiLink_Msg.Values.Text;
                mObj.mShow_Info[index].Prefix = uitb_Prefix.Text;
                mObj.mShow_Info[index].Suffix = uitb_Suffix.Text;
                mObj.mShow_Info[index].OK = uicp_OK.Value;
                mObj.mShow_Info[index].NG = uicp_NG.Value;
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        public override void ObjToForm()
        {
            try
            { 
            string posx = mObj.mShow_Info[index].X.ToString();
            string posy = mObj.mShow_Info[index].Y.ToString();
            uiLink_Status.Values.Text = mObj.mShow_Info[index].Status;
            uicb_Align.Text=mObj.mShow_Info[index].Align.ToString();
            uiLink_X.Values.Text = (posx.Length<1)? "0":posx;
            uiLink_Y.Values.Text = (posy.Length < 1) ? "0" : posy;
            uiLink_Msg.Values.Text=mObj.mShow_Info[index].Msg;
            uitb_Prefix.Text=mObj.mShow_Info[index].Prefix;
            uitb_Suffix.Text=mObj.mShow_Info[index].Suffix;
            uicp_OK.Value=mObj.mShow_Info[index].OK;
            uicp_NG.Value=mObj.mShow_Info[index].NG;
            }
            catch (Exception ex)
            {
                Log.Error(mObj.ModInfo.Name + ":" + ex.Message);
            }
        }
        private void uilk_BtnAdd(object sender, EventArgs e)
        {
            PluginDataLinkForm LikeDataForm = new PluginDataLinkForm(mObj.Name, mObj.ModInfo.Name, VarType.IntVar, LinkDataForm.Script);
            LikeDataForm.ShowDialog();
            if (LikeDataForm.m_OutLinkData.Length > 3)
            {
                string[] m_IntStr = LikeDataForm.m_OutLinkData.Split('|');
                UISymbolButton UIBtn = (UISymbolButton)sender;
                if (UIBtn != null)
                {
                    switch (UIBtn.Parent.GetType().Name)
                    {
                        case "UILinkText":
                            UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                            mUILinkText.Values.Text = m_IntStr[0] + ":" + m_IntStr[1];
                            break;
                    }
                    FormToObj();
                    return;
                }
            }
        }
        private void uilk_BtnDec(object sender, EventArgs e)
        {
            UISymbolButton UIBtn = (UISymbolButton)sender;
            if (UIBtn != null)
            {
                switch (UIBtn.Parent.GetType().Name)
                {
                    case "UILinkData":
                        UILinkData mUILinkData = (UILinkData)UIBtn.Parent;
                        mUILinkData.Values.Text = "数据链接";
                        break;
                    case "UILinkText":
                        UILinkText mUILinkText = (UILinkText)UIBtn.Parent;
                        mUILinkText.Values.Text = "数据链接";
                        break;
                }
                return;
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FormToObj();
            ObjToForm();
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
