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
    public partial class frmNhapHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void cmbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from NhaCungCap where ManCC= '" + cmbMaNCC.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                string nhacc = (string)dr["TenNCC"].ToString();
                txtTenNCC.Text = nhacc;
            }
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhapHang";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNhapHang.DataSource = table;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            themMaNH(ref cmbMaNCC, "select MaNCC from NhaCungCap");
            loaddata();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            txtMaNhap.Text = "";
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoaiSP.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            cmbMaNCC.Text = "";
            txtTenNCC.Text = "";
        }
        private void themMaNH(ref ComboBox combobox, string query)
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
        public bool KTMaNH(string manh)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select MaNH from NhapHang where MaNH='" + manh + "'";
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
                if (txtMaNhap.Text != "" && txtMaSP.Text != "")
                {
                    {
                        command.CommandText = "insert into NhapHang values('" + txtMaNhap.Text + "',N'" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + txtLoaiSP.Text + "','" + txtSoLuong.Text + "','" + txtGiaNhap.Text + "','" + cmbMaNCC.Text + "','" + txtTenNCC.Text + "')";
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddata();
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNH = txtMaNhap.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "delete from SanPham  where MaSP = '" + txtMaSP.Text + "'";
                command.CommandText = "delete from NhaCungCap  where MaNCC = '" + cmbMaNCC.Text + "'";
                command.CommandText = "delete from NhapHang where MaNH = '" + txtMaNhap.Text + "'";
                int kq = (int)command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xoá thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
                }
                else
                    MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)

            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaNH = txtMaNhap.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "update NhapHang set MaSP=N'" + txtMaSP.Text + "',TenSP='" + txtTenSP.Text + "',LoaiSanPham = '" + txtLoaiSP.Text + "',SoLuong = '" + txtSoLuong.Text + "',GiaNhap = '" + txtGiaNhap.Text + "',MaNCC = '" + cmbMaNCC.Text + "',TenNCC = '" + txtTenNCC.Text + "'where MaNH='" + txtMaNhap.Text + "'";
                int kq = (int)command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();
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
            Reset();
        }

        private void dgvNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhapHang.CurrentRow.Index;
            txtMaNhap.Text = dgvNhapHang.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dgvNhapHang.Rows[i].Cells[1].Value.ToString();
            txtTenSP.Text = dgvNhapHang.Rows[i].Cells[2].Value.ToString();
            txtLoaiSP.Text = dgvNhapHang.Rows[i].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvNhapHang.Rows[i].Cells[4].Value.ToString();
            txtGiaNhap.Text = dgvNhapHang.Rows[i].Cells[5].Value.ToString();
            cmbMaNCC.Text = dgvNhapHang.Rows[i].Cells[6].Value.ToString();
            txtTenNCC.Text = dgvNhapHang.Rows[i].Cells[7].Value.ToString();
        }
    }
}
