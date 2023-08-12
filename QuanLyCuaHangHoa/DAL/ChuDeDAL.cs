using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChuDeDAL
    {
        static SqlConnection Conn;
        public static List<ChuDeDTO> LayDanhSachChuDe()
        {
            string sTruyVan = "SELECT *FROM CHUDE";
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChuDeDTO> lstChuDe = new List<ChuDeDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChuDeDTO cd = new ChuDeDTO();
                cd.SMaChuDe = dt.Rows[i]["MACHUDE"].ToString();
                cd.STenChuDe = dt.Rows[i]["TENCHUDE"].ToString();
                lstChuDe.Add(cd);
            }
            DataProvider.CloseConnection(Conn);
            return lstChuDe;
        }

        //Hàm thêm chủ đề
        public static bool ThemChuDe(ChuDeDTO cd)
        {
            string sTruyVan = string.Format(@"INSERT INTO CHUDE VALUES(N'{0}',
                N'{1}')", cd.SMaChuDe, cd.STenChuDe);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm tìm chủ đề theo mã
        public static ChuDeDTO TimChuDeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT *FROM CHUDE WHERE MACHUDE=N'{0}'", ma);
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            // Nếu có chuyển dữ liệu thành kiểu ChuDeDTO
            ChuDeDTO cd = new ChuDeDTO();
            cd.SMaChuDe = dt.Rows[0]["MACHUDE"].ToString();
            cd.STenChuDe = dt.Rows[0]["TENCHUDE"].ToString();
        
            DataProvider.CloseConnection(Conn);
            return cd;
        }

        //Hàm sửa thông tin chủ đề
        public static bool CapNhatThongTinChuDe(ChuDeDTO cd)
        {
            string sTruyVan = string.Format(@"UPDATE CHUDE SET TENCHUDE=N'{0}' WHERE MACHUDE=N'{1}'", cd.STenChuDe, cd.STenChuDe);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm xóa thông tin chủ đề
        public static bool XoaThongTinChuDe(ChuDeDTO cd)
        {
            string sTruyVan = string.Format(@"DELETE FROM CHUDE WHERE MACHUDE=N'{0}'", cd.SMaChuDe);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        /*
        public static List<HoaDonDTO> LayTKPL()
        {
            string sql = @"select tenchude, count(hh.mahoa) as SL from chude pl, hoa hh 
                        where hh.machude = pl.machude group by tenchude";
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHD = dt.Rows[i]["tenchude"].ToString();
                hd.DTongTien = int.Parse(dt.Rows[i]["SL"].ToString());
                lstHoaDon.Add(hd);
            }
            Conn.Close();
            return lstHoaDon;
        }
        */
    }
}
