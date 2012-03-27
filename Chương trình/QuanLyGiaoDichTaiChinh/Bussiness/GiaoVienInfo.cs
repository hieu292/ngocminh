using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class GiaoVienInfo
    {
        public GiaoVienInfo()
        {

        }

        private String m_MaGiaoVien;
        public String MaGiaoVien
        {
            get { return m_MaGiaoVien; }
            set { m_MaGiaoVien = value; }
        }

        private String m_Ho;
        public String Ho
        {
            get { return m_Ho; }
            set { m_Ho = value; }
        }

        private String m_Ten;
        public String Ten
        {
            get { return m_Ten; }
            set { m_Ten = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
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

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }
    }
}
