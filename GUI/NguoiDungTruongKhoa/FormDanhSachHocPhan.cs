using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDanhSachHocPhan : Form
    {
        private CHocPhanBLL hocPhanBLL;
        public FormDanhSachHocPhan()
        {
            InitializeComponent();
            hocPhanBLL = new CHocPhanBLL();
        }

        private void HienThiDanhSachLopHocPhan(DataTable dataTable)
        {
            // Xóa tất cả các UserControl trong flPnlDanhSachLopHocPhan
            flPnlDanhSachLopHocPhan.Controls.Clear();

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var lopHocPhanItem = new UCLopHocPhan
                    {
                        UCMaHocPhan = row["MAHOCPHAN"].ToString(),
                        UCTenMonHoc = row["TENMONHOC"].ToString(),
                        UCGiaoVien = row["GIAOVIEN"].ToString(),
                        UCPhongHoc = row["PHONGHOC"].ToString(),
                        UCSoLuongSV = row["SOLUONGSINHVIEN"].ToString(),
                        UCSoLuongSVDK = row["SOLUONGDANGKY"].ToString()
                    };
                    flPnlDanhSachLopHocPhan.Controls.Add(lopHocPhanItem);
                }
            }
        }

        private void loadLopHocPHan()
        {
            if (checkBoxLopDangMo.Checked)
            {
                HienThiDanhSachLopHocPhan(hocPhanBLL.LayCacLopHocPhanDangMo());
            }
            else
            {
                HienThiDanhSachLopHocPhan(hocPhanBLL.LayTatCaLopHocPhan());
            }
        }
        private void FormDanhSachHocPhan_Load(object sender, EventArgs e)
        {
            loadLopHocPHan();
            if (NguoiDungHienTai.chucVu == "Giáo vụ" || NguoiDungHienTai.chucVu == "Trưởng bộ môn" || NguoiDungHienTai.chucVu == "Giáo viên")
            {
                btnThem.Hide();
            }
        }

        private void flPnlDanhSachLopHocPhan_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDanhSachLopHocPhan.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDanhSachLopHocPhan.ClientSize.Width;
                }
            }
        }

        private void checkBoxLopDangMo_CheckedChanged(object sender, EventArgs e)
        {
            loadLopHocPHan();
        }

        private void picBoxLamMoiForm_Click(object sender, EventArgs e)
        {
            loadLopHocPHan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form formThemHocPhan = new FormThongTinHocPhan();
            formThemHocPhan.Show();
        }
    }
}
