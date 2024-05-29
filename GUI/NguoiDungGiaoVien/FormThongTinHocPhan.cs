using BLL;
using DTO;
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
    public partial class FormThongTinHocPhan : Form
    {
        private CMonHocBLL monHocBLL;
        private CHocPhanBLL hocPhanBLL;
        private CGiaoVienBLL giaoVienBLL;
        public string maLHP
        {
            get => txtMaHocPhan.Text;
            set => txtMaHocPhan.Text = value;
        }
        public Boolean sua { get; set; }
        public FormThongTinHocPhan()
        {
            InitializeComponent();
            hocPhanBLL = new CHocPhanBLL();
            monHocBLL = new CMonHocBLL();
            giaoVienBLL = new CGiaoVienBLL();
        }

        private void FormThongTinHocPhan_Load(object sender, EventArgs e)
        {
            var dataTable = hocPhanBLL.LayChiTieMotHocPhan(maLHP);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                cbbMaMonHoc.Text = row["MAMONHOC"].ToString();
                cbbMaGiaoVien.Text = row["MAGIAOVIEN"].ToString();
                txtNgayHoc.Text = row["NGAYHOC"].ToString();
                txtGioBatDau.Text = row["GIOBATDAU"].ToString();
                txtGioKetThuc.Text = row["GIOKETTHUC"].ToString();
                txtPhongHoc.Text = row["PHONGHOC"].ToString();
                txtSoLuongSV.Text = row["SOLUONGSINHVIEN"].ToString();
                txtSoLuongSVHienTai.Text = row["SOLUONGDANGKY"].ToString();
            }

            if (NguoiDungHienTai.chucVu == "Giáo vụ")
            {
                btnCapNhat.Hide();
                cbbMaGiaoVien.Enabled= false;
                txtNgayHoc.ReadOnly = true;
                txtGioBatDau.ReadOnly = true;
                txtGioKetThuc.ReadOnly = true;
                txtPhongHoc.ReadOnly = true;
                txtSoLuongSV.ReadOnly = true;
                txtSoLuongSVHienTai.ReadOnly = true;
            } else if (NguoiDungHienTai.chucVu == "Trưởng khoa")
            {
                txtSoLuongSV.ReadOnly= true;
            } else
            {
                cbbMaGiaoVien.Enabled = false;
                txtNgayHoc.ReadOnly = true;
                txtGioBatDau.ReadOnly = true;
                txtGioKetThuc.ReadOnly = true;
                txtPhongHoc.ReadOnly = true;
                txtSoLuongSVHienTai.ReadOnly = true;


            }

            if (sua == true)
            {
                txtMaHocPhan.ReadOnly = true;
                cbbMaMonHoc.Enabled = false;
                btnThem.Hide();
            } else
            {
                btnCapNhat.Hide();
                txtSoLuongSV.ReadOnly = false;
            }

            List<MonHoc> danhSachMonHoc = monHocBLL.LayTatCaMonHoc();

            foreach (MonHoc monHoc in danhSachMonHoc)
            {
                cbbMaMonHoc.Items.Add(monHoc.maMonHoc);
            }

            List<GiaoVien> danhSachGiaoVien = giaoVienBLL.LayTatCaGiaoVien();

            foreach (GiaoVien giaoVien in danhSachGiaoVien)
            {
                cbbMaGiaoVien.Items.Add(giaoVien.maGiaoVien);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.chucVu == "Trưởng bộ môn")
            {
                try 
                {
                    hocPhanBLL.CapNhatSoLuongSinhVienToiDa(maLHP, int.Parse(txtSoLuongSV.Text));
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    hocPhanBLL.SuaHocPhan(txtMaHocPhan.Text, cbbMaGiaoVien.Text, txtNgayHoc.Text, txtGioBatDau.Text, txtGioKetThuc.Text, txtPhongHoc.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                hocPhanBLL.themHocPhan(txtMaHocPhan.Text, cbbMaMonHoc.Text, cbbMaGiaoVien.Text, txtNgayHoc.Text, txtGioBatDau.Text, txtGioKetThuc.Text,
                    txtPhongHoc.Text, txtSoLuongSV.Text);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
