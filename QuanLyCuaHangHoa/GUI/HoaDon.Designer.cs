
namespace GUI
{
    partial class HoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnBoQua = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaButton();
            this.txtThanhToan = new Guna.UI.WinForms.GunaTextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboKhachHang = new Guna.UI.WinForms.GunaComboBox();
            this.cboNhanVien = new Guna.UI.WinForms.GunaComboBox();
            this.cboHoa = new Guna.UI.WinForms.GunaComboBox();
            this.dtpNgayBan = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtMaHoaDon = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.txtTimKiemMaHoa = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTimKiemMaNhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnInHoaDon = new Guna.UI.WinForms.GunaButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.groupBox2.Controls.Add(this.numDonGia);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.txtThanhToan);
            this.groupBox2.Controls.Add(this.numSoLuong);
            this.groupBox2.Controls.Add(this.cboKhachHang);
            this.groupBox2.Controls.Add(this.cboNhanVien);
            this.groupBox2.Controls.Add(this.cboHoa);
            this.groupBox2.Controls.Add(this.dtpNgayBan);
            this.groupBox2.Controls.Add(this.txtMaHoaDon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 588);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BILL INFORMATION";
            // 
            // numDonGia
            // 
            this.numDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numDonGia.Location = new System.Drawing.Point(114, 263);
            this.numDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(197, 27);
            this.numDonGia.TabIndex = 30;
            this.numDonGia.ValueChanged += new System.EventHandler(this.numDonGia_ValueChanged);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_edit_property_64;
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(178, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Radius = 20;
            this.btnSua.Size = new System.Drawing.Size(133, 45);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Update";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBoQua.AnimationHoverSpeed = 0.07F;
            this.btnBoQua.AnimationSpeed = 0.03F;
            this.btnBoQua.BackColor = System.Drawing.Color.Transparent;
            this.btnBoQua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnBoQua.BorderColor = System.Drawing.Color.Black;
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBoQua.FocusedColor = System.Drawing.Color.Empty;
            this.btnBoQua.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.Black;
            this.btnBoQua.Image = global::GUI.Properties.Resources.icons8_skip_to_start_64;
            this.btnBoQua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBoQua.Location = new System.Drawing.Point(178, 433);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnBoQua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverImage = null;
            this.btnBoQua.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoQua.Radius = 20;
            this.btnBoQua.Size = new System.Drawing.Size(133, 45);
            this.btnBoQua.TabIndex = 26;
            this.btnBoQua.Text = "Skip";
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Image = global::GUI.Properties.Resources.icons8_save_64;
            this.btnLuu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLuu.Location = new System.Drawing.Point(178, 484);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 20;
            this.btnLuu.Size = new System.Drawing.Size(133, 45);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_multiply_64;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(39, 433);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 20;
            this.btnXoa.Size = new System.Drawing.Size(133, 45);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemMoi.AnimationHoverSpeed = 0.07F;
            this.btnThemMoi.AnimationSpeed = 0.03F;
            this.btnThemMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnThemMoi.BorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemMoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.Image = global::GUI.Properties.Resources.icons8_plus_math_64;
            this.btnThemMoi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThemMoi.Location = new System.Drawing.Point(9, 485);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Radius = 20;
            this.btnThemMoi.Size = new System.Drawing.Size(163, 91);
            this.btnThemMoi.TabIndex = 29;
            this.btnThemMoi.Text = "Create New";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.txtThanhToan.BaseColor = System.Drawing.Color.White;
            this.txtThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhToan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtThanhToan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtThanhToan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.ForeColor = System.Drawing.Color.Black;
            this.txtThanhToan.Location = new System.Drawing.Point(114, 299);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.PasswordChar = '\0';
            this.txtThanhToan.Radius = 10;
            this.txtThanhToan.ReadOnly = true;
            this.txtThanhToan.SelectedText = "";
            this.txtThanhToan.Size = new System.Drawing.Size(197, 30);
            this.txtThanhToan.TabIndex = 24;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numSoLuong.Location = new System.Drawing.Point(114, 224);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(197, 27);
            this.numSoLuong.TabIndex = 23;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboKhachHang.BaseColor = System.Drawing.Color.White;
            this.cboKhachHang.BorderColor = System.Drawing.Color.Silver;
            this.cboKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhachHang.ForeColor = System.Drawing.Color.Black;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(114, 107);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboKhachHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboKhachHang.Radius = 10;
            this.cboKhachHang.Size = new System.Drawing.Size(197, 26);
            this.cboKhachHang.TabIndex = 18;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVien.BaseColor = System.Drawing.Color.White;
            this.cboNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(114, 68);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboNhanVien.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboNhanVien.Radius = 10;
            this.cboNhanVien.Size = new System.Drawing.Size(197, 26);
            this.cboNhanVien.TabIndex = 18;
            // 
            // cboHoa
            // 
            this.cboHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboHoa.BackColor = System.Drawing.Color.Transparent;
            this.cboHoa.BaseColor = System.Drawing.Color.White;
            this.cboHoa.BorderColor = System.Drawing.Color.Silver;
            this.cboHoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoa.FocusedColor = System.Drawing.Color.Empty;
            this.cboHoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHoa.ForeColor = System.Drawing.Color.Black;
            this.cboHoa.FormattingEnabled = true;
            this.cboHoa.Location = new System.Drawing.Point(114, 185);
            this.cboHoa.Name = "cboHoa";
            this.cboHoa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboHoa.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboHoa.Radius = 10;
            this.cboHoa.Size = new System.Drawing.Size(197, 26);
            this.cboHoa.TabIndex = 18;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayBan.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayBan.BaseColor = System.Drawing.Color.White;
            this.dtpNgayBan.BorderColor = System.Drawing.Color.Silver;
            this.dtpNgayBan.CustomFormat = null;
            this.dtpNgayBan.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBan.ForeColor = System.Drawing.Color.Black;
            this.dtpNgayBan.Location = new System.Drawing.Point(114, 143);
            this.dtpNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpNgayBan.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgayBan.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgayBan.OnPressedColor = System.Drawing.Color.Black;
            this.dtpNgayBan.Radius = 10;
            this.dtpNgayBan.Size = new System.Drawing.Size(197, 30);
            this.dtpNgayBan.TabIndex = 17;
            this.dtpNgayBan.Text = "Saturday, May 7, 2022";
            this.dtpNgayBan.Value = new System.DateTime(2022, 5, 7, 21, 47, 24, 525);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.txtMaHoaDon.BaseColor = System.Drawing.Color.White;
            this.txtMaHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtMaHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHoaDon.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaHoaDon.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtMaHoaDon.FocusedForeColor = System.Drawing.Color.Black;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaHoaDon.Location = new System.Drawing.Point(114, 26);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.PasswordChar = '\0';
            this.txtMaHoaDon.Radius = 10;
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.SelectedText = "";
            this.txtMaHoaDon.Size = new System.Drawing.Size(197, 30);
            this.txtMaHoaDon.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment:*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price:*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount:*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Flower:*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer:*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Staff:*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID Bill:*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiemMaHoa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTimKiemMaNhanVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(326, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_64;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(451, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 20;
            this.btnTimKiem.Size = new System.Drawing.Size(130, 52);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemMaHoa
            // 
            this.txtTimKiemMaHoa.AllowDrop = true;
            this.txtTimKiemMaHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemMaHoa.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemMaHoa.BaseColor = System.Drawing.Color.White;
            this.txtTimKiemMaHoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtTimKiemMaHoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemMaHoa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiemMaHoa.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtTimKiemMaHoa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKiemMaHoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMaHoa.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemMaHoa.Location = new System.Drawing.Point(228, 64);
            this.txtTimKiemMaHoa.Name = "txtTimKiemMaHoa";
            this.txtTimKiemMaHoa.PasswordChar = '\0';
            this.txtTimKiemMaHoa.Radius = 10;
            this.txtTimKiemMaHoa.SelectedText = "";
            this.txtTimKiemMaHoa.Size = new System.Drawing.Size(185, 32);
            this.txtTimKiemMaHoa.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(224, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Enter ID Flower:";
            // 
            // txtTimKiemMaNhanVien
            // 
            this.txtTimKiemMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemMaNhanVien.BaseColor = System.Drawing.Color.White;
            this.txtTimKiemMaNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtTimKiemMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemMaNhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiemMaNhanVien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtTimKiemMaNhanVien.FocusedForeColor = System.Drawing.Color.Black;
            this.txtTimKiemMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemMaNhanVien.Location = new System.Drawing.Point(10, 64);
            this.txtTimKiemMaNhanVien.Name = "txtTimKiemMaNhanVien";
            this.txtTimKiemMaNhanVien.PasswordChar = '\0';
            this.txtTimKiemMaNhanVien.Radius = 10;
            this.txtTimKiemMaNhanVien.SelectedText = "";
            this.txtTimKiemMaNhanVien.Size = new System.Drawing.Size(185, 32);
            this.txtTimKiemMaNhanVien.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Enter ID Staff: ";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(326, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvHoaDon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(593, 464);
            this.dgvHoaDon.TabIndex = 5;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInHoaDon.AnimationHoverSpeed = 0.07F;
            this.btnInHoaDon.AnimationSpeed = 0.03F;
            this.btnInHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnInHoaDon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnInHoaDon.BorderColor = System.Drawing.Color.Black;
            this.btnInHoaDon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInHoaDon.FocusedColor = System.Drawing.Color.Empty;
            this.btnInHoaDon.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Image = global::GUI.Properties.Resources.icons8_print_641;
            this.btnInHoaDon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInHoaDon.Location = new System.Drawing.Point(178, 382);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnInHoaDon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInHoaDon.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.OnHoverImage = null;
            this.btnInHoaDon.OnPressedColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Radius = 20;
            this.btnInHoaDon.Size = new System.Drawing.Size(133, 45);
            this.btnInHoaDon.TabIndex = 28;
            this.btnInHoaDon.Text = "Print";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 588);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "HoaDon";
            this.Text = "HoaDon1";
            this.Load += new System.EventHandler(this.HoaDon1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox txtMaHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpNgayBan;
        private Guna.UI.WinForms.GunaComboBox cboKhachHang;
        private Guna.UI.WinForms.GunaComboBox cboNhanVien;
        private Guna.UI.WinForms.GunaComboBox cboHoa;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private Guna.UI.WinForms.GunaTextBox txtThanhToan;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnBoQua;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnThemMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private Guna.UI.WinForms.GunaTextBox txtTimKiemMaNhanVien;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtTimKiemMaHoa;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private Guna.UI.WinForms.GunaButton btnInHoaDon;
    }
}