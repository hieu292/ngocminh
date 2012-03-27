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
    public partial class frmKhoiLop : Form
    {
        #region Field
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        #endregion

        #region constructor
        public frmKhoiLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThi(dgvKhoiLop, bindingNavigatorKhoiLop);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorKhoiLop.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKhoiLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_KhoiLopCtrl.ThemDongMoi();
            m_Row["MaKhoiLop"] = "";
            m_Row["TenKhoiLop"] = "";
            m_KhoiLopCtrl.ThemKhoiLop(m_Row);
            bindingNavigatorKhoiLop.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvKhoiLop.Rows)
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
            if (KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colTenkhoiLop") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhoiLopCtrl.LuuKhoiLop();
            }
        }
        #endregion

        #region DataError event
        private void dgvKhoiLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmKhoiLop_Load(sender, e);
        }
    }
}
