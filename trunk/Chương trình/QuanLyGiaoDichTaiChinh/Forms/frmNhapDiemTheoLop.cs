using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Controller;
using QuanLyGiaoDichTaiChinh.DataLayer;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmNhapDiemTheoLop : Form
    {
        
        #region Fields
        NamHocCtrl          m_NamHocCtrl            = new NamHocCtrl();
        LopCtrl             m_LopCtrl               = new LopCtrl();
        HocKyCtrl           m_HocKyCtrl             = new HocKyCtrl();
        MonHocCtrl          m_MonHocCtrl            = new MonHocCtrl();
        DiemCtrl            m_DiemCtrl              = new DiemCtrl();
        LoaiDiemCtrl        m_LoaiDiemCtrl          = new LoaiDiemCtrl();
        HocSinhCtrl         m_HocSinhCtrl           = new HocSinhCtrl();
        KQHocKyMonHocCtrl   m_KQHocKyMonHocCtrl     = new KQHocKyMonHocCtrl();
        KQHocKyTongHopCtrl  m_KQHocKyTongHopCtrl    = new KQHocKyTongHopCtrl();
        KQCaNamMonHocCtrl   m_KQCaNamMonHocCtrl     = new KQCaNamMonHocCtrl();
        KQCaNamTongHopCtrl  m_KQCaNamTongHopCtrl    = new KQCaNamTongHopCtrl();

        DiemData            m_DiemData              = new DiemData();
        QuyDinh             quyDinh                 = new QuyDinh();
        int[,] STT = null;
        #endregion

        #region Constructor
        public frmNhapDiemTheoLop()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmNhapDiemTheoLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cboNamHoc);
            m_HocKyCtrl.HienThiComboBox(cboHocKy);
            if (cboNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);

            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
        }
        #endregion

        #region BindingNavigatorItems
        #region Kiểm tra điểm số trước khi lưu
        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dgvDiem.Rows)
            {
                if (row.Cells[loaiDiem].Value != null && row.Cells[loaiDiem].Value.ToString() != "")
                {
                    String[] chuoiDiem = row.Cells[loaiDiem].Value.ToString().Split(';');
                    for (int i = 0; i < chuoiDiem.Length; i++ )
                        if (quyDinh.KiemTraDiem(chuoiDiem[i]) == false)
                        {
                            MessageBox.Show(dgvDiem.Columns[loaiDiem].HeaderText + " của học sinh " + row.Cells["colHoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                }
            }
            return true;
        }
        #endregion

        #region Lưu điểm
        private void LuuDiem(DataGridViewRow row)
        {
            #region Kiểm tra miệng
            if (row.Cells["colDiemMieng"].Value != null)
            {
                String[] chuoiDiem = row.Cells["colDiemMieng"].Value.ToString().Split(';');
                for (int i = 0; i < chuoiDiem.Length; i++)
                {
                    if (chuoiDiem[i] != null && chuoiDiem[i] != " " && quyDinh.KiemTraDiem(chuoiDiem[i]))
                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                           cboMonHoc.SelectedValue.ToString(),
                                           cboHocKy.SelectedValue.ToString(),
                                           cboNamHoc.SelectedValue.ToString(),
                                           cboLop.SelectedValue.ToString(),
                                           "LD0001",
                                           float.Parse(chuoiDiem[i].ToString()));
                }
            }
            #endregion

            #region Kiểm tra 15 phút
            if (row.Cells["colDiem15Phut"].Value != null)
            {
                String[] chuoiDiem = row.Cells["colDiem15Phut"].Value.ToString().Split(';');
                for (int i = 0; i < chuoiDiem.Length; i++)
                {
                    if (chuoiDiem[i] != null && chuoiDiem[i] != " " && quyDinh.KiemTraDiem(chuoiDiem[i]))
                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                           cboMonHoc.SelectedValue.ToString(),
                                           cboHocKy.SelectedValue.ToString(),
                                           cboNamHoc.SelectedValue.ToString(),
                                           cboLop.SelectedValue.ToString(),
                                           "LD0002",
                                           float.Parse(chuoiDiem[i].ToString()));
                }
            }
            #endregion

            #region Kiểm tra 1 tiet
            if (row.Cells["colDiem1Tiet"].Value != null)
            {
                String[] chuoiDiem = row.Cells["colDiem1Tiet"].Value.ToString().Split(';');
                for (int i = 0; i < chuoiDiem.Length; i++)
                {
                    if (chuoiDiem[i] != null && chuoiDiem[i] != " " && quyDinh.KiemTraDiem(chuoiDiem[i]))
                        m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                           cboMonHoc.SelectedValue.ToString(),
                                           cboHocKy.SelectedValue.ToString(),
                                           cboNamHoc.SelectedValue.ToString(),
                                           cboLop.SelectedValue.ToString(),
                                           "LD0003",
                                           float.Parse(chuoiDiem[i].ToString()));
                }
            }
            #endregion

            #region Thi học kỳ
            if (row.Cells["colDiemHocKy"].Value != null)
            {
                String diemHocKy = row.Cells["colDiemHocKy"].Value.ToString();
                if (quyDinh.KiemTraDiem(diemHocKy))
                    m_DiemCtrl.LuuDiem(row.Cells["colMaHocSinh"].Value.ToString(),
                                               cboMonHoc.SelectedValue.ToString(),
                                               cboHocKy.SelectedValue.ToString(),
                                               cboNamHoc.SelectedValue.ToString(),
                                               cboLop.SelectedValue.ToString(),
                                               "LD0004",
                                               float.Parse(diemHocKy.ToString()));
            }
            #endregion

            #region Lưu vào bảng kết quả
            m_KQHocKyMonHocCtrl.LuuKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                          cboLop.SelectedValue.ToString(),
                                          cboMonHoc.SelectedValue.ToString(),
                                          cboHocKy.SelectedValue.ToString(),
                                          cboNamHoc.SelectedValue.ToString());

            m_KQCaNamMonHocCtrl.LuuKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                          cboLop.SelectedValue.ToString(),
                                          cboMonHoc.SelectedValue.ToString(),
                                          cboNamHoc.SelectedValue.ToString());

            m_KQHocKyTongHopCtrl.LuuKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                           cboLop.SelectedValue.ToString(),
                                           cboHocKy.SelectedValue.ToString(),
                                           cboNamHoc.SelectedValue.ToString());

            m_KQCaNamTongHopCtrl.LuuKetQua(row.Cells["colMaHocSinh"].Value.ToString(),
                                           cboLop.SelectedValue.ToString(),
                                           cboNamHoc.SelectedValue.ToString());
            #endregion

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (KiemTraDiemTruocKhiLuu("colDiemMieng") == true &&
                KiemTraDiemTruocKhiLuu("colDiem15Phut") == true &&
                KiemTraDiemTruocKhiLuu("colDiem1Tiet") == true &&
                KiemTraDiemTruocKhiLuu("colDiemHocKy") == true)
            {
                bindingNavigatorPositionItem.Focus();
                #region Nếu nhập điểm
                if (rdbNhapDiem.Checked == true)
                {
                    foreach (DataGridViewRow row in dgvDiem.Rows)
                    {
                        LuuDiem(row);
                    }
                    MessageBox.Show("Đã lưu thành công vào bảng điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
                #region Nếu sửa điểm
                if (rdbSuaDiem.Checked == true)
                {
                    foreach (DataGridViewRow row in dgvDiem.Rows)
                    {
                        LuuDiem(row);
                    }
                    #region Xóa các kết quả cũ
                    if (STT != null)
                    {
                        for (int i = 1; i < 60; i++)
                            for (int j = 1; j < 40; j++)
                            {
                                int id = STT[i, j];
                                if (id > 0)
                                    m_DiemCtrl.XoaDiem(id);
                                else
                                    break;
                            }
                    }
                    #endregion
                    MessageBox.Show("Cập nhật thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }
        }
        #endregion
        #endregion

        #region DataError event
        private void dgvNhapDiemTheoLop_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        #region SelectedIndexChanged event
        //Lấy thông tin lớp theo từng năm học
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox(cboNamHoc.SelectedValue.ToString(), cboLop);
                cboLop_SelectedIndexChanged(sender, e);
            }
        }

        //Lấy môn học theo từng lớp
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cboLop.SelectedValue.ToString(), cboMonHoc);
            if (cboMonHoc.Items.Count == 0)
                rdbNhapDiem_CheckedChanged(sender, e);
            else
                cboMonHoc_SelectedIndexChanged(sender, e);
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHocKy_SelectedIndexChanged(sender, e);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbNhapDiem_CheckedChanged(sender, e);
        }

        private void rdbNhapDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cboMonHoc.Items.Count > 0 && cboHocKy.SelectedValue != null)
            {
                if (rdbNhapDiem.Checked)
                {
                    if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboHocKy.SelectedValue != null && cboMonHoc.SelectedValue != null)
                        m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dgvDiem, bindingNavigatorDiem, cboLop.SelectedValue.ToString());
                }
                else
                {
                    STT = new int[60, 40];

                    if (cboNamHoc.SelectedValue != null && cboLop.SelectedValue != null && cboHocKy.SelectedValue != null && cboMonHoc.SelectedValue != null)
                        m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dgvDiem, bindingNavigatorDiem, cboLop.SelectedValue.ToString());

                    int countRowHocSinh = 0;
                    foreach (DataGridViewRow rowHocSinh in dgvDiem.Rows)
                    {
                        countRowHocSinh++;

                        String[] diemMieng = new String[20];
                        String[] diem15Phut = new String[20];
                        String[] diem1Tiet = new String[20];
                        String diemThi = "";

                        int soDiemMieng = 0;
                        int soDiem15Phut = 0;
                        int soDiem1Tiet = 0;

                        DataTable m_DT = m_DiemData.LayDsDiem(rowHocSinh.Cells["colMaHocSinh"].Value.ToString(),
                                                              cboMonHoc.SelectedValue.ToString(),
                                                              cboHocKy.SelectedValue.ToString(),
                                                              cboNamHoc.SelectedValue.ToString(),
                                                              cboLop.SelectedValue.ToString());

                        int countRowDiem = 0;
                        foreach (DataRow rowDiem in m_DT.Rows)
                        {
                            countRowDiem++;

                            STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());

                            if (rowDiem["MaLoai"].ToString() == "LD0001")
                                diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();

                            else if (rowDiem["MaLoai"].ToString() == "LD0002")
                                diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();

                            else if (rowDiem["MaLoai"].ToString() == "LD0003")
                                diem1Tiet[soDiem1Tiet++] = rowDiem["Diem"].ToString();

                            else if (rowDiem["MaLoai"].ToString() == "LD0004")
                                diemThi = rowDiem["Diem"].ToString();
                        }

                        rowHocSinh.Cells["colDiemMieng"].Value = quyDinh.ArrayToString(diemMieng, soDiemMieng);
                        rowHocSinh.Cells["colDiem15Phut"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                        rowHocSinh.Cells["colDiem1Tiet"].Value = quyDinh.ArrayToString(diem1Tiet, soDiem1Tiet);
                        rowHocSinh.Cells["colDiemHocKy"].Value = diemThi;
                    }
                }
            }
            else
            {
                for (int i = dgvDiem.RowCount; i > 0; i--)
                    dgvDiem.Rows.RemoveAt(i - 1);
            }
        }

        private void rdbSuaDiem_CheckedChanged(object sender, EventArgs e)
        {
            rdbNhapDiem_CheckedChanged(sender, e);
        }

        #endregion
    }
}
