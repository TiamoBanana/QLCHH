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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        #region Tạo mã
        public static string CreateKey(string keyvalue)
        {
            string key = keyvalue;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');//cắt chuỗi ngày tháng
                                                                   //Ví dụ 12/13/2021
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;//HDB+12132021
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');//cắt chuỗi thời gian
                                                                   //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")//nếu thời gian là PM từ thực hiện convertimeto24
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];//từ 1-9 thì hiển thị là 01,...09.
                                                      //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            //ví dụ 9:23:00AM

            key = key + t;//key = HDB+12132021_092300
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        #endregion
        private void HienThiNhanVienLenCombobox()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBLL.LayDanhSachNhanVien();
            cboNhanVien.DataSource = lstNhanVien;
            cboNhanVien.DisplayMember = "STenNhanVien";
            cboNhanVien.ValueMember = "SMaNhanVien";
        }
        private void HienThiKhachHangLenCombobox()
        {
            List<KhachHangDTO> lstKhachHang = KhachHangBLL.LayDanhSachKhachHang();
            cboKhachHang.DataSource = lstKhachHang;
            cboKhachHang.DisplayMember = "STenKhach";
            cboKhachHang.ValueMember = "SMaKhach";
        }
        private void HienThiHoaLenCombobox()
        {
            List<HoaDTO> lstHoa = HoaBLL.LayDanhSachHoa();
            cboHoa.DataSource = lstHoa;
            cboHoa.DisplayMember = "STenHoa";
            cboHoa.ValueMember = "SMaHoa";
        }
        void TinhThanhTien()
        {
            double sl, dg;
            if (numSoLuong.Value.ToString() == "")
                sl = 0;
            else
                sl = Convert.ToDouble(numSoLuong.Value.ToString());
            
            if (numDonGia.Value.ToString() == "")
                dg = 0;
            else
                dg = Convert.ToDouble(numDonGia.Value.ToString());
            txtThanhToan.Text = (sl * dg).ToString();
        }
        private void HienThiDanhSachHoaDon()
        {
            List<HoaDonDTO> lstHoaDon = HoaDonBLL.LayDSHoaDon();
            dgvHoaDon.DataSource = lstHoaDon;
            dgvHoaDon.Columns["SMaHoaDon"].HeaderText = "ID Bill";
            dgvHoaDon.Columns["SMaNhanVien"].HeaderText = "Staff";
            dgvHoaDon.Columns["SMaKhach"].HeaderText = "Customer";
            dgvHoaDon.Columns["DNgayBan"].HeaderText = "Date";
            dgvHoaDon.Columns["SMaHoa"].HeaderText = "Flower";
            dgvHoaDon.Columns["ISoLuong"].HeaderText = "Amount";
            dgvHoaDon.Columns["FDonGia"].HeaderText = "Price";
            dgvHoaDon.Columns["SThanhtien"].HeaderText = "Payment";

            dgvHoaDon.Columns["SThanhtien"].DefaultCellStyle.Format = "#,### VNĐ";
            dgvHoaDon.Columns["FDonGia"].DefaultCellStyle.Format = "#,### VND";
            

            dgvHoaDon.Columns["SMaHoaDon"].Width = 40;
            dgvHoaDon.Columns["SMaNhanVien"].Width = 30;
            dgvHoaDon.Columns["SMaKhach"].Width = 40;
            dgvHoaDon.Columns["DNgayBan"].Width = 30;
            dgvHoaDon.Columns["SMaHoa"].Width = 30;
            dgvHoaDon.Columns["ISoLuong"].Width = 25;
            dgvHoaDon.Columns["FDonGia"].Width = 35;
            dgvHoaDon.Columns["SThanhtien"].Width = 60;
            

            dgvHoaDon.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemMoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHoaDon.Focus();
                return;
            }

            txtMaHoaDon.Text = dgvHoaDon.CurrentRow.Cells["SMaHoaDon"].Value.ToString();
            cboNhanVien.SelectedValue = dgvHoaDon.CurrentRow.Cells["SMaNhanVien"].Value.ToString();
            cboKhachHang.SelectedValue = dgvHoaDon.CurrentRow.Cells["SMaKhach"].Value.ToString();
            dtpNgayBan.Text = dgvHoaDon.CurrentRow.Cells["DNgayBan"].Value.ToString();
            cboHoa.SelectedValue = dgvHoaDon.CurrentRow.Cells["SMaHoa"].Value.ToString();
            numSoLuong.Value = decimal.Parse(dgvHoaDon.CurrentRow.Cells["ISoLuong"].Value.ToString());
            numDonGia.Value = decimal.Parse(dgvHoaDon.CurrentRow.Cells["FDonGia"].Value.ToString());
            txtThanhToan.Text = dgvHoaDon.CurrentRow.Cells["SThanhtien"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = CreateKey("HDB");
            cboNhanVien.SelectedIndex = 0;
            cboKhachHang.SelectedIndex = 0;
            dtpNgayBan.Value = DateTime.Now;
            cboHoa.SelectedIndex = 0;
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            txtThanhToan.Text = "";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void numDonGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "" || numDonGia.Value == 0 || numSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập các thông tin liên quan về sản phẩm khách hàng đã mua cho hóa đơn (mã hóa đơn, đơn giá, số lượng)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HoaDonDTO hd = new HoaDonDTO();
            hd.SMaHoaDon = txtMaHoaDon.Text;
            hd.SMaNhanVien = cboNhanVien.SelectedValue.ToString();
            hd.SMaKhach = cboKhachHang.SelectedValue.ToString();
            hd.DNgayBan = DateTime.Parse(dtpNgayBan.Text);
            hd.SMaHoa = cboHoa.SelectedValue.ToString();
            hd.ISoLuong = int.Parse(numSoLuong.Value.ToString());
            hd.FDonGia = float.Parse(numDonGia.Value.ToString());
            hd.SThanhtien = float.Parse(txtThanhToan.Text);

            if (HoaDonBLL.ThemHoaDon(hd) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            HienThiDanhSachHoaDon();
            MessageBox.Show("Đã thêm hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HoaDon1_Load(object sender, EventArgs e)
        {
            HienThiNhanVienLenCombobox();
            HienThiKhachHangLenCombobox();
            HienThiHoaLenCombobox();

            HienThiDanhSachHoaDon();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "" || txtThanhToan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            HoaDonDTO hd = new HoaDonDTO();
            hd.SMaHoaDon = txtMaHoaDon.Text;
            hd.SMaNhanVien = cboNhanVien.SelectedValue.ToString();
            hd.SMaKhach = cboKhachHang.SelectedValue.ToString();
            hd.DNgayBan = DateTime.Parse(dtpNgayBan.Text);
            hd.SMaHoa = cboHoa.SelectedValue.ToString();
            hd.ISoLuong = int.Parse(numSoLuong.Value.ToString());
            hd.FDonGia = float.Parse(numDonGia.Value.ToString());
            hd.SThanhtien = float.Parse(txtThanhToan.Text);

            if (HoaDonBLL.SuaHoaDon(hd) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            HienThiDanhSachHoaDon();
            MessageBox.Show("Đã sửa hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Thông báo",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.SMaHoaDon = txtMaHoaDon.Text;
                if (HoaDonBLL.XoaHoaDon(hd) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienThiDanhSachHoaDon();
                MessageBox.Show("Đã xóa hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = CreateKey("HDB");
            cboNhanVien.SelectedIndex = 0;
            cboKhachHang.SelectedIndex = 0;
            dtpNgayBan.Value = DateTime.Now;
            cboHoa.SelectedIndex = 0;
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            txtThanhToan.Text = "";

            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            txtMaHoaDon.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<HoaDonDTO> ds = HoaDonBLL.LayDSHoaDon();
            List<HoaDonDTO> kq = (from hd in ds
                                     where hd.SMaNhanVien.Contains(txtTimKiemMaNhanVien.Text)
                                     where hd.SMaHoa.Contains(txtTimKiemMaHoa.Text)
                                     select hd).ToList();
            dgvHoaDon.DataSource = kq;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            ReportHoaDon bc = new ReportHoaDon();
            bc.ShowDialog();
        }
    }
}
