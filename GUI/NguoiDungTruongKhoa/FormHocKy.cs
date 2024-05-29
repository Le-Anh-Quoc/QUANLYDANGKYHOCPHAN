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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormHocKy : Form
    {
        CHocKyBLL hocKyBLL;
        public FormHocKy()
        {
            InitializeComponent();
            hocKyBLL = new CHocKyBLL();
        }

        private void FomHocKy_Load(object sender, EventArgs e)
        {
            cbbHocKy.Items.Add("I");
            cbbHocKy.Items.Add("II");
            cbbHocKy.Items.Add("III");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.IsNullOrEmpty() || cbbHocKy.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
            } else
            {
                string thongBaoKichHoat = hocKyBLL.KichHoatHocKy(cbbHocKy.Text, txtNienKhoa.Text);
                MessageBox.Show(thongBaoKichHoat);
                Close();
            }
        } 
    }
}
