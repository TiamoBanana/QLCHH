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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();

        }

        //Hàm load dữ liệu nhân viên
        private void HienThiDanhSachNhanVien()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBLL.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = lstNhanVien;
            dgvNhanVien.Columns["SMaNhanVien"].HeaderText = "ID Staff";
            dgvNhanVien.Columns["STenNhanVien"].HeaderText = "Staff Name";
            dgvNhanVien.Columns["SGioiTinh"].HeaderText = "Sex";
            dgvNhanVien.Columns["SDiaChi"].HeaderText = "Address";
            dgvNhanVien.Columns["SDienThoai"].HeaderText = "Phone NumBers";
            dgvNhanVien.Columns["DtNgaySinh"].HeaderText = "Date Of Birth";

            dgvNhanVien.Columns["SMaNhanVien"].Width = 80;
            dgvNhanVien.Columns["STenNhanVien"].Width = 150;
            dgvNhanVien.Columns["SGioiTinh"].Width = 40;
            dgvNhanVien.Columns["SDiaChi"].Width = 200;
            dgvNhanVien.Columns["SDienThoai"].Width = 100;
            dgvNhanVien.Columns["DtNgaySinh"].Width = 100;

            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["SMaNhanVien"].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells["STenNhanVien"].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells["SGioiTinh"].Value.ToString() == "Male")
                radGioiTinhNam.Checked = true;
            else
                radGioiTinhNu.Checked = true;
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["SDienThoai"].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["DtNgaySinh"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;


        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues();
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Focus();
        }

        private void ResetValues()
        {
            txtMaNhanVien.Text = "NV0";
            txtTenNhanVien.Text = "";
            radGioiTinhNam.Checked = false;
            radGioiTinhNu.Checked = false;
            txtDiaChi.Text = "";
            dtpNgaySinh.Text = "";
            txtDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra các thông tin
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
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
            if (dtpNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Focus();
                return;
            }

            //Kiểm tra mã trùng
            if (NhanVienBLL.TimNhanVienTheoMa(txtMaNhanVien.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng chọn mã khác!");
                return;
            }

            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNhanVien = txtMaNhanVien.Text;
            nv.STenNhanVien = txtTenNhanVien.Text;
            if (radGioiTinhNam.Checked == true)
            {
                nv.SGioiTinh = "Male";
            }
            else
            {
                nv.SGioiTinh = "Female";
            }
            nv.SDiaChi = txtDiaChi.Text;
            nv.SDienThoai = txtDienThoai.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            // Thực hiện thêm
            if (NhanVienBLL.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            HienThiDanhSachNhanVien();
            MessageBox.Show("Đã thêm nhân viên thành công!");

            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhanVien.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
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
            if (dtpNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgaySinh.Focus();
                return;
            }

            // Kiểm tra mã nhân viên có tồn tại không
            if (NhanVienBLL.TimNhanVienTheoMa(txtMaNhanVien.Text) == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }

            // Gán dữ liệu vào kiểu KhachHangDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNhanVien = txtMaNhanVien.Text;
            nv.STenNhanVien = txtTenNhanVien.Text;
            if (radGioiTinhNam.Checked == true)
            {
                nv.SGioiTinh = "Male";
            }
            else
            {
                nv.SGioiTinh = "Female";
            }
            nv.SDiaChi = txtDiaChi.Text;
            nv.SDienThoai = txtDienThoai.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);


            // Thực hiện cập nhật
            if (NhanVienBLL.CapNhatThongTinNhanVien(nv) == false)
            {
                MessageBox.Show("Không cập nhật được!");
                return;
            }
            HienThiDanhSachNhanVien();
            MessageBox.Show("Đã cập nhật nhân viên!");

            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá thông tin nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gán dữ liệu vào kiểu NhanVienDTO
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNhanVien = txtMaNhanVien.Text;
                nv.STenNhanVien = txtTenNhanVien.Text;
                if (radGioiTinhNam.Checked == true)
                {
                    nv.SGioiTinh = "Male";
                }
                else
                {
                    nv.SGioiTinh = "Female";
                }
                nv.SDiaChi = txtDiaChi.Text;
                nv.SDienThoai = txtDienThoai.Text;
                nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

                // Thực hiện xóa 
                if (NhanVienBLL.XoaThongTinNhanVien(nv) == false)
                {
                    MessageBox.Show("Không xóa được thông tin nhân viên!");
                    return;
                }
                HienThiDanhSachNhanVien();
                MessageBox.Show("Đã xóa thông tin nhân viên!");

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
            txtMaNhanVien.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> ds = NhanVienBLL.LayDanhSachNhanVien();
            List<NhanVienDTO> kq = (from nv in ds
                                     where nv.SMaNhanVien.Contains(txtTimKiemMaNhanVien.Text)
                                     where nv.STenNhanVien.Contains(txtTimKiemTenNhanVien.Text)
                                     select nv).ToList();
            dgvNhanVien.DataSource = kq;
        }
    }
}
