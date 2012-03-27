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
    public partial class frmDanToc : Form
    {
        #region Fields
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion
        #region Constructor
        public frmDanToc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmDanToc_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThi(dgvDanToc, bindingNavigatorDanToc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorDanToc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvDanToc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_DanTocCtrl.ThemDongMoi();
            m_Row["MaDanToc"] = "DT" + quyDinh.LaySTT(dgvDanToc.Rows.Count + 1);
            m_Row["TenDanToc"] = "";
            m_DanTocCtrl.ThemDanToc(m_Row);
            bindingNavigatorDanToc.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvDanToc.Rows)
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
            if (KiemTraTruocKhiLuu("colMaDanToc") == true &&
                KiemTraTruocKhiLuu("colTenDanToc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DanTocCtrl.LuuDanToc();
            }
        }
        #endregion

        #region DataError event
        private void dgvDanToc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmDanToc_Load(sender, e);
        }
    }
}
