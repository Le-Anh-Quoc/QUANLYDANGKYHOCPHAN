using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CDangNhapBLL
    {
        private CDangNhapDAL dataAccess;

        public CDangNhapBLL()
        {
            this.dataAccess = new CDangNhapDAL();
        }
        public DataTable DangNhap(string taiKhoan, string matKhau)
        {
            return dataAccess.DangNhap(taiKhoan, matKhau);
        }
    }
}
