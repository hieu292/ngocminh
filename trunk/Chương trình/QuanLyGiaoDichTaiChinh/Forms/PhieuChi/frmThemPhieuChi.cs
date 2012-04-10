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
    public partial class frmThemPhieuChi : Form
    {
        PhieuChiCtrl m_PhieuChiCtrl = new PhieuChiCtrl();
        NhanVienCtrl m_NhanVienCtrl = new NhanVienCtrl();
        KhoanChiCtrl m_KhoanChiCtrl = new KhoanChiCtrl();

        int soPhieuChi = 0;
        int tinhTrang = 0;
        public frmThemPhieuChi()
        {
            InitializeComponent();
        }
        public int SoPhieuChi
        {
            get { return soPhieuChi; }
            set { soPhieuChi = value; }
        }
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        private void frmThemPhieuChi_Load(object sender, EventArgs e)
        {
            m_NhanVienCtrl.HienThiComboBox(cboNhanVien);
            m_KhoanChiCtrl.HienThiComboBox(cboKhoanChi);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtpNgayChi.Value.DayOfYear < dtpNgayLap.Value.DayOfYear)
            {
                MessageBox.Show("Ngày lập phải trước ngày chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Focus();
                return;
            }
            if ((soPhieuChi = m_PhieuChiCtrl.LuuPhieuChi(cboNhanVien.SelectedValue.ToString(),
                dtpNgayLap.Value, dtpNgayChi.Value,
                Convert.ToInt32(cboKhoanChi.SelectedValue.ToString()),
                Convert.ToInt64(nudSoTienChi.Value.ToString()),
                txtGhiChu.Text, false)) != 0)
            {
                MessageBox.Show("Đã lưu phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tinhTrang = 0;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi trong khi lưu phiếu chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDaChi_Click(object sender, EventArgs e)
        {
            if (dtpNgayChi.Value.DayOfYear < dtpNgayLap.Value.DayOfYear)
            {
                MessageBox.Show("Ngày lập phải trước ngày chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayLap.Focus();
                return;
            }
            if ((soPhieuChi = m_PhieuChiCtrl.LuuPhieuChi(cboNhanVien.SelectedValue.ToString(),
                dtpNgayLap.Value, dtpNgayChi.Value,
                Convert.ToInt32(cboKhoanChi.SelectedValue.ToString()),
                Convert.ToInt64(nudSoTienChi.Value.ToString()),
                txtGhiChu.Text, true)) != 0)
            {
                tinhTrang = 1;
                MessageBox.Show("Đã lưu và xác nhận phiếu chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi trong khi lưu và xác nhận phiếu chi!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
