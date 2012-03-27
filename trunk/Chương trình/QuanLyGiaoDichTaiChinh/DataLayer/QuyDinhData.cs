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
            m_QuyDinhData.Load(cmd);
            return m_QuyDinhData;
        }

        public int CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren");
            cmd.Parameters.Add("siSoCanDuoi", SqlDbType.Int).Value  = siSoCanDuoi;
            cmd.Parameters.Add("siSoCanTren", SqlDbType.Int).Value  = siSoCanTren;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren");
            cmd.Parameters.Add("tuoiCanDuoi", SqlDbType.Int).Value = tuoiCanDuoi;
            cmd.Parameters.Add("tuoiCanTren", SqlDbType.Int).Value = tuoiCanTren;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TenTruong = @tenTruong, DiaChiTruong = @diaChiTruong");
            cmd.Parameters.Add("tenTruong", SqlDbType.NVarChar).Value       = tenTruong;
            cmd.Parameters.Add("diaChiTruong", SqlDbType.NVarChar).Value    = diaChiTruong;

            return m_QuyDinhData.Load(cmd);
        }

        public int CapNhatQuyDinhThangDiem(int thangDiem)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET ThangDiem = @thangDiem");
            cmd.Parameters.Add("thangDiem", SqlDbType.Int).Value = thangDiem;

            return m_QuyDinhData.Load(cmd);
        }
    }
}
