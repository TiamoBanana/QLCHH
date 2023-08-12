using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKePLBLL
    {
        public static List<ThongKePLDTO> LayTKPL()
        {
            return ThongKePLDAL.LayTKPL();
        }
    }
}
