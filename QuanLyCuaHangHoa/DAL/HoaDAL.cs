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
    public class HoaDAL
    {
        static SqlConnection Conn;
        //Hàm lấy danh sách hoa
        public static List<HoaDTO> LayDanhSachHoa()
        {
            string sTruyVan = "SELECT * FROM HOA";
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDTO> lstHoa = new List<HoaDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDTO h = new HoaDTO();
                h.SMaHoa = dt.Rows[i]["MAHOA"].ToString();
                h.STenHoa = dt.Rows[i]["TENHOA"].ToString();
                h.SMaChuDe = dt.Rows[i]["MACHUDE"].ToString();
                h.SSoLuong = int.Parse(dt.Rows[i]["SOLUONG"].ToString());
                h.SDonGiaNhap = float.Parse(dt.Rows[i]["DONGIANHAP"].ToString());
                h.SDonGiaBan = float.Parse(dt.Rows[i]["DONGIABAN"].ToString());
                h.SAnh = dt.Rows[i]["ANH"].ToString();
                h.SGhiChu = dt.Rows[i]["GHICHU"].ToString();

                lstHoa.Add(h);
            }
            DataProvider.CloseConnection(Conn);

            return lstHoa;
        }

        //Hàm thêm hoa
        public static bool ThemHoa(HoaDTO h)
        {
            string sTruyVan = string.Format(@"INSERT INTO HOA VALUES(N'{0}',
                N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", h.SMaHoa, h.STenHoa, h.SMaChuDe,
                h.SSoLuong, h.SDonGiaNhap, h.SDonGiaBan, h.SAnh, h.SGhiChu);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm tìm hoa theo mã
        public static HoaDTO TimHoaTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT *FROM HOA WHERE MAHOA=N'{0}'", ma);
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            // Nếu có chuyển dữ liệu thành kiểu HoaDTO
            HoaDTO h = new HoaDTO();
            h.SMaHoa = dt.Rows[0]["MAHOA"].ToString();
            h.STenHoa = dt.Rows[0]["TENHOA"].ToString();
            h.SMaChuDe = dt.Rows[0]["MACHUDE"].ToString();
            h.SSoLuong = int.Parse(dt.Rows[0]["SOLUONG"].ToString());
            h.SDonGiaNhap = float.Parse(dt.Rows[0]["DONGIANHAP"].ToString());
            h.SDonGiaBan = float.Parse(dt.Rows[0]["DONGIABAN"].ToString());
            h.SAnh = dt.Rows[0]["ANH"].ToString();
            h.SGhiChu = dt.Rows[0]["GHICHU"].ToString();

            DataProvider.CloseConnection(Conn);
            return h;
        }

        //Hàm sửa thông tin hoa
        public static bool CapNhatThongTinHoa(HoaDTO h)
        {
            string sTruyVan = string.Format(@"UPDATE HOA SET TENHOA=N'{0}',
                MACHUDE=N'{1}',SOLUONG=N'{2}' ,DONGIANHAP=N'{3}' ,DONGIABAN=N'{4}' ,ANH=N'{5}' ,GHICHU=N'{6}' WHERE MAHOA=N'{7}'",
                h.STenHoa, h.SMaChuDe, h.SSoLuong, h.SDonGiaNhap, h.SDonGiaBan, h.SAnh, h.SGhiChu, h.SMaHoa);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm xóa thông tin HOA
        public static bool XoaThongTinHoa(HoaDTO h)
        {
            string sTruyVan = string.Format(@"DELETE FROM HOA WHERE MAHOA=N'{0}'", h.SMaHoa);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }
    }
}
