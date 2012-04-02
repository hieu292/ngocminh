using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class NhanVienInfo
    {
        public NhanVienInfo()
        {

        }

        private String m_MaNV;
        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_TenNV;
        public String TenNV
        {
            get { return m_TenNV; }
            set { m_TenNV = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_GioiTinh;
        public String GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }


        private String m_CMND;
        public String CMND
        {
            get { return m_CMND; }
            set { m_CMND = value; }
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
