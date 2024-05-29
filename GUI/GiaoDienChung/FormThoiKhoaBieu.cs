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
    public partial class FormThoiKhoaBieu : Form
    {
        private CGiaoVienBLL giaoVienBLL;
        public string maGiaoVien
        {
            get => lblMaGiaoVien.Text;
            set => lblMaGiaoVien.Text = value;
        }
        public string tenGiaoVien
        {
            get => lblTenGiaoVien.Text;
            set => lblTenGiaoVien.Text = value;
        }
        public FormThoiKhoaBieu()
        {
            InitializeComponent();
            giaoVienBLL = new CGiaoVienBLL();
        }

        private void FormThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            var dataTable = giaoVienBLL.LayThoiKhoaBieu(maGiaoVien);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    var monHocTKBItem = new UCMonHocTKB
                    {
                        UCTenMonHoc = row["TENMONHOC"].ToString(),
                        UCGioHoc = row["GIOBATDAU"].ToString() + "h-" + row["GIOKETTHUC"].ToString() + "h",
                        UCPhongHoc = row["PHONGHOC"].ToString(),
                    };

                    if (row["GIOBATDAU"].ToString() == "7")     // nếu giờ bắt đầu là 7 thì là tiết buổi sáng truyền lên row 0
                    {
                        tablePnlThoiKhoaBieu.Controls.Add(monHocTKBItem, XacDinhCot(row["NGAYHOC"].ToString()), 0);
                    } else
                    {
                        //nếu giờ bắt đầu khác thì là tiết buổi chiều truyền lên row 1
                        tablePnlThoiKhoaBieu.Controls.Add(monHocTKBItem, XacDinhCot(row["NGAYHOC"].ToString()), 1);
                    }
                    
                }
            }
        }

        private int XacDinhCot(string ngayHoc)
        {
            int thu = 0;
            if (!string.IsNullOrEmpty(ngayHoc))
            {
                char last_strNgayHoc = ngayHoc[ngayHoc.Length - 1];     // lấy kí tự cuối của ngayHoc
                thu = last_strNgayHoc - '0';        // ép về kiểu int
            }
            int cot = thu - 2;      //do cột của tablePnelThoiKhoaBieu bắt đầu từ 0
                                    //vd: ngayHoc là "Thứ 2", lấy kí tự cuối là "2", ép về kiểu int,
                                    //để ở cột đầu (cột 0) là thứ 2 nên trừ cho 2, tương tự ở những thứ khác
            return cot;
        }
    }
}
