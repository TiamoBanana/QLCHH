using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TaiKhoan : Form
    {
        OpenFileDialog dlOpen = new OpenFileDialog();
        string anh;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FillComboNhanVien()
        {
            List<NhanVienDTO> lst = NhanVienBLL.LayDanhSachNhanVien();
            cboNhanVien.DataSource = lst;
            cboNhanVien.DisplayMember = "STenNhanVien";
            cboNhanVien.ValueMember = "STenNhanVien";
        }
        public void HienThiTaiKhoan()
        {
            List<TaiKhoanDTO> lstTaiKhoan = TaiKhoanBLL.LayTaiKhoan();
            dgvTaiKhoan.DataSource = lstTaiKhoan;
            if (lstTaiKhoan != null)
            {
                dgvTaiKhoan.Columns["STenDangNhap"].HeaderText = "Account";
                dgvTaiKhoan.Columns["SMatKhau"].HeaderText = "Password";
                dgvTaiKhoan.Columns["SNguoiDung"].HeaderText = "Staff's Account";
                dgvTaiKhoan.Columns["SQuyenHan"].HeaderText = "Authorities";
                dgvTaiKhoan.Columns["SAnh"].HeaderText = "Picture";
        
                if (txtDuongDan.Text.Trim() != "")
                {
                    try
                    {
                        picAnh.Image = Image.FromFile(path + @"\Images\AnhTK\" + txtDuongDan.Text);
                    }
                    catch
                    {
                        picAnh.Image = Image.FromFile(path + @"\Images\image.png");
                    }
                }
                else
                {
                    picAnh.Image = Image.FromFile(path + @"\Images\image.png");
                }
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|PNG(*.png)|*.png|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = path;
            dlgOpen.FilterIndex = 5;
            dlgOpen.Title = "Chọn ảnh đại diện";

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = Path.GetFileName(dlgOpen.FileName);
                dlOpen = dlgOpen;
                picAnh.Image = Image.FromFile(dlOpen.FileName);
            }
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
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
            txtTenTaiKhoan.Enabled = true;
            txtTenTaiKhoan.Focus();
        }
        private void ResetValues()
        {
            txtTenTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboNhanVien.SelectedIndex = 0;
            radQuanTrivien.Checked = false;
            radNhanVien.Checked = false;
            txtDuongDan.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
           

            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.SNguoiDung = cboNhanVien.SelectedValue.ToString();
            tk.STenDangNhap = txtTenTaiKhoan.Text;
            tk.SMatKhau = txtMatKhau.Text;
            tk.SAnh = txtDuongDan.Text;
            if (radQuanTrivien.Checked == true)
                tk.SQuyenHan = "Admin";
            else
                tk.SQuyenHan = "User";
         
            
            if (TaiKhoanBLL.ThemTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            //savefile ảnh
            if (!File.Exists(path + @"\Images\AnhTK\" + txtDuongDan.Text))
            {
                try
                {
                    File.Copy(dlOpen.FileName, path + @"\Images\AnhTK\" + txtDuongDan.Text);
                }
                catch { }
            }

            TaiKhoan_Load(sender, e);
            MessageBox.Show("Đã thêm thành công!");

            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtTenTaiKhoan.Enabled = false;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;

            HienThiTaiKhoan();
            FillComboNhanVien();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenTaiKhoan.Text = r.Cells["STenDangNhap"].Value.ToString();
                txtMatKhau.Text = r.Cells["SMatKhau"].Value.ToString();
                cboNhanVien.SelectedValue = r.Cells["SNguoiDung"].Value.ToString();                          
                if (r.Cells["SQuyenHan"].Value.ToString() == "Admin")
                    radQuanTrivien.Checked = true;
                else
                    radNhanVien.Checked = true;
                txtDuongDan.Text = r.Cells["SAnh"].Value.ToString();
                if (txtDuongDan.Text.Trim() != "")
                {
                    try
                    {
                        picAnh.Image = Image.FromFile(path + @"\Images\AnhTK\" + txtDuongDan.Text);
                    }
                    catch
                    {
                        picAnh.Image = Image.FromFile(path + @"\Images\image.png");
                    }
                }
                else
                {
                    picAnh.Image = Image.FromFile(path + @"\Images\image.png");
                }
            }
            anh = txtDuongDan.Text;

            txtTenTaiKhoan.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboNhanVien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã nhân viên có tồn tại không
            if (TaiKhoanBLL.TimTaiKhoanTheoMa(txtTenTaiKhoan.Text) == null)
            {
                MessageBox.Show("Tên tài khoản không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu TaiKhoan_DTO
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.STenDangNhap = txtTenTaiKhoan.Text;
            tk.SMatKhau = txtMatKhau.Text;
            tk.SNguoiDung = cboNhanVien.SelectedValue.ToString();
            if (radQuanTrivien.Checked == true)
                tk.SQuyenHan = "Admin";
            else
                tk.SQuyenHan = "User";

            tk.SAnh = txtDuongDan.Text;
            //savefile ảnh
            if (!File.Exists(path + @"\Images\AnhTK\" + txtDuongDan.Text))
            {
                try
                {
                    File.Copy(dlOpen.FileName, path + @"\Images\AnhTK\" + txtDuongDan.Text);
                }
                catch { }
            }
            // Thực hiện cập nhật
            if (TaiKhoanBLL.CapNhatTaiKhoan(tk) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            TaiKhoan_Load(sender, e);
            MessageBox.Show("Cập nhật thành công.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin tài khoản nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá thông tin tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gán dữ liệu vào kiểu TaiKhoanDTO
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = txtTenTaiKhoan.Text;
                tk.SMatKhau = txtMatKhau.Text;
                tk.SNguoiDung = cboNhanVien.SelectedValue.ToString();
                if (radQuanTrivien.Checked == true)
                    tk.SQuyenHan = "Admin";
                else
                    tk.SQuyenHan = "User";

                tk.SAnh = txtDuongDan.Text;

                // Thực hiện xóa 
                if (TaiKhoanBLL.XoaTaiKhoan(tk) == false)
                {
                    MessageBox.Show("Không xóa được thông tin tài khoản!");
                    return;
                }
                HienThiTaiKhoan();
                MessageBox.Show("Đã xóa thông tin khách hàng!");

                ResetValues();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<TaiKhoanDTO> ds = TaiKhoanBLL.LayTaiKhoan();
            List<TaiKhoanDTO> kq = (from tk in ds
                                     where tk.STenDangNhap.Contains(txtTimKiemTenTaiKhoan.Text)
                                     where tk.SNguoiDung.Contains(txtTimKienNguoiDung.Text)
                                     select tk).ToList();
            dgvTaiKhoan.DataSource = kq;
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTaiKhoan.Columns[e.ColumnIndex].Name == "SMatKhau")
            {
                e.Value = "*********";
            }
        }
    }
}
