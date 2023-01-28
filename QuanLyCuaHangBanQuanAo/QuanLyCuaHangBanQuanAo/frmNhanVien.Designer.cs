
namespace QuanLyCuaHangBanQuanAo
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDSNV
            // 
            this.grbDSNV.Controls.Add(this.dgvDSNV);
            this.grbDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbDSNV.Location = new System.Drawing.Point(10, 229);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Size = new System.Drawing.Size(1095, 330);
            this.grbDSNV.TabIndex = 79;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Text = "Danh sách nhân viên";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colGioiTinh,
            this.colDiaChi,
            this.colNgaySinh,
            this.colSDT,
            this.colChucVu});
            this.dgvDSNV.Location = new System.Drawing.Point(6, 21);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(1083, 303);
            this.dgvDSNV.TabIndex = 0;
            this.dgvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellContentClick);
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 50;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "HoTenNV";
            this.colTenNV.HeaderText = "Họ tên nhân viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 200;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "Phone";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 125;
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "ChucVu";
            this.colChucVu.HeaderText = "Chức vụ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Width = 125;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnReset);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.ForeColor = System.Drawing.Color.Blue;
            this.grbChucNang.Location = new System.Drawing.Point(772, 60);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(333, 163);
            this.grbChucNang.TabIndex = 78;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(180, 93);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnReset.Size = new System.Drawing.Size(115, 49);
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
            this.btnSua.Location = new System.Drawing.Point(38, 93);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSua.Size = new System.Drawing.Size(115, 49);
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
            this.btnXoa.Location = new System.Drawing.Point(180, 31);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(115, 49);
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
            this.btnThem.Location = new System.Drawing.Point(38, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(115, 49);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmbGioiTinh);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.lblMaNV);
            this.grbThongTin.Controls.Add(this.lblTenNV);
            this.grbThongTin.Controls.Add(this.cbChucVu);
            this.grbThongTin.Controls.Add(this.lblSDT);
            this.grbThongTin.Controls.Add(this.lblGioiTinh);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.lblNgaySinh);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.lblChucVu);
            this.grbThongTin.Controls.Add(this.txtMaNV);
            this.grbThongTin.Controls.Add(this.lblDiaChi);
            this.grbThongTin.Controls.Add(this.dtpNgaySinh);
            this.grbThongTin.ForeColor = System.Drawing.Color.Red;
            this.grbThongTin.Location = new System.Drawing.Point(10, 60);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(756, 163);
            this.grbThongTin.TabIndex = 77;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chi tiết";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(505, 29);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(200, 24);
            this.cmbGioiTinh.TabIndex = 72;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 118);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(548, 22);
            this.txtDiaChi.TabIndex = 71;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(35, 33);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(89, 16);
            this.lblMaNV.TabIndex = 58;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(35, 62);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(109, 16);
            this.lblTenNV.TabIndex = 59;
            this.lblTenNV.Text = "Họ tên nhân viên:";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Thu ngân",
            "Quản lý",
            "Thủ kho",
            "Kế toán"});
            this.cbChucVu.Location = new System.Drawing.Point(505, 86);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(200, 24);
            this.cbChucVu.TabIndex = 74;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(35, 89);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 16);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(429, 33);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 61;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(157, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 22);
            this.txtSDT.TabIndex = 70;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(429, 62);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 62;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(157, 60);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(214, 22);
            this.txtTenNV.TabIndex = 69;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(429, 89);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(57, 16);
            this.lblChucVu.TabIndex = 63;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(157, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(214, 22);
            this.txtMaNV.TabIndex = 68;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(35, 117);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 64;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(505, 60);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 73;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(372, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 36);
            this.lblTitle.TabIndex = 76;
            this.lblTitle.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(994, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.btnExit.Size = new System.Drawing.Size(109, 54);
            this.btnExit.TabIndex = 81;
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
            this.btnBack.Location = new System.Drawing.Point(12, 559);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 54);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 625);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbDSNV);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.grbDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}