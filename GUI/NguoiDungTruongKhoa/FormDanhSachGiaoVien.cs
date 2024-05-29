using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDanhSachGiaoVien : Form
    {
        CGiaoVienBLL giaoVienBLL;
        public FormDanhSachGiaoVien()
        {
            InitializeComponent();
            giaoVienBLL = new CGiaoVienBLL();
        }

        private void LayTatCaGiaoVien()
        {
            flPnlDanhSachGiaoVien.Controls.Clear();

            List<GiaoVien> danhSachGiaoVien = giaoVienBLL.LayTatCaGiaoVien();
            foreach (GiaoVien giaoVien in  danhSachGiaoVien)
            {
                UCGiaoVien ucGiaoVien = new UCGiaoVien();

                ucGiaoVien.UCMaGV = giaoVien.maGiaoVien;
                ucGiaoVien.UCHoTenGV = giaoVien.hoTen;
                ucGiaoVien.UCNgaySinh = giaoVien.ngaySinh;
                ucGiaoVien.UCEmail = giaoVien.email;

                flPnlDanhSachGiaoVien.Controls.Add(ucGiaoVien);
            }
        }

        private void FormDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            LayTatCaGiaoVien();
        }

        private void flPnlDanhSachGiaoVien_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDanhSachGiaoVien.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDanhSachGiaoVien.ClientSize.Width;
                }
            }
        }
    }
}
