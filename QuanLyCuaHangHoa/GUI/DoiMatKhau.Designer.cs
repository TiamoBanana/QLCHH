
namespace GUI
{
    partial class DoiMatKhau
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new Guna.UI.WinForms.GunaButton();
            this.txtNhapLaiMatKhau = new Guna.UI.WinForms.GunaTextBox();
            this.txtMatKhauMoi = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(236)))));
            this.groupBox2.Controls.Add(this.lblTenNguoiDung);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.txtNhapLaiMatKhau);
            this.groupBox2.Controls.Add(this.txtMatKhauMoi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDoiMatKhau);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 450);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHANGE PASSWORD";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnBoQua.Location = new System.Drawing.Point(100, 277);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnBoQua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnBoQua.OnHoverImage = null;
            this.btnBoQua.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoQua.Radius = 20;
            this.btnBoQua.Size = new System.Drawing.Size(111, 46);
            this.btnBoQua.TabIndex = 13;
            this.btnBoQua.Text = "Skip";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.AllowDrop = true;
            this.txtNhapLaiMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapLaiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtNhapLaiMatKhau.BaseColor = System.Drawing.Color.White;
            this.txtNhapLaiMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtNhapLaiMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiMatKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNhapLaiMatKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtNhapLaiMatKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(194, 70);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '\0';
            this.txtNhapLaiMatKhau.Radius = 10;
            this.txtNhapLaiMatKhau.SelectedText = "";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(114, 32);
            this.txtNhapLaiMatKhau.TabIndex = 11;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhauMoi.BaseColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(171)))), ((int)(((byte)(183)))));
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.txtMatKhauMoi.FocusedForeColor = System.Drawing.Color.Black;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(194, 32);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '\0';
            this.txtMatKhauMoi.Radius = 10;
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(114, 32);
            this.txtMatKhauMoi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Re-Enter Password*:";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDoiMatKhau.AnimationHoverSpeed = 0.07F;
            this.btnDoiMatKhau.AnimationSpeed = 0.03F;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(217)))), ((int)(((byte)(200)))));
            this.btnDoiMatKhau.BorderColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMatKhau.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Letter Gothic Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Image = global::GUI.Properties.Resources.icons8_plus_math_64;
            this.btnDoiMatKhau.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDoiMatKhau.Location = new System.Drawing.Point(58, 169);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(183)))), ((int)(((byte)(201)))));
            this.btnDoiMatKhau.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.OnHoverImage = null;
            this.btnDoiMatKhau.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Radius = 20;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(209, 91);
            this.btnDoiMatKhau.TabIndex = 8;
            this.btnDoiMatKhau.Text = "Change Password";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Letter Gothic Std", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "New Password*: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Untitled_design1;
            this.pictureBox1.Location = new System.Drawing.Point(318, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(12, 118);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(59, 20);
            this.lblTenNguoiDung.TabIndex = 14;
            this.lblTenNguoiDung.Text = "User:";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox txtNhapLaiMatKhau;
        private Guna.UI.WinForms.GunaTextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnDoiMatKhau;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaButton btnBoQua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTenNguoiDung;
    }
}