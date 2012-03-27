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
    public partial class frmNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_NguoiDungCtrl.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
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
                }
            }
            if (dgvNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung(m_NguoiDungCtrl);
            frm.ShowDialog();
            /*DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaNguoiDung"] = DBNull.Value;
            m_Row["MaLoaiNguoiDung"] = "1";
            m_Row["TenNguoiDung"] = "";
            m_Row["TenDangNhap"] = "";
            m_Row["MatKhau"] = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bindingNavigatorNguoiDung.BindingSource.MoveLast();
            if (dgvNguoiDung.RowCount > 0)
                bindingNavigatorDeleteItem.Enabled = true;*/
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaND") == true &&
               KiemTraTruocKhiLuu("colMaLoai") == true &&
               KiemTraTruocKhiLuu("colTenND") == true &&
               KiemTraTruocKhiLuu("colTenDNhap") == true &&
               KiemTraTruocKhiLuu("colMatKhau") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NguoiDungCtrl.LuuNguoiDung();
            }
        }

        private void dgvNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung_Load(sender, e);
        }





    }
}
