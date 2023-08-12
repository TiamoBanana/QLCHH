using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {

        //Hàm hiển thị danh sách khách hàng
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return KhachHangDAL.LayDanhSachKhachHang();
        }

        //Hàm thêm mới nhân viên
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAL.ThemKhachHang(kh);
        }

        //Hàm tìm khách hàng theo mã
        public static KhachHangDTO TimKhachHangTheoMa(string ma)
        {
            return KhachHangDAL.TimKhachHangTheoMa(ma);
        }

        //Hàm sửa thông tin khách hàng
        public static bool CapNhatThongTinKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAL.CapNhatThongTinKhachHang(kh);
        }

        //Hàm xóa thông tin khách hàng
        public static bool XoaThongTinKhachHang(KhachHangDTO kh)
        {
            return KhachHangDAL.XoaThongTinKhachHang(kh);
        }

        //Hàm tìm kiếm thông tin khách hàng theo mã và tên
        public static List<KhachHangDTO> TimKhachHang(string valueToFind)
        {
            return KhachHangDAL.TimKhachHang(valueToFind);
        }
    }
}
