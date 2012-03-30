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
    public partial class frmQuyDinh : Form
    {
        #region Field
        QuyDinhCtrl m_QuyDinhCtrl = new QuyDinhCtrl();
        #endregion
        #region Constructor
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        #endregion
        #region Load
        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            m_QuyDinhCtrl.HienThi(txtTenCongTy, txtDiaChi,txtDienThoai,lblTaiKhoanCo,
                nudLichSaoLuu,txtViTriSaoLuu,lblThoiDiemSaoLuu,rdbBat,rdbTat);
        }
        #endregion

        #region Click event
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlQuyDinh.SelectedTab == tabCongTy)
            {
                if(m_QuyDinhCtrl.CapNhatThongTinCongTy(txtTenCongTy.Text, txtDiaChi.Text,txtDienThoai.Text) == 0)
                    MessageBox.Show("Cập nhật thành công quy định về thông tin công ty!", "COMPLETED",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frmQuyDinh_Load(sender, e);
            }
            else if (tabControlQuyDinh.SelectedTab == tabSaoLuu)
            {
                if (m_QuyDinhCtrl.CapNhatThongTinSaoLuu((int)nudLichSaoLuu.Value, txtViTriSaoLuu.Text) == 0)
                    MessageBox.Show("Cập nhật thành công quy định về sao lưu!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuyDinh_Load(sender, e);
            }
            else
            {
                if (m_QuyDinhCtrl.CapNhatTimKiemTuDong(rdbBat.Checked) == 0)
                    MessageBox.Show("Cập nhật thành công quy định về tìm kiếm tự động!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                //frmQuyDinh_Load(sender, e);
            }
        }
        #endregion

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.SelectedPath = txtViTriSaoLuu.Text;
            fbd.Description = "Chọn thư mục mặc định để lưu tệp sao lưu";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtViTriSaoLuu.Text = fbd.SelectedPath;
            }
        }
    }
}
