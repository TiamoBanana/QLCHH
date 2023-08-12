using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {

        public static string slHoaDon()
        {
            return ThongKeDAL.SoLuongHoaDon();
        }
        public static List<ThongKeDTO> DoanhThuThang()
        {
            return ThongKeDAL.DoanhThuThang();
        }
        public static string slKhachHang()
        {
            return ThongKeDAL.SoLuonggKhachHang();
        }
        public static string slNhanVien()
        {
            return ThongKeDAL.SoLuonggNhanVien();
        }
        public static string slHangHoa()
        {
            return ThongKeDAL.SoLuonggHangHoa();
        }
    }
}
