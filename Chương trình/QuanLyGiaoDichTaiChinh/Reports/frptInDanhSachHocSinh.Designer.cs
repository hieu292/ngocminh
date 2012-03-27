namespace QuanLyGiaoDichTaiChinh
{
    partial class frptInDanhSachHocSinh
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
            this.bSDSHS = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerDSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bSDSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // bSDSHS
            // 
            this.bSDSHS.DataMember = "HocSinhInfo";
            // 
            // reportViewerDSHS
            // 
            this.reportViewerDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HocSinhInfo";
            reportDataSource1.Value = this.bSDSHS;
            this.reportViewerDSHS.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSHS.LocalReport.ReportEmbeddedResource = "QLDiemHS.Reports.rptDanhSachHocSinh.rdlc";
            this.reportViewerDSHS.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSHS.Name = "reportViewerDSHS";
            this.reportViewerDSHS.Size = new System.Drawing.Size(834, 561);
            this.reportViewerDSHS.TabIndex = 0;
            // 
            // frptInDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.reportViewerDSHS);
            this.Name = "frptInDanhSachHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IN DANH SÁCH HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptInDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bSDSHS;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewerDSHS;
    }
}