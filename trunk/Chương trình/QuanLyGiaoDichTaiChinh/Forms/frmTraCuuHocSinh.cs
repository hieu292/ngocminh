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
    public partial class frmTraCuuHocSinh : Form
    {
       #region Fields
        HocSinhCtrl     m_HocSinhCtrl   = new HocSinhCtrl();
        #endregion

        #region Constructor
        public frmTraCuuHocSinh()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmTraCuuHocSinh_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region BindingNavigatorItems
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
            frptInDanhSachHocSinh frm = new frptInDanhSachHocSinh();
            frm.reportViewerDSHS.LocalReport.SetParameters(param);
            IList<HocSinhInfo> hocsinh = HocSinhCtrl.LayDsHocSinhForReport(Convert.ToString(txtTuKhoa.Tag));
            frm.bSDSHS.DataSource = hocsinh;
            frm.reportViewerDSHS.RefreshReport();
            frm.Show();
        }
        #endregion

        #region Tìm kiếm học sinh
        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txtTuKhoa.Text, dgvKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            txtTuKhoa.Tag = txtTuKhoa.Text;
            if (dgvKetQuaTimKiem.RowCount == 0)
                MessageBox.Show("Không có học sinh muốn tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
