using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
       
        public DoiMatKhau(string tk)
        {
       
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muons đổi mật khẩu?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtNhapLaiMatKhau.Text != txtMatKhauMoi.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Gán dữ liệu vào kiểu TaiKhoan_DTO
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.STenDangNhap = lblTenNguoiDung.Text;
                tk.SMatKhau = txtMatKhauMoi.Text;
                // Thực hiện cập nhật
                if (TaiKhoanBLL.DoiMatKhau(tk) == false)
                {
                    MessageBox.Show("Không cập nhật được.");
                    return;
                }
                MessageBox.Show("Đổi mật khẩu thành công thành công.");
            }
            this.Close();
        }
    }
}
