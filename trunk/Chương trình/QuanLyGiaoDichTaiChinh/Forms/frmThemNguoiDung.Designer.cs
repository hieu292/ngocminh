namespace QuanLyGiaoDichTaiChinh
{
    partial class frmThemNguoiDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhauXacNhan = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiNguoiDung = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(153, 23);
            this.txtTenDangNhap.MaxLength = 100;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(202, 23);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtMatKhauXacNhan
            // 
            this.txtMatKhauXacNhan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauXacNhan.Location = new System.Drawing.Point(153, 137);
            this.txtMatKhauXacNhan.MaxLength = 50;
            this.txtMatKhauXacNhan.Name = "txtMatKhauXacNhan";
            this.txtMatKhauXacNhan.PasswordChar = '*';
            this.txtMatKhauXacNhan.Size = new System.Drawing.Size(202, 23);
            this.txtMatKhauXacNhan.TabIndex = 4;
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.AutoSize = true;
            this.lblNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(31, 140);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(116, 16);
            this.lblNhapLaiMatKhauMoi.TabIndex = 16;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu:";
            this.lblNhapLaiMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(153, 100);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(202, 23);
            this.txtMatKhau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đầy đủ:";
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(153, 173);
            this.txtTenNguoiDung.MaxLength = 100;
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(202, 23);
            this.txtTenNguoiDung.TabIndex = 5;
            this.txtTenNguoiDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNguoiDung_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhóm người dùng:";
            // 
            // cboLoaiNguoiDung
            // 
            this.cboLoaiNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNguoiDung.FormattingEnabled = true;
            this.cboLoaiNguoiDung.Location = new System.Drawing.Point(153, 61);
            this.cboLoaiNguoiDung.Name = "cboLoaiNguoiDung";
            this.cboLoaiNguoiDung.Size = new System.Drawing.Size(202, 24);
            this.cboLoaiNguoiDung.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 44);
            this.panel1.TabIndex = 62;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(274, 8);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 25);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Location = new System.Drawing.Point(188, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 25);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboLoaiNguoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMatKhauXacNhan);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMatKhauXacNhan;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        public System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.TextBox txtTenDangNhap;
        public System.Windows.Forms.ComboBox cboLoaiNguoiDung;
    }
}