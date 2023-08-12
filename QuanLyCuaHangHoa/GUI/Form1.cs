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
    public partial class Form1 : Form
    {
        private Form ActiveForm;
        DangNhap dN;
        string TenDangNhap = "";
        static TaiKhoanDTO taiKhoan;
        bool bDangNhap = false;
        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
        public Form1()
        {
            InitializeComponent();
            DangNhap();
            
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.gunaPanel3.Controls.Add(childForm);
            this.gunaPanel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            gunaPictureBox1.Visible = true;
            btnShow.Visible = false;
            btnHide.Visible = true;
            gunaPanel1.Visible = false;
            gunaPanel1.Width = 257;
            gunaTransition1.ShowSync(gunaPanel1);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //gunaPictureBox1.Visible = false;
            gunaPanel1.Visible = false;
            btnHide.Visible = false;
            btnShow.Visible = true;
            gunaPanel1.Width = 62;
            gunaTransition1.ShowSync(gunaPanel1);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu(), sender);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien(), sender);
        }

        private void btnChuDe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChuDe(), sender);
        }

        private void btnHoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Hoa(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDon(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe(), sender);
        }

        private void btnMaxnimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Flash flash = new Flash();
            flash.ShowDialog();
            timer1.Enabled = true;
        }


        private void HienThiDangNhap()
        {
            
            if (bDangNhap)
            {
                lblNguoiDung.Text = taiKhoan.SNguoiDung;
                lblQuyenHan.Text = taiKhoan.SQuyenHan;

                try
                {
                    picAnh.Image = Image.FromFile(path + @"\Images\AnhTK\" + taiKhoan.SAnh);
                }
                catch
                {
                    picAnh.Image = Image.FromFile(path + @"\Images\image.png");
                }

                string quyenHan;
                if (taiKhoan == null)
                    quyenHan = "";
                else
                    quyenHan = taiKhoan.SQuyenHan;

                switch (quyenHan)
                {
                    case "Admin":
                        btnTrangChu.Enabled = true;
                        btnChuDe.Visible = true;
                        btnKhachHang.Enabled = true;
                        btnHoa.Enabled = true;
                        btnHoaDon.Enabled = true;
                        btnNhanVien.Enabled = true;
                        break;
                    case "User":
                        btnTrangChu.Enabled = true;
                        btnChuDe.Visible = true;
                        btnKhachHang.Enabled = true;
                        btnHoa.Enabled = true;
                        btnHoaDon.Enabled = true;
                        btnNhanVien.Enabled = false;
                        btnThongKe.Enabled = false;
                        btnTaiKhoan.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                lblNguoiDung.Text = "Unknow";
                lblQuyenHan.Text = "no Status";
                btnTrangChu.Enabled = false;
                btnTrangChu.Enabled = false;
                btnChuDe.Visible = false;
                btnKhachHang.Enabled = false;
                btnHoa.Enabled = false;
                btnHoaDon.Enabled = false;
                btnNhanVien.Enabled = false;
            }
        }

        public void DangNhap()
        {

            if (dN == null || dN.IsDisposed)
                dN = new DangNhap();
            Lamlai:
            if (dN.ShowDialog() == DialogResult.OK)
            {
                string tenDN = dN.txtTenDN.Text;
                string matKhau = dN.txtMatKhau.Text;
                if (tenDN == "")
                {
                    dN.txtTenDN.Focus();
                    goto Lamlai;
                }
                else if (matKhau == "")
                {
                    dN.txtMatKhau.Focus();
                    goto Lamlai;
                }

                taiKhoan = new TaiKhoanDTO();
                taiKhoan = TaiKhoanBLL.LayTaiKhoan(tenDN, matKhau);
                if (taiKhoan != null)
                {
                    
                    bDangNhap = true;
            
                }
                else
                {
                    goto Lamlai;
                }
            }
            else
            {
                bDangNhap = false;
            }
            HienThiDangNhap();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoan(), sender);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiMatKhau(TenDangNhap), sender);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
