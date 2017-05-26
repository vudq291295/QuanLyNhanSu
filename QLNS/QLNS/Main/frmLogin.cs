using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }
        public void IsShowLogin()
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                btnLogin.Visible = true;
                lbError.Text = "";
            }
            else
            {
                btnLogin.Visible = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lbError.Text = "Không để trống tên đăng nhập";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lbError.Text = "Không để trống tên đăng nhập";
                lbError.ForeColor = Color.Red;
            } 
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lbError.Text = "Không để trống mật khẩu";
                lbError.ForeColor = Color.Red;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lbError.Text = "Không để trống mật khẩu";
                lbError.ForeColor = Color.Red;
            } 
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                lbError.Text = "Không để trống tên đăng nhập";
                lbError.ForeColor = Color.Red;
            } 
        }
    }
}
