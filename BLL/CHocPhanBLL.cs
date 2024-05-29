using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CHocPhanBLL
    {
        private CHocPhanDAL dataAccess;

        public CHocPhanBLL()
        {
            this.dataAccess = new CHocPhanDAL();
        }
        //CREATE 
        public void themHocPhan(string maHocPhan, string maMonHoc, string maGiaoVien, string ngayHoc, string gioBatDau, string gioKetThuc, string phongHoc,
            string soLuongSinhVien)
        {
            dataAccess.ThemHocPhan(maHocPhan, maMonHoc, maGiaoVien, ngayHoc, gioBatDau, gioKetThuc, phongHoc, soLuongSinhVien);
        }

        // read
        public DataTable LayTatCaLopHocPhan()
        {
            return dataAccess.LayTatCaLopHocPhan();
        }
        public DataTable LayCacLopHocPhanDangMo()
        {
            return dataAccess.LayCacLopHocPhanDangMo();
        }
        public DataTable LayChiTieMotHocPhan(string maHocPhan)
        {
            return dataAccess.LayChiTietMotHocPhan(maHocPhan);
        }
        public DataTable LayCacLopHocPhanDangMoTheoMaMon(string maMonHoc)
        {
            return dataAccess.LayCacLopHocPhanDangMoTheoMaMon(maMonHoc);
        }
        public DataTable LayCacHocPhanSinhVienDaDangKy(string maSinhVien)
        {
            return dataAccess.LayCacHocPhanSinhVienDaDangKy(maSinhVien);
        }

        //update
        public void SuaHocPhan(string maHocPhan, string maGiaoVien, string ngayHoc, string gioBatDau, string gioKetThuc, string phongHoc)
        {
            dataAccess.SuaHocPhan(maHocPhan, maGiaoVien, ngayHoc, gioBatDau, gioKetThuc, phongHoc);
        }
        public void CapNhatSoLuongSinhVienToiDa(string maHocPhan, int soLuongSV)
        {
            dataAccess.CapNhatSoLuongSinhVienToiDa(maHocPhan, soLuongSV);
        }
    }
}
