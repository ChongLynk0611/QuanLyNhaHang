namespace NhaHang
{
    partial class TonKho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchLookUpEdit2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNL = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataNL = new System.Windows.Forms.DataGridView();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_NguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // searchLookUpEdit2
            // 
            this.searchLookUpEdit2.Location = new System.Drawing.Point(143, 22);
            this.searchLookUpEdit2.Name = "searchLookUpEdit2";
            this.searchLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit2.Properties.PopupView = this.gridView2;
            this.searchLookUpEdit2.Size = new System.Drawing.Size(263, 20);
            this.searchLookUpEdit2.TabIndex = 1;
            this.searchLookUpEdit2.EditValueChanged += new System.EventHandler(this.searchLookUpEdit2_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(74, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 16);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Tìm Kiếm :";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(120, 35);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(264, 20);
            this.txtMaNL.TabIndex = 10;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(120, 73);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(264, 20);
            this.txtTenNL.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(27, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(83, 13);
            this.labelControl10.TabIndex = 6;
            this.labelControl10.Text = "Mã Nguyên Liệu :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(27, 76);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Tên Nguyên Liệu :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Số Lượng Tồn :";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(120, 111);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(187, 20);
            this.txtSL.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 152);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Đơn vị :";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(120, 149);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(117, 20);
            this.txtDonVi.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtDonVi);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtSL);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtTenNL);
            this.groupControl2.Controls.Add(this.txtMaNL);
            this.groupControl2.Location = new System.Drawing.Point(532, 61);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(467, 199);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Thông tin chung";
            // 
            // dataNL
            // 
            this.dataNL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_NguyenLieu,
            this.TenNL,
            this.SoLuong,
            this.DonVi});
            this.dataNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNL.Location = new System.Drawing.Point(2, 20);
            this.dataNL.Name = "dataNL";
            this.dataNL.Size = new System.Drawing.Size(524, 446);
            this.dataNL.TabIndex = 0;
            this.dataNL.Click += new System.EventHandler(this.dataNL_Click);
            // 
            // DonVi
            // 
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 269.0722F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // TenNL
            // 
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.FillWeight = 27.89569F;
            this.TenNL.HeaderText = "Tên Nguyên Liệu";
            this.TenNL.Name = "TenNL";
            this.TenNL.Width = 150;
            // 
            // id_NguyenLieu
            // 
            this.id_NguyenLieu.DataPropertyName = "id_NguyenLieu";
            this.id_NguyenLieu.FillWeight = 3.032139F;
            this.id_NguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.id_NguyenLieu.Name = "id_NguyenLieu";
            this.id_NguyenLieu.Width = 125;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dataNL);
            this.groupControl4.Location = new System.Drawing.Point(0, 61);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(528, 468);
            this.groupControl4.TabIndex = 21;
            this.groupControl4.Text = "DANH SÁCH NGUYÊN LIỆU";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(580, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(580, 384);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(580, 460);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.searchLookUpEdit2);
            this.Name = "TonKho";
            this.Size = new System.Drawing.Size(1002, 530);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMaNL;
        private DevExpress.XtraEditors.TextEdit txtTenNL;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_NguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}
