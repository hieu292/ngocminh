namespace QuanLyGiaoDichTaiChinh
{
    partial class frptInDanhSachLop
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
            this.reportViewerDSLop = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bSDSLop = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSLop)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDSLop
            // 
            this.reportViewerDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LopInfo";
            reportDataSource1.Value = this.bSDSLop;
            this.reportViewerDSLop.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSLop.LocalReport.ReportEmbeddedResource = "QLDiemHS.Reports.rptDanhSachLop.rdlc";
            this.reportViewerDSLop.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSLop.Name = "reportViewerDSLop";
            this.reportViewerDSLop.Size = new System.Drawing.Size(834, 561);
            this.reportViewerDSLop.TabIndex = 0;
            // 
            // bSDSLop
            // 
            this.bSDSLop.DataSource = typeof(QuanLyGiaoDichTaiChinh.Bussiness.LopInfo);
            // 
            // frptInDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.reportViewerDSLop);
            this.Name = "frptInDanhSachLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IN DANH SÁCH LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptInDanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSDSLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerDSLop;
        public System.Windows.Forms.BindingSource bSDSLop;

    }
}