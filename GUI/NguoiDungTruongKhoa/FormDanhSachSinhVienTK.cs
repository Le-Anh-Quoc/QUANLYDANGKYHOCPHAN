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
    public partial class FormDanhSachSinhVienTK : Form
    {
        CSinhVienBLL sinhVienBLL;
        public FormDanhSachSinhVienTK()
        {
            InitializeComponent();
            sinhVienBLL = new CSinhVienBLL();
        }
        private void LayTatCaSinhVien()
        {
            flPnlDanhSachSV.Controls.Clear();

            var dataTable = sinhVienBLL.LayTatCaSinhVien();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var sinhVienItem = new UCSinhVienTK
                    {
                        UCMaSV = row["MASINHVIEN"].ToString(),
                        UCHoTenSV = row["HOTEN"].ToString(),
                        UCNgaySinh = row["NGAYSINH"].ToString(),
                        UCEmail = row["EMAIL"].ToString(),
                        UCDiaChi = row["DIACHI"].ToString()
                    };
                    flPnlDanhSachSV.Controls.Add(sinhVienItem);
                }
            }
        }
        private void FormDanhSachSinhVienTK_Load(object sender, EventArgs e)
        {
            LayTatCaSinhVien();
        }
    }
}
