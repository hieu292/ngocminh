using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class TonGiaoCtrl
    {
        TonGiaoData m_TonGiaoData = new TonGiaoData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_TonGiaoData.LayDsTonGiao();
            comboBox.DisplayMember = "TenTonGiao";
            comboBox.ValueMember = "MaTonGiao";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_TonGiaoData.LayDsTonGiao();
            cmbColumn.DisplayMember = "TenTonGiao";
            cmbColumn.ValueMember = "MaTonGiao";
            cmbColumn.DataPropertyName = "MaTonGiao";
            cmbColumn.HeaderText = "Tôn giáo";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_TonGiaoData.LayDsTonGiao();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.ThemDongMoi();
        }

        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.ThemTonGiao(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuTonGiao()
        {
            return m_TonGiaoData.LuuTonGiao();
        }
        #endregion
    }
}
