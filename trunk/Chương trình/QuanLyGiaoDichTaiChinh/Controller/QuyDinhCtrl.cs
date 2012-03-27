using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class QuyDinhCtrl
    {
        QuyDinhData m_QuyDinhData = new QuyDinhData();

        public void HienThi(NumericUpDown nudSiSoCanDuoi,
                            NumericUpDown nudSiSoCanTren,
                            NumericUpDown nudDoTuoiCanDuoi,
                            NumericUpDown nudDoTuoiCanTren,
                            RadioButton rdbThangDiem10,
                            RadioButton rdbThangDiem100,
                            TextBox txtTenTruong,
                            TextBox txtDiaChiTruong)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_QuyDinhData.LayDsQuyDinh();

            DataTable dT = m_QuyDinhData.LayDsQuyDinh();
            if (dT.Rows.Count == 0) return;
            int thangDiem = Convert.ToInt32(dT.Rows[0]["ThangDiem"]);
            if (thangDiem == 10)
                rdbThangDiem10.Checked = true;
            else
                rdbThangDiem100.Checked = true;

            nudSiSoCanDuoi.DataBindings.Clear();
            nudSiSoCanDuoi.DataBindings.Add("Value", bS, "SiSoCanDuoi");

            nudSiSoCanTren.DataBindings.Clear();
            nudSiSoCanTren.DataBindings.Add("Value", bS, "SiSoCanTren");

            nudDoTuoiCanDuoi.DataBindings.Clear();
            nudDoTuoiCanDuoi.DataBindings.Add("Value", bS, "TuoiCanDuoi");

            nudDoTuoiCanTren.DataBindings.Clear();
            nudDoTuoiCanTren.DataBindings.Add("Value", bS, "TuoiCanTren");

            txtTenTruong.DataBindings.Clear();
            txtTenTruong.DataBindings.Add("Text", bS, "TenTruong");

            txtDiaChiTruong.DataBindings.Clear();
            txtDiaChiTruong.DataBindings.Add("Text", bS, "DiaChiTruong");
        }

        public int CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            return m_QuyDinhData.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public int CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            return m_QuyDinhData.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public int CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            return m_QuyDinhData.CapNhatQuyDinhTruong(tenTruong, diaChiTruong);
        }

        public int CapNhatQuyDinhThangDiem(int thangDiem)
        {
            return m_QuyDinhData.CapNhatQuyDinhThangDiem(thangDiem);
        }
    }
}
