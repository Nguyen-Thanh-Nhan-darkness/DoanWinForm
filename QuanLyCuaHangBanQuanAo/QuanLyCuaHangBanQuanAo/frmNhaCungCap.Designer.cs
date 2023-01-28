
namespace QuanLyCuaHangBanQuanAo
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblGiaNhap = new System.Windows.Forms.Label();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblLoaiHang = new System.Windows.Forms.Label();
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grbThongTin.SuspendLayout();
            this.grbDSNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.txtGiaNhap);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.lblMaNCC);
            this.grbThongTin.Controls.Add(this.lblTenNCC);
            this.grbThongTin.Controls.Add(this.lblSDT);
            this.grbThongTin.Controls.Add(this.lblGiaNhap);
            this.grbThongTin.Controls.Add(this.txtLoaiHang);
            this.grbThongTin.Controls.Add(this.lblEmail);
            this.grbThongTin.Controls.Add(this.txtTenNCC);
            this.grbThongTin.Controls.Add(this.txtMaNCC);
            this.grbThongTin.Controls.Add(this.lblLoaiHang);
            this.grbThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbThongTin.Location = new System.Drawing.Point(10, 67);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(756, 144);
            this.grbThongTin.TabIndex = 85;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chi tiết";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(531, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 73;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(531, 62);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(214, 22);
            this.txtGiaNhap.TabIndex = 72;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(531, 33);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 22);
            this.txtSDT.TabIndex = 71;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(44, 33);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(121, 17);
            this.lblMaNCC.TabIndex = 58;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(42, 63);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(127, 17);
            this.lblTenNCC.TabIndex = 59;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(433, 35);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(95, 17);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblGiaNhap
            // 
            this.lblGiaNhap.AutoSize = true;
            this.lblGiaNhap.Location = new System.Drawing.Point(433, 62);
            this.lblGiaNhap.Name = "lblGiaNhap";
            this.lblGiaNhap.Size = new System.Drawing.Size(70, 17);
            this.lblGiaNhap.TabIndex = 61;
            this.lblGiaNhap.Text = "Giá nhập:";
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Location = new System.Drawing.Point(174, 89);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(214, 22);
            this.txtLoaiHang.TabIndex = 70;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(433, 89);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "Email:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(174, 60);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(214, 22);
            this.txtTenNCC.TabIndex = 69;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(174, 33);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(214, 22);
            this.txtMaNCC.TabIndex = 68;
            // 
            // lblLoaiHang
            // 
            this.lblLoaiHang.AutoSize = true;
            this.lblLoaiHang.Location = new System.Drawing.Point(44, 91);
            this.lblLoaiHang.Name = "lblLoaiHang";
            this.lblLoaiHang.Size = new System.Drawing.Size(75, 17);
            this.lblLoaiHang.TabIndex = 64;
            this.lblLoaiHang.Text = "Loại hàng:";
            // 
            // grbDSNV
            // 
            this.grbDSNV.Controls.Add(this.dgvNCC);
            this.grbDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbDSNV.Location = new System.Drawing.Point(10, 217);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Size = new System.Drawing.Size(1095, 343);
            this.grbDSNV.TabIndex = 87;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Text = "Danh sách nhà cung cấp";
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colTenNV,
            this.colLoaiHang,
            this.colGiaNhap,
            this.colSDT,
            this.colEmail});
            this.dgvNCC.Location = new System.Drawing.Point(15, 21);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(1074, 316);
            this.dgvNCC.TabIndex = 0;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MaNCC";
            this.colMaNCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNCC.MinimumWidth = 6;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Width = 50;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenNCC";
            this.colTenNV.HeaderText = "Tên nhà cung cấp";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 200;
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.DataPropertyName = "LoaiHang";
            this.colLoaiHang.HeaderText = "Loại hàng";
            this.colLoaiHang.MinimumWidth = 6;
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.Width = 125;
            // 
            // colGiaNhap
            // 
            this.colGiaNhap.DataPropertyName = "GiaNhap";
            this.colGiaNhap.HeaderText = "Giá nhập";
            this.colGiaNhap.MinimumWidth = 6;
            this.colGiaNhap.Name = "colGiaNhap";
            this.colGiaNhap.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "Phone";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "DCMail";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 125;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnReset);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbChucNang.Location = new System.Drawing.Point(772, 67);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(333, 144);
            this.grbChucNang.TabIndex = 86;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(359, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 36);
            this.lblTitle.TabIndex = 84;
            this.lblTitle.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(178, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnReset.Size = new System.Drawing.Size(115, 49);
            this.btnReset.TabIndex = 91;
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
            this.btnSua.Location = new System.Drawing.Point(36, 80);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSua.Size = new System.Drawing.Size(115, 49);
            this.btnSua.TabIndex = 90;
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
            this.btnXoa.Location = new System.Drawing.Point(178, 24);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(115, 49);
            this.btnXoa.TabIndex = 89;
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
            this.btnThem.Location = new System.Drawing.Point(36, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(115, 49);
            this.btnThem.TabIndex = 88;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(994, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.btnExit.Size = new System.Drawing.Size(109, 54);
            this.btnExit.TabIndex = 93;
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
            this.btnBack.Location = new System.Drawing.Point(12, 566);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 54);
            this.btnBack.TabIndex = 92;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 625);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbDSNV);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbDSNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblGiaNhap;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblLoaiHang;
        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}