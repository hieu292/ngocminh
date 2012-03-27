using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class GiaoVienCtrl
    {
        GiaoVienData m_GiaoVienData = new GiaoVienData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_GiaoVienData.LayDsGiaoVien("SELECT MaGiaoVien, Ho + ' ' + Ten AS HoTen FROM GIAOVIEN");
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaGiaoVien";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_GiaoVienData.LayDsGiaoVien("SELECT MaGiaoVien, Ho + ' ' + Ten AS HoTen FROM GIAOVIEN");
            cmbColumn.DisplayMember = "HoTen";
            cmbColumn.ValueMember = "MaGiaoVien";
            cmbColumn.DataPropertyName = "MaGiaoVien";
            //cmbColumn.HeaderText = "Giáo viên";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_GiaoVienData.LayDsGiaoVien();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public void HienThi(DataGridView dGV,
                            BindingNavigator bN,
                            TextBox txtMaGiaoVien,
                            TextBox txtHo,
                            TextBox txtTen,
                            DateTimePicker dtpNgaySinh,
                            TextBox txtDiaChi,
                            TextBox txtDienThoai,
                            ComboBox cmbMonHoc)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoVienData.LayDsGiaoVien();

            txtMaGiaoVien.DataBindings.Clear();
            txtMaGiaoVien.DataBindings.Add("Text", bS, "MaGiaoVien");

            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", bS, "Ho");

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bS, "Ten");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("SelectedValue", bS, "MaMonHoc");

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Lay danh sach giao vien do vao report
        public static IList<GiaoVienInfo> LayDsGiaoVienForReport(String tuKhoa)
        {
            GiaoVienData m_GVData = new GiaoVienData();
            DataTable m_DT = m_GVData.TimKiemGiaoVien(tuKhoa);

            IList<GiaoVienInfo> dS = new List<GiaoVienInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                GiaoVienInfo gv = new GiaoVienInfo();

                MonHocInfo mh = new MonHocInfo();
                mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);

                gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
                gv.Ho = Convert.ToString(Row["Ho"]);
                gv.Ten= Convert.ToString(Row["Ten"]);
                gv.DiaChi = Convert.ToString(Row["DiaChi"]);
                gv.DienThoai = Convert.ToString(Row["DienThoai"]);
                gv.MonHoc = mh;

                dS.Add(gv);
            }
            return dS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_GiaoVienData.ThemDongMoi();
        }
        

        public void ThemGiaoVien(DataRow m_Row)
        {
            m_GiaoVienData.ThemGiaoVien(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuGiaoVien()
        {
            return m_GiaoVienData.LuuGiaoVien();
        }

        public void LuuGiaoVien(String maGiaoVien, String ho, String ten, DateTime ngaySinh, String diaChi, String dienThoai, String chuyenMon)
        {
            m_GiaoVienData.LuuGiaoVien(maGiaoVien, ho, ten, ngaySinh, diaChi, dienThoai, chuyenMon);
        }
        #endregion

        #region Tìm kiem
        public void TimKiemGiaoVien(String tuKhoa,
                                   DataGridView dGV,
                                   BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(tuKhoa);

            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        //public void TimKiemGiaoVien(TextBox txtHoTen,
        //                            ComboBox cmbTheoDChi,
        //                            TextBox txtDiaChi,
        //                            ComboBox cmbTheoCMon,
        //                            ComboBox cmbCMon,
        //                            DataGridView dGV,
        //                            BindingNavigator bN)
        //{
        //    BindingSource bS = new BindingSource();
        //    bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(txtHoTen.Text, cmbTheoDChi.Text, txtDiaChi.Text, cmbTheoCMon.Text, cmbCMon.Text);

        //    bN.BindingSource = bS;
        //    dGV.DataSource = bS;
        //}

        public void TimTheoMa(String m_MaGiaoVien)
        {
            m_GiaoVienData.TimTheoMa(m_MaGiaoVien);
        }
        
        public void TimTheoTen(String m_TenGiaoVien)
        {
            m_GiaoVienData.TimTheoTen(m_TenGiaoVien);
        }
        #endregion
    }
}
