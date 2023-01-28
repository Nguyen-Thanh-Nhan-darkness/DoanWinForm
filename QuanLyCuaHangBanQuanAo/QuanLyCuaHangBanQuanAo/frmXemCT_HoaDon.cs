using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace QuanLyCuaHangBanQuanAo
{
    public partial class frmXemCT_HoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-AGGV3MSM\SQLEXPRESS;Initial Catalog=QuanLyThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmXemCT_HoaDon()
        {
            InitializeComponent();
        }
        public string MaHD;
        public string NgayLap;
        public string MaNV;
        public string TenNV;
        public string MaKH;
        public string TenKh;
        public string SDT;
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


        private void btnTongTien_Click(object sender, EventArgs e)
        {
            txtThanhTien.Text = "";
            float thanhtien = 0;

            for (int j = 0; j < dgvThongTin.RowCount - 1; j++)
            {
                thanhtien += float.Parse(dgvThongTin.Rows[j].Cells["ThanhTien"].Value.ToString());
            }

            txtThanhTien.Text = thanhtien.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            DataTable dt = new DataTable();
            DataColumn col0 = new DataColumn("Số thứ tự");
            DataColumn col1 = new DataColumn("Mã sản phẩm");
            DataColumn col2 = new DataColumn("Tên sản phẩm");
            DataColumn col3 = new DataColumn("Màu sắc");
            DataColumn col4 = new DataColumn("Kích thước");
            DataColumn col5 = new DataColumn("Số lượng");
            DataColumn col6 = new DataColumn("Đơn giá");
            DataColumn col7 = new DataColumn("Chiếu khấu %");
            DataColumn col8 = new DataColumn("Thành tiền");


            dt.Columns.Add(col0);
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);
            dt.Columns.Add(col7);
            dt.Columns.Add(col8);

            foreach (DataGridViewRow dtvRow in dgvThongTin.Rows)
            {
                DataRow dtrow = dt.NewRow();

                dtrow[0] = dtvRow.Cells[1].Value;
                dtrow[1] = dtvRow.Cells[2].Value;
                dtrow[2] = dtvRow.Cells[3].Value;
                dtrow[3] = dtvRow.Cells[4].Value;
                dtrow[4] = dtvRow.Cells[5].Value;
                dtrow[5] = dtvRow.Cells[6].Value;
               dtrow[6] = dtvRow.Cells[7].Value;
                dtrow[7] = dtvRow.Cells[8].Value;
                dtrow[8] = dtvRow.Cells["ThanhTien"].Value;

                dt.Rows.Add(dtrow);
            }
            // Tạo các đối tượng Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbooks oBooks;
            COMExcel.Sheets oSheets;
            COMExcel.Workbook oBook;
            COMExcel.Worksheet oSheet;
            COMExcel.Range exRange;

            // Tạo mới một Excel WorkBook
            exApp.Visible = true;
            exApp.DisplayAlerts = false;
            exApp.Application.SheetsInNewWorkbook = 1;
            oBooks = exApp.Workbooks;
            oBook = (COMExcel.Workbook)(exApp.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (COMExcel.Worksheet)oSheets.get_Item(1);

            // Định dạng chung
            exRange = oSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:A1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:A1"].Value = "Shop ABC";
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A2:A2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:A2"].Value = "TP.HCM";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A3:A3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:A3"].Value = "Điện thoại:(09)3833833";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["C2:F2"].Font.Size = 16;
            exRange.Range["C2:F2"].Font.Bold = true;
            exRange.Range["C2:F2"].Font.ColorIndex = 3;

            // Tạo phần header
            COMExcel.Range head = oSheet.get_Range("C2", "G2");
            head.MergeCells = true;
            head.Value2 = "CHI TIẾT HÓA ĐƠN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //Lấy thông tin hóa đơn

            exRange.Range["B6:B8"].Font.Bold= true;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:C6"].Value = txtMaHD.Text;
            exRange.Range["C6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:C7"].Value = txtTenKH.Text;
            exRange.Range["C7:C7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["B8:B8"].Value = "Điện thoại:";
            exRange.Range["C8:C8"].Value = txtSDT.Text;
            exRange.Range["C8:C8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;

            // Tạo tiêu đề cột 
            COMExcel.Range cl1 = oSheet.get_Range("A11", "A11");
            cl1.Value2 = "Số thứ tự";
            cl1.ColumnWidth = 12.00;
            COMExcel.Range cl2 = oSheet.get_Range("B11", "B11");
            cl2.Value2 = "Mã sản phẩm";
            cl2.ColumnWidth = 12.00;
            COMExcel.Range cl3 = oSheet.get_Range("C11", "C11");
            cl3.Value2 = "Tên sản phẩm";
            cl3.ColumnWidth = 30.33;
            COMExcel.Range cl4 = oSheet.get_Range("D11", "D11");
            cl4.Value2 = "Màu sắc";
            cl4.ColumnWidth = 8.00;
            COMExcel.Range cl5 = oSheet.get_Range("E11", "E11");
            cl5.Value2 = "Kích thước";
            cl5.ColumnWidth = 10.00;
            COMExcel.Range cl9 = oSheet.get_Range("F11", "F11");
            cl9.Value2 = "Số lượng";
            cl9.ColumnWidth = 9.00;
            COMExcel.Range cl10 = oSheet.get_Range("G11", "G11");
            cl10.Value2 = "Đơn giá";
            cl10.ColumnWidth = 7.00;
            COMExcel.Range cl6 = oSheet.get_Range("H11", "H11");
            cl6.Value2 = "Chiết khấu %";
            cl6.ColumnWidth = 12.33;
            COMExcel.Range cl7 = oSheet.get_Range("I11", "I11");
            cl7.Value2 = "Thành tiền";
            cl7.ColumnWidth = 9.56;
            COMExcel.Range rowHead = oSheet.get_Range("A11", "I11");
            rowHead.Font.Bold = true;

            // Kẻ viền
            rowHead.Borders.LineStyle = COMExcel.Constants.xlSolid;

            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // Vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            // Ô bắt đầu điền dữ liệu
            COMExcel.Range c1 = (COMExcel.Range)oSheet.Cells[12, 1];

            // Ô kết thúc điền dữ liệu
            COMExcel.Range c2 = (COMExcel.Range)oSheet.Cells[12 + dt.Rows.Count - 1, 9];

            // Lấy về vùng điền dữ liệu
            COMExcel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            //// Kẻ viền
            range.Borders.LineStyle = COMExcel.Constants.xlSolid;

            // Căn giữa cột Số thứ tự
            COMExcel.Range c3 = (COMExcel.Range)oSheet.Cells[12 + dt.Rows.Count - 1, 1];
            COMExcel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            // Căn giữa cột mã sản phẩm
            COMExcel.Range c5 = (COMExcel.Range)oSheet.Cells[12 + dt.Rows.Count - 1, 2];
            COMExcel.Range c6 = oSheet.get_Range((COMExcel.Range)oSheet.Cells[12, 2], c5);
            oSheet.get_Range(c5, c6).HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            //Tổng tiền
            exRange.Range["H18:H18"].Font.Bold = true;
            exRange.Range["H18:H18"].Value = "Tổng tiền:";
            exRange.Range["I18:I18"].Value = txtThanhTien.Text;
            exRange.Range["I18:I18"].Font.Bold = true;

            //Footer
            exRange.Range["G21:I21"].MergeCells = true;
            exRange.Range["G21:I21"].Value = "TP.HCM, Ngày___tháng___năm___";
            exRange.Range["G21:I21"].Font.Italic = true;
            exRange.Range["G21:I21"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["G22:I22"].Value = "Nhân viên bán hàng";
            exRange.Range["G22:I22"].MergeCells = true;
            exRange.Range["G22:I22"].Font.Italic = true;
            exRange.Range["G22:I22"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["G26:I26"].Value = txtTenNV.Text;
            exRange.Range["G26:I26"].MergeCells = true;
            exRange.Range["G26:I26"].Font.Italic = true;
            exRange.Range["G26:I26"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
        }

        private void frmXemCT_HoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadata();
            txtMaHD.Text = MaHD;
            dtpNgayLap.Text = NgayLap;
            txtMaNV.Text = MaNV;
            txtTenNV.Text = TenNV;
            txtMaKH.Text = MaKH;
            txtTenKH.Text = TenKh;
            txtSDT.Text = SDT;
        }

        private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTin.CurrentRow.Index;
            txtMaHD.Text = dgvThongTin.Rows[i].Cells[1].Value.ToString();
            txtMaSP.Text = dgvThongTin.Rows[i].Cells[2].Value.ToString();
            txtTenSP.Text = dgvThongTin.Rows[i].Cells[3].Value.ToString();
            txtMauSac.Text = dgvThongTin.Rows[i].Cells[4].Value.ToString();
            txtKichThuoc.Text = dgvThongTin.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvThongTin.Rows[i].Cells[6].Value.ToString();
            txtDonGia.Text = dgvThongTin.Rows[i].Cells[7].Value.ToString();
            txtChieuKhau.Text = dgvThongTin.Rows[i].Cells[8].Value.ToString();
      

        }
    }
}
