using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTruongKhoa : Form
    {
        CHocKyBLL hocKyBLL;
        public FormTruongKhoa()
        {
            InitializeComponent();
            hocKyBLL = new CHocKyBLL();
        }

        private void FormTruongKhoa_Load(object sender, EventArgs e)
        {
            btnThongTin.Text = NguoiDungHienTai.chucVu;
            lblHocKy.Text = hocKyBLL.LayHocKyDangKichHoat();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Form formThongTinCaNhan = new FormThongTinCaNhan();
            formThongTinCaNhan.ShowDialog();
        }

        private void btnMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMain.Controls.Add(XuLyGiaoDien.moFormCon(new FormDanhSachMonHoc()));
            XuLyGiaoDien.resetButtonVeMacDinh(btnMonHoc, pnlMenu);
        }

        private void btnHocPhan_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMain.Controls.Add(XuLyGiaoDien.moFormCon(new FormDanhSachHocPhan()));
            XuLyGiaoDien.resetButtonVeMacDinh(btnHocPhan, pnlMenu);
        }
        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(XuLyGiaoDien.moFormCon(new FormDanhSachGiaoVien()));
            XuLyGiaoDien.resetButtonVeMacDinh(btnGiaoVien, pnlMenu);
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(XuLyGiaoDien.moFormCon(new FormDanhSachSinhVienTK()));
            XuLyGiaoDien.resetButtonVeMacDinh(btnSinhVien, pnlMenu);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(XuLyGiaoDien.moFormCon(new FormCaiDat()));
            XuLyGiaoDien.resetButtonVeMacDinh(btnCaiDat, pnlMenu);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            NguoiDungHienTai.XoaNguoiDungHienTai();
            this.Hide();
            Form formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }

        private void lblHocKy_Click(object sender, EventArgs e)
        {
            Form formHocKy = new FormHocKy();
            formHocKy.ShowDialog();
        }

        
    }
}
