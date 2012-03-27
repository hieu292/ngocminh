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
    public partial class frmLop : Form
    {
        #region Fields
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThiComboBox(cboKhoiLop);
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            m_GiaoVienCtrl.HienThiComboBox(cboGiaoVien);
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(colMaKhoiLop);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(colMaNamHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);

            m_LopCtrl.HienThi(dgvLop, bindingNavigatorLop, txtMaLop, txtTenLop, cboKhoiLop, cboNamHoc, nudSiSo, cboGiaoVien);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLop.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_LopCtrl.ThemDongMoi();
            m_Row["MaLop"] = "";
            m_Row["TenLop"] = "";
            m_Row["MaKhoiLop"] = null;
            m_Row["MaNamHoc"] = null;
            m_Row["SiSo"] = 0;
            m_Row["MaGiaoVien"] = null;
            m_LopCtrl.ThemLop(m_Row);
            bindingNavigatorLop.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmLop_Load(sender, e);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
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

        public Boolean KiemTraSiSoTruocKhiLuu(String siSoColumn)
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (row.Cells[siSoColumn].Value != null)
                {
                    try
                    {
                        int siSo = Convert.ToInt32(row.Cells[siSoColumn].Value.ToString());

                        if (quyDinh.KiemTraSiSo(siSo) == false)
                        {
                            MessageBox.Show("Sỉ số không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sỉ số phải là một số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaLop") == true &&
                KiemTraTruocKhiLuu("colTenLop") == true &&
                KiemTraTruocKhiLuu("colMaKhoiLop") == true &&
                KiemTraTruocKhiLuu("colMaNamHoc") == true &&
                KiemTraTruocKhiLuu("colMaGiaoVien") == true &&
                KiemTraSiSoTruocKhiLuu("colSiSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LopCtrl.LuuLop();
            }
        }
        #endregion

        #region DataError event
        private void dgvLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" &&
                txtTenLop.Text != "" &&
                cboKhoiLop.SelectedValue != null &&
                cboNamHoc.SelectedValue != null &&
                cboGiaoVien.SelectedValue != null &&
                quyDinh.KiemTraSiSo(Convert.ToInt16(nudSiSo.Value)) == true)
            {
                m_LopCtrl.LuuLop(txtMaLop.Text, txtTenLop.Text, cboKhoiLop.SelectedValue.ToString(), cboNamHoc.SelectedValue.ToString(), Convert.ToInt16(nudSiSo.Value), cboGiaoVien.SelectedValue.ToString());
                m_LopCtrl.HienThi(dgvLop, bindingNavigatorLop, txtMaLop, txtTenLop, cboKhoiLop, cboNamHoc, nudSiSo, cboGiaoVien);

                bindingNavigatorLop.BindingSource.MoveLast();
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng và sỉ số phải theo quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
