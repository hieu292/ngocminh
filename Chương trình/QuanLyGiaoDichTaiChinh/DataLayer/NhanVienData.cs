using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class NhanVienData
    {
        DataService m_NhanVienData = new DataService();

        public DataTable LayDsNhanVien(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
            return m_NhanVienData;
        }
        public DataTable LayDsNhanVien()
        {
            SqlCommand cmd = new SqlCommand(TruyVanChung());
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
            return m_NhanVienData;
        }
        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.NewRow();
        }

        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.Rows.Add(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuNhanVien(String maNV, String tenNV, DateTime ngaySinh, Boolean gioiTinh, String CMND, String diaChi, String dienThoai)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien VALUES(@maNV, @tenNV, @ngaySinh, @gioiTinh, @CMND, @diaChi, @dienThoai)");
            cmd.Parameters.Add("maNV", SqlDbType.VarChar).Value = maNV;
            cmd.Parameters.Add("tenNV", SqlDbType.NVarChar).Value = tenNV;
            cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value = ngaySinh;
            cmd.Parameters.Add("gioiTinh", SqlDbType.Bit).Value = gioiTinh;
            cmd.Parameters.Add("CMND", SqlDbType.VarChar).Value = CMND;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.VarChar).Value = dienThoai;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
        }
        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
            return m_NhanVienData;
        }

        public DataTable TimTheoTen(String tenNV)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE TenNV LIKE '%' + @tenNV + '%'");
            cmd.Parameters.Add("tenNV", SqlDbType.NVarChar).Value = tenNV;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
            return m_NhanVienData;
        }

        public String TruyVanChung()
        {
            return "SELECT * FROM NhanVien";
        }

        public DataTable TimKiemNhanVien(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE MaNV LIKE '%' + @tuKhoa + '%' " +
            "OR TenNV LIKE '%' + @tuKhoa + '%' " +
            "OR GioiTinh LIKE '%' + @tuKhoa + '%' " +
            "OR CMND LIKE '%' + @tuKhoa + '%' " +
            "OR DiaChi LIKE '%' + @tuKhoa + '%' " +
            "OR DienThoai LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NhanVienData = dS;
            return m_NhanVienData;
        }
    }
}
