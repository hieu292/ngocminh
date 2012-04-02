using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KhachHangInfo
    {
        public KhachHangInfo()
        {

        }

        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private String m_TenKH;
        public String TenKH
        {
            get { return m_TenKH; }
            set { m_TenKH = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
    }
}
