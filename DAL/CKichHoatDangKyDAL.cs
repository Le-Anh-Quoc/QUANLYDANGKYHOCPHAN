using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DAL
{
    public class CKichHoatDangKyDAL
    {
        public DataTable LayKichHoatDangKyMon()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_KICH_HOAT_DANG_KY_MON", null);
        }


        public void KichHoatDangKyMon(Boolean kichHoat)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@KICHHOAT", SqlDbType.Bit);
            parameters[0].Value = kichHoat;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_CAP_NHAT_KICH_HOAT_DANG_KY_MON", parameters);
        }
    }
}
