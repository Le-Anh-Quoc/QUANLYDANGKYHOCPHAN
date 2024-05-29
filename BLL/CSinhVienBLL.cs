using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CSinhVienBLL
    {
        private CSinhVienDAL dataAccess;

        public CSinhVienBLL()
        {
            this.dataAccess = new CSinhVienDAL();
        }
        public DataTable LayTatCaSinhVien()
        {
            return dataAccess.LayTatCaSinhVien();
        }
        public DataTable LaySinhVienLopHocPhan(string maLHP)
        {
            return dataAccess.LaySinhVienLopHocPhan(maLHP);
        }
        public void HuyDangKyHocPhan(string maSinhVien, string maHocPhan)
        {
            dataAccess.HuyDangKyHocPhan(maSinhVien, maHocPhan);
        }

        public void CapNhatDiemSinhVien(string maSinhVien, string maHocPhan, int diem)
        {
            dataAccess.CapNhatDiemSinhVien(maSinhVien , maHocPhan, diem);
        }
    }
}
