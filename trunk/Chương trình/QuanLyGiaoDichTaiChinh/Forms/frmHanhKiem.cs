using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Controller;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmHanhKiem : Form
    {
        #region Fields
        HanhKiemCtrl m_HanhKiemCtrl = new HanhKiemCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmHanhKiem()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            m_HanhKiemCtrl.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvHanhKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorHanhKiem.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvHanhKiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_HanhKiemCtrl.ThemDongMoi();
            m_Row["MaHanhKiem"] = "HK" + quyDinh.LaySTT(dgvHanhKiem.Rows.Count + 1);
            m_Row["TenHanhKiem"] = "";
            m_HanhKiemCtrl.ThemHanhKiem(m_Row);
            bindingNavigatorHanhKiem.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvHanhKiem.Rows)
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
            if (KiemTraTruocKhiLuu("colMaHanhKiem") == true &&
                KiemTraTruocKhiLuu("colTenHanhKiem") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HanhKiemCtrl.LuuHanhKiem();
            }
        }
        #endregion

        #region DataError event
        private void dgvHanhKiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmHanhKiem_Load(sender, e);
        }
    }
}
