using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CGiaoVienDAL
    {
        public DataTable KiemTraGiaoVienThuocLop(string maGiaoVienHienTai, string maHocPhan)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MAGIAOVIEN_HIENTAI", SqlDbType.VarChar);
            parameters[0].Value = maGiaoVienHienTai;
            parameters[1] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[1].Value = maHocPhan;

            return DatabaseHelper.ExecuteStoredProcedure("SP_KIEM_TRA_GIAO_VIEN_THUOC_LOP", parameters);
        }

        public DataTable KiemTraTruongBoMonMonHoc(string maGiaoVien, string maHocPhan)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MAGIAOVIEN", SqlDbType.VarChar);
            parameters[0].Value = maGiaoVien;
            parameters[1] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[1].Value = maHocPhan;

            return DatabaseHelper.ExecuteStoredProcedure("SP_KIEM_TRA_TRUONG_BO_MON_MON_HOC", parameters);
        }

        public DataTable LayTatCaGiaoVien()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_TAT_CA_GIAO_VIEN", null);
        }

        public DataTable LayThoiKhoaBieu(string maGiaoVien)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MAGIAOVIEN", SqlDbType.VarChar);
            parameters[0].Value = maGiaoVien;

            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_THOI_KHOA_BIEU", parameters);
        }
    }
}
