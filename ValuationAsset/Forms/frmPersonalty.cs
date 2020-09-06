using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset
{
    public partial class frmPersonalty : Form
    {
        public int? ContractId { get; set; }
        public int? AssetId { get; set; }

        DataAccess da = new DataAccess();
        public frmPersonalty()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void initCombobox()
        {
            txtYearOfManufacture.Items.Clear();
            txtYearOfUsing.Items.Clear();

            DateTime now = DateTime.Now;

            for(int i = now.Year; i >= 1900; i--)
            {
                txtYearOfUsing.Items.Add(i);
                txtYearOfManufacture.Items.Add(i);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //to do
            try
            {
                string name = txtNameOfAsset.Text.Trim();
                string model = txtAssetModel.Text.Trim();
                string yearOfManufacture = txtYearOfManufacture.SelectedItem.ToString();
                string yearOfUsing = txtYearOfUsing.SelectedItem.ToString();
                string quant = txtQuantity.Text.Trim();
                string uniPrice = txtUnitPrice.Text.Trim();
                string val = txtPrice.Text.Trim();
                if (name.Equals("") || model.Equals("") || yearOfManufacture.Equals("") || yearOfUsing.Equals("") || quant.Equals("") ||
                    uniPrice.Equals("") || val.Equals(""))
                {
                    MessageBox.Show("Vui lòng không để trống bất kì mục nào!");
                }
                else
                {
                    int quantity = int.Parse(quant);
                    float unitPrice = float.Parse(uniPrice);
                    float value = float.Parse(val);

                    List<SqlParameter> para = new List<SqlParameter>()
                    {
                        new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = ContractId },
                        new SqlParameter() { ParameterName = "@type", SqlDbType = SqlDbType.NVarChar, Value = "Động Sản" },
                        new SqlParameter() { ParameterName = "@name", SqlDbType = SqlDbType.NVarChar, Value = name },
                        new SqlParameter() { ParameterName = "@model", SqlDbType = SqlDbType.VarChar, Value = model },
                        new SqlParameter() { ParameterName = "@yearOfManufacture", SqlDbType = SqlDbType.VarChar, Value = yearOfManufacture },
                        new SqlParameter() { ParameterName = "@yearOfUse", SqlDbType = SqlDbType.VarChar, Value = yearOfUsing },
                        new SqlParameter() { ParameterName = "@number", SqlDbType = SqlDbType.Int, Value = quantity },
                        new SqlParameter() { ParameterName = "@unitPrice", SqlDbType = SqlDbType.Float, Value = unitPrice },
                        new SqlParameter() { ParameterName = "@value", SqlDbType = SqlDbType.Float, Value = value }
                    };

                    //string queryStr = string.Format("Insert into tbAsset(Type, Name, Model, YearOfManufacture, YearOfUse, Number, UnitPrice, Value) " +
                    //    "values(N'{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", "Động Sản", name, model, yearOfManufacture, yearOfUsing, quantity, unitPrice, value);

                    da.execSqlReturn("sp_CreateAsset", para);

                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    //MessageBox.Show("Lưu hoàn tất.");
                }
            } 
            catch (Exception ex)
            {
                if (ex.ToString().Contains(txtUnitPrice.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập đúng đơn giá!");
                }
                else if (ex.ToString().Contains(txtPrice.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập đúng giá trị!");
                }
                else
                {
                    MessageBox.Show("Gặp sự cố: " + ex.Message);
                }
            }
        }

        private void frmPersonalty_Load(object sender, EventArgs e)
        {
            initCombobox();
            if (AssetId.HasValue)
            {
                string queryStr = string.Format(@"SELECT Name, Model, YearOfManufacture, YearOfUse, Number, UnitPrice, Value FROM tbAsset WHERE Type = N'Động Sản' and Id = '{0}'", AssetId);
                var personalty = da.execSqlQuery(queryStr).Tables[0];
                if (personalty.Rows.Count > 0)
                {
                    txtNameOfAsset.Text = personalty.Rows[0]["Name"].ToString();
                    txtAssetModel.Text = personalty.Rows[0]["Model"].ToString();
                    txtYearOfManufacture.Text = personalty.Rows[0]["YearOfManufacture"].ToString();
                    txtYearOfUsing.Text = personalty.Rows[0]["YearOfUse"].ToString();
                    txtQuantity.Text = personalty.Rows[0]["Number"].ToString();
                    txtUnitPrice.Text = personalty.Rows[0]["UnitPrice"].ToString();
                    txtPrice.Text = personalty.Rows[0]["Value"].ToString();
                }
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }
    }
}
