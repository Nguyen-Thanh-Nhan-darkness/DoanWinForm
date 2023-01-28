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
    public partial class frmKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Khachhang";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDSKH.DataSource = table;
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

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDSKH.CurrentRow.Index;
            txtMaKH.Text = dgvDSKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvDSKH.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDSKH.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvDSKH.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvDSKH.Rows[i].Cells[4].Value.ToString();
        }
        private void Reset()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                if (txtMaKH.Text != "" && txtTenKH.Text != "")
                {
                    {
                        command.CommandText = "insert into Khachhang values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtEmail.Text + "')";
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
            string MaKH = txtMaKH.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "delete from HoaDon where MaKH = '" + txtMaKH.Text + "'";
                command.CommandText = "delete from Khachhang where MaKH = '" + txtMaKH.Text + "'";
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
            string MaKH = txtMaKH.Text;
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "update Khachhang set TenKH=N'" + txtTenKH.Text + "',DiaChi='" + txtDiaChi.Text + "',Phone = '" + txtSDT.Text + "',DCMail = '" + txtEmail.Text + "'where MaKH='" + txtMaKH.Text + "'";
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
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
    }
}
