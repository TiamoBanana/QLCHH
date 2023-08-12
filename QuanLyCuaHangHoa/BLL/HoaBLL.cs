using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaBLL
    {
        //Hàm hiển thị danh sách hoa
        public static List<HoaDTO> LayDanhSachHoa()
        {
            return HoaDAL.LayDanhSachHoa();
        }

        //Hàm thêm mới hoa
        public static bool ThemHoa(HoaDTO h)
        {
            return HoaDAL.ThemHoa(h);
        }

        //Hàm tìm hoa theo mã
        public static HoaDTO TimHoaTheoMa(string ma)
        {
            return HoaDAL.TimHoaTheoMa(ma);
        }

        //Hàm sửa thông tin hoa
        public static bool CapNhatThongTinHoa(HoaDTO h)
        {
            return HoaDAL.CapNhatThongTinHoa(h);
        }

        //Hàm xóa thông tin hoa
        public static bool XoaThongTinHoa(HoaDTO h)
        {
            return HoaDAL.XoaThongTinHoa(h);
        }
    }
}
