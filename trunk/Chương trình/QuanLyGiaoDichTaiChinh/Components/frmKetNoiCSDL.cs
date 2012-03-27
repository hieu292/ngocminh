using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyGiaoDichTaiChinh.Components;
using QuanLyGiaoDichTaiChinh.Properties;
using System.Data.SqlClient;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frmKetNoiCSDL : Form
    {
        public frmKetNoiCSDL()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (txtTenMayChu.Text == "") 
            {
                MessageBox.Show("Bạn chưa nhập tên máy chủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMayChu.Select();
                return;
            }
            if (cboCSDL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCSDL.Select();
                return;
            }
            if (cboKieuXacThuc.Text == "Windows Authentication")
                DataConnect.LayChuoiKetNoi(txtTenMayChu.Text, cboCSDL.Text, "", "", true);
            else
            {
                if (txtTenNguoiDung.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenNguoiDung.Select();
                    return;
                }
                if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Select();
                    return;
                }
                DataConnect.LayChuoiKetNoi(txtTenMayChu.Text, cboCSDL.Text, txtTenNguoiDung.Text,
                    txtMatKhau.Text, false);
            }
            DataConnect.MoLaiKetNoi();
            if (DataConnect.DaKetNoi)
            {
                MessageBox.Show("Kết nối CSDL thành công", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                DataConnect.DongKetNoi();
                DataConnect.LuuChuoiKetNoi();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến máy chủ.", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DataConnect.LayChuoiKetNoi(Settings.Default.Server, Settings.Default.Database,
                    Settings.Default.Username, Utilities.Decrypt(Settings.Default.Password,true), Settings.Default.Security);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cboKieuXacThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKieuXacThuc.SelectedIndex == 0)
            {
                txtTenNguoiDung.Enabled = txtMatKhau.Enabled = false;
            }
            else
            {
                txtTenNguoiDung.Enabled = txtMatKhau.Enabled = true;
            }
        }

        private void frmKetNoiCSDL_Load(object sender, EventArgs e)
        {
            cboKieuXacThuc.SelectedIndex = 0;
        }

        private void frmKetNoiCSDL_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
                btnKetNoi_Click(sender, e);
             else if(e.KeyCode == Keys.Escape)
                btnHuyBo_Click(sender, e);
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            lblKQKiemTra.Visible = true;
             //Quyền Windows
            if (cboKieuXacThuc.SelectedIndex == 0)
            {
                cboCSDL.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtTenMayChu.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;
                
                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cboCSDL.Items.Add(m_DReader[0].ToString());
                    }
                    lblKQKiemTra.ForeColor = Color.Green;
                    lblKQKiemTra.Text = "Kết nối thành công!";
                }
                catch
                {
                    lblKQKiemTra.ForeColor = Color.Red;
                    lblKQKiemTra.Text = "Lỗi kết nối!";
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cboKieuXacThuc.SelectedIndex == 1)
            {
                cboCSDL.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtTenMayChu.Text +
                    ";Initial Catalog=master;User Id=" + txtTenNguoiDung.Text + ";Password=" +
                    txtMatKhau.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cboCSDL.Items.Add(m_DReader[0].ToString());
                    }
                    lblKQKiemTra.ForeColor = Color.Green;
                    lblKQKiemTra.Text = "Kết nối thành công!";
                }
                catch
                {
                    lblKQKiemTra.ForeColor = Color.Red;
                    lblKQKiemTra.Text = "Lỗi kết nối!";
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();
                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
    }
}
