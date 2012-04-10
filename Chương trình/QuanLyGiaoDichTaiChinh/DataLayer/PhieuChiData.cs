using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    class PhieuChiData
    {
        DataService m_PhieuChiData = new DataService();

        public int LuuPhieuChi(String MaNV, DateTime ngayLap, DateTime ngayChi, int MaKC, Int64 SoTienChi, String ghiChu, Boolean tinhTrang)
        {
            SqlCommand cmd = new SqlCommand("dbo.Insert_PhieuChi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@NgayLap", ngayLap));
            cmd.Parameters.Add(new SqlParameter("@NgayChi", ngayChi));
            cmd.Parameters.Add(new SqlParameter("@MaKC", MaKC));
            cmd.Parameters.Add(new SqlParameter("@SoTienChi", SoTienChi));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", ghiChu));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
            SqlParameter returnValue = new SqlParameter("@SoPC", SqlDbType.Int);
            returnValue.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(returnValue);
            DataService dS = new DataService();
            dS.ExecuteNoneQuery(cmd);
            return Convert.ToInt32(cmd.Parameters["@SoPC"].Value.ToString());
        }

        public int CapNhatPhieuChi(int SoPC, String MaNV, DateTime ngayLap, DateTime ngayChi, int MaKC, Int64 SoTienChi, String ghiChu, Boolean tinhTrang)
        {
            SqlCommand cmd = new SqlCommand("dbo.Update_PhieuChi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPC", SoPC));
            cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
            cmd.Parameters.Add(new SqlParameter("@NgayLap", ngayLap));
            cmd.Parameters.Add(new SqlParameter("@NgayChi", ngayChi));
            cmd.Parameters.Add(new SqlParameter("@MaKC", MaKC));
            cmd.Parameters.Add(new SqlParameter("@SoTienChi", SoTienChi));
            cmd.Parameters.Add(new SqlParameter("@GhiChu", ghiChu));
            cmd.Parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        public int XacNhanPhieuChi(int SoPC)
        {
            SqlCommand cmd = new SqlCommand("dbo.XacNhan_PhieuChi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPC", SoPC));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        public int XoaPhieuChi(int SoPC)
        {
            SqlCommand cmd = new SqlCommand("dbo.Delete_PhieuChi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SoPC", SoPC));
            DataService dS = new DataService();
            return dS.ExecuteNoneQuery(cmd);
        }

        private String TruyVanChung()
        {
            return "SELECT * FROM PhieuChi ";
        }

        public DataTable TimKiemPhieuChi(String tinhTrang, String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = TruyVanChung() + "WHERE SoPC LIKE '%' + @tuKhoa + '%' " +
            "AND TinhTrang LIKE '%' + @tinhTrang + '%' ORDER BY SoPC DESC";
            cmd.Parameters.Add("tuKhoa", SqlDbType.VarChar).Value = tuKhoa;
            cmd.Parameters.Add("tinhTrang", SqlDbType.VarChar).Value = tinhTrang;
            cmd.CommandText = sql;
            DataService dS = new DataService();
            dS.Load(cmd);
            m_PhieuChiData = dS;
            return m_PhieuChiData;
        }
    }
}
