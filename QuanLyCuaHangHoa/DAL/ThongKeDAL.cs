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
    public class ThongKeDAL
    {
        static SqlConnection conn;
    
        public static List<ThongKeDTO> DoanhThuThang()
        {
            string sql = @"SELECT MONTH(NGAYBAN) as THANG, SUM(THANHTIEN) as TONGTIEN from HOADON group by MONTH(NGAYBAN)";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongKeDTO> lstHoaDon = new List<ThongKeDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongKeDTO hd = new ThongKeDTO();
                hd.TenKhachHang = dt.Rows[i]["THANG"].ToString();
                hd.TongTien = double.Parse(dt.Rows[i]["TONGTIEN"].ToString());
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }
        public static string SoLuonggKhachHang()
        {
            conn = DataProvider.OpenConnection();
            string sql, sl = "";
            sql = "Select count(*) as sl from KHACHHANG";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                object value = reader.GetValue(reader.GetOrdinal("sl"));//chuyển kiểu dữ liệu từ float qua string
                sl = value.ToString();
            }
            conn.Close();
            return sl;
        }
        public static string SoLuonggNhanVien()
        {
            conn = DataProvider.OpenConnection();
            string sql, sl = "";
            sql = "Select count(*) as sl from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                object value = reader.GetValue(reader.GetOrdinal("sl"));//chuyển kiểu dữ liệu từ float qua string
                sl = value.ToString();
            }
            conn.Close();
            return sl;
        }
        public static string SoLuonggHangHoa()
        {
            conn = DataProvider.OpenConnection();
            string sql, sl = "";
            sql = "Select sum(soluong) as sl from hoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                object value = reader.GetValue(reader.GetOrdinal("sl"));//chuyển kiểu dữ liệu từ float qua string
                sl = value.ToString();
            }
            conn.Close();
            return sl;
        }
        public static string SoLuongHoaDon()
        {
            conn = DataProvider.OpenConnection();
            string sql, sl = "";
            sql = "Select count(*) as sl from hoadon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                object value = reader.GetValue(reader.GetOrdinal("sl"));//chuyển kiểu dữ liệu từ float qua string
                sl = value.ToString();
            }
            conn.Close();
            return sl;
        }
    }
}
