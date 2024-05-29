using BLL;
using DTO;
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
    public partial class FormThemMonHoc : Form
    {
        CGiaoVienBLL giaoVienBLL;
        CMonHocBLL monHocBLL;
        public string maMon
        {
            get => txtMaMon.Text;
            set => txtMaMon.Text = value;
        }
        public string tenMon
        {
            get => txtTenMon.Text;
            set => txtTenMon.Text = value;
        }
        public string truongBoMon
        {
            get => cbbTruongBoMon.Text;
            set => cbbTruongBoMon.Text = value;
        }
        public string thongTinMon
        {
            get => txtThongTinMon.Text;
            set => txtThongTinMon.Text = value;
        }
        public Boolean them { get; set; }
        public FormThemMonHoc()
        {
            InitializeComponent();
            giaoVienBLL = new CGiaoVienBLL();
            monHocBLL = new CMonHocBLL();
        }

        private void FormThemMonHoc_Load(object sender, EventArgs e)
        {
            if (them == true)
            {
                btnCapNhat.Hide();
            } else
            {
                btnThem.Hide();
                txtMaMon.Enabled = false;
            }

            List<GiaoVien> danhSachGiaoVien = giaoVienBLL.LayTatCaGiaoVien();

            foreach (GiaoVien giaoVien in danhSachGiaoVien)
            {
                cbbTruongBoMon.Items.Add(giaoVien.maGiaoVien);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                monHocBLL.ThemMonHoc(txtMaMon.Text, txtTenMon.Text, cbbTruongBoMon.Text, txtThongTinMon.Text);
                MessageBox.Show("Thêm môn học thành công");
            } 
            catch
            {
                MessageBox.Show("Có lỗi khi thêm môn học");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                monHocBLL.SuaMonHoc(txtMaMon.Text, txtTenMon.Text, cbbTruongBoMon.Text, txtThongTinMon.Text);
                MessageBox.Show("Sửa thông tin môn học thành công");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Có lỗi khi sửa môn học");
            }
        }
    }
}
