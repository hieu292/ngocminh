using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class NhaCungCapCtrl
    {
        NhaCungCapData m_NhaCungCapData = new NhaCungCapData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_NhaCungCapData.LayDsNhaCungCap("SELECT MaNCC, TenNCC FROM NhaCungCap");
            comboBox.DisplayMember = "TenNCC";
            comboBox.ValueMember = "MaNCC";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhaCungCapData.LayDsNhaCungCap("SELECT MaNCC, TenNCC FROM NhaCungCap");
            cmbColumn.DisplayMember = "TenNCC";
            cmbColumn.ValueMember = "MaNCC";
            cmbColumn.DataPropertyName = "MaNCC";
            //cmbColumn.HeaderText = "Giáo viên";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NhaCungCapData.LayDsNhaCungCap();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaNCC,
                            TextBox txtTenNCC,
                            TextBox txtDiaChi,
                            TextBox txtDienThoai)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhaCungCapData.LayDsNhaCungCap();

            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", bS, "MaNCC");

            txtTenNCC.DataBindings.Clear();
            txtTenNCC.DataBindings.Add("Text", bS, "TenNCC");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach giao vien do vao report
        public static IList<NhaCungCapInfo> LayDsNhaCungCapForReport(String tuKhoa)
        {
            NhaCungCapData m_NCCData = new NhaCungCapData();
            DataTable m_DT = m_NCCData.TimKiemNhaCungCap(tuKhoa);

            IList<NhaCungCapInfo> dS = new List<NhaCungCapInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                NhaCungCapInfo NCC = new NhaCungCapInfo();

                NCC.MaNCC = Convert.ToString(Row["MaNCC"]);
                NCC.TenNCC = Convert.ToString(Row["TenNCC"]);
                NCC.DiaChi = Convert.ToString(Row["DiaChi"]);
                NCC.DienThoai = Convert.ToString(Row["DienThoai"]);

                dS.Add(NCC);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhaCungCapData.ThemDongMoi();
        }


        public void ThemNhaCungCap(DataRow m_Row)
        {
            m_NhaCungCapData.ThemNhaCungCap(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNhaCungCap()
        {
            return m_NhaCungCapData.LuuNhaCungCap();
        }

        public void LuuNhaCungCap(String maNCC, String tenNCC, String diaChi, String dienThoai)
        {
            m_NhaCungCapData.LuuNhaCungCap(maNCC, tenNCC, diaChi, dienThoai);
        }
        #endregion

        #region Tìm kiem
        public void TimKiemNhaCungCap(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhaCungCapData.TimKiemNhaCungCap(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaNCC)
        {
            m_NhaCungCapData.TimTheoMa(m_MaNCC);
        }

        public void TimTheoTen(String m_TenNCC)
        {
            m_NhaCungCapData.TimTheoTen(m_TenNCC);
        }
        #endregion
    }
}
