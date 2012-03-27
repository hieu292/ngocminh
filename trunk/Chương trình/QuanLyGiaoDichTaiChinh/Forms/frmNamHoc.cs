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
    public partial class frmNamHoc : Form
    {
        #region Field
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        #endregion

        #region Constructor
        public frmNamHoc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThi(dgvNamHoc, bindingNavigatorNamHoc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNamHoc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NamHocCtrl.ThemDongMoi();
            m_Row["MaNamHoc"] = "";
            m_Row["TenNamHoc"] = "";
            m_NamHocCtrl.ThemNamHoc(m_Row);
            bindingNavigatorNamHoc.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNamHoc.Rows)
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
            if (KiemTraTruocKhiLuu("colMaNamHoc") == true &&
                KiemTraTruocKhiLuu("colTenNamHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NamHocCtrl.LuuNamHoc();
            }
        }
        #endregion

        #region DataError event
        private void dgvNamHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNamHoc_Load(sender, e);
        }
    }
}
