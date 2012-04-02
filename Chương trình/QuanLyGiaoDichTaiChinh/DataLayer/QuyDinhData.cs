using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class QuyDinhData
    {
        DataService m_QuyDinhData = new DataService();

        public DataTable LayDsQuyDinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUYDINH");
            DataService dS = new DataService();
            dS.Load(cmd);
            m_QuyDinhData = dS;
            return m_QuyDinhData;
        }

        public Int64 LayTaiKhoanCo()
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 TaiKhoanCo FROM QUYDINH");

            return Convert.ToInt64(m_QuyDinhData.ExecuteScalar(cmd));
        }

        public int CapNhatTaiKhoanCo(Int64 taiKhoanCo)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TaiKhoanCo = TaiKhoanCo + @taiKhoanCo");
            cmd.Parameters.Add("taiKhoanCo", SqlDbType.BigInt).Value = taiKhoanCo;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatThongTinSaoLuu(int lichSaoLuu, String viTriSaoLuu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET LichSaoLuu = @lichSaoLuu, ThoiDiemSaoLuuTiepTheo = dateadd(dd, @lichSaoLuu, getdate()), viTriSaoLuu = @viTriSaoLuu");
            cmd.Parameters.Add("lichSaoLuu", SqlDbType.Int).Value = lichSaoLuu;
            cmd.Parameters.Add("viTriSaoLuu", SqlDbType.VarChar).Value = viTriSaoLuu;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatThongTinCongTy(String tenTenCongTy, String diaChi, String dienThoai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TenCongTy = @tenCongTy, DiaChi = @diaChi, DienThoai = @dienThoai");
            cmd.Parameters.Add("tenCongTy", SqlDbType.NVarChar).Value       = tenTenCongTy;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value    = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.NVarChar).Value = dienThoai;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatTimKiemTuDong(Boolean timKiemTuDong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TimKiemTuDong= @timKiemTuDong");
            cmd.Parameters.Add("timKiemTuDong", SqlDbType.Bit).Value = timKiemTuDong;

            return m_QuyDinhData.Load(cmd);
        }
    }
}
