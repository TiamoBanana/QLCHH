using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CSDLBLL
    {
        public static bool SaoLuu(string sDuongDan)
        {
            return CSDLDAL.SaoLuuDuLieu(sDuongDan);
        }

    }
}
