namespace ValuationAsset.Forms
{
    partial class frmAssetInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.FileId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDateCCTT = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAttachFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemBatDongSan = new System.Windows.Forms.Button();
            this.btnThemDongSan = new System.Windows.Forms.Button();
            this.txtAssetTotalPrice = new System.Windows.Forms.TextBox();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfManufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelOfLand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acreage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoilType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCTXD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.txtMST_CCCD = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtGiaTri_CCTT_HD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labTemplateNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFile);
            this.panel1.Controls.Add(this.dtpDateCCTT);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnAttachFile);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnThemBatDongSan);
            this.panel1.Controls.Add(this.btnThemDongSan);
            this.panel1.Controls.Add(this.txtAssetTotalPrice);
            this.panel1.Controls.Add(this.dgvAssets);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCustomerPhoneNo);
            this.panel1.Controls.Add(this.txtMST_CCCD);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtGiaTri_CCTT_HD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labTemplateNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 730);
            this.panel1.TabIndex = 0;
            // 
            // dgvFile
            // 
            this.dgvFile.AllowUserToAddRows = false;
            this.dgvFile.AllowUserToDeleteRows = false;
            this.dgvFile.AllowUserToResizeRows = false;
            this.dgvFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileId,
            this.FileName});
            this.dgvFile.Location = new System.Drawing.Point(193, 554);
            this.dgvFile.MultiSelect = false;
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.ReadOnly = true;
            this.dgvFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFile.Size = new System.Drawing.Size(521, 150);
            this.dgvFile.TabIndex = 8;
            this.dgvFile.Text = "dataGridView1";
            this.dgvFile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFile_CellDoubleClick);
            // 
            // FileId
            // 
            this.FileId.DataPropertyName = "ID";
            this.FileId.HeaderText = "Mã";
            this.FileId.Name = "FileId";
            this.FileId.ReadOnly = true;
            this.FileId.Visible = false;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "Tên File";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // dtpDateCCTT
            // 
            this.dtpDateCCTT.CustomFormat = "dd/MM/yyyy";
            this.dtpDateCCTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateCCTT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCCTT.Location = new System.Drawing.Point(686, 269);
            this.dtpDateCCTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateCCTT.Name = "dtpDateCCTT";
            this.dtpDateCCTT.Size = new System.Drawing.Size(136, 26);
            this.dtpDateCCTT.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(405, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 32);
            this.label14.TabIndex = 7;
            this.label14.Text = "THÔNG TIN HỒ SƠ";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(239, 105);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(114, 26);
            this.dtpDate.TabIndex = 0;
            // 
            // btnAttachFile
            // 
            this.btnAttachFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttachFile.Location = new System.Drawing.Point(63, 554);
            this.btnAttachFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttachFile.Name = "btnAttachFile";
            this.btnAttachFile.Size = new System.Drawing.Size(112, 30);
            this.btnAttachFile.TabIndex = 9;
            this.btnAttachFile.Text = "Đính kèm file";
            this.btnAttachFile.UseVisualStyleBackColor = true;
            this.btnAttachFile.Click += new System.EventHandler(this.btnAttachFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1077, 601);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "VNĐ";
            // 
            // btnThemBatDongSan
            // 
            this.btnThemBatDongSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemBatDongSan.Location = new System.Drawing.Point(386, 322);
            this.btnThemBatDongSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBatDongSan.Name = "btnThemBatDongSan";
            this.btnThemBatDongSan.Size = new System.Drawing.Size(130, 30);
            this.btnThemBatDongSan.TabIndex = 8;
            this.btnThemBatDongSan.Text = "Thêm Bất động sản";
            this.btnThemBatDongSan.UseVisualStyleBackColor = true;
            this.btnThemBatDongSan.Click += new System.EventHandler(this.btnThemBatDongSan_Click);
            // 
            // btnThemDongSan
            // 
            this.btnThemDongSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemDongSan.Location = new System.Drawing.Point(223, 322);
            this.btnThemDongSan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDongSan.Name = "btnThemDongSan";
            this.btnThemDongSan.Size = new System.Drawing.Size(130, 30);
            this.btnThemDongSan.TabIndex = 7;
            this.btnThemDongSan.Text = "Thêm Động sản";
            this.btnThemDongSan.UseVisualStyleBackColor = true;
            this.btnThemDongSan.Click += new System.EventHandler(this.btnThemDongSan_Click);
            // 
            // txtAssetTotalPrice
            // 
            this.txtAssetTotalPrice.Enabled = false;
            this.txtAssetTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAssetTotalPrice.Location = new System.Drawing.Point(853, 598);
            this.txtAssetTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssetTotalPrice.Name = "txtAssetTotalPrice";
            this.txtAssetTotalPrice.Size = new System.Drawing.Size(218, 26);
            this.txtAssetTotalPrice.TabIndex = 1;
            // 
            // dgvAssets
            // 
            this.dgvAssets.AllowUserToAddRows = false;
            this.dgvAssets.AllowUserToDeleteRows = false;
            this.dgvAssets.AllowUserToResizeRows = false;
            this.dgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.AssetName,
            this.Model,
            this.YearOfManufacture,
            this.YearOfUse,
            this.Number,
            this.UnitPrice,
            this.Value,
            this.ParcelOfLand,
            this.Map,
            this.Acreage,
            this.SoilType,
            this.ValueCTXD,
            this.StreetName,
            this.WardName});
            this.dgvAssets.Location = new System.Drawing.Point(47, 356);
            this.dgvAssets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAssets.MultiSelect = false;
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.ReadOnly = true;
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssets.Size = new System.Drawing.Size(1046, 179);
            this.dgvAssets.TabIndex = 2;
            this.dgvAssets.Text = "dataGridView1";
            this.dgvAssets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssets_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã tài sản";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 97;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại tài sản";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 103;
            // 
            // AssetName
            // 
            this.AssetName.DataPropertyName = "AssetName";
            this.AssetName.HeaderText = "Tên tài sản";
            this.AssetName.Name = "AssetName";
            this.AssetName.ReadOnly = true;
            this.AssetName.Width = 99;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 74;
            // 
            // YearOfManufacture
            // 
            this.YearOfManufacture.DataPropertyName = "YearOfManufacture";
            this.YearOfManufacture.HeaderText = "Năm sản xuất";
            this.YearOfManufacture.Name = "YearOfManufacture";
            this.YearOfManufacture.ReadOnly = true;
            this.YearOfManufacture.Width = 117;
            // 
            // YearOfUse
            // 
            this.YearOfUse.DataPropertyName = "YearOfUse";
            this.YearOfUse.HeaderText = "Năm sử dụng";
            this.YearOfUse.Name = "YearOfUse";
            this.YearOfUse.ReadOnly = true;
            this.YearOfUse.Width = 116;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Số lượng";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 89;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 81;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Giá trị tài sản";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 113;
            // 
            // ParcelOfLand
            // 
            this.ParcelOfLand.DataPropertyName = "ParcelOfLand";
            this.ParcelOfLand.HeaderText = "Thửa đất";
            this.ParcelOfLand.Name = "ParcelOfLand";
            this.ParcelOfLand.ReadOnly = true;
            this.ParcelOfLand.Width = 89;
            // 
            // Map
            // 
            this.Map.DataPropertyName = "Map";
            this.Map.HeaderText = "Tờ bản đồ";
            this.Map.Name = "Map";
            this.Map.ReadOnly = true;
            this.Map.Width = 97;
            // 
            // Acreage
            // 
            this.Acreage.DataPropertyName = "Acreage";
            this.Acreage.HeaderText = "Diện tích";
            this.Acreage.Name = "Acreage";
            this.Acreage.ReadOnly = true;
            this.Acreage.Width = 87;
            // 
            // SoilType
            // 
            this.SoilType.DataPropertyName = "SoilType";
            this.SoilType.HeaderText = "Loại đất";
            this.SoilType.Name = "SoilType";
            this.SoilType.ReadOnly = true;
            this.SoilType.Width = 84;
            // 
            // ValueCTXD
            // 
            this.ValueCTXD.DataPropertyName = "ValueCTXD";
            this.ValueCTXD.HeaderText = "Giá trị CTXD";
            this.ValueCTXD.Name = "ValueCTXD";
            this.ValueCTXD.ReadOnly = true;
            this.ValueCTXD.Width = 117;
            // 
            // StreetName
            // 
            this.StreetName.DataPropertyName = "StreetName";
            this.StreetName.HeaderText = "Tên đường";
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            // 
            // WardName
            // 
            this.WardName.DataPropertyName = "WardName";
            this.WardName.HeaderText = "Phường/Xã";
            this.WardName.Name = "WardName";
            this.WardName.ReadOnly = true;
            this.WardName.Width = 103;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(592, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày CCTT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(47, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tài Sản Thẩm Định:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(725, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tổng giá trị tài sản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(116, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(169, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(853, 553);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(45, 26);
            this.txtNumber.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(130, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "MST-CCCD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(771, 556);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(132, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // txtCustomerPhoneNo
            // 
            this.txtCustomerPhoneNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerPhoneNo.Location = new System.Drawing.Point(238, 269);
            this.txtCustomerPhoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerPhoneNo.Name = "txtCustomerPhoneNo";
            this.txtCustomerPhoneNo.Size = new System.Drawing.Size(278, 26);
            this.txtCustomerPhoneNo.TabIndex = 5;
            // 
            // txtMST_CCCD
            // 
            this.txtMST_CCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMST_CCCD.Location = new System.Drawing.Point(239, 230);
            this.txtMST_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMST_CCCD.Name = "txtMST_CCCD";
            this.txtMST_CCCD.Size = new System.Drawing.Size(728, 26);
            this.txtMST_CCCD.TabIndex = 4;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerAddress.Location = new System.Drawing.Point(238, 187);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(728, 26);
            this.txtCustomerAddress.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.Location = new System.Drawing.Point(238, 144);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(728, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtGiaTri_CCTT_HD
            // 
            this.txtGiaTri_CCTT_HD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaTri_CCTT_HD.Location = new System.Drawing.Point(802, 105);
            this.txtGiaTri_CCTT_HD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTri_CCTT_HD.Name = "txtGiaTri_CCTT_HD";
            this.txtGiaTri_CCTT_HD.Size = new System.Drawing.Size(165, 26);
            this.txtGiaTri_CCTT_HD.TabIndex = 1;
            this.txtGiaTri_CCTT_HD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_CCTT_HD_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(661, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "GIÁ TRỊ CCTT/HĐ";
            // 
            // labTemplateNumber
            // 
            this.labTemplateNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labTemplateNumber.Location = new System.Drawing.Point(440, 108);
            this.labTemplateNumber.Name = "labTemplateNumber";
            this.labTemplateNumber.Size = new System.Drawing.Size(183, 19);
            this.labTemplateNumber.TabIndex = 0;
            this.labTemplateNumber.Text = "/2020/GYC-EXIMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày yêu cầu: ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 1000;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAssetInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 770);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAssetInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset Manager";
            this.Load += new System.EventHandler(this.frmAssetInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labTemplateNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemDongSan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaTri_CCTT_HD;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtMST_CCCD;
        private System.Windows.Forms.TextBox txtCustomerPhoneNo;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtAssetTotalPrice;
        private System.Windows.Forms.Button btnAttachFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnThemBatDongSan;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfManufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelOfLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Map;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acreage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoilType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCTXD;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WardName;
        private System.Windows.Forms.DateTimePicker dtpDateCCTT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    }
}