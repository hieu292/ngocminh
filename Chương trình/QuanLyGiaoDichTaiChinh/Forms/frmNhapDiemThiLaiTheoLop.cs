using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNhapDiemThiLai : Form
    {
         
        #region Fields
        NamHocCtrl          m_NamHocCtrl            = new NamHocCtrl();
        LopCtrl             m_LopCtrl               = new LopCtrl();
        HocKyCtrl           m_HocKyCtrl             = new HocKyCtrl();
        MonHocCtrl          m_MonHocCtrl            = new MonHocCtrl();
        DiemCtrl            m_DiemCtrl              = new DiemCtrl();
        LoaiDiemCtrl        m_LoaiDiemCtrl          = new LoaiDiemCtrl();
        HocSinhCtrl         m_HocSinhCtrl           = new HocSinhCtrl();
        KQHocKyMonHocCtrl   m_KQHocKyMonHocCtrl     = new KQHocKyMonHocCtrl();
        KQHocKyTongHopCtrl  m_KQHocKyTongHopCtrl    = new KQHocKyTongHopCtrl();
        KQCaNamMonHocCtrl   m_KQCaNamMonHocCtrl     = new KQCaNamMonHocCtrl();
        KQCaNamTongHopCtrl  m_KQCaNamTongHopCtrl    = new KQCaNamTongHopCtrl();

        DiemData            m_DiemData              = new DiemData();
        QuyDinh             quyDinh                 = new QuyDinh();
        #endregion

        #region Constructor
        public frmNhapDiemThiLai()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhapDiemThiLai_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            cboNamHoc_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region DataError event
        private void dgvKetQuaThiLai_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Kiểm tra điểm số trước khi lưu
        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dgvKetQuaThiLai.Rows)
            {
                if (row.Cells[loaiDiem].Value != null && row.Cells[loaiDiem].Value.ToString() != "")
                {
                        if (quyDinh.KiemTraDiem(row.Cells[loaiDiem].Value.ToString()) == false)
                        {
                            MessageBox.Show(dgvKetQuaThiLai.Columns[loaiDiem].HeaderText +
                                " của học sinh " + row.Cells["colHo"].Value.ToString() + " " + row.Cells["colTen"].Value.ToString()
                                + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                }
            }
            return true;
        }
        #endregion

        #region SelectedIndexChanged event
        //Lấy thông tin lớp theo từng năm học
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
            {
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
                cboMonHoc_SelectedIndexChanged(sender, e);
            }
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboMonHoc.SelectedValue != null)
                m_KQCaNamMonHocCtrl.HienThi(dgvKetQuaThiLai, bindingNavigatorKetQuaThiLai, cboLop.SelectedValue.ToString(),
                    cboMonHoc.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNhapDiemThiLai_Load(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (KiemTraDiemTruocKhiLuu("colDiemThiLai") == true)
            {
                bindingNavigatorPositionItem.Focus();
                foreach (DataGridViewRow row in dgvKetQuaThiLai.Rows)
                {
                    m_KQCaNamMonHocCtrl.CapNhatKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                                 cboLop.SelectedValue.ToString(),
                                                 cboMonHoc.SelectedValue.ToString(),
                                                 cboNamHoc.SelectedValue.ToString(),
                                                 Convert.ToSingle(row.Cells["colDiemThiLai"].Value.ToString()));
                    m_KQCaNamTongHopCtrl.LuuKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                                 cboLop.SelectedValue.ToString(),
                                                 cboNamHoc.SelectedValue.ToString());
                }
                MessageBox.Show("Đã lưu vào bảng điểm kết quả cả năm môn học!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
