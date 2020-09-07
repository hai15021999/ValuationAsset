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
    public partial class frmRealEstate : Form
    {
        public int? ContractId { get; set; }
        public int? AssetId { get; set; }

        DataAccess da = new DataAccess();
        public frmRealEstate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //to do
            try
            {
                string ParcelOfLand = txtThuaDat.Text.Trim();
                string Map = txtToBD.Text.Trim();
                float Acreage = float.Parse(txtDienTich.Text.Trim());
                string SoilType = txtLoaiDat.Text.Trim();
                //int ProvinceId = int.Parse(cbTinh_Thanh.SelectedValue.ToString());
                //int DistrictId = int.Parse(cbQuan_Huyen.SelectedValue.ToString());
                int WardId = int.Parse(cbPhuong_Xa.SelectedValue.ToString());
                int StreetId = int.Parse(cbDuong.SelectedValue.ToString());
                float UnitPrice = float.Parse(txtDonGia.Text.Trim());
                float ValueCTXD = float.Parse(txtTongGiaCTXD.Text.Trim());
                float Value = float.Parse(txtTongGiaTri.Text.Trim());
                if (string.IsNullOrEmpty(ParcelOfLand) || string.IsNullOrEmpty(Map) || string.IsNullOrEmpty(txtDienTich.Text.Trim()) ||
                    string.IsNullOrEmpty(SoilType) || string.IsNullOrEmpty(txtDonGia.Text.Trim()) || string.IsNullOrEmpty(txtTongGiaCTXD.Text.Trim()) ||
                    string.IsNullOrEmpty(txtTongGiaTri.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng không để trống bất kì mục nào!");
                } else {
                    List<SqlParameter> para = new List<SqlParameter>()
                    {
                        new SqlParameter() { ParameterName = "@contractId", SqlDbType = SqlDbType.Int, Value = ContractId },
                        new SqlParameter() { ParameterName = "@type", SqlDbType = SqlDbType.NVarChar, Value = "Bất Động Sản" },
                        new SqlParameter() { ParameterName = "@parcelOfLand", SqlDbType = SqlDbType.NVarChar, Value = ParcelOfLand },
                        new SqlParameter() { ParameterName = "@map", SqlDbType = SqlDbType.NVarChar, Value = Map },
                        new SqlParameter() { ParameterName = "@acreage", SqlDbType = SqlDbType.Float, Value = Acreage },
                        new SqlParameter() { ParameterName = "@soilType", SqlDbType = SqlDbType.NVarChar, Value = SoilType },
                        new SqlParameter() { ParameterName = "@streetId", SqlDbType = SqlDbType.Int, Value = StreetId },
                        new SqlParameter() { ParameterName = "@valueCTXD", SqlDbType = SqlDbType.Float, Value = ValueCTXD },
                        new SqlParameter() { ParameterName = "@wardId", SqlDbType = SqlDbType.Int, Value = WardId },
                        new SqlParameter() { ParameterName = "@unitPrice", SqlDbType = SqlDbType.Float, Value = UnitPrice },
                        new SqlParameter() { ParameterName = "@value", SqlDbType = SqlDbType.Float, Value = Value }
                    };

                    if (AssetId == null)
                    {
                        da.execSqlReturn("sp_CreateAsset", para);
                    } else
                    {
                        para.Add(new SqlParameter() { ParameterName = "@assetId", SqlDbType = SqlDbType.Int, Value = AssetId });
                        da.execSqlReturn("sp_UpdateAsset", para);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            } catch (Exception ex)
            {
                if (ex.ToString().Contains(txtDienTich.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng diện tích!");
                } else if (ex.ToString().Contains(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng đơn giá!");
                }
                else if (ex.ToString().Contains(txtTongGiaCTXD.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng tổng giá CTXD!");
                }
                else if (ex.ToString().Contains(txtTongGiaTri.Text))
                {
                    MessageBox.Show("Vui lòng nhập đúng tổng giá trị!");
                } else
                {
                   MessageBox.Show("Gặp sự cố: " + ex.Message);
                }
               
            }
        }

        private void cbTinh_Thanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var value = cbTinh_Thanh.SelectedValue;
                int provinceId = int.Parse(value.ToString());
                BindDataDistrictList(provinceId);
            }
            catch { }
        }

        private void cbQuan_Huyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int districtId = int.Parse(cbQuan_Huyen.SelectedValue.ToString());
                BindDataWardList(districtId);
                BindDataStreetList(districtId);
            }
            catch { }
        }

        private void BindDataProvincialList()
        {
            string strQuery = "select * from tbProvince";
            var provinces = da.execSqlQuery(strQuery).Tables[0];
            if (provinces.Rows.Count > 0)
            {
                cbTinh_Thanh.DataSource = provinces;
                cbTinh_Thanh.ValueMember = provinces.Columns[0].ToString();
                cbTinh_Thanh.DisplayMember = provinces.Columns[1].ToString();
                cbTinh_Thanh.SelectedItem = 0;
            }
        }

        private void BindDataDistrictList(int provincialId)
        {
            string strQuery = string.Format("SELECT * FROM tbDistrict WHERE ProvinceId = {0}", provincialId);
            var districts = da.execSqlQuery(strQuery).Tables[0];
            if (districts.Rows.Count > 0)
            {
                cbQuan_Huyen.DataSource = districts;
                cbQuan_Huyen.ValueMember = districts.Columns[0].ToString();
                cbQuan_Huyen.DisplayMember = districts.Columns[1].ToString();
                cbQuan_Huyen.SelectedItem = 0;
            }
        }

        private void BindDataWardList(int districtId)
        {
            string strQuery = string.Format("SELECT * FROM tbWard WHERE DistrictId = {0}", districtId);
            var wards = da.execSqlQuery(strQuery).Tables[0];
            if (wards.Rows.Count > 0)
            {
                cbPhuong_Xa.DataSource = wards;
                cbPhuong_Xa.ValueMember = wards.Columns[0].ToString();
                cbPhuong_Xa.DisplayMember = wards.Columns[1].ToString();
                cbPhuong_Xa.SelectedItem = 0;
            }
        }

        private void BindDataStreetList(int districtId)
        {
            string strQuery = string.Format("SELECT * FROM tbStreet WHERE DistrictId = {0}", districtId);
            var streets = da.execSqlQuery(strQuery).Tables[0];
            if (streets.Rows.Count > 0)
            {
                cbDuong.DataSource = streets;
                cbDuong.ValueMember = streets.Columns[0].ToString();
                cbDuong.DisplayMember = streets.Columns[1].ToString();
                cbDuong.SelectedItem = 0;
            }
        }

        private void txtDienTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }

        private void txtTongGiaCTXD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }

        private void txtTongGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar.CompareTo('.') != 0))
                e.Handled = true;
        }

        private void frmRealEstate_Load(object sender, EventArgs e)
        {
            if (!AssetId.HasValue)
            {
                BindDataProvincialList();
            }
            else
            {
                BindDataProvincialList();
                string queryStr = string.Format("SELECT ParcelOfLand, Map, Acreage, SoilType, StreetId, ValueCTXD, Created, WardId, UnitPrice, Value FROM tbAsset WHERE Type = N'Bất Động Sản' and Id = '{0}'", AssetId);
                var realEstate = da.execSqlQuery(queryStr).Tables[0];
                if (realEstate.Rows.Count > 0)
                {
                    string locationQuery = string.Format("SELECT ProvinceId, DistrictId FROM tbStreet WHERE ID = {0}", realEstate.Rows[0]["StreetId"].ToString());
                    var location = da.execSqlQuery(locationQuery).Tables[0];
                    txtThuaDat.Text = realEstate.Rows[0]["ParcelOfLand"].ToString();
                    txtToBD.Text = realEstate.Rows[0]["Map"].ToString();
                    txtDienTich.Text = realEstate.Rows[0]["Acreage"].ToString();
                    txtLoaiDat.Text = realEstate.Rows[0]["SoilType"].ToString();
                    cbTinh_Thanh.SelectedValue = location.Rows[0]["ProvinceId"].ToString();
                    cbQuan_Huyen.SelectedValue = location.Rows[0]["DistrictId"].ToString();
                    cbPhuong_Xa.SelectedValue = realEstate.Rows[0]["WardId"].ToString();
                    cbDuong.SelectedValue = realEstate.Rows[0]["StreetId"].ToString();
                    txtDonGia.Text = realEstate.Rows[0]["UnitPrice"].ToString();
                    txtTongGiaCTXD.Text = realEstate.Rows[0]["ValueCTXD"].ToString();
                    txtTongGiaTri.Text = realEstate.Rows[0]["Value"].ToString();
                }
            }
        }
    }
}
