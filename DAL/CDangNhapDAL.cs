using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CDangNhapDAL
    {
        public DataTable DangNhap(string taiKhoan, string matKhau)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@TAIKHOAN", SqlDbType.VarChar);
            parameters[0].Value = taiKhoan;
            parameters[1] = new SqlParameter("@MATKHAU", SqlDbType.VarChar);
            parameters[1].Value = matKhau;

            return DatabaseHelper.ExecuteStoredProcedure("SP_DANG_NHAP_NGUOI_DUNG", parameters);
        }
    }
}
