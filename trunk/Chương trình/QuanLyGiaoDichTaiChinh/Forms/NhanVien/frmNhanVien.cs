using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNhanVien : Form
    {
        #region Fields
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        #endregion

        #region Constructor
        public frmNhanVien()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThi(dgvNhanVien, bindingNavigatorNhanVien, txtMaNV, txtTenNV, 
                dtpNgaySinh, chkGioiTinh, txtCMND, txtDiaChi, txtDienThoai);
            lblStatus.Text = "";
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNhanVien.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            DataRow m_Row = m_NhanVienCtrl.ThemDongMoi();
            m_Row["MaNV"] = "NV" + String.Format("{0:D3}",dgvNhanVien.RowCount + 1);
            m_Row["TenNV"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["GioiTinh"] = 0;
            m_Row["CMND"] = "";
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_NhanVienCtrl.ThemNhanVien(m_Row);
            lblStatus.Text = "*";
            bindingNavigatorNhanVien.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (Utilities.KiemTraTruocKhiLuu(dgvNhanVien, "colMaNV") == true &&
                Utilities.KiemTraTruocKhiLuu(dgvNhanVien, "colTenNV") == true
                && lblStatus.Text == "*")
            {
                if (m_NhanVienCtrl.LuuNhanVien())
                {
                    MessageBox.Show("Lưu thay đổi nhân viên thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "";
                }
                else
                    MessageBox.Show("Lưu thay đổi nhân viên thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataError event
        private void dgvNhanVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void dgvNhanVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "*";
            bindingNavigatorPositionItem.Focus();
        }
    }
}
