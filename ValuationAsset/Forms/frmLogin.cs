using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text.Trim();
            string Password = txtPassword.Text.Trim();

            //Call function Login(UserName, Password) return ObjUser
            //

            //AuthSession.Set(AuthSession.key_UserId, user.ID.ToString());
            AuthSession.Set(AuthSession.key_UserName, UserName);

            //Login successfull
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }
    }
}
