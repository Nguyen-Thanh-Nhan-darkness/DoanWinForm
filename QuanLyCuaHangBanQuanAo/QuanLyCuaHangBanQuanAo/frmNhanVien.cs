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
    public partial class frmNhanVien : Form
    {
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlConnection connection; //Ket noi sql
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string MaNV;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Text = "";
            cbChucVu.Text = "";
            cmbGioiTinh.Text = "";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Reset();
            loadata();
        }
        /*Load data*/
        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDSNV.DataSource = table;
            Reset();
        }
        /*Kiem tra ma nv khong trung*/
        public bool KTMaNV(string manv)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select MaNV from NhanVien where MaNV='" + manv + "'";
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
        /*Hien thong tin len TextBox khi an vao DataGridView*/
        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDSNV.CurrentRow.Index;
            txtMaNV.Text = dgvDSNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvDSNV.Rows[i].Cells[1].Value.ToString();
            cmbGioiTinh.Text = dgvDSNV.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvDSNV.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvDSNV.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dgvDSNV.Rows[i].Cells[5].Value.ToString();
            cbChucVu.Text = dgvDSNV.Rows[i].Cells[6].Value.ToString();
        }
        /*Button quay lai*/
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu h = new frmMenu();
            h.Show();
            this.Hide();
        }
        /*Button thoat*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*Button them*/
        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                if (txtMaNV.Text != "")
                {
                    if (KTMaNV(txtMaNV.Text) == true)
                        MessageBox.Show("Mã đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        command.CommandText = "insert into NhanVien values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cmbGioiTinh.Text + "','" + txtDiaChi.Text + "','" + dtpNgaySinh.Text + "','" + txtSDT.Text + "',N'" + cbChucVu.Text + "')";
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
        /*Button xoa*/
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MaNV = txtMaNV.Text;
            command = connection.CreateCommand();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "delete from NhanVien where MaNV = '" + txtMaNV.Text + "'";
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
        /*Button sua*/
        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaKNV = txtMaNV.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "update NhanVien set MaNV='" + txtMaNV.Text + "',HoTenNV=N'" + txtTenNV.Text + "',GioiTinh=N'" + cmbGioiTinh.Text + "',DiaChi = '" + txtDiaChi.Text + "',NgaySinh = '" + dtpNgaySinh.Text + "',Phone = '" + txtSDT.Text + "',ChucVu=N'" + cbChucVu.Text + "'where MaNV='" + txtMaNV.Text + "'";
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
        /*Button reset*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            dtpNgaySinh.Text = "";
            cbChucVu.Text = "";
            cmbGioiTinh.Text = "";
            loadata();
        }
    }
}
