using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class PhieuThuData
    {
        DataService m_PhieuThuData = new DataService();

        public int LuuPhieuThu(String maKH, DateTime ngayLap, DateTime ngayThu, int MaKT, Int64 SoTienThu, String ghiChu, Boolean tinhTrang)
        {
            SqlCommand cmd = new SqlCommand("dbo.Insert_PhieuThu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", maKH));
            cmd.Parameters.Add(new SqlParameter("@NgayLap", ngayLap));
            cmd.Parameters.Add(new SqlParameter("@NgayThu", ngayThu));
            cmd.Parameters.Add(new SqlParameter("@MaKT", MaKT));
            cmd.Parameters.Add(new SqlParameter("@SoTienThu", SoTienThu));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", ghiChu));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
            SqlParameter returnValue = new SqlParameter("@SoPT", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(returnValue);
            DataService dS = new DataService();
            dS.ExecuteNoneQuery(cmd);
            return Convert.ToInt32(cmd.Parameters["@SoPT"].Value.ToString());
        }

        public int CapNhatPhieuThu(int SoPT, String maKH, DateTime ngayLap, DateTime ngayThu, int MaKT, Int64 SoTienThu, String ghiChu, Boolean tinhTrang)
        {
            SqlCommand cmd = new SqlCommand("dbo.Update_PhieuThu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPT", SoPT));
            cmd.Parameters.Add(new SqlParameter("@MaKH", maKH));
            cmd.Parameters.Add(new SqlParameter("@NgayLap", ngayLap));
            cmd.Parameters.Add(new SqlParameter("@NgayThu", ngayThu));
            cmd.Parameters.Add(new SqlParameter("@MaKT", MaKT));
            cmd.Parameters.Add(new SqlParameter("@SoTienThu", SoTienThu));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", ghiChu));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        public int XacNhanPhieuThu(int SoPT)
        {
            SqlCommand cmd = new SqlCommand("dbo.XacNhan_PhieuThu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPT", SoPT));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        public int XoaPhieuThu(int SoPT)
        {
            SqlCommand cmd = new SqlCommand("dbo.Delete_PhieuThu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPT", SoPT));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        private String TruyVanChung()
        {
            return "SELECT * FROM PhieuThu ";
        }

        public DataTable TimKiemPhieuThu(String tinhTrang, String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = TruyVanChung() + "WHERE SoPT LIKE '%' + @tuKhoa + '%' " +
            "AND TinhTrang LIKE '%' + @tinhTrang + '%' ORDER BY SoPT DESC";
            cmd.Parameters.Add("tuKhoa", SqlDbType.VarChar).Value = tuKhoa;
            cmd.Parameters.Add("tinhTrang", SqlDbType.VarChar).Value = tinhTrang;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_PhieuThuData = dS;
            return m_PhieuThuData;
        }
    }
}
