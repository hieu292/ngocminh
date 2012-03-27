using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Bussiness;
using Microsoft.Reporting.WinForms;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frptKetQuaCaNam_HocSinh : Form
    {
        #region Fields
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        #endregion

        #region Constructor
        public frptKetQuaCaNam_HocSinh()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frptKetQuaCaNam_HocSinh_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            cboNamHoc_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region SelectedIndexChanged event
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
                cboLop_SelectedIndexChanged(sender, e);
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
                m_HocSinhCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboHocSinh);
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<KQCaNamMonHocInfo> ketqua = KQCaNamMonHocCtrl.LayDsKQCaNamHocSinh(cboHocSinh.SelectedValue.ToString(),
                                                                                    cboLop.SelectedValue.ToString(),
                                                                                    cboNamHoc.SelectedValue.ToString());
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cboNamHoc.Text));
            param.Add(new ReportParameter("Lop", cboLop.Text));
            param.Add(new ReportParameter("HocSinh", cboHocSinh.Text));
            this.reportViewerKQCNHS.LocalReport.SetParameters(param);

            this.bSKQCNHS.DataSource = ketqua;
            this.reportViewerKQCNHS.RefreshReport();
        }
        #endregion

    }
}
