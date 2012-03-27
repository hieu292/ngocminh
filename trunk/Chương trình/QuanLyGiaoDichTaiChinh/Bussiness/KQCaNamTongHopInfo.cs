using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QuanLyGiaoDichTaiChinh.Bussiness
{
    public class KQCaNamTongHopInfo
    {
        public KQCaNamTongHopInfo()
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

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private KQHocKyTongHopInfo m_KetQuaHocKy1;
        public KQHocKyTongHopInfo KetQuaHocKy1
        {
            get { return m_KetQuaHocKy1; }
            set { m_KetQuaHocKy1 = value; }
        }

        private KQHocKyTongHopInfo m_KetQuaHocKy2;
        public KQHocKyTongHopInfo KetQuaHocKy2
        {
            get { return m_KetQuaHocKy2; }
            set { m_KetQuaHocKy2 = value; }
        }

        private HocLucInfo m_HocLucCN;
        public HocLucInfo HocLucCN
        {
            get { return m_HocLucCN; }
            set { m_HocLucCN = value; }
        }

        private HanhKiemInfo m_HanhKiemCN;
        public HanhKiemInfo HanhKiemCN
        {
            get { return m_HanhKiemCN; }
            set { m_HanhKiemCN = value; }
        }

        private float m_DTBCaNam;
        public float DTBCaNam
        {
            get { return m_DTBCaNam; }
            set { m_DTBCaNam = value; }
        }
        private KetQuaInfo m_KetQuaCN;
        public KetQuaInfo KetQuaCN
        {
            get { return m_KetQuaCN; }
            set { m_KetQuaCN = value; }
        }

        private int m_SoBuoiNghi;
        public int SoBuoiNghi
        {
            get { return m_SoBuoiNghi; }
            set { m_SoBuoiNghi = value; }
        }

        private int m_XepThu;
        public int XepThu
        {
            get { return m_XepThu; }
            set { m_XepThu = value; }
        }
    }
}
