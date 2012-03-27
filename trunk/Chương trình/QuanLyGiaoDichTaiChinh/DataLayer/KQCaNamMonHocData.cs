using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class KQCaNamMonHocData
    {
        DataService m_KQCaNamMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai, float diemTBMonCN)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_MON_HOC VALUES(@maHocSinh, @maLop, @maMonHoc, @maNamHoc, @diemThiLai, @diemTBMonCN)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("diemThiLai", SqlDbType.Float).Value     = Math.Round(diemThiLai, 1);
            cmd.Parameters.Add("diemTBMonCN", SqlDbType.Float).Value    = Math.Round(diemTBMonCN, 1);

            m_KQCNMHData.Load(cmd);
        }

        public void CapNhatDiemThiLai(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE KQ_CA_NAM_MON_HOC SET DiemThiLai = @diemThiLai " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaMonHoc = @maMonHoc AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("diemThiLai", SqlDbType.Float).Value = Math.Round(diemThiLai,1);

            m_KQHKTHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_MON_HOC WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaMonHoc = @maMonHoc AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQCNMHData.Load(cmd);
        }

        public DataTable LayKQCaNamMonHoc(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM KQ_CA_NAM_MON_HOC " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaMonHoc = @maMonHoc AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }

        public DataTable LayDsKQCaNamMonHoc(String maLop, String maMonHoc, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, Ho, Ten, DiemThiLai, DTBCaNam " +
                                           "FROM HOCSINH HS INNER JOIN KQ_CA_NAM_MON_HOC KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                           "WHERE KQ.MaLop = @maLop AND " +
                                           "KQ.MaMonHoc = @maMonHoc AND " +
                                           "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }

        public DataTable LayDsKQCaNamMonHocForReport(String maLop, String maMonHoc, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand(
"select KQHK1.MaHocSinh, Ho, Ten, KQHK1.MaLop, TenLop, KQHK1.MaHocKy, KQHK1.MaNamHoc, TenNamHoc, KQHK1.MaMonHoc, TenMonHoc, " +
"KQHK1.DTBKiemTraMieng as DTBKiemTraMieng1, KQHK1.DTBKiemTra15Phut as DTBKiemTra15Phut1, " +
"KQHK1.DTBKiemTra1Tiet as DTBKiemTra1Tiet1, KQHK1.DiemHocKy as DiemHocKy1, KQHK1.DTBMonHocKy as DTBMonHocKy1, " +
"KQHK2.DTBKiemTraMieng as DTBKiemTraMieng2, KQHK2.DTBKiemTra15Phut as DTBKiemTra15Phut2, " +
"KQHK2.DTBKiemTra1Tiet as DTBKiemTra1Tiet2, KQHK2.DiemHocKy as DiemHocKy2, KQHK2.DTBMonHocKy as DTBMonHocKy2, " +
"KQCN.DiemThiLai, KQCN.DTBCaNam, " +
"DENSE_RANK() OVER (ORDER BY DTBCaNam DESC) AS XepThu " +
"from " +
"(select * from KQ_HOC_KY_MON_HOC " +
"where MaHocKy = 'HK1' and MaLop = @maLop and MaNamHoc = @maNamHoc and MaMonHoc = @maMonHoc) as KQHK1 " +
"full outer join " +
"(select * from KQ_HOC_KY_MON_HOC " +
"where MaHocKy = 'HK2' and MaLop = @maLop and MaNamHoc = @maNamHoc and MaMonHoc = @maMonHoc) as KQHK2 " +
"on KQHK1.MaHocSinh = KQHK2.MaHocSinh " +
"full outer join " +
"(select * from KQ_CA_NAM_MON_HOC " +
"where MaLop = @maLop and MaNamHoc = @maNamHoc and MaMonHoc = @maMonHoc) as KQCN " +
"on KQHK1.MaHocSinh = KQCN.MaHocSinh " + 
"inner join HocSinh HS on HS.MaHocSinh = KQHK1.MaHocSinh " +
"inner join Lop L on L.MaLop = KQHK1.MaLop " +
"inner join NamHoc N on N.MaNamHoc = KQHK1.MaNamHoc " +
"inner join MonHoc M on M.MaMonHoc = KQHK1.MaMonHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value    = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }

        public DataTable LayDsKQCaNamHocSinhForReport(String maHocSinh, String maLop, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand(
"select KQHK1.MaHocSinh, Ho, Ten, KQHK1.MaLop, TenLop, KQHK1.MaHocKy, KQHK1.MaNamHoc, TenNamHoc, KQHK1.MaMonHoc, TenMonHoc, " +
"KQHK1.DTBKiemTraMieng as DTBKiemTraMieng1, KQHK1.DTBKiemTra15Phut as DTBKiemTra15Phut1, " +
"KQHK1.DTBKiemTra1Tiet as DTBKiemTra1Tiet1, KQHK1.DiemHocKy as DiemHocKy1, KQHK1.DTBMonHocKy as DTBMonHocKy1, " +
"KQHK2.DTBKiemTraMieng as DTBKiemTraMieng2, KQHK2.DTBKiemTra15Phut as DTBKiemTra15Phut2, " +
"KQHK2.DTBKiemTra1Tiet as DTBKiemTra1Tiet2, KQHK2.DiemHocKy as DiemHocKy2, KQHK2.DTBMonHocKy as DTBMonHocKy2, " +
"KQCN.DiemThiLai, KQCN.DTBCaNam, " +
"DENSE_RANK() OVER (ORDER BY DTBCaNam DESC) AS XepThu " +
"from " +
"(select * from KQ_HOC_KY_MON_HOC " +
"where MaHocKy = 'HK1' and MaLop = @maLop and MaNamHoc = @maNamHoc and MaHocSinh = @maHocSinh) as KQHK1 " +
"full outer join " +
"(select * from KQ_HOC_KY_MON_HOC " +
"where MaHocKy = 'HK2' and MaLop = @maLop and MaNamHoc = @maNamHoc and MaHocSinh = @maHocSinh) as KQHK2 " +
"on KQHK1.MaMonHoc = KQHK2.MaMonHoc " +
"full outer join " +
"(select * from KQ_CA_NAM_MON_HOC " +
"where MaLop = @maLop and MaNamHoc = @maNamHoc and MaHocSinh = @maHocSinh) as KQCN " +
"on KQHK1.MaMonHoc = KQCN.MaMonHoc " +
"inner join HocSinh HS on HS.MaHocSinh = KQHK1.MaHocSinh " +
"inner join Lop L on L.MaLop = KQHK1.MaLop " +
"inner join NamHoc N on N.MaNamHoc = KQHK1.MaNamHoc " +
"inner join MonHoc M on M.MaMonHoc = KQHK1.MaMonHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }
    }
}
