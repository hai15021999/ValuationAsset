using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;
using ValuationAsset.Core;

namespace ValuationAsset.Forms
{
    public partial class frmAssetInformation : Form
    {
        DataAccess da = new DataAccess();
        public int? ContractId { get; set; }
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
                List<SqlParameter> para = new List<SqlParameter>()
                {
                    new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = ContractId }
                };
                var number = da.execSqlReturn("sp_GetContractInfo", para).Tables[0];
                dtpDate.Value = DateTime.Parse(number.Rows[0]["RequestDate"].ToString());
                labTemplateNumber.Text = number.Rows[0]["NumberFull"].ToString();
                txtGiaTri_CCTT_HD.Text = number.Rows[0]["ContractValue"].ToString();
                txtCustomerName.Text = number.Rows[0]["CustomerName"].ToString();
                txtCustomerAddress.Text = number.Rows[0]["Address"].ToString();
                txtMST_CCCD.Text = number.Rows[0]["MST"].ToString();
                txtCustomerPhoneNo.Text = number.Rows[0]["Phone"].ToString();
                dtpDateCCTT.Value = DateTime.Parse(number.Rows[0]["DateOfProvision"].ToString());

                BindDataAssetList();
                BindDataFileList();
            }
        }

        private string GetNumberSetting()
        {
            string strQuery = "select [Value] from tbSetting where [Key] = 'TemplateContractNumber'";
            var numberSetting = da.execSqlQuery(strQuery).Tables[0].Rows[0][0].ToString();

            return numberSetting;
        }

        private bool CreateContract()
        {
            if(string.IsNullOrWhiteSpace(txtGiaTri_CCTT_HD.Text.Trim()) || string.IsNullOrWhiteSpace(txtCustomerName.Text.Trim()) || string.IsNullOrWhiteSpace(txtCustomerAddress.Text.Trim())
            || string.IsNullOrWhiteSpace(txtMST_CCCD.Text.Trim()) || string.IsNullOrWhiteSpace(txtCustomerPhoneNo.Text.Trim()))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông", "Thông báo", MessageBoxButtons.OK);

                return false;
            }

            string number = "0";

            if(!ContractId.HasValue)
            {
                List<SqlParameter> paraGetNumber = new List<SqlParameter>()
                {
                    new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year },
                    new SqlParameter() { ParameterName = "@type", SqlDbType = SqlDbType.VarChar, Value = "Contract" }
                };
                number = da.execSqlReturn("sp_GetNumber", paraGetNumber).Tables[0].Rows[0][0].ToString();

                var numberSetting = GetNumberSetting();
                labTemplateNumber.Text = numberSetting.Replace("[Number]/[Year]", number + "/" + DateTime.Now.Year + "/");
            }

            List<SqlParameter> paraCreateCustomerAndContract = new List<SqlParameter>()
            {
                new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = (ContractId.HasValue ? ContractId.Value : 0) },
                new SqlParameter() { ParameterName = "@requestDate", SqlDbType = SqlDbType.DateTime, Value = dtpDate.Value },
                new SqlParameter() { ParameterName = "@contractValue", SqlDbType = SqlDbType.Float, Value = double.Parse(txtGiaTri_CCTT_HD.Text.Trim()) },
                new SqlParameter() { ParameterName = "@customerName", SqlDbType = SqlDbType.NVarChar, Value = txtCustomerName.Text.Trim() },
                new SqlParameter() { ParameterName = "@address", SqlDbType = SqlDbType.NVarChar, Value = txtCustomerAddress.Text.Trim() },
                new SqlParameter() { ParameterName = "@mst", SqlDbType = SqlDbType.VarChar, Value = txtMST_CCCD.Text.Trim() },
                new SqlParameter() { ParameterName = "@phone", SqlDbType = SqlDbType.VarChar, Value = txtCustomerPhoneNo.Text.Trim() },
                new SqlParameter() { ParameterName = "@number", SqlDbType = SqlDbType.Int, Value = int.Parse(number) },
                new SqlParameter() { ParameterName = "@year", SqlDbType = SqlDbType.Int, Value = DateTime.Now.Year },
                new SqlParameter() { ParameterName = "@dateOfProvision", SqlDbType = SqlDbType.DateTime, Value = dtpDateCCTT.Value }
            };
            var contractIdStr = da.execSqlReturn("sp_CreateCustomerAndContract", paraCreateCustomerAndContract).Tables[0].Rows[0][0].ToString();
            ContractId = int.Parse(contractIdStr);

            if (ContractId.HasValue) return true;

            return false;
        }

        private void btnThemDongSan_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCreate = false;

                if (ContractId.HasValue)
                {
                    isCreate = CreateContract();
                }
                else
                {
                    if (MessageBox.Show("Thông tin sẽ được lưu lại. Bạn có tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isCreate = CreateContract();
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
                        BindDataAssetList();
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

                if (ContractId.HasValue)
                {
                    isCreate = CreateContract();
                }
                else
                {
                    if (MessageBox.Show("Thông tin sẽ được lưu lại. Bạn có tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isCreate = CreateContract();
                    }
                }

                if (isCreate)
                {
                    frmRealEstate realEstate = new frmRealEstate();
                    realEstate.ContractId = ContractId;
                    DialogResult dr = realEstate.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        //bind data to dgvAssets
                        BindDataAssetList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void BindDataAssetList()
        {
            if(ContractId.HasValue)
            {
                List<SqlParameter> para = new List<SqlParameter>()
                {
                    new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = ContractId }
                };
                var ret = da.execSqlReturn("sp_GetAssetByContract", para);
                var assets = ret.Tables[0];
                dgvAssets.AutoGenerateColumns = false;
                dgvAssets.DataSource = assets;

                txtAssetTotalPrice.Text = ret.Tables[1].Rows[0][0].ToString();

                txtNumber.Text = assets.Rows.Count.ToString();
            }
        }

        private void BindDataFileList()
        {
            if (ContractId.HasValue)
            {
                string strQuery = string.Format("select * from tbContractFile where ContractId = {0}", ContractId);
                var ret = da.execSqlQuery(strQuery);
                var assets = ret.Tables[0];
                dgvFile.AutoGenerateColumns = false;
                dgvFile.DataSource = assets;
            }
        }

        private void dgvAssets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var type = dgvAssets.CurrentRow.Cells["Type"].Value.ToString();
            var assetIdstr = dgvAssets.CurrentRow.Cells["ID"].Value.ToString();

            if (type.Equals("Động Sản"))
            {
                frmPersonalty personalty = new frmPersonalty();
                personalty.ContractId = ContractId;
                personalty.AssetId = int.Parse(assetIdstr);
                DialogResult dr = personalty.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //bind data to dgvAssets
                    BindDataAssetList();
                }
            }
            if (type.Equals("Bất Động Sản"))
            {
                frmRealEstate realEstate = new frmRealEstate();
                realEstate.ContractId = ContractId;
                realEstate.AssetId = int.Parse(assetIdstr);
                DialogResult dr = realEstate.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //bind data to dgvAssets
                    BindDataAssetList();
                }
            }
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContractId.HasValue)
                {
                    MessageBox.Show("Hồ sơ chưa được tạo.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            var fileName = openFileDialog1.SafeFileName;
                            var filePath = openFileDialog1.FileName;

                            byte[] file;
                            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                            {
                                using (var reader = new BinaryReader(stream))
                                {
                                    file = reader.ReadBytes((int)stream.Length);
                                }
                            }

                            List<SqlParameter> para = new List<SqlParameter>()
                            {
                                new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = ContractId },
                                new SqlParameter() { ParameterName = "@fileName", SqlDbType = SqlDbType.VarChar, Value = fileName },
                                new SqlParameter() { ParameterName = "@data", SqlDbType = SqlDbType.VarBinary, Value = file }
                            };
                            da.execSqlReturn("sp_CreateContractFile", para);

                            BindDataFileList();
                        }
                        catch (SecurityException ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void txtGiaTri_CCTT_HD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dgvFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("File sẽ được lưu về máy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var idstr = dgvFile.CurrentRow.Cells["FileId"].Value.ToString();
                    var id = int.Parse(idstr);

                    string select = string.Format("SELECT FileName, FileData from tbContractFile where ID = {0}", id);
                    var ret = da.execSqlQuery(select);

                    byte[] blob;
                    byte[] blob2;

                    blob = (byte[])ret.Tables[0].Rows[0]["FileData"];//(byte[])reader[0];

                    blob2 = System.Text.Encoding.Default.GetBytes(System.Text.Encoding.Unicode.GetString(blob));

                    var path = @"C:\Test\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    path += ret.Tables[0].Rows[0]["FileName"].ToString();

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        fs.Write(blob2, 0, blob2.Length);
                        fs.Flush();
                    }

                    System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", path));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CreateContract();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}
