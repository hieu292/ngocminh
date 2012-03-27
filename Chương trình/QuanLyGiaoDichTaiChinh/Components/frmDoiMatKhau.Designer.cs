namespace QuanLyGiaoDichTaiChinh
{
    partial class frmDoiMatKhau
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
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblLoiMatKhauCu = new System.Windows.Forms.Label();
            this.lblLoiMatKhauMoi = new System.Windows.Forms.Label();
            this.lblLoiNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(263, 221);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(83, 23);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDongY.Location = new System.Drawing.Point(161, 221);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(83, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(161, 123);
            this.txtMatKhauMoi.MaxLength = 20;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(185, 23);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(17, 126);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(90, 16);
            this.lblMatKhauMoi.TabIndex = 7;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            this.lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(161, 74);
            this.txtMatKhauCu.MaxLength = 30;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(185, 23);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ GIAO DỊCH TÀI CHÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauCu.Location = new System.Drawing.Point(17, 77);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(82, 16);
            this.lblMatKhauCu.TabIndex = 5;
            this.lblMatKhauCu.Text = "Mật khẩu cũ:";
            this.lblMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.AutoSize = true;
            this.lblNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(17, 174);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(141, 16);
            this.lblNhapLaiMatKhauMoi.TabIndex = 7;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới:";
            this.lblNhapLaiMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(161, 171);
            this.txtNhapLaiMatKhauMoi.MaxLength = 20;
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(185, 23);
            this.txtNhapLaiMatKhauMoi.TabIndex = 3;
            this.txtNhapLaiMatKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapLaiMatKhauMoi_KeyDown);
            // 
            // lblLoiMatKhauCu
            // 
            this.lblLoiMatKhauCu.AutoSize = true;
            this.lblLoiMatKhauCu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiMatKhauCu.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhauCu.Location = new System.Drawing.Point(166, 100);
            this.lblLoiMatKhauCu.Name = "lblLoiMatKhauCu";
            this.lblLoiMatKhauCu.Size = new System.Drawing.Size(0, 13);
            this.lblLoiMatKhauCu.TabIndex = 12;
            this.lblLoiMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoiMatKhauMoi
            // 
            this.lblLoiMatKhauMoi.AutoSize = true;
            this.lblLoiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiMatKhauMoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMatKhauMoi.Location = new System.Drawing.Point(166, 148);
            this.lblLoiMatKhauMoi.Name = "lblLoiMatKhauMoi";
            this.lblLoiMatKhauMoi.Size = new System.Drawing.Size(0, 13);
            this.lblLoiMatKhauMoi.TabIndex = 13;
            this.lblLoiMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoiNhapLaiMatKhauMoi
            // 
            this.lblLoiNhapLaiMatKhauMoi.AutoSize = true;
            this.lblLoiNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhapLaiMatKhauMoi.Location = new System.Drawing.Point(166, 197);
            this.lblLoiNhapLaiMatKhauMoi.Name = "lblLoiNhapLaiMatKhauMoi";
            this.lblLoiNhapLaiMatKhauMoi.Size = new System.Drawing.Size(0, 13);
            this.lblLoiNhapLaiMatKhauMoi.TabIndex = 14;
            this.lblLoiNhapLaiMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(375, 262);
            this.Controls.Add(this.lblLoiNhapLaiMatKhauMoi);
            this.Controls.Add(this.lblLoiMatKhauMoi);
            this.Controls.Add(this.lblLoiMatKhauCu);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMatKhauCu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDongY;
        public System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        public System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        public System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Label lblLoiMatKhauCu;
        private System.Windows.Forms.Label lblLoiMatKhauMoi;
        private System.Windows.Forms.Label lblLoiNhapLaiMatKhauMoi;
    }
}