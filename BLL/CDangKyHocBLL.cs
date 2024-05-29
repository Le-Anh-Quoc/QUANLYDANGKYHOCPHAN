using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CDangKyHocBLL
    {
        private CDangKyHocDAL dataAccess;

        public CDangKyHocBLL()
        {
            this.dataAccess = new CDangKyHocDAL();
        }
        public void SinhVienDangKyHoc(string maSinhVien, string maHocPhan)
        {
            dataAccess.SinhVienDangKyHoc( maSinhVien, maHocPhan);
        }
    }
}
