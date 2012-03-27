namespace QuanLyGiaoDichTaiChinh
{
    partial class frptInDanhSachGiaoVien
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
            this.reportViewerDSGV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bSDSGV = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSGV)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDSGV
            // 
            this.reportViewerDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GiaoVienInfo";
            reportDataSource1.Value = this.bSDSGV;
            this.reportViewerDSGV.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSGV.LocalReport.ReportEmbeddedResource = "QLDiemHS.Reports.rptDanhSachGiaoVien.rdlc";
            this.reportViewerDSGV.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSGV.Name = "reportViewerDSGV";
            this.reportViewerDSGV.Size = new System.Drawing.Size(834, 561);
            this.reportViewerDSGV.TabIndex = 0;
            // 
            // bSDSGV
            // 
            this.bSDSGV.DataSource = typeof(QuanLyGiaoDichTaiChinh.Bussiness.GiaoVienInfo);
            // 
            // frptInDanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.reportViewerDSGV);
            this.Name = "frptInDanhSachGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IN DANH SÁCH GIÁO VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bSDSGV;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewerDSGV;

    }
}