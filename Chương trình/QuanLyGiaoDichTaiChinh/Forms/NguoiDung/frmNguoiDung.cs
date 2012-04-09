using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        #endregion
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_NguoiDungCtrl.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
            lblStatus.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount > 0)
            {
                if (dgvNguoiDung.Rows[dgvNguoiDung.CurrentCell.RowIndex].Cells[0].Value.ToString() == "1")
                {
                    MessageBox.Show("Đây là tài khoản mặc định bạn không thể xóa!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
                    lblStatus.Text = "*";
                }
            }
            if (dgvNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung(m_NguoiDungCtrl);
            if(frm.ShowDialog() == DialogResult.OK)
                lblStatus.Text = "*";
        }

        private void dgvNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung_Load(sender, e);
        }

        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            frmSuaNguoiDung frm = new frmSuaNguoiDung(m_NguoiDungCtrl, (int)dgvNguoiDung.Rows[dgvNguoiDung.CurrentCell.RowIndex].Cells[0].Value);
            if (frm.ShowDialog() == DialogResult.OK)
                lblStatus.Text = "*";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "") return;
            if (m_NguoiDungCtrl.LuuNguoiDung())
            {
                MessageBox.Show("Lưu thay đổi người dùng thành công!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNguoiDung_Load(sender, e);
            }
            else
                MessageBox.Show("Lưu thay đổi người dùng thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
