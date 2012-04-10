using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class PhieuChiCtrl
    {
        PhieuChiData m_PhieuChiData = new PhieuChiData();

        public void HienThi(DataGridView dGV, BindingNavigator bN, String tinhTrang, String soPhieu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PhieuChiData.TimKiemPhieuChi(tinhTrang, soPhieu);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public int LuuPhieuChi(String MaNV, DateTime ngayLap, DateTime ngayChi, int MaKC, Int64 SoTienChi, String ghiChu, Boolean tinhTrang)
        {
            return m_PhieuChiData.LuuPhieuChi(MaNV, ngayLap, ngayChi, MaKC, SoTienChi, ghiChu, tinhTrang);
        }

        public int CapNhatPhieuChi(int SoPC, String MaNV, DateTime ngayLap, DateTime ngayChi, int MaKC, Int64 SoTienChi, String ghiChu, Boolean tinhTrang)
        {
            return m_PhieuChiData.CapNhatPhieuChi(SoPC,MaNV, ngayLap, ngayChi, MaKC, SoTienChi, ghiChu, tinhTrang);
        }

        public int XacNhanPhieuChi(int SoPC)
        {
            return m_PhieuChiData.XacNhanPhieuChi(SoPC);
        }

        public int XoaPhieuChi(int SoPC)
        {
            return m_PhieuChiData.XoaPhieuChi(SoPC);
        }
    }
}