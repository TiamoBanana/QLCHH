
namespace GUI
{
    partial class TaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMo = new Guna.UI.WinForms.GunaButton();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtAnh = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNhanVien = new Guna.UI.WinForms.GunaComboBox();
            this.txtMatKhau = new Guna.UI.WinForms.GunaTextBox();
            this.txtDuongDan = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radNhanVien = new Guna.UI.WinForms.GunaRadioButton();
            this.radQuanTrivien = new Guna.UI.WinForms.GunaRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKienNguoiDung = new Guna.UI.WinForms.GunaTextBox();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.txtTimKiemTenTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.btnBoQua = new Guna.UI.WinForms.GunaButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnThemMoi = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnMo);
            this.groupBox1.Controls.Add(this.picAnh);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtDuongDan);
            this.groupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radNhanVien);
            this.groupBox1.Controls.Add(this.radQuanTrivien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCOUNT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(495, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Image:*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnMo
            // 
            this.btnMo.AnimationHoverSpeed = 0.07F;
            this.btnMo.AnimationSpeed = 0.03F;
            this.btnMo.BackColor = System.Drawing.Color.Transparent;
            this.btnMo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnMo.BorderColor = System.Drawing.Color.Black;
            this.btnMo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMo.FocusedColor = System.Drawing.Color.Empty;
            this.btnMo.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.ForeColor = System.Drawing.Color.Black;
            this.btnMo.Image = global::GUI.Properties.Resources.icons8_open_door_64;
            this.btnMo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMo.Location = new System.Drawing.Point(673, 64);
            this.btnMo.Name = "btnMo";
            this.btnMo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnMo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMo.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnMo.OnHoverImage = null;
            this.btnMo.OnPressedColor = System.Drawing.Color.Black;
            this.btnMo.Radius = 20;
            this.btnMo.Size = new System.Drawing.Size(109, 39);
            this.btnMo.TabIndex = 23;
            this.btnMo.Text = "Open";
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // picAnh
            // 
            this.picAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picAnh.Location = new System.Drawing.Point(821, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(158, 140);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 22;
            this.picAnh.TabStop = false;
            // 
            // txtAnh
            // 
            this.txtAnh.BackColor = System.Drawing.Color.Transparent;
            this.txtAnh.BaseColor = System.Drawing.Color.White;
            this.txtAnh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAnh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtAnh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAnh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.ForeColor = System.Drawing.Color.Black;
            this.txtAnh.Location = new System.Drawing.Point(297, -45);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.PasswordChar = '\0';
            this.txtAnh.Radius = 10;
            this.txtAnh.SelectedText = "";
            this.txtAnh.Size = new System.Drawing.Size(209, 32);
            this.txtAnh.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(219, -38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Image:*";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVien.BaseColor = System.Drawing.Color.White;
            this.cboNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.cboNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(171, 28);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboNhanVien.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboNhanVien.Radius = 10;
            this.cboNhanVien.Size = new System.Drawing.Size(254, 26);
            this.cboNhanVien.TabIndex = 19;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.BaseColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMatKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtMatKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(171, 109);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.Radius = 10;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(254, 32);
            this.txtMatKhau.TabIndex = 15;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.txtDuongDan.BaseColor = System.Drawing.Color.White;
            this.txtDuongDan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtDuongDan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuongDan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDuongDan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtDuongDan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDuongDan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.ForeColor = System.Drawing.Color.Black;
            this.txtDuongDan.Location = new System.Drawing.Point(573, 26);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '\0';
            this.txtDuongDan.Radius = 10;
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(229, 32);
            this.txtDuongDan.TabIndex = 15;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenTaiKhoan.BaseColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtTenTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(171, 67);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.Radius = 10;
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(254, 32);
            this.txtTenTaiKhoan.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(495, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Authorities:*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:*";
            // 
            // radNhanVien
            // 
            this.radNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radNhanVien.BaseColor = System.Drawing.SystemColors.Control;
            this.radNhanVien.CheckedOffColor = System.Drawing.Color.Gray;
            this.radNhanVien.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radNhanVien.FillColor = System.Drawing.Color.White;
            this.radNhanVien.ForeColor = System.Drawing.Color.Black;
            this.radNhanVien.Location = new System.Drawing.Point(617, 138);
            this.radNhanVien.Name = "radNhanVien";
            this.radNhanVien.Size = new System.Drawing.Size(54, 20);
            this.radNhanVien.TabIndex = 11;
            this.radNhanVien.Text = "User";
            // 
            // radQuanTrivien
            // 
            this.radQuanTrivien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radQuanTrivien.BaseColor = System.Drawing.SystemColors.Control;
            this.radQuanTrivien.CheckedOffColor = System.Drawing.Color.Gray;
            this.radQuanTrivien.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.radQuanTrivien.FillColor = System.Drawing.Color.White;
            this.radQuanTrivien.ForeColor = System.Drawing.Color.Black;
            this.radQuanTrivien.Location = new System.Drawing.Point(499, 138);
            this.radQuanTrivien.Name = "radQuanTrivien";
            this.radQuanTrivien.Size = new System.Drawing.Size(62, 20);
            this.radQuanTrivien.TabIndex = 11;
            this.radQuanTrivien.Text = "Admin";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Account:*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Staff Name:*";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.groupBox2.Controls.Add(this.txtTimKienNguoiDung);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.txtTimKiemTenTaiKhoan);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThemMoi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 289);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADVANCED CONTROLS";
            // 
            // txtTimKienNguoiDung
            // 
            this.txtTimKienNguoiDung.AllowDrop = true;
            this.txtTimKienNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKienNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKienNguoiDung.BaseColor = System.Drawing.Color.White;
            this.txtTimKienNguoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtTimKienNguoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKienNguoiDung.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKienNguoiDung.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtTimKienNguoiDung.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTimKienNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKienNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtTimKienNguoiDung.Location = new System.Drawing.Point(171, 52);
            this.txtTimKienNguoiDung.Name = "txtTimKienNguoiDung";
            this.txtTimKienNguoiDung.PasswordChar = '\0';
            this.txtTimKienNguoiDung.Radius = 10;
            this.txtTimKienNguoiDung.SelectedText = "";
            this.txtTimKienNguoiDung.Size = new System.Drawing.Size(114, 32);
            this.txtTimKienNguoiDung.TabIndex = 11;
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
            this.btnTimKiem.Location = new System.Drawing.Point(305, 26);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 20;
            this.btnTimKiem.Size = new System.Drawing.Size(130, 52);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(253, 130);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 20;
            this.btnLuu.Size = new System.Drawing.Size(133, 45);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Save";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnSua.Location = new System.Drawing.Point(253, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Radius = 20;
            this.btnSua.Size = new System.Drawing.Size(133, 45);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Update";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTimKiemTenTaiKhoan
            // 
            this.txtTimKiemTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiemTenTaiKhoan.BaseColor = System.Drawing.Color.White;
            this.txtTimKiemTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtTimKiemTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiemTenTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTimKiemTenTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtTimKiemTenTaiKhoan.FocusedForeColor = System.Drawing.Color.Black;
            this.txtTimKiemTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiemTenTaiKhoan.Location = new System.Drawing.Point(171, 19);
            this.txtTimKiemTenTaiKhoan.Name = "txtTimKiemTenTaiKhoan";
            this.txtTimKiemTenTaiKhoan.PasswordChar = '\0';
            this.txtTimKiemTenTaiKhoan.Radius = 10;
            this.txtTimKiemTenTaiKhoan.SelectedText = "";
            this.txtTimKiemTenTaiKhoan.Size = new System.Drawing.Size(114, 32);
            this.txtTimKiemTenTaiKhoan.TabIndex = 12;
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
            this.btnBoQua.Location = new System.Drawing.Point(106, 130);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnBoQua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverImage = null;
            this.btnBoQua.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoQua.Radius = 20;
            this.btnBoQua.Size = new System.Drawing.Size(133, 45);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Skip";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Enter Staff Name:";
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
            this.btnXoa.Location = new System.Drawing.Point(253, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 20;
            this.btnXoa.Size = new System.Drawing.Size(133, 45);
            this.btnXoa.TabIndex = 7;
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
            this.btnThemMoi.Location = new System.Drawing.Point(76, 186);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnThemMoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnThemMoi.OnHoverImage = null;
            this.btnThemMoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemMoi.Radius = 20;
            this.btnThemMoi.Size = new System.Drawing.Size(163, 91);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Create New";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Enter Account: ";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(458, 0);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTaiKhoan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(533, 289);
            this.dgvTaiKhoan.TabIndex = 5;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            this.dgvTaiKhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTaiKhoan_CellFormatting);
            this.dgvTaiKhoan.Click += new System.EventHandler(this.dgvTaiKhoan_Click);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnMo;
        private System.Windows.Forms.PictureBox picAnh;
        private Guna.UI.WinForms.GunaTextBox txtAnh;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaComboBox cboNhanVien;
        private Guna.UI.WinForms.GunaTextBox txtMatKhau;
        private Guna.UI.WinForms.GunaTextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaRadioButton radNhanVien;
        private Guna.UI.WinForms.GunaRadioButton radQuanTrivien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox txtTimKienNguoiDung;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaButton btnLuu;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaTextBox txtTimKiemTenTaiKhoan;
        private Guna.UI.WinForms.GunaButton btnBoQua;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnThemMoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private Guna.UI.WinForms.GunaTextBox txtDuongDan;
    }
}