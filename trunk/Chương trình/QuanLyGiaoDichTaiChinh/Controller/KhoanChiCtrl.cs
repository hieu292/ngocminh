using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class KhoanChiCtrl
    {
        KhoanChiData m_KhoanChiData = new KhoanChiData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_KhoanChiData.LayDsKhoanChi("SELECT MaKC, TenKC FROM KhoanChi");
            comboBox.DisplayMember = "TenKC";
            comboBox.ValueMember = "MaKC";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhoanChiData.LayDsKhoanChi("SELECT MaKC, TenKC FROM KhoanChi");
            cmbColumn.DisplayMember = "TenKC";
            cmbColumn.ValueMember = "MaKC";
            cmbColumn.DataPropertyName = "MaKC";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KhoanChiData.LayDsKhoanChi();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaKC,
                            TextBox txtTenKC,
                            TextBox txtGhiChu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhoanChiData.LayDsKhoanChi();

            txtMaKC.DataBindings.Clear();
            txtMaKC.DataBindings.Add("Text", bS, "MaKC");

            txtTenKC.DataBindings.Clear();
            txtTenKC.DataBindings.Add("Text", bS, "TenKC");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bS, "GhiChu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach khoan chi do vao report
        public static IList<KhoanChiInfo> LayDsKhoanChiForReport(String tuKhoa)
        {
            KhoanChiData m_KHData = new KhoanChiData();
            DataTable m_DT = m_KHData.TimKiemKhoanChi(tuKhoa);

            IList<KhoanChiInfo> dS = new List<KhoanChiInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KhoanChiInfo KT = new KhoanChiInfo();

                KT.MaKC = Convert.ToString(Row["MaKC"]);
                KT.TenKC = Convert.ToString(Row["TenKC"]);
                KT.GhiChu = Convert.ToString(Row["GhiChu"]);

                dS.Add(KT);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_KhoanChiData.ThemDongMoi();
        }

        public void ThemKhoanChi(DataRow m_Row)
        {
            m_KhoanChiData.ThemKhoanChi(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuKhoanChi()
        {
            return m_KhoanChiData.LuuKhoanChi();
        }
        #endregion

        #region Tìm kiem
        public void TimKiemKhoanChi(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhoanChiData.TimKiemKhoanChi(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaKC)
        {
            m_KhoanChiData.TimTheoMa(m_MaKC);
        }

        public void TimTheoTen(String m_TenKC)
        {
            m_KhoanChiData.TimTheoTen(m_TenKC);
        }
        #endregion
    }
}
