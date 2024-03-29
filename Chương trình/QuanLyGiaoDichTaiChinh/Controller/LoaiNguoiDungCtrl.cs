﻿using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.DataLayer;

namespace QuanLyGiaoDichTaiChinh.Controller
{
    public class LoaiNguoiDungCtrl
    {
        LoaiNguoiDungData m_LoaiNguoiDungData = new LoaiNguoiDungData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            comboBox.DisplayMember = "TenLoaiNguoiDung";
            comboBox.ValueMember = "MaLoaiNguoiDung";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            cmbColumn.DisplayMember = "TenLoaiNguoiDung";
            cmbColumn.ValueMember = "MaLoaiNguoiDung";
            cmbColumn.DataPropertyName = "MaLoaiNguoiDung";
            cmbColumn.HeaderText = "Nhóm người dùng";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiNguoiDungData.LayDsLoaiNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.ThemDongMoi();
        }

        public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.ThemLoaiNguoiDung(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.LuuLoaiNguoiDung();
        }
        #endregion
    }
}
