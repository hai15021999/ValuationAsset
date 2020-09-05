using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset
{
    public partial class frmPersonalty : Form
    {
        public int ContractId { get; set; }
        public int AssetId { get; set; }

        public frmPersonalty()
        {
            InitializeComponent();
            initCombobox();
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
                if (name.Equals("") || model.Equals("") || yearOfManufacture.Equals("") || yearOfUsing.Equals(""))
                {
                    MessageBox.Show("Vui lòng không để trống bất kì mục nào!");
                }
                else
                {
                    int quantity = int.Parse(txtQuantity.Text.Trim());
                    float unitPrice = float.Parse(txtUnitPrice.Text.Trim());
                    float value = float.Parse(txtPrice.Text.Trim());

                    string queryStr = string.Format("Insert into tbAsset(Type, Name, Model, YearOfManufacture, YearOfUse, Number, UnitPrice, Value) " +
                        "values(N'{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", "Động Sản", name, model, yearOfManufacture, yearOfUsing, quantity, unitPrice, value);

                    DataAccess da = new DataAccess();

                    da.execSqlQuery(queryStr);

                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    //MessageBox.Show("Lưu hoàn tất.");
                }
            } 
            catch (Exception ex)
            {
                if (ex.ToString().Contains(txtQuantity.Text.Trim())){
                    MessageBox.Show("Vui lòng không nhập ký tự khác ký tự số vào mục Số lượng!");
                } else if (ex.ToString().Contains(txtUnitPrice.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng không nhập ký tự khác ký tự số vào mục đơn giá!");
                }
                else if (ex.ToString().Contains(txtPrice.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng không nhập ký tự khác ký tự số vào mục giá trị!");
                }
                else if (ex.ToString().Contains(txtYearOfManufacture.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập năm sản xuất!");
                }
                else if (ex.ToString().Contains(txtYearOfUsing.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập năm đưa vào sử dụng!");
                }
                else
                {
                    MessageBox.Show("Gặp sự cố: " + ex.Message);
                }
            }
        }
    }
}
