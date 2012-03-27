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

namespace QuanLyGiaoDichTaiChinh.Reports
{
    public partial class frptKetQuaHocKy_Lop : Form
    {
        #region Fields
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        #endregion

        #region Constructor
        public frptKetQuaHocKy_Lop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frptKetQuaHocKy_Lop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            m_HocKyCtrl.HienThiComboBox(cboHocKy);
            if (cboNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
        }
        #endregion

        #region SelectedIndexChanged event
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
            cboLop.DataBindings.Clear();
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<KQHocKyTongHopInfo> ketqua = KQHocKyTongHopCtrl.LayDsKQHocKyTongHop(cboLop.SelectedValue.ToString(),
                                                                                     cboHocKy.SelectedValue.ToString(),
                                                                                     cboNamHoc.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cboNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cboHocKy.Text));
            param.Add(new ReportParameter("Lop", cboLop.Text));
            this.reportViewerKQHKTH.LocalReport.SetParameters(param);

            this.bSKQHKTH.DataSource = ketqua;
            this.reportViewerKQHKTH.RefreshReport();
        }
        #endregion
    }
}
