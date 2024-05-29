using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CGiaoVienBLL
    {
        private CGiaoVienDAL dataAccess;

        public CGiaoVienBLL()
        {
            this.dataAccess = new CGiaoVienDAL();
        }
        public DataTable KiemTraGiaoVienThuocLop(string maGiaoVienHienTai, string maHocPhan)
        {
            return dataAccess.KiemTraGiaoVienThuocLop(maGiaoVienHienTai, maHocPhan);
        }
        public DataTable KiemTraTruongBoMonMonHoc(string maGiaoVien, string maHocPhan)
        {
            return dataAccess.KiemTraTruongBoMonMonHoc(maGiaoVien, maHocPhan);
        }
        public List<GiaoVien> LayTatCaGiaoVien()
        {
            List<GiaoVien> danhSachGiaoVien = new List<GiaoVien>();

            var dataTable = dataAccess.LayTatCaGiaoVien();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    GiaoVien giaoVienItem = new GiaoVien
                    {
                        maGiaoVien = row["MAGIAOVIEN"].ToString(),
                        maNguoiDung = row["MANGUOIDUNG"].ToString(),
                        hoTen = row["HOTEN"].ToString(),
                        ngaySinh = row["NGAYSINH"].ToString(),
                        email = row["EMAIL"].ToString(),
                        diaChi = row["DIACHI"].ToString()
                    };

                    danhSachGiaoVien.Add(giaoVienItem);
                }
            }

            return danhSachGiaoVien;
        }
        public DataTable LayThoiKhoaBieu(string maGiaoVien)
        {
            return dataAccess.LayThoiKhoaBieu(maGiaoVien);
        }
    }
}
