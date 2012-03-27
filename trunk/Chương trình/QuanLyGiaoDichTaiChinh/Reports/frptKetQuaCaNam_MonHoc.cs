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
    public partial class frptKetQuaCaNam_MonHoc : Form
    {
        #region Fields
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        #endregion

        #region Constructor
        public frptKetQuaCaNam_MonHoc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frptKetQuaCaNam_MonHoc_Load(object sender, EventArgs e)
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
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<KQCaNamMonHocInfo> ketqua = KQCaNamMonHocCtrl.LayDsKQCaNamMonHoc(cboLop.SelectedValue.ToString(),
                                                                                   cboMonHoc.SelectedValue.ToString(),
                                                                                   cboNamHoc.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
            String hoten = m_PhanCongCtrl.LayHoTenGiaoVienBoMon(cboLop.SelectedValue.ToString(), cboMonHoc.SelectedValue.ToString());
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cboNamHoc.Text));
            param.Add(new ReportParameter("Lop", cboLop.Text));
            param.Add(new ReportParameter("MonHoc", cboMonHoc.Text));
            param.Add(new ReportParameter("GiaoVien", hoten));
            this.reportViewerKQCNMH.LocalReport.SetParameters(param);
            this.bSKQCNMH.DataSource = ketqua;
            this.reportViewerKQCNMH.RefreshReport();
        }
        #endregion

    }
}
