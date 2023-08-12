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
    public class ThongKePLDAL
    {
        static SqlConnection conn;
        public static List<ThongKePLDTO> LayTKPL()
        {
            string sql = @"select tenchude, count(h.mahoa) as SL from CHUDE pl, HOA h 
                        where h.machude = pl.machude group by tenchude";
            conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongKePLDTO> lstHoaDon = new List<ThongKePLDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongKePLDTO hd = new ThongKePLDTO();
                hd.TenPhanLoai = dt.Rows[i]["tenchude"].ToString();
                hd.SoLuong = int.Parse(dt.Rows[i]["SL"].ToString());
                lstHoaDon.Add(hd);
            }
            conn.Close();
            return lstHoaDon;
        }
    }
}
