using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class KhoanThuCtrl
    {
        KhoanThuData m_KhoanThuData = new KhoanThuData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_KhoanThuData.LayDsKhoanThu("SELECT MaKT, TenKT FROM KhoanThu");
            comboBox.DisplayMember = "TenKT";
            comboBox.ValueMember = "MaKT";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhoanThuData.LayDsKhoanThu("SELECT MaKT, TenKT FROM KhoanThu");
            cmbColumn.DisplayMember = "TenKT";
            cmbColumn.ValueMember = "MaKT";
            cmbColumn.DataPropertyName = "MaKT";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KhoanThuData.LayDsKhoanThu();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaKT,
                            TextBox txtTenKT,
                            TextBox txtGhiChu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhoanThuData.LayDsKhoanThu();

            txtMaKT.DataBindings.Clear();
            txtMaKT.DataBindings.Add("Text", bS, "MaKT");

            txtTenKT.DataBindings.Clear();
            txtTenKT.DataBindings.Add("Text", bS, "TenKT");

            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.Add("Text", bS, "GhiChu");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach khoan thu do vao report
        public static IList<KhoanThuInfo> LayDsKhoanThuForReport(String tuKhoa)
        {
            KhoanThuData m_KHData = new KhoanThuData();
            DataTable m_DT = m_KHData.TimKiemKhoanThu(tuKhoa);

            IList<KhoanThuInfo> dS = new List<KhoanThuInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KhoanThuInfo KT = new KhoanThuInfo();

                KT.MaKT = Convert.ToString(Row["MaKT"]);
                KT.TenKT = Convert.ToString(Row["TenKT"]);
                KT.GhiChu = Convert.ToString(Row["GhiChu"]);

                dS.Add(KT);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_KhoanThuData.ThemDongMoi();
        }

        public void ThemKhoanThu(DataRow m_Row)
        {
            m_KhoanThuData.ThemKhoanThu(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuKhoanThu()
        {
            return m_KhoanThuData.LuuKhoanThu();
        }
        #endregion

        #region Tìm kiem
        public void TimKiemKhoanThu(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhoanThuData.TimKiemKhoanThu(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaKT)
        {
            m_KhoanThuData.TimTheoMa(m_MaKT);
        }

        public void TimTheoTen(String m_TenKT)
        {
            m_KhoanThuData.TimTheoTen(m_TenKT);
        }
        #endregion
    }
}
