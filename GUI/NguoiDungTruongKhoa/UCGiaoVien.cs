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
    public partial class UCGiaoVien : UserControl
    {
        bool isHover = false;
        public string UCMaGV
        {
            get => lblMaGV.Text;
            set => lblMaGV.Text = value;
        }

        public string UCHoTenGV
        {
            get => lblHoTenGV.Text;
            set => lblHoTenGV.Text = value;
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
        public UCGiaoVien()
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

        private void UCGiaoVien_MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCGiaoVien_MouseLeave(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void UCGiaoVien_Click(object sender, EventArgs e)
        {
            Form formThoiKhoaBieu = new FormThoiKhoaBieu
            {
                maGiaoVien = UCMaGV,
                tenGiaoVien = UCHoTenGV,
            };
            formThoiKhoaBieu.ShowDialog();
        }
    }
}
