namespace QuanLyGiaoDichTaiChinh
{
    partial class frmKetNoiCSDL
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
            this.cboKieuXacThuc = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtTenMayChu = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnKiemTraKetNoi = new System.Windows.Forms.Button();
            this.cboCSDL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKQKiemTra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboKieuXacThuc
            // 
            this.cboKieuXacThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKieuXacThuc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboKieuXacThuc.FormattingEnabled = true;
            this.cboKieuXacThuc.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cboKieuXacThuc.Location = new System.Drawing.Point(135, 97);
            this.cboKieuXacThuc.Name = "cboKieuXacThuc";
            this.cboKieuXacThuc.Size = new System.Drawing.Size(207, 24);
            this.cboKieuXacThuc.TabIndex = 2;
            this.cboKieuXacThuc.SelectedIndexChanged += new System.EventHandler(this.cboKieuXacThuc_SelectedIndexChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(135, 163);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(207, 23);
            this.txtMatKhau.TabIndex = 4;
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Enabled = false;
            this.txtTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNguoiDung.Location = new System.Drawing.Point(135, 131);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(207, 23);
            this.txtTenNguoiDung.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label4.Location = new System.Drawing.Point(60, 166);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(65, 16);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Mật khẩu:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label3.Location = new System.Drawing.Point(22, 134);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 16);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Tên người dùng:";
            // 
            // txtTenMayChu
            // 
            this.txtTenMayChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMayChu.Location = new System.Drawing.Point(135, 68);
            this.txtTenMayChu.Name = "txtTenMayChu";
            this.txtTenMayChu.Size = new System.Drawing.Size(207, 23);
            this.txtTenMayChu.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label5.Location = new System.Drawing.Point(36, 100);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 16);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Kiểu xác thực:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label2.Location = new System.Drawing.Point(56, 224);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 16);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Tên CSDL:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Label1.Location = new System.Drawing.Point(38, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 16);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Tên máy chủ:";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(241, 8);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(100, 25);
            this.btnHuyBo.TabIndex = 8;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKetNoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKetNoi.Location = new System.Drawing.Point(134, 8);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(100, 25);
            this.btnKetNoi.TabIndex = 7;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKiemTraKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKiemTraKetNoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(135, 192);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(121, 23);
            this.btnKiemTraKetNoi.TabIndex = 5;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối";
            this.btnKiemTraKetNoi.UseVisualStyleBackColor = true;
            this.btnKiemTraKetNoi.Click += new System.EventHandler(this.btnKiemTraKetNoi_Click);
            // 
            // cboCSDL
            // 
            this.cboCSDL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboCSDL.FormattingEnabled = true;
            this.cboCSDL.Location = new System.Drawing.Point(135, 221);
            this.cboCSDL.Name = "cboCSDL";
            this.cboCSDL.Size = new System.Drawing.Size(207, 24);
            this.cboCSDL.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 54);
            this.label6.TabIndex = 19;
            this.label6.Text = "QUẢN LÝ GIAO DỊCH TÀI CHÍNH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnKetNoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 44);
            this.panel1.TabIndex = 20;
            // 
            // lblKQKiemTra
            // 
            this.lblKQKiemTra.AutoSize = true;
            this.lblKQKiemTra.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKQKiemTra.ForeColor = System.Drawing.Color.Green;
            this.lblKQKiemTra.Location = new System.Drawing.Point(136, 248);
            this.lblKQKiemTra.Name = "lblKQKiemTra";
            this.lblKQKiemTra.Size = new System.Drawing.Size(102, 16);
            this.lblKQKiemTra.TabIndex = 12;
            this.lblKQKiemTra.Text = "Kết quả kiểm tra";
            this.lblKQKiemTra.Visible = false;
            // 
            // frmKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(381, 330);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCSDL);
            this.Controls.Add(this.cboKieuXacThuc);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtTenMayChu);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.lblKQKiemTra);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetNoiCSDL";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU SQL SERVER";
            this.Load += new System.EventHandler(this.frmKetNoiCSDL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKetNoiCSDL_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKieuXacThuc;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnKiemTraKetNoi;
        private System.Windows.Forms.ComboBox cboCSDL;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.TextBox txtTenMayChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnKetNoi;
        internal System.Windows.Forms.Label lblKQKiemTra;
    }
}