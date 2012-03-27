using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLyGiaoDichTaiChinh.Bussiness;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class KQHocKyMonHocCtrl
    {
        #region Fields
        DiemCtrl            m_DiemCtrl          = new DiemCtrl();
        KQHocKyMonHocData   m_KQHocKyMonHocData = new KQHocKyMonHocData();
        #endregion

        #region Luu ket qua
        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            float diemTBKTMieng     = m_DiemCtrl.DiemTrungBinhKiemTra(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop,"LD0001");
            float diemTBKT15Phut = m_DiemCtrl.DiemTrungBinhKiemTra(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, "LD0002");
            float diemTBKT1Tiet = m_DiemCtrl.DiemTrungBinhKiemTra(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, "LD0003");
            float diemHocKy = m_DiemCtrl.DiemTrungBinhKiemTra(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, "LD0004");
            float diemTBMonHK   = m_DiemCtrl.DiemTrungBinhMonHocKy(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

            m_KQHocKyMonHocData.XoaKetQua(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc);
            m_KQHocKyMonHocData.LuuKetQua(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc, diemTBKTMieng, diemTBKT15Phut, diemTBKT1Tiet, diemHocKy, diemTBMonHK);
        }
        #endregion

        #region Lay danh sach ket qua hoc ky mon hoc do vao report
        public static IList<KQHocKyMonHocInfo> LayDsKQHocKyMonHoc(String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            KQHocKyMonHocData m_KQHKMHData = new KQHocKyMonHocData();
            DataTable m_DT = m_KQHKMHData.LayDsKQHocKyMonHocForReport(maLop, maMonHoc, maHocKy, maNamHoc);

            IList<KQHocKyMonHocInfo> dS = new List<KQHocKyMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQHocKyMonHocInfo ketqua = new KQHocKyMonHocInfo();

                HocSinhInfo hs      = new HocSinhInfo();
                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.Ho               = Convert.ToString(Row["Ho"]);
                hs.Ten              = Convert.ToString(Row["Ten"]);

                LopInfo l           = new LopInfo();
                l.MaLop             = Convert.ToString(Row["MaLop"]);
                l.TenLop            = Convert.ToString(Row["TenLop"]);

                MonHocInfo mh       = new MonHocInfo();
                mh.MaMonHoc         = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc        = Convert.ToString(Row["TenMonHoc"]);

                HocKyInfo hk        = new HocKyInfo();
                hk.MaHocKy          = Convert.ToString(Row["MaHocKy"]);
                hk.TenHocKy         = Convert.ToString(Row["TenHocKy"]);

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                try
                {
                    ketqua.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DiemHocKy = Convert.ToSingle(Row["DiemHocKy"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy"]);
                }
                catch
                {
                }

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.MonHoc       = mh;
                ketqua.HocKy        = hk;
                ketqua.NamHoc       = nh;
                ketqua.XepThu       = Convert.ToInt16(Row["XepThu"]);
                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion

        #region Lay danh sach ket qua hoc ky hoc sinh do vao report
        public static IList<KQHocKyMonHocInfo> LayDsKQHocKyHocSinh(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            KQHocKyMonHocData m_KQHKMHData = new KQHocKyMonHocData();
            DataTable m_DT = m_KQHKMHData.LayDsKQHocKyHocSinhForReport(maHocSinh, maLop, maHocKy, maNamHoc);

            IList<KQHocKyMonHocInfo> dS = new List<KQHocKyMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQHocKyMonHocInfo ketqua = new KQHocKyMonHocInfo();

                HocSinhInfo hs = new HocSinhInfo();
                hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hs.Ho = Convert.ToString(Row["Ho"]);
                hs.Ten = Convert.ToString(Row["Ten"]);

                LopInfo l = new LopInfo();
                l.MaLop = Convert.ToString(Row["MaLop"]);
                l.TenLop = Convert.ToString(Row["TenLop"]);

                MonHocInfo mh = new MonHocInfo();
                mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);

                HocKyInfo hk = new HocKyInfo();
                hk.MaHocKy = Convert.ToString(Row["MaHocKy"]);
                hk.TenHocKy = Convert.ToString(Row["TenHocKy"]);

                NamHocInfo nh = new NamHocInfo();
                nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                try
                {
                    ketqua.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DiemHocKy = Convert.ToSingle(Row["DiemHocKy"]);
                }
                catch
                {
                }
                try
                {
                    ketqua.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy"]);
                }
                catch
                {
                }
                ketqua.HocSinh = hs;
                ketqua.Lop = l;
                ketqua.MonHoc = mh;
                ketqua.HocKy = hk;
                ketqua.NamHoc = nh;

                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
