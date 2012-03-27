using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class LopData
    {
        DataService m_LopData = new DataService();

        public DataTable LayDsLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP");
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String khoiLop, String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaKhoiLop = @khoiLop AND MaNamHoc = @namHoc");
            cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value = khoiLop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayGiaoVienChuNhiem(String maLop)
        {
            SqlCommand cmd = new SqlCommand("SELECT L.MaGiaoVien, GV.Ho, GV.Ten, FROM LOP L, GIAOVIEN GV WHERE L.MaLop = @maLop AND L.MaGiaoVien = GV.MaGiaoVien");
            cmd.Parameters.Add("@maLop", SqlDbType.VarChar).Value = maLop;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLopForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN GV INNER JOIN LOP L ON L.MaGiaoVien = GV.MaGiaoVien INNER JOIN KHOILOP KL ON L.MaKhoiLop = KL.MaKhoiLop INNER JOIN NAMHOC NH ON L.MaNamHoc = NH.MaNamHoc");
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLopForReport(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN GV INNER JOIN LOP L ON L.MaGiaoVien = GV.MaGiaoVien INNER JOIN KHOILOP KL ON L.MaKhoiLop = KL.MaKhoiLop INNER JOIN NAMHOC NH ON L.MaNamHoc = NH.MaNamHoc WHERE L.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public String TruyVanChung()
        {
            return "SELECT L.MaLop, L.TenLop, L.MaKhoiLop, K.TenKhoiLop, L.MaNamHoc, N.TenNamHoc, L.SiSo, G.Ho, G.Ten, G.Ho + ' ' + G.Ten AS HoTenGV FROM LOP L INNER JOIN GIAOVIEN G ON L.MaGiaoVien = G.MaGiaoVien INNER JOIN NAMHOC N ON L.MaNamHoc = N.MaNamHoc INNER JOIN KHOILOP K ON L.MaKhoiLop = K.MaKhoiLop ";
        }

        public DataTable TimKiemLop(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE L.MaLop LIKE '%' + @tuKhoa + '%' " +
            "OR L.TenLop LIKE '%' + @tuKhoa + '%' " +
            "OR K.TenKhoiLop LIKE '%' + @tuKhoa + '%' " +
            "OR N.TenNamHoc LIKE '%' + @tuKhoa + '%' " +
            "OR G.Ho + ' ' + G.Ten LIKE '%' + @tuKhoa + '%' " +
            "OR L.SiSo LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            m_LopData.Load(cmd);
            return m_LopData;
        }
        public DataRow ThemDongMoi()
        {
            return m_LopData.NewRow();
        }

        public void ThemLop(DataRow m_Row)
        {
            m_LopData.Rows.Add(m_Row);
        }

        public bool LuuLop()
        {
            return m_LopData.ExecuteNoneQuery() > 0;
        }

        public void LuuLop(String maLop, String tenLop, String maKhoiLop, String maNamHoc, int siSo, String maGiaoVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LOP VALUES(@maLop, @tenLop, @maKhoiLop, @maNamHoc, @siSo, @maGiaoVien)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("tenLop", SqlDbType.NVarChar).Value      = tenLop;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value    = maKhoiLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("siSo", SqlDbType.Int).Value             = siSo;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value   = maGiaoVien;

            m_LopData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaLop LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE TenLop LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_LopData.Load(cmd);
            return m_LopData;
        }
    }
}
