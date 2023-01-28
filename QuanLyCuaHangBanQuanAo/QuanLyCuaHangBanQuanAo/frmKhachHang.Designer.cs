
namespace QuanLyCuaHangBanQuanAo
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.grbDSNV = new System.Windows.Forms.GroupBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.grbDSNV.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // colChucVu
            // 
            this.colChucVu.DataPropertyName = "DCMail";
            this.colChucVu.HeaderText = "Email";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "Phone";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 125;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 125;
            // 
            // colTenNV
            // 
            this.colTenNV.DataPropertyName = "TenKH";
            this.colTenNV.HeaderText = "Họ tên khách hàng";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Width = 200;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaKH";
            this.colMaNV.HeaderText = "Mã khách hàng";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 50;
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colDiaChi,
            this.colSDT,
            this.colChucVu});
            this.dgvDSKH.Location = new System.Drawing.Point(6, 21);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.RowTemplate.Height = 24;
            this.dgvDSKH.Size = new System.Drawing.Size(1079, 289);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellContentClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(499, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 22);
            this.txtEmail.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(161, 89);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(552, 22);
            this.txtDiaChi.TabIndex = 72;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(25, 33);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(101, 16);
            this.lblMaNV.TabIndex = 58;
            this.lblMaNV.Text = "Mã khách hàng:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(25, 62);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(121, 16);
            this.lblTenNV.TabIndex = 59;
            this.lblTenNV.Text = "Họ tên khách hàng:";
            // 
            // grbDSNV
            // 
            this.grbDSNV.Controls.Add(this.dgvDSKH);
            this.grbDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbDSNV.Location = new System.Drawing.Point(10, 233);
            this.grbDSNV.Name = "grbDSNV";
            this.grbDSNV.Size = new System.Drawing.Size(1091, 316);
            this.grbDSNV.TabIndex = 87;
            this.grbDSNV.TabStop = false;
            this.grbDSNV.Text = "Danh sách nhân viên";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(400, 35);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 16);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(161, 61);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(203, 22);
            this.txtTenKH.TabIndex = 69;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(161, 33);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(203, 22);
            this.txtMaKH.TabIndex = 68;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(25, 92);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 64;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txtEmail);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.lblMaNV);
            this.grbThongTin.Controls.Add(this.lblTenNV);
            this.grbThongTin.Controls.Add(this.lblSDT);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.txtTenKH);
            this.grbThongTin.Controls.Add(this.txtMaKH);
            this.grbThongTin.Controls.Add(this.lblDiaChi);
            this.grbThongTin.ForeColor = System.Drawing.Color.Red;
            this.grbThongTin.Location = new System.Drawing.Point(10, 64);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(756, 163);
            this.grbThongTin.TabIndex = 85;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chi tiết";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(499, 32);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 22);
            this.txtSDT.TabIndex = 70;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnReset);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.ForeColor = System.Drawing.Color.Blue;
            this.grbChucNang.Location = new System.Drawing.Point(772, 64);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(333, 163);
            this.grbChucNang.TabIndex = 86;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(186, 89);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5, 0, 4, 0);
            this.btnReset.Size = new System.Drawing.Size(115, 49);
            this.btnReset.TabIndex = 97;
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
            this.btnSua.Location = new System.Drawing.Point(44, 89);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnSua.Size = new System.Drawing.Size(115, 49);
            this.btnSua.TabIndex = 96;
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
            this.btnXoa.Location = new System.Drawing.Point(186, 33);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(115, 49);
            this.btnXoa.TabIndex = 95;
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
            this.btnThem.Location = new System.Drawing.Point(44, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnThem.Size = new System.Drawing.Size(115, 49);
            this.btnThem.TabIndex = 94;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(372, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(404, 36);
            this.lblTitle.TabIndex = 84;
            this.lblTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(994, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.btnExit.Size = new System.Drawing.Size(109, 54);
            this.btnExit.TabIndex = 99;
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
            this.btnBack.Location = new System.Drawing.Point(12, 555);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 54);
            this.btnBack.TabIndex = 98;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 619);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grbDSNV);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.grbDSNV.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.GroupBox grbDSNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}