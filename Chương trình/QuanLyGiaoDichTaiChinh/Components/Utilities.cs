﻿using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using QuanLyGiaoDichTaiChinh.Bussiness;

namespace QuanLyGiaoDichTaiChinh.Components
{
    #region Utilities
    public static class Utilities
    {
        public static NguoiDungInfo NguoiDung;

        public static Boolean KiemTraTruocKhiLuu(DataGridView datagridview, String strCheckCellName)
        {
            foreach (DataGridViewRow row in datagridview.Rows)
            {
                if (row.Cells[strCheckCellName].Value != null)
                {
                    String str = row.Cells[strCheckCellName].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin " + datagridview.Columns[strCheckCellName].HeaderText + " tại hàng số " + (int)(row.Index + 1)
                            + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public static string Encrypt(string toEncrypt, bool useHashing)
        {
            String key = "minhngoc";
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string toDecrypt, bool useHashing)
        {
            String key = "minhngoc";
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int LaySoPhieuTruoc(int maLoaiPhieu)
        {
            DataService dS = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 SoPhieuTruoc FROM LoaiPhieu WHERE MaLoaiPhieu = @maLoaiPhieu");
            cmd.Parameters.Add("maLoaiPhieu", SqlDbType.Int).Value = maLoaiPhieu;
            return (int)dS.ExecuteScalar(cmd);
        }

        public static Boolean BackupDatabase()
        {
            return false;
        }

        public static Boolean RestoreDatabase()
        {
            return true;
        }
    }
    #endregion

    #region QuyDinh
    public static class QuyDinh
    {
        public static String LayViTriSaoLuuMacDinh()
        {
            DataService dS = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 ViTriSaoLuu FROM QuyDinh");
            return dS.ExecuteScalar(cmd).ToString();
        }

        public static DateTime LayThoiDiemSaoLuuTiepTheo()
        {
            DataService dS = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 ThoiDiemSaoLuuTiepTheo FROM QuyDinh");
            return (DateTime)dS.ExecuteScalar(cmd);
        }

        public static QuyDinhInfo LayThongTinTruong()
        {
            QuyDinhInfo m_Truong = new QuyDinhInfo();
            DataService dS = new DataService();

            dS.Load(new SqlCommand("SELECT TenTruong, DiaChiTruong FROM QUYDINH"));

            if (dS.Rows.Count > 0)
            {
                m_Truong.TenTruong = dS.Rows[0]["TenTruong"].ToString();
                m_Truong.DiaChiTruong = dS.Rows[0]["DiaChiTruong"].ToString();
            }

            return m_Truong;
        }
 
        public static DataTable LayDsQuyDinh()
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUYDINH");
            m_QuyDinhData.Load(cmd);
            return m_QuyDinhData;
        }

        public static Int64 LayTaiKhoanCo()
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 TaiKhoanCo FROM QUYDINH");
            return Convert.ToInt64(m_QuyDinhData.ExecuteScalar(cmd));
        }

        public static int CapNhatTaiKhoanCo(Int64 taiKhoanCo)
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TaiKhoanCo = TaiKhoanCo + @taiKhoanCo");
            cmd.Parameters.Add("taiKhoanCo", SqlDbType.BigInt).Value = taiKhoanCo;

            return m_QuyDinhData.Load(cmd);
        }

        public static int CapNhatThongTinSaoLuu(int lichSaoLuu, String viTriSaoLuu)
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET LichSaoLuu = @lichSaoLuu, ThoiDiemSaoLuuTiepTheo = dateadd(dd, @lichSaoLuu, getdate()), viTriSaoLuu = @viTriSaoLuu");
            cmd.Parameters.Add("lichSaoLuu", SqlDbType.Int).Value = lichSaoLuu;
            cmd.Parameters.Add("viTriSaoLuu", SqlDbType.VarChar).Value = viTriSaoLuu;

            return m_QuyDinhData.Load(cmd);
        }

        public static int CapNhatThongTinCongTy(String tenTenCongTy, String diaChi, String dienThoai)
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TenCongTy = @tenCongTy, DiaChi = @diaChi, DienThoai = @dienThoai");
            cmd.Parameters.Add("tenCongTy", SqlDbType.NVarChar).Value = tenTenCongTy;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.NVarChar).Value = dienThoai;

            return m_QuyDinhData.Load(cmd);
        }

        public static int CapNhatTimKiemTuDong(Boolean timKiemTuDong)
        {
            DataService m_QuyDinhData = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TimKiemTuDong= @timKiemTuDong");
            cmd.Parameters.Add("timKiemTuDong", SqlDbType.Bit).Value = timKiemTuDong;

            return m_QuyDinhData.Load(cmd);
        }

        public static String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public static Boolean KiemTraDiem(String diemSo)
        {
            IList<String> gioiHanDiem = new List<String>();

            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT ThangDiem FROM QUYDINH"));

            int thangDiem = Convert.ToInt32(dS.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diemSo) == true)
                    return true;
                else
                    return false;
            }
        }

        public static Boolean KiemTraSiSo(int siSo)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH"));

            int siSoMin = Convert.ToInt32(dS.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dS.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax)
                return true;
            else
                return false;
        }

        public static Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));

            int doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);

            int doTuoi    = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
        }

        public static String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }
    }
    #endregion
}