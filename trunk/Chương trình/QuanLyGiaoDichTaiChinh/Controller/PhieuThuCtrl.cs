using System;
using System.Collections.Generic;
using System.Text;
using QuanLyGiaoDichTaiChinh.DataLayer;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Bussiness;
using System.Data;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    class PhieuThuCtrl
    {
        PhieuThuData m_PhieuThuData = new PhieuThuData();

        public void HienThi(DataGridView dGV, BindingNavigator bN, String tinhTrang, String soPhieu)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_PhieuThuData.TimKiemPhieuThu(tinhTrang, soPhieu);
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public int LuuPhieuThu(String maKH, DateTime ngayLap, DateTime ngayThu, int MaKT, Int64 SoTienThu, String ghiChu, Boolean tinhTrang)
        {
            return m_PhieuThuData.LuuPhieuThu(maKH, ngayLap, ngayThu, MaKT, SoTienThu, ghiChu, tinhTrang);
        }

        public int CapNhatPhieuThu(int SoPT, String maKH, DateTime ngayLap, DateTime ngayThu, int MaKT, Int64 SoTienThu, String ghiChu, Boolean tinhTrang)
        {
            return m_PhieuThuData.CapNhatPhieuThu(SoPT,maKH, ngayLap, ngayThu, MaKT, SoTienThu, ghiChu, tinhTrang);
        }

        public int XacNhanPhieuThu(int SoPT)
        {
            return m_PhieuThuData.XacNhanPhieuThu(SoPT);
        }

        public int XoaPhieuThu(int SoPT)
        {
            return m_PhieuThuData.XoaPhieuThu(SoPT);
        }
    }
}