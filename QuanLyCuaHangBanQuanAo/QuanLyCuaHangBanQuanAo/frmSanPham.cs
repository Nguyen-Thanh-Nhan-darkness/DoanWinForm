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
    public partial class frmSanPham : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaSP;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu h = new frmMenu();
            h.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            //themMaNCC(ref cmbMaNCC, "select MaNCC from NhaCungCap");
            Reset();
            loadata();
        }
        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SanPham";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTin.DataSource = table;
            Reset();

        }
        private void themMaNCC(ref ComboBox combobox, string query)
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
        private void Reset()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbDVT.Text = "";
            txtGiaBan.Text = "";
            txtLoaiSP.Text = "";
            txtSoLuong.Text = "";
            txtMauSac.Text = "";
            txtKichThuoc.Text = "";
            txtMoTa.Text = "";
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaSP.Text = dgvThongTin.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            cbDVT.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            txtLoaiSP.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
            txtMauSac.Text = dgvThongTin.Rows[i].Cells[6].Value.ToString();
            txtKichThuoc.Text = dgvThongTin.Rows[i].Cells[7].Value.ToString();
            txtMoTa.Text = dgvThongTin.Rows[i].Cells[8].Value.ToString();
        }
        public bool KTMaSp(string masp)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select MaSp from SanPham where MaSp='" + masp + "'";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "")
                {
                    if (KTMaSp(txtMaSP.Text) == true)
                        MessageBox.Show("Mã đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        command.CommandText = "insert into SanPham values('" + txtMaSP.Text + "', N'" + txtTenSP.Text + "','" + cbDVT.Text + "','" + txtGiaBan.Text + "','" + txtSoLuong.Text + "',N'" + txtLoaiSP.Text + "',N'" + txtMauSac.Text + "','" + txtKichThuoc.Text + "',N'" + txtMoTa.Text + "')";
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadata();
                        }
                        else
                            MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MaSP = txtMaSP.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "delete from CT_HoaDon where MaSp = '" + txtMaSP.Text + "'";
                command.ExecuteNonQuery();
                command = connection.CreateCommand();
                command.CommandText = "delete from SanPham where MaSp = '" + txtMaSP.Text + "'";
                int kq = (int)command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadata();
                }
                else
                    MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MaSP = txtMaSP.Text;
                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                string sql = string.Format("update SanPham set MaSp='" + txtMaSP.Text + "',TenSp=N'" + txtTenSP.Text + "',DonViTinh='" + cbDVT.Text + "',GiaBan = '" + txtGiaBan.Text + "',SoLuong = '" + txtSoLuong.Text + "',LoaiSanPham = N'" + txtLoaiSP.Text + "', MauSac = '" + txtMauSac.Text + "', KichThuoc = '" + txtKichThuoc.Text + "', MoTa =N'" + txtMoTa.Text + "' where MaSp='" + txtMaSP.Text + "'");
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cbDVT.Text = "";
            //txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtLoaiSP.Text = "";
            txtSoLuong.Text = "";
            //cmbMaNCC.Text = "";
            txtKichThuoc.Text = "";
            txtMoTa.Text = "";
            loadata();
        }
    }
}
