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
    public partial class frmDoiMatKhau : Form
    {
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            lblLoiMatKhauCu.Text = "";
            lblLoiMatKhauMoi.Text = "";
            lblLoiNhapLaiMatKhauMoi.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhauMoi.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauCu.Select();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                lblLoiMatKhauCu.Text = "Chưa nhập mật khẩu hiện tại!";
                lblLoiMatKhauMoi.Text = "";
                lblLoiNhapLaiMatKhauMoi.Text = "";
                return;
            }

            if (txtMatKhauMoi.Text == "")
            {
                lblLoiMatKhauCu.Text = "";
                lblLoiMatKhauMoi.Text = "Chưa nhập mật khẩu mới!";
                lblLoiNhapLaiMatKhauMoi.Text = "";
                return;
            }

            if (txtNhapLaiMatKhauMoi.Text == "")
            {
                lblLoiMatKhauCu.Text = "";
                lblLoiMatKhauMoi.Text = "";
                lblLoiNhapLaiMatKhauMoi.Text = "Chưa nhập xác nhận mật khẩu!";
                return;
            }

            String m_Username = Utilities.NguoiDung.TenDangNhap;
            String m_Password = Utilities.NguoiDung.MatKhau;

            String m_OldPassword = Utilities.Encrypt(txtMatKhauCu.Text,true);
            String m_NewPassword = txtMatKhauMoi.Text;
            String m_ReNPassword = txtNhapLaiMatKhauMoi.Text;
            if (m_Password != m_OldPassword)
            {
                lblLoiMatKhauCu.Text = "Nhập sai mật khẩu cũ!";
                lblLoiMatKhauMoi.Text = "";
                lblLoiNhapLaiMatKhauMoi.Text = "";
            }
            else if (m_NewPassword != m_ReNPassword)
            {
                lblLoiMatKhauCu.Text = "";
                lblLoiMatKhauMoi.Text = "";
                lblLoiNhapLaiMatKhauMoi.Text = "Nhập xác nhận không khớp!";
            }
            else
            {
                m_NguoiDungCtrl.ChangePassword(m_Username, m_NewPassword);
                MessageBox.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNhapLaiMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDongY.PerformClick();
            }
        }
    }
}
