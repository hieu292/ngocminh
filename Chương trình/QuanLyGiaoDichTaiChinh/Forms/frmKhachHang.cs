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
    public partial class frmKhachHang : Form
    {
        #region Fields
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        #endregion

        #region Constructor
        public frmKhachHang()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThi(dgvKhachHang, bindingNavigatorKhachHang, txtMaKH, txtTenKH, txtDiaChi, txtDienThoai);
            lblStatus.Text = "";
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhachHang.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            DataRow m_Row = m_KhachHangCtrl.ThemDongMoi();
            m_Row["MaKH"] = "KH" + String.Format("{0:D3}",dgvKhachHang.RowCount + 1);
            m_Row["TenKH"] = "";
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_KhachHangCtrl.ThemKhachHang(m_Row);
            lblStatus.Text = "*";
            bindingNavigatorKhachHang.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            if (Utilities.KiemTraTruocKhiLuu(dgvKhachHang, "colMaKH") == true &&
                Utilities.KiemTraTruocKhiLuu(dgvKhachHang, "colTenKH") == true
                && lblStatus.Text == "*")
            {
                if (m_KhachHangCtrl.LuuKhachHang())
                {
                    MessageBox.Show("Lưu thay đổi khách hàng thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "";
                }
                else
                    MessageBox.Show("Lưu thay đổi khách hàng thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DataError event
        private void dgvKhachHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void dgvKhachHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lblStatus.Text = "*";
            bindingNavigatorPositionItem.Focus();
        }
    }
}
