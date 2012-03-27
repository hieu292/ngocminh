using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class NguoiDungInfo
    {
        public NguoiDungInfo()
        {

        }

        private String m_MaND;
        public String MaNguoiDung
        {
            get { return m_MaND; }
            set { m_MaND = value; }
        }

        private LoaiNguoiDungInfo m_LoaiND;
        public LoaiNguoiDungInfo LoaiNguoiDung
        {
            get { return m_LoaiND; }
            set { m_LoaiND = value; }
        }

        private String m_TenND;
        public String TenNguoiDung
        {
            get { return m_TenND; }
            set { m_TenND = value; }
        }

        private String m_TenDNhap;
        public String TenDangNhap
        {
            get { return m_TenDNhap; }
            set { m_TenDNhap = value; }
        }

        private String m_MatKhau;
        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
    }
}
