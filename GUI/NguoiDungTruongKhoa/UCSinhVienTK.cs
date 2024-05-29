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
    public partial class UCSinhVienTK : UserControl
    {
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
        public string UCDiaChi
        {
            get => lblDiaChi.Text;
            set => lblDiaChi.Text = value;
        }
        public UCSinhVienTK()
        {
            InitializeComponent();
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

        private void UCSinhVienTK_MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCSinhVienTK_MouseLeave(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void UCSinhVienTK_Click(object sender, EventArgs e)
        {

        }
    }
}
