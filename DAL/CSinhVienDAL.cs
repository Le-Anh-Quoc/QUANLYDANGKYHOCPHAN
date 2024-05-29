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
    public class CSinhVienDAL
    {
        public DataTable LayTatCaSinhVien()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_TAT_CA_SINH_VIEN", null);
        }


        public DataTable LaySinhVienLopHocPhan(string maLHP)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MALHP", SqlDbType.VarChar);
            parameters[0].Value = maLHP;

            return DatabaseHelper.ExecuteStoredProcedure("SP_SINH_VIEN_LOP_HOC_PHAN", parameters);
        }

        public void HuyDangKyHocPhan(string maSinhVien, string maHocPhan)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MASINHVIEN", SqlDbType.VarChar);
            parameters[0].Value = maSinhVien;
            parameters[1] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[1].Value = maHocPhan;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_SINH_VIEN_HUY_DANG_KY", parameters);
        }

        public void CapNhatDiemSinhVien(string maSinhVien, string maHocPhan, int diem)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@MASINHVIEN", SqlDbType.VarChar);
            parameters[0].Value = maSinhVien;
            parameters[1] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[1].Value = maHocPhan;
            parameters[2] = new SqlParameter("@DIEM", SqlDbType.Int);
            parameters[2].Value = diem;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_CAP_NHAT_DIEM_CHO_SINH_VIEN", parameters);
        }
    }
}
