using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class KhachHangData
    {
        DataService m_KhachHangData = new DataService();

        public DataTable LayDsKhachHang(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
            return m_KhachHangData;
        }
        public DataTable LayDsKhachHang()
        {
            SqlCommand cmd = new SqlCommand(TruyVanChung());
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
            return m_KhachHangData;
        }
        public DataRow ThemDongMoi()
        {
            return m_KhachHangData.NewRow();
        }

        public void ThemKhachHang(DataRow m_Row)
        {
            m_KhachHangData.Rows.Add(m_Row);
        }

        public bool LuuKhachHang()
        {
            return m_KhachHangData.ExecuteNoneQuery() > 0;
        }

        public void LuuKhachHang(String maKH, String tenKH, String diaChi, String dienThoai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang VALUES(@maKH, @tenKH, @diaChi, @dienThoai)");
            cmd.Parameters.Add("maKH", SqlDbType.VarChar).Value = maKH;
            cmd.Parameters.Add("tenKH", SqlDbType.NVarChar).Value = tenKH;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.VarChar).Value = dienThoai;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
        }
        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaKH LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
            return m_KhachHangData;
        }

        public DataTable TimTheoTen(String tenKH)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE TenKH LIKE '%' + @tenKH + '%'");
            cmd.Parameters.Add("tenKH", SqlDbType.NVarChar).Value = tenKH;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
            return m_KhachHangData;
        }

        public String TruyVanChung()
        {
            return "SELECT * FROM KhachHang";
        }

        public DataTable TimKiemKhachHang(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE MaKH LIKE '%' + @tuKhoa + '%' " +
            "OR TenKH LIKE '%' + @tuKhoa + '%' " +
            "OR DiaChi LIKE '%' + @tuKhoa + '%' " +
            "OR DienThoai LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_KhachHangData = dS;
            return m_KhachHangData;
        }
    }
}
