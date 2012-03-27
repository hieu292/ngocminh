using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class PhanCongCtrl
    {
        PhanCongData m_PhanCongData = new PhanCongData();

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_PhanCongData.LayDsPhanCong();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            String maLop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PhanCongData.LayDsPhanCong(maLop);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public String LayHoTenGiaoVienBoMon(String maLop, String maMonHoc)
        {
            DataTable dt = m_PhanCongData.LayGiaoVienBoMon(maLop,maMonHoc);
            return dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
        }
        #endregion
        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.ThemDongMoi();
        }
        
        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.ThemPhanCong(m_Row);
        }
        #endregion

        #region Xoa phan cong
        public void XoaPhanCong(string maLop)
        {
            m_PhanCongData.XoaPhanCong(maLop);
        }

        #endregion
        #region Luu du lieu
        public bool LuuPhanCong()
        {
            return m_PhanCongData.LuuPhanCong();
        }

        public void LuuPhanCong(String maLop, String maMonHoc, String maGiaoVien)
        {
            m_PhanCongData.LuuPhanCong(maLop, maMonHoc, maGiaoVien);
        }
        #endregion

        #region Tìm kiem
        public void TimTheoTenLop(String m_TenLop)
        {
            m_PhanCongData.TimTheoTenLop(m_TenLop);
        }

        public void TimTheoTenGV(String m_TenGiaoVien)
        {
            m_PhanCongData.TimTheoTenGV(m_TenGiaoVien);
        }
        #endregion
    }
}
