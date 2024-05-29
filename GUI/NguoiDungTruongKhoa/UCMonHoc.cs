using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCMonHoc : UserControl
    {
        CMonHocBLL monHocBLL;
        bool isHover = false;
        public string UCMaMon
        {
            get => lblMaMon.Text;
            set => lblMaMon.Text = value;
        }

        public string UCTenMon
        {
            get => lblTenMon.Text;
            set => lblTenMon.Text = value;
        }

        public string UCTruongBoMon { get; set; }
        public string UCThongTinMonHoc { get; set; }
        public bool UCKichHoatMon
        {
            get => ckBoxKichHoatMon.Checked;
            set => ckBoxKichHoatMon.Checked = value;
        }
        public UCMonHoc()
        {
            InitializeComponent();
            monHocBLL = new CMonHocBLL();
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

        private void UCMonHoc_MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCMonHoc_MouseLeave_1(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void UCMonHoc_Load(object sender, EventArgs e)
        {
            if (NguoiDungHienTai.chucVu == "Giáo vụ")
            {
                ckBoxKichHoatMon.Enabled = true;        //được phép kích hoạt môn học

                btnSua.Hide();
                btnXoa.Hide(); 
            } else if (NguoiDungHienTai.chucVu == "Trưởng bộ môn" || NguoiDungHienTai.chucVu == "Giáo viên")
            {
                btnSua.Hide();
                btnXoa.Hide();
            }
        }

        private void ckBoxKichHoatMon_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                // Lấy thông tin user control tương ứng từ checkbox
                // Cập nhật trạng thái kích hoạt trong cơ sở dữ liệu
                CapNhatMonHocMo(UCMaMon, checkBox.Checked);
            }
        }

        private void CapNhatMonHocMo(string maMonHoc, bool kichHoat)
        {
            monHocBLL.BatTatMonHoc(maMonHoc, kichHoat);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form formThemMonHoc = new FormThemMonHoc
            {
                maMon = UCMaMon,
                tenMon = UCTenMon,
                truongBoMon = UCTruongBoMon,
                thongTinMon = UCThongTinMonHoc,
                them = false,
            };
            formThemMonHoc.ShowDialog();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    monHocBLL.XoaMonHoc(UCMaMon);
                    MessageBox.Show("Xóa môn học thành công");
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa môn học");
                }
            }
        }
    }
}
