using System;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class CMonHocDAL
    {
        #region LẤY DỮ LIỆU MÔN HỌC
        public DataTable LayTatCaMonHoc()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_TAT_CA_MON_HOC", null);
        }

        public DataTable LayMonHocDangMoChoSinhVien()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_TAT_CA_MON_HOC_MO", null);
        }

        #endregion


        #region SỬA DỮ LIỆU MÔN HỌC
        public void SuaMonHoc(string maMonHoc, string tenMonHoc, string truongBoMon, string thongTinMonHoc)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@MAMONHOC", SqlDbType.VarChar);
            parameters[0].Value = maMonHoc;
            parameters[1] = new SqlParameter("@TENMONHOC", SqlDbType.NVarChar);
            parameters[1].Value = tenMonHoc;
            parameters[2] = new SqlParameter("@TRUONGBOMON", SqlDbType.VarChar);
            parameters[2].Value = truongBoMon;
            parameters[3] = new SqlParameter("@THONGTINMONHOC", SqlDbType.NVarChar);
            parameters[3].Value = thongTinMonHoc;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_SUA_MON_HOC", parameters);
        }
        public void BatTatMonHocMo(string maMonHoc, bool kichHoat)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MAMONHOC", SqlDbType.NVarChar);
            parameters[0].Value = maMonHoc;
            parameters[1] = new SqlParameter("@KICHHOAT", SqlDbType.Bit);
            parameters[1].Value = kichHoat;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_CAP_NHAT_MON_HOC_DUOC_MO", parameters);
        }
        
        #endregion


        #region CREATE
        public void ThemMonHoc(string maMonHoc, string tenMonHoc, string truongBoMon, string thongTinMonHoc)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@MAMONHOC", SqlDbType.VarChar);
            parameters[0].Value = maMonHoc;
            parameters[1] = new SqlParameter("@TENMONHOC", SqlDbType.NVarChar);
            parameters[1].Value = tenMonHoc;
            parameters[2] = new SqlParameter("@TRUONGBOMON", SqlDbType.VarChar);
            parameters[2].Value = truongBoMon;
            parameters[3] = new SqlParameter("@THONGTINMONHOC", SqlDbType.NVarChar);
            parameters[3].Value = thongTinMonHoc;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_THEM_MON_HOC", parameters);
        }
        #endregion

        #region DELETE
        public void XoaMonHoc(string maMonHoc)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MAMONHOC", SqlDbType.VarChar);
            parameters[0].Value = maMonHoc;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_XOA_MON_HOC", parameters);
        }
        #endregion
    }
}
