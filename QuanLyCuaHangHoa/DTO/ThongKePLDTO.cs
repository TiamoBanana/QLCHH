using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKePLDTO
    {
        string tenPhanLoai;
        int soLuong;

        public string TenPhanLoai { get => tenPhanLoai; set => tenPhanLoai = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
