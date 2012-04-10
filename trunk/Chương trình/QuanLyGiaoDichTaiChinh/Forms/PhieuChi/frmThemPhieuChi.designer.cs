namespace QuanLyGiaoDichTaiChinh
{
    partial class frmThemPhieuChi
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.nudSoTienChi = new System.Windows.Forms.NumericUpDown();
            this.cboKhoanChi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDaChi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienChi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(137, 223);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(285, 76);
            this.txtGhiChu.TabIndex = 70;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChi.Location = new System.Drawing.Point(137, 184);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(144, 23);
            this.dtpNgayChi.TabIndex = 69;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(137, 145);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(144, 23);
            this.dtpNgayLap.TabIndex = 68;
            // 
            // nudSoTienChi
            // 
            this.nudSoTienChi.Location = new System.Drawing.Point(137, 108);
            this.nudSoTienChi.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSoTienChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoTienChi.Name = "nudSoTienChi";
            this.nudSoTienChi.Size = new System.Drawing.Size(106, 23);
            this.nudSoTienChi.TabIndex = 67;
            this.nudSoTienChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoTienChi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboKhoanChi
            // 
            this.cboKhoanChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoanChi.FormattingEnabled = true;
            this.cboKhoanChi.Location = new System.Drawing.Point(137, 70);
            this.cboKhoanChi.Name = "cboKhoanChi";
            this.cboKhoanChi.Size = new System.Drawing.Size(285, 24);
            this.cboKhoanChi.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày chi:";
            // 
            // btnDaChi
            // 
            this.btnDaChi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDaChi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDaChi.Location = new System.Drawing.Point(255, 9);
            this.btnDaChi.Name = "btnDaChi";
            this.btnDaChi.Size = new System.Drawing.Size(80, 25);
            this.btnDaChi.TabIndex = 7;
            this.btnDaChi.Text = "Đã chi";
            this.btnDaChi.UseVisualStyleBackColor = true;
            this.btnDaChi.Click += new System.EventHandler(this.btnDaChi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 75;
            this.label4.Text = "Ngày lập:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Số tiền chi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Lý do chi:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(137, 32);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(285, 24);
            this.cboNhanVien.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tên nhân viên:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnDaChi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 44);
            this.panel1.TabIndex = 71;
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
            // frmThemPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(463, 368);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.dtpNgayChi);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.nudSoTienChi);
            this.Controls.Add(this.cboKhoanChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThemPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM PHIẾU CHI";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTienChi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.NumericUpDown nudSoTienChi;
        private System.Windows.Forms.ComboBox cboKhoanChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLuu;
    }
}