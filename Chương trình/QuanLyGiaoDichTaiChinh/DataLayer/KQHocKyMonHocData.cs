using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class KQHocKyMonHocData
    {
        DataService m_KQHocKyMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc, float diemTBKTMieng, float diemTBKT15Phut, float diemTBKT1Tiet, float diemHocKy, float diemTBMonHK)
        {
            DataService m_KQHKMHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_HOC_KY_MON_HOC VALUES(@maHocSinh, @maLop, @maMonHoc, @maHocKy, @maNamHoc, @diemTBKTMieng, @diemTBKT15Phut, @diemTBKT1Tiet, @diemHocKy, @diemTBMonHK)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value      = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("diemTBKTMieng", SqlDbType.Float).Value  = Math.Round(diemTBKTMieng, 1);
            cmd.Parameters.Add("diemTBKT15Phut", SqlDbType.Float).Value = Math.Round(diemTBKT15Phut, 1);
            cmd.Parameters.Add("diemTBKT1Tiet", SqlDbType.Float).Value  = Math.Round(diemTBKT1Tiet, 1);
            cmd.Parameters.Add("diemHocKy", SqlDbType.Float).Value      = Math.Round(diemHocKy, 1);
            cmd.Parameters.Add("diemTBMonHK", SqlDbType.Float).Value    = Math.Round(diemTBMonHK, 1);

            m_KQHKMHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            DataService m_KQHKMHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_HOC_KY_MON_HOC WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaMonHoc = @maMonHoc AND MaHocKy = @maHocKy AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value      = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQHKMHData.Load(cmd);
        }

        public DataTable LayDsKQHocKyMonHocForReport(String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, Ho, Ten, KQ.MaLop, TenLop, KQ.MaHocKy, KQ.MaNamHoc, TenNamHoc, KQ.MaMonHoc, TenMonHoc, KQ.MaHocKy, TenHocKy, " +
"KQ.DTBKiemTraMieng, KQ.DTBKiemTra15Phut, " +
"KQ.DTBKiemTra1Tiet, KQ.DiemHocKy, KQ.DTBMonHocKy, " +
"DENSE_RANK() OVER (ORDER BY DTBMonHocKy DESC) AS XepThu " +
"FROM HOCSINH HS INNER JOIN KQ_HOC_KY_MON_HOC KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
"INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
"INNER JOIN MONHOC MH ON KQ.MaMonHoc = MH.MaMonHoc " +
"INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy " +
"INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
"WHERE KQ.MaLop = @maLop AND " +
"KQ.MaMonHoc = @maMonHoc AND " +
"KQ.MaHocKy = @maHocKy AND " +
"KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value    = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value  = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyMonHocData.Load(cmd);
            return m_KQHocKyMonHocData;
        }
        public DataTable LayDsKQHocKyHocSinhForReport(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, Ho, Ten, KQ.MaLop, TenLop, KQ.MaHocKy, KQ.MaNamHoc, TenNamHoc, KQ.MaMonHoc, TenMonHoc, KQ.MaHocKy, TenHocKy, " +
"KQ.DTBKiemTraMieng, KQ.DTBKiemTra15Phut, " +
"KQ.DTBKiemTra1Tiet, KQ.DiemHocKy, KQ.DTBMonHocKy, " +
"DENSE_RANK() OVER (ORDER BY DTBMonHocKy DESC) AS XepThu " +
"FROM HOCSINH HS INNER JOIN KQ_HOC_KY_MON_HOC KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
"INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
"INNER JOIN MONHOC MH ON KQ.MaMonHoc = MH.MaMonHoc " +
"INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy " +
"INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
"WHERE KQ.MaLop = @maLop AND " +
"KQ.MaHocSinh = @maHocSinh AND " +
"KQ.MaHocKy = @maHocKy AND " +
"KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyMonHocData.Load(cmd);
            return m_KQHocKyMonHocData;
        }
    }
}
