using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanQuanAo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham a = new frmSanPham();
            a.Show();
            this.Hide();
        }
        private void btnHoDon_Click(object sender, EventArgs e)
        {
            frmHoaDon b = new frmHoaDon();
            b.Show();
            this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien c = new frmNhanVien();
            c.Show();
            this.Hide();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang d = new frmKhachHang();
            d.Show();
            this.Hide();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap g = new frmNhaCungCap();
            g.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham a = new frmSanPham();
            a.Show();
            this.Hide();
        }

        private void lblHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon b = new frmHoaDon();
            b.Show();
            this.Hide();
        }

        private void lblNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien c = new frmNhanVien();
            c.Show();
            this.Hide();
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang d = new frmKhachHang();
            d.Show();
            this.Hide();
        }

        private void lblNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap g = new frmNhaCungCap();
            g.Show();
            this.Hide();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang h = new frmNhapHang();
            h.Show();
            this.Hide();
        }

        private void lblNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang h = new frmNhapHang();
            h.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCT_HoaDon h = new frmCT_HoaDon();
            h.Show();
            this.Hide();
        }
    }
}
