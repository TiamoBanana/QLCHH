using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        //Hàm hiển thị danh sách khách hàng
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return NhanVienDAL.LayDanhSachNhanVien();
        }

        //Hàm thêm mới nhân viên
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAL.ThemNhanVien(nv);
        }

        //Hàm tìm nhân viên theo mã
        public static NhanVienDTO TimNhanVienTheoMa(string ma)
        {
            return NhanVienDAL.TimNhanVienTheoMa(ma);
        }

        //Hàm sửa thông tin nhân viên
        public static bool CapNhatThongTinNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAL.CapNhatThongTinNhanVien(nv);
        }

        //Hàm xóa thông tin nhân viên
        public static bool XoaThongTinNhanVien(NhanVienDTO nv)
        {
            return NhanVienDAL.XoaThongTinNhanVien(nv);
        }
    }
}
