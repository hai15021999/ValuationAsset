namespace ValuationAsset
{
    partial class frmPersonalty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.clNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAssetsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYearOfManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clYearOfUsing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMST_CCCD = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAssetTotalPrice = new System.Windows.Forms.TextBox();
            this.txtDateOfCCTT = new System.Windows.Forms.TextBox();
            this.txtDateRequest = new System.Windows.Forms.TextBox();
            this.txtCCTTNumber = new System.Windows.Forms.TextBox();
            this.txtCCTT_HD_Value = new System.Windows.Forms.TextBox();
            this.txtRequestNumber = new System.Windows.Forms.TextBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(508, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỘNG SẢN";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvAssets);
            this.panel1.Controls.Add(this.txtMST_CCCD);
            this.panel1.Controls.Add(this.txtCustomerPhoneNumber);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtAssetTotalPrice);
            this.panel1.Controls.Add(this.txtDateOfCCTT);
            this.panel1.Controls.Add(this.txtDateRequest);
            this.panel1.Controls.Add(this.txtCCTTNumber);
            this.panel1.Controls.Add(this.txtCCTT_HD_Value);
            this.panel1.Controls.Add(this.txtRequestNumber);
            this.panel1.Controls.Add(this.txtSo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 601);
            this.panel1.TabIndex = 1;
            // 
            // dgvAssets
            // 
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNo,
            this.clAssetsName,
            this.clModel,
            this.clYearOfManufacture,
            this.clYearOfUsing,
            this.clQuantity,
            this.clPrice,
            this.clValues});
            this.dgvAssets.Location = new System.Drawing.Point(31, 236);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.Size = new System.Drawing.Size(1088, 239);
            this.dgvAssets.TabIndex = 2;
            this.dgvAssets.Text = "dataGridView1";
            // 
            // clNo
            // 
            this.clNo.HeaderText = "STT";
            this.clNo.MinimumWidth = 6;
            this.clNo.Name = "clNo";
            this.clNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clNo.Width = 50;
            // 
            // clAssetsName
            // 
            this.clAssetsName.HeaderText = "Tên tài sản";
            this.clAssetsName.MinimumWidth = 6;
            this.clAssetsName.Name = "clAssetsName";
            this.clAssetsName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clAssetsName.Width = 250;
            // 
            // clModel
            // 
            this.clModel.HeaderText = "Model";
            this.clModel.MinimumWidth = 6;
            this.clModel.Name = "clModel";
            this.clModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clModel.Width = 125;
            // 
            // clYearOfManufacture
            // 
            this.clYearOfManufacture.HeaderText = "Năm sản xuất";
            this.clYearOfManufacture.MinimumWidth = 6;
            this.clYearOfManufacture.Name = "clYearOfManufacture";
            this.clYearOfManufacture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clYearOfManufacture.Width = 125;
            // 
            // clYearOfUsing
            // 
            this.clYearOfUsing.HeaderText = "Năm đưa vào sử dụng";
            this.clYearOfUsing.MinimumWidth = 6;
            this.clYearOfUsing.Name = "clYearOfUsing";
            this.clYearOfUsing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clYearOfUsing.Width = 125;
            // 
            // clQuantity
            // 
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.MinimumWidth = 6;
            this.clQuantity.Name = "clQuantity";
            this.clQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clQuantity.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Đơn giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clPrice.Width = 175;
            // 
            // clValues
            // 
            this.clValues.HeaderText = "Giá trị";
            this.clValues.MinimumWidth = 6;
            this.clValues.Name = "clValues";
            this.clValues.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clValues.Width = 125;
            // 
            // txtMST_CCCD
            // 
            this.txtMST_CCCD.Location = new System.Drawing.Point(180, 139);
            this.txtMST_CCCD.Name = "txtMST_CCCD";
            this.txtMST_CCCD.Size = new System.Drawing.Size(486, 27);
            this.txtMST_CCCD.TabIndex = 1;
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(180, 172);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(486, 27);
            this.txtCustomerPhoneNumber.TabIndex = 1;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(180, 106);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(486, 27);
            this.txtCustomerAddress.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(180, 74);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(486, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtAssetTotalPrice
            // 
            this.txtAssetTotalPrice.Location = new System.Drawing.Point(204, 550);
            this.txtAssetTotalPrice.Name = "txtAssetTotalPrice";
            this.txtAssetTotalPrice.Size = new System.Drawing.Size(248, 27);
            this.txtAssetTotalPrice.TabIndex = 1;
            // 
            // txtDateOfCCTT
            // 
            this.txtDateOfCCTT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOfCCTT.Location = new System.Drawing.Point(132, 500);
            this.txtDateOfCCTT.Name = "txtDateOfCCTT";
            this.txtDateOfCCTT.Size = new System.Drawing.Size(156, 27);
            this.txtDateOfCCTT.TabIndex = 1;
            this.txtDateOfCCTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDateRequest
            // 
            this.txtDateRequest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateRequest.Location = new System.Drawing.Point(132, 19);
            this.txtDateRequest.Name = "txtDateRequest";
            this.txtDateRequest.Size = new System.Drawing.Size(156, 27);
            this.txtDateRequest.TabIndex = 1;
            this.txtDateRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCCTTNumber
            // 
            this.txtCCTTNumber.Location = new System.Drawing.Point(329, 500);
            this.txtCCTTNumber.Name = "txtCCTTNumber";
            this.txtCCTTNumber.Size = new System.Drawing.Size(51, 27);
            this.txtCCTTNumber.TabIndex = 1;
            // 
            // txtCCTT_HD_Value
            // 
            this.txtCCTT_HD_Value.Location = new System.Drawing.Point(721, 19);
            this.txtCCTT_HD_Value.Name = "txtCCTT_HD_Value";
            this.txtCCTT_HD_Value.Size = new System.Drawing.Size(150, 27);
            this.txtCCTT_HD_Value.TabIndex = 1;
            // 
            // txtRequestNumber
            // 
            this.txtRequestNumber.Location = new System.Drawing.Point(331, 19);
            this.txtRequestNumber.Name = "txtRequestNumber";
            this.txtRequestNumber.Size = new System.Drawing.Size(51, 27);
            this.txtRequestNumber.TabIndex = 1;
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(331, 19);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(51, 27);
            this.txtSo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "GIÁ TRỊ CCTT/HĐ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 984);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 503);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "/2020/CCTT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "/2020/GYC-EXIMA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(458, 551);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(31, 554);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(167, 23);
            this.lb.TabIndex = 0;
            this.lb.Text = "Tổng giá trị tài sản:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày CCTT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tài Sản Thẩm Định:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "MST-CCCD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày yêu cầu: ";
            // 
            // frmPersonalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonalty";
            this.Text = "frmPersonalty";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDateRequest;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMST_CCCD;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtDateOfCCTT;
        private System.Windows.Forms.TextBox txtRequestNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCCTTNumber;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtAssetTotalPrice;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.TextBox txtCCTT_HD_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAssetsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYearOfManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clYearOfUsing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValues;
    }
}