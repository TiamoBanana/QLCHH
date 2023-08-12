using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        public static List<HoaDonDTO> LayDSHoaDon()
        {
            return HoaDonDAL.LayDSHoaDon();
        }
        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAL.ThemHoaDon(hd);
        }
        public static bool XoaHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAL.XoaHoaDon(hd);
        }
        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            return HoaDonDAL.SuaHoaDon(hd);
        }
        public static HoaDonDTO TimHoaDonTheoMa(string ma)
        {
            return HoaDonDAL.TimHoaDonTheoMa(ma);
        }
    }
}
