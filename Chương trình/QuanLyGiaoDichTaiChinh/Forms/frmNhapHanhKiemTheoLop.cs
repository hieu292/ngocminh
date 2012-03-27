using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNhapHanhKiemTheoLop : Form
    {
        #region Fields
        HanhKiemCtrl       m_HanhKiemCtrl       = new HanhKiemCtrl();
        NamHocCtrl         m_NamHocCtrl         = new NamHocCtrl();
        LopCtrl            m_LopCtrl            = new LopCtrl();
        HocKyCtrl          m_HocKyCtrl          = new HocKyCtrl();
        HocSinhCtrl        m_HocSinhCtrl        = new HocSinhCtrl();
        KQHocKyTongHopCtrl m_KQHocKyTongHopCtrl = new KQHocKyTongHopCtrl();
        KQCaNamTongHopCtrl m_KQCaNamTongHopCtrl = new KQCaNamTongHopCtrl();
        #endregion

        #region Constructor
        public frmNhapHanhKiemTheoLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhapHanhKiemTheoLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            m_HocKyCtrl.HienThiComboBox(cboHocKy);
            m_HanhKiemCtrl.HienThiDataGridViewComboBoxColumn(colMaHanhKiem);
            cboNamHoc_SelectedIndexChanged(sender, e);
        }
        #endregion
        private void rdbHanhKiemHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue != null && cboHocKy.SelectedValue != null)
            {
                if (rdbHanhKiemHocKy.Checked == true)
                {
                    if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboHocKy.SelectedValue != null)
                        m_KQHocKyTongHopCtrl.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem, cboLop.SelectedValue.ToString(), cboHocKy.SelectedValue.ToString(),
                            cboNamHoc.SelectedValue.ToString());
                }
                else
                {
                    if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
                        m_KQCaNamTongHopCtrl.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem, cboLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString());
                }
            }
        }

        private void rdbHanhKiemCaNam_CheckedChanged(object sender, EventArgs e)
        {
            rdbHanhKiemHocKy_CheckedChanged(sender, e);
        }


        #region DataError event
        private void dgvNhapDiemTheoLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
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
            cboHocKy_SelectedIndexChanged(sender, e);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbHanhKiemHocKy_CheckedChanged(sender, e);
        }

        #endregion

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            try
            {
                foreach (DataGridViewRow row in dgvHanhKiem.Rows)
                {
                    if (row.Cells[cellString].Value != null)
                    {
                        String str = row.Cells[cellString].Value.ToString();
                        if (str == "")
                        {
                            MessageBox.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return true;
            }
            return true;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNhapHanhKiemTheoLop_Load(sender, e);
            rdbHanhKiemHocKy_CheckedChanged(sender, e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (KiemTraTruocKhiLuu("colMaHanhKiem") == true &&
                KiemTraTruocKhiLuu("Số buổi nghỉ") == true)
            {
                if (rdbHanhKiemHocKy.Checked)
                {
                    foreach (DataGridViewRow row in dgvHanhKiem.Rows)
                    {
                        m_KQHocKyTongHopCtrl.CapNhatKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                                     cboLop.SelectedValue.ToString(),
                                                     cboHocKy.SelectedValue.ToString(),
                                                     cboNamHoc.SelectedValue.ToString(),
                                                     row.Cells["colMaHanhKiem"].Value.ToString());
                    }
                    MessageBox.Show("Đã lưu hạnh kiểm học kỳ!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataGridViewRow row in dgvHanhKiem.Rows)
                    {
                        m_KQCaNamTongHopCtrl.CapNhatKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                                     cboLop.SelectedValue.ToString(),
                                                     cboNamHoc.SelectedValue.ToString(),
                                                     row.Cells["colMaHanhKiem"].Value.ToString(),
                                                     Convert.ToInt16(row.Cells["Số buổi nghỉ"].Value.ToString())
                                                        );
                    }
                    MessageBox.Show("Đã lưu hạnh kiểm cả năm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
