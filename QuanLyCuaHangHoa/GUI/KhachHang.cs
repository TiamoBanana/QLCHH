using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhach.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;

            HienThiDanhSachKhachHang();
        }

        private void HienThiDanhSachKhachHang()
        {
            List<KhachHangDTO> lstKhachHang = KhachHangBLL.LayDanhSachKhachHang();
            dgvKhachHang.DataSource = lstKhachHang;
            dgvKhachHang.Columns["SMaKhach"].HeaderText = "ID Client";
            dgvKhachHang.Columns["STenKhach"].HeaderText = "Client Name";
            dgvKhachHang.Columns["SDiaChi"].HeaderText = "Address";
            dgvKhachHang.Columns["SDienThoai"].HeaderText = "Phone Numbers";

            dgvKhachHang.Columns["SMaKhach"].Width = 80;
            dgvKhachHang.Columns["STenKhach"].Width = 150;
            dgvKhachHang.Columns["SDiaChi"].Width = 200;
            dgvKhachHang.Columns["SDienThoai"].Width = 100;

            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvKhachHang.AllowUserToAddRows = false;          
            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btnThemMoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }

            txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells["SMaKhach"].Value.ToString();
            txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells["STenKhach"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells["SDienThoai"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues();
            txtMaKhach.Enabled = true;
            txtMaKhach.Focus();
        }

        private void ResetValues()
        {
            txtMaKhach.Text = "KH0";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra các thông tin
            if (txtMaKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }

            //Kiểm tra mã trùng
            if (KhachHangBLL.TimKhachHangTheoMa(txtMaKhach.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại! Vui lòng chọn mã khác!");
                return;
            }

            // Gán dữ liệu vào kiểu KhachHangDTO
            KhachHangDTO kh = new KhachHangDTO();
            kh.SMaKhach = txtMaKhach.Text;
            kh.STenKhach = txtTenKhach.Text;
            kh.SDiaChi = txtDiaChi.Text;
            kh.SDienThoai = txtDienThoai.Text;

            // Thực hiện thêm
            if (KhachHangBLL.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            HienThiDanhSachKhachHang();
            MessageBox.Show("Đã thêm khách hàng thành công!");

            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }

            // Kiểm tra mã khách hàng có tồn tại không
            if (KhachHangBLL.TimKhachHangTheoMa(txtMaKhach.Text) == null)
            {
                MessageBox.Show("Mã khách hàng không tồn tại!");
                return;
            }

            // Gán dữ liệu vào kiểu KhachHangDTO
            KhachHangDTO kh = new KhachHangDTO();
            kh.SMaKhach = txtMaKhach.Text;
            kh.STenKhach = txtTenKhach.Text;
            kh.SDiaChi = txtDiaChi.Text;
            kh.SDienThoai = txtDienThoai.Text;

            // Thực hiện cập nhật
            if (KhachHangBLL.CapNhatThongTinKhachHang(kh) == false)
            {
                MessageBox.Show("Không cập nhật được!");
                return;
            }
            HienThiDanhSachKhachHang();
            MessageBox.Show("Đã cập nhật khách hàng!");

            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin khách hàng nao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá thông tin khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gán dữ liệu vào kiểu KhachHangDTO
                KhachHangDTO kh = new KhachHangDTO();
                kh.SMaKhach = txtMaKhach.Text;
                kh.STenKhach = txtTenKhach.Text;
                kh.SDiaChi = txtDiaChi.Text;
                kh.SDienThoai = txtDienThoai.Text;

                // Thực hiện xóa 
                if (KhachHangBLL.XoaThongTinKhachHang(kh) == false)
                {
                    MessageBox.Show("Không xóa được thông tin khách hàng!");
                    return;
                }
                HienThiDanhSachKhachHang();
                MessageBox.Show("Đã xóa thông tin khách hàng!");

                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaKhach.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<KhachHangDTO> ds = KhachHangBLL.LayDanhSachKhachHang();
            List<KhachHangDTO> kq = (from kh in ds
                                         where kh.SMaKhach.Contains(txtTimKiemMaKhachHang.Text)
                                         where kh.STenKhach.Contains(txtTimKiemTenKhachHang.Text)
                                         select kh).ToList();
             dgvKhachHang.DataSource = kq;
        }

        private void txtTimKiemMaKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtTimKiemTenKhachHang_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtTimKiemTenKhachHang_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtTimKiemTenKhachHang_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTimKiemMaKhachHang_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtTimKiemMaKhachHang_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
