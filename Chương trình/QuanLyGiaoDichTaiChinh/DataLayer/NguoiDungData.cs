using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class NguoiDungData
    {
        DataService m_NguoiDungData = new DataService();

        public DataTable LayDsNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG");
            DataService dS = new DataService();
            dS.Load(cmd);
            m_NguoiDungData = dS;
            DataColumn[] dc = {m_NguoiDungData.Columns[0]};
            m_NguoiDungData.PrimaryKey = dc;
            return m_NguoiDungData;
        }

        public DataTable LayDsNguoiDung(String tenDangNhap)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @ten");
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = tenDangNhap;

            DataService dS = new DataService();
            dS.Load(cmd);
            m_NguoiDungData = dS;
            return m_NguoiDungData;
        }

        public Boolean isDuplicate(String tenDangNhap)
        {
            foreach (DataRow dr in m_NguoiDungData.Rows)
            {
                if (dr["TenDangNhap"].ToString() == tenDangNhap)
                    return true;
            }
            return false;
        }
        public DataRow FindRow(int maNguoiDung)
        {
            return m_NguoiDungData.Rows.Find(maNguoiDung);
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.Rows.Add(m_Row);
        }

        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.ExecuteNoneQuery() > 0;
        }

        public void DoiMatKhau(String tenDangNhap, String matKhauMoi)
        {
            m_NguoiDungData.ChangePassword(tenDangNhap,matKhauMoi);
        }
    }
}
