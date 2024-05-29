using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CHocKyBLL
    {
        private CHocKyDAL dataAccess;

        public CHocKyBLL()
        {
            this.dataAccess = new CHocKyDAL();
        }
        public string KichHoatHocKy(string hocKy, string nienKhoa)
        {
            var dt = dataAccess.KichHoatHocKy(hocKy, nienKhoa);
            DataRow dataRow = dt.Rows[0];
            return dataRow["THONGBAO"].ToString();
        }
        public string LayHocKyDangKichHoat()
        {
            var dtHocKyKichHoat = dataAccess.LayHocKyDangKichHoat();
            DataRow dr = dtHocKyKichHoat.Rows[0];
            return "Học kỳ " + dr["HOCKY"].ToString() + ", " + dr["NIENKHOA"].ToString();
        }
    }
}
