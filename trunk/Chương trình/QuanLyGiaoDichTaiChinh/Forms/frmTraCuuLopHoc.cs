using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using Microsoft.Reporting.WinForms;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmTraCuuLopHoc : Form
    {
       #region Fields
        LopCtrl    m_LopHocCtrl  = new LopCtrl();
        #endregion

        #region Constructor
        public frmTraCuuLopHoc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmTraCuuLopHoc_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Tìm kiếm lớp học
        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_LopHocCtrl.TimKiemLop(txtTuKhoa.Text, dgvKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dgvKetQuaTimKiem.RowCount == 0)
                MessageBox.Show("Không có lớp học muốn tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            frptInDanhSachLop frm = new frptInDanhSachLop();
            frm.reportViewerDSLop.LocalReport.SetParameters(param);
            IList<LopInfo> lopHoc = LopCtrl.LayDsLopForReport(Convert.ToString(txtTuKhoa.Tag));
            frm.bSDSLop.DataSource = lopHoc;
            frm.reportViewerDSLop.RefreshReport();
            frm.Show();
        }
    }
}
