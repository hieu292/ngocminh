using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class QuyDinhCtrl
    {
        //QuyDinhData m_QuyDinhData = new QuyDinhData();

        public void HienThi(TextBox txtTenCongTy,
                            TextBox txtDiaChi,
                            TextBox txtDienThoai,
                            Label lblTaiKhoanCo,
                            NumericUpDown nudLichSaoLuu,
                            TextBox txtViTriSaoLuu,
                            Label lblThoiDiemSaoLuu,
                            RadioButton rdbBat,
                            RadioButton rdbTat)
        {
            DataTable dT = QuyDinh.LayDsQuyDinh();
            if (dT.Rows.Count == 0) return;
            int timKiemTuDong = Convert.ToInt32(dT.Rows[0]["TimKiemTuDong"]);
            if (timKiemTuDong==1)
                rdbBat.Checked = true;
            else
                rdbTat.Checked = true;
            txtTenCongTy.Text = dT.Rows[0]["TenCongTy"].ToString();
            txtDiaChi.Text = dT.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dT.Rows[0]["DienThoai"].ToString();
            lblTaiKhoanCo.Text = dT.Rows[0]["TaiKhoanCo"].ToString();
            nudLichSaoLuu.Value = Convert.ToInt32(dT.Rows[0]["LichSaoLuu"]);
            txtViTriSaoLuu.Text = dT.Rows[0]["ViTriSaoLuu"].ToString();
            lblThoiDiemSaoLuu.Text = dT.Rows[0]["ThoiDiemSaoLuuTiepTheo"].ToString();
        }

        public int CapNhatTaiKhoanCo(Int64 taiKhoanCo)
        {
            return QuyDinh.CapNhatTaiKhoanCo(taiKhoanCo);
        }

        public int CapNhatThongTinCongTy(String tenCongTy, String diaChi, String dienThoai)
        {
            return QuyDinh.CapNhatThongTinCongTy(tenCongTy, diaChi, dienThoai);
        }

        public int CapNhatThongTinSaoLuu(int lichSaoLuu, String viTriSaoLuu)
        {
            return QuyDinh.CapNhatThongTinSaoLuu(lichSaoLuu, viTriSaoLuu);
        }

        public int CapNhatTimKiemTuDong(Boolean timKiemTuDong)
        {
            return QuyDinh.CapNhatTimKiemTuDong(timKiemTuDong);
        }

        public Int64 LayTaiKhoanCo()
        {
            return QuyDinh.LayTaiKhoanCo();
        }
    }
}
