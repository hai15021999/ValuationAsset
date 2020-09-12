using AMS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            var isLogin = AuthSuport.Login(userName, password);
            if (isLogin == "true")
            {
                //Login successfull
                this.Hide();
                frmHome home = new frmHome();
                home.Show();
            }
            else
            {
                labError.Text = isLogin;
                labError.ForeColor = Color.Red;
                labError.Visible = true;
            }
        }
    }
}
