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
    public partial class UCLopHocPhan_SV_ : UserControl
    {
        CDangKyHocBLL dangKyHocBLL;
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

        public string UCPhongHoc
        {
            get => lblPhongHoc.Text;
            set => lblPhongHoc.Text = value;
        }

        public string UCSoLuongSV
        {
            get => lblSoLuongSV.Text;
            set => lblSoLuongSV.Text = value;
        }
        public string UCSoLuongSVDK
        {
            get => lblSoLuongSVDK.Text;
            set => lblSoLuongSVDK.Text = value;
        }
        public UCLopHocPhan_SV_()
        {
            InitializeComponent();
            dangKyHocBLL = new CDangKyHocBLL();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                dangKyHocBLL.SinhVienDangKyHoc(NguoiDungHienTai.maSo, UCMaHocPhan);
                MessageBox.Show("Đăng ký thành công");
            } catch
            {
                MessageBox.Show("Bạn đã đăng ký học phần này rồi");
            }
        }

        private void UCLopHocPhan_SV__Load(object sender, EventArgs e)
        {
            if (int.Parse(UCSoLuongSV) == int.Parse(UCSoLuongSVDK))
            {
                btnDangKy.Enabled = false;
            }
        }
    }
}
