namespace QuanLyGiaoDichTaiChinh
{
    partial class frmKhoanChi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoanChi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvKhoanChi = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorKhoanChi = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            this.txtTenKC = new System.Windows.Forms.TextBox();
            this.lblMaKhoanChi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKC = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoanChi)).BeginInit();
            this.bindingNavigatorKhoanChi.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dgvKhoanChi);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigatorKhoanChi);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTenKC);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaKhoanChi);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtMaKC);
            this.splitContainer1.Panel2.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(800, 500);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvKhoanChi
            // 
            this.dgvKhoanChi.AllowUserToAddRows = false;
            this.dgvKhoanChi.AllowUserToDeleteRows = false;
            this.dgvKhoanChi.AllowUserToResizeRows = false;
            this.dgvKhoanChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanChi.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoanChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoanChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaKC,
            this.colTenKC,
            this.colGhiChu});
            this.dgvKhoanChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoanChi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvKhoanChi.Location = new System.Drawing.Point(0, 25);
            this.dgvKhoanChi.Name = "dgvKhoanChi";
            this.dgvKhoanChi.RowTemplate.Height = 25;
            this.dgvKhoanChi.Size = new System.Drawing.Size(559, 473);
            this.dgvKhoanChi.TabIndex = 1;
            this.dgvKhoanChi.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanChi_CellValueChanged);
            this.dgvKhoanChi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvKhoanChi_DataError);
            // 
            // bindingNavigatorKhoanChi
            // 
            this.bindingNavigatorKhoanChi.AddNewItem = null;
            this.bindingNavigatorKhoanChi.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorKhoanChi.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKhoanChi.CountItemFormat = "của {0}";
            this.bindingNavigatorKhoanChi.DeleteItem = null;
            this.bindingNavigatorKhoanChi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.saveToolStripButton,
            this.lblStatus});
            this.bindingNavigatorKhoanChi.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorKhoanChi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKhoanChi.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKhoanChi.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKhoanChi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKhoanChi.Name = "bindingNavigatorKhoanChi";
            this.bindingNavigatorKhoanChi.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKhoanChi.Size = new System.Drawing.Size(559, 25);
            this.bindingNavigatorKhoanChi.TabIndex = 0;
            this.bindingNavigatorKhoanChi.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Thêm mới";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = global::QuanLyGiaoDichTaiChinh.Properties.Resources.re;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 22);
            this.lblStatus.Text = "*";
            this.lblStatus.ToolTipText = "Đã thay đổi dữ liệu";
            // 
            // txtTenKC
            // 
            this.txtTenKC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKC.Location = new System.Drawing.Point(21, 100);
            this.txtTenKC.MaxLength = 100;
            this.txtTenKC.Name = "txtTenKC";
            this.txtTenKC.Size = new System.Drawing.Size(192, 23);
            this.txtTenKC.TabIndex = 3;
            // 
            // lblMaKhoanChi
            // 
            this.lblMaKhoanChi.AutoSize = true;
            this.lblMaKhoanChi.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKhoanChi.Location = new System.Drawing.Point(18, 33);
            this.lblMaKhoanChi.Name = "lblMaKhoanChi";
            this.lblMaKhoanChi.Size = new System.Drawing.Size(88, 16);
            this.lblMaKhoanChi.TabIndex = 41;
            this.lblMaKhoanChi.Text = "Mã khoản chi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tên khoản chi:";
            // 
            // txtMaKC
            // 
            this.txtMaKC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKC.Location = new System.Drawing.Point(21, 52);
            this.txtMaKC.MaxLength = 5;
            this.txtMaKC.Name = "txtMaKC";
            this.txtMaKC.ReadOnly = true;
            this.txtMaKC.Size = new System.Drawing.Size(192, 23);
            this.txtMaKC.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(21, 151);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(192, 23);
            this.txtGhiChu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ghi chú:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khoản chi";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khoản chi";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 216;
            // 
            // colMaKC
            // 
            this.colMaKC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaKC.DataPropertyName = "MaKC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colMaKC.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaKC.HeaderText = "Mã khoản chi";
            this.colMaKC.MaxInputLength = 5;
            this.colMaKC.Name = "colMaKC";
            this.colMaKC.ReadOnly = true;
            // 
            // colTenKC
            // 
            this.colTenKC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTenKC.DataPropertyName = "TenKC";
            this.colTenKC.HeaderText = "Tên khoản chi";
            this.colTenKC.MaxInputLength = 100;
            this.colTenKC.Name = "colTenKC";
            this.colTenKC.Width = 200;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MaxInputLength = 100;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // frmKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKhoanChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KHOẢN CHI";
            this.Load += new System.EventHandler(this.frmKhoanChi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKhoanChi)).EndInit();
            this.bindingNavigatorKhoanChi.ResumeLayout(false);
            this.bindingNavigatorKhoanChi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvKhoanChi;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKhoanChi;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripLabel lblStatus;
        private System.Windows.Forms.TextBox txtTenKC;
        private System.Windows.Forms.Label lblMaKhoanChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaKC;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}