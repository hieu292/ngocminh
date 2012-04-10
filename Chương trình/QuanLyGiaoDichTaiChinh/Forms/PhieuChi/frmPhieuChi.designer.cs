namespace QuanLyGiaoDichTaiChinh
{
    partial class frmPhieuChi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuChi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.verifyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtSoPhieu = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cboStatusFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPhieuChi = new System.Windows.Forms.DataGridView();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSoPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colKhoanChi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new QuanLyGiaoDichTaiChinh.Components.CalendarColumn();
            this.colNgayChi = new QuanLyGiaoDichTaiChinh.Components.CalendarColumn();
            this.colTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionPage = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cboRecords = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cboSort = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorPage = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnNextPage = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPhieuChi = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorUpdateItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPage)).BeginInit();
            this.bindingNavigatorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhieuChi)).BeginInit();
            this.bindingNavigatorPhieuChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(56, 28);
            this.toolStripLabel3.Text = "Số phiếu:";
            // 
            // verifyToolStripButton
            // 
            this.verifyToolStripButton.AutoToolTip = false;
            this.verifyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.verifyToolStripButton.Image = global::QuanLyGiaoDichTaiChinh.Properties.Resources.check;
            this.verifyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.verifyToolStripButton.Name = "verifyToolStripButton";
            this.verifyToolStripButton.Size = new System.Drawing.Size(23, 28);
            this.verifyToolStripButton.Text = "Xác nhận";
            this.verifyToolStripButton.Click += new System.EventHandler(this.verifyToolStripButton_Click);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 31);
            this.txtSoPhieu.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "Chưa xác nhận",
            "Đã xác nhận",
            "Tất cả"});
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(121, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 28);
            this.toolStripLabel2.Text = "Tình trạng :";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 28);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.AutoToolTip = false;
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Image = global::QuanLyGiaoDichTaiChinh.Properties.Resources.search;
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(23, 28);
            this.searchToolStripButton.Text = "toolStripButton1";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // dgvPhieuChi
            // 
            this.dgvPhieuChi.AllowUserToAddRows = false;
            this.dgvPhieuChi.AllowUserToDeleteRows = false;
            this.dgvPhieuChi.AllowUserToResizeRows = false;
            this.dgvPhieuChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhieuChi.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhieuChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTinhTrang,
            this.colSoPC,
            this.colNhanVien,
            this.colKhoanChi,
            this.colSoTienChi,
            this.colNgayLap,
            this.colNgayChi,
            this.colTon,
            this.colGhiChu,
            this.colDuTru});
            this.dgvPhieuChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuChi.Location = new System.Drawing.Point(0, 31);
            this.dgvPhieuChi.Name = "dgvPhieuChi";
            this.dgvPhieuChi.ReadOnly = true;
            this.dgvPhieuChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPhieuChi.Size = new System.Drawing.Size(880, 469);
            this.dgvPhieuChi.TabIndex = 75;
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình trạng";
            this.colTinhTrang.Name = "colTinhTrang";
            this.colTinhTrang.ReadOnly = true;
            this.colTinhTrang.Width = 73;
            // 
            // colSoPC
            // 
            this.colSoPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSoPC.DataPropertyName = "SoPC";
            this.colSoPC.HeaderText = "Số phiếu chi";
            this.colSoPC.MaxInputLength = 20;
            this.colSoPC.Name = "colSoPC";
            this.colSoPC.ReadOnly = true;
            // 
            // colNhanVien
            // 
            this.colNhanVien.DataPropertyName = "MaKH";
            this.colNhanVien.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colNhanVien.HeaderText = "Tên nhân viên";
            this.colNhanVien.Name = "colNhanVien";
            this.colNhanVien.ReadOnly = true;
            this.colNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colNhanVien.Width = 114;
            // 
            // colKhoanChi
            // 
            this.colKhoanChi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colKhoanChi.HeaderText = "Lý do chi";
            this.colKhoanChi.Name = "colKhoanChi";
            this.colKhoanChi.ReadOnly = true;
            this.colKhoanChi.Width = 64;
            // 
            // colSoTienChi
            // 
            this.colSoTienChi.DataPropertyName = "SoTienChi";
            this.colSoTienChi.HeaderText = "Số tiền chi";
            this.colSoTienChi.Name = "colSoTienChi";
            this.colSoTienChi.ReadOnly = true;
            this.colSoTienChi.Width = 93;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Width = 63;
            // 
            // colNgayChi
            // 
            this.colNgayChi.DataPropertyName = "NgayChi";
            this.colNgayChi.HeaderText = "Ngày chi";
            this.colNgayChi.Name = "colNgayChi";
            this.colNgayChi.ReadOnly = true;
            this.colNgayChi.Width = 62;
            // 
            // colTon
            // 
            this.colTon.DataPropertyName = "Ton";
            this.colTon.HeaderText = "Tồn";
            this.colTon.Name = "colTon";
            this.colTon.ReadOnly = true;
            this.colTon.Visible = false;
            this.colTon.Width = 55;
            // 
            // colGhiChu
            // 
            this.colGhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // colDuTru
            // 
            this.colDuTru.DataPropertyName = "DuTru";
            this.colDuTru.HeaderText = "Dự trữ";
            this.colDuTru.Name = "colDuTru";
            this.colDuTru.ReadOnly = true;
            this.colDuTru.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDuTru.Visible = false;
            this.colDuTru.Width = 70;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Hiển thị :";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionPage
            // 
            this.bindingNavigatorPositionPage.AccessibleName = "Position";
            this.bindingNavigatorPositionPage.AutoSize = false;
            this.bindingNavigatorPositionPage.BackColor = System.Drawing.SystemColors.Window;
            this.bindingNavigatorPositionPage.Name = "bindingNavigatorPositionPage";
            this.bindingNavigatorPositionPage.ReadOnly = true;
            this.bindingNavigatorPositionPage.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionPage.Text = "0";
            this.bindingNavigatorPositionPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.AutoToolTip = false;
            this.btnPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.RightToLeftAutoMirrorImage = true;
            this.btnPreviousPage.Size = new System.Drawing.Size(23, 22);
            this.btnPreviousPage.Text = "Move previous";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cboRecords
            // 
            this.cboRecords.AutoSize = false;
            this.cboRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecords.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "40",
            "60",
            "80",
            "100"});
            this.cboRecords.Name = "cboRecords";
            this.cboRecords.Size = new System.Drawing.Size(45, 23);
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel4.Text = "Số phiếu :";
            // 
            // cboSort
            // 
            this.cboSort.AutoSize = false;
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.Items.AddRange(new object[] {
            "Giảm dần",
            "Tăng dần"});
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(80, 23);
            // 
            // bindingNavigatorPage
            // 
            this.bindingNavigatorPage.AddNewItem = null;
            this.bindingNavigatorPage.BackColor = System.Drawing.Color.Lavender;
            this.bindingNavigatorPage.CountItem = null;
            this.bindingNavigatorPage.DeleteItem = null;
            this.bindingNavigatorPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorPage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboRecords,
            this.bindingNavigatorSeparator4,
            this.toolStripLabel4,
            this.cboSort,
            this.toolStripSeparator6,
            this.btnPreviousPage,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionPage,
            this.bindingNavigatorSeparator5,
            this.btnNextPage});
            this.bindingNavigatorPage.Location = new System.Drawing.Point(0, 475);
            this.bindingNavigatorPage.MoveFirstItem = null;
            this.bindingNavigatorPage.MoveLastItem = null;
            this.bindingNavigatorPage.MoveNextItem = null;
            this.bindingNavigatorPage.MovePreviousItem = null;
            this.bindingNavigatorPage.Name = "bindingNavigatorPage";
            this.bindingNavigatorPage.PositionItem = null;
            this.bindingNavigatorPage.Size = new System.Drawing.Size(880, 25);
            this.bindingNavigatorPage.TabIndex = 77;
            this.bindingNavigatorPage.Text = "bindingNavigator1";
            this.bindingNavigatorPage.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.AutoToolTip = false;
            this.btnNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeftAutoMirrorImage = true;
            this.btnNextPage.Size = new System.Drawing.Size(23, 22);
            this.btnNextPage.Text = "Move next";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorPhieuChi
            // 
            this.bindingNavigatorPhieuChi.AddNewItem = null;
            this.bindingNavigatorPhieuChi.AutoSize = false;
            this.bindingNavigatorPhieuChi.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorPhieuChi.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPhieuChi.CountItemFormat = "của {0}";
            this.bindingNavigatorPhieuChi.DeleteItem = null;
            this.bindingNavigatorPhieuChi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorUpdateItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.verifyToolStripButton,
            this.toolStripSeparator5,
            this.printToolStripButton,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.cboStatusFilter,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.txtSoPhieu,
            this.toolStripSeparator3,
            this.searchToolStripButton});
            this.bindingNavigatorPhieuChi.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPhieuChi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPhieuChi.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPhieuChi.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPhieuChi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPhieuChi.Name = "bindingNavigatorPhieuChi";
            this.bindingNavigatorPhieuChi.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPhieuChi.Size = new System.Drawing.Size(880, 31);
            this.bindingNavigatorPhieuChi.TabIndex = 76;
            this.bindingNavigatorPhieuChi.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 28);
            this.bindingNavigatorCountItem.Text = "của {0}";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Thêm mới";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorUpdateItem
            // 
            this.bindingNavigatorUpdateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorUpdateItem.Image = global::QuanLyGiaoDichTaiChinh.Properties.Resources.update;
            this.bindingNavigatorUpdateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorUpdateItem.Name = "bindingNavigatorUpdateItem";
            this.bindingNavigatorUpdateItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorUpdateItem.Text = "Sửa";
            this.bindingNavigatorUpdateItem.Click += new System.EventHandler(this.bindingNavigatorUpdateItem_Click);
            // 
            // frmPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.dgvPhieuChi);
            this.Controls.Add(this.bindingNavigatorPage);
            this.Controls.Add(this.bindingNavigatorPhieuChi);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHIẾU CHI";
            this.Load += new System.EventHandler(this.frmPhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPage)).EndInit();
            this.bindingNavigatorPage.ResumeLayout(false);
            this.bindingNavigatorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhieuChi)).EndInit();
            this.bindingNavigatorPhieuChi.ResumeLayout(false);
            this.bindingNavigatorPhieuChi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton verifyToolStripButton;
        private System.Windows.Forms.ToolStripTextBox txtSoPhieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox cboStatusFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView dgvPhieuChi;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPreviousPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox cboRecords;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cboSort;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPage;
        private System.Windows.Forms.ToolStripButton btnNextPage;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPhieuChi;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorUpdateItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoPC;
        private System.Windows.Forms.DataGridViewComboBoxColumn colNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn colKhoanChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienChi;
        private QuanLyGiaoDichTaiChinh.Components.CalendarColumn colNgayLap;
        private QuanLyGiaoDichTaiChinh.Components.CalendarColumn colNgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuTru;
    }
}