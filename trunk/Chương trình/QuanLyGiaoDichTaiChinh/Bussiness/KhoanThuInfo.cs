using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KhoanThuInfo
    {
        public KhoanThuInfo()
        {

        }

        private String m_MaKT;
        public String MaKT
        {
            get { return m_MaKT; }
            set { m_MaKT = value; }
        }

        private String m_TenKT;
        public String TenKT
        {
            get { return m_TenKT; }
            set { m_TenKT = value; }
        }

        private String m_GhiChu;
        public String GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
    }
}
