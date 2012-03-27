using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyGiaoDichTaiChinh.Controller;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class KQCaNamTongHopData
    {
      
        DataService m_KQCaNamTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc, float diemTBChungCacMonCN, String maHocLuc, String maHanhKiem, String maKetQua, int soBuoiNghi)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_TONG_HOP VALUES(@maHocSinh, @maLop, @maNamHoc, @maHocLuc, @maHanhKiem, @diemTBChungCacMonCN, @maKetQua, @soBuoiNghi)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value            = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value                = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value             = maNamHoc;
            cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value             = maHocLuc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value           = maHanhKiem;
            cmd.Parameters.Add("diemTBChungCacMonCN", SqlDbType.Float).Value    = Math.Round(diemTBChungCacMonCN, 1);
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value             = maKetQua;
            cmd.Parameters.Add("soBuoiNghi", SqlDbType.TinyInt).Value           = soBuoiNghi;

            m_KQCNTHData.Load(cmd);
        }

        public void CapNhatKetQua(String maHocSinh, String maLop, String maNamHoc, String maHanhKiem, String maKetQua, int soBuoiNghi)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE KQ_CA_NAM_TONG_HOP SET MaHanhKiem = @maHanhKiem, MaKetQua = @maKetQua, SoBuoiNghi = @soBuoiNghi " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value = maHanhKiem;
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value = maKetQua;
            cmd.Parameters.Add("soBuoiNghi", SqlDbType.TinyInt).Value = soBuoiNghi;

            m_KQHKTHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maNamHoc)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQCNTHData.Load(cmd);
        }
        public DataTable LayKQCaNamTongHop(String maHocSinh, String maLop, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM KQ_CA_NAM_TONG_HOP " +
                                            "WHERE MaHocSinh = @maHocSinh AND " +
                                            "MaLop = @maLop AND " +
                                            "MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamTongHopData.Load(cmd);
            return m_KQCaNamTongHopData;
        }

        public DataTable LayDsKQCaNamTongHop(String maLop, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT KQ.MaHocSinh, HS.Ho, HS.Ten, HKIEM.MaHanhKiem, KQ.SoBuoiNghi [Số buổi nghỉ]" +
                                            "FROM HOCSINH HS INNER JOIN KQ_CA_NAM_TONG_HOP KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN HANHKIEM HKIEM ON KQ.MaHanhKiem = HKIEM.MaHanhKiem " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamTongHopData.Load(cmd);
            return m_KQCaNamTongHopData;
        }

        public DataTable LayDsKQCaNamTongHopForReport(String maLop, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand(
"select KQHK1.MaHocSinh, Ho, Ten, KQHK1.MaLop, TenLop, KQHK1.MaHocKy, KQHK1.MaNamHoc, TenNamHoc, " +
"MaHocLucKy1, TenHocLucKy1, MaHanhKiemKy1, TenHanhKiemKy1, DiemTBMonHocKy1, MaKetQuaKy1, TenKetQuaKy1, " +
"MaHocLucKy2, TenHocLucKy2, MaHanhKiemKy2, TenHanhKiemKy2, DiemTBMonHocKy2, MaKetQuaKy2, TenKetQuaKy2, " +
"MaHocLucCN, TenHocLucCN, MaHanhKiemCN, TenHanhKiemCN, DTBCaNam, MaKetQuaCN, TenKetQuaCN, SoBuoiNghi, " +
"DENSE_RANK() OVER (ORDER BY DTBCaNam DESC) AS XepThu " +
"from " +
"(select MaHocSinh, MaLop, MaHocKy, MaNamHoc, KQ1.MaHocLuc as MaHocLucKy1, TenHocLuc as TenHocLucKy1, " +
"KQ1.MaHanhKiem as MaHanhKiemKy1, TenHanhKiem as TenHanhKiemKy1, DTBMonHocKy as DiemTBMonHocKy1, " +
"KQ1.MaKetQua as MaKetQuaKy1, TenKetQua as TenKetQuaKy1 " +
"from KQ_HOC_KY_TONG_HOP KQ1 " +
"inner join HanhKiem HKiem on HKiem.MaHanhKiem = KQ1.MaHanhKiem " +
"inner join HocLuc HL on HL.MaHocLuc = KQ1.MaHocLuc " +
"inner join KetQua KQ on KQ.MaKetQua = KQ1.MaKetQua " +
"where MaHocKy = 'HK1' and MaLop = @maLop and MaNamHoc = @maNamHoc) as KQHK1 " +
"full outer join " +
"(select MaHocSinh, MaLop, MaHocKy, MaNamHoc, KQ2.MaHocLuc as MaHocLucKy2, TenHocLuc as TenHocLucKy2, " +
"KQ2.MaHanhKiem as MaHanhKiemKy2, TenHanhKiem as TenHanhKiemKy2, DTBMonHocKy as DiemTBMonHocKy2, " +
"KQ2.MaKetQua as MaKetQuaKy2, TenKetQua as TenKetQuaKy2 " +
"from KQ_HOC_KY_TONG_HOP KQ2 " +
"inner join HanhKiem HKiem on HKiem.MaHanhKiem = KQ2.MaHanhKiem " +
"inner join HocLuc HL on HL.MaHocLuc = KQ2.MaHocLuc " +
"inner join KetQua KQ on KQ.MaKetQua = KQ2.MaKetQua " +
"where MaHocKy = 'HK2' and MaLop = @maLop and MaNamHoc = @maNamHoc) as KQHK2 " +
"on " +
"KQHK1.MaHocSinh = KQHK2.MaHocSinh " +
"full outer join " +
"(select MaHocSinh, MaLop, MaNamHoc, KQ3.MaHocLuc as MaHocLucCN, TenHocLuc as TenHocLucCN, " +
"KQ3.MaHanhKiem as MaHanhKiemCN, TenHanhKiem as TenHanhKiemCN, DTBCaNam, " +
"KQ3.MaKetQua as MaKetQuaCN, TenKetQua as TenKetQuaCN, SoBuoiNghi " +
"from KQ_CA_NAM_TONG_HOP KQ3 " +
"inner join HanhKiem HKiem on HKiem.MaHanhKiem = KQ3.MaHanhKiem " +
"inner join HocLuc HL on HL.MaHocLuc = KQ3.MaHocLuc  " +
"inner join KetQua KQ on KQ.MaKetQua = KQ3.MaKetQua " +
"where MaLop = @maLop and MaNamHoc = @maNamHoc) as KQCN " +
"on " +
"KQHK1.MaHocSinh = KQCN.MaHocSinh " +
"inner join HocSinh HS on HS.MaHocSinh = KQHK1.MaHocSinh " +
"inner join Lop L on L.MaLop = KQHK1.MaLop " +
"inner join NamHoc N on N.MaNamHoc = KQHK1.MaNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamTongHopData.Load(cmd);
            return m_KQCaNamTongHopData;
        }
    }
}
