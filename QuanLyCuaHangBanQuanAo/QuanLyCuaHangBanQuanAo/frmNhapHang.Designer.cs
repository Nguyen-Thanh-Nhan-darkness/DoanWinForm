
namespace QuanLyCuaHangBanQuanAo
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmbMaNCC = new System.Windows.Forms.ComboBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblMaNhap = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChucNang.SuspendLayout();
            this.grbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnReset);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbChucNang.Location = new System.Drawing.Point(6, 51);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbChucNang.Size = new System.Drawing.Size(258, 168);
            this.grbChucNang.TabIndex = 76;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(134, 93);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.btnReset.Size = new System.Drawing.Size(86, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Cài lại";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(27, 93);
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSua.Size = new System.Drawing.Size(86, 40);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(134, 35);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(86, 40);
            this.btnXoa.TabIndex = 5;
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
            this.btnThem.Location = new System.Drawing.Point(27, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnThem.Size = new System.Drawing.Size(86, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.dgvNhapHang);
            this.grbHoaDon.ForeColor = System.Drawing.Color.Red;
            this.grbHoaDon.Location = new System.Drawing.Point(6, 224);
            this.grbHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbHoaDon.Size = new System.Drawing.Size(785, 220);
            this.grbHoaDon.TabIndex = 74;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Nhập hàng";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayLap,
            this.colMaNV,
            this.colTenNV,
            this.colMaKH,
            this.colTenKH,
            this.colSoDT,
            this.Column1});
            this.dgvNhapHang.Location = new System.Drawing.Point(9, 17);
            this.dgvNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(772, 198);
            this.dgvNhapHang.TabIndex = 0;
            this.dgvNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapHang_CellContentClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(316, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 29);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "NHẬP SẢN PHẨM";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmbMaNCC);
            this.grbThongTin.Controls.Add(this.txtTenNCC);
            this.grbThongTin.Controls.Add(this.txtGiaNhap);
            this.grbThongTin.Controls.Add(this.lblTenNCC);
            this.grbThongTin.Controls.Add(this.lblMaNCC);
            this.grbThongTin.Controls.Add(this.lblGiaNhap);
            this.grbThongTin.Controls.Add(this.txtLoaiSP);
            this.grbThongTin.Controls.Add(this.txtMaNhap);
            this.grbThongTin.Controls.Add(this.txtMaSP);
            this.grbThongTin.Controls.Add(this.txtTenSP);
            this.grbThongTin.Controls.Add(this.lblMaSP);
            this.grbThongTin.Controls.Add(this.lblTenSP);
            this.grbThongTin.Controls.Add(this.lblSoLuong);
            this.grbThongTin.Controls.Add(this.txtSoLuong);
            this.grbThongTin.Controls.Add(this.lblLoaiSP);
            this.grbThongTin.Controls.Add(this.lblMaNhap);
            this.grbThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbThongTin.Location = new System.Drawing.Point(273, 51);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Size = new System.Drawing.Size(518, 168);
            this.grbThongTin.TabIndex = 75;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin nhập hàng";
            // 
            // cmbMaNCC
            // 
            this.cmbMaNCC.FormattingEnabled = true;
            this.cmbMaNCC.Location = new System.Drawing.Point(328, 91);
            this.cmbMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaNCC.Name = "cmbMaNCC";
            this.cmbMaNCC.Size = new System.Drawing.Size(120, 21);
            this.cmbMaNCC.TabIndex = 97;
            this.cmbMaNCC.SelectedIndexChanged += new System.EventHandler(this.cmbMaNCC_SelectedIndexChanged);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(328, 124);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(120, 20);
            this.txtTenNCC.TabIndex = 96;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(328, 59);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(120, 20);
            this.txtGiaNhap.TabIndex = 94;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNCC.Location = new System.Drawing.Point(228, 124);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(98, 13);
            this.lblTenNCC.TabIndex = 93;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.ForeColor = System.Drawing.Color.Blue;
            this.lblMaNCC.Location = new System.Drawing.Point(228, 93);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(94, 13);
            this.lblMaNCC.TabIndex = 92;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.ForeColor = System.Drawing.Color.Blue;
            this.lblGiaNhap.Location = new System.Drawing.Point(228, 60);
            this.lblGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(53, 13);
            this.lblGiaNhap.TabIndex = 91;
            this.lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(104, 124);
            this.txtLoaiSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(108, 20);
            this.txtLoaiSP.TabIndex = 90;
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(104, 27);
            this.txtMaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(108, 20);
            this.txtMaNhap.TabIndex = 89;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(104, 58);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(108, 20);
            this.txtMaSP.TabIndex = 87;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(104, 91);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(108, 20);
            this.txtTenSP.TabIndex = 88;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(21, 60);
            this.lblMaSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(74, 13);
            this.lblMaSP.TabIndex = 85;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(21, 93);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);
            this.lblTenSP.TabIndex = 86;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.ForeColor = System.Drawing.Color.Blue;
            this.lblSoLuong.Location = new System.Drawing.Point(228, 28);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(52, 13);
            this.lblSoLuong.TabIndex = 84;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(328, 27);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txtSoLuong.TabIndex = 83;
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(21, 124);
            this.lblLoaiSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(79, 13);
            this.lblLoaiSP.TabIndex = 3;
            this.lblLoaiSP.Text = "Loại sản phẩm:";
            // 
            // lblMaNhap
            // 
            this.lblMaNhap.AutoSize = true;
            this.lblMaNhap.Location = new System.Drawing.Point(21, 28);
            this.lblMaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhap.Name = "lblMaNhap";
            this.lblMaNhap.Size = new System.Drawing.Size(79, 13);
            this.lblMaNhap.TabIndex = 0;
            this.lblMaNhap.Text = "Mã nhập hàng:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(15, 449);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 42);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(126, 449);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 42);
            this.btnThoat.TabIndex = 78;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaNH";
            this.colMaHD.FillWeight = 30F;
            this.colMaHD.HeaderText = "Mã nhập hàng";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "MaSP";
            this.colNgayLap.FillWeight = 30F;
            this.colNgayLap.HeaderText = "Mã sản phẩm";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "TenSP";
            this.colMaNV.FillWeight = 70F;
            this.colMaNV.HeaderText = "Tên sản phẩm";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "LoaiSanPham";
            this.colTenNV.FillWeight = 58.15202F;
            this.colTenNV.HeaderText = "Loại sản phẩm";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // colMaKH
            // 
            this.colMaKH.DataPropertyName = "SoLuong";
            this.colMaKH.FillWeight = 34.01802F;
            this.colMaKH.HeaderText = "Số lượng";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.DataPropertyName = "GiaNhap";
            this.colTenKH.FillWeight = 58.15202F;
            this.colTenKH.HeaderText = "Giá nhập";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            // 
            // colSoDT
            // 
            this.colSoDT.DataPropertyName = "MaNCC";
            this.colSoDT.FillWeight = 58.15202F;
            this.colSoDT.HeaderText = "Mã nhà cung cấp";
            this.colSoDT.MinimumWidth = 6;
            this.colSoDT.Name = "colSoDT";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenNCC";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Tên nhà cung cấp.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 502);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grbChucNang.ResumeLayout(false);
            this.grbHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblMaNhap;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.ComboBox cmbMaNCC;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}