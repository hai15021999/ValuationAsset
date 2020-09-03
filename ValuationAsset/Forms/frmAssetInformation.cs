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
            personalty.ShowDialog();
        }

        private void btnThemBatDongSan_Click(object sender, EventArgs e)
        {
            frmRealEstate realEstate = new frmRealEstate();
            realEstate.ShowDialog();
        }
    }
}
