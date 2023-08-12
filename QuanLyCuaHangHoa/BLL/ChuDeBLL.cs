using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChuDeBLL
    {
        //Hàm hiển thị danh sách chủ đề
        public static List<ChuDeDTO> LayDanhSachChuDe()
        {
            return ChuDeDAL.LayDanhSachChuDe();
        }

        //Hàm thêm mới chủ đề
        public static bool ThemChuDe(ChuDeDTO cd)
        {
            return ChuDeDAL.ThemChuDe(cd);
        }

        //Hàm tìm chủ đề theo mã
        public static ChuDeDTO TimChuDeTheoMa(string ma)
        {
            return ChuDeDAL.TimChuDeTheoMa(ma);
        }

        //Hàm sửa thông tin chủ đề
        public static bool CapNhatThongTinChuDe(ChuDeDTO cd)
        {
            return ChuDeDAL.CapNhatThongTinChuDe(cd);
        }

        //Hàm xóa thông tin chủ đề
        public static bool XoaThongTinChuDe(ChuDeDTO cd)
        {
            return ChuDeDAL.XoaThongTinChuDe(cd);
        }
        /*
        public static List<HoaDonDTO> LayTKPL()
        {
            return ChuDeDAL.LayTKPL();
        }
        */
    }
}
