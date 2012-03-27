using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh.Forms
{
    public partial class frmThemNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        #endregion
        public frmThemNguoiDung()
        {
            InitializeComponent();
            m_LoaiNguoiDungCtrl.HienThiComboBox(cboLoaiNguoiDung);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
