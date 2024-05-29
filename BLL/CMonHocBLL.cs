using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class CMonHocBLL
    {
        private CMonHocDAL dataAccess;

        public CMonHocBLL()
        {
            this.dataAccess = new CMonHocDAL();
        }

        // lấy dữ liệu
        public List<MonHoc> LayTatCaMonHoc()
        {
            List<MonHoc> danhSachMonHoc = new List<MonHoc>();

            var dataTable = dataAccess.LayTatCaMonHoc();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    MonHoc monHocItem = new MonHoc
                    {
                        maMonHoc = row["MAMONHOC"].ToString(),
                        tenMonHoc = row["TENMONHOC"].ToString(),
                        truongBoMon = row["TRUONGBOMON"].ToString(),
                        thongTinMonHoc = row["THONGTINMONHOC"].ToString(),
                        kichHoat = Convert.ToBoolean(row["KICHHOAT"]),
                        hienThi = Convert.ToBoolean(row["HIENTHI"])
                    };

                    danhSachMonHoc.Add(monHocItem);
                }
            }

            return danhSachMonHoc;
        }        
        public DataTable LayMonHocDangMoChoSinhVien()
        {
            return dataAccess.LayMonHocDangMoChoSinhVien();
        }
        

        //cập nhật
        public void SuaMonHoc(string maMonHoc, string tenMonHoc, string truongBoMon, string thongTinMonHoc)
        {
            dataAccess.SuaMonHoc(maMonHoc, tenMonHoc, truongBoMon, thongTinMonHoc);
        }
        public void BatTatMonHoc(string maMonHoc, bool kichHoat)
        {
            dataAccess.BatTatMonHocMo(maMonHoc, kichHoat);
        }

        //THÊM
        public void ThemMonHoc(string maMonHoc, string tenMonHoc, string truongBoMon, string thongTinMonHoc)
        {
            dataAccess.ThemMonHoc(maMonHoc, tenMonHoc, truongBoMon, thongTinMonHoc);
        }

        //XOA
        public void XoaMonHoc(string maMonHoc)
        {
            dataAccess.XoaMonHoc(maMonHoc);
        }
    }
}
