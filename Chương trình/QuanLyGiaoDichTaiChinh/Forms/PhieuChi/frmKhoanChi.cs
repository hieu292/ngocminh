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
    public partial class frmKhoanChi : Form
    {
        #region Fields
        KhoanChiCtrl m_KhoanChiCtrl = new KhoanChiCtrl();
        #endregion

        #region Constructor
        public frmKhoanChi()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmKhoanChi_Load(object sender, EventArgs e)
        {
            m_KhoanChiCtrl.HienThi(dgvKhoanChi, bindingNavigatorKhoanChi, txtMaKC, txtTenKC, txtGhiChu);
            lblStatus.Text = "";
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoanChi.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoanChi.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoanChi.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            DataRow m_Row = m_KhoanChiCtrl.ThemDongMoi();
            m_Row["MaKC"] = -1;
            m_Row["TenKC"] = "";
            m_Row["GhiChu"] = "";
            m_KhoanChiCtrl.ThemKhoanChi(m_Row);
            lblStatus.Text = "*";
            bindingNavigatorKhoanChi.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmKhoanChi_Load(sender, e);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (Utilities.KiemTraTruocKhiLuu(dgvKhoanChi, "colMaKC") == true &&
                Utilities.KiemTraTruocKhiLuu(dgvKhoanChi, "colTenKC") == true
                && lblStatus.Text == "*")
            {
                if (m_KhoanChiCtrl.LuuKhoanChi())
                {
                    MessageBox.Show("Lưu thay đổi khoản chi thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "";
                    frmKhoanChi_Load(sender, e);
                }
                else
                    MessageBox.Show("Lưu thay đổi khoản chi thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataError event
        private void dgvKhoanChi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void dgvKhoanChi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "*";
            bindingNavigatorPositionItem.Focus();
        }
    }
}
