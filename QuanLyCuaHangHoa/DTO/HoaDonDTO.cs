using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string sMaHoaDon;
        private string sMaNhanVien;
        private string sMaKhach;
        private DateTime dNgayBan;
        private string sMaHoa;
        private int iSoLuong;
        private float fDonGia;
        private float sThanhtien;

        public string SMaHoaDon { get => sMaHoaDon; set => sMaHoaDon = value; }
        public string SMaNhanVien { get => sMaNhanVien; set => sMaNhanVien = value; }
        public string SMaKhach { get => sMaKhach; set => sMaKhach = value; }
        public DateTime DNgayBan { get => dNgayBan; set => dNgayBan = value; }
        public string SMaHoa { get => sMaHoa; set => sMaHoa = value; }
        public int ISoLuong { get => iSoLuong; set => iSoLuong = value; }
        public float FDonGia { get => fDonGia; set => fDonGia = value; }
        public float SThanhtien { get => sThanhtien; set => sThanhtien = value; }
    }
}
