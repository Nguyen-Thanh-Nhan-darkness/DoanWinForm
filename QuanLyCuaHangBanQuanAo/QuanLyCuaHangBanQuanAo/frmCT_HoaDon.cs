using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHangBanQuanAo
{
    public partial class frmCT_HoaDon : Form
    {
        public frmCT_HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public string truyenMaHD;
        public string truyenNgayLap;
        public string truyenMaNV;
        public string truyenTenNV;
        public string truyenMaKH;
        public string truyenTenKh;
        public string truyenSDT;
        private void themMaNV(ref ComboBox combobox, string query)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand conma = new SqlCommand(query, conn);
            SqlDataReader dataReader = conma.ExecuteReader();
            while (dataReader.Read())
            {
                combobox.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            conn.Close();
        }
        public bool KTMaHD(string mahd)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select MaHD from CT_HoaDon where MaHD='" + mahd + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == true)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
        private void themMaKH(ref ComboBox combobox, string query)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand conma = new SqlCommand(query, conn);
            SqlDataReader dataReader = conma.ExecuteReader();
            while (dataReader.Read())
            {
                combobox.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            conn.Close();
        }
        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CT_HoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTin.DataSource = table;
            for (int i = 0; i < dgvThongTin.RowCount - 1; i++)
            {
                float dongia = float.Parse(dgvThongTin.Rows[i].Cells["colGiaBan"].Value.ToString());
                int soluong = int.Parse(dgvThongTin.Rows[i].Cells["colSoLuong"].Value.ToString());
                float chietkhau = float.Parse(dgvThongTin.Rows[i].Cells["colChieuKau"].Value.ToString());

                float thanhtien = (dongia * soluong) - ((dongia * soluong) * (chietkhau / 100));

                dgvThongTin.Rows[i].Cells["ThanhTien"].Value = thanhtien;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
            this.Hide();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnXemCTHD_Click(object sender, EventArgs e)
        //{
        //    frmXemCT_HoaDon sd = new frmXemCT_HoaDon();
        //    sd.MaHD = txtMaHD.Text;
        //    sd.NgayLap = dtpNgayLap.Text;
        //    sd.MaNV = cmbMaNV.Text;
        //    sd.TenNV = txtTenNV.Text;
        //    sd.MaKH = cmbMaKH.Text;
        //    sd.TenKh = txtTenKH.Text;
        //    sd.SDT = txtSDT.Text;
        //    sd.Show();
        //    this.Hide();
        //}

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenu hd = new frmMenu();
            hd.Show();
            this.Hide();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                if (cmbMaSP.Text != "" && txtTenSP.Text != "")
                {

                    command.CommandText = "insert into CT_HoaDon values( '" + cmbMaHD.Text + "','" + cmbMaSP.Text + "', N'" + txtTenSP.Text + "',N'" + txtMauSac.Text + "','" + txtKichThuoc.Text + "','" + txtSoLuong.Text + "',N'" + txtDonGia.Text + "' ,N'" + txtChieuKhau.Text + "')";
                    int kq = (int)command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadata();
                    }
                    else
                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                    MessageBox.Show("Chưa nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            loadata();
        }

        

        private void frmCT_HoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            themMaSP(ref cmbMaSP, "select MaSp from SanPham");
            themMaHD(ref cmbMaHD, "select MaHD from HoaDon ");
            loadata();
            //txtMaHD.Text = truyenMaHD;
            //dtpNgayLap.Text = truyenNgayLap;
            //cmbMaNV.Text = truyenMaNV;
            //txtTenNV.Text = truyenTenNV;
            //cmbMaKH.Text = truyenMaKH;
            //txtTenKH.Text = truyenTenKh;
            //txtSDT.Text = truyenSDT;
        }

        //private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SqlConnection connection = new SqlConnection(str);
        //    connection.Open();
        //    string sql = "select * from NhanVien where MaNV= '" + cmbMaNV.Text + "'";
        //    SqlCommand command = new SqlCommand(sql, connection);
        //    command.ExecuteNonQuery();
        //    SqlDataReader dr;
        //    dr = command.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        txtTenNV.Text = dr["HoTenNV"].ToString(); ;
        //    }
        //}

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTin.CurrentRow.Index;
            cmbMaHD.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            cmbMaSP.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtTenSP.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            txtMauSac.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            txtKichThuoc.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvThongTin.Rows[i].Cells[6].Value.ToString();
            txtDonGia.Text = dgvThongTin.Rows[i].Cells[7].Value.ToString();
            txtChieuKhau.Text = dgvThongTin.Rows[i].Cells[8].Value.ToString();
        }
        private void themMaSP(ref ComboBox combobox, string query)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand conma = new SqlCommand(query, conn);
            SqlDataReader dataReader = conma.ExecuteReader();
            while (dataReader.Read())
            {
                combobox.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            conn.Close();
        }
        private void cmbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from SanPham where MaSp= '" + cmbMaSP.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtTenSP.Text = dr["TenSp"].ToString();
                txtMauSac.Text = dr["MauSac"].ToString();
                txtKichThuoc.Text = dr["KichThuoc"].ToString();
                txtSoLuong.Text = dr["SoLuong"].ToString();

            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = string.Format("update CT_HoaDon set MaHD='" + cmbMaHD.Text + "',MaSp='" + cmbMaSP.Text + "',TenSp=N'" + txtTenSP.Text + "',MauSac = N'" + txtMauSac.Text + "',KichThuoc = N'" + txtKichThuoc.Text + "',SoLuong = '" + txtSoLuong.Text + "',DonGia = '" + txtDonGia.Text + "',ChietKhau='" + txtChieuKhau.Text + "' where MaSp='" + cmbMaSP.Text + "'");
            SqlCommand command = new SqlCommand(sql, connection);
            int kq = (int)command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadata();
            }
            else
                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void Reset()
        {
            cmbMaHD.Text = "";
            cmbMaSP.Text = "";
            txtTenSP.Text = "";
            txtKichThuoc.Text = "";
            txtSoLuong.Text = "";
            txtMauSac.Text = "";
            txtChieuKhau.Text = "";
            txtDonGia.Text = "";

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "delete from CT_HoaDon where MaHD = '" + cmbMaHD.Text + "'";
            SqlCommand comm = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            int kq = (int)comm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadata();
            }
            else
                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Reset();
        }
        private void themMaHD(ref ComboBox combobox, string query)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand conma = new SqlCommand(query, conn);
            SqlDataReader dataReader = conma.ExecuteReader();
            while (dataReader.Read())
            {
                combobox.Items.Add(dataReader[0]);
            }
            dataReader.Close();
            conn.Close();
        }
        private void cmbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
