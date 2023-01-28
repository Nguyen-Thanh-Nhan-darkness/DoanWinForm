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
    public partial class frmNhaCungCap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string Mancc;
        public frmNhaCungCap()
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

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadata();
        }
        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhaCungCap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNCC.DataSource = table;
        }
        public bool KTMaNCC(string mancc)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select MaNCC from NhaCungCap where MaNCC='" + mancc + "'";
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

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtLoaiHang.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                if (txtMaNCC.Text != "" && txtTenNCC.Text != "")
                {
                    if (KTMaNCC(txtMaNCC.Text) == true)
                        MessageBox.Show("Mã đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        command.CommandText = "insert into NhaCungCap values('" + txtMaNCC.Text + "','" + txtTenNCC.Text + "',N'" + txtLoaiHang.Text + "','" + txtGiaNhap.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "')";
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
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Mancc = txtMaNCC.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "delete from NhaCungCap where MaNCC =" + txtMaNCC.Text + "";
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
                Mancc = txtMaNCC.Text;

                SqlConnection connection = new SqlConnection(str);
                connection.Open();
                string sql = string.Format("update NhaCungCap set MaNCC='" + txtMaNCC.Text + "',TenNCC='" + txtTenNCC.Text + "',LoaiHang=N'" + txtLoaiHang.Text + "',GiaNhap = '" + txtGiaNhap.Text + "',Phone = '" + txtSDT.Text + "',DCMail = '" + txtEmail.Text + "' where MaNCC=" + txtMaNCC.Text + "");
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
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtGiaNhap.Text = "";
            txtLoaiHang.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }
    }
}
