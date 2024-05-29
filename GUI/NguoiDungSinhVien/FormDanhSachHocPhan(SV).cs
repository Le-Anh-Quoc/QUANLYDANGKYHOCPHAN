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
    public partial class FormDanhSachHocPhan_SV_ : Form
    {
        CHocPhanBLL hocPhanBLL;
        public string maMonHoc
        {
            get => NguoiDungHienTai.maMonHocDangChon;
            set => NguoiDungHienTai.maMonHocDangChon = value;
        }
        //public string tenMonHoc
        public FormDanhSachHocPhan_SV_()
        {
            InitializeComponent();
            hocPhanBLL = new CHocPhanBLL();
        }

        private void FormDanhSachHocPhan_SV__Load(object sender, EventArgs e)
        {
            HienThiCacLopHocPhanTheoMaMon();
        }

        private void HienThiCacLopHocPhanTheoMaMon()
        {
            flPnlDanhSachLopHocPhanDangMo.Controls.Clear();

            var dataTable = hocPhanBLL.LayCacLopHocPhanDangMoTheoMaMon(maMonHoc);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var lopHocPhanItem = new UCLopHocPhan_SV_
                    {
                        UCMaHocPhan = row["MAHOCPHAN"].ToString(),
                        UCTenMonHoc = row["TENMONHOC"].ToString(),
                        UCGiaoVien = row["GIAOVIEN"].ToString(),
                        UCPhongHoc = row["PHONGHOC"].ToString(),
                        UCSoLuongSV = row["SOLUONGSINHVIEN"].ToString(),
                        UCSoLuongSVDK = row["SOLUONGDANGKY"].ToString()
                    };
                    flPnlDanhSachLopHocPhanDangMo.Controls.Add(lopHocPhanItem);
                }
            }
        }

        private void flPnlDanhSachLopHocPhanDangMo_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDanhSachLopHocPhanDangMo.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDanhSachLopHocPhanDangMo.ClientSize.Width;
                }
            }
        }
    }
}
