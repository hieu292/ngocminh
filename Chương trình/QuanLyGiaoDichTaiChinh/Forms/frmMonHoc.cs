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
    public partial class frmMonHoc : Form
    {
        #region Fields
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmMonHoc()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThi(dgvMonHoc, bindingNavigatorMonHoc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorMonHoc.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_MonHocCtrl.ThemDongMoi();
            m_Row["MaMonHoc"] = "MH" + quyDinh.LaySTT(dgvMonHoc.Rows.Count + 1);
            m_Row["TenMonHoc"] = "";
            m_Row["SoTiet"] = 0;
            m_Row["HeSo"] = 0;
            m_MonHocCtrl.ThemMonHoc(m_Row);
            bindingNavigatorMonHoc.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvMonHoc.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBox.Show("Giá trị của ô không được rỗng, số tiết và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaMonHoc") == true &&
                KiemTraTruocKhiLuu("colTenMonHoc") == true &&
                KiemTraTruocKhiLuu("colSoTiet") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_MonHocCtrl.LuuMonHoc();
            }
        }
        #endregion

        #region DataError event
        private void dgvMonHoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmMonHoc_Load(sender, e);
        }
    }
}
