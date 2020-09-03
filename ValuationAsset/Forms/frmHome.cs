using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset.Forms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            initButton();
        }

        //initButton để thiết lập hiển thị của những button nên hiện và nên ẩn khi vừa load form
        private void initButton()
        {
            btnSave.Visible = false;
            btnAddUser.Visible = true;
            btnCancel.Visible = false;
            btnEdit.Visible = true;
            btnEdit.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirm.Enabled = false;
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            var test = AuthSession.Get(AuthSession.key_UserName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAssetInformation addAsset = new frmAssetInformation();
            addAsset.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            btnAddUser.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            txtPassword.Enabled = true;
            txtConfirm.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddUser.Visible = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            if(txtPassword.Enabled && txtConfirm.Enabled)
            {
                txtPassword.Enabled = false;
                txtConfirm.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //nếu password và nhập lại password mà enable thì nút save để lưu user mới tạo
            //nếu không thì nút save để chỉnh sửa thông tin user đã có
            if (txtPassword.Enabled && txtConfirm.Enabled)
            {
                //create user here

                txtPassword.Enabled = false;
                txtConfirm.Enabled = false;
            } else
            {
                //edit user here

            }

            btnAddUser.Visible = true;
            btnEdit.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAddUser.Visible = false;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
    }
}
