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
    public partial class frmPhieuChi : Form
    {
        PhieuChiCtrl m_PhieuChiCtrl = new PhieuChiCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        KhoanChiCtrl m_KhoanChiCtrl = new KhoanChiCtrl();
        public frmPhieuChi()
        {
            InitializeComponent();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuChi_Load(object sender, EventArgs e)
        {
            cboStatusFilter.SelectedIndex = 0;
            m_NhanVienCtrl.HienThiDataGridViewComboBoxColumn(colNhanVien);
            m_KhoanChiCtrl.HienThiDataGridViewComboBoxColumn(colKhoanChi);
            m_PhieuChiCtrl.HienThi(dgvPhieuChi, bindingNavigatorPhieuChi, "0", "");
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            String tinhTrang = "";
            if (cboStatusFilter.SelectedIndex < 2)
                tinhTrang = cboStatusFilter.SelectedIndex.ToString();
            String soPhieu = txtSoPhieu.Text;
            m_PhieuChiCtrl.HienThi(dgvPhieuChi, bindingNavigatorPhieuChi, tinhTrang, soPhieu);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuChi.CurrentRow;
            if (dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể xóa phiếu chi đã xác nhận chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc chắn xóa phiếu chi này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (m_PhieuChiCtrl.XoaPhieuChi(Convert.ToInt32(dr.Cells["colSoPC"].Value.ToString())) != 0)
                {
                    MessageBox.Show("Đã xóa phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchToolStripButton_Click(sender, e);
                }
                else
                    MessageBox.Show("Lỗi trong khi xóa phiếu chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuChi.CurrentRow;
            if (dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể xác nhận phiếu chi đã xác nhận chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc chắn xác nhận phiếu chi này không?", "VERIFY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (m_PhieuChiCtrl.XacNhanPhieuChi(Convert.ToInt32(dr.Cells["colSoPC"].Value.ToString())) != 0)
                {
                    MessageBox.Show("Đã xác nhận phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchToolStripButton_Click(sender, e);
                }
                else
                    MessageBox.Show("Lỗi trong khi xác nhận phiếu chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmThemPhieuChi frm = new frmThemPhieuChi();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cboStatusFilter.SelectedIndex = frm.TinhTrang;
                txtSoPhieu.Text = frm.SoPhieuChi.ToString();
                searchToolStripButton_Click(sender, e);
            }
        }

        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuChi.CurrentRow;
            if (dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể sửa phiếu chi đã xác nhận chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSuaPhieuChi frm = new frmSuaPhieuChi();
            frm.SoPhieuChi = Convert.ToInt32(dr.Cells["colSoPC"].Value.ToString());
            frm.cboNhanVien.SelectedValue = dr.Cells["colNhanVien"].Value;
            frm.cboKhoanChi.SelectedValue = dr.Cells["colKhoanChi"].Value;
            frm.nudSoTienChi.Value = Convert.ToInt64(dr.Cells["colSoTienChi"].Value.ToString());
            frm.txtGhiChu.Text = dr.Cells["colGhiChu"].Value.ToString();
            frm.dtpNgayLap.Value = Convert.ToDateTime(dr.Cells["colNgayLap"].Value);
            frm.dtpNgayChi.Value = Convert.ToDateTime(dr.Cells["colNgayChi"].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cboStatusFilter.SelectedIndex = frm.TinhTrang;
                txtSoPhieu.Text = frm.SoPhieuChi.ToString();
                searchToolStripButton_Click(sender, e);
            }
        }
    }
}
