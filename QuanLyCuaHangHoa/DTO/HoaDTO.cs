using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDTO
    {
        private string sMaHoa;
        private string sTenHoa;
        private string sMaChuDe;
        private int sSoLuong;
        private float sDonGiaNhap;
        private float sDonGiaBan;
        private string sAnh;
        private string sGhiChu;

        public string SMaHoa { get => sMaHoa; set => sMaHoa = value; }
        public string STenHoa { get => sTenHoa; set => sTenHoa = value; }
        public string SMaChuDe { get => sMaChuDe; set => sMaChuDe = value; }
        public int SSoLuong { get => sSoLuong; set => sSoLuong = value; }
        public float SDonGiaNhap { get => sDonGiaNhap; set => sDonGiaNhap = value; }
        public float SDonGiaBan { get => sDonGiaBan; set => sDonGiaBan = value; }
        public string SAnh { get => sAnh; set => sAnh = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
