using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CDangKyHocDAL
    {
        public void SinhVienDangKyHoc(string maSinhVien, string maHocPhan)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MASINHVIEN", SqlDbType.VarChar);
            parameters[0].Value = maSinhVien;
            parameters[1] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[1].Value = maHocPhan;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_SINH_VIEN_DANG_KY_HOC", parameters);
        }
    }
}
