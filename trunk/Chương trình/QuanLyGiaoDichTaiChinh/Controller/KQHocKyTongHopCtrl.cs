using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLyGiaoDichTaiChinh.Bussiness;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class KQHocKyTongHopCtrl
    {
        #region Fields
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        KQHocKyTongHopData  m_KQHocKyTongHopData    = new KQHocKyTongHopData();
        #endregion
        #region Hiển thị

        public void HienThi(DataGridView dGV, BindingNavigator bN, String maLop, String maHocKy, String maNamHoc)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KQHocKyTongHopData.LayDsKQHocKyTongHop(maLop, maHocKy, maNamHoc);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
        #region Luu ket qua

         public String XepLoaiKetQuaHocKy(String maHocLuc, String maHanhKiem)
        {
            if (maHocLuc == "HL0001" && maHanhKiem == "HK0001")
                return "KQ0005";
            if (maHocLuc == "HL0002" && (maHanhKiem == "HK0001" || maHanhKiem == "HK0002"))
                return "KQ0006";
            return "KQ0007";
        }

        public void LuuKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            KQHocKyTongHopData m_KQHKTHData = new KQHocKyTongHopData();
            float diemTBChungCacMonHK = m_DiemCtrl.DiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, maHocKy, maNamHoc);
            String maHocLuc = m_HocLucCtrl.XepLoaiHocLucHocKy(maHocSinh, maLop, maHocKy, maNamHoc);
            DataTable m_DT = m_KQHKTHData.LayKQHocKyTongHop(maHocSinh, maLop, maHocKy, maNamHoc);
            String maHanhKiem = "HK0001";
            if (m_DT.Rows.Count > 0)
                maHanhKiem = m_DT.Rows[0]["MaHanhKiem"].ToString();
            String maKetQua = XepLoaiKetQuaHocKy(maHocLuc, maHanhKiem);

            m_KQHKTHData.XoaKetQua(maHocSinh, maLop, maHocKy, maNamHoc);

            m_KQHocKyTongHopData.LuuKetQua(maHocSinh, maLop, maHocKy, maNamHoc, diemTBChungCacMonHK, maHocLuc, maHanhKiem, maKetQua);
        }

        public void CapNhatKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc, String maHanhKiem)
        {
            KQHocKyTongHopData m_KQHKTHData = new KQHocKyTongHopData();
            DataTable m_DT = m_KQHKTHData.LayKQHocKyTongHop(maHocSinh, maLop, maHocKy, maNamHoc);
            if (m_DT.Rows.Count == 0) return;
            String maKetQua = XepLoaiKetQuaHocKy(m_DT.Rows[0]["MaHocLuc"].ToString(), maHanhKiem);
            m_KQHocKyTongHopData.CapNhatKetQua(maHocSinh, maLop, maHocKy, maNamHoc, maHanhKiem, maKetQua);
        }
        #endregion

        #region Lay danh sach ket qua hoc ky tong hop do vao report
        public static IList<KQHocKyTongHopInfo> LayDsKQHocKyTongHop(String maLop, String maHocKy, String maNamHoc)
        {
            KQHocKyTongHopData m_KQHKTHData = new KQHocKyTongHopData();
            DataTable m_DT = m_KQHKTHData.LayDsKQHocKyTongHopForReport(maLop, maHocKy, maNamHoc);

            IList<KQHocKyTongHopInfo> dS = new List<KQHocKyTongHopInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQHocKyTongHopInfo ketqua = new KQHocKyTongHopInfo();

                HocSinhInfo hs      = new HocSinhInfo();
                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.Ho               = Convert.ToString(Row["Ho"]);
                hs.Ten              = Convert.ToString(Row["Ten"]);

                LopInfo l           = new LopInfo();
                l.MaLop             = Convert.ToString(Row["MaLop"]);
                l.TenLop            = Convert.ToString(Row["TenLop"]);

                HocKyInfo hk        = new HocKyInfo();
                hk.MaHocKy          = Convert.ToString(Row["MaHocKy"]);
                hk.TenHocKy         = Convert.ToString(Row["TenHocKy"]);

                NamHocInfo nh       = new NamHocInfo();
                nh.MaNamHoc         = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc        = Convert.ToString(Row["TenNamHoc"]);

                HocLucInfo hl       = new HocLucInfo();
                hl.MaHocLuc         = Convert.ToString(Row["MaHocLuc"]);
                hl.TenHocLuc        = Convert.ToString(Row["TenHocLuc"]);

                HanhKiemInfo hkiem  = new HanhKiemInfo();
                hkiem.MaHanhKiem    = Convert.ToString(Row["MaHanhKiem"]);
                hkiem.TenHanhKiem   = Convert.ToString(Row["TenHanhKiem"]);

                KetQuaInfo kq       = new KetQuaInfo();
                kq.MaKetQua         = Convert.ToString(Row["MaKetQua"]);
                kq.TenKetQua        = Convert.ToString(Row["TenKetQua"]);

                ketqua.HocSinh      = hs;
                ketqua.Lop          = l;
                ketqua.HocKy        = hk;
                ketqua.NamHoc       = nh;
                ketqua.HocLuc       = hl;
                ketqua.HanhKiem     = hkiem;
                ketqua.DTBMonHocKy  = Convert.ToSingle(Row["DTBMonHocKy"]);
                ketqua.KetQua       = kq;
                ketqua.XepThu       = Convert.ToInt16(Row["XepThu"]);

                dS.Add(ketqua);
            }
            return dS;
        }
        #endregion
    }
}
