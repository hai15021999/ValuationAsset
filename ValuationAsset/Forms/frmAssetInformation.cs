using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ValuationAsset.Forms
{
    public partial class frmAssetInformation : Form
    {
        public frmAssetInformation()
        {
            InitializeComponent();
        }

        private void btnThemDongSan_Click(object sender, EventArgs e)
        {
            frmPersonalty personalty = new frmPersonalty();
            DialogResult dr = personalty.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                personalty.Close();
            }
            else if (dr == DialogResult.OK)
            {
                MessageBox.Show("test");
            }
        }

        private void btnThemBatDongSan_Click(object sender, EventArgs e)
        {
            frmRealEstate realEstate = new frmRealEstate();
            DialogResult dr = realEstate.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                realEstate.Close();
            }
            else if (dr == DialogResult.OK)
            {
                MessageBox.Show("test");
            }
        }
    }
}
