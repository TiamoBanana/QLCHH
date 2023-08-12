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
    public class NhanVienDAL
    {
        static SqlConnection Conn;
        //Hàm lấy danh sách nhân viên
        public static List<NhanVienDTO> LayDanhSachNhanVien()
        {
            string sTruyVan = "SELECT * FROM NHANVIEN";
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNhanVien = dt.Rows[i]["MANHANVIEN"].ToString();
                nv.STenNhanVien = dt.Rows[i]["TENNHANVIEN"].ToString();
                nv.SGioiTinh = dt.Rows[i]["GIOITINH"].ToString();
                nv.SDiaChi = dt.Rows[i]["DIACHI"].ToString();
                nv.SDienThoai = dt.Rows[i]["DIENTHOAI"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NGAYSINH"].ToString());

                lstNhanVien.Add(nv);
            }
            DataProvider.CloseConnection(Conn);

            return lstNhanVien;
        }

        //Hàm thêm nhân viên
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"INSERT INTO NHANVIEN VALUES(N'{0}',
                N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", nv.SMaNhanVien, nv.STenNhanVien, nv.SGioiTinh,
               nv.SDiaChi, nv.SDienThoai, nv.DtNgaySinh);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm tìm khách hàng theo mã
        public static NhanVienDTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"SELECT *FROM NHANVIEN WHERE MANHANVIEN=N'{0}'", ma);
            Conn = DataProvider.OpenConnection();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNhanVien = dt.Rows[0]["MANHANVIEN"].ToString();
            nv.STenNhanVien = dt.Rows[0]["TENNHANVIEN"].ToString();
            nv.SGioiTinh = dt.Rows[0]["GIOITINH"].ToString();
            nv.SDiaChi = dt.Rows[0]["DIACHI"].ToString();
            nv.SDienThoai = dt.Rows[0]["DIENTHOAI"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["NGAYSINH"].ToString());
            DataProvider.CloseConnection(Conn);
            return nv;
        }

        //Hàm sửa thông tin nhân viên
        public static bool CapNhatThongTinNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"UPDATE NHANVIEN SET TENNHANVIEN=N'{0}',
                GIOITINH=N'{1}',DIACHI=N'{2}', DIENTHOAI=N'{3}', NGAYSINH=N'{4}' WHERE MANHANVIEN=N'{5}'",
                nv.STenNhanVien, nv.SGioiTinh, nv.SDiaChi, nv.SDienThoai, nv.DtNgaySinh, nv.SMaNhanVien);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

        //Hàm xóa thông tin nhân viên
        public static bool XoaThongTinNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"DELETE FROM NHANVIEN WHERE MANHANVIEN=N'{0}'", nv.SMaNhanVien);
            Conn = DataProvider.OpenConnection();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, Conn);
            DataProvider.CloseConnection(Conn);
            return kq;
        }

    }
}

