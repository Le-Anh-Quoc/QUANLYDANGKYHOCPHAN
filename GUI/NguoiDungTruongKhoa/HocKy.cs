using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public static class HocKy
    {
        public static string hocKy {  get; set; }
        public static string nienKhoa { get; set; }

        public static string layMaHocKy()
        {
            return hocKy + '_' + nienKhoa;
        }
    }
}
