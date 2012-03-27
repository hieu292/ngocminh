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
    public partial class frmTonGiao : Form
    {
        #region Fields
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmTonGiao()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            m_TonGiaoCtrl.HienThi(dgvTonGiao, bindingNavigatorTonGiao);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorTonGiao.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            DataRow m_Row = m_TonGiaoCtrl.ThemDongMoi();
            m_Row["MaTonGiao"] = "TG" + quyDinh.LaySTT(dgvTonGiao.Rows.Count + 1);
            m_Row["TenTonGiao"] = "";
            m_TonGiaoCtrl.ThemTonGiao(m_Row);
            bindingNavigatorTonGiao.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvTonGiao.Rows)
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
            if (KiemTraTruocKhiLuu("colMaTonGiao") == true &&
                KiemTraTruocKhiLuu("colTenTonGiao") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_TonGiaoCtrl.LuuTonGiao();
            }
        }
        #endregion

        #region DataError event
        private void dgvTonGiao_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmTonGiao_Load(sender, e);
        }
    }
}
