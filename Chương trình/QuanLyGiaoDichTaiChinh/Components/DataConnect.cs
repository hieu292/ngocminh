using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using QuanLyGiaoDichTaiChinh.Properties;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh.Components
{
    public class DataConnect
    {
        #region Fields
        public static string m_Condition;
        public static SqlConnection m_Connection = new SqlConnection();
        public static string m_ConnectionString;
        public static string m_SqlString;
        private static bool m_ConnectionState;
        public static string databasename;
        public static string password;
        public static bool security;
        public static string servername;
        public static string username;
        #endregion

        #region  Methods

        public static bool DaKetNoi
        {
            get
            {
                return m_ConnectionState;
            }
        }

        public static bool DongKetNoi()
        {
            try
            {
                m_Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đóng kết nối.\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool HuyKetNoi()
        {
            try
            {
                m_Connection.Dispose();
                servername = "";
                databasename = "";
                username = "";
                password = "";
                security = true;
                m_ConnectionString = "";
                MessageBox.Show("Hủy kết nối thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                m_ConnectionState = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hủy kết nối." + ex.ToString(), "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public static void LayChuoiKetNoi(string tenmaychu, string tencsdl, string tennguoidung, string matkhau, bool kieuxacthuc)
        {
            try
            {
                servername = tenmaychu;
                databasename = tencsdl;
                username = tennguoidung;
                password = matkhau;
                security = kieuxacthuc;
                m_ConnectionString = "server=" + servername + ";database=" + databasename;
                if (security)
                {
                    m_ConnectionString = m_ConnectionString + ";integrated security = true";
                }
                else
                {
                    m_ConnectionString = m_ConnectionString + ";uid=" + username + ";pwd=" + password;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy file cấu hình. Vui lòng khởi động lại chương trình.\n" 
                    + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LuuChuoiKetNoi()
        {
            try
            {
                Settings.Default.Server = servername;
                Settings.Default.Database = databasename;
                Settings.Default.Username = username;
                Settings.Default.Password = Utilities.Encrypt(password,true);
                Settings.Default.Security = security;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy file cấu hình. Vui lòng khởi động lại chương trình.\n"
                    + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LuuChuoiKetNoi(object tenmaychu, object tencsdl, object tennguoidung,
            object matkhau, ref bool kieuxacthuc)
        {
            try
            {
                ((TextBox)tenmaychu).Text = servername;
                ((ComboBox)tencsdl).Text = databasename;
                ((TextBox)tennguoidung).Text = username;
                ((TextBox)matkhau).Text = password;
                kieuxacthuc = security;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể gán thông tin kết nối.\n" + ex.ToString(), "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MoKetNoi()
        {
            if (!MoLaiKetNoi())
            {
                new frmKetNoiCSDL().ShowDialog();
            }
        }

        public static bool MoLaiKetNoi()
        {
            m_Connection = new SqlConnection();
            m_Connection.ConnectionString = m_ConnectionString;
            try
            {
                m_Connection.Open();
                m_ConnectionState = true;
                return true;
            }
            catch
            {
                m_ConnectionState = false;
                return false;
            }
        }
        #endregion  
    }
}
