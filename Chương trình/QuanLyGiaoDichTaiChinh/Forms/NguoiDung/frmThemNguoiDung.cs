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
    public partial class frmThemNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        #endregion

        public frmThemNguoiDung(NguoiDungCtrl nguoidung)
        {
            InitializeComponent();
            m_NguoiDungCtrl = nguoidung;
            m_LoaiNguoiDungCtrl.HienThiComboBox(cboLoaiNguoiDung);
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String s = txtTenDangNhap.Text;
            if (s == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            char c;
            for (int i = 0; i < s.Length; ++i)
            {
                c = s[i];
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || (c > 47 && c < 58) || c == 46 || c == 8 || c == 127)
                {
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập không dấu và không cách trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.SelectAll();
                    txtTenDangNhap.Focus();
                    return;
                }
            }

            if (txtMatKhau.Text != txtMatKhauXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng nhập lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauXacNhan.Focus();
                txtMatKhauXacNhan.SelectAll();
                return;
            }
            if (m_NguoiDungCtrl.isDuplicate(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng đổi tên đăng nhập khác!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                txtTenDangNhap.SelectAll();
                return;
            }
            DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaNguoiDung"] = -1;
            m_Row["MaLoaiNguoiDung"] = cboLoaiNguoiDung.SelectedValue;
            m_Row["TenNguoiDung"] = txtTenNguoiDung.Text;
            m_Row["TenDangNhap"] = txtTenDangNhap.Text;
            m_Row["MatKhau"] = Utilities.Encrypt(txtMatKhau.Text, true);
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            this.DialogResult = DialogResult.OK;
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || (c > 47 && c < 58) || c == 46 || c==8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtTenNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }
    }
}
