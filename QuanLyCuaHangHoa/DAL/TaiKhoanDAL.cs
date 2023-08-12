using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {
        static SqlConnection conn;
        //Hàm lấy danh sách nhân viên
        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            string sTruyVan = "SELECT * FROM TAIKHOAN";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoanDTO> lstTK = new List<TaiKhoanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = dt.Rows[i]["TENDANGNHAP"].ToString();
                tk.SMatKhau = dt.Rows[i]["MATKHAU"].ToString();
                tk.SNguoiDung = dt.Rows[i]["NGUOIDUNG"].ToString();
                tk.SQuyenHan = dt.Rows[i]["QUYENHAN"].ToString();
                tk.SAnh = dt.Rows[i]["ANH"].ToString();


                lstTK.Add(tk);
            }
            DataProvider.CloseConnection(conn);

            return lstTK;
        }
        public static TaiKhoanDTO LayTaiKhoan(string tenDN, string matKhau)
        {
            string sTruyVan = string.Format("SELECT * FROM TAIKHOAN WHERE TENDANGNHAP=N'{0}' AND MATKHAU=N'{1}' ORDER BY TENDANGNHAP DESC", tenDN, matKhau);
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.STenDangNhap = dt.Rows[0]["TENDANGNHAP"].ToString();
            tk.SMatKhau = dt.Rows[0]["MATKHAU"].ToString();
            tk.SNguoiDung = dt.Rows[0]["NGUOIDUNG"].ToString();
            tk.SQuyenHan = dt.Rows[0]["QUYENHAN"].ToString();
            tk.SAnh = dt.Rows[0]["ANH"].ToString();
            conn.Close();
            return tk;
        }
        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            string sql = string.Format(@"INSERT INTO TAIKHOAN VALUES(N'{0}', N'{1}',N'{2}',N'{3}','{4}')",
            tk.STenDangNhap, tk.SMatKhau, tk.SNguoiDung, tk.SQuyenHan, tk.SAnh);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static TaiKhoanDTO TimTaiKhoanTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT * FROM TAIKHOAN WHERE TENDANGNHAP=N'{0}'", ma);
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu TaiKhoanDTO
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.STenDangNhap = dt.Rows[0]["TENDANGNHAP"].ToString();
            tk.SMatKhau = dt.Rows[0]["MATKHAU"].ToString();
            tk.SNguoiDung = dt.Rows[0]["NGUOIDUNG"].ToString();
            tk.SQuyenHan = dt.Rows[0]["QUYENHAN"].ToString();
            tk.SAnh = dt.Rows[0]["ANH"].ToString();
            conn.Close();
            return tk;
        }
        public static bool CapNhatTaiKhoan(TaiKhoanDTO tk)
        {
            string sTruyVan = string.Format(@"UPDATE TAIKHOAN SET  MATKHAU=N'{0}',
                NGUOIDUNG=N'{1}', QUYENHAN=N'{2}', ANH=N'{3}' WHERE TENDANGNHAP = N'{4}'",
                tk.SMatKhau, tk.SNguoiDung, tk.SQuyenHan, tk.SAnh, tk.STenDangNhap);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }

        public static bool XoaTaiKhoan(TaiKhoanDTO tk)
        {
            string sTruyVan = string.Format(@"DELETE FROM TAIKHOAN WHERE TENDANGNHAP=N'{0}'", tk.STenDangNhap);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static bool DoiMatKhau(TaiKhoanDTO tk)
        {
            string sTruyVan = string.Format(@"UPDATE TAIKHOAN SET MATKHAU = N'{0}' WHERE TENDANGNHAP=N'{1}'",
            tk.SMatKhau, tk.STenDangNhap);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
    }
}
