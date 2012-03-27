using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class KhoiLopData
    {
        DataService m_KhoiLopData = new DataService();

        public DataTable LayDsKhoiLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataTable LayDsKhoiLop(String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT L.MaKhoiLop, TenKhoiLop FROM LOP L INNER JOIN KHOILOP K ON L.MaKhoiLop = K.MaKhoiLop WHERE MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.NewRow();
        }

        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.Rows.Add(m_Row);
        }

        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.ExecuteNoneQuery() > 0;
        }
    }
}
