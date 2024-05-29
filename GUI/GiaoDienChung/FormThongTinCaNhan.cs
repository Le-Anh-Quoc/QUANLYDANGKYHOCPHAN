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
    public partial class FormThongTinCaNhan : Form
    {
        CThongTinBLL thongTinBLL;
        public FormThongTinCaNhan()
        {
            InitializeComponent();
            thongTinBLL = new CThongTinBLL();
        }

        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LayThongTinCaNhan();
        }

        private void LayThongTinCaNhan()
        {
            txtMaSo.Text = NguoiDungHienTai.maSo;
            txtHoTen.Text = NguoiDungHienTai.hoTen;
            txtNgaySinh.Text = NguoiDungHienTai.ngaySinh;
            txtEmail.Text = NguoiDungHienTai.email;
            txtDiaChi.Text = NguoiDungHienTai.diaChi;
        }
    }
}
