using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyGiaoDichTaiChinh.Controller;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class KQHocKyTongHopData
    {
        DataService m_KQHocKyTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc,float diemTBChungCacMonHK, String maHocLuc, String maHanhKiem, String maKetQua)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_HOC_KY_TONG_HOP VALUES(@maHocSinh, @maLop, @maHocKy, @maNamHoc, @maHocLuc, @maHanhKiem, @diemTBChungCacMonHK, @maKetQua)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value            = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value                = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value              = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value             = maNamHoc;
            cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value             = maHocLuc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value           = maHanhKiem;
            cmd.Parameters.Add("diemTBChungCacMonHK", SqlDbType.Float).Value    = Math.Round(diemTBChungCacMonHK, 1);
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value             = maKetQua;

            m_KQHKTHData.Load(cmd);
        }

        public void CapNhatKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc, String maHanhKiem, String maKetQua)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE KQ_HOC_KY_TONG_HOP SET MaHanhKiem = @maHanhKiem, MaKetQua = @maKetQua " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaHocKy = @maHocKy AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value = maHanhKiem;
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value = maKetQua;
            m_KQHKTHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_HOC_KY_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaHocKy = @maHocKy AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value      = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQHKTHData.Load(cmd);
        }

        public DataTable LayKQHocKyTongHop(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            //Console.WriteLine(maHocSinh + ";" + maLop + ";" + maHocKy + ";" + maNamHoc);
            SqlCommand cmd = new SqlCommand("SELECT * FROM KQ_HOC_KY_TONG_HOP " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaHocKy = @maHocKy AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyTongHopData.Load(cmd);
            return m_KQHocKyTongHopData;
        }

        public DataTable LayDsKQHocKyTongHop(String maLop, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, HS.Ho, HS.Ten, HKIEM.MaHanhKiem " +
                                            "FROM HOCSINH HS INNER JOIN KQ_HOC_KY_TONG_HOP KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN HANHKIEM HKIEM ON KQ.MaHanhKiem = HKIEM.MaHanhKiem " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaHocKy = @maHocKy AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyTongHopData.Load(cmd);
            return m_KQHocKyTongHopData;
        }


        public DataTable LayDsKQHocKyTongHopForReport(String maLop, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, Ho, Ten, KQ.MaNamHoc, TenNamHoc, KQ.MaLop, TenLop, KQ.MaHocKy, TenHocKy, " +
                                            "KQ.MaHocLuc, TenHocLuc, KQ.MaHanhKiem, TenHanhKiem, KQ.MaKetQua, TenKetQua, DTBMonHocKy, " +
                                            "DENSE_RANK() OVER (ORDER BY DTBMonHocKy DESC) AS XepThu " +
                                            "FROM KQ_HOC_KY_TONG_HOP KQ INNER JOIN HOCSINH HS ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
                                            "INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy " +
                                            "INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
                                            "INNER JOIN HOCLUC HL ON KQ.MaHocLuc = HL.MaHocLuc " +
                                            "INNER JOIN HANHKIEM HKIEM ON KQ.MaHanhKiem = HKIEM.MaHanhKiem " +
                                            "INNER JOIN KETQUA KQUA ON KQ.MaKetQua = KQUA.MaKetQua " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaHocKy = @maHocKy AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value    = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value  = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyTongHopData.Load(cmd);
            return m_KQHocKyTongHopData;
        }
    }
}
