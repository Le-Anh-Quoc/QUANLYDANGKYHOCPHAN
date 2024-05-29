using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CThongTinBLL
    {
        private CThongTinDAL dataAccess;

        public CThongTinBLL()
        {
            this.dataAccess = new CThongTinDAL();
        }
        public DataTable LayThongTinCaNhan(string maNguoiDung, string chucVu)
        {
            return dataAccess.LayThongTinCaNhan(maNguoiDung, chucVu);
        }
    }
}
