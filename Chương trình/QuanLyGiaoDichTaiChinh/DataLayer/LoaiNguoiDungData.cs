﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class LoaiNguoiDungData
    {
        DataService m_LoaiNguoiDungData = new DataService();

        public DataTable LayDsLoaiNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAINGUOIDUNG");
            DataService dS = new DataService();
            dS.Load(cmd);
            m_LoaiNguoiDungData = dS;
            return m_LoaiNguoiDungData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.NewRow();
        }

        public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.Rows.Add(m_Row);
        }

        public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.ExecuteNoneQuery() > 0;
        }
    }
}
