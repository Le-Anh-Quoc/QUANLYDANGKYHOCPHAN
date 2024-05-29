using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CKichHoatDangKyBLL
    {
        private CKichHoatDangKyDAL dataAccess;

        public CKichHoatDangKyBLL()
        {
            this.dataAccess = new CKichHoatDangKyDAL();
        }

        public DataTable LayKichHoatDangKyMon()
        {
            return dataAccess.LayKichHoatDangKyMon();
        }
        public void KichHoatDangKyMon(Boolean kichHoat)
        {
            dataAccess.KichHoatDangKyMon(kichHoat);
        }
    }
}
