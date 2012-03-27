using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class PhanCongData
    {
        DataService m_PhanCongData = new DataService();

        public DataTable LayDsPhanCong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHANCONG");
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataTable LayDsPhanCong(String maLop)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.MaMonHoc, P.MaGiaoVien " +
                "FROM PHANCONG P, LOP L WHERE P.MaLop = L.MaLop AND P.MaLop = @maLop");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataTable LayGiaoVienBoMon(String maLop, String maMonHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.MaGiaoVien, GV.Ho, GV.Ten " +
                "FROM PHANCONG P, GIAOVIEN GV WHERE P.MaLop = @maLop AND P.MaMonHoc = @maMonHoc AND P.MaGiaoVien = GV.MaGiaoVien");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }
        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.NewRow();
        }

        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.Rows.Add(m_Row);
        }

        public bool LuuPhanCong()
        {
            return m_PhanCongData.ExecuteNoneQuery() > 0;
        }

        public void XoaPhanCong(String maLop)
        {
            DataService m_PCData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM PHANCONG WHERE MaLop = @maLop");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

            m_PCData.Load(cmd);
        }
        public void LuuPhanCong(String maLop, String maMonHoc, String maGiaoVien)
        {
            DataService m_PCData = new DataService();
            SqlCommand cmd = new SqlCommand("INSERT INTO PHANCONG VALUES(@maLop, @maMonHoc, @maGiaoVien)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value   = maGiaoVien;

            m_PCData.Load(cmd);
        }

        public DataTable TimTheoTenLop(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.MaLop, P.MaMonHoc, P.MaGiaoVien FROM PHANCONG P, LOP L WHERE P.MaLop = L.MaLop AND L.TenLop LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataTable TimTheoTenGV(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.MaLop, P.MaMonHoc, P.MaGiaoVien FROM PHANCONG P, GIAOVIEN G WHERE P.MaGiaoVien = G.MaGiaoVien AND G.TenGiaoVien LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }
    }
}
