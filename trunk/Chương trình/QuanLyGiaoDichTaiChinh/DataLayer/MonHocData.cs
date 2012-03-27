using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class MonHocData
    {
        DataService m_MonHocData = new DataService();

        public DataTable LayDsMonHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC");
            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        public DataTable LayDsMonHoc(String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH, PHANCONG PC WHERE MH.MaMonHoc = PC.MaMonHoc AND PC.MaLop = @lop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            
            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_MonHocData.NewRow();
        }

        public void ThemMonHoc(DataRow m_Row)
        {
            m_MonHocData.Rows.Add(m_Row);
        }

        public bool LuuMonHoc()
        {
            return m_MonHocData.ExecuteNoneQuery() > 0;
        }
    }
}
