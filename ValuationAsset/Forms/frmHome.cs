using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            init();
        }

        DataAccess da = new DataAccess();
        int PageSize = 5;

        //initButton để thiết lập hiển thị của những button nên hiện và nên ẩn khi vừa load form
        private void init()
        {
            //btnSave.Visible = false;
            //btnAddUser.Visible = true;
            //btnCancel.Visible = false;
            //btnEdit.Visible = true;
            //btnEdit.Enabled = false;
            //txtPassword.Enabled = false;
            //txtConfirm.Enabled = false;
            tabControl1.SelectedTab = tabPage1;
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //var test = AuthSession.Get(AuthSession.key_UserName);

            string strQuery = "select ID, Role from tbRole where isnull(Deactive, 0) != 1";
            GetDataCombobox(cbPermission, strQuery);

            BindDataUserList();

            BindDataAssetList(1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAssetInformation addAsset = new frmAssetInformation();
            addAsset.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //btnAddUser.Visible = false;
            //btnEdit.Visible = false;
            //btnSave.Visible = true;
            //btnCancel.Visible = true;
        }

        #region

        private void GetDataCombobox(ComboBox cmb, string strQuery)
        {
            
            var roles = da.execSqlQuery(strQuery);
            if (roles.Tables[0].Rows.Count > 0)
            {
                cmb.DataSource = roles.Tables[0];
                cmb.ValueMember = roles.Tables[0].Columns[0].ToString();
                cmb.DisplayMember = roles.Tables[0].Columns[1].ToString();
                cmb.SelectedItem = 0;
            }
        }

        private void BindDataUserList()
        {
            string strQuery = "sp_GetUser";
            var users = da.execSqlReturn(strQuery, null).Tables[0];
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = users;
        }

        private void BindDataAssetList(int pageIndex)
        {
            string constring = ConfigurationManager.ConnectionStrings["Entities"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetAsset", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                    cmd.Parameters.AddWithValue("@PageSize", PageSize);
                    cmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
                    cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvAssets.DataSource = dt;
                    con.Close();
                    int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
                    this.PopulatePager(recordCount, pageIndex);
                }
            }

            //string strQuery = "sp_GetAsset";
            //List<SqlParameter> para = new List<SqlParameter>()
            //{
            //    new SqlParameter() { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Value = pageIndex },
            //    new SqlParameter() { ParameterName = "@PageSize", SqlDbType = SqlDbType.Int, Value = PageSize }
            //};
            
            //var assets = da.execSqlReturn(strQuery, para).Tables[0];
            //dgvAssets.AutoGenerateColumns = true;
            //dgvAssets.DataSource = assets;

            //int recordCount = 10;
            //this.PopulatePager(recordCount, pageIndex);
        }

        private void PopulatePager(int recordCount, int currentPage)
        {
            List<Page> pages = new List<Page>();
            int startIndex, endIndex;
            int pagerSpan = 5;

            //Calculate the Start and End Index of pages to be displayed.
            double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
            endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add the First Page Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "First", Value = "1" });
            }

            //Add the Previous Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
            }

            //Add the Next Button.
            if (currentPage < pageCount)
            {
                pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
            }

            //Add the Last Button.
            if (currentPage != pageCount)
            {
                pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
            }

            //Clear existing Pager Buttons.
            pnlPager.Controls.Clear();

            //Loop and add Buttons for Pager.
            int count = 0;
            foreach (Page page in pages)
            {
                Button btnPage = new Button();
                btnPage.Location = new System.Drawing.Point(38 * count, 5);
                btnPage.Size = new System.Drawing.Size(45, 30);
                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.Enabled = !page.Selected;
                btnPage.Click += new System.EventHandler(this.Page_Click);
                pnlPager.Controls.Add(btnPage);
                count++;
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button btnPager = (sender as Button);
            this.BindDataAssetList(int.Parse(btnPager.Name));
        }

        #endregion

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirmPassword = txtConfirm.Text.Trim();
                if (password.Equals(""))
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "Password must not be empty!";
                    lbMessage.ForeColor = Color.Red;
                }
                else if (!password.Equals(confirmPassword))
                {
                    //Show error when input confirm password not similar with password
                    lbMessage.Visible = true;
                    lbMessage.Text = "Confirm password is incorrect.";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    var checkUser = AuthSuport.CheckUserExisted(userName);
                    if (checkUser.Equals("true"))
                    {
                        int roleId = int.Parse(cbPermission.SelectedValue.ToString());
                        int active = chkDeactive.Checked ? 1 : 0;
                        AuthSuport.Register(-1, userName, password, roleId, active, 1);
                        MessageBox.Show("Sign Up success", "Message");
                        BindDataUserList();
                    }
                    else
                    {
                        lbMessage.Visible = true;
                        lbMessage.Text = checkUser;
                        lbMessage.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                lbMessage.Visible = true;
                lbMessage.Text = ex.Message;
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
            cbPermission.SelectedValue = dgvUser.CurrentRow.Cells["RoleId"].Value.ToString();
            chkDeactive.Checked = dgvUser.CurrentRow.Cells["Status"].Value.ToString() == "Active" ? false : true;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string idStr = dgvUser.CurrentRow.Cells["ID"].Value.ToString();
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string confirmPassword = txtConfirm.Text.Trim();
                int roleId = int.Parse(cbPermission.SelectedValue.ToString());
                int active = chkDeactive.Checked ? 1 : 0;

                if (string.IsNullOrWhiteSpace(idStr) || string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    lbMessage.Visible = true;
                    lbMessage.Text = "User Name, Password is not empty.";
                    lbMessage.ForeColor = Color.Red;
                }
                else if (!password.Equals(confirmPassword))
                {
                    //Show error when input confirm password not similar with password
                    lbMessage.Visible = true;
                    lbMessage.Text = "Confirm password is incorrect.";
                    lbMessage.ForeColor = Color.Red;
                }
                else
                {
                    int id = !string.IsNullOrWhiteSpace(idStr) ? int.Parse(idStr) : 0;
                    AuthSuport.Register(id, userName, password, roleId, active, 0);
                    MessageBox.Show("Update success", "Message");
                    BindDataUserList();
                }
            }
            catch(Exception ex)
            {
                lbMessage.Visible = true;
                lbMessage.Text = ex.Message;
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check deleted rows
            if (dgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var idStr = dgvUser.CurrentRow.Cells["ID"].Value.ToString();
                    int id = !string.IsNullOrWhiteSpace(idStr) ? int.Parse(idStr) : 0;

                    string strQuery = string.Format("delete from tbUser where ID = {0}", id);
                    da.execSqlQuery(strQuery);

                    BindDataUserList();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }

    public class Page
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
