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
            this.tabSiSo = new System.Windows.Forms.TabPage();
            this.nudSiSoCanTren = new System.Windows.Forms.NumericUpDown();
            this.nudSiSoCanDuoi = new System.Windows.Forms.NumericUpDown();
            this.lblSiSoCanTren = new System.Windows.Forms.Label();
            this.lblSiSoCanDuoi = new System.Windows.Forms.Label();
            this.tabDoTuoi = new System.Windows.Forms.TabPage();
            this.nudDoTuoiCanTren = new System.Windows.Forms.NumericUpDown();
            this.nudDoTuoiCanDuoi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabThangDiem = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbThangDiem100 = new System.Windows.Forms.RadioButton();
            this.rdbThangDiem10 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabThongTinTruong = new System.Windows.Forms.TabPage();
            this.txtDiaChiTruong = new System.Windows.Forms.TextBox();
            this.txtTenTruong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.tabControlQuyDinh.SuspendLayout();
            this.tabSiSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSoCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSoCanDuoi)).BeginInit();
            this.tabDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoTuoiCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoTuoiCanDuoi)).BeginInit();
            this.tabThangDiem.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabThongTinTruong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlQuyDinh
            // 
            this.tabControlQuyDinh.Controls.Add(this.tabSiSo);
            this.tabControlQuyDinh.Controls.Add(this.tabDoTuoi);
            this.tabControlQuyDinh.Controls.Add(this.tabThangDiem);
            this.tabControlQuyDinh.Controls.Add(this.tabThongTinTruong);
            this.tabControlQuyDinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuyDinh.Name = "tabControlQuyDinh";
            this.tabControlQuyDinh.SelectedIndex = 0;
            this.tabControlQuyDinh.Size = new System.Drawing.Size(351, 140);
            this.tabControlQuyDinh.TabIndex = 0;
            // 
            // tabSiSo
            // 
            this.tabSiSo.BackColor = System.Drawing.Color.Lavender;
            this.tabSiSo.Controls.Add(this.nudSiSoCanTren);
            this.tabSiSo.Controls.Add(this.nudSiSoCanDuoi);
            this.tabSiSo.Controls.Add(this.lblSiSoCanTren);
            this.tabSiSo.Controls.Add(this.lblSiSoCanDuoi);
            this.tabSiSo.Location = new System.Drawing.Point(4, 25);
            this.tabSiSo.Name = "tabSiSo";
            this.tabSiSo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSiSo.Size = new System.Drawing.Size(343, 111);
            this.tabSiSo.TabIndex = 0;
            this.tabSiSo.Text = "Sĩ số";
            // 
            // nudSiSoCanTren
            // 
            this.nudSiSoCanTren.Location = new System.Drawing.Point(210, 65);
            this.nudSiSoCanTren.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSiSoCanTren.Name = "nudSiSoCanTren";
            this.nudSiSoCanTren.Size = new System.Drawing.Size(109, 23);
            this.nudSiSoCanTren.TabIndex = 2;
            this.nudSiSoCanTren.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudSiSoCanDuoi
            // 
            this.nudSiSoCanDuoi.Location = new System.Drawing.Point(210, 32);
            this.nudSiSoCanDuoi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSiSoCanDuoi.Name = "nudSiSoCanDuoi";
            this.nudSiSoCanDuoi.Size = new System.Drawing.Size(109, 23);
            this.nudSiSoCanDuoi.TabIndex = 2;
            this.nudSiSoCanDuoi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblSiSoCanTren
            // 
            this.lblSiSoCanTren.AutoSize = true;
            this.lblSiSoCanTren.Location = new System.Drawing.Point(26, 67);
            this.lblSiSoCanTren.Name = "lblSiSoCanTren";
            this.lblSiSoCanTren.Size = new System.Drawing.Size(151, 16);
            this.lblSiSoCanTren.TabIndex = 1;
            this.lblSiSoCanTren.Text = "Sĩ số tối đa trên một lớp:";
            this.lblSiSoCanTren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSiSoCanDuoi
            // 
            this.lblSiSoCanDuoi.AutoSize = true;
            this.lblSiSoCanDuoi.Location = new System.Drawing.Point(26, 34);
            this.lblSiSoCanDuoi.Name = "lblSiSoCanDuoi";
            this.lblSiSoCanDuoi.Size = new System.Drawing.Size(165, 16);
            this.lblSiSoCanDuoi.TabIndex = 1;
            this.lblSiSoCanDuoi.Text = "Sĩ số tối thiểu trên một lớp:";
            this.lblSiSoCanDuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabDoTuoi
            // 
            this.tabDoTuoi.BackColor = System.Drawing.Color.Lavender;
            this.tabDoTuoi.Controls.Add(this.nudDoTuoiCanTren);
            this.tabDoTuoi.Controls.Add(this.nudDoTuoiCanDuoi);
            this.tabDoTuoi.Controls.Add(this.label1);
            this.tabDoTuoi.Controls.Add(this.label2);
            this.tabDoTuoi.Location = new System.Drawing.Point(4, 25);
            this.tabDoTuoi.Name = "tabDoTuoi";
            this.tabDoTuoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoTuoi.Size = new System.Drawing.Size(343, 111);
            this.tabDoTuoi.TabIndex = 1;
            this.tabDoTuoi.Text = "Độ tuổi";
            // 
            // nudDoTuoiCanTren
            // 
            this.nudDoTuoiCanTren.Location = new System.Drawing.Point(211, 65);
            this.nudDoTuoiCanTren.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudDoTuoiCanTren.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDoTuoiCanTren.Name = "nudDoTuoiCanTren";
            this.nudDoTuoiCanTren.Size = new System.Drawing.Size(108, 23);
            this.nudDoTuoiCanTren.TabIndex = 25;
            this.nudDoTuoiCanTren.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudDoTuoiCanDuoi
            // 
            this.nudDoTuoiCanDuoi.Location = new System.Drawing.Point(211, 32);
            this.nudDoTuoiCanDuoi.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudDoTuoiCanDuoi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDoTuoiCanDuoi.Name = "nudDoTuoiCanDuoi";
            this.nudDoTuoiCanDuoi.Size = new System.Drawing.Size(108, 23);
            this.nudDoTuoiCanDuoi.TabIndex = 24;
            this.nudDoTuoiCanDuoi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Độ tuổi tối đa của học sinh:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Độ tuổi tối thiểu của học sinh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabThangDiem
            // 
            this.tabThangDiem.BackColor = System.Drawing.Color.Lavender;
            this.tabThangDiem.Controls.Add(this.panel4);
            this.tabThangDiem.Controls.Add(this.label3);
            this.tabThangDiem.Location = new System.Drawing.Point(4, 25);
            this.tabThangDiem.Name = "tabThangDiem";
            this.tabThangDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabThangDiem.Size = new System.Drawing.Size(343, 111);
            this.tabThangDiem.TabIndex = 2;
            this.tabThangDiem.Text = "Thang điểm";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbThangDiem100);
            this.panel4.Controls.Add(this.rdbThangDiem10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 76);
            this.panel4.TabIndex = 27;
            // 
            // rdbThangDiem100
            // 
            this.rdbThangDiem100.AutoSize = true;
            this.rdbThangDiem100.Location = new System.Drawing.Point(53, 40);
            this.rdbThangDiem100.Name = "rdbThangDiem100";
            this.rdbThangDiem100.Size = new System.Drawing.Size(119, 20);
            this.rdbThangDiem100.TabIndex = 0;
            this.rdbThangDiem100.Text = "Thang điểm 100";
            this.rdbThangDiem100.UseVisualStyleBackColor = true;
            // 
            // rdbThangDiem10
            // 
            this.rdbThangDiem10.AutoSize = true;
            this.rdbThangDiem10.Checked = true;
            this.rdbThangDiem10.Location = new System.Drawing.Point(53, 17);
            this.rdbThangDiem10.Name = "rdbThangDiem10";
            this.rdbThangDiem10.Size = new System.Drawing.Size(112, 20);
            this.rdbThangDiem10.TabIndex = 0;
            this.rdbThangDiem10.TabStop = true;
            this.rdbThangDiem10.Text = "Thang điểm 10";
            this.rdbThangDiem10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thang điểm sử dụng để đánh giá kết quả học tập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabThongTinTruong
            // 
            this.tabThongTinTruong.BackColor = System.Drawing.Color.Lavender;
            this.tabThongTinTruong.Controls.Add(this.txtDiaChiTruong);
            this.tabThongTinTruong.Controls.Add(this.txtTenTruong);
            this.tabThongTinTruong.Controls.Add(this.label4);
            this.tabThongTinTruong.Controls.Add(this.label5);
            this.tabThongTinTruong.Location = new System.Drawing.Point(4, 25);
            this.tabThongTinTruong.Name = "tabThongTinTruong";
            this.tabThongTinTruong.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinTruong.Size = new System.Drawing.Size(343, 111);
            this.tabThongTinTruong.TabIndex = 3;
            this.tabThongTinTruong.Text = "Thông tin trường";
            // 
            // txtDiaChiTruong
            // 
            this.txtDiaChiTruong.Location = new System.Drawing.Point(127, 64);
            this.txtDiaChiTruong.MaxLength = 50;
            this.txtDiaChiTruong.Name = "txtDiaChiTruong";
            this.txtDiaChiTruong.Size = new System.Drawing.Size(192, 23);
            this.txtDiaChiTruong.TabIndex = 27;
            // 
            // txtTenTruong
            // 
            this.txtTenTruong.Location = new System.Drawing.Point(127, 29);
            this.txtTenTruong.MaxLength = 50;
            this.txtTenTruong.Name = "txtTenTruong";
            this.txtTenTruong.Size = new System.Drawing.Size(192, 23);
            this.txtTenTruong.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Trường:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Phòng GD && ĐT:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 41);
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
            this.btnDongY.Location = new System.Drawing.Point(166, 9);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 19;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHuyBo.Location = new System.Drawing.Point(247, 9);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 20;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(347, 177);
            this.Controls.Add(this.tabControlQuyDinh);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuyDinh";
            this.Text = "QUY ĐỊNH";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            this.tabControlQuyDinh.ResumeLayout(false);
            this.tabSiSo.ResumeLayout(false);
            this.tabSiSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSoCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiSoCanDuoi)).EndInit();
            this.tabDoTuoi.ResumeLayout(false);
            this.tabDoTuoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoTuoiCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoTuoiCanDuoi)).EndInit();
            this.tabThangDiem.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabThongTinTruong.ResumeLayout(false);
            this.tabThongTinTruong.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuyDinh;
        private System.Windows.Forms.TabPage tabSiSo;
        private System.Windows.Forms.TabPage tabDoTuoi;
        private System.Windows.Forms.TabPage tabThangDiem;
        private System.Windows.Forms.TabPage tabThongTinTruong;
        private System.Windows.Forms.Label lblSiSoCanTren;
        private System.Windows.Forms.Label lblSiSoCanDuoi;
        private System.Windows.Forms.NumericUpDown nudSiSoCanTren;
        private System.Windows.Forms.NumericUpDown nudSiSoCanDuoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.NumericUpDown nudDoTuoiCanTren;
        private System.Windows.Forms.NumericUpDown nudDoTuoiCanDuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbThangDiem100;
        private System.Windows.Forms.RadioButton rdbThangDiem10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDiaChiTruong;
        public System.Windows.Forms.TextBox txtTenTruong;
    }
}