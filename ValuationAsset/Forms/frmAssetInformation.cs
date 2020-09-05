using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset.Forms
{
    public partial class frmAssetInformation : Form
    {
        DataAccess da = new DataAccess();
        public static int ContractId = 0;
        public string contractNumberFull { get; set; }

        public frmAssetInformation()
        {
            InitializeComponent();
        }

        private void frmAssetInformation_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(contractNumberFull))
            {
                var numberSetting = GetNumberSetting();
                labTemplateNumber.Text = numberSetting.Replace("[Number]/[Year]", ".../" + DateTime.Now.Year + "/");
            }
            else
            {

            }
        }

        private string GetNumberSetting()
        {
            string strQuery = "select value from tbSetting where Key = 'TemplateContractNumber'";
            var numberSetting = da.execSqlQuery(strQuery).Tables[0].Rows[0][0].ToString();

            return numberSetting;
        }

        private void btnThemDongSan_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCreate = false;

                if (ContractId > 0)
                {
                    isCreate = true;
                }
                else
                {
                    if (MessageBox.Show("Thông tin sẽ được lưu lại. Bạn có tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<SqlParameter> paraGetNumber = new List<SqlParameter>()
                    {
                        new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year },
                        new SqlParameter() { ParameterName = "@type", SqlDbType = SqlDbType.VarChar, Value = "Contract" }
                    };
                        var number = da.execSqlReturn("sp_GetNumber", paraGetNumber).Tables[0].Rows[0][0].ToString();

                        var numberSetting = GetNumberSetting();
                        labTemplateNumber.Text = numberSetting.Replace("[Number]/[Year]", number + "/" + DateTime.Now.Year + "/");

                        List<SqlParameter> paraCreateCustomerAndContract = new List<SqlParameter>()
                    {
                        new SqlParameter() { ParameterName = "@requestDate", SqlDbType = SqlDbType.DateTime, Value = dtpDate.Value },
                        new SqlParameter() { ParameterName = "@contractValue", SqlDbType = SqlDbType.Float, Value = double.Parse(txtGiaTri_CCTT_HD.Text) },
                        new SqlParameter() { ParameterName = "@customerName", SqlDbType = SqlDbType.VarChar, Value = txtCustomerName.Text.Trim() },
                        new SqlParameter() { ParameterName = "@address", SqlDbType = SqlDbType.VarChar, Value = txtCustomerAddress.Text.Trim() },
                        new SqlParameter() { ParameterName = "@mst", SqlDbType = SqlDbType.VarChar, Value = txtMST_CCCD.Text.Trim() },
                        new SqlParameter() { ParameterName = "@phone", SqlDbType = SqlDbType.VarChar, Value = txtCustomerPhoneNo.Text.Trim() },
                        new SqlParameter() { ParameterName = "@number", SqlDbType = SqlDbType.Int, Value = int.Parse(number) },
                        new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year }
                    };
                        var contractIdStr = da.execSqlReturn("sp_CreateCustomerAndContract", paraCreateCustomerAndContract).Tables[0].Rows[0][0].ToString();
                        ContractId = int.Parse(contractIdStr);

                        if (ContractId > 0) isCreate = true;
                    }
                }

                if (isCreate)
                {
                    frmPersonalty personalty = new frmPersonalty();
                    personalty.ContractId = ContractId;
                    DialogResult dr = personalty.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        //bind data to dgvAssets
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnThemBatDongSan_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCreate = false;

                if (ContractId > 0)
                {
                    isCreate = true;
                }
                else
                {
                    if (MessageBox.Show("Thông tin sẽ được lưu lại. Bạn có tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        List<SqlParameter> paraGetNumber = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year },
                            new SqlParameter() { ParameterName = "@type", SqlDbType = SqlDbType.VarChar, Value = "Contract" }
                        };
                        var number = da.execSqlReturn("sp_GetNumber", paraGetNumber).Tables[0].Rows[0][0].ToString();

                        var numberSetting = GetNumberSetting();
                        labTemplateNumber.Text = numberSetting.Replace("[Number]/[Year]", number + "/" + DateTime.Now.Year + "/");

                        List<SqlParameter> paraCreateCustomerAndContract = new List<SqlParameter>()
                        {
                            new SqlParameter() { ParameterName = "@requestDate", SqlDbType = SqlDbType.DateTime, Value = dtpDate.Value },
                            new SqlParameter() { ParameterName = "@contractValue", SqlDbType = SqlDbType.Float, Value = double.Parse(txtGiaTri_CCTT_HD.Text) },
                            new SqlParameter() { ParameterName = "@customerName", SqlDbType = SqlDbType.VarChar, Value = txtCustomerName.Text.Trim() },
                            new SqlParameter() { ParameterName = "@address", SqlDbType = SqlDbType.VarChar, Value = txtCustomerAddress.Text.Trim() },
                            new SqlParameter() { ParameterName = "@mst", SqlDbType = SqlDbType.VarChar, Value = txtMST_CCCD.Text.Trim() },
                            new SqlParameter() { ParameterName = "@phone", SqlDbType = SqlDbType.VarChar, Value = txtCustomerPhoneNo.Text.Trim() },
                            new SqlParameter() { ParameterName = "@number", SqlDbType = SqlDbType.Int, Value = int.Parse(number) },
                            new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year }
                        };
                        var contractIdStr = da.execSqlReturn("sp_CreateCustomerAndContract", paraCreateCustomerAndContract).Tables[0].Rows[0][0].ToString();
                        ContractId = int.Parse(contractIdStr);

                        if (ContractId > 0) isCreate = true;
                    }
                }

                if (isCreate)
                {
                    frmRealEstate realEstate = new frmRealEstate();
                    //realEstate.ContractId = ContractId;
                    DialogResult dr = realEstate.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        //bind data to dgvAssets
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
