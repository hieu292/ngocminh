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
    public partial class frmKhoanThu : Form
    {
        #region Fields
        KhoanThuCtrl m_KhoanThuCtrl = new KhoanThuCtrl();
        #endregion

        #region Constructor
        public frmKhoanThu()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmKhoanThu_Load(object sender, EventArgs e)
        {
            m_KhoanThuCtrl.HienThi(dgvKhoanThu, bindingNavigatorKhoanThu, txtMaKT, txtTenKT, txtGhiChu);
            lblStatus.Text = "";
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoanThu.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoanThu.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoanThu.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            DataRow m_Row = m_KhoanThuCtrl.ThemDongMoi();
            m_Row["MaKT"] = -1;
            m_Row["TenKT"] = "";
            m_Row["GhiChu"] = "";
            m_KhoanThuCtrl.ThemKhoanThu(m_Row);
            lblStatus.Text = "*";
            bindingNavigatorKhoanThu.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmKhoanThu_Load(sender, e);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (Utilities.KiemTraTruocKhiLuu(dgvKhoanThu, "colMaKT") == true &&
                Utilities.KiemTraTruocKhiLuu(dgvKhoanThu, "colTenKT") == true
                && lblStatus.Text == "*")
            {
                if (m_KhoanThuCtrl.LuuKhoanThu())
                {
                    MessageBox.Show("Lưu thay đổi khoản thu thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "";
                    frmKhoanThu_Load(sender, e);
                }
                else
                    MessageBox.Show("Lưu thay đổi khoản thu thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataError event
        private void dgvKhoanThu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void dgvKhoanThu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "*";
            bindingNavigatorPositionItem.Focus();
        }
    }
}
