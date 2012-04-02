using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KhoanChiInfo
    {
        public KhoanChiInfo()
        {

        }

        private String m_MaKC;
        public String MaKC
        {
            get { return m_MaKC; }
            set { m_MaKC = value; }
        }

        private String m_TenKC;
        public String TenKC
        {
            get { return m_TenKC; }
            set { m_TenKC = value; }
        }

        private String m_GhiChu;
        public String GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
    }
}
