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
    public partial class UCMonHoc_SV_ : UserControl
    {
        CMonHocBLL monHocBLL;
        bool isHover = false;
        public string UCMaMon
        {
            get => lblMaMonHoc.Text;
            set => lblMaMonHoc.Text = value;
        }

        public string UCTenMon
        {
            get => lblTenMonHoc.Text;
            set => lblTenMonHoc.Text = value;
        }
        public UCMonHoc_SV_()
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

        private void UCMonHoc_SV__MouseEnter(object sender, EventArgs e)
        {
            moveMouseEnter();
        }

        private void UCMonHoc_SV__MouseLeave(object sender, EventArgs e)
        {
            moveMouseLeave();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Form formDanhSachHocPhan_Mo = new FormDanhSachHocPhan_SV_()
            {
                maMonHoc = UCMaMon,
            };
            formDanhSachHocPhan_Mo.ShowDialog();
        }
    }
}
