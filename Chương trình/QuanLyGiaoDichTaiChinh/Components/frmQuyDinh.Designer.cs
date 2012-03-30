namespace QuanLyGiaoDichTaiChinh
{
    partial class frmQuyDinh
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
            this.tabControlQuyDinh = new System.Windows.Forms.TabControl();
            this.tabCongTy = new System.Windows.Forms.TabPage();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblTaiKhoanCo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabSaoLuu = new System.Windows.Forms.TabPage();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.txtViTriSaoLuu = new System.Windows.Forms.TextBox();
            this.nudLichSaoLuu = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThoiDiemSaoLuu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTimKiemTuDong = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.rdbTat = new System.Windows.Forms.RadioButton();
            this.rdbBat = new System.Windows.Forms.RadioButton();
            this.tabControlQuyDinh.SuspendLayout();
            this.tabCongTy.SuspendLayout();
            this.tabSaoLuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLichSaoLuu)).BeginInit();
            this.tabTimKiemTuDong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQuyDinh
            // 
            this.tabControlQuyDinh.Controls.Add(this.tabCongTy);
            this.tabControlQuyDinh.Controls.Add(this.tabSaoLuu);
            this.tabControlQuyDinh.Controls.Add(this.tabTimKiemTuDong);
            this.tabControlQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuyDinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuyDinh.Name = "tabControlQuyDinh";
            this.tabControlQuyDinh.SelectedIndex = 0;
            this.tabControlQuyDinh.Size = new System.Drawing.Size(528, 216);
            this.tabControlQuyDinh.TabIndex = 0;
            // 
            // tabCongTy
            // 
            this.tabCongTy.BackColor = System.Drawing.Color.Lavender;
            this.tabCongTy.Controls.Add(this.txtDienThoai);
            this.tabCongTy.Controls.Add(this.txtDiaChi);
            this.tabCongTy.Controls.Add(this.lblTaiKhoanCo);
            this.tabCongTy.Controls.Add(this.label4);
            this.tabCongTy.Controls.Add(this.txtTenCongTy);
            this.tabCongTy.Controls.Add(this.label8);
            this.tabCongTy.Controls.Add(this.label7);
            this.tabCongTy.Controls.Add(this.label6);
            this.tabCongTy.Location = new System.Drawing.Point(4, 25);
            this.tabCongTy.Name = "tabCongTy";
            this.tabCongTy.Padding = new System.Windows.Forms.Padding(3);
            this.tabCongTy.Size = new System.Drawing.Size(520, 187);
            this.tabCongTy.TabIndex = 0;
            this.tabCongTy.Text = "Thông tin công ty";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(128, 97);
            this.txtDienThoai.MaxLength = 11;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(363, 23);
            this.txtDienThoai.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(128, 65);
            this.txtDiaChi.MaxLength = 255;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(363, 23);
            this.txtDiaChi.TabIndex = 2;
            // 
            // lblTaiKhoanCo
            // 
            this.lblTaiKhoanCo.AutoSize = true;
            this.lblTaiKhoanCo.BackColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoanCo.Location = new System.Drawing.Point(125, 131);
            this.lblTaiKhoanCo.Name = "lblTaiKhoanCo";
            this.lblTaiKhoanCo.Size = new System.Drawing.Size(15, 16);
            this.lblTaiKhoanCo.TabIndex = 0;
            this.lblTaiKhoanCo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài khoản có:";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(128, 33);
            this.txtTenCongTy.MaxLength = 255;
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(363, 23);
            this.txtTenCongTy.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên công ty:";
            // 
            // tabSaoLuu
            // 
            this.tabSaoLuu.BackColor = System.Drawing.Color.Lavender;
            this.tabSaoLuu.Controls.Add(this.btnDuyet);
            this.tabSaoLuu.Controls.Add(this.txtViTriSaoLuu);
            this.tabSaoLuu.Controls.Add(this.nudLichSaoLuu);
            this.tabSaoLuu.Controls.Add(this.label5);
            this.tabSaoLuu.Controls.Add(this.label1);
            this.tabSaoLuu.Controls.Add(this.lblThoiDiemSaoLuu);
            this.tabSaoLuu.Controls.Add(this.label3);
            this.tabSaoLuu.Controls.Add(this.label2);
            this.tabSaoLuu.Location = new System.Drawing.Point(4, 25);
            this.tabSaoLuu.Name = "tabSaoLuu";
            this.tabSaoLuu.Padding = new System.Windows.Forms.Padding(3);
            this.tabSaoLuu.Size = new System.Drawing.Size(520, 187);
            this.tabSaoLuu.TabIndex = 1;
            this.tabSaoLuu.Text = "Sao lưu";
            // 
            // btnDuyet
            // 
            this.btnDuyet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDuyet.BackColor = System.Drawing.Color.Transparent;
            this.btnDuyet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDuyet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDuyet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDuyet.Location = new System.Drawing.Point(433, 73);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(59, 23);
            this.btnDuyet.TabIndex = 8;
            this.btnDuyet.Text = "Mở...";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // txtViTriSaoLuu
            // 
            this.txtViTriSaoLuu.Location = new System.Drawing.Point(119, 73);
            this.txtViTriSaoLuu.Name = "txtViTriSaoLuu";
            this.txtViTriSaoLuu.Size = new System.Drawing.Size(308, 23);
            this.txtViTriSaoLuu.TabIndex = 7;
            // 
            // nudLichSaoLuu
            // 
            this.nudLichSaoLuu.Location = new System.Drawing.Point(119, 32);
            this.nudLichSaoLuu.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudLichSaoLuu.Name = "nudLichSaoLuu";
            this.nudLichSaoLuu.Size = new System.Drawing.Size(78, 23);
            this.nudLichSaoLuu.TabIndex = 6;
            this.nudLichSaoLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLichSaoLuu.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Vị trí sao lưu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thời điểm sao lưu tiếp theo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThoiDiemSaoLuu
            // 
            this.lblThoiDiemSaoLuu.AutoSize = true;
            this.lblThoiDiemSaoLuu.Location = new System.Drawing.Point(203, 112);
            this.lblThoiDiemSaoLuu.Name = "lblThoiDiemSaoLuu";
            this.lblThoiDiemSaoLuu.Size = new System.Drawing.Size(35, 16);
            this.lblThoiDiemSaoLuu.TabIndex = 23;
            this.lblThoiDiemSaoLuu.Text = "ngày";
            this.lblThoiDiemSaoLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ngày";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Lịch sao lưu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTimKiemTuDong
            // 
            this.tabTimKiemTuDong.BackColor = System.Drawing.Color.Lavender;
            this.tabTimKiemTuDong.Controls.Add(this.rdbTat);
            this.tabTimKiemTuDong.Controls.Add(this.rdbBat);
            this.tabTimKiemTuDong.Location = new System.Drawing.Point(4, 25);
            this.tabTimKiemTuDong.Name = "tabTimKiemTuDong";
            this.tabTimKiemTuDong.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimKiemTuDong.Size = new System.Drawing.Size(520, 187);
            this.tabTimKiemTuDong.TabIndex = 2;
            this.tabTimKiemTuDong.Text = "Tìm kiếm tự động";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 41);
            this.panel1.TabIndex = 21;
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDongY.BackColor = System.Drawing.Color.Transparent;
            this.btnDongY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDongY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDongY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDongY.Location = new System.Drawing.Point(185, 8);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 4;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(266, 8);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // rdbTat
            // 
            this.rdbTat.AutoSize = true;
            this.rdbTat.Location = new System.Drawing.Point(263, 26);
            this.rdbTat.Name = "rdbTat";
            this.rdbTat.Size = new System.Drawing.Size(45, 20);
            this.rdbTat.TabIndex = 12;
            this.rdbTat.Text = "Tắt";
            this.rdbTat.UseVisualStyleBackColor = true;
            // 
            // rdbBat
            // 
            this.rdbBat.AutoSize = true;
            this.rdbBat.Checked = true;
            this.rdbBat.Location = new System.Drawing.Point(213, 26);
            this.rdbBat.Name = "rdbBat";
            this.rdbBat.Size = new System.Drawing.Size(44, 20);
            this.rdbBat.TabIndex = 11;
            this.rdbBat.TabStop = true;
            this.rdbBat.Text = "Bật";
            this.rdbBat.UseVisualStyleBackColor = true;
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(528, 257);
            this.Controls.Add(this.tabControlQuyDinh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuyDinh";
            this.Text = "QUY ĐỊNH";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            this.tabControlQuyDinh.ResumeLayout(false);
            this.tabCongTy.ResumeLayout(false);
            this.tabCongTy.PerformLayout();
            this.tabSaoLuu.ResumeLayout(false);
            this.tabSaoLuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLichSaoLuu)).EndInit();
            this.tabTimKiemTuDong.ResumeLayout(false);
            this.tabTimKiemTuDong.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuyDinh;
        private System.Windows.Forms.TabPage tabCongTy;
        private System.Windows.Forms.TabPage tabSaoLuu;
        private System.Windows.Forms.TabPage tabTimKiemTuDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.NumericUpDown nudLichSaoLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label lblTaiKhoanCo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.TextBox txtViTriSaoLuu;
        private System.Windows.Forms.Label lblThoiDiemSaoLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbTat;
        private System.Windows.Forms.RadioButton rdbBat;
    }
}