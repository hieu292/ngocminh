using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KQHocKyMonHocInfo
    {
        public KQHocKyMonHocInfo()
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

        private HocKyInfo m_HocKy;
        public HocKyInfo HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private float m_DTBKiemTraMieng;
        public float DTBKiemTraMieng
        {
            get { return m_DTBKiemTraMieng; }
            set { m_DTBKiemTraMieng = value; }
        }

        private float m_DTBKiemTra15Phut;
        public float DTBKiemTra15Phut
        {
            get { return m_DTBKiemTra15Phut; }
            set { m_DTBKiemTra15Phut = value; }
        }

        private float m_DTBKiemTra1Tiet;
        public float DTBKiemTra1Tiet
        {
            get { return m_DTBKiemTra1Tiet; }
            set { m_DTBKiemTra1Tiet = value; }
        }

        private float m_DiemHocKy;
        public float DiemHocKy
        {
            get { return m_DiemHocKy; }
            set { m_DiemHocKy = value; }
        }

        private float m_DTBMonHocKy;
        public float DTBMonHocKy
        {
            get { return m_DTBMonHocKy; }
            set { m_DTBMonHocKy = value; }
        }

        private int m_XepThu;
        public int XepThu
        {
            get { return m_XepThu; }
            set { m_XepThu = value; }
        }
    }
}
