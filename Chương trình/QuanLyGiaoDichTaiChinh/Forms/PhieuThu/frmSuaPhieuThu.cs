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
    public partial class frmSuaPhieuThu : Form
    {
        PhieuThuCtrl m_PhieuThuCtrl = new PhieuThuCtrl();
        KhachHangCtrl m_KhachHangCtrl = new KhachHangCtrl();
        KhoanThuCtrl m_KhoanThuCtrl = new KhoanThuCtrl();

        int soPhieuThu = 0;
        int tinhTrang = 0;

        public frmSuaPhieuThu()
        {
            InitializeComponent();
        }

        public int SoPhieuThu
        {
            get { return soPhieuThu; }
            set { soPhieuThu = value; }
        }

        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        private void frmSuaPhieuThu_Load(object sender, EventArgs e)
        {
            m_KhachHangCtrl.HienThiComboBox(cboKhachHang);
            m_KhoanThuCtrl.HienThiComboBox(cboKhoanThu);
            txtSoPT.Text = soPhieuThu.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtpNgayThu.Value.DayOfYear < dtpNgayLap.Value.DayOfYear)
            {
                MessageBox.Show("Ngày lập phải trước ngày thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Focus();
                return;
            }
            if (m_PhieuThuCtrl.CapNhatPhieuThu(soPhieuThu,
                cboKhachHang.SelectedValue.ToString(),
                dtpNgayLap.Value, dtpNgayThu.Value,
                Convert.ToInt32(cboKhoanThu.SelectedValue.ToString()),
                Convert.ToInt64(nudSoTienThu.Value.ToString()),
                txtGhiChu.Text, false) != 0)
            {
                MessageBox.Show("Đã lưu phiếu thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tinhTrang = 0;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi trong khi lưu phiếu thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDaThu_Click(object sender, EventArgs e)
        {
            if (dtpNgayThu.Value.DayOfYear < dtpNgayLap.Value.DayOfYear)
            {
                MessageBox.Show("Ngày lập phải trước ngày thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Focus();
                return;
            }
            if ((soPhieuThu = m_PhieuThuCtrl.CapNhatPhieuThu(soPhieuThu, cboKhachHang.SelectedValue.ToString(),
                dtpNgayLap.Value, dtpNgayThu.Value,
                Convert.ToInt32(cboKhoanThu.SelectedValue.ToString()),
                Convert.ToInt64(nudSoTienThu.Value.ToString()),
                txtGhiChu.Text, true)) != 0)
            {
                tinhTrang = 1;
                MessageBox.Show("Đã lưu và xác nhận phiếu thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi trong khi lưu và xác nhận phiếu thu!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
