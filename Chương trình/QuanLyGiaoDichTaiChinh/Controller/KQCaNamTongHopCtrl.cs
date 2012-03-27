using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLyGiaoDichTaiChinh.Bussiness;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class KQCaNamTongHopCtrl
    {
        #region Fields
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        KQCaNamTongHopData  m_KQCaNamTongHopData = new KQCaNamTongHopData();
        #endregion

        #region Hiển thị
        public void HienThi(DataGridView dGV, BindingNavigator bN, String maLop, String maNamHoc)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KQCaNamTongHopData.LayDsKQCaNamTongHop(maLop,maNamHoc);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Luu ket qua
        public String XepLoaiKetQuaCaNam(String maHocLuc, String maHanhKiem, int soBuoiNghi)
        {
            if (soBuoiNghi <= 45)
            {
                if (maHocLuc == "HL0001" && maHanhKiem == "HK0001")
                    return "KQ0005";
                if (maHocLuc == "HL0002" && (maHanhKiem == "HK0001" || maHanhKiem == "HK0002"))
                    return "KQ0006";
                if (maHocLuc == "HL0003" && maHanhKiem == "HK0003")
                    return "KQ0001";
                if (maHocLuc == "HL0005" || (maHocLuc == "HL0004" && maHanhKiem == "HK0004"))
                    return "KQ0004";
                if (maHocLuc == "HL0004" && maHanhKiem != "HK0004")
                    return "KQ0002";
                if (maHocLuc != "HL0004" && maHocLuc != "HL0005" && maHanhKiem == "HK0004")
                    return "KQ0003";
            }
            else
            {
                return "KQ0004";
            }
            return "KQ0004";
        }
        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc)
        {
            KQCaNamTongHopData m_KQCNTHData = new KQCaNamTongHopData();
            float diemTBChungCacMonCN = m_DiemCtrl.DiemTrungBinhChungCacMonCaNam(maHocSinh, maLop, maNamHoc);
            String maHocLuc = m_HocLucCtrl.XepLoaiHocLucCaNam(maHocSinh, maLop, maNamHoc);
            DataTable m_DT = m_KQCNTHData.LayKQCaNamTongHop(maHocSinh, maLop, maNamHoc);
            String maHanhKiem = "HK0001";
            int soBuoiNghi = 0;
            if (m_DT.Rows.Count > 0)
            {
                maHanhKiem = m_DT.Rows[0]["MaHanhKiem"].ToString();
                soBuoiNghi = Convert.ToInt16(m_DT.Rows[0]["SoBuoiNghi"]);
            }
            String maKetQua = XepLoaiKetQuaCaNam(maHocLuc, maHanhKiem, soBuoiNghi);

            m_KQCNTHData.XoaKetQua(maHocSinh, maLop, maNamHoc);

            m_KQCaNamTongHopData.LuuKetQua(maHocSinh, maLop, maNamHoc,diemTBChungCacMonCN, maHocLuc, maHanhKiem, maKetQua, soBuoiNghi);
        }
        public void CapNhatKetQua(String maHocSinh, String maLop, String maNamHoc, String maHanhKiem, int soBuoiNghi)
        {
            KQCaNamTongHopData m_KQCNTHData = new KQCaNamTongHopData();
            DataTable m_DT = m_KQCNTHData.LayKQCaNamTongHop(maHocSinh, maLop, maNamHoc);
            //Console.WriteLine(m_DT.Rows.Count.ToString());
            if (m_DT.Rows.Count == 0) return;
            String maKetQua = XepLoaiKetQuaCaNam(m_DT.Rows[0]["MaHocLuc"].ToString(), maHanhKiem, soBuoiNghi);
            m_KQCaNamTongHopData.CapNhatKetQua(maHocSinh, maLop, maNamHoc,maHanhKiem, maKetQua, soBuoiNghi);
        }

        #endregion

        #region Lay danh sach ket qua ca nam tong hop do vao report
        public static IList<KQCaNamTongHopInfo> LayDsKQCaNamTongHop(String maLop, String maNamHoc)
        {
            KQCaNamTongHopData m_KQCNTHData = new KQCaNamTongHopData();
            DataTable m_DT = m_KQCNTHData.LayDsKQCaNamTongHopForReport(maLop, maNamHoc);
            //MessageBox.Show(m_DT.Rows.Count.ToString());
            IList<KQCaNamTongHopInfo> dS = new List<KQCaNamTongHopInfo>();
            foreach (DataRow Row in m_DT.Rows)
            {
                KQCaNamTongHopInfo ketqua = new KQCaNamTongHopInfo();

                HocSinhInfo hs      = new HocSinhInfo();
                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.Ho               = Convert.ToString(Row["Ho"]);
                hs.Ten              = Convert.ToString(Row["Ten"]);

                LopInfo l           = new LopInfo();
                l.MaLop             = Convert.ToString(Row["MaLop"]);
                l.TenLop            = Convert.ToString(Row["TenLop"]);

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                HocLucInfo hlcn       = new HocLucInfo();
                hlcn.MaHocLuc         = Convert.ToString(Row["MaHocLucCN"]);
                hlcn.TenHocLuc        = Convert.ToString(Row["TenHocLucCN"]);

                HocLucInfo hlky1 = new HocLucInfo();
                hlky1.MaHocLuc = Convert.ToString(Row["MaHocLucKy1"]);
                hlky1.TenHocLuc = Convert.ToString(Row["TenHocLucKy1"]);

                HocLucInfo hlky2 = new HocLucInfo();
                hlky2.MaHocLuc = Convert.ToString(Row["MaHocLucKy2"]);
                hlky2.TenHocLuc = Convert.ToString(Row["TenHocLucKy2"]);

                HanhKiemInfo hkiemcn  = new HanhKiemInfo();
                hkiemcn.MaHanhKiem    = Convert.ToString(Row["MaHanhKiemCN"]);
                hkiemcn.TenHanhKiem   = Convert.ToString(Row["TenHanhKiemCN"]);

                HanhKiemInfo hkiemky1 = new HanhKiemInfo();
                hkiemky1.MaHanhKiem = Convert.ToString(Row["MaHanhKiemKy1"]);
                hkiemky1.TenHanhKiem = Convert.ToString(Row["TenHanhKiemKy1"]);

                HanhKiemInfo hkiemky2 = new HanhKiemInfo();
                hkiemky2.MaHanhKiem = Convert.ToString(Row["MaHanhKiemKy2"]);
                hkiemky2.TenHanhKiem = Convert.ToString(Row["TenHanhKiemKy2"]);

                KetQuaInfo kqcn       = new KetQuaInfo();
                kqcn.MaKetQua         = Convert.ToString(Row["MaKetQuaCN"]);
                kqcn.TenKetQua        = Convert.ToString(Row["TenKetQuaCN"]);

                KetQuaInfo kqky1 = new KetQuaInfo();
                kqky1.MaKetQua = Convert.ToString(Row["MaKetQuaKy1"]);
                kqky1.TenKetQua = Convert.ToString(Row["TenKetQuaKy1"]);

                KetQuaInfo kqky2    = new KetQuaInfo();
                kqky2.MaKetQua      = Convert.ToString(Row["MaKetQuaKy2"]);
                kqky2.TenKetQua     = Convert.ToString(Row["TenKetQuaKy2"]);

                KQHocKyTongHopInfo kqhocky1 = new KQHocKyTongHopInfo();
                kqhocky1.HocLuc        = hlky1;
                kqhocky1.KetQua        = kqky1;
                kqhocky1.HanhKiem      = hkiemky1;
                try
                {
                    kqhocky1.DTBMonHocKy = Convert.ToSingle(Row["DiemTBMonHocKy1"]);
                }
                catch
                {
                }

                KQHocKyTongHopInfo kqhocky2 = new KQHocKyTongHopInfo();
                kqhocky2.HocLuc        = hlky2;
                kqhocky2.KetQua        = kqky2;
                kqhocky2.HanhKiem      = hkiemky2;
                try
                {
                    kqhocky2.DTBMonHocKy = Convert.ToSingle(Row["DiemTBMonHocKy2"]);
                }
                catch
                {
                }

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.NamHoc       = nh;
                ketqua.HocLucCN     = hlcn;
                ketqua.HanhKiemCN   = hkiemcn;
                ketqua.KetQuaCN     = kqcn;
                ketqua.KetQuaHocKy1 = kqhocky1;
                ketqua.KetQuaHocKy2 = kqhocky2;
                try
                {
                    ketqua.DTBCaNam = Convert.ToSingle(Row["DTBCaNam"]);
                }
                catch{}
                ketqua.SoBuoiNghi   = Convert.ToInt16(Row["SoBuoiNghi"]);
                ketqua.XepThu       = Convert.ToInt16(Row["XepThu"]);

                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
