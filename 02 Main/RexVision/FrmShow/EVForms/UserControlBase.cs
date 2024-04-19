using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyVision.EVControl.Plugin
{
    [ToolboxItem(false)]
    public partial class UserControlBase : UserControl
    {
        /// <summary>
        /// 自定义控件的基础类
        /// </summary>
        protected bool m_StopChangeEvent = true;
        private string m_DataIdent;
        private DataType m_DataType = DataType.ModuleDataIn;

        private PluginBaseForm m_ParentForm;

        /// <summary>
        /// 数据类型
        /// </summary>
        public DataType DataType
        {
            get { return m_DataType; }
            set { m_DataType = value; }
        }
        /// <summary>
        /// 数据标识
        /// </summary>
        public string DataIdent
        {
            get { return m_DataIdent; }
            set { m_DataIdent = value; }
        }
        public UserControlBase()
        {
            InitializeComponent();
        }

        private void GetParentForm()
        {
            Control parent = base.Parent;
            if (this.m_ParentForm == null)
            {
                while (parent != null)
                {
                    this.m_ParentForm = parent as PluginBaseForm;
                    if (this.m_ParentForm != null)
                    {
                        this.m_ParentForm.Load += new EventHandler(this.ParentForm_Load);
                        break;
                    }
                    parent = parent.Parent;
                }
            }
            parent = base.Parent;
            if (this.m_ParentForm == null)
            {
                while (parent != null)
                {
                    parent.ParentChanged += new EventHandler(this.GetParentForm);
                    parent = parent.Parent;
                }
            }
        }

        private void GetParentForm(object sender, EventArgs e)
        {
            this.GetParentForm();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            this.GetParentForm();
        }

        protected virtual void ParentForm_Load(object sender, EventArgs e)
        {
        }
        protected string GetData()
        {
            string val = m_ParentForm.GetVarValueText(DataIdent, DataType);

            return val;
        }
        protected bool GetBoolData(string dataIdent, DataType dataType = DataType.ModuleDataIn)
        {
            string val = m_ParentForm.GetVarValueText(dataIdent, dataType);
            if (val==Common.GlobalDefine.ON_VAL)
            {
                return true;
            }
            return false;
        }
        protected double GetDoubleData(string dataIdent, DataType dataType= DataType.ModuleDataIn)
        {
            string val = m_ParentForm.GetVarValueText(dataIdent, dataType);

            return double.Parse(val);
        }
        protected void SetDoubleData(string dataIdent, double val,DataType dataType = DataType.ModuleDataIn)
        {
           m_ParentForm.SetVarValueText(dataIdent, dataType,val.ToString("f4"));
        }
        protected void SetBoolData(string dataIdent, bool val, DataType dataType = DataType.ModuleDataIn)
        {
            if (val)
            {
                m_ParentForm.SetVarValueText(dataIdent, dataType, Common.GlobalDefine.ON_VAL);
            }
            else
            {
                m_ParentForm.SetVarValueText(dataIdent, dataType, Common.GlobalDefine.OFF_VAL);
            }
           
        }
        protected void SetData(string data)
        {
            m_ParentForm.SetVarValueText(DataIdent, DataType, data);
        }

    }
}
