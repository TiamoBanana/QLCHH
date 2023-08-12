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
    public class HoaDonDAL
    {
        static SqlConnection conn;
        public static List<HoaDonDTO> LayDSHoaDon()
        {
            string sTruyVan = "SELECT * FROM HOADON";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHoaDon = dt.Rows[i]["MAHOADON"].ToString();
                hd.SMaNhanVien = dt.Rows[i]["MANHANVIEN"].ToString();
                hd.SMaKhach = dt.Rows[i]["MAKHACH"].ToString();
                hd.DNgayBan = DateTime.Parse(dt.Rows[i]["NGAYBAN"].ToString());
                hd.SMaHoa = dt.Rows[i]["MAHOA"].ToString();
     
                hd.ISoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                hd.FDonGia = float.Parse(dt.Rows[i]["DONGIA"].ToString());
                hd.SThanhtien = float.Parse(dt.Rows[i]["THANHTIEN"].ToString());

                lstHoaDon.Add(hd);
            }
            DataProvider.CloseConnection(conn);
            return lstHoaDon;
        }
        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            string sTruyVan = string.Format(@"INSERT INTO HOADON VALUES(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                , hd.SMaHoaDon, hd.SMaNhanVien, hd.SMaKhach, hd.DNgayBan, hd.SMaHoa, hd.ISoLuong, hd.FDonGia, hd.SThanhtien);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.CloseConnection(conn);
            return kq;
        }
        public static HoaDonDTO TimHoaDonTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT * FROM HOADON WHERE MAHOADON=N'{0}'", ma);
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu HoaDonDTO
            HoaDonDTO hd = new HoaDonDTO();
            hd.SMaHoaDon = dt.Rows[0]["MAHOADON"].ToString();
            hd.SMaNhanVien = dt.Rows[0]["MANHANVIEN"].ToString();
            hd.SMaKhach = dt.Rows[0]["MAKHACH"].ToString();
            hd.DNgayBan = DateTime.Parse(dt.Rows[0]["NGAYBAN"].ToString());
            hd.SMaHoa = dt.Rows[0]["MAHOA"].ToString();

            hd.ISoLuong = int.Parse(dt.Rows[0]["SOLUONG"].ToString());
            hd.FDonGia = float.Parse(dt.Rows[0]["DONGIA"].ToString());
            hd.SThanhtien = float.Parse(dt.Rows[0]["THANHTIEN"].ToString());
            DataProvider.CloseConnection(conn);
            return hd;
        }
        public static bool SuaHoaDon(HoaDonDTO hd)
        {
            string sTruyVan = string.Format(@"UPDATE HOADON SET MANHANVIEN=N'{0}', MAKHACH=N'{1}',NGAYBAN=N'{2}',MAHOA=N'{3}',SOLUONG=N'{4}',DONGIA=N'{5}',THANHTIEN=N'{6}'
            WHERE MAHOADON=N'{7}'", hd.SMaNhanVien, hd.SMaKhach, hd.DNgayBan, hd.SMaHoa, hd.ISoLuong, hd.FDonGia, hd.SThanhtien, hd.SMaHoaDon);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.CloseConnection(conn);
            return kq;
        }
        public static bool XoaHoaDon(HoaDonDTO hd)
        {
            string sTruyVan = string.Format(@"DELETE FROM HOADON
            WHERE MAHOADON='{0}'", hd.SMaHoaDon);
            conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            DataProvider.CloseConnection(conn);
            return kq;
        }
        /*public static List<HoaDonDTO> DoanhThuThang()
        {
            string sql = @"select MONTH(NGAYBAN) as Thang, SUM(TONGTIEN) as TongTIen from HOADON group by MONTH(NgayBan)";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaKhach = dt.Rows[i]["thang"].ToString();
                hd.DTongTien = double.Parse(dt.Rows[i]["tongtien"].ToString());
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }*/
     
    }
}
