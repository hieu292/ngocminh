using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class HocSinhCtrl
    {
        HocSinhData m_HocSinhData = new HocSinhData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_HocSinhData.LayDsHocSinh("SELECT MaHocSinh, Ho + ' ' + Ten AS HoTen FROM HOCSINH");
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public void HienThiComboBox(String lop, ComboBox comboBox)
        {
            HocSinhData m_HSData = new HocSinhData();

            comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = m_HocSinhData.LayDsHocSinh("SELECT MaHocSinh, Ho + ' ' + Ten AS HoTen FROM HOCSINH");
            cboColumn.DisplayMember = "HoTen";
            cboColumn.ValueMember = "MaHocSinh";
            cboColumn.DataPropertyName = "MaHocSinh";
            cboColumn.HeaderText = "Học sinh";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dgv, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocSinhData.LayDsHocSinh();
            bN.BindingSource = bS;
            dgv.DataSource = bS;
        }

        public void HienThi(DataGridView dgv,
                            BindingNavigator bN,
                            TextBox txtMaHocSinh,
                            TextBox txtHo,
                            TextBox txtTen,
                            RadioButton rdbNam,
                            RadioButton rdbNu,
                            DateTimePicker dtpNgaySinh,
                            TextBox txtNoiSinh,
                            TextBox txtDiaChi,
                            ComboBox cboDanToc,
                            ComboBox cboTonGiao,
                            TextBox txtHoTenCha,
                            ComboBox cboNgheNghiepCha,
                            TextBox txtHoTenMe,
                            ComboBox cboNgheNghiepMe)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinh();

            DataTable dT = (DataTable)bS.DataSource;
            string gioiTinh = dT.Rows[0]["GioiTinh"].ToString();

            if (gioiTinh == "Nam")
            {
                rdbNam.Checked = true;
                rdbNu.Checked = false;
            }
            else
            {
                rdbNu.Checked = true;
                rdbNam.Checked = false;
            }

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", bS, "MaHocSinh");

            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", bS, "Ho");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bS, "Ten");
            
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", bS, "NoiSinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            cboDanToc.DataBindings.Clear();
            cboDanToc.DataBindings.Add("SelectedValue", bS, "MaDanToc");

            cboTonGiao.DataBindings.Clear();
            cboTonGiao.DataBindings.Add("SelectedValue", bS, "MaTonGiao");

            txtHoTenCha.DataBindings.Clear();
            txtHoTenCha.DataBindings.Add("Text", bS, "HoTenCha");
            
            cboNgheNghiepCha.DataBindings.Clear();
            cboNgheNghiepCha.DataBindings.Add("SelectedValue", bS, "MaNNghiepCha");

            txtHoTenMe.DataBindings.Clear();
            txtHoTenMe.DataBindings.Add("Text", bS, "HoTenMe");

            cboNgheNghiepMe.DataBindings.Clear();
            cboNgheNghiepMe.DataBindings.Add("SelectedValue", bS, "MaNNghiepMe");

            bN.BindingSource = bS;
            dgv.DataSource = bS;
        }
        #endregion

        public void HienThiDsHocSinhTheoLop(DataGridView dgv, BindingNavigator bN, String lop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(lop);

            bN.BindingSource = bS;
            dgv.DataSource = bS;
        }

        public void HienThiDsHocSinhChuaPhanLop(DataGridView dgv)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhChuaPhanLop();
            dgv.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLopVaKetQua(DataGridView dgv, String lop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLopVaKetQua(lop);
            dgv.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLop(DataGridView dgv, String lop)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(lop);
            dgv.DataSource = bS;
        }

        public void HienThiDsHocSinhTheoLop(DataGridView dgv, String lop, String ketQua)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLopVaKetQua(lop, ketQua);
            dgv.DataSource = bS;
        }

        public void PhanLopHocSinh(String maHocSinh, String maLopMoi)
        {
            m_HocSinhData.PhanLopHocSinh(maHocSinh, maLopMoi);
        }

        #region Lay danh sach hoc sinh do vao report
        public static IList<HocSinhInfo> LayDsHocSinhForReport(String tuKhoa)
        {
            HocSinhData m_HSData = new HocSinhData();
            DataTable m_DT = m_HSData.TimKiemHocSinh(tuKhoa);

            IList<HocSinhInfo> dS = new List<HocSinhInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                HocSinhInfo hs = new HocSinhInfo();

                NgheNghiepInfo nncha   = new NgheNghiepInfo();
                nncha.TenNghe          = Convert.ToString(Row["TenNgheCha"]);

                NgheNghiepInfo nnme = new NgheNghiepInfo();
                nnme.TenNghe = Convert.ToString(Row["TenNgheMe"]);

                DanTocInfo dt       = new DanTocInfo();
                dt.TenDanToc        = Convert.ToString(Row["TenDanToc"]);

                LopInfo lop         = new LopInfo();
                lop.MaLop           = Convert.ToString(Row["MaLop"]);
                lop.TenLop          = Convert.ToString(Row["TenLop"]);

                NamHocInfo nh = new NamHocInfo();
                nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);
                lop.NamHoc = nh;

                TonGiaoInfo tg      = new TonGiaoInfo();
                tg.TenTonGiao       = Convert.ToString(Row["TenTonGiao"]);

                hs.MaHocSinh        = Convert.ToString(Row["MaHocSinh"]);
                hs.Ho               = Convert.ToString(Row["Ho"]);
                hs.Ten              = Convert.ToString(Row["Ten"]);
                hs.GioiTinh         = Convert.ToString(Row["GioiTinh"]);
                hs.NgaySinh         = Convert.ToDateTime(Row["NgaySinh"]);
                hs.NoiSinh          = Convert.ToString(Row["NoiSinh"]);
                hs.DiaChi           = Convert.ToString(Row["DiaChi"]);
                hs.DanToc           = dt;
                hs.TonGiao          = tg;
                hs.HoTenCha         = Convert.ToString(Row["HoTenCha"]);
                hs.NNghiepCha       = nncha;
                hs.HoTenMe          = Convert.ToString(Row["HoTenMe"]);
                hs.NNghiepMe        = nnme;
                hs.Lop              = lop;
                dS.Add(hs);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.ThemDongMoi();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.ThemHocSinh(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHocSinh()
        {
            return m_HocSinhData.LuuHocSinh();
        }

        public void LuuHocSinh(String maHocSinh, String ho, String ten, String gioiTinh, DateTime ngaySinh, String noiSinh,
            String diaChi, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe)
        {
            m_HocSinhData.LuuHocSinh(maHocSinh, ho, ten, gioiTinh, ngaySinh, noiSinh, diaChi, maDanToc, maTonGiao, hoTenCha, maNgheCha, hoTenMe, maNgheMe);
        }

        public void LuuHocSinh(String maHocSinh, String ho, String ten, String gioiTinh, DateTime ngaySinh, String noiSinh, String diaChi, String maDanToc, String maTonGiao, String hoTenCha, String hoTenMe)
        {
            m_HocSinhData.LuuHocSinh(maHocSinh, ho, ten, gioiTinh, ngaySinh, noiSinh, diaChi, maDanToc, maTonGiao, hoTenCha, hoTenMe);
        }
        #endregion

        #region Tim kiem
        public void TimKiemHocSinh(TextBox txtHoTen,
                                   ComboBox cboTheoNSinh,
                                   TextBox txtNoiSinh,
                                   ComboBox cboTheoDToc,
                                   ComboBox cboDanToc,
                                   ComboBox cboTheoTGiao,
                                   ComboBox cboTonGiao,
                                   DataGridView dgv,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text, cboTheoNSinh.Text, txtNoiSinh.Text, cboTheoDToc.Text, cboDanToc.Text, cboTheoTGiao.Text, cboTonGiao.Text);

            bN.BindingSource = bS;
            dgv.DataSource = bS;
        }

        public void TimKiemHocSinh(String tuKhoa,
                                   DataGridView dgv,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_HocSinhData.TimKiemHocSinh(tuKhoa);

            bN.BindingSource = bS;
            dgv.DataSource = bS;
        }

        public void TimTheoMa(String m_MaHocSinh)
        {
            m_HocSinhData.TimTheoMa(m_MaHocSinh);
        }

        public void TimTheoTen(String m_TenHocSinh)
        {
            m_HocSinhData.TimTheoTen(m_TenHocSinh);
        }
        #endregion
    }
}
