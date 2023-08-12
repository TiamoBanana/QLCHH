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
    public partial class Hoa : Form
    {
        OpenFileDialog dlOpen = new OpenFileDialog();
        string anh;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public Hoa()
        {
            InitializeComponent();
        }

        private void txtTimKiemMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }
        private void HienThiMaChuDeLenCombobox()
        {
            List<ChuDeDTO> lstChuDe = ChuDeBLL.LayDanhSachChuDe();
            cboChuDe.DataSource = lstChuDe;
            cboChuDe.DisplayMember = "STenChuDe";
            cboChuDe.ValueMember = "SMaChuDe";
        }

        private void Hoa_Load(object sender, EventArgs e)
        {
            txtMaHoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            HienThiMaChuDeLenCombobox();



            HienThiDSHoaLenDatagrid();
        }
        private void HienThiDSHoaLenDatagrid()
        {
            List<HoaDTO> lstHoa = HoaBLL.LayDanhSachHoa();
            dgvHoa.DataSource = lstHoa;
            dgvHoa.Columns["SMaHoa"].HeaderText = "ID Flower";
            dgvHoa.Columns["STenHoa"].HeaderText = "Flower Name";
            dgvHoa.Columns["SMaChuDe"].HeaderText = "Category";
            dgvHoa.Columns["SSoLuong"].HeaderText = "Numbers";
            dgvHoa.Columns["SDonGiaNhap"].HeaderText = "Import Price";
            dgvHoa.Columns["SDonGiaBan"].HeaderText = "Unit Price";
            dgvHoa.Columns["SAnh"].HeaderText = "Image";
            dgvHoa.Columns["SGhiChu"].HeaderText = "Note";

            dgvHoa.Columns["SDonGiaNhap"].DefaultCellStyle.Format = "#,### VND";
            dgvHoa.Columns["SDonGiaBan"].DefaultCellStyle.Format = "#,### VND";

            dgvHoa.Columns["SMaHoa"].Width = 80;
            dgvHoa.Columns["STenHoa"].Width = 140;
            dgvHoa.Columns["SMaChuDe"].Width = 80;
            dgvHoa.Columns["SSoLuong"].Width = 80;
            dgvHoa.Columns["SDonGiaNhap"].Width = 100;
            dgvHoa.Columns["SDonGiaBan"].Width = 100;
            dgvHoa.Columns["SAnh"].Width = 100;
            dgvHoa.Columns["SGhiChu"].Width = 100;
            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(path + @"\Images\AnhH\" + txtAnh.Text);
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

            dgvHoa.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvHoa.AllowUserToAddRows = false;
            dgvHoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvHoa_Click(object sender, EventArgs e)
        {
           
        }
        bool ktSo(Guna.UI.WinForms.GunaTextBox t)
        {
            try
            {
                Convert.ToInt32(t.Text);
            }
            catch
            {
                MessageBox.Show(t.Tag + " Giá trị phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThemMoi.Enabled = false;
            ResetValues();
            txtMaHoa.Enabled = true;
            txtMaHoa.Focus();
        }
        private void ResetValues()
        {
            txtMaHoa.Text = "H00";
            txtTenHoa.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtSoLuong.Text = "0";
            txtAnh.Text = "";
            txtGhiChu.Text = "";
            cboChuDe.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra các thông tin
            if (txtMaHoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHoa.Focus();
                return;
            }
            if (txtTenHoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHoa.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá nhập không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Đơn giá bán không được rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }
            if (!ktSo(txtDonGiaNhap))
                return;
            if (!ktSo(txtDonGiaBan))
                return;
            if (!ktSo(txtSoLuong))
                return;

            //Kiểm tra mã trùng
            if (HoaBLL.TimHoaTheoMa(txtMaHoa.Text) != null)
            {
                MessageBox.Show("Mã hoa đã tồn tại! Vui lòng chọn mã khác!");
                return;
            }

            // Gán dữ liệu vào kiểu HoaDTO
            HoaDTO h = new HoaDTO();
            h.SMaHoa = txtMaHoa.Text;
            h.STenHoa = txtTenHoa.Text;
            h.SMaChuDe = cboChuDe.SelectedValue.ToString();
            h.SSoLuong = int.Parse(txtSoLuong.Text);
            h.SDonGiaNhap = float.Parse(txtDonGiaNhap.Text);
            h.SDonGiaBan = float.Parse(txtDonGiaBan.Text);
            h.SAnh = txtAnh.Text;
            h.SGhiChu = txtGhiChu.Text;

            // Thực hiện thêm
            if (HoaBLL.ThemHoa(h) == false)
            {
                MessageBox.Show("Không thêm được!");
                return;
            }
            //savefile ảnh
            if (!File.Exists(path + @"\Images\AnhH\" + txtAnh.Text))
            {
                try
                {
                    File.Copy(dlOpen.FileName, path + @"\Images\AnhH\" + txtAnh.Text);
                }
                catch { }
            }

            HienThiDSHoaLenDatagrid();
            MessageBox.Show("Đã thêm hoa thành công!");

            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHoa.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHoa.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }

            // Kiểm tra mã hoa có tồn tại không
            if (HoaBLL.TimHoaTheoMa(txtMaHoa.Text) == null)
            {
                MessageBox.Show("Mã hoa không tồn tại!");
                return;
            }

            // Gán dữ liệu vào kiểu HoaDTO
            HoaDTO h = new HoaDTO();
            h.SMaHoa = txtMaHoa.Text;
            h.STenHoa = txtTenHoa.Text;
            h.SMaChuDe = cboChuDe.SelectedValue.ToString();
            h.SSoLuong = int.Parse(txtSoLuong.Text);
            h.SDonGiaNhap = float.Parse(txtDonGiaNhap.Text);
            h.SDonGiaBan = float.Parse(txtDonGiaBan.Text);
            h.SAnh = txtAnh.Text;
            h.SGhiChu = txtGhiChu.Text;

            // Thực hiện cập nhật
            if (HoaBLL.CapNhatThongTinHoa(h) == false)
            {
                MessageBox.Show("Không cập nhật được!");
                return;
            }
            //savefile ảnh
            if (!File.Exists(path + @"\Images\AnhH\" + txtAnh.Text))
            {
                try
                {
                    File.Copy(dlOpen.FileName, path + @"\Images\AnhH\" + txtAnh.Text);
                }
                catch { }
            }
            HienThiDSHoaLenDatagrid();
            MessageBox.Show("Đã cập nhật hoa!");

            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHoa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin hoa nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá thông tin khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gán dữ liệu vào kiểu HoaDTO
                HoaDTO h = new HoaDTO();
                h.SMaHoa = txtMaHoa.Text;
                h.STenHoa = txtTenHoa.Text;
                h.SMaChuDe = cboChuDe.SelectedValue.ToString();
                h.SSoLuong = int.Parse(txtSoLuong.Text);
                h.SDonGiaNhap = float.Parse(txtDonGiaNhap.Text);
                h.SDonGiaBan = float.Parse(txtDonGiaBan.Text);
                h.SAnh = txtAnh.Text;
                h.SGhiChu = txtGhiChu.Text;

                // Thực hiện xóa 
                if (HoaBLL.XoaThongTinHoa(h) == false)
                {
                    MessageBox.Show("Không xóa được thông tin hoa!");
                    return;
                }
                HienThiDSHoaLenDatagrid();
                MessageBox.Show("Đã xóa thông tin hoa !");

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
            txtMaHoa.Enabled = false;
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
                txtAnh.Text = Path.GetFileName(dlgOpen.FileName);
                dlOpen = dlgOpen;
                picAnh.Image = Image.FromFile(dlOpen.FileName);
            }
        }

        private void dgvHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemMoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHoa.Focus();
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvHoa.Rows[e.RowIndex];
                txtMaHoa.Text = r.Cells["SMaHoa"].Value.ToString();
                txtTenHoa.Text = r.Cells["STenHoa"].Value.ToString();
                cboChuDe.SelectedValue = r.Cells["SMaChuDe"].Value.ToString();
                txtSoLuong.Text = r.Cells["SSoLuong"].Value.ToString();
                txtDonGiaNhap.Text = r.Cells["SDonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = r.Cells["SDonGiaBan"].Value.ToString();
                txtAnh.Text = r.Cells["SAnh"].Value.ToString();
                txtGhiChu.Text = r.Cells["SGhiChu"].Value.ToString();
                if (txtAnh.Text.Trim() != "")
                {
                    try
                    {
                        picAnh.Image = Image.FromFile(path + @"\Images\AnhH\" + txtAnh.Text);
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
            anh = txtAnh.Text;


        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDLBLL.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }
    }
}
