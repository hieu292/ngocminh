﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh.DataLayer
{
    public class DanTocData
    {
        DataService m_DanTocData = new DataService();

        public DataTable LayDsDanToc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DANTOC");
            m_DanTocData.Load(cmd);
            return m_DanTocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DanTocData.NewRow();
        }

        public void ThemDanToc(DataRow m_Row)
        {
            m_DanTocData.Rows.Add(m_Row);
        }

        public bool LuuDanToc()
        {
            return m_DanTocData.ExecuteNoneQuery() > 0;
        }
    }
}
