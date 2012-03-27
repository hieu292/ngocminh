using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class HocSinhData
    {
        DataService m_HocSinhData = new DataService();

        public DataTable LayDsHocSinh(String sqlString)
        {
            SqlCommand cmd = new SqlCommand(sqlString);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT MaHocSinh, Ho, Ten, GioiTinh, NgaySinh, NoiSinh, DiaChi, MaDanToc, MaTonGiao, HoTenCha, MaNNghiepCha, HoTenMe, MaNNghiepMe, MaLop FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhChuaPhanLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT MaHocSinh, Ho + ' ' + Ten AS HoTen FROM HOCSINH WHERE MaLop IS NULL");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT MaHocSinh, Ho + ' ' + Ten AS HoTen " +
                                            "FROM HOCSINH WHERE MaLop = @lop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLopVaKetQua(String lop)
        {
            String sql = "SELECT HS.MaHocSinh, Ho +' ' + Ten AS HoTen, TenKetQua " +
                        "FROM HOCSINH HS LEFT JOIN KQ_CA_NAM_TONG_HOP KQCN " +
                        "ON KQCN.MaLop = HS.MaLop AND KQCN.MaHocSinh = HS.MaHocSinh " +
                        "LEFT JOIN KETQUA KQ ON KQCN.MaKetQua = KQ.MaKetQua " +
                        "WHERE HS.MaLop = @lop";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLopVaKetQua(String lop, String ketQua)
        {
            String sql = "SELECT HS.MaHocSinh, Ho +' ' + Ten AS HoTen, TenKetQua " +
                        "FROM HOCSINH HS LEFT JOIN KQ_CA_NAM_TONG_HOP KQCN " +
                        "ON KQCN.MaLop = HS.MaLop AND KQCN.MaHocSinh = HS.MaHocSinh " +
                        "LEFT JOIN KETQUA KQ ON KQCN.MaKetQua = KQ.MaKetQua " +
                        "WHERE HS.MaLop = @lop AND TenKetQua LIKE @ketQua";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("ketQua", SqlDbType.NVarChar).Value = "%" + ketQua + "%";

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public void PhanLopHocSinh(String maHocSinh, String maLopMoi)
        {
            DataService m_HocSinhData = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE HOCSINH SET MaLop = @maLop WHERE MaHocSinh = @maHocSinh");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLopMoi;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;

            m_HocSinhData.Load(cmd);
        }
        
        public DataTable LayDsHocSinhForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHENGHIEP NNC, NGHENGHIEP NNM, HOCSINH HS, DANTOC DT, TONGIAO TG, LOP L " +
                "WHERE HS.MaNNghiepCha = NNC.MaNghe AND HS.MaNNghiepMe = NNM.MaNghe AND HS.MaDanToc = DT.MaDanToc AND HS.MaTonGiao = TG.MaTonGiao AND HS.MaLop = L.MaLop");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.NewRow();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.Rows.Add(m_Row);
        }

        public bool LuuHocSinh()
        {
            return m_HocSinhData.ExecuteNoneQuery() > 0;
        }

        public void LuuHocSinh(String maHocSinh, String ho, String ten, String gioiTinh, DateTime ngaySinh, String noiSinh, String diaChi, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HOCSINH(MaHocSinh,Ho,Ten,GioiTinh,NgaySinh,NoiSinh,DiaChi,MaDanToc,MaTonGiao,HoTenCha,MaNNghiepCha,HoTenMe,MaNNghiepMe,MaLop) "+ 
                "VALUES(@maHocSinh, @ho, @ten, @gioiTinh, @ngaySinh, @noiSinh, @diaChi, @maDanToc, @maTonGiao, @hoTenCha, @maNgheCha, @hoTenMe, @maNgheMe, null)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("ho", SqlDbType.NVarChar).Value          = ho;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value         = ten;
            cmd.Parameters.Add("gioiTinh", SqlDbType.NVarChar).Value    = gioiTinh;
            cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value    = ngaySinh;
            cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value     = noiSinh;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value      = diaChi;
            cmd.Parameters.Add("maDanToc", SqlDbType.VarChar).Value     = maDanToc;
            cmd.Parameters.Add("maTonGiao", SqlDbType.VarChar).Value    = maTonGiao;
            cmd.Parameters.Add("hoTenCha", SqlDbType.NVarChar).Value    = hoTenCha;
            cmd.Parameters.Add("maNgheCha", SqlDbType.VarChar).Value    = maNgheCha;
            cmd.Parameters.Add("hoTenMe", SqlDbType.NVarChar).Value     = hoTenMe;
            cmd.Parameters.Add("maNgheMe", SqlDbType.VarChar).Value     = maNgheMe;

            m_HocSinhData.Load(cmd);
        }

        public void LuuHocSinh(String maHocSinh, String ho, String ten, String gioiTinh, DateTime ngaySinh, String noiSinh, String diaChi, String maDanToc, String maTonGiao, String hoTenCha, String hoTenMe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HOCSINH (MaHocSinh,Ho,Ten,GioiTinh,NgaySinh,NoiSinh,DiaChi,MaDanToc,MaTonGiao,HoTenCha,MaNNghiepCha,HoTenMe,MaNNghiepMe,MaLop) " +
                "VALUES(@maHocSinh, @ho, @ten, @gioiTinh, @ngaySinh, @noiSinh, @diaChi, @maDanToc, @maTonGiao, @hoTenCha, null, @hoTenMe, null, null)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("ho", SqlDbType.NVarChar).Value = ho;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
            cmd.Parameters.Add("gioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
            cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value = ngaySinh;
            cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value = noiSinh;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("maDanToc", SqlDbType.VarChar).Value = maDanToc;
            cmd.Parameters.Add("maTonGiao", SqlDbType.VarChar).Value = maTonGiao;
            cmd.Parameters.Add("hoTenCha", SqlDbType.NVarChar).Value = hoTenCha;
            cmd.Parameters.Add("hoTenMe", SqlDbType.NVarChar).Value = hoTenMe;

            m_HocSinhData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE MaHocSinh LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE Ho + ' ' + Ten LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public String TruyVanChung()
        {
            return "SELECT HS.MaHocSinh, HS.Ho, HS.Ten, HS.GioiTinh, HS.NgaySinh, " +
                "HS.NoiSinh, HS.DiaChi, DT.TenDanToc, TG.TenTonGiao, L.MaLop, L.TenLop, L.MaNamHoc, NH.TenNamHoc, " +
                "HS.HoTenCha, HS.HoTenMe, NN1.TenNghe TenNgheCha, NN2.TenNghe TenNgheMe " +
                "FROM HOCSINH HS INNER JOIN DANTOC DT ON HS.MaDanToc = DT.MaDanToc " +
                "INNER JOIN TONGIAO TG ON HS.MaTonGiao = TG.MaTonGiao " +
                "LEFT JOIN NGHENGHIEP NN1 ON HS.MaNNghiepCha = NN1.MaNghe " +
                "LEFT JOIN NGHENGHIEP NN2 ON HS.MaNNghiepMe = NN2.MaNghe " +
                "LEFT JOIN LOP L ON HS.MaLop = L.MaLop " +
                "LEFT JOIN NAMHOC NH ON L.MaNamHoc = NH.MaNamHoc ";
        }

        public DataTable TimKiemHocSinh(String tuKhoa)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + "WHERE HS.MaHocSinh LIKE '%' + @tuKhoa + '%' " +
            "OR HS.Ho + ' ' + HS.Ten LIKE '%' + @tuKhoa + '%' " +
            "OR HS.GioiTinh LIKE '%' + @tuKhoa + '%' " +
            "OR HS.NgaySinh LIKE '%' + @tuKhoa + '%' " +
            "OR HS.NoiSinh LIKE '%' + @tuKhoa + '%' " +
            "OR HS.DiaChi LIKE '%' + @tuKhoa + '%' " +
            "OR DT.TenDanToc LIKE '%' + @tuKhoa + '%' " +
            "OR TG.TenTonGiao LIKE '%' + @tuKhoa + '%' " +
            "OR HS.HoTenCha LIKE '%' + @tuKhoa + '%' " +
            "OR HS.HoTenMe LIKE '%' + @tuKhoa + '%' " +
            "OR NN1.TenNghe LIKE '%' + @tuKhoa + '%' " +
            "OR NN2.TenNghe LIKE '%' + @tuKhoa + '%' " +
            "OR L.TenLop LIKE '%' + @tuKhoa + '%' " +
            "OR NH.TenNamHoc LIKE '%' + @tuKhoa + '%' ";

            cmd.Parameters.Add("tuKhoa", SqlDbType.NVarChar).Value = tuKhoa;
            cmd.CommandText = sql;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimKiemHocSinh(String hoTen, String theoNSinh, String noiSinh, String theoDToc, String danToc, String theoTGiao, String tonGiao)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE HS.Ho + ' ' + HS.Ten LIKE '%' + @hoTen + '%' ";
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;

            if (theoNSinh != "NONE")
            {
                sql += theoNSinh + " HS.NoiSinh LIKE '%' + @noiSinh + '%' ";
                cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value = noiSinh;
            }

            if (theoDToc != "NONE")
            {
                sql += theoDToc + " DT.TenDanToc = @danToc ";
                cmd.Parameters.Add("danToc", SqlDbType.NVarChar).Value = danToc;
            }

            if (theoTGiao != "NONE")
            {
                sql += theoTGiao + " TG.TenTonGiao = @tonGiao";
                cmd.Parameters.Add("tonGiao", SqlDbType.NVarChar).Value = tonGiao;
            }

            cmd.CommandText = sql;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }
    }
}
