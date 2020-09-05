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
    public partial class frmRealEstate : Form
    {
        public int? ContractId { get; set; }
        public int? AssetId { get; set; }

        DataAccess da = new DataAccess();
        public frmRealEstate()
        {
            InitializeComponent();
        }

        private void frmRealEstate_Load(object sender, EventArgs e)
        {
            if (!AssetId.HasValue)
            {
                BindDataProvincialList();
            }
            else
            {
                string queryStr = string.Format("SELECT ParcelOfLand, Map, Acreage, SoilType, StreetId, ValueCTXD, Created, WardId, UnitPrice, Value FROM tbAsset WHERE Type = N'Bất Động Sản' and Id = '{0}'", AssetId);
                var realEstate = da.execSqlQuery(queryStr).Tables[0];
                if (realEstate.Rows.Count > 0)
                {
                    string locationQuery = string.Format("SELECT ProvinceId, DistrictId FROM tbStreet WHERE ID = {0}", realEstate.Rows[0]["StreetId"].ToString());
                    var location = da.execSqlQuery(locationQuery).Tables[0];
                    txtThuaDat.Text = realEstate.Rows[0]["ParcelOfLand"].ToString();
                    txtToBD.Text = realEstate.Rows[0]["Map"].ToString();
                    txtDienTich.Text = realEstate.Rows[0]["Acreage"].ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //to do


            this.Dispose();
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

        private void cbPhuong_Xa_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
