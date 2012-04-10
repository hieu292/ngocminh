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
    public partial class frmPhieuThu : Form
    {
        PhieuThuCtrl m_PhieuThuCtrl = new PhieuThuCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        KhoanThuCtrl m_KhoanThuCtrl = new KhoanThuCtrl();
        public frmPhieuThu()
        {
            InitializeComponent();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            cboStatusFilter.SelectedIndex = 0;
            m_KhachHangCtrl.HienThiDataGridViewComboBoxColumn(colKhachHang);
            m_KhoanThuCtrl.HienThiDataGridViewComboBoxColumn(colKhoanThu);
            m_PhieuThuCtrl.HienThi(dgvPhieuThu, bindingNavigatorPhieuThu, "0", "");
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            String tinhTrang="";
            if (cboStatusFilter.SelectedIndex < 2)
                tinhTrang = cboStatusFilter.SelectedIndex.ToString();
            String soPhieu = txtSoPhieu.Text;
            m_PhieuThuCtrl.HienThi(dgvPhieuThu, bindingNavigatorPhieuThu, tinhTrang, soPhieu);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuThu.CurrentRow;
            if(dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể xóa phiếu thu đã xác nhận thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(MessageBox.Show("Bạn có chắc chắn xóa phiếu thu này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (m_PhieuThuCtrl.XoaPhieuThu(Convert.ToInt32(dr.Cells["colSoPT"].Value.ToString()))!=0)
                {
                    MessageBox.Show("Đã xóa phiếu thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchToolStripButton_Click(sender, e);
                }
                else
                    MessageBox.Show("Lỗi trong khi xóa phiếu thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verifyToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuThu.CurrentRow;
            if (dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể xác nhận phiếu thu đã xác nhận thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (MessageBox.Show("Bạn có chắc chắn xác nhận phiếu thu này không?", "VERIFY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (m_PhieuThuCtrl.XacNhanPhieuThu(Convert.ToInt32(dr.Cells["colSoPT"].Value.ToString())) != 0)
                {
                    MessageBox.Show("Đã xác nhận phiếu thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchToolStripButton_Click(sender, e);
                }
                else
                    MessageBox.Show("Lỗi trong khi xác nhận phiếu thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmThemPhieuThu frm = new frmThemPhieuThu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cboStatusFilter.SelectedIndex = frm.TinhTrang;
                txtSoPhieu.Text = frm.SoPhieuThu.ToString();
                searchToolStripButton_Click(sender, e);
            }
        }

        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhieuThu.CurrentRow;
            if (dr.Cells["colTinhTrang"].Value.ToString().Equals("True"))
            {
                MessageBox.Show("Không thể sửa phiếu thu đã xác nhận thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmSuaPhieuThu frm = new frmSuaPhieuThu();
            frm.SoPhieuThu = Convert.ToInt32(dr.Cells["colSoPT"].Value.ToString());
            frm.cboKhachHang.SelectedValue = dr.Cells["colKhachHang"].Value;
            frm.cboKhoanThu.SelectedValue = dr.Cells["colKhoanThu"].Value;
            frm.nudSoTienThu.Value = Convert.ToInt64(dr.Cells["colSoTienThu"].Value.ToString());
            frm.txtGhiChu.Text = dr.Cells["colGhiChu"].Value.ToString();
            frm.dtpNgayLap.Value = Convert.ToDateTime(dr.Cells["colNgayLap"].Value);
            frm.dtpNgayThu.Value =  Convert.ToDateTime(dr.Cells["colNgayThu"].Value);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cboStatusFilter.SelectedIndex = frm.TinhTrang;
                txtSoPhieu.Text = frm.SoPhieuThu.ToString();
                searchToolStripButton_Click(sender, e);
            }
        }
    }
}
