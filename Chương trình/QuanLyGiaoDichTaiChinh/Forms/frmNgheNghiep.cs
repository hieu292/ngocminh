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
    public partial class frmNgheNghiep : Form
    {
        #region Fields
        NgheNghiepCtrl m_NgheNghiepCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmNgheNghiep()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNgheNghiep_Load(object sender, EventArgs e)
        {
            m_NgheNghiepCtrl.HienThi(dgvNgheNghiep, bindingNavigatorNgheNghiep);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNgheNghiep.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNgheNghiep.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNgheNghiep.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NgheNghiepCtrl.ThemDongMoi();
            m_Row["MaNghe"] = "NN" + quyDinh.LaySTT(dgvNgheNghiep.Rows.Count + 1);
            m_Row["TenNghe"] = "";
            m_NgheNghiepCtrl.ThemNgheNghiep(m_Row);
            bindingNavigatorNgheNghiep.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNgheNghiep.Rows)
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
            if (KiemTraTruocKhiLuu("colMaNghe") == true &&
                KiemTraTruocKhiLuu("colTenNghe") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NgheNghiepCtrl.LuuNgheNghiep();
            }
        }
        #endregion

        #region DataError event
        private void dgvNgheNghiep_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNgheNghiep_Load(sender, e);
        }
    }
}
