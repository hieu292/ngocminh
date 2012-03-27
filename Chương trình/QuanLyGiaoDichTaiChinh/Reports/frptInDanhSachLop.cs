using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyGiaoDichTaiChinh
{
    public partial class frptInDanhSachLop : Form
    {
        public frptInDanhSachLop()
        {
            InitializeComponent();
        }

        private void frptInDanhSachLop_Load(object sender, EventArgs e)
        {

            this.reportViewerDSLop.RefreshReport();
        }
    }
}
