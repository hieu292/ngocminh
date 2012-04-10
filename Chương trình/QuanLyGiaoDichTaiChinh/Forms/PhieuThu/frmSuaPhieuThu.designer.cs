namespace QuanLyGiaoDichTaiChinh
{
    partial class frmSuaPhieuThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboKhoanThu = new System.Windows.Forms.ComboBox();
            this.nudSoTienThu = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.txtSoPT = new System.Windows.Forms.TextBox();
            this.btnDaThu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnDaThu);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 44);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tên khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(137, 68);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(285, 24);
            this.cboKhachHang.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Lý do thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Số tiền thu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Ghi chú:";
            // 
            // cboKhoanThu
            // 
            this.cboKhoanThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoanThu.FormattingEnabled = true;
            this.cboKhoanThu.Location = new System.Drawing.Point(137, 106);
            this.cboKhoanThu.Name = "cboKhoanThu";
            this.cboKhoanThu.Size = new System.Drawing.Size(285, 24);
            this.cboKhoanThu.TabIndex = 66;
            // 
            // nudSoTienThu
            // 
            this.nudSoTienThu.Location = new System.Drawing.Point(137, 144);
            this.nudSoTienThu.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSoTienThu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoTienThu.Name = "nudSoTienThu";
            this.nudSoTienThu.Size = new System.Drawing.Size(106, 23);
            this.nudSoTienThu.TabIndex = 67;
            this.nudSoTienThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoTienThu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(137, 181);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(144, 23);
            this.dtpNgayLap.TabIndex = 68;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThu.Location = new System.Drawing.Point(137, 220);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(144, 23);
            this.dtpNgayThu.TabIndex = 69;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLuu.Location = new System.Drawing.Point(169, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 25);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Số phiếu thu:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(137, 259);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(285, 76);
            this.txtGhiChu.TabIndex = 70;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(341, 9);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(80, 25);
            this.btnHuyBo.TabIndex = 8;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // txtSoPT
            // 
            this.txtSoPT.Location = new System.Drawing.Point(137, 27);
            this.txtSoPT.Name = "txtSoPT";
            this.txtSoPT.ReadOnly = true;
            this.txtSoPT.Size = new System.Drawing.Size(106, 23);
            this.txtSoPT.TabIndex = 79;
            // 
            // btnDaThu
            // 
            this.btnDaThu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDaThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDaThu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDaThu.Location = new System.Drawing.Point(255, 9);
            this.btnDaThu.Name = "btnDaThu";
            this.btnDaThu.Size = new System.Drawing.Size(80, 25);
            this.btnDaThu.TabIndex = 7;
            this.btnDaThu.Text = "Đã thu";
            this.btnDaThu.UseVisualStyleBackColor = true;
            this.btnDaThu.Click += new System.EventHandler(this.btnDaThu_Click);
            // 
            // frmSuaPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(463, 402);
            this.Controls.Add(this.txtSoPT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.nudSoTienThu);
            this.Controls.Add(this.cboKhoanThu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSuaPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SỬA PHIẾU THU";
            this.Load += new System.EventHandler(this.frmSuaPhieuThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDaThu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboKhoanThu;
        public System.Windows.Forms.NumericUpDown nudSoTienThu;
        public System.Windows.Forms.DateTimePicker dtpNgayLap;
        public System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtGhiChu;
        public System.Windows.Forms.TextBox txtSoPT;

    }
}