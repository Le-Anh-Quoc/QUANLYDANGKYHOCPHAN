using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CHocPhanDAL
    {
        //CREATE
        public void ThemHocPhan(string maHocPhan, string maMonHoc, string maGiaoVien, string ngayHoc, string gioBatDau, string gioKetThuc, string phongHoc,
            string soLuongSinhVien)
        {
            SqlParameter[] parameters = new SqlParameter[8];

            parameters[0] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[0].Value = maHocPhan;

            parameters[1] = new SqlParameter("@MAMONHOC", SqlDbType.VarChar);
            parameters[1].Value = maMonHoc;

            parameters[2] = new SqlParameter("@MAGIAOVIEN", SqlDbType.VarChar);
            parameters[2].Value = maGiaoVien;

            parameters[3] = new SqlParameter("@NGAYHOC", SqlDbType.NVarChar);
            parameters[3].Value = ngayHoc;

            parameters[4] = new SqlParameter("@GIOBATDAU", SqlDbType.VarChar);
            parameters[4].Value = gioBatDau;

            parameters[5] = new SqlParameter("@GIOKETTHUC", SqlDbType.NVarChar);
            parameters[5].Value = gioKetThuc;

            parameters[6] = new SqlParameter("@PHONGHOC", SqlDbType.VarChar);
            parameters[6].Value = phongHoc;

            parameters[7] = new SqlParameter("@SOLUONGSINHVIEN", SqlDbType.Int);
            parameters[7].Value = soLuongSinhVien;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_THEM_HOC_PHAN", parameters);
        }
        //READ
        public DataTable LayTatCaLopHocPhan()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_TAT_CA_LOP_HOC_PHAN", null);
        }

        public DataTable LayCacLopHocPhanDangMo()
        {
            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_CAC_LOP_HOC_PHAN_DANG_MO", null);
        }

        public DataTable LayChiTietMotHocPhan(string maHocPhan)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[0].Value = maHocPhan;

            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_THONG_TIN_CHI_TIET_HOC_PHAN", parameters);
        }
        public DataTable LayCacLopHocPhanDangMoTheoMaMon(string maMonHoc)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MAMONHOC", SqlDbType.VarChar);
            parameters[0].Value = maMonHoc;

            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_CAC_LOP_HOC_PHAN_DANG_MO_THEO_MA_MON", parameters);
        }
        public DataTable LayCacHocPhanSinhVienDaDangKy(string maSinhVien)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@MASINHVIEN", SqlDbType.VarChar);
            parameters[0].Value = maSinhVien;

            return DatabaseHelper.ExecuteStoredProcedure("SP_LAY_CAC_HOC_PHAN_SINH_VIEN_DANG_KY", parameters);
        }
        //UPDATE

        public void SuaHocPhan(string maHocPhan, string maGiaoVien, string ngayHoc, string gioBatDau, string gioKetThuc, string phongHoc)
        {
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[0].Value = maHocPhan;

            parameters[1] = new SqlParameter("@MAGIAOVIEN", SqlDbType.VarChar);
            parameters[1].Value = maGiaoVien;

            parameters[2] = new SqlParameter("@NGAYHOC", SqlDbType.NVarChar);
            parameters[2].Value = ngayHoc;

            parameters[3] = new SqlParameter("@GIOBATDAU", SqlDbType.VarChar);
            parameters[3].Value = gioBatDau;

            parameters[4] = new SqlParameter("@GIOKETTHUC", SqlDbType.VarChar);
            parameters[4].Value = gioKetThuc;

            parameters[5] = new SqlParameter("@PHONGHOC", SqlDbType.NVarChar);
            parameters[5].Value = phongHoc;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_CAP_NHAT_HOC_PHAN", parameters);
        }
        public void CapNhatSoLuongSinhVienToiDa(string maHocPhan, int soLuongSV)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@MAHOCPHAN", SqlDbType.VarChar);
            parameters[0].Value = maHocPhan;
            parameters[1] = new SqlParameter("@SOLUONGSINHVIEN", SqlDbType.Int);
            parameters[1].Value = soLuongSV;

            DatabaseHelper.ExecuteNonQueryStoredProcedure("SP_CAP_NHAT_SO_LUONG_SINH_VIEN_HOC_PHAN", parameters);
        }
    }
}
