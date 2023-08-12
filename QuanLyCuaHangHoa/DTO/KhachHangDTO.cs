using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string sMaKhach;
        private string sTenKhach;
        private string sDiaChi;
        private string sDienThoai;

        public string SMaKhach { get => sMaKhach; set => sMaKhach = value; }
        public string STenKhach { get => sTenKhach; set => sTenKhach = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SDienThoai { get => sDienThoai; set => sDienThoai = value; }
    }
}
