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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
                txtMatKhau.PasswordChar = (char)0;
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True;");
            conn.Open();
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            SqlCommand comma = new SqlCommand("select * from QLTaiKhoan where TenTK = '" + tk + "'and MatKhau = '" + mk + "'", conn);
            SqlDataReader dr = comma.ExecuteReader();
            if (dr.Read())
            {
                frmMenu f = new frmMenu();
                f.Show();
                this.Hide();
                txtTaiKhoan.Text = txtMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                conn.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
