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
    public class KhachHangDAL
    {
        static SqlConnection Conn;

        //Hàm lấy danh sách khách hàng
        public static List<KhachHangDTO> LayDanhSachKhachHang()
        {
            string sTruyVan = "SELECT * FROM KHACHHANG";
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHangDTO> lstKhachHang = new List<KhachHangDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.SMaKhach = dt.Rows[i]["MAKHACH"].ToString();
                kh.STenKhach = dt.Rows[i]["TENKHACH"].ToString();
                kh.SDiaChi = dt.Rows[i]["DIACHI"].ToString();
                kh.SDienThoai = dt.Rows[i]["DIENTHOAI"].ToString();
               
                lstKhachHang.Add(kh);
            }
            DataProvider.CloseConnection(Conn);

            return lstKhachHang;
        }

        //Hàm thêm khách hàng
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            string sTruyVan = string.Format(@"INSERT INTO KHACHHANG VALUES(N'{0}',
                N'{1}',N'{2}',N'{3}')", kh.SMaKhach, kh.STenKhach, kh.SDiaChi,
                kh.SDienThoai);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm tìm khách hàng theo mã
        public static KhachHangDTO TimKhachHangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT *FROM KHACHHANG WHERE MAKHACH=N'{0}'", ma);
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            // Nếu có chuyển dữ liệu thành kiểu KhachHangDTO
            KhachHangDTO kh = new KhachHangDTO();
            kh.SMaKhach = dt.Rows[0]["MAKHACH"].ToString();
            kh.STenKhach = dt.Rows[0]["TENKHACH"].ToString();
            kh.SDiaChi = dt.Rows[0]["DIACHI"].ToString();
            kh.SDienThoai = dt.Rows[0]["DIENTHOAI"].ToString();
            DataProvider.CloseConnection(Conn);
            return kh;
        }

        //Hàm sửa thông tin khách hàng
        public static bool CapNhatThongTinKhachHang(KhachHangDTO kh)
        {
            string sTruyVan = string.Format(@"UPDATE KHACHHANG SET TENKHACH=N'{0}',
                DIACHI=N'{1}',DIENTHOAI=N'{2}'WHERE MAKHACH=N'{3}'",
                kh.STenKhach, kh.SDiaChi, kh.SDienThoai, kh.SMaKhach);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm xóa thông tin khách hàng
        public static bool XoaThongTinKhachHang(KhachHangDTO kh)
        {
            string sTruyVan = string.Format(@"DELETE FROM KHACHHANG WHERE MAKHACH=N'{0}'", kh.SMaKhach);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm tìm kiếm mã khách hàng và tên khách hàng dựa trên sự kiện gõ liên tục
        public static List<KhachHangDTO> TimKhachHang(string valueToFind)
        {
            string sTruyVan = string.Format(@"SELECT * FROM KHACHHANG WHERE TENKHACH LIKE N'%{0}%' or makhach like N'%{0}%'", valueToFind);
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<KhachHangDTO> lstKhachHang = new List<KhachHangDTO>();
            // Nếu có chuyển dữ liệu thành kiểu KhachHangDTO
            for(int i = 0; i< dt.Rows.Count; i++)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.SMaKhach = dt.Rows[0]["MAKHACH"].ToString();
                kh.STenKhach = dt.Rows[0]["TENKHACH"].ToString();
                kh.SDiaChi = dt.Rows[0]["DIACHI"].ToString();
                kh.SDienThoai = dt.Rows[0]["DIENTHOAI"].ToString();
                lstKhachHang.Add(kh);
            }
            DataProvider.CloseConnection(Conn);
            return lstKhachHang;
            
        }

    }
}
