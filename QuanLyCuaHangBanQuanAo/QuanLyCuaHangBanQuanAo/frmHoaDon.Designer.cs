
namespace QuanLyCuaHangBanQuanAo
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grbHoaDon.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnCTHD);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Location = new System.Drawing.Point(530, 59);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucNang.Size = new System.Drawing.Size(258, 168);
            this.grbChucNang.TabIndex = 72;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(87, 72);
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(86, 40);
            this.btnSua.TabIndex = 102;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.BackColor = System.Drawing.Color.White;
            this.btnCTHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTHD.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCTHD.Location = new System.Drawing.Point(22, 121);
            this.btnCTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(218, 35);
            this.btnCTHD.TabIndex = 66;
            this.btnCTHD.Text = "Xem chi tiết hóa đơn\r\n";
            this.btnCTHD.UseVisualStyleBackColor = false;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(136, 23);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(86, 40);
            this.btnXoa.TabIndex = 101;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(29, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThem.Size = new System.Drawing.Size(86, 40);
            this.btnThem.TabIndex = 100;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(374, 20);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(125, 21);
            this.cmbMaKH.TabIndex = 11;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.cmbMaKH_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(108, 89);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(125, 20);
            this.txtTenNV.TabIndex = 20;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(27, 89);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 12;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(108, 43);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(125, 20);
            this.dtpNgayLap.TabIndex = 9;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayLap,
            this.colMaNV,
            this.colTenNV,
            this.colMaKH,
            this.colTenKH,
            this.colSoDT});
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 17);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(772, 198);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.FillWeight = 30F;
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLapHD";
            this.colNgayLap.FillWeight = 58.15202F;
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.FillWeight = 34.01802F;
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenNV";
            this.colTenNV.FillWeight = 58.15202F;
            this.colTenNV.HeaderText = "Tên nhân viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "MaKh";
            this.colMaKH.FillWeight = 34.01802F;
            this.colMaKH.HeaderText = "Mã khách hàng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "TenKh";
            this.colTenKH.FillWeight = 58.15202F;
            this.colTenKH.HeaderText = "Tên khách hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            // 
            // colSoDT
            // 
            this.colSoDT.DataPropertyName = "SoDienThoai";
            this.colSoDT.FillWeight = 58.15202F;
            this.colSoDT.HeaderText = "Số điện thoại";
            this.colSoDT.MinimumWidth = 6;
            this.colSoDT.Name = "colSoDT";
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.dgvHoaDon);
            this.grbHoaDon.ForeColor = System.Drawing.Color.Red;
            this.grbHoaDon.Location = new System.Drawing.Point(8, 232);
            this.grbHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHoaDon.Size = new System.Drawing.Size(785, 220);
            this.grbHoaDon.TabIndex = 70;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa đơn";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(292, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 29);
            this.lblTitle.TabIndex = 69;
            this.lblTitle.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(374, 68);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(125, 20);
            this.txtSDT.TabIndex = 22;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(108, 20);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(125, 20);
            this.txtMaHD.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(374, 46);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(125, 20);
            this.txtTenKH.TabIndex = 21;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(286, 24);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(85, 13);
            this.lblMaKH.TabIndex = 5;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(286, 72);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 13);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(286, 48);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(89, 13);
            this.lblTenKH.TabIndex = 3;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(27, 68);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(27, 24);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmbMaNV);
            this.grbThongTin.Controls.Add(this.cmbMaKH);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.lblTenNV);
            this.grbThongTin.Controls.Add(this.dtpNgayLap);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.txtMaHD);
            this.grbThongTin.Controls.Add(this.txtTenKH);
            this.grbThongTin.Controls.Add(this.lblMaKH);
            this.grbThongTin.Controls.Add(this.lblSDT);
            this.grbThongTin.Controls.Add(this.lblTenKH);
            this.grbThongTin.Controls.Add(this.lblMaNV);
            this.grbThongTin.Controls.Add(this.lblNgayLap);
            this.grbThongTin.Controls.Add(this.lblMaHD);
            this.grbThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbThongTin.Location = new System.Drawing.Point(16, 59);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Size = new System.Drawing.Size(509, 168);
            this.grbThongTin.TabIndex = 71;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin hóa đơn";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(108, 63);
            this.cmbMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(125, 21);
            this.cmbMaNV.TabIndex = 10;
            this.cmbMaNV.SelectedIndexChanged += new System.EventHandler(this.cmbMaNV_SelectedIndexChanged);
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(27, 46);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(71, 13);
            this.lblNgayLap.TabIndex = 1;
            this.lblNgayLap.Text = "Ngày lập HĐ:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(709, 457);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 0, 6, 0);
            this.btnExit.Size = new System.Drawing.Size(82, 44);
            this.btnExit.TabIndex = 104;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(9, 457);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 44);
            this.btnBack.TabIndex = 103;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grbHoaDon.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
    }
}