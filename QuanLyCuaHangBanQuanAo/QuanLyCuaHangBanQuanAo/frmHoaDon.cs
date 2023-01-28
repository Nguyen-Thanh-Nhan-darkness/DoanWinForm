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

    public partial class frmHoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        void loadata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHoaDon.DataSource = table;
            Reset();

        }
        void Reset()
        {
            txtMaHD.Text = "";
            dtpNgayLap.Text = "1/1/2000";
            cmbMaNV.Text = "";
            txtTenNV.Text = "";
            cmbMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            themMaNV(ref cmbMaNV, "select MaNV from NhanVien");
            themMaKH(ref cmbMaKH, "select MaKH from KhachHang");
            connection = new SqlConnection(str);
            Reset();
            loadata();
        }
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
            string sql = "select MaHD from HoaDon where MaHD='" + mahd + "'";
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
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHoaDon.CurrentRow.Index;
            txtMaHD.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
            cmbMaNV.Text = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
            cmbMaKH.Text = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
            txtTenKH.Text = dgvHoaDon.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text = dgvHoaDon.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            try
            {
                if (txtMaHD.Text != "")
                {
                    if (KTMaHD(txtMaHD.Text) == true)
                        MessageBox.Show("Mã đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {

                        try
                        {
                            connection.Open();
                            string sql = string.Format("insert into HoaDon values('" + txtMaHD.Text + "','" + dtpNgayLap.Value.ToShortDateString() + "','" + cmbMaNV.Text + "','" + txtTenNV.Text + "','" + cmbMaKH.Text + "','" + txtTenKH.Text + "','" + txtSDT.Text + "')");
                            SqlCommand command = new SqlCommand(sql, connection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadata();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("Chưa nhập MHD đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql1 = "delete from CT_HoaDon where MaHD = '" + txtMaHD.Text + "'";
            SqlCommand command = new SqlCommand(sql1, connection);
            string sql = "delete from HoaDon where MaHD = '" + txtMaHD.Text + "'";
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = string.Format("update HoaDon set MaHD='" + txtMaHD.Text + "',NgayLapHD='" + dtpNgayLap.Text + "',MaNV='" + cmbMaNV.Text + "',TenNV = N'" + txtTenNV.Text + "',MaKH = '" + cmbMaKH.Text + "',TenKh = N'" + txtTenKH.Text + "',SoDienThoai = '" + txtSDT.Text + "' where MaHD='" + txtMaHD.Text + "'");
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

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            frmXemCT_HoaDon hd = new frmXemCT_HoaDon();
            hd.MaHD = txtMaHD.Text;
            hd.NgayLap = dtpNgayLap.Text;
            hd.MaNV = cmbMaNV.Text;
            hd.TenNV = txtTenNV.Text;
            hd.MaKH = cmbMaKH.Text;
            hd.TenKh = txtTenKH.Text;
            hd.SDT = txtSDT.Text;
            hd.Show();
            this.Hide();
        }

        private void cmbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from NhanVien where MaNV= '" + cmbMaNV.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                string nhacc = (string)dr["HoTenNV"].ToString();
                txtTenNV.Text = nhacc;
            }
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from KhachHang where MaKH= '" + cmbMaKH.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                string tenkh = (string)dr["TenKh"].ToString();
                txtTenKH.Text = tenkh;
                string sdt = (string)dr["Phone"].ToString();
                txtSDT.Text = sdt;
            }
        }
    }
}
