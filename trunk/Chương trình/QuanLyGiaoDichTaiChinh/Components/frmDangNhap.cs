using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmDangNhap : Form
    {
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            lblLoiTenDangNhap.Text = "";
            lblLoiMatKhau.Text = "";
            txtUsername.Select();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblLoiTenDangNhap.Text = "";
                lblLoiTenDangNhap.Text = "Bạn chưa nhập tên!";
                return;
            }

            /*if (txtPassword.Text == "")
            {
                lblLoiTenDangNhap.Text = "";
                lblLoiMatKhau.Text = "Bạn chưa nhập mật khẩu!";
                return;
            }*/

            int ketQua = m_NguoiDungCtrl.DangNhap(txtUsername.Text, txtPassword.Text);

            switch (ketQua)
            {
                case 0:
                    lblLoiMatKhau.Text = "";
                    lblLoiTenDangNhap.Text = "Người dùng này không tồn tại!";
                    break;
                case 1:
                    lblLoiTenDangNhap.Text = "";
                    lblLoiMatKhau.Text = "Mật khẩu không hợp lệ!";
                    break;
                case 2:
                    this.DialogResult = DialogResult.OK;
                    break;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
