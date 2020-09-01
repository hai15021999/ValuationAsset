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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (!password.Equals(confirmPassword))
            {
                //Show error when input confirm password not similar with password
                lbMessage.Visible = true;
                lbMessage.Text = "Confirm password is incorrect!";
                lbMessage.ForeColor = Color.Red;
            } 
            else
            {
                var checkUser = AuthSuport.CheckUserExisted(userName);
                if (checkUser.Equals("true"))
                {
                    var registration = AuthSuport.Register(userName, password);
                    MessageBox.Show("Sign Up success");
                    this.Dispose();
                } else
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = checkUser;
                    lbMessage.ForeColor = Color.Red;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
