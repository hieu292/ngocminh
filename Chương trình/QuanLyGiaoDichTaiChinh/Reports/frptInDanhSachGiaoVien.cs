using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frptInDanhSachGiaoVien : Form
    {
        public frptInDanhSachGiaoVien()
        {
            InitializeComponent();
        }

        private void frmInDanhSachGiaoVien_Load(object sender, EventArgs e)
        {

            this.reportViewerDSGV.RefreshReport();
        }
    }
}
