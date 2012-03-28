﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Properties;
using QuanLyGiaoDichTaiChinh.Reports;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmMain : Form
    {
        #region Fields
        frmDangNhap m_FrmDangNhap = null;
        frmDoiMatKhau m_FrmDoiMatKhau = null;
        frmKetNoiCSDL m_FrmKetNoiCSDL = null;
        #endregion

        #region Contructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            QuyenChuaDangNhap();
            timer1.Start();
            DataConnect.LayChuoiKetNoi(Settings.Default.Server, Settings.Default.Database, Settings.Default.Username,
            Settings.Default.Password, Settings.Default.Security);
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi)
            {
                //ketNoiCSDLToolStripMenuItem.Enabled = false;
                DataConnect.DongKetNoi();
                lblTinhTrangKetNoi.Text = "  Đã kết nối đến cơ sở dữ liệu " + Settings.Default.Database;
                dangNhapToolStripMenuItem.PerformClick();
            }
            else
            {
                huyKetNoiCSDLToolStripMenuItem.Enabled = false;
            }
        }
        #endregion

        #region Add TabPage
        private void AddTab(Form frm)
        {
            if (DataConnect.DaKetNoi == false)
            {
                ketNoiCSDLToolStripMenuItem.PerformClick();
                return;
            }
            TabPage tp = GetNewTabPage(frm.Text);
            if (tp.Text == "New")
            {
                tabControl1.Visible = dongTatCaTrangKhacToolStripMenuItem.Visible = dongTatCaToolStripMenuItem.Visible = btnDongTab.Visible = true;
                frm.Dock = DockStyle.Fill;
                frm.TopLevel = false;
                tp.Text = frm.Text;
                tp.Controls.Add(frm);
                tabControl1.TabPages.Add(tp);
                frm.Show();
            }
            tabControl1.SelectTab(tp);
        }

        private TabPage GetNewTabPage(string name)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Text == name)
                    return tabPage;
            }
            return new TabPage("New");
        }
        #endregion

        #region Phân quyền
        private void QuyenChuaDangNhap()
        {
            dongTatCaToolStripMenuItem.PerformClick();
            //dangNhapToolStripMenuItem.Enabled = true;
            dangXuatToolStripMenuItem.Enabled = false;
            doiMatKhauToolStripMenuItem.Enabled = false;
            nguoiDungToolStripMenuItem.Enabled = false;
            saoLuuDuLieuToolStripMenuItem.Enabled = false;
            phucHoiDuLieuToolStripMenuItem.Enabled = false;
            quyDinhToolStripMenuItem.Enabled = false;
            danhMucToolStripMenuItem.Enabled = false;
            quanLyChoVayToolstipMenuItem.Enabled = false;
            quanLyVayToolStripMenuItem.Enabled = false;
            quanLyThuChiToolStripMenuItem.Enabled = false;
            timKiemToolStripMenuItem.Enabled = false;
            thongKeToolStripMenuItem.Enabled = false;
        }

        private void QuyenNhanVienGiaoDich()
        {
            dongTatCaToolStripMenuItem.PerformClick();
            //dangNhapToolStripMenuItem.Enabled = false;
            dangXuatToolStripMenuItem.Enabled = true;
            doiMatKhauToolStripMenuItem.Enabled = true;
            nguoiDungToolStripMenuItem.Enabled = false;
            saoLuuDuLieuToolStripMenuItem.Enabled = false;
            phucHoiDuLieuToolStripMenuItem.Enabled = false;
            quyDinhToolStripMenuItem.Enabled = false;
            danhMucToolStripMenuItem.Enabled = true;
            quanLyChoVayToolstipMenuItem.Enabled = true;
            quanLyVayToolStripMenuItem.Enabled = true;
            quanLyThuChiToolStripMenuItem.Enabled = true;
            timKiemToolStripMenuItem.Enabled = true;
            thongKeToolStripMenuItem.Enabled = true;
        }

        private void QuyenQuanTriVien()
        {
            dongTatCaToolStripMenuItem.PerformClick();
            //dangNhapToolStripMenuItem.Enabled = false;
            dangXuatToolStripMenuItem.Enabled = true;
            doiMatKhauToolStripMenuItem.Enabled = true;
            nguoiDungToolStripMenuItem.Enabled = true;
            saoLuuDuLieuToolStripMenuItem.Enabled = true;
            phucHoiDuLieuToolStripMenuItem.Enabled = true;
            quyDinhToolStripMenuItem.Enabled = true;
            danhMucToolStripMenuItem.Enabled = true;
            quanLyChoVayToolstipMenuItem.Enabled = true;
            quanLyVayToolStripMenuItem.Enabled = true;
            quanLyThuChiToolStripMenuItem.Enabled = true;
            timKiemToolStripMenuItem.Enabled = true;
            thongKeToolStripMenuItem.Enabled = true;
        }

        private void PhanQuyen(string loaiND)
        {
            switch (loaiND)
            {
                case "1": QuyenQuanTriVien(); break;
                case "2": QuyenNhanVienGiaoDich(); break;
                default: QuyenChuaDangNhap(); break;
            }
        }
        #endregion

        #region Tình trạng
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("h:mm:ss tt  d/MM/yyyy");
        }
        #endregion

        #region Đóng TabPage
        private void btnDongTab_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có thực sự muốn đóng trang " + tabControl1.SelectedTab.Text,
                //"Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            int i = tabControl1.SelectedIndex;
            tabControl1.SelectedTab.Dispose();
            if (tabControl1.TabCount == 0) btnDongTab.Visible = tabControl1.Visible = dongTatCaTrangKhacToolStripMenuItem.Visible = dongTatCaToolStripMenuItem.Visible = false;
            if (i > 0)
                tabControl1.SelectTab(i - 1);
            //}
        }
        #endregion

        #region Show form
        #region Hệ thống
        private void ketNoiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_FrmKetNoiCSDL == null || m_FrmKetNoiCSDL.IsDisposed)
                m_FrmKetNoiCSDL = new frmKetNoiCSDL();
            if (m_FrmKetNoiCSDL.ShowDialog() == DialogResult.OK)
            {
                //ketNoiCSDLToolStripMenuItem.Enabled = false;
                huyKetNoiCSDLToolStripMenuItem.Enabled = true;
                lblTinhTrangKetNoi.Text = "  Đã kết nối đến cơ sở dữ liệu " + Settings.Default.Database;
            }
        }

        private void huyKetNoiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataConnect.HuyKetNoi();
            //ketNoiCSDLToolStripMenuItem.Enabled = true;
            huyKetNoiCSDLToolStripMenuItem.Enabled = false;
            tabControl1.TabPages.Clear();
            btnDongTab.Visible = tabControl1.Visible = dongTatCaTrangKhacToolStripMenuItem.Visible = dongTatCaToolStripMenuItem.Visible = false;
            lblTinhTrangKetNoi.Text = "  Đã hủy kết nối đến cơ sở dữ liệu";
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_FrmDangNhap == null || m_FrmDangNhap.IsDisposed)
                m_FrmDangNhap = new frmDangNhap();
            if (m_FrmDangNhap.ShowDialog() == DialogResult.OK)
            {
                lblNguoiDangNhap.Text = "Người đăng nhập: " + Utilities.NguoiDung.TenNguoiDung;
                PhanQuyen(Utilities.NguoiDung.LoaiNguoiDung.MaLoai);
            }
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNguoiDangNhap.Text = "Chưa đăng nhập";
            QuyenChuaDangNhap();
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_FrmDoiMatKhau == null || m_FrmDoiMatKhau.IsDisposed)
                m_FrmDoiMatKhau = new frmDoiMatKhau();
            m_FrmDoiMatKhau.ShowDialog();
        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNguoiDung());
        }

        private void loaiNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmLoaiNguoiDung());
        }

        private void quyDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmQuyDinh().Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion
        #region Danh mục
        private void khoiLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmKhoiLop());
        }

        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmLop());
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmMonHoc());
        }

        private void hocKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmHocKy());
        }

        private void namHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNamHoc());
        }

        private void loaiDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmLoaiDiem());
        }

        private void hocLucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmHocLuc());
        }

        private void ketQuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmKetQua());
        }

        private void hanhKiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmHanhKiem());
        }

        private void danTocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmDanToc());
        }

        private void tonGiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmTonGiao());
        }

        private void ngheNghiepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNgheNghiep());
        }

        private void hocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmHocSinh());
        }

        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmGiaoVien());
        }
        #endregion
        #region Nghiệp vụ
        private void nhapDiemTheoLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNhapDiemTheoLop());
        }

        private void nhapDiemTheoHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNhapDiemTheoHocSinh());
        }

        private void nhapDiemThiLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNhapDiemThiLai());
        }

        private void nhapHanhKiemTheoLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmNhapHanhKiemTheoLop());
        }

        private void phanLopHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmPhanLop());
        }

        private void phanCongGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmPhanCong());
        }
        #endregion
        #region Tra cứu
        private void traCuuHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmTraCuuHocSinh());
        }

        private void traCuuGiaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmTraCuuGiaoVien());
        }

        private void traCuuLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frmTraCuuLopHoc());
        }
        #endregion
        #region Thống kê
        private void tkDiemHocKyTheoMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaHocKy_MonHoc());
        }

        private void tkDiemHocKyTtheoLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaHocKy_Lop());
        }

        private void tkDiemHocKyTheoHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaHocKy_HocSinh());
        }

        private void tkDiemCaNamTheoLopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaCaNam_Lop());
        }

        private void tkDiemCaNamTheoMonHocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaCaNam_MonHoc());
        }

        private void tkDiemCaNamTheoHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab(new frptKetQuaCaNam_HocSinh());
        }

        #endregion
        #region Hiển thị
        private void thanhCongCuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = thanhCongCuToolStripMenuItem.Checked;
            if (toolStrip1.Visible == false)
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y - 25);
            else
                btnDongTab.Location = new Point(btnDongTab.Location.X, btnDongTab.Location.Y + 25);
        }

        private void thanhTinhTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = thanhTinhTrangToolStripMenuItem.Checked;
        }

        private void dongTatCaTrangKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thực sự muốn đóng tất cả các trang khác?",
                "Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TabPage tp = tabControl1.SelectedTab;
                    foreach (TabPage tabPage in tabControl1.TabPages)
                    {
                        if (string.Compare(tabPage.Text, tp.Text) != 0)
                            tabControl1.TabPages.Remove(tabPage);
                    }
                }
            }
            catch { }
        }

        private void dongTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Bạn có thực sự muốn đóng tất cả các trang?",
                "Xác nhận đóng trang", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 tabControl1.TabPages.Clear();
                 btnDongTab.Visible = tabControl1.Visible = dongTatCaTrangKhacToolStripMenuItem.Visible = dongTatCaToolStripMenuItem.Visible = false;
             }
        }
        #endregion 
        #region Trợ giúp
        private void huongDanSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thongTinPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void lapGiaoDichToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void giaoDichKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
