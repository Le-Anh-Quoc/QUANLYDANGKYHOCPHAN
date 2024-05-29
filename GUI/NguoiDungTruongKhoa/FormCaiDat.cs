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
    public partial class FormCaiDat : Form
    {
        CKichHoatDangKyBLL kichHoatDangKyBLL;
        public FormCaiDat()
        {
            InitializeComponent();
            kichHoatDangKyBLL = new CKichHoatDangKyBLL();
        }

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            var dataTable = kichHoatDangKyBLL.LayKichHoatDangKyMon();

            DataRow dr = dataTable.Rows[0];

            if (dr["KICHHOAT"].ToString() == "True")
            {
                rdoBtnMo.Checked = true;
            } else
            {
                rdoBtnDong.Checked = true;
            }
        }

        private void rdoBtnMo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                kichHoatDangKyBLL.KichHoatDangKyMon(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoBtnDong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                kichHoatDangKyBLL.KichHoatDangKyMon(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
