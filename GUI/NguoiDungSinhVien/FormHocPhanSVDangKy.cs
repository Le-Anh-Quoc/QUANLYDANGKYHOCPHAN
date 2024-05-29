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
    public partial class FormHocPhanSVDangKy : Form
    {
        CHocPhanBLL hocPhanBLL;
        public FormHocPhanSVDangKy()
        {
            InitializeComponent();
            hocPhanBLL = new CHocPhanBLL();
        }

        private void FormHocPhanSVDangKy_Load(object sender, EventArgs e)
        {
            LayCacHocPhanSinhVienDaDangKy(NguoiDungHienTai.maSo);
        }
        private void LayCacHocPhanSinhVienDaDangKy(string maSinhVien)
        {
            if (flPnlHocPhanSVDangKy.Controls.Count > 0)
            {
                flPnlHocPhanSVDangKy.Controls.Clear();
            }

            var dataTable = hocPhanBLL.LayCacHocPhanSinhVienDaDangKy(maSinhVien);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var hocPhanItems = new UCHocPhanDaDangKy_SV_
                    {
                        UCMaHocPhan = row["MAHOCPHAN"].ToString(),
                        UCTenMonHoc = row["TENMONHOC"].ToString(),
                        UCGiaoVien = row["GIAOVIEN"].ToString()
                    };
                    flPnlHocPhanSVDangKy.Controls.Add(hocPhanItems);
                }
            }
        }

        private void flPnlHocPhanSVDangKy_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlHocPhanSVDangKy.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlHocPhanSVDangKy.ClientSize.Width;
                }
            }
        }
    }
}
