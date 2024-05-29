using BLL;
using Org.BouncyCastle.Math.Field;
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
    public partial class FormSinhVien : Form
    {
        private Form currentFormChild;
        CHocKyBLL hocKyBLL;
        CKichHoatDangKyBLL kichHoatDangKyBLL;
        public FormSinhVien()
        {
            InitializeComponent();
            hocKyBLL = new CHocKyBLL();
            kichHoatDangKyBLL = new CKichHoatDangKyBLL();
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

        private void btnDangKyMon_Click(object sender, EventArgs e)
        {
            var dataTable = kichHoatDangKyBLL.LayKichHoatDangKyMon();

            DataRow dr = dataTable.Rows[0];

            if (dr["KICHHOAT"].ToString() == "True")
            {
                OpenChildForm(new FormDanhSachMonHoc_SV_());
                ResetButtonColors();
                btnDangKyMon.FlatAppearance.BorderSize = 1;
            } else
            {
                MessageBox.Show("Sự kiện đăng ký học phần hiện tại chưa được mở. Hãy quay lại sau, xin cảm ơn.");
            }
            
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            btnThongTin.Text = NguoiDungHienTai.chucVu;
            lblHocKy.Text = hocKyBLL.LayHocKyDangKichHoat();
        }

        private void btnLopHocPhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLichSuDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHocPhanSVDangKy());
            ResetButtonColors();
            btnLichSuDangKy.FlatAppearance.BorderSize = 1;
        }
    }
}
