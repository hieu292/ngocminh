using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class KhachHangCtrl
    {
        KhachHangData m_KhachHangData = new KhachHangData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_KhachHangData.LayDsKhachHang("SELECT MaKH, TenKH FROM KhachHang");
            comboBox.DisplayMember = "TenKH";
            comboBox.ValueMember = "MaKH";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KhachHangData.LayDsKhachHang("SELECT MaKH, TenKH FROM KhachHang");
            cmbColumn.DisplayMember = "TenKH";
            cmbColumn.ValueMember = "MaKH";
            cmbColumn.DataPropertyName = "MaKH";
            //cmbColumn.HeaderText = "Giáo viên";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KhachHangData.LayDsKhachHang();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaKH,
                            TextBox txtTenKH,
                            TextBox txtDiaChi,
                            TextBox txtDienThoai)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhachHangData.LayDsKhachHang();

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", bS, "MaKH");

            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", bS, "TenKH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach giao vien do vao report
        public static IList<KhachHangInfo> LayDsKhachHangForReport(String tuKhoa)
        {
            KhachHangData m_KHData = new KhachHangData();
            DataTable m_DT = m_KHData.TimKiemKhachHang(tuKhoa);

            IList<KhachHangInfo> dS = new List<KhachHangInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KhachHangInfo KH = new KhachHangInfo();

                KH.MaKH = Convert.ToString(Row["MaKH"]);
                KH.TenKH = Convert.ToString(Row["TenKH"]);
                KH.DiaChi = Convert.ToString(Row["DiaChi"]);
                KH.DienThoai = Convert.ToString(Row["DienThoai"]);

                dS.Add(KH);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.ThemDongMoi();
        }


        public void ThemKhachHang(DataRow m_Row)
        {
            m_KhachHangData.ThemKhachHang(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuKhachHang()
        {
            return m_KhachHangData.LuuKhachHang();
        }

        public void LuuKhachHang(String maKH, String tenKH, String diaChi, String dienThoai)
        {
            m_KhachHangData.LuuKhachHang(maKH, tenKH, diaChi, dienThoai);
        }
        #endregion

        #region Tìm kiem
        public void TimKiemKhachHang(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_KhachHangData.TimKiemKhachHang(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void TimTheoMa(String m_MaKH)
        {
            m_KhachHangData.TimTheoMa(m_MaKH);
        }

        public void TimTheoTen(String m_TenKH)
        {
            m_KhachHangData.TimTheoTen(m_TenKH);
        }
        #endregion
    }
}
