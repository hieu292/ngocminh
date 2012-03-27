using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;
using Microsoft.Reporting.WinForms;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmTraCuuGiaoVien : Form
    {
        #region Fields
        GiaoVienCtrl    m_GiaoVienCtrl  = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public frmTraCuuGiaoVien()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmTraCuuGiaoVien_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Tìm kiếm giáo viên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txtTuKhoa.Text, dgvKetQuaTimKiem, bindingNavigatorKetQuaTimKiem);
            
            if (dgvKetQuaTimKiem.RowCount == 0)
                MessageBox.Show("Không có giáo viên muốn tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frptInDanhSachGiaoVien frm = new frptInDanhSachGiaoVien();
            frm.reportViewerDSGV.LocalReport.SetParameters(param);
            IList<GiaoVienInfo> giaovien = GiaoVienCtrl.LayDsGiaoVienForReport(Convert.ToString(txtTuKhoa.Tag));
            frm.bSDSGV.DataSource = giaovien;
            frm.reportViewerDSGV.RefreshReport();
            frm.Show();
        }
    }
}
