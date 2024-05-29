using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocPhan
    {
        public string maHocPhan {  get; set; }
        public string maMonHoc {  get; set; }
        public string maGiaoVien { get; set; }
        public string ngayHoc { get; set; }             //thứ trong tuần vd thứ 2, thứ 3, ...., thứ 7
        public string gioBatDau { get; set; }
        public string gioKetThuc { get; set; }
        public string phongHoc { get; set; }
        public int soLuongDangKy {  get; set; }         // số lượng sinh viên đã đăng ký được
        public int soLuongSinhVien { get; set; }        //số lượng sinh viên tối đa của một lớp học phần
    }
}
