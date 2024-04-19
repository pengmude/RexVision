using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RexHelps
{
    public partial class frmRegistered : Form
    {
        public frmRegistered()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbRegisterCode.Text.Length>0)
            {
                try
                {
                    RegisterHelper.Instance.RegisterCode= tbRegisterCode.Text;
                    if (RegisterHelper.Instance.RegisteredDll() == true)
                    {
                        MessageBox.Show("注册成功");
                        this.Close();
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("注册失败,请检查"+ex.Message);
                }
                MessageBox.Show("注册失败,请检查");
            }
            else
            {
                MessageBox.Show("请输入注册码");

            }
        }

        private void btnGetMachineCode_Click(object sender, EventArgs e)
        {
            tbMachineCode.Text = RegisterHelper.Instance.MachineCode;
        }

        private void frmRegistered_Load(object sender, EventArgs e)
        {
            tbMachineCode.Text = RegisterHelper.Instance.MachineCode;
        }
    }
}
