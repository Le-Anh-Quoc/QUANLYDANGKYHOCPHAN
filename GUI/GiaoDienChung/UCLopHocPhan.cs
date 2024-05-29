using BLL;
using Org.BouncyCastle.Math.Field;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCLopHocPhan : UserControl
    {
        CGiaoVienBLL giaoVienBLL;
        bool isHover = false;
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
        public UCLopHocPhan()
        {
            InitializeComponent();
            giaoVienBLL = new CGiaoVienBLL();
        }
        private void moveMouseEnter()
        {
            if (isHover == true) { return; }

            BackColor = Color.WhiteSmoke;
            this.Cursor = Cursors.Hand;
            isHover = true;
        }
        private void moveMouseLeave()
        {
            if (isHover == false) { return; }

            BackColor = Color.White;
            isHover = false;
        }

        private void UCLopHocPhan_MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCLopHocPhan_MouseLeave(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void UCLopHocPhan_Click(object sender, EventArgs e)
        {
            string ketQuaKiemTra;
            var dataTable = giaoVienBLL.KiemTraGiaoVienThuocLop(NguoiDungHienTai.maSo, UCMaHocPhan);

            DataRow row = dataTable.Rows[0];
            ketQuaKiemTra = row["KETQUA"].ToString();

            if (ketQuaKiemTra == "1")
            {
                var formDanhSachSinhVien = new FormDanhSachSinhVien
                {
                    maLHP = UCMaHocPhan,
                    tenLHP = UCTenMonHoc,
                };
                NguoiDungHienTai.maHocPhanDangChon = UCMaHocPhan;
                formDanhSachSinhVien.ShowDialog();
            } else
            {
                MessageBox.Show("Bạn không phải là giáo viên lớp này nên không thể xem danh sách lớp");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ketQuaKiemTra;
            var dataTable = giaoVienBLL.KiemTraTruongBoMonMonHoc(NguoiDungHienTai.maSo, UCMaHocPhan);

            DataRow row = dataTable.Rows[0];
            ketQuaKiemTra = row["KETQUA"].ToString();

            if (ketQuaKiemTra == "1")
            {
                var formThongTinHocPhan = new FormThongTinHocPhan
                {
                    maLHP = UCMaHocPhan,
                    sua = true
                };
                formThongTinHocPhan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không phải là trưởng bộ môn của môn học này");
            }
        }

        private void UCLopHocPhan_Load(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.chucVu == "Giáo viên")
            {
                btnSua.Hide();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
