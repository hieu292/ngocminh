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
    public partial class frmLoaiDiem : Form
    {
        #region Fields
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmLoaiDiem()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            m_LoaiDiemCtrl.HienThi(dgvLoaiDiem, bindingNavigatorLoaiDiem);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLoaiDiem.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_LoaiDiemCtrl.ThemDongMoi();
            m_Row["MaLoai"] = "LD" + quyDinh.LaySTT(dgvLoaiDiem.Rows.Count + 1);
            m_Row["TenLoai"] = "";
            m_Row["HeSo"] = 0;
            m_LoaiDiemCtrl.ThemLoaiDiem(m_Row);
            bindingNavigatorLoaiDiem.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLoaiDiem.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBox.Show("Giá trị của ô không được rỗng và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLoai") == true &&
                KiemTraTruocKhiLuu("colTenLoai") == true &&
                KiemTraTruocKhiLuu("colHeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiDiemCtrl.LuuLoaiDiem();
            }
        }
        #endregion

        #region LoaiDiem event
        private void dgvLoaiDiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmLoaiDiem_Load(sender, e);
        }
    }
}
