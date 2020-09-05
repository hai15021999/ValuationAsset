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
        public int ContractId { get; set; }
        public int AssetId { get; set; }


        public frmRealEstate()
        {
            InitializeComponent();
            loadProvinceComboBox();
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

        private void loadProvinceComboBox()
        {
            cbTinh_Thanh.Items.Clear();
            cbQuan_Huyen.Items.Clear();
            cbPhuong_Xa.Items.Clear();
            cbDuong.Items.Clear();

            DataAccess da = new DataAccess();

            string queryStr = "SELECT ID, Name FROM tbProvince";

            var provinces = da.execSqlQuery(queryStr).Tables[0];

            foreach(DataRow dr in provinces.Rows)
            {
                cbTinh_Thanh.Items.Add(dr["Name"].ToString());
            }

        }

        private void cbTinh_Thanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = cbTinh_Thanh.SelectedItem.ToString();
            cbQuan_Huyen.Items.Clear();

            string queryStr = string.Format("Select d.Prefix, d.Name from tbDistrict as d, tbProvince as p Where d.ProvinceId = p.ID and p.Name = N'{0}'", province);

            DataAccess da = new DataAccess();

            var districts = da.execSqlQuery(queryStr).Tables[0];

            foreach (DataRow dr in districts.Rows)
            {
                cbQuan_Huyen.Items.Add(dr["prefix"].ToString() + " " + dr["Name"].ToString());
            }

        }

        private void cbQuan_Huyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = cbTinh_Thanh.SelectedItem.ToString();
            string district = cbQuan_Huyen.SelectedItem.ToString();
            var arr = district.Split(" ");

            string value = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    if (i > 1)
                    {
                        value += " ";
                    }
                    value += arr[i];
                }
            }

            cbPhuong_Xa.Items.Clear();

            string queryStr = string.Format("Select w.Name, w.Prefix from tbWard as w, tbDistrict as d Where w.DistrictId = d.ID and d.Name = N'{0}'", value);
            string queryStr2 = string.Format("Select * FROM tbStreet as s, tbWard as w, tbDistrict as d, tbProvince as p " +
                "Where s.DistrictId = d.ID and s.ProvinceId = p.ID and p.Name = N'{0}' and d.Name = N'{1}'", province, value);
            DataAccess da = new DataAccess();

            var wards = da.execSqlQuery(queryStr).Tables[0];

            foreach (DataRow dr in wards.Rows)
            {
                cbPhuong_Xa.Items.Add(dr["prefix"].ToString() + " " + dr["Name"].ToString());
            }

            var street = da.execSqlQuery(queryStr2).Tables[0];
            foreach (DataRow dr in street.Rows)
            {
                cbDuong.Items.Add(dr["Prefix"].ToString() + " " + dr["Name"].ToString());
            }
        }
    }
}
