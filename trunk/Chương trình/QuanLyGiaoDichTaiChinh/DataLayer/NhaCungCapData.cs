using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class NhaCungCapData
    {
        DataService m_NhaCungCapData = new DataService();

        public DataTable LayDsNhaCungCap(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
            return m_NhaCungCapData;
        }
        public DataTable LayDsNhaCungCap()
        {
            SqlCommand cmd = new SqlCommand(TruyVanChung());
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
            return m_NhaCungCapData;
        }
        public DataRow ThemDongMoi()
        {
            return m_NhaCungCapData.NewRow();
        }

        public void ThemNhaCungCap(DataRow m_Row)
        {
            m_NhaCungCapData.Rows.Add(m_Row);
        }

        public bool LuuNhaCungCap()
        {
            return m_NhaCungCapData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhaCungCap(String maNCC, String tenNCC, String diaChi, String dienThoai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NhaCungCap VALUES(@maNCC, @tenNCC, @diaChi, @dienThoai)");
            cmd.Parameters.Add("maNCC", SqlDbType.VarChar).Value = maNCC;
            cmd.Parameters.Add("tenNCC", SqlDbType.NVarChar).Value = tenNCC;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.VarChar).Value = dienThoai;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
        }
        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE MaNCC LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
            return m_NhaCungCapData;
        }

        public DataTable TimTheoTen(String tenNCC)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhaCungCap WHERE TenNCC LIKE '%' + @tenNCC + '%'");
            cmd.Parameters.Add("tenNCC", SqlDbType.NVarChar).Value = tenNCC;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
            return m_NhaCungCapData;
        }

        public String TruyVanChung()
        {
            return "SELECT * FROM NhaCungCap";
        }

        public DataTable TimKiemNhaCungCap(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE MaNCC LIKE '%' + @tuKhoa + '%' " +
            "OR TenNCC LIKE '%' + @tuKhoa + '%' " +
            "OR DiaChi LIKE '%' + @tuKhoa + '%' " +
            "OR DienThoai LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhaCungCapData = dS;
            return m_NhaCungCapData;
        }
    }
}
