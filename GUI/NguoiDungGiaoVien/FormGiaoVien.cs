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
    public partial class FormGiaoVien : Form
    {
        private Form currentFormChild;
        CHocKyBLL hocKyBLL;
        public FormGiaoVien()
        {
            InitializeComponent();
            hocKyBLL = new CHocKyBLL();
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void ResetButtonColors()
        {
            foreach (System.Windows.Forms.Control control in pnlMenu.Controls)
            {
                if (control is Button button)
                {
                    button.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            btnThongTin.Text = NguoiDungHienTai.chucVu;
            lblHocKy.Text = hocKyBLL.LayHocKyDangKichHoat();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Form formThongTinCaNhan = new FormThongTinCaNhan();
            formThongTinCaNhan.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            NguoiDungHienTai.XoaNguoiDungHienTai();
            this.Hide();
            Form formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }

        private void btnMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new FormDanhSachMonHoc());
            ResetButtonColors();
            btnMonHoc.FlatAppearance.BorderSize = 1;
        }

        private void btnHocPhan_MouseClick(object sender, MouseEventArgs e)
        {
            OpenChildForm(new FormDanhSachHocPhan());
            ResetButtonColors();
            btnHocPhan.FlatAppearance.BorderSize = 1;
        }

        private void btnLichDay_Click(object sender, EventArgs e)
        {
            Form formThoiKhoaBieu = new FormThoiKhoaBieu
            {
                maGiaoVien = NguoiDungHienTai.maSo,
                tenGiaoVien = NguoiDungHienTai.hoTen,
            };
            OpenChildForm(formThoiKhoaBieu);
            ResetButtonColors();
            btnLichDay.FlatAppearance.BorderSize = 1;
        }
    }
}
