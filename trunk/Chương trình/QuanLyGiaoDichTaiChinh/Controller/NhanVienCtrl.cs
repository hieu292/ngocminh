using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class NhanVienCtrl
    {
        NhanVienData m_NhanVienData = new NhanVienData();
        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_NhanVienData.LayDsNhanVien("SELECT MaNV, TenNV FROM NhanVien");
            comboBox.DisplayMember = "TenNV";
            comboBox.ValueMember = "MaNV";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NhanVienData.LayDsNhanVien("SELECT MaNV, TenNV FROM NhanVien");
            cmbColumn.DisplayMember = "TenNV";
            cmbColumn.ValueMember = "MaNV";
            cmbColumn.DataPropertyName = "MaNV";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NhanVienData.LayDsNhanVien();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaNV,
                            TextBox txtTenNV,
                            DateTimePicker dtpNgaySinh,
                            CheckBox chkGioiTinh,
                            TextBox txtCMND,
                            TextBox txtDiaChi,
                            TextBox txtDienThoai)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.LayDsNhanVien();

            chkGioiTinh.DataBindings.Clear();
            chkGioiTinh.DataBindings.Add("Checked", bS, "GioiTinh");

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", bS, "MaNV");

            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", bS, "TenNV");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", bS, "CMND");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach giao vien do vao report
        public static IList<NhanVienInfo> LayDsNhanVienForReport(String tuKhoa)
        {
            NhanVienData m_NVData = new NhanVienData();
            DataTable m_DT = m_NVData.TimKiemNhanVien(tuKhoa);

            IList<NhanVienInfo> dS = new List<NhanVienInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                NhanVienInfo NV = new NhanVienInfo();

                NV.MaNV = Convert.ToString(Row["MaNV"]);
                NV.TenNV = Convert.ToString(Row["TenNV"]);
                NV.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                NV.GioiTinh = Row["GioiTinh"].ToString() == "0"?"Nam":"Nữ";
                NV.CMND = Convert.ToString(Row["CMND"]);
                NV.DiaChi = Convert.ToString(Row["DiaChi"]);
                NV.DienThoai = Convert.ToString(Row["DienThoai"]);

                dS.Add(NV);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.ThemDongMoi();
        }


        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.ThemNhanVien(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNhanVien()
        {
            return m_NhanVienData.LuuNhanVien();
        }

        public void LuuNhanVien(String maNV, String tenNV, DateTime ngaySinh, Boolean gioiTinh, String CMND, String diaChi, String dienThoai)
        {
            m_NhanVienData.LuuNhanVien(maNV, tenNV, ngaySinh, gioiTinh, CMND, diaChi, dienThoai);
        }
        #endregion

        #region Tìm kiem
        public void TimKiemNhanVien(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NhanVienData.TimKiemNhanVien(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaNV)
        {
            m_NhanVienData.TimTheoMa(m_MaNV);
        }

        public void TimTheoTen(String m_TenNV)
        {
            m_NhanVienData.TimTheoTen(m_TenNV);
        }
        #endregion
    }
}
