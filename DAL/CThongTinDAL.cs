using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CThongTinDAL
    {
        public DataTable LayThongTinCaNhan(string maNguoiDung, string chucVu)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MANGUOIDUNG", SqlDbType.VarChar);
            parameters[0].Value = maNguoiDung;
            parameters[1] = new SqlParameter("@CHUCVU", SqlDbType.NVarChar);
            parameters[1].Value = chucVu;

            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_THONG_TIN_NGUOI_DUNG", parameters);
        }
    }
}
