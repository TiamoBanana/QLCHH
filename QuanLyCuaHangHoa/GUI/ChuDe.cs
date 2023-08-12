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
    public partial class ChuDe : Form
    {
        public ChuDe()
        {
            InitializeComponent();
        }

        private void ChuDe_Load(object sender, EventArgs e)
        {
            txtMaChuDe.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;

            HienThiDanhSachChuDe();
        }
        private void HienThiDanhSachChuDe()
        {
            List<ChuDeDTO> lstChuDe = ChuDeBLL.LayDanhSachChuDe();
            dgvChuDe.DataSource = lstChuDe;
            dgvChuDe.Columns["SMaChuDe"].HeaderText = "ID Theme";
            dgvChuDe.Columns["STenChuDe"].HeaderText = "Theme Name";

            dgvChuDe.Columns["SMaChuDe"].Width = 10;
            dgvChuDe.Columns["STenChuDe"].Width = 150;

            dgvChuDe.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvChuDe.AllowUserToAddRows = false;
            dgvChuDe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChuDe_Click(object sender, EventArgs e)
        {
            if (btnThemMoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuDe.Focus();
                return;
            }

            txtMaChuDe.Text = dgvChuDe.CurrentRow.Cells["SMaChuDe"].Value.ToString();
            txtTenChuDe.Text = dgvChuDe.CurrentRow.Cells["STenChuDe"].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues(); //Xoá trắng các textbox
            txtMaChuDe.Enabled = true; //cho phép nhập mới
            txtMaChuDe.Focus();
        }

        private void ResetValues()
        {
            txtMaChuDe.Text = "CD0";
            txtTenChuDe.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra các thông tin
            if (txtMaChuDe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChuDe.Focus();
                return;
            }
            if (txtTenChuDe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChuDe.Focus();
                return;
            }

            //Kiểm tra mã trùng
            if (ChuDeBLL.TimChuDeTheoMa(txtMaChuDe.Text) != null)
            {
                MessageBox.Show("Mã chủ đề đã tồn tại! Vui lòng chọn mã khác!");
                return;
            }

            // Gán dữ liệu vào kiểu ChuDeDTO
            ChuDeDTO cd = new ChuDeDTO();
            cd.SMaChuDe = txtMaChuDe.Text;
            cd.STenChuDe = txtTenChuDe.Text;

            // Thực hiện thêm
            if (ChuDeBLL.ThemChuDe(cd) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            HienThiDanhSachChuDe();
            MessageBox.Show("Đã thêm chủ đề thành công!");

            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChuDe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaChuDe.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChuDe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChuDe.Focus();
                return;
            }


            // Kiểm tra mã chủ đề có tồn tại không
            if (ChuDeBLL.TimChuDeTheoMa(txtMaChuDe.Text) == null)
            {
                MessageBox.Show("Mã chủ đề không tồn tại!");
                return;
            }

            // Gán dữ liệu vào kiểu ChuDeDTO
            ChuDeDTO cd = new ChuDeDTO();
            cd.SMaChuDe = txtMaChuDe.Text;
            cd.STenChuDe = txtTenChuDe.Text;

            // Thực hiện cập nhật
            if (ChuDeBLL.CapNhatThongTinChuDe(cd) == false)
            {
                MessageBox.Show("Không cập nhật được!");
                return;
            }
            HienThiDanhSachChuDe();
            MessageBox.Show("Đã cập nhật chủ đề!");

            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuDe.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin chủ đề nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá thông tin chủ đề này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gán dữ liệu vào kiểu ChuDeDTO
                ChuDeDTO cd = new ChuDeDTO();
                cd.SMaChuDe = txtMaChuDe.Text;
                cd.STenChuDe = txtTenChuDe.Text;

                // Thực hiện xóa 
                if (ChuDeBLL.XoaThongTinChuDe(cd) == false)
                {
                    MessageBox.Show("Không xóa được thông tin chủ đề!");
                    return;
                }
                HienThiDanhSachChuDe();
                MessageBox.Show("Đã xóa thông tin chủ đề!");

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
            txtMaChuDe.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<ChuDeDTO> ds = ChuDeBLL.LayDanhSachChuDe();
            List<ChuDeDTO> kq = (from cd in ds
                                     where cd.SMaChuDe.Contains(txtTimKiemMaChuDe.Text)
                                     where cd.STenChuDe.Contains(txtTimKiemTenChuDe.Text)
                                     select cd).ToList();
            dgvChuDe.DataSource = kq;
        }
    }
}
