using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class KhoanChiData
    {
        DataService m_KhoanChiData = new DataService();

        public DataTable LayDsKhoanChi(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanChiData = dS;
            return m_KhoanChiData;
        }
        public DataTable LayDsKhoanChi()
        {
            SqlCommand cmd = new SqlCommand(TruyVanChung());
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanChiData = dS;
            return m_KhoanChiData;
        }
        public DataRow ThemDongMoi()
        {
            return m_KhoanChiData.NewRow();
        }

        public void ThemKhoanChi(DataRow m_Row)
        {
            m_KhoanChiData.Rows.Add(m_Row);
        }

        public bool LuuKhoanChi()
        {
            return m_KhoanChiData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoanChi WHERE MaKC LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanChiData = dS;
            return m_KhoanChiData;
        }

        public DataTable TimTheoTen(String TenKC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoanChi WHERE TenKC LIKE '%' + @TenKC + '%'");
            cmd.Parameters.Add("TenKC", SqlDbType.NVarChar).Value = TenKC;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanChiData = dS;
            return m_KhoanChiData;
        }

        public String TruyVanChung()
        {
            return "SELECT * FROM KhoanChi";
        }

        public DataTable TimKiemKhoanChi(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE MaKC LIKE '%' + @tuKhoa + '%' " +
            "OR TenKC LIKE '%' + @tuKhoa + '%' " +
            "OR GhiChu LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanChiData = dS;
            return m_KhoanChiData;
        }
    }
}
