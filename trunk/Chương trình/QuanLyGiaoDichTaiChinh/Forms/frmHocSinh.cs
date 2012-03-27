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
    public partial class frmHocSinh : Form
    {
        #region Fields
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NgheNghiepCtrl m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl m_NgheNghiepMeCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        #endregion

        #region Constructor
        public frmHocSinh()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cboDanToc);
            m_TonGiaoCtrl.HienThiComboBox(cboTonGiao);
            m_NgheNghiepChaCtrl.HienThiComboBox(cboNgheNghiepCha);
            m_NgheNghiepMeCtrl.HienThiComboBox(cboNgheNghiepMe);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(colMaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(colMaTonGiao);
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(colMaNNghiepCha);
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(colMaNNghiepMe);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(colMaLop);
            m_HocSinhCtrl.HienThi(dgvHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtHo, txtTen, rdbNam, rdbNu, dtpNgaySinh, txtNoiSinh, txtDiaChi,cboDanToc, cboTonGiao, txtHoTenCha, cboNgheNghiepCha, txtHoTenMe, cboNgheNghiepMe);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa những học sinh đã chọn không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvHocSinh.SelectedRows)
                {
                    bindingNavigatorHocSinh.BindingSource.RemoveAt(row.Index);

                }
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
            m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT(dgvHocSinh.Rows.Count + 1);
            m_Row["Ho"] = "";
            m_Row["Ten"] = "";
            m_Row["GioiTinh"] = "Nam";
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["NoiSinh"] = "";
            m_Row["DiaChi"] = "";
            m_Row["MaDanToc"] = null;
            m_Row["MaTonGiao"] = null;
            m_Row["HoTenCha"] = "";
            m_Row["MaNNghiepCha"] = null;
            m_Row["HoTenMe"] = "";
            m_Row["MaNNghiepMe"] = null;
            m_Row["MaLop"] = null;
            m_HocSinhCtrl.ThemHocSinh(m_Row);
            bindingNavigatorHocSinh.BindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmHocSinh_Load(sender, e);
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvHocSinh.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin học sinh " + row.Cells["colMaHocSinh"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dgvHocSinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBox.Show("Tuổi học sinh " + row.Cells["colMaHocSinh"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaHocSinh") == true &&
                KiemTraTruocKhiLuu("colHo") == true &&
                KiemTraTruocKhiLuu("colTen") == true &&
                KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true &&
                KiemTraTruocKhiLuu("colMaDanToc") == true &&
                KiemTraTruocKhiLuu("colMaTonGiao") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("colNgaySinh") == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
                }
            }
        }
        #endregion

        #region DataError event
        private void dgvHocSinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
        #region Click event
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHocSinh.CurrentRow.Cells["colGioiTinh"].Value.ToString() == "Nam")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (txtMaHocSinh.Text != "" &&
                txtHo.Text != "" &&
                txtTen.Text != "" &&
                dtpNgaySinh.Value != null &&
                cboDanToc.SelectedValue != null &&
                cboTonGiao.SelectedValue != null)
            {
                if (quyDinh.KiemTraDoTuoi(dtpNgaySinh.Value) == true)
                {
                    if (cboNgheNghiepCha.SelectedValue != null)
                    {
                        m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtHo.Text, txtTen.Text, rdbNam.Checked == true ? "Nam" : "Nữ",
                            dtpNgaySinh.Value, txtNoiSinh.Text, txtDiaChi.Text, cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                            txtHoTenCha.Text, cboNgheNghiepCha.SelectedValue.ToString(), txtHoTenMe.Text, cboNgheNghiepMe.SelectedValue.ToString());
                        m_HocSinhCtrl.HienThi(dgvHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtHo, txtTen, rdbNam, rdbNu,
                            dtpNgaySinh, txtNoiSinh, txtDiaChi, cboDanToc, cboTonGiao, txtHoTenCha, cboNgheNghiepCha, txtHoTenMe, cboNgheNghiepMe);
                    }
                    else
                    {
                        m_HocSinhCtrl.LuuHocSinh(txtMaHocSinh.Text, txtHo.Text, txtTen.Text, rdbNam.Checked == true ? "Nam" : "Nữ",
                       dtpNgaySinh.Value, txtNoiSinh.Text, txtDiaChi.Text, cboDanToc.SelectedValue.ToString(), cboTonGiao.SelectedValue.ToString(),
                       txtHoTenCha.Text, txtHoTenMe.Text);
                        m_HocSinhCtrl.HienThi(dgvHocSinh, bindingNavigatorHocSinh, txtMaHocSinh, txtHo, txtTen, rdbNam, rdbNu,
                            dtpNgaySinh, txtNoiSinh, txtDiaChi, cboDanToc, cboTonGiao, txtHoTenCha, cboNgheNghiepCha, txtHoTenMe, cboNgheNghiepMe);
                    }
                    bindingNavigatorHocSinh.BindingSource.MoveLast();
                }
                else
                    MessageBox.Show("Tuổi của học sinh " + txtHo.Text + " " + txtTen.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
