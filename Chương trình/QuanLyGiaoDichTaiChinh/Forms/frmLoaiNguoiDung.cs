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
    public partial class frmLoaiNguoiDung : Form
    {
        #region Fields
        LoaiNguoiDungCtrl   m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        #endregion

        #region Constructor
        public frmLoaiNguoiDung()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThi(dgvLoaiNguoiDung, bindingNavigatorLoaiNguoiDung);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiNguoiDung.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLoaiNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row       = m_LoaiNguoiDungCtrl.ThemDongMoi();
            m_Row["MaLoai"] = DBNull.Value;
            m_Row["TenLoaiND"]  = "";
            m_LoaiNguoiDungCtrl.ThemLoaiNguoiDung(m_Row);
            bindingNavigatorLoaiNguoiDung.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLoaiNguoiDung.Rows)
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
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLoai")     == true &&
                KiemTraTruocKhiLuu("colTenLoaiND")  == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiNguoiDungCtrl.LuuLoaiNguoiDung();
            }
        }
        #endregion

        #region DataError event
        private void dgvLoaiNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmLoaiNguoiDung_Load(sender, e);
        }
    }
}
