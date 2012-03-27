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
            m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi, nudDoTuoiCanTren, 
                rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
        }
        #endregion

        #region Click event
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlQuyDinh.SelectedTab == tabSiSo)
            {
                if (nudSiSoCanDuoi.Value <= 10 || nudSiSoCanTren.Value >= 60)
                    MessageBox.Show("Sĩ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if(m_QuyDinhCtrl.CapNhatQuyDinhSiSo((int)nudSiSoCanDuoi.Value, (int)nudSiSoCanTren.Value) == 0)
                        MessageBox.Show("Cập nhật thành công quy định về sĩ số!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi, 
                        nudDoTuoiCanTren, rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlQuyDinh.SelectedTab == tabDoTuoi)
            {
                if (nudDoTuoiCanDuoi.Value <= 10 || nudDoTuoiCanTren.Value >= 30)
                    MessageBox.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 30!", "ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if(m_QuyDinhCtrl.CapNhatQuyDinhDoTuoi((int)nudDoTuoiCanDuoi.Value, (int)nudDoTuoiCanTren.Value) == 0)
                        MessageBox.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi,
                        nudDoTuoiCanTren, rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlQuyDinh.SelectedTab == tabThongTinTruong)
            {
                if (txtTenTruong.Text == "")
                    MessageBox.Show("Tên trường học là giá trị bắt buộc phải nhập!", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtDiaChiTruong.Text == "")
                    MessageBox.Show("Địa chỉ trường là giá trị bắt buộc phải nhập!", "ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if(m_QuyDinhCtrl.CapNhatQuyDinhTruong(txtTenTruong.Text, txtDiaChiTruong.Text)==0)
                        MessageBox.Show("Cập nhật thành công thông tin trường học!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi, 
                        nudDoTuoiCanTren, rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
                }
            }
            else if (tabControlQuyDinh.SelectedTab == tabThangDiem)
            {
                if (rdbThangDiem10.Checked == true)
                {
                    if(m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(10)==0)
                        MessageBox.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi, 
                        nudDoTuoiCanTren, rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
                }
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(100);
                    MessageBox.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(nudSiSoCanDuoi, nudSiSoCanTren, nudDoTuoiCanDuoi, 
                        nudDoTuoiCanTren, rdbThangDiem10, rdbThangDiem100, txtTenTruong, txtDiaChiTruong);
                }
            }
        }
        #endregion
    }
}
