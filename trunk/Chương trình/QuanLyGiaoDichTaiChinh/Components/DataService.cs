using System;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyGiaoDichTaiChinh.Components;

namespace QuanLyGiaoDichTaiChinh
{
    partial class DataService : DataTable
    {
        #region Fields
        //private static  SqlConnection   m_Connection;
        //public static   String          m_ConnectString = "";
        private         SqlCommand      m_Command;
        private         SqlDataAdapter  m_DataAdapter;
        #endregion

        #region Constructor
        public DataService()
        {

        }
        #endregion

        #region Load
        public int Load(SqlCommand m_Sql)
        {
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi == false) return 0;
            int result = 0;
            m_Command = m_Sql;
            try
            {
                m_Command.Connection = DataConnect.m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                result = m_DataAdapter.Fill(this);
            }
            catch //(Exception e)
            {
                //MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                DataConnect.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Update DataTable
        public int ExecuteNoneQuery()
        {
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi == false) return 0;
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = DataConnect.m_Connection.BeginTransaction();

                m_Command.Connection = DataConnect.m_Connection;
                m_Command.Transaction = m_SqlTran;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
            }
            finally
            {
                DataConnect.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Thực thi câu lệnh SQL
        public int ExecuteNoneQuery(SqlCommand m_Sql)
        {
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi == false) return 0;
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = DataConnect.m_Connection.BeginTransaction();

                m_Sql.Connection = DataConnect.m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteNonQuery();

                this.AcceptChanges();
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                //throw;
            }
            finally
            {
                DataConnect.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region ExecuteScalar
        public object ExecuteScalar(SqlCommand m_Sql)
        {
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi == false) return new object();
            object result = null;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = DataConnect.m_Connection.BeginTransaction();
                m_Sql.Connection = DataConnect.m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteScalar();

                this.AcceptChanges();
                m_SqlTran.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                //throw;
            }
            finally
            {
                DataConnect.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Đổi mật khẩu, thiết lập lại kết nối
        public int ChangePassword(String userName, String newPassword)
        {
            DataConnect.MoKetNoi();
            if (DataConnect.DaKetNoi == false) return 0;
            int result = 0;
            m_DataAdapter = new SqlDataAdapter();
            
            SqlCommand cmd = new SqlCommand("UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDNhap = @tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = newPassword;

            m_Command = new SqlCommand();
            m_Command = cmd;

            try
            {
                m_Command.Connection = DataConnect.m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //this.Clear();

                m_DataAdapter.Fill(this);

                SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
                result = m_DataAdapter.Update(this);
            }
            catch
            {
                //MessageBox.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                DataConnect.DongKetNoi();
            }
            return result;
        }
        #endregion
    }
}