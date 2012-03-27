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
    public partial class frmGiaoVien : Form
    {
        #region Fields
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cboMonHoc);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(colMaMonHoc);

            m_GiaoVienCtrl.HienThi(dgvGiaoVien, bindingNavigatorGiaoVien, txtMaGiaoVien, txtHo, txtTen,dtpNgaySinh,  txtDiaChi, txtDienThoai, cboMonHoc);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorGiaoVien.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_GiaoVienCtrl.ThemDongMoi();
            m_Row["MaGiaoVien"] = "GV" + quyDinh.LaySTT(dgvGiaoVien.Rows.Count + 1);
            m_Row["Ho"] = "";
            m_Row["Ten"] = "";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_Row["MaMonHoc"] = null;
            m_GiaoVienCtrl.ThemGiaoVien(m_Row);
            bindingNavigatorGiaoVien.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmGiaoVien_Load(sender, e);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin giáo viên " + row.Cells["colTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
                KiemTraTruocKhiLuu("colHo") == true &&
                KiemTraTruocKhiLuu("colTen") == true &&
                KiemTraTruocKhiLuu("colNgaySinh") == true &&
                KiemTraTruocKhiLuu("colMaMonHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_GiaoVienCtrl.LuuGiaoVien();
            }
        }
        #endregion

        #region DataError event
        private void dgvGiaoVien_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region Click event

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (txtHo.Text != "" &&
                txtTen.Text != "" &&
                txtDiaChi.Text != "" &&
                txtDienThoai.Text != "" &&
                cboMonHoc.SelectedValue != null)
            {
                m_GiaoVienCtrl.LuuGiaoVien(txtMaGiaoVien.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, cboMonHoc.SelectedValue.ToString());
                m_GiaoVienCtrl.HienThi(dgvGiaoVien, bindingNavigatorGiaoVien, txtMaGiaoVien, txtHo, txtTen,dtpNgaySinh, txtDiaChi, txtDienThoai, cboMonHoc);
                bindingNavigatorGiaoVien.BindingSource.MoveLast();
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
