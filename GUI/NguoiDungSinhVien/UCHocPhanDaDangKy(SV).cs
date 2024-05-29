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
    public partial class UCHocPhanDaDangKy_SV_ : UserControl
    {
        CSinhVienBLL sinhVienBLL;
        public string UCMaHocPhan
        {
            get => lblMaHocPhan.Text;
            set => lblMaHocPhan.Text = value;
        }

        public string UCTenMonHoc
        {
            get => lblTenMonHoc.Text;
            set => lblTenMonHoc.Text = value;
        }

        public string UCGiaoVien
        {
            get => lblTenGiaoVien.Text;
            set => lblTenGiaoVien.Text = value;
        }
        public UCHocPhanDaDangKy_SV_()
        {
            InitializeComponent();
            sinhVienBLL = new CSinhVienBLL();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                sinhVienBLL.HuyDangKyHocPhan(NguoiDungHienTai.maSo, UCMaHocPhan);
                MessageBox.Show("Hủy đăng ký học phần thành công");
            } catch (Exception ex)
            {
                throw (ex);
            }
            
        }
    }
}
