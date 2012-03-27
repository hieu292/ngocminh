using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNhapDiemTheoHocSinh : Form
    {
        #region Fields
        NamHocCtrl      m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl       m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl         m_LopCtrl       = new LopCtrl();
        HocSinhCtrl     m_HocSinhCtrl   = new HocSinhCtrl();
        MonHocCtrl      m_MonHocCtrl    = new MonHocCtrl();
        LoaiDiemCtrl    m_LoaiDiemCtrl  = new LoaiDiemCtrl();
        DiemCtrl        m_DiemCtrl      = new DiemCtrl();
        KQHocKyMonHocCtrl m_KQHocKyMonHocCtrl = new KQHocKyMonHocCtrl();
        KQHocKyTongHopCtrl m_KQHocKyTongHopCtrl = new KQHocKyTongHopCtrl();
        KQCaNamMonHocCtrl m_KQCaNamMonHocCtrl = new KQCaNamMonHocCtrl();
        KQCaNamTongHopCtrl m_KQCaNamTongHopCtrl = new KQCaNamTongHopCtrl();
        QuyDinh         quyDinh         = new QuyDinh();
        #endregion

        #region Constructor
        public frmNhapDiemTheoHocSinh()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhapDiemTheoHocSinh_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            m_HocKyCtrl.HienThiComboBox(cboHocKy);
            m_LoaiDiemCtrl.HienThiComboBox(cboLoaiDiem);
            if (cboNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
                m_HocSinhCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboHocSinh);
            }
        }
        #endregion

        #region BindingNavigatorItems
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDiem.Rows.Remove(dgvDiem.CurrentRow);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int numberOfRow = dgvDiem.RowCount;
            for (int i = 0; i < numberOfRow; i++)
            {
                DiemInfo diem = new DiemInfo();
                diem = (DiemInfo)dgvDiem.Rows[i].Tag;
                //Lưu vào bảng điểm
                m_DiemCtrl.LuuDiem(diem.HocSinh.MaHocSinh, diem.MonHoc.MaMonHoc, diem.HocKy.MaHocKy, diem.NamHoc.MaNamHoc, diem.Lop.MaLop, diem.LoaiDiem.MaLoai, diem.Diem);
                #region Lưu vào bảng kết quả
                m_KQHocKyMonHocCtrl.LuuKetQua(diem.HocSinh.MaHocSinh.ToString(),
                                              diem.Lop.MaLop.ToString(),
                                              diem.MonHoc.MaMonHoc.ToString(),
                                              diem.HocKy.MaHocKy.ToString(),
                                              diem.NamHoc.MaNamHoc.ToString());

                m_KQCaNamMonHocCtrl.LuuKetQua(diem.HocSinh.MaHocSinh.ToString(),
                                              diem.Lop.MaLop.ToString(),
                                              diem.MonHoc.MaMonHoc.ToString(),
                                              diem.NamHoc.MaNamHoc.ToString());

                m_KQHocKyTongHopCtrl.LuuKetQua(diem.HocSinh.MaHocSinh.ToString(),
                                               diem.Lop.MaLop.ToString(),
                                               diem.HocKy.MaHocKy.ToString(),
                                               diem.NamHoc.MaNamHoc.ToString());

                m_KQCaNamTongHopCtrl.LuuKetQua(diem.HocSinh.MaHocSinh.ToString(),
                                               diem.Lop.MaLop.ToString(),
                                               diem.NamHoc.MaNamHoc.ToString());
                #endregion
            }
            dgvDiem.Rows.Clear();

            MessageBox.Show("Đã lưu vào bảng điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Click event
        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            if (quyDinh.KiemTraDiem(txtDiem.Text) == false || txtDiem.Text == "")
            {
                MessageBox.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvDiem.Rows.Add(cboHocSinh.SelectedValue.ToString(),
                                 cboHocSinh.Text,
                                 cboLop.Text,
                                 cboNamHoc.Text,
                                 cboHocKy.Text,
                                 cboMonHoc.Text,
                                 cboLoaiDiem.Text,
                                 txtDiem.Text);

                DiemInfo diem = new DiemInfo();
                diem.HocSinh.MaHocSinh = cboHocSinh.SelectedValue.ToString();
                diem.MonHoc.MaMonHoc = cboMonHoc.SelectedValue.ToString();
                diem.HocKy.MaHocKy = cboHocKy.SelectedValue.ToString();
                diem.NamHoc.MaNamHoc = cboNamHoc.SelectedValue.ToString();
                diem.Lop.MaLop = cboLop.SelectedValue.ToString();
                diem.LoaiDiem.MaLoai = cboLoaiDiem.SelectedValue.ToString();
                diem.Diem = Convert.ToSingle(txtDiem.Text);

                dgvDiem.Rows[dgvDiem.RowCount - 1].Tag = diem;
            }
        }
        #endregion

        #region SelectedIndexChanged event
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
            cboLop.DataBindings.Clear();
            cboLop_SelectedIndexChanged(sender, e);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
                m_HocSinhCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboHocSinh);
            }
            cboMonHoc.DataBindings.Clear();
            cboHocSinh.DataBindings.Clear();
        }
        #endregion

        #region Key event
        private void txtDiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemVaoDS.PerformClick();
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
