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
    public partial class frmPhanLop : Form
    {
        #region Fields
        NamHocCtrl m_NamHocCuCtrl = new NamHocCtrl();
        NamHocCtrl m_NamHocMoiCtrl = new NamHocCtrl();
        KhoiLopCtrl m_KhoiLopCuCtrl = new KhoiLopCtrl();
        KhoiLopCtrl m_KhoiLopMoiCtrl = new KhoiLopCtrl();
        LopCtrl m_LopCuCtrl = new LopCtrl();
        LopCtrl m_LopMoiCtrl = new LopCtrl();
        HocSinhCtrl m_HocSinhCuCtrl = new HocSinhCtrl();
        HocSinhCtrl m_HocSinhMoiCtrl = new HocSinhCtrl();

        #endregion

        #region Constructor
        public frmPhanLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            m_NamHocCuCtrl.HienThiComboBox(cboNamHocCu);
            m_NamHocMoiCtrl.HienThiComboBox(cboNamHocMoi);
        }

        private void frmPhanLop_Shown(object sender, EventArgs e)
        {
            cboNamHocCu_SelectedIndexChanged(sender, e);
            cboNamHocMoi_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region Lưu vào bảng PHANLOP
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null &&
                cboKhoiLopMoi.SelectedValue != null &&
                cboLopMoi.SelectedValue != null)
            {
                String maLopMoi = cboLopMoi.SelectedValue.ToString();
                for (int i = 0; i < dgvLopMoi.RowCount; i++ )
                {
                    m_HocSinhMoiCtrl.PhanLopHocSinh(dgvLopMoi.Rows[i].Cells[1].Value.ToString(), maLopMoi);
                    //cboLopMoi_SelectedIndexChanged(sender, e);
                }
                MessageBox.Show("Đã cập nhật lớp mới cho các học sinh!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region SelectedIndexChanged event
        private void cboNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null)
                m_KhoiLopCuCtrl.HienThiComboBox(cboNamHocCu.SelectedValue.ToString(), cboKhoiLopCu);
        }

        private void cboNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null)
                m_KhoiLopMoiCtrl.HienThiComboBox(cboNamHocMoi.SelectedValue.ToString(), cboKhoiLopMoi);
        }

        private void cboKhoiLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopCu.SelectedValue != null)
            {
                m_LopCuCtrl.HienThiComboBox(cboKhoiLopCu.SelectedValue.ToString(), cboNamHocCu.SelectedValue.ToString(), cboLopCu);
                cboLopCu_SelectedIndexChanged(sender, e);
            }
        }

        private void cboKhoiLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopMoi.SelectedValue != null)
            {
                m_LopMoiCtrl.HienThiComboBox(cboKhoiLopMoi.SelectedValue.ToString(), cboNamHocMoi.SelectedValue.ToString(), cboLopMoi);
                cboLopMoi_SelectedIndexChanged(sender, e);
            }
        }

        private void cboLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopCu.SelectedValue != null)
            {
                cboKetQua_SelectedIndexChanged(sender, e);
                chkChonCu.Checked = false;
            }
        }

        private void cboLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopMoi.SelectedValue != null)
                m_HocSinhMoiCtrl.HienThiDsHocSinhTheoLop(dgvLopMoi, cboLopMoi.SelectedValue.ToString());
        }

        private void cboKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopCu.SelectedValue.ToString() != null)
            {
                int idx = cboKetQua.SelectedIndex;
                if (idx == 0)
                    m_HocSinhCuCtrl.HienThiDsHocSinhTheoLopVaKetQua(dgvLopCu, cboLopCu.SelectedValue.ToString());
                else if (idx == 1)
                    m_HocSinhCuCtrl.HienThiDsHocSinhChuaPhanLop(dgvLopCu);
                else
                    m_HocSinhCuCtrl.HienThiDsHocSinhTheoLop(dgvLopCu, cboLopCu.SelectedValue.ToString(), cboKetQua.Text);
            }
        }
        #endregion

        #region Click Event
        private void chkChonCu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLopCu.Rows.Count; i++)
            {
                dgvLopCu.Rows[i].Cells[0].Value = chkChonCu.Checked;
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = dgvLopCu.RowCount - 1; i >= 0; i--)
            {
                try
                {
                    if (dgvLopCu.Rows[i].Cells[0].Value.ToString() == "True")
                        if (ChuyenLop(dgvLopCu.Rows[i], dgvLopMoi))
                        {
                            Xoa(dgvLopCu, i);

                            count++;
                        }
                }
                catch { }
            }
            if (cboKetQua.SelectedIndex == 1)
                MessageBox.Show("Đã chuyển " + count + " học sinh chưa xếp lớp vào lớp " + cboLopMoi.Text + " năm học " + cboNamHocMoi.Text,
               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Đã chuyển " + count + " học sinh từ lớp " + cboLopCu.Text + " năm học " +
                    cboNamHocCu.Text + " sang lớp " + cboLopMoi.Text + " năm học " + cboNamHocMoi.Text,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvLopCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    if (dgvLopCu.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                        chkChonCu.Checked = false;
                }
                catch { }
            }
        }

        private Boolean ChuyenLop(DataGridViewRow rowLopCu, DataGridView lopMoi)
        {
            String maHS = rowLopCu.Cells[1].Value.ToString();
            String tenHS = rowLopCu.Cells[2].Value.ToString();
            for (int i = 0; i < lopMoi.RowCount; i++)
                if (lopMoi.Rows[i].Cells[1].Value.ToString() == maHS)
                {
                    //MessageBox.Show("Học sinh " + tenHS + " đã học ở lớp mới này rồi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            BindingSource bS = (BindingSource)lopMoi.DataSource;
            bS.AddNew();
            dgvLopMoi.Rows[bS.Count - 1].Cells[0].Value = false;
            dgvLopMoi.Rows[bS.Count - 1].Cells[1].Value = rowLopCu.Cells[1].Value.ToString();
            dgvLopMoi.Rows[bS.Count - 1].Cells[2].Value = rowLopCu.Cells[2].Value.ToString();
            return true;
        }

        private Boolean Xoa(DataGridView dgv, int rid)
        {
            try
            {
                BindingSource bs = (BindingSource)dgv.DataSource;
                bs.RemoveAt(rid);
                return true;
            }
            catch { }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (MessageBox.Show("Bạn có chắc bạn muốn xóa toàn bộ các học sinh đã chọn trong lớp mới?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = dgvLopMoi.RowCount - 1; i >= 0; i--)
                {
                    try
                    {
                        if (dgvLopMoi.Rows[i].Cells[0].Value.ToString() == "True")
                            if (Xoa(dgvLopMoi, i)) count++;
                    }
                    catch { }
                }
                MessageBox.Show("Đã xóa " + count + " học sinh khỏi danh sách cập nhật lớp " +
                    cboLopMoi.Text + " năm học " + cboNamHocMoi.Text,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChuyenHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLopCu.Rows.Count; i++)
            {
                dgvLopCu.Rows[i].Cells[0].Value = true;
            }
            btnChuyen_Click(sender, e);
        }

        private void btnChuyenTuDong_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (MessageBox.Show("Chỉ có những học sinh đạt kết quả Lên lớp, Tiên tiến hoặc Giỏi mới được chuyển sang lớp mới. Bạn có muốn tiếp tục không?", "Xác nhận chuyển tự động",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = dgvLopMoi.RowCount - 1; i >= 0; i--)
                {
                    try
                    {
                        String kq = dgvLopMoi.Rows[i].Cells[3].Value.ToString();
                        if (kq == "Lên lớp" || kq == "Tiên tiến" || kq == "Giỏi")
                            if (ChuyenLop(dgvLopCu.Rows[i], dgvLopMoi))
                            {
                                Xoa(dgvLopCu, i);
                                count++;
                            }
                    }
                    catch { }
                }
                MessageBox.Show("Đã chuyển tự động " + count + " học sinh từ lớp " + cboLopCu.Text + " năm học " +
                     cboNamHocCu.Text + " sang lớp " + cboLopMoi.Text + " năm học " + cboNamHocMoi.Text,
                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkChonMoi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLopMoi.Rows.Count; i++)
            {
                dgvLopMoi.Rows[i].Cells[0].Value = chkChonMoi.Checked;
            }
        }

        private void dgvLopMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    if (dgvLopMoi.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                        chkChonMoi.Checked = false;
                }
                catch { }
            }
        }
        #endregion
    }
}
