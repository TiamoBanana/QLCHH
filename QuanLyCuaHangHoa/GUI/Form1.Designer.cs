
namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.picAnh = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.btnHide = new Guna.UI.WinForms.GunaCircleButton();
            this.btnShow = new Guna.UI.WinForms.GunaCircleButton();
            this.btnThoat = new Guna.UI.WinForms.GunaGradientButton();
            this.btnDoiMatKhau = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTaiKhoan = new Guna.UI.WinForms.GunaGradientButton();
            this.btnThongKe = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHoaDon = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnChuDe = new Guna.UI.WinForms.GunaGradientButton();
            this.btnNhanVien = new Guna.UI.WinForms.GunaGradientButton();
            this.btnKhachHang = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTrangChu = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.gunaPanel1.Controls.Add(this.btnHide);
            this.gunaPanel1.Controls.Add(this.btnShow);
            this.gunaPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaPanel1.Controls.Add(this.btnThoat);
            this.gunaPanel1.Controls.Add(this.btnDoiMatKhau);
            this.gunaPanel1.Controls.Add(this.btnTaiKhoan);
            this.gunaPanel1.Controls.Add(this.btnThongKe);
            this.gunaPanel1.Controls.Add(this.btnHoaDon);
            this.gunaPanel1.Controls.Add(this.btnHoa);
            this.gunaPanel1.Controls.Add(this.btnChuDe);
            this.gunaPanel1.Controls.Add(this.btnNhanVien);
            this.gunaPanel1.Controls.Add(this.btnKhachHang);
            this.gunaPanel1.Controls.Add(this.btnTrangChu);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaTransition1.SetDecoration(this.gunaPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(257, 763);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaSeparator1
            // 
            this.gunaTransition1.SetDecoration(this.gunaSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 589);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(220, 10);
            this.gunaSeparator1.TabIndex = 8;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Mosaic;
            this.gunaTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation2;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.White;
            this.gunaPanel2.Controls.Add(this.btnXoa);
            this.gunaPanel2.Controls.Add(this.lblQuyenHan);
            this.gunaPanel2.Controls.Add(this.lblNguoiDung);
            this.gunaPanel2.Controls.Add(this.picAnh);
            this.gunaPanel2.Controls.Add(this.lblDate);
            this.gunaPanel2.Controls.Add(this.label1);
            this.gunaPanel2.Controls.Add(this.lblTime);
            this.gunaPanel2.Controls.Add(this.btnMinimize);
            this.gunaPanel2.Controls.Add(this.gunaControlBox1);
            this.gunaTransition1.SetDecoration(this.gunaPanel2, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(257, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(994, 60);
            this.gunaPanel2.TabIndex = 11;
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblQuyenHan, Guna.UI.Animation.DecorationType.None);
            this.lblQuyenHan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenHan.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuyenHan.Location = new System.Drawing.Point(689, 30);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(30, 15);
            this.lblQuyenHan.TabIndex = 4;
            this.lblQuyenHan.Text = "User";
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblNguoiDung, Guna.UI.Animation.DecorationType.None);
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoiDung.ForeColor = System.Drawing.Color.DimGray;
            this.lblNguoiDung.Location = new System.Drawing.Point(689, 9);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(43, 21);
            this.lblNguoiDung.TabIndex = 4;
            this.lblNguoiDung.Text = "User";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblDate, Guna.UI.Animation.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Baby Dualistic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(148, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 28);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.label1, Guna.UI.Animation.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Baby Dualistic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.lblTime, Guna.UI.Animation.DecorationType.None);
            this.lblTime.Font = new System.Drawing.Font("Baby Dualistic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(22, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 28);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaTransition1.SetDecoration(this.gunaControlBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(937, 12);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaPanel3, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(257, 60);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(994, 703);
            this.gunaPanel3.TabIndex = 12;
            this.gunaPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel3_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnXoa, Guna.UI.Animation.DecorationType.None);
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_data_recovery_64;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(345, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 20;
            this.btnXoa.Size = new System.Drawing.Size(124, 30);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Recover";
            this.btnXoa.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // picAnh
            // 
            this.picAnh.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.picAnh, Guna.UI.Animation.DecorationType.None);
            this.picAnh.Image = global::GUI.Properties.Resources.Кисули_;
            this.picAnh.Location = new System.Drawing.Point(630, 3);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(45, 48);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 3;
            this.picAnh.TabStop = false;
            this.picAnh.UseTransfarantBackground = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnMinimize, Guna.UI.Animation.DecorationType.None);
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::GUI.Properties.Resources.icons8_subtract_501;
            this.btnMinimize.ImageOffsetX = 2;
            this.btnMinimize.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMinimize.Location = new System.Drawing.Point(886, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(45, 29);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHide
            // 
            this.btnHide.Animated = true;
            this.btnHide.AnimationHoverSpeed = 0.07F;
            this.btnHide.AnimationSpeed = 0.03F;
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.btnHide.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnHide, Guna.UI.Animation.DecorationType.None);
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHide.FocusedColor = System.Drawing.Color.Empty;
            this.btnHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHide.ForeColor = System.Drawing.Color.Black;
            this.btnHide.Image = global::GUI.Properties.Resources.icons8_back_64;
            this.btnHide.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHide.Location = new System.Drawing.Point(228, 576);
            this.btnHide.Name = "btnHide";
            this.btnHide.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHide.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHide.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHide.OnHoverImage = null;
            this.btnHide.OnPressedColor = System.Drawing.Color.Black;
            this.btnHide.Size = new System.Drawing.Size(40, 40);
            this.btnHide.TabIndex = 9;
            this.btnHide.UseTransfarantBackground = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnShow, Guna.UI.Animation.DecorationType.None);
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Image = global::GUI.Properties.Resources.icons8_forward_64;
            this.btnShow.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShow.Location = new System.Drawing.Point(32, 576);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Size = new System.Drawing.Size(40, 40);
            this.btnShow.TabIndex = 10;
            this.btnShow.UseTransfarantBackground = true;
            this.btnShow.Visible = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Animated = true;
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThoat.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnThoat, Guna.UI.Animation.DecorationType.None);
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.icons8_logout_64;
            this.btnThoat.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThoat.Location = new System.Drawing.Point(0, 678);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnThoat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(254, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Log Out";
            this.btnThoat.TextOffsetX = 20;
            this.btnThoat.UseTransfarantBackground = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Animated = true;
            this.btnDoiMatKhau.AnimationHoverSpeed = 0.07F;
            this.btnDoiMatKhau.AnimationSpeed = 0.03F;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnDoiMatKhau.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnDoiMatKhau.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnDoiMatKhau, Guna.UI.Animation.DecorationType.None);
            this.btnDoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMatKhau.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Image = global::GUI.Properties.Resources.icons8_show_password_64;
            this.btnDoiMatKhau.ImageSize = new System.Drawing.Size(45, 45);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 622);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnDoiMatKhau.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnDoiMatKhau.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.OnHoverImage = null;
            this.btnDoiMatKhau.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(254, 50);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Password";
            this.btnDoiMatKhau.TextOffsetX = 20;
            this.btnDoiMatKhau.UseTransfarantBackground = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Animated = true;
            this.btnTaiKhoan.AnimationHoverSpeed = 0.07F;
            this.btnTaiKhoan.AnimationSpeed = 0.03F;
            this.btnTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTaiKhoan.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnTaiKhoan, Guna.UI.Animation.DecorationType.None);
            this.btnTaiKhoan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaiKhoan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaiKhoan.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Image = global::GUI.Properties.Resources.icons8_password_key_64;
            this.btnTaiKhoan.ImageSize = new System.Drawing.Size(45, 45);
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 498);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnTaiKhoan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTaiKhoan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.OnHoverImage = null;
            this.btnTaiKhoan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaiKhoan.Size = new System.Drawing.Size(254, 50);
            this.btnTaiKhoan.TabIndex = 7;
            this.btnTaiKhoan.Text = "Account";
            this.btnTaiKhoan.TextOffsetX = 20;
            this.btnTaiKhoan.UseTransfarantBackground = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Animated = true;
            this.btnThongKe.AnimationHoverSpeed = 0.07F;
            this.btnThongKe.AnimationSpeed = 0.03F;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThongKe.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnThongKe, Guna.UI.Animation.DecorationType.None);
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongKe.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Image = global::GUI.Properties.Resources.icons8_increase_64;
            this.btnThongKe.ImageSize = new System.Drawing.Size(45, 45);
            this.btnThongKe.Location = new System.Drawing.Point(0, 442);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnThongKe.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongKe.OnHoverImage = null;
            this.btnThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongKe.Size = new System.Drawing.Size(254, 50);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Statistic";
            this.btnThongKe.TextOffsetX = 20;
            this.btnThongKe.UseTransfarantBackground = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Animated = true;
            this.btnHoaDon.AnimationHoverSpeed = 0.07F;
            this.btnHoaDon.AnimationSpeed = 0.03F;
            this.btnHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoaDon.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoaDon.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnHoaDon, Guna.UI.Animation.DecorationType.None);
            this.btnHoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnHoaDon.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = global::GUI.Properties.Resources.icons8_bill_64;
            this.btnHoaDon.ImageSize = new System.Drawing.Size(45, 45);
            this.btnHoaDon.Location = new System.Drawing.Point(0, 387);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnHoaDon.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHoaDon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHoaDon.OnHoverImage = null;
            this.btnHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(254, 50);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Bill";
            this.btnHoaDon.TextOffsetX = 20;
            this.btnHoaDon.UseTransfarantBackground = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnHoa
            // 
            this.btnHoa.Animated = true;
            this.btnHoa.AnimationHoverSpeed = 0.07F;
            this.btnHoa.AnimationSpeed = 0.03F;
            this.btnHoa.BackColor = System.Drawing.Color.Transparent;
            this.btnHoa.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoa.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoa.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnHoa, Guna.UI.Animation.DecorationType.None);
            this.btnHoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnHoa.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoa.ForeColor = System.Drawing.Color.Black;
            this.btnHoa.Image = global::GUI.Properties.Resources.icons8_flower_64;
            this.btnHoa.ImageSize = new System.Drawing.Size(45, 45);
            this.btnHoa.Location = new System.Drawing.Point(0, 332);
            this.btnHoa.Name = "btnHoa";
            this.btnHoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnHoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnHoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHoa.OnHoverImage = null;
            this.btnHoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnHoa.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHoa.Size = new System.Drawing.Size(254, 50);
            this.btnHoa.TabIndex = 5;
            this.btnHoa.Text = "Flowers";
            this.btnHoa.TextOffsetX = 20;
            this.btnHoa.UseTransfarantBackground = true;
            this.btnHoa.Click += new System.EventHandler(this.btnHoa_Click);
            // 
            // btnChuDe
            // 
            this.btnChuDe.Animated = true;
            this.btnChuDe.AnimationHoverSpeed = 0.07F;
            this.btnChuDe.AnimationSpeed = 0.03F;
            this.btnChuDe.BackColor = System.Drawing.Color.Transparent;
            this.btnChuDe.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnChuDe.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnChuDe.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnChuDe, Guna.UI.Animation.DecorationType.None);
            this.btnChuDe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuDe.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuDe.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuDe.ForeColor = System.Drawing.Color.Black;
            this.btnChuDe.Image = global::GUI.Properties.Resources.icons8_springtime_64;
            this.btnChuDe.ImageSize = new System.Drawing.Size(45, 45);
            this.btnChuDe.Location = new System.Drawing.Point(0, 277);
            this.btnChuDe.Name = "btnChuDe";
            this.btnChuDe.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnChuDe.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnChuDe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuDe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuDe.OnHoverImage = null;
            this.btnChuDe.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuDe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChuDe.Size = new System.Drawing.Size(254, 50);
            this.btnChuDe.TabIndex = 4;
            this.btnChuDe.Text = "Themes";
            this.btnChuDe.TextOffsetX = 20;
            this.btnChuDe.UseTransfarantBackground = true;
            this.btnChuDe.Click += new System.EventHandler(this.btnChuDe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Animated = true;
            this.btnNhanVien.AnimationHoverSpeed = 0.07F;
            this.btnNhanVien.AnimationSpeed = 0.03F;
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnNhanVien.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnNhanVien.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnNhanVien, Guna.UI.Animation.DecorationType.None);
            this.btnNhanVien.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.btnNhanVien.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = global::GUI.Properties.Resources.icons8_add_user_group_man_woman_64;
            this.btnNhanVien.ImageSize = new System.Drawing.Size(45, 45);
            this.btnNhanVien.Location = new System.Drawing.Point(0, 222);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnNhanVien.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnNhanVien.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhanVien.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhanVien.OnHoverImage = null;
            this.btnNhanVien.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(254, 50);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Staffs";
            this.btnNhanVien.TextOffsetX = 20;
            this.btnNhanVien.UseTransfarantBackground = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Animated = true;
            this.btnKhachHang.AnimationHoverSpeed = 0.07F;
            this.btnKhachHang.AnimationSpeed = 0.03F;
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnKhachHang.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnKhachHang.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnKhachHang, Guna.UI.Animation.DecorationType.None);
            this.btnKhachHang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnKhachHang.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = global::GUI.Properties.Resources.icons8_customer_64;
            this.btnKhachHang.ImageSize = new System.Drawing.Size(45, 45);
            this.btnKhachHang.Location = new System.Drawing.Point(0, 167);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnKhachHang.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnKhachHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKhachHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKhachHang.OnHoverImage = null;
            this.btnKhachHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(254, 50);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Customers";
            this.btnKhachHang.TextOffsetX = 20;
            this.btnKhachHang.UseTransfarantBackground = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Animated = true;
            this.btnTrangChu.AnimationHoverSpeed = 0.07F;
            this.btnTrangChu.AnimationSpeed = 0.03F;
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTrangChu.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTrangChu.BorderColor = System.Drawing.Color.Black;
            this.gunaTransition1.SetDecoration(this.btnTrangChu, Guna.UI.Animation.DecorationType.None);
            this.btnTrangChu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTrangChu.FocusedColor = System.Drawing.Color.Empty;
            this.btnTrangChu.Font = new System.Drawing.Font("High Spirited", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = global::GUI.Properties.Resources.icons8_home_40;
            this.btnTrangChu.ImageSize = new System.Drawing.Size(45, 45);
            this.btnTrangChu.Location = new System.Drawing.Point(0, 112);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(145)))), ((int)(((byte)(170)))));
            this.btnTrangChu.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(218)))), ((int)(((byte)(204)))));
            this.btnTrangChu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTrangChu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTrangChu.OnHoverImage = null;
            this.btnTrangChu.OnPressedColor = System.Drawing.Color.Black;
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(254, 50);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Home";
            this.btnTrangChu.TextOffsetX = 20;
            this.btnTrangChu.UseTransfarantBackground = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTransition1.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Image = global::GUI.Properties.Resources.O_HARA_FLORA1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(9, 23);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(209, 68);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.UseTransfarantBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1251, 763);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnTrangChu;
        private Guna.UI.WinForms.GunaGradientButton btnHoaDon;
        private Guna.UI.WinForms.GunaGradientButton btnHoa;
        private Guna.UI.WinForms.GunaGradientButton btnChuDe;
        private Guna.UI.WinForms.GunaGradientButton btnNhanVien;
        private Guna.UI.WinForms.GunaGradientButton btnKhachHang;
        private Guna.UI.WinForms.GunaGradientButton btnThongKe;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaCircleButton btnHide;
        private Guna.UI.WinForms.GunaCircleButton btnShow;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton btnMinimize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCirclePictureBox picAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.Label lblNguoiDung;
        private Guna.UI.WinForms.GunaGradientButton btnTaiKhoan;
        private Guna.UI.WinForms.GunaGradientButton btnDoiMatKhau;
        private Guna.UI.WinForms.GunaGradientButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnXoa;
    }
}

