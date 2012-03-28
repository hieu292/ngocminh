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
    public partial class frmSuaNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        DataRow m_Row;
        #endregion

        public frmSuaNguoiDung(NguoiDungCtrl nguoidung, int maND)
        {
            InitializeComponent();
            m_NguoiDungCtrl = nguoidung;
            m_LoaiNguoiDungCtrl.HienThiComboBox(cboLoaiNguoiDung);
            m_Row = m_NguoiDungCtrl.FindRow(maND);
            cboLoaiNguoiDung.SelectedValue = m_Row["MaLoaiNguoiDung"];
            if ((int)m_Row["MaLoaiNguoiDung"] == 1)
                cboLoaiNguoiDung.Enabled = false;
            txtMatKhau.Text = Utilities.Decrypt(m_Row["MatKhau"].ToString(), true);
            txtMatKhauXacNhan.Text = txtMatKhau.Text;
            txtTenNguoiDung.Text = m_Row["TenNguoiDung"].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtMatKhauXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauXacNhan.Focus();
                return;
            }

            m_Row["MaLoaiNguoiDung"] = cboLoaiNguoiDung.SelectedValue;
            m_Row["TenNguoiDung"] = txtTenNguoiDung.Text;
            m_Row["MatKhau"] = Utilities.Encrypt(txtMatKhau.Text, true);
            if(m_NguoiDungCtrl.LuuNguoiDung())
                this.DialogResult = DialogResult.OK;
        }

        private void txtTenNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnXacNhan.PerformClick();
            }
        }


    }
}
