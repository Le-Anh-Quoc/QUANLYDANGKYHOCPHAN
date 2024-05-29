using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class NguoiDungHienTai
    {
        //chỗ này xử lý chung lấy thông tin
        public static string maNguoiDung { get; set; }
        public static string chucVu {  get; set; }

        public static string maSo {  get; set; }
        public static string hoTen {  get; set; }
        public static string ngaySinh { get; set; }
        public static string email { get; set; }
        public static string diaChi { get; set; }

        // chỗ này xử lý cho sinh viên
        public static string maMonHocDangChon {  get; set; }
        public static string maHocPhanDangChon { get; set; }

        public static void XoaNguoiDungHienTai()            //đây là chức năng dành cho việc đăng xuất
        {
            maNguoiDung = null;
            chucVu = null;
            maSo = null;
            hoTen = null;
            ngaySinh = null;
            email = null;
            diaChi = null;
        }
        //public static string layMaHocKy()
        //{
        //    return hocKy + '_' + nienKhoa;
        //}
    }
}
