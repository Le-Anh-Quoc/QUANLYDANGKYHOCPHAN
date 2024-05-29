using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CHocKyDAL
    {
        public DataTable KichHoatHocKy(string hocKy, string nienKhoa)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@HOCKY", SqlDbType.VarChar);
            parameters[0].Value = hocKy;
            parameters[1] = new SqlParameter("@NIENKHOA", SqlDbType.VarChar);
            parameters[1].Value = nienKhoa;

            return DatabaseHelper.ExecuteStoredProcedure("SP_KICH_HOAT_MO_HOC_KY", parameters);
        }

        public DataTable LayHocKyDangKichHoat()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_HOC_KY_DANG_KICH_HOAT", null);
        }
    }
}
