using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class NguoiDungCtrl
    {
        NguoiDungData m_NguoiDungData = new NguoiDungData();
        NguoiDungInfo m_NguoiDungInfo = new NguoiDungInfo();
        LoaiNguoiDungInfo m_LoaiNguoiDungInfo = new LoaiNguoiDungInfo();

        #region Lay row
        public DataRow FindRow(int maNguoiDung)
        {
            return m_NguoiDungData.FindRow(maNguoiDung);
        }
        #endregion

        public Boolean isDuplicate(String tenDangNhap)
        {
            return m_NguoiDungData.isDuplicate(tenDangNhap);
        }

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_NguoiDungData.LayDsNguoiDung();
            comboBox.DisplayMember = "TenND";
            comboBox.ValueMember = "MaND";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NguoiDungData.LayDsNguoiDung();
            cmbColumn.DisplayMember = "TenND";
            cmbColumn.ValueMember = "MaND";
            cmbColumn.DataPropertyName = "MaND";
            cmbColumn.HeaderText = "Người dùng";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NguoiDungData.LayDsNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.ThemDongMoi();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.ThemNguoiDung(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.LuuNguoiDung();
        }
        #endregion

        #region Dang nhap
        public int DangNhap(string m_Username, string m_Password)
        {
            DataTable m_DT = m_NguoiDungData.LayDsNguoiDung(m_Username);

            if (m_DT.Rows.Count == 0)
                return 0;

            String m_SysPass = m_DT.Rows[0]["MatKhau"].ToString();
            if (m_SysPass != Utilities.Encrypt(m_Password,true))
                return 1;
            else
            {
                m_NguoiDungInfo.MaNguoiDung = m_DT.Rows[0]["MaNguoiDung"].ToString();
                m_NguoiDungInfo.TenDangNhap    = m_DT.Rows[0]["TenDangNhap"].ToString();
                m_NguoiDungInfo.TenNguoiDung       = m_DT.Rows[0]["TenNguoiDung"].ToString();
                m_LoaiNguoiDungInfo.MaLoai  = m_DT.Rows[0]["MaLoaiNguoiDung"].ToString();
                m_NguoiDungInfo.MatKhau = m_SysPass;
                m_NguoiDungInfo.LoaiNguoiDung = m_LoaiNguoiDungInfo;
                Utilities.NguoiDung = m_NguoiDungInfo;
                return 2;
            }
        }
        #endregion

        #region Doi mat khau
        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.DoiMatKhau(userName, Utilities.Encrypt(newPassword, true));
        }
        #endregion
    }
}
