using BLL;
using ServiceStack;
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
    public partial class FormDangNhap : Form
    {
        private CDangNhapBLL dangNhapBLL;
        private CThongTinBLL thongTinBLL;

        public FormDangNhap()
        {
            InitializeComponent();
            dangNhapBLL = new CDangNhapBLL();
            thongTinBLL = new CThongTinBLL();
        }

        private void dangNhap(string taiKhoan, string matKhau)
        {
            var dtDangNhap = dangNhapBLL.DangNhap(taiKhoan, matKhau);

            if (dtDangNhap != null && dtDangNhap.Rows.Count > 0)
            {
                DataRow row = dtDangNhap.Rows[0];
                if (row["MANGUOIDUNG"].ToString() == "0")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng");
                }
                else
                {
                    NguoiDungHienTai.maNguoiDung = row["MANGUOIDUNG"].ToString();
                    NguoiDungHienTai.chucVu = row["CHUCVU"].ToString();

                    var dtThongTin = thongTinBLL.LayThongTinCaNhan(NguoiDungHienTai.maNguoiDung, NguoiDungHienTai.chucVu);
                    DataRow dr = dtThongTin.Rows[0];

                    NguoiDungHienTai.maSo = dr["MASO"].ToString();
                    NguoiDungHienTai.hoTen = dr["HOTEN"].ToString();
                    NguoiDungHienTai.ngaySinh = dr["NGAYSINH"].ToString();
                    NguoiDungHienTai.email = dr["EMAIL"].ToString();
                    NguoiDungHienTai.diaChi = dr["DIACHI"].ToString();

                    if (NguoiDungHienTai.chucVu == "Trưởng khoa" || NguoiDungHienTai.chucVu == "Giáo vụ")
                    {
                        Form formTruongKhoa = new FormTruongKhoa();
                        formTruongKhoa.ShowDialog();
                        this.Hide();
                    }
                    else if (NguoiDungHienTai.chucVu == "Trưởng bộ môn" || NguoiDungHienTai.chucVu == "Giáo viên")
                    {
                        Form formGiaoVien = new FormGiaoVien();
                        formGiaoVien.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        Form formSinhVien = new FormSinhVien();
                        formSinhVien.ShowDialog();
                        this.Hide();
                    }
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
        }
    }
}
