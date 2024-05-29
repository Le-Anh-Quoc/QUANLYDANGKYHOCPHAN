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
    public partial class UCSinhVien : UserControl
    {
        private CSinhVienBLL sinhVienBLL;

        bool isHover = false;
        public string UCMaSV
        {
            get => lblMaSV.Text;
            set => lblMaSV.Text = value;
        }

        public string UCHoTenSV
        {
            get => lblHoTenSV.Text;
            set => lblHoTenSV.Text = value;
        }

        public string UCNgaySinh
        {
            get => lblNgaySinh.Text;
            set => lblNgaySinh.Text = value;
        }

        public string UCEmail
        {
            get => lblEmail.Text;
            set => lblEmail.Text = value;
        }
        public string UCDiem
        {
            get => txtDiem.Text;
            set => txtDiem.Text = value;
        }
        public UCSinhVien()
        {
            InitializeComponent();
            sinhVienBLL = new CSinhVienBLL();
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

        private void UCSinhVien_MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCSinhVien_MouseLeave(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void UCSinhVien_Load(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.chucVu == "Trưởng khoa" || NguoiDungHienTai.chucVu == "Giáo vụ")
            {
                txtDiem.ReadOnly = true;
                btnCapNhat.Hide();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                sinhVienBLL.CapNhatDiemSinhVien(UCMaSV, NguoiDungHienTai.maHocPhanDangChon, int.Parse(txtDiem.Text));
                MessageBox.Show("Cập nhật điểm cho sinh viên thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
