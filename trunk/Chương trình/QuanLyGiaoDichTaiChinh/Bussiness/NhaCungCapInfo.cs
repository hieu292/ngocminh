using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class NhaCungCapInfo
    {
        public NhaCungCapInfo()
        {

        }

        private String m_MaNCC;
        public String MaNCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }
        }

        private String m_TenNCC;
        public String TenNCC
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }
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
