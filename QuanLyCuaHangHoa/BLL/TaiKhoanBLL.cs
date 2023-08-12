using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        public static List<TaiKhoanDTO> LayTaiKhoan()
        {
            return TaiKhoanDAL.LayDanhSachTaiKhoan();
        }
        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAL.ThemTaiKhoan(tk);
        }
        public static TaiKhoanDTO TimTaiKhoanTheoMa(string ma)
        {
            return TaiKhoanDAL.TimTaiKhoanTheoMa(ma);
        }
        public static TaiKhoanDTO LayTaiKhoan(string tenDN, string matKhau)
        {
            
            return TaiKhoanDAL.LayTaiKhoan(tenDN, matKhau);
        }
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAL.CapNhatTaiKhoan(tk);
        }
        public static bool XoaTaiKhoan(TaiKhoanDTO tk)
        {
            return TaiKhoanDAL.XoaTaiKhoan(tk);
        }
        public static bool DoiMatKhau(TaiKhoanDTO tk)
        {
            return TaiKhoanDAL.DoiMatKhau(tk);
        }
    }
}
