namespace NhaHang
{
    partial class NhapKho
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.btnThemNL = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTenNL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtGia_PNK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.fds = new DevExpress.XtraEditors.LabelControl();
            this.sbtnKhoiTao = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnNhap = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.dataNK = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_NguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayNK = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPNK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia_PNK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numSL);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtDonVi);
            this.groupControl1.Controls.Add(this.btnThemNL);
            this.groupControl1.Controls.Add(this.txtMaNL);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbTenNL);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtGia_PNK);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.fds);
            this.groupControl1.Location = new System.Drawing.Point(3, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 304);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin nguyên liệu";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(156, 199);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(142, 21);
            this.numSL.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(59, 253);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Giá :";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(156, 146);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Properties.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(372, 20);
            this.txtDonVi.TabIndex = 23;
            // 
            // btnThemNL
            // 
            this.btnThemNL.Location = new System.Drawing.Point(469, 42);
            this.btnThemNL.Name = "btnThemNL";
            this.btnThemNL.Size = new System.Drawing.Size(34, 19);
            this.btnThemNL.TabIndex = 19;
            this.btnThemNL.Text = "Thêm";
            this.btnThemNL.Click += new System.EventHandler(this.btnThemNL_Click);
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(155, 91);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Properties.ReadOnly = true;
            this.txtMaNL.Size = new System.Drawing.Size(373, 20);
            this.txtMaNL.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Mã nguyên liệu :";
            // 
            // cbTenNL
            // 
            this.cbTenNL.Location = new System.Drawing.Point(156, 42);
            this.cbTenNL.Name = "cbTenNL";
            this.cbTenNL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenNL.Properties.DisplayMember = "NPPTen";
            this.cbTenNL.Properties.NullText = "";
            this.cbTenNL.Properties.PopupView = this.gridView1;
            this.cbTenNL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTenNL.Properties.ValueMember = "NPPMa";
            this.cbTenNL.Size = new System.Drawing.Size(372, 20);
            this.cbTenNL.TabIndex = 18;
            this.cbTenNL.EditValueChanged += new System.EventHandler(this.cbTenNL_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(59, 149);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Đơn vị :";
            // 
            // txtGia_PNK
            // 
            this.txtGia_PNK.Location = new System.Drawing.Point(154, 250);
            this.txtGia_PNK.Name = "txtGia_PNK";
            this.txtGia_PNK.Size = new System.Drawing.Size(374, 20);
            this.txtGia_PNK.TabIndex = 25;
            this.txtGia_PNK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_PNK_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(58, 201);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(49, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Số lượng :";
            // 
            // fds
            // 
            this.fds.Location = new System.Drawing.Point(58, 45);
            this.fds.Name = "fds";
            this.fds.Size = new System.Drawing.Size(83, 13);
            this.fds.TabIndex = 17;
            this.fds.Text = "Tên nguyên liệu :";
            // 
            // sbtnKhoiTao
            // 
            this.sbtnKhoiTao.Location = new System.Drawing.Point(559, 487);
            this.sbtnKhoiTao.Name = "sbtnKhoiTao";
            this.sbtnKhoiTao.Size = new System.Drawing.Size(85, 52);
            this.sbtnKhoiTao.TabIndex = 16;
            this.sbtnKhoiTao.Text = "Tạo Phiếu Nhập";
            this.sbtnKhoiTao.Click += new System.EventHandler(this.sbtnKhoiTao_Click);
            // 
            // sbtnNhap
            // 
            this.sbtnNhap.Location = new System.Drawing.Point(216, 391);
            this.sbtnNhap.Name = "sbtnNhap";
            this.sbtnNhap.Size = new System.Drawing.Size(85, 52);
            this.sbtnNhap.TabIndex = 15;
            this.sbtnNhap.Text = "Nhập Kho";
            this.sbtnNhap.Click += new System.EventHandler(this.sbtnNhap_Click);
            // 
            // sbtnThemMoi
            // 
            this.sbtnThemMoi.Location = new System.Drawing.Point(77, 391);
            this.sbtnThemMoi.Name = "sbtnThemMoi";
            this.sbtnThemMoi.Size = new System.Drawing.Size(85, 52);
            this.sbtnThemMoi.TabIndex = 14;
            this.sbtnThemMoi.Text = "Thêm";
            this.sbtnThemMoi.Click += new System.EventHandler(this.sbtnThemMoi_Click);
            // 
            // dataNK
            // 
            this.dataNK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNK.Location = new System.Drawing.Point(2, 20);
            this.dataNK.MainView = this.gridView2;
            this.dataNK.Name = "dataNK";
            this.dataNK.Size = new System.Drawing.Size(546, 558);
            this.dataNK.TabIndex = 20;
            this.dataNK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_NguyenLieu,
            this.TenNL,
            this.DonVi,
            this.SoLuong,
            this.Gia});
            this.gridView2.GridControl = this.dataNK;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // id_NguyenLieu
            // 
            this.id_NguyenLieu.Caption = "Mã Nguyên Liệu";
            this.id_NguyenLieu.FieldName = "id_NguyenLieu";
            this.id_NguyenLieu.Name = "id_NguyenLieu";
            this.id_NguyenLieu.Visible = true;
            this.id_NguyenLieu.VisibleIndex = 0;
            // 
            // TenNL
            // 
            this.TenNL.Caption = "Tên Nguyên Liệu";
            this.TenNL.FieldName = "TenNL";
            this.TenNL.Name = "TenNL";
            this.TenNL.Visible = true;
            this.TenNL.VisibleIndex = 1;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn Vị";
            this.DonVi.FieldName = "DonVi";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá";
            this.Gia.FieldName = "Gia";
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataNK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(650, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(550, 580);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "PHIẾU NHẬP KHO";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dateNgayNK);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.txtMaPNK);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Location = new System.Drawing.Point(389, 349);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(257, 101);
            this.groupControl3.TabIndex = 22;
            // 
            // dateNgayNK
            // 
            this.dateNgayNK.EditValue = null;
            this.dateNgayNK.Location = new System.Drawing.Point(99, 58);
            this.dateNgayNK.Name = "dateNgayNK";
            this.dateNgayNK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNK.Size = new System.Drawing.Size(144, 20);
            this.dateNgayNK.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Ngày nhập :";
            // 
            // txtMaPNK
            // 
            this.txtMaPNK.Location = new System.Drawing.Point(99, 23);
            this.txtMaPNK.Name = "txtMaPNK";
            this.txtMaPNK.Size = new System.Drawing.Size(144, 20);
            this.txtMaPNK.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Mã phiếu nhập :";
            // 
            // NhapKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.sbtnKhoiTao);
            this.Controls.Add(this.sbtnNhap);
            this.Controls.Add(this.sbtnThemMoi);
            this.Controls.Add(this.groupControl1);
            this.Name = "NhapKho";
            this.Size = new System.Drawing.Size(1200, 580);
            this.Load += new System.EventHandler(this.NhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGia_PNK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGia_PNK;
        private DevExpress.XtraEditors.SimpleButton sbtnKhoiTao;
        private DevExpress.XtraEditors.SimpleButton sbtnNhap;
        private DevExpress.XtraEditors.SimpleButton sbtnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnThemNL;
        private DevExpress.XtraEditors.GridLookUpEdit cbTenNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dataNK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit dateNgayNK;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMaPNK;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.NumericUpDown numSL;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.TextEdit txtMaNL;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl fds;
        private DevExpress.XtraGrid.Columns.GridColumn id_NguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNL;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
    }
}
