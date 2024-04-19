using DockContrl;
using System;
using System.Collections.Generic;

namespace VisionCore
{
    /// <summary>
    /// UI基类
    /// </summary>
    public partial class FormBase : DockForm
    {
        /// <summary>界面-对应模块 </summary>
        public ObjBase ObjBase { get; set; }
        /// <summary>备份-取消还原</summary>
        private ObjBase ObjBaseBack;
        public FormBase() : base()
        {
            InitializeComponent();
        }
        public FormBase(ObjBase mObj) 
        {
            ObjBase = mObj;
            InitializeComponent();
        }
        private void FormBase_Load(object sender, EventArgs e)
        {
            if (ObjBase == null) return;
            Tools.SetWindowRegion(this, 8 * 1);
            Tools.SetWindowRegion(pbox_Icon, 8 * 2);
            pbox_Icon.Image = ObjBase.Icon;
            this.Text = ObjBase.ModInfo.Name;
            this.Title = ObjBase.ModInfo.Name;
            cb_Enable.Checked = ObjBase.Enable;
            uitb_Remark.Text = ObjBase.ModInfo.Remarks;
            ObjBaseBack = CloneObject.DeepCopy(ObjBase);
            ObjToForm();
            FormToObj();
        }
        /// <summary>模块数据加载至界面-先模块后界面</summary>
        public virtual  void ObjToForm(){}
        /// <summary>界面数据加载至模块-先模块后界面</summary>
        public virtual void FormToObj(){}
        private void tb_Describle_TextChanged(object sender, EventArgs e)
        {
            ObjBase.ModInfo.Remarks = uitb_Remark.Text;
        }
        private void cb_Enable_CheckedChanged(object sender, EventArgs e)
        {
            ObjBase.Enable = cb_Enable.Checked;
        }
        private void btn_Run_Click(object sender, EventArgs e) { }
        private void btn_Save_Click(object sender, EventArgs e) { }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ObjBase = ObjBaseBack;
            this.Close();
        }
    }
}
