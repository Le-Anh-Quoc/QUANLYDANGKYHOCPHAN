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
    public partial class FormDanhSachMonHoc_SV_ : Form
    {
        CMonHocBLL monHocBLL;
        public FormDanhSachMonHoc_SV_()
        {
            InitializeComponent();
            monHocBLL = new CMonHocBLL();
        }

        private void HienThiCacMonHocDangMo()
        {
            if (flPnlDSMonHocMo.Controls.Count > 0)
            {
                flPnlDSMonHocMo.Controls.Clear();
            }

            var dataTable = monHocBLL.LayMonHocDangMoChoSinhVien();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var monHocItem = new UCMonHoc_SV_
                    {
                        UCMaMon = row["MAMONHOC"].ToString(),
                        UCTenMon = row["TENMONHOC"].ToString(),
                    };
                    flPnlDSMonHocMo.Controls.Add(monHocItem);
                }
            }
        }

        private void FormDanhSachMonHoc_SV__Load(object sender, EventArgs e)
        {
            HienThiCacMonHocDangMo();
        }

        private void flPnlDSMonHocMo_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in flPnlDSMonHocMo.Controls)
            {
                // Kiểm tra xem control có phải là UserControl không
                if (control is UserControl)
                {
                    // Đặt kích thước chiều dài của UserControl bằng với kích thước chiều dài của FlowLayoutPanel
                    control.Width = flPnlDSMonHocMo.ClientSize.Width;
                }
            }
        }
    }
}
