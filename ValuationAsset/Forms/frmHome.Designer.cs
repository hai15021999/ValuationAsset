namespace ValuationAsset.Forms
{
    partial class frmHome
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listFile = new System.Windows.Forms.ListView();
            this.chSTT = new System.Windows.Forms.ColumnHeader();
            this.chFileTitle = new System.Windows.Forms.ColumnHeader();
            this.btnAttackFile = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAssets = new System.Windows.Forms.DataGridView();
            this.txtMST_CCCD = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAssetTotalPrice = new System.Windows.Forms.TextBox();
            this.txtDateOf_CCTT = new System.Windows.Forms.TextBox();
            this.txtNgayYeuCau = new System.Windows.Forms.TextBox();
            this.txtNumberOf_CCTT = new System.Windows.Forms.TextBox();
            this.txtGiaTri_CCTT_HD = new System.Windows.Forms.TextBox();
            this.txtSo_NgayYeuCau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(68, 567);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(167, 29);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Test Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(40, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1393, 830);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1385, 843);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName});
            this.dataGridView1.Location = new System.Drawing.Point(45, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(328, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1385, 797);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listFile);
            this.panel1.Controls.Add(this.btnAttackFile);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvAssets);
            this.panel1.Controls.Add(this.txtMST_CCCD);
            this.panel1.Controls.Add(this.txtCustomerPhoneNo);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtAssetTotalPrice);
            this.panel1.Controls.Add(this.txtDateOf_CCTT);
            this.panel1.Controls.Add(this.txtNgayYeuCau);
            this.panel1.Controls.Add(this.txtNumberOf_CCTT);
            this.panel1.Controls.Add(this.txtGiaTri_CCTT_HD);
            this.panel1.Controls.Add(this.txtSo_NgayYeuCau);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 785);
            this.panel1.TabIndex = 1;
            // 
            // listFile
            // 
            this.listFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSTT,
            this.chFileTitle});
            this.listFile.HideSelection = false;
            this.listFile.Location = new System.Drawing.Point(189, 551);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(1159, 211);
            this.listFile.TabIndex = 5;
            this.listFile.UseCompatibleStateImageBehavior = false;
            this.listFile.View = System.Windows.Forms.View.Details;
            // 
            // chSTT
            // 
            this.chSTT.Text = "STT";
            this.chSTT.Width = 100;
            // 
            // chFileTitle
            // 
            this.chFileTitle.Text = "Title";
            this.chFileTitle.Width = 1000;
            // 
            // btnAttackFile
            // 
            this.btnAttackFile.Location = new System.Drawing.Point(59, 551);
            this.btnAttackFile.Name = "btnAttackFile";
            this.btnAttackFile.Size = new System.Drawing.Size(94, 29);
            this.btnAttackFile.TabIndex = 4;
            this.btnAttackFile.Text = "Attack File";
            this.btnAttackFile.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(780, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "GIÁ TRỊ CCTT/HĐ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(648, 504);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tổng giá trị tài sản:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(369, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Số:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1094, 504);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(489, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số:";
            // 
            // dgvAssets
            // 
            this.dgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssets.Location = new System.Drawing.Point(31, 244);
            this.dgvAssets.Name = "dgvAssets";
            this.dgvAssets.RowHeadersWidth = 51;
            this.dgvAssets.Size = new System.Drawing.Size(1317, 239);
            this.dgvAssets.TabIndex = 2;
            this.dgvAssets.Text = "dataGridView1";
            // 
            // txtMST_CCCD
            // 
            this.txtMST_CCCD.Location = new System.Drawing.Point(320, 138);
            this.txtMST_CCCD.Name = "txtMST_CCCD";
            this.txtMST_CCCD.Size = new System.Drawing.Size(831, 27);
            this.txtMST_CCCD.TabIndex = 1;
            // 
            // txtCustomerPhoneNo
            // 
            this.txtCustomerPhoneNo.Location = new System.Drawing.Point(320, 171);
            this.txtCustomerPhoneNo.Name = "txtCustomerPhoneNo";
            this.txtCustomerPhoneNo.Size = new System.Drawing.Size(831, 27);
            this.txtCustomerPhoneNo.TabIndex = 1;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(320, 105);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(831, 27);
            this.txtCustomerAddress.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(320, 73);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(831, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtAssetTotalPrice
            // 
            this.txtAssetTotalPrice.Location = new System.Drawing.Point(831, 505);
            this.txtAssetTotalPrice.Name = "txtAssetTotalPrice";
            this.txtAssetTotalPrice.Size = new System.Drawing.Size(248, 27);
            this.txtAssetTotalPrice.TabIndex = 1;
            // 
            // txtDateOf_CCTT
            // 
            this.txtDateOf_CCTT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateOf_CCTT.Location = new System.Drawing.Point(189, 502);
            this.txtDateOf_CCTT.Name = "txtDateOf_CCTT";
            this.txtDateOf_CCTT.Size = new System.Drawing.Size(156, 27);
            this.txtDateOf_CCTT.TabIndex = 1;
            this.txtDateOf_CCTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNgayYeuCau
            // 
            this.txtNgayYeuCau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayYeuCau.Location = new System.Drawing.Point(320, 17);
            this.txtNgayYeuCau.Name = "txtNgayYeuCau";
            this.txtNgayYeuCau.Size = new System.Drawing.Size(156, 27);
            this.txtNgayYeuCau.TabIndex = 1;
            this.txtNgayYeuCau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumberOf_CCTT
            // 
            this.txtNumberOf_CCTT.Location = new System.Drawing.Point(429, 503);
            this.txtNumberOf_CCTT.Name = "txtNumberOf_CCTT";
            this.txtNumberOf_CCTT.Size = new System.Drawing.Size(51, 27);
            this.txtNumberOf_CCTT.TabIndex = 1;
            // 
            // txtGiaTri_CCTT_HD
            // 
            this.txtGiaTri_CCTT_HD.Location = new System.Drawing.Point(935, 14);
            this.txtGiaTri_CCTT_HD.Name = "txtGiaTri_CCTT_HD";
            this.txtGiaTri_CCTT_HD.Size = new System.Drawing.Size(216, 27);
            this.txtGiaTri_CCTT_HD.TabIndex = 1;
            // 
            // txtSo_NgayYeuCau
            // 
            this.txtSo_NgayYeuCau.Location = new System.Drawing.Point(532, 17);
            this.txtSo_NgayYeuCau.Name = "txtSo_NgayYeuCau";
            this.txtSo_NgayYeuCau.Size = new System.Drawing.Size(51, 27);
            this.txtSo_NgayYeuCau.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(589, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "/2020/GYC-EXIMA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(210, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(80, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày CCTT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tài Sản Thẩm Định:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(165, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số điện thoại:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(151, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên khách hàng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(180, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "MST-CCCD:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(160, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Ngày yêu cầu: ";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên tài sản";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Năm sản xuất";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Năm đưa vào sử dụng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 175;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá trị";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "GIÁ TRỊ CCTT/HĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 984);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "/2020/CCTT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(458, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng giá trị tài sản:";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 870);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAssets;
        private System.Windows.Forms.TextBox txtMST_CCCD;
        private System.Windows.Forms.TextBox txtCustomerPhoneNo;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAssetTotalPrice;
        private System.Windows.Forms.TextBox txtDateOf_CCTT;
        private System.Windows.Forms.TextBox txtNgayYeuCau;
        private System.Windows.Forms.TextBox txtNumberOf_CCTT;
        private System.Windows.Forms.TextBox txtGiaTri_CCTT_HD;
        private System.Windows.Forms.TextBox txtSo_NgayYeuCau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.ColumnHeader chSTT;
        private System.Windows.Forms.ColumnHeader chFileTitle;
        private System.Windows.Forms.Button btnAttackFile;
    }
}