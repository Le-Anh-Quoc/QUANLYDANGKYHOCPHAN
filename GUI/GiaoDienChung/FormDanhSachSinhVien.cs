using BLL;
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
    public partial class FormDanhSachSinhVien : Form
    {
        private CSinhVienBLL sinhVienBLL;

        public string maLHP
        {
            get => lblMaLop.Text;
            set => lblMaLop.Text = value;
        }
        public string tenLHP
        {
            get => lblTenLop.Text;
            set => lblTenLop.Text = value;
        }

        public FormDanhSachSinhVien()
        {
            InitializeComponent();
            sinhVienBLL = new CSinhVienBLL();
        }

        private void FormDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            HienThiSinhVienTheoLopHocPhan(maLHP);
        }

        private void HienThiSinhVienTheoLopHocPhan(string maLHP)
        {
            if (flPnlDanhSachSinhVien.Controls.Count > 0)
            {
                flPnlDanhSachSinhVien.Controls.Clear();
            }

            var dataTable = sinhVienBLL.LaySinhVienLopHocPhan(maLHP);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var sinhVienItem = new UCSinhVien
                    {
                        UCMaSV = row["MASINHVIEN"].ToString(),
                        UCHoTenSV = row["HOTEN"].ToString(),
                        UCNgaySinh = row["NGAYSINH"].ToString(),
                        UCEmail = row["EMAIL"].ToString(),
                        UCDiem = row["DIEM"].ToString()
                    };
                    //monHocItem.BackColor = Color.Green;
                    flPnlDanhSachSinhVien.Controls.Add(sinhVienItem);
                }
            }
        }

        private void flPnlDanhSachSinhVien_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDanhSachSinhVien.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDanhSachSinhVien.ClientSize.Width;
                }
            }
        }
    }
}
