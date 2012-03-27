using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLyGiaoDichTaiChinh.Bussiness;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class KQCaNamMonHocCtrl
    {
        #region Fields
        DiemCtrl            m_DiemCtrl          = new DiemCtrl();
        KQCaNamMonHocData   m_KQCaNamMonHocData = new KQCaNamMonHocData();
        #endregion
        #region Hien thi
        public void HienThi(DataGridView dGV, BindingNavigator bN, String maLop, String maMonHoc, String maNamHoc)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KQCaNamMonHocData.LayDsKQCaNamMonHoc(maLop, maMonHoc, maNamHoc);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Luu ket qua
        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            float diemTBMonCN   = m_DiemCtrl.DiemTrungBinhMonCaNam(maHocSinh, maMonHoc, maNamHoc, maLop);
            float diemThiLai = 0;
            KQCaNamMonHocData m_KQCNMHData = new KQCaNamMonHocData();
            DataTable m_DT = m_KQCNMHData.LayKQCaNamMonHoc(maHocSinh, maLop, maMonHoc, maNamHoc);
            if (m_DT.Rows.Count > 0)
            {
                diemThiLai = Convert.ToSingle(m_DT.Rows[0]["DiemThiLai"].ToString());
                m_KQCaNamMonHocData.XoaKetQua(maHocSinh, maLop, maMonHoc, maNamHoc);
            }
            m_KQCaNamMonHocData.LuuKetQua(maHocSinh, maLop, maMonHoc, maNamHoc, diemThiLai, diemTBMonCN);
        }

        public void CapNhatKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai)
        {
            m_KQCaNamMonHocData.CapNhatDiemThiLai(maHocSinh, maLop, maMonHoc, maNamHoc, diemThiLai);
        }

        #endregion

        #region Lay danh sach ket qua ca nam mon hoc do vao report
        public static IList<KQCaNamMonHocInfo> LayDsKQCaNamMonHoc(String maLop, String maMonHoc, String maNamHoc)
        {
            KQCaNamMonHocData m_KQCNMHData = new KQCaNamMonHocData();
            DataTable m_DT = m_KQCNMHData.LayDsKQCaNamMonHocForReport(maLop, maMonHoc, maNamHoc);
            IList<KQCaNamMonHocInfo> dS = new List<KQCaNamMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQCaNamMonHocInfo ketqua = new KQCaNamMonHocInfo();

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

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                KQHocKyMonHocInfo kqhocky1 = new KQHocKyMonHocInfo();
                try
                {
                    kqhocky1.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DiemHocKy = Convert.ToSingle(Row["DiemHocKy1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy1"]);
                }
                catch
                {
                }

                KQHocKyMonHocInfo kqhocky2 = new KQHocKyMonHocInfo();
                try
                {
                    kqhocky2.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DiemHocKy = Convert.ToSingle(Row["DiemHocKy2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy2"]);
                }
                catch
                {
                }

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.MonHoc       = mh;
                ketqua.NamHoc       = nh;
                ketqua.KetQuaHocKy1 = kqhocky1;
                ketqua.KetQuaHocKy2 = kqhocky2;
                try
                {
                    ketqua.DiemThiLai = Convert.ToSingle(Row["DiemThiLai"]);
                }
                catch{}
                try
                {
                    ketqua.DTBCaNam = Convert.ToSingle(Row["DTBCaNam"]);
                }
                catch{}
                ketqua.XepThu       = Convert.ToInt16(Row["XepThu"]);
                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion


        #region Lay danh sach ket qua ca nam hoc sinh do vao report
        public static IList<KQCaNamMonHocInfo> LayDsKQCaNamHocSinh(String maHocSinh, String maLop, String maNamHoc)
        {
            KQCaNamMonHocData m_KQCNMHData = new KQCaNamMonHocData();
            DataTable m_DT = m_KQCNMHData.LayDsKQCaNamHocSinhForReport(maHocSinh, maLop, maNamHoc);
            IList<KQCaNamMonHocInfo> dS = new List<KQCaNamMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQCaNamMonHocInfo ketqua = new KQCaNamMonHocInfo();

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

                NamHocInfo nh = new NamHocInfo();
                nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                KQHocKyMonHocInfo kqhocky1 = new KQHocKyMonHocInfo();
                try
                {
                    kqhocky1.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DiemHocKy = Convert.ToSingle(Row["DiemHocKy1"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky1.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy1"]);
                }
                catch
                {
                }

                KQHocKyMonHocInfo kqhocky2 = new KQHocKyMonHocInfo();
                try
                {
                    kqhocky2.DTBKiemTraMieng = Convert.ToSingle(Row["DTBKiemTraMieng2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBKiemTra15Phut = Convert.ToSingle(Row["DTBKiemTra15Phut2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBKiemTra1Tiet = Convert.ToSingle(Row["DTBKiemTra1Tiet2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DiemHocKy = Convert.ToSingle(Row["DiemHocKy2"]);
                }
                catch
                {
                }
                try
                {
                    kqhocky2.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy2"]);
                }
                catch
                {
                }

                ketqua.HocSinh = hs;
                ketqua.Lop = l;
                ketqua.MonHoc = mh;
                ketqua.NamHoc = nh;
                ketqua.KetQuaHocKy1 = kqhocky1;
                ketqua.KetQuaHocKy2 = kqhocky2;
                try
                {
                    ketqua.DiemThiLai = Convert.ToSingle(Row["DiemThiLai"]);
                }
                catch { }
                try
                {
                    ketqua.DTBCaNam = Convert.ToSingle(Row["DTBCaNam"]);
                }
                catch { }
                ketqua.XepThu = Convert.ToInt16(Row["XepThu"]);
                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
