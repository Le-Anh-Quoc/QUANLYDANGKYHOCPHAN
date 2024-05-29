using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDanhSachMonHoc : Form
    {
        private CMonHocBLL monHocBLL;
        public FormDanhSachMonHoc()
        {
            InitializeComponent();
            monHocBLL = new CMonHocBLL();
        }

        private void FormDanhSachMonHoc_Load(object sender, EventArgs e)
        {
            HienThiTatCaMonHoc();
            if (NguoiDungHienTai.chucVu == "Giáo vụ" || NguoiDungHienTai.chucVu == "Trưởng bộ môn" || NguoiDungHienTai.chucVu == "Giáo viên")
            {
                btnThem.Hide();
            }
        }

        private void HienThiTatCaMonHoc()
        {
            if (flPnlDanhSachMonHoc.Controls.Count > 0)
            {
                flPnlDanhSachMonHoc.Controls.Clear();
            }

            List<MonHoc> danhSachMonHoc = monHocBLL.LayTatCaMonHoc();

            foreach (MonHoc monHoc in danhSachMonHoc)
            {
                UCMonHoc ucMonHoc = new UCMonHoc();

                ucMonHoc.UCMaMon = monHoc.maMonHoc;
                ucMonHoc.UCTenMon = monHoc.tenMonHoc;
                ucMonHoc.UCTruongBoMon = monHoc.truongBoMon;
                ucMonHoc.UCThongTinMonHoc = monHoc.thongTinMonHoc;
                ucMonHoc.UCKichHoatMon = monHoc.kichHoat;

                flPnlDanhSachMonHoc.Controls.Add(ucMonHoc);
            }

        }

        private void flPnlDanhSachMonHoc_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDanhSachMonHoc.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDanhSachMonHoc.ClientSize.Width;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form formThemMonHoc = new FormThemMonHoc 
            { 
                them = true,
            };
            formThemMonHoc.ShowDialog();
        }
    }
}
