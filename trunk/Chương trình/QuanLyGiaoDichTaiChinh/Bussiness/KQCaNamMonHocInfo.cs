using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KQCaNamMonHocInfo
    {
        public KQCaNamMonHocInfo()
        {

        }

        private HocSinhInfo m_HocSinh;
        public HocSinhInfo HocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
        }

        private LopInfo m_Lop;
        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }
        private KQHocKyMonHocInfo m_KetQuaHocKy1;
        public KQHocKyMonHocInfo KetQuaHocKy1
        {
            get { return m_KetQuaHocKy1; }
            set { m_KetQuaHocKy1 = value; }
        }

        private KQHocKyMonHocInfo m_KetQuaHocKy2;
        public KQHocKyMonHocInfo KetQuaHocKy2
        {
            get { return m_KetQuaHocKy2; }
            set { m_KetQuaHocKy2 = value; }
        }

        private float m_DiemThiLai;
        public float DiemThiLai
        {
            get { return m_DiemThiLai; }
            set { m_DiemThiLai = value; }
        }

        private float m_DTBCaNam;
        public float DTBCaNam
        {
            get { return m_DTBCaNam; }
            set { m_DTBCaNam = value; }
        }

        private int m_XepThu;
        public int XepThu
        {
            get { return m_XepThu; }
            set { m_XepThu = value; }
        }
    }
}
