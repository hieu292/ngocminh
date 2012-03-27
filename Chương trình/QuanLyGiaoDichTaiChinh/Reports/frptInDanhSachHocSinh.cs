using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frptInDanhSachHocSinh : Form
    {
        public frptInDanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void frptInDanhSachHocSinh_Load(object sender, EventArgs e)
        {

            this.reportViewerDSHS.RefreshReport();
        }
    }
}
