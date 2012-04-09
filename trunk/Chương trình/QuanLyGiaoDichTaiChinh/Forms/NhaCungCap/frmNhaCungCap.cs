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
    public partial class frmNhaCungCap : Form
    {
        #region Fields
        NhaCungCapCtrl m_NhaCungCapCtrl = new NhaCungCapCtrl();
        #endregion

        #region Constructor
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            m_NhaCungCapCtrl.HienThi(dgvNhaCungCap, bindingNavigatorNhaCungCap, txtMaNCC, txtTenNCC, txtDiaChi, txtDienThoai);
            lblStatus.Text = "";
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNhaCungCap.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            DataRow m_Row = m_NhaCungCapCtrl.ThemDongMoi();
            m_Row["MaNCC"] = "NCC" + String.Format("{0:D2}",dgvNhaCungCap.RowCount + 1);
            m_Row["TenNCC"] = "";
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_NhaCungCapCtrl.ThemNhaCungCap(m_Row);
            lblStatus.Text = "*";
            bindingNavigatorNhaCungCap.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap_Load(sender, e);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (Utilities.KiemTraTruocKhiLuu(dgvNhaCungCap, "colMaNCC") == true &&
                Utilities.KiemTraTruocKhiLuu(dgvNhaCungCap, "colTenNCC") == true
                && lblStatus.Text == "*")
            {
                if (m_NhaCungCapCtrl.LuuNhaCungCap())
                {
                    MessageBox.Show("Lưu thay đổi nhà cung cấp thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "";
                }
                else
                    MessageBox.Show("Lưu thay đổi nhà cung cấp thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataError event
        private void dgvNhaCungCap_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void dgvNhaCungCap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "*";
            bindingNavigatorPositionItem.Focus();
        }
    }
}
