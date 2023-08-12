using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeDTO
    {
        private string tenKhachHang;
        private DateTime ngayBan;
        private double tongTien;

        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
