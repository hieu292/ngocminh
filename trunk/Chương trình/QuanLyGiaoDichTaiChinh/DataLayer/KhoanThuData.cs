using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class KhoanThuData
    {
        DataService m_KhoanThuData = new DataService();

        public DataTable LayDsKhoanThu(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanThuData = dS;
            return m_KhoanThuData;
        }
        public DataTable LayDsKhoanThu()
        {
            SqlCommand cmd = new SqlCommand(TruyVanChung());
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhoanThuData = dS;
            return m_KhoanThuData;
        }
        public DataRow ThemDongMoi()
        {
            return m_KhoanThuData.NewRow();
        }

        public void ThemKhoanThu(DataRow m_Row)
        {
            m_KhoanThuData.Rows.Add(m_Row);
        }

        public bool LuuKhoanThu()
        {
            return m_KhoanThuData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoanThu WHERE MaKT LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_KhoanThuData.Load(cmd);
            return m_KhoanThuData;
        }

        public DataTable TimTheoTen(String tenKT)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoanThu WHERE TenKT LIKE '%' + @tenKT + '%'");
            cmd.Parameters.Add("tenKT", SqlDbType.NVarChar).Value = tenKT;

            m_KhoanThuData.Load(cmd);
            return m_KhoanThuData;
        }

        public String TruyVanChung()
        {
            return "SELECT * FROM KhoanThu";
        }

        public DataTable TimKiemKhoanThu(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE MaKT LIKE '%' + @tuKhoa + '%' " +
            "OR TenKT LIKE '%' + @tuKhoa + '%' " +
            "OR GhiChu LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            m_KhoanThuData.Load(cmd);
            return m_KhoanThuData;
        }
    }
}
