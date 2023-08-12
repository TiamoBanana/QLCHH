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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            //new Flash().Show();
            InitializeComponent();
           
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = txtTenDN.Text;
            string matkhau = txtMatKhau.Text;
            if(tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                
            }else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
               
            } 
          
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
