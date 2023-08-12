using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CSDLDAL
    {
        static SqlConnection con;
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QLCHH(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLCHH TO DISK = N'" + sDuongDan +
           sTen + "'";
            con = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
