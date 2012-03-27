namespace QuanLyGiaoDichTaiChinh
{
    partial class frptKetQuaCaNam_MonHoc
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bSKQCNMH = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerKQCNMH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bSKQCNMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSKQCNMH
            // 
            this.bSKQCNMH.DataSource = typeof(QuanLyGiaoDichTaiChinh.Bussiness.KQCaNamMonHocInfo);
            // 
            // reportViewerKQCNMH
            // 
            this.reportViewerKQCNMH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KQCaNamMonHocInfo";
            reportDataSource1.Value = this.bSKQCNMH;
            this.reportViewerKQCNMH.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerKQCNMH.LocalReport.ReportEmbeddedResource = "QLDiemHS.Reports.rptKetQuaCaNam_Mon_Hoc.rdlc";
            this.reportViewerKQCNMH.Location = new System.Drawing.Point(0, 69);
            this.reportViewerKQCNMH.Name = "reportViewerKQCNMH";
            this.reportViewerKQCNMH.Size = new System.Drawing.Size(850, 531);
            this.reportViewerKQCNMH.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboMonHoc);
            this.panel1.Controls.Add(this.cboLop);
            this.panel1.Controls.Add(this.cboNamHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 69);
            this.panel1.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXem.Location = new System.Drawing.Point(640, 24);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(55, 21);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(455, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Môn học:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(317, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(156, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Năm học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(513, 24);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(120, 21);
            this.cboMonHoc.TabIndex = 2;
            // 
            // cboLop
            // 
            this.cboLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(351, 24);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(90, 21);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(215, 24);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(90, 21);
            this.cboNamHoc.TabIndex = 0;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // frptKetQuaCaNam_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.reportViewerKQCNMH);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frptKetQuaCaNam_MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KẾT QUẢ CẢ NĂM MÔN HỌC";
            this.Load += new System.EventHandler(this.frptKetQuaCaNam_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSKQCNMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerKQCNMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.BindingSource bSKQCNMH;
    }
}