using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            HienThiThongTin();
        }
        public void HienThiThongTin()
        {
           
            lblKhachHang.Text = ThongKeBLL.slKhachHang();
            lblNhanVien.Text = ThongKeBLL.slNhanVien();
            lblHoa.Text = ThongKeBLL.slHangHoa();
            lblHoaDon.Text = ThongKeBLL.slHoaDon();
        }
        private void HienThiChartPL()
        {
            List<ThongKePLDTO> lst = ThongKePLBLL.LayTKPL();
            ChartPhanLoai.DataSource = lst;
            for (int i = 0; i < lst.Count; i++)
            {
                ChartPhanLoai.Series[0].XValueMember = "TenPhanLoai";
                ChartPhanLoai.Series[0].YValueMembers = "SoLuong";
            }
        }
        private void HienThiChartDoanhThu()
        {
            List<ThongKeDTO> lst = ThongKeBLL.DoanhThuThang();
            for (int i = 0; i < lst.Count; i++)
            {
                ChartDoanhThu.Series[0].Points.AddXY(lst[i].TenKhachHang, lst[i].TongTien / 1000000);
                ChartDoanhThu.Series[0].Points[i].Label = (lst[i].TongTien / 1000000).ToString() + " M";
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            HienThiThongTin();
            HienThiChartPL();
            HienThiChartDoanhThu();
            
        }
    }
}
