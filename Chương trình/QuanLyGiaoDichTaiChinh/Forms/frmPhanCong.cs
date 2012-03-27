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
    public partial class frmPhanCong : Form
    {
        #region Fields
        PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        #endregion

        #region Constructor
        public frmPhanCong()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(colMaMonHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(colMaGiaoVien);

            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            cboNamHoc_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;

            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorPhanCong.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;
            try
            {
                BindingSource bS = (BindingSource)dgvPhanCong.DataSource;
                bS.AddNew();
                bindingNavigatorPhanCong.BindingSource.MoveLast();
            }
            catch
            {
            	
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmPhanCong_Load(sender, e);
        }

        public Boolean KiemTraTruocKhiLuu()
        {
            for (int i = 0; i < dgvPhanCong.RowCount-1; i++ )
            {
                if (dgvPhanCong.Rows[i].Cells[0].Value != null && dgvPhanCong.Rows[i].Cells[1].Value != null)
                {
                    String maMonHoc = dgvPhanCong.Rows[i].Cells[0].Value.ToString();
                    String maGiaoVien= dgvPhanCong.Rows[i].Cells[1].Value.ToString();
                    if (maMonHoc == "" || maGiaoVien == "")
                    {
                        MessageBox.Show("Giá trị của môn học tại hàng " + (int)(i+1) + "không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    for (int j = i+1; j < dgvPhanCong.RowCount; j++ )
                    {
                        String maMonHoc1 = dgvPhanCong.Rows[j].Cells[0].Value.ToString();
                        if (maMonHoc1 == "")
                        {
                            MessageBox.Show("Giá trị của môn học tại hàng " + (int)(j + 1) + "không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        if(maMonHoc == dgvPhanCong.Rows[j].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Môn tại hàng " + (int)(i + 1) + " và " + (int)(j+1) + " bị trùng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu() == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_PhanCongCtrl.XoaPhanCong(cboLop.SelectedValue.ToString());
                for (int i = 0; i < dgvPhanCong.RowCount; i++)
                {
                    m_PhanCongCtrl.LuuPhanCong(cboLop.SelectedValue.ToString(), dgvPhanCong.Rows[i].Cells[0].Value.ToString(), dgvPhanCong.Rows[i].Cells[1].Value.ToString());
                }
            }
        }
        #endregion

        #region DataError Event
        private void dgvPhanCong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region SelectedIndexChanged event
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
                cboLop_SelectedIndexChanged(sender, e);
            }
        }
        #endregion

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLop.SelectedValue != null)
                m_PhanCongCtrl.HienThi(dgvPhanCong, bindingNavigatorPhanCong, cboLop.SelectedValue.ToString());
        }
    }
}
