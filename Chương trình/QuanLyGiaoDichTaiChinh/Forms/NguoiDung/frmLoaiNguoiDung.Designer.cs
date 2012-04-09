namespace QuanLyGiaoDichTaiChinh
{
    partial class frmLoaiNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiNguoiDung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.dgvLoaiNguoiDung = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorLoaiNguoiDung = new System.Windows.Forms.BindingNavigator(this.components);
            this.colMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLoaiNguoiDung)).BeginInit();
            this.bindingNavigatorLoaiNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Thêm mới";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // dgvLoaiNguoiDung
            // 
            this.dgvLoaiNguoiDung.AllowUserToAddRows = false;
            this.dgvLoaiNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiNguoiDung.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoai,
            this.colTenLoaiND});
            this.dgvLoaiNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiNguoiDung.Location = new System.Drawing.Point(0, 31);
            this.dgvLoaiNguoiDung.Name = "dgvLoaiNguoiDung";
            this.dgvLoaiNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLoaiNguoiDung.Size = new System.Drawing.Size(600, 269);
            this.dgvLoaiNguoiDung.TabIndex = 72;
            this.dgvLoaiNguoiDung.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvLoaiNguoiDung_DataError);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = global::QuanLyGiaoDichTaiChinh.Properties.Resources.re;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 28);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorLoaiNguoiDung
            // 
            this.bindingNavigatorLoaiNguoiDung.AddNewItem = null;
            this.bindingNavigatorLoaiNguoiDung.AutoSize = false;
            this.bindingNavigatorLoaiNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorLoaiNguoiDung.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorLoaiNguoiDung.CountItemFormat = "của {0}";
            this.bindingNavigatorLoaiNguoiDung.DeleteItem = null;
            this.bindingNavigatorLoaiNguoiDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.bindingNavigatorRefreshItem,
            this.saveToolStripButton});
            this.bindingNavigatorLoaiNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorLoaiNguoiDung.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLoaiNguoiDung.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLoaiNguoiDung.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorLoaiNguoiDung.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorLoaiNguoiDung.Name = "bindingNavigatorLoaiNguoiDung";
            this.bindingNavigatorLoaiNguoiDung.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorLoaiNguoiDung.Size = new System.Drawing.Size(600, 31);
            this.bindingNavigatorLoaiNguoiDung.TabIndex = 71;
            this.bindingNavigatorLoaiNguoiDung.Text = "bindingNavigator1";
            // 
            // colMaLoai
            // 
            this.colMaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaLoai.DataPropertyName = "MaLoaiNguoiDung";
            this.colMaLoai.HeaderText = "Mã nhóm";
            this.colMaLoai.MaxInputLength = 6;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.ReadOnly = true;
            // 
            // colTenLoaiND
            // 
            this.colTenLoaiND.DataPropertyName = "TenLoaiNguoiDung";
            this.colTenLoaiND.FillWeight = 98.47716F;
            this.colTenLoaiND.HeaderText = "Tên nhóm";
            this.colTenLoaiND.MaxInputLength = 30;
            this.colTenLoaiND.Name = "colTenLoaiND";
            // 
            // frmLoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.dgvLoaiNguoiDung);
            this.Controls.Add(this.bindingNavigatorLoaiNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LOẠI NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.frmLoaiNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLoaiNguoiDung)).EndInit();
            this.bindingNavigatorLoaiNguoiDung.ResumeLayout(false);
            this.bindingNavigatorLoaiNguoiDung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.DataGridView dgvLoaiNguoiDung;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLoaiNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiND;
    }
}