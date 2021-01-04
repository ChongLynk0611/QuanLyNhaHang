namespace QuanAo
{
    partial class XuatKho
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
            this.txtDonVi = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbTenNL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fds = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataXK = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_NguyenLieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtNgayXK = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaPXK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnTaoPhieuXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataXK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPXK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numSL);
            this.groupControl1.Controls.Add(this.txtDonVi);
            this.groupControl1.Controls.Add(this.txtMaNL);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbTenNL);
            this.groupControl1.Controls.Add(this.fds);
            this.groupControl1.Location = new System.Drawing.Point(6, 25);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(748, 298);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin nguyên liệu";
            // 
            // numSL
            // 
            this.numSL.Enabled = false;
            this.numSL.Location = new System.Drawing.Point(192, 245);
            this.numSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(128, 23);
            this.numSL.TabIndex = 16;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(192, 180);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Properties.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(434, 22);
            this.txtDonVi.TabIndex = 15;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(191, 112);
            this.txtMaNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Properties.ReadOnly = true;
            this.txtMaNL.Size = new System.Drawing.Size(435, 22);
            this.txtMaNL.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(78, 119);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 17);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Mã nguyên liệu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 183);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Đơn vị :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 247);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Số lượng :";
            // 
            // cbTenNL
            // 
            this.cbTenNL.Location = new System.Drawing.Point(192, 52);
            this.cbTenNL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTenNL.Name = "cbTenNL";
            this.cbTenNL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenNL.Properties.DisplayMember = "NPPTen";
            this.cbTenNL.Properties.NullText = "";
            this.cbTenNL.Properties.PopupView = this.gridView1;
            this.cbTenNL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTenNL.Properties.ValueMember = "NPPMa";
            this.cbTenNL.Size = new System.Drawing.Size(434, 22);
            this.cbTenNL.TabIndex = 10;
            this.cbTenNL.EditValueChanged += new System.EventHandler(this.cbTenNL_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // fds
            // 
            this.fds.Location = new System.Drawing.Point(78, 55);
            this.fds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fds.Name = "fds";
            this.fds.Size = new System.Drawing.Size(106, 17);
            this.fds.TabIndex = 2;
            this.fds.Text = "Tên nguyên liệu :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataXK);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl2.Location = new System.Drawing.Point(758, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(642, 714);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "PHIẾU XUẤT KHO";
            // 
            // dataXK
            // 
            this.dataXK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataXK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataXK.Location = new System.Drawing.Point(2, 26);
            this.dataXK.MainView = this.gridView2;
            this.dataXK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataXK.Name = "dataXK";
            this.dataXK.Size = new System.Drawing.Size(638, 686);
            this.dataXK.TabIndex = 0;
            this.dataXK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_NguyenLieu,
            this.TenNL,
            this.DonVi,
            this.SoLuong});
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.dataXK;
            this.gridView2.Name = "gridView2";
            // 
            // id_NguyenLieu
            // 
            this.id_NguyenLieu.Caption = "Mã Nguyên Liệu";
            this.id_NguyenLieu.FieldName = "id_NguyenLieu";
            this.id_NguyenLieu.MinWidth = 23;
            this.id_NguyenLieu.Name = "id_NguyenLieu";
            this.id_NguyenLieu.Visible = true;
            this.id_NguyenLieu.VisibleIndex = 0;
            this.id_NguyenLieu.Width = 87;
            // 
            // TenNL
            // 
            this.TenNL.Caption = "Tên Nguyên Liệu";
            this.TenNL.FieldName = "TenNL";
            this.TenNL.MinWidth = 23;
            this.TenNL.Name = "TenNL";
            this.TenNL.Visible = true;
            this.TenNL.VisibleIndex = 1;
            this.TenNL.Width = 87;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn Vị";
            this.DonVi.FieldName = "DonVi";
            this.DonVi.MinWidth = 23;
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            this.DonVi.Width = 87;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.MinWidth = 23;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 87;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtNgayXK);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtMaPXK);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Location = new System.Drawing.Point(451, 345);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(300, 124);
            this.groupControl3.TabIndex = 22;
            // 
            // txtNgayXK
            // 
            this.txtNgayXK.EditValue = null;
            this.txtNgayXK.Location = new System.Drawing.Point(115, 71);
            this.txtNgayXK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNgayXK.Name = "txtNgayXK";
            this.txtNgayXK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayXK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayXK.Size = new System.Drawing.Size(168, 22);
            this.txtNgayXK.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 75);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 17);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Ngày xuất :";
            // 
            // txtMaPXK
            // 
            this.txtMaPXK.Location = new System.Drawing.Point(115, 28);
            this.txtMaPXK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPXK.Name = "txtMaPXK";
            this.txtMaPXK.Size = new System.Drawing.Size(168, 22);
            this.txtMaPXK.TabIndex = 19;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 32);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 17);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Mã phiếu xuất :";
            // 
            // btnTaoPhieuXuat
            // 
            this.btnTaoPhieuXuat.Location = new System.Drawing.Point(631, 517);
            this.btnTaoPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaoPhieuXuat.Name = "btnTaoPhieuXuat";
            this.btnTaoPhieuXuat.Size = new System.Drawing.Size(99, 64);
            this.btnTaoPhieuXuat.TabIndex = 5;
            this.btnTaoPhieuXuat.Text = "Tạo phiếu xuất";
            this.btnTaoPhieuXuat.Click += new System.EventHandler(this.btnTaoPhieuXuat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(85, 393);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 64);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(251, 393);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(99, 64);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất kho";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // XuatKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTaoPhieuXuat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XuatKho";
            this.Size = new System.Drawing.Size(1400, 714);
            this.Load += new System.EventHandler(this.XuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataXK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayXK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPXK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl fds;
        private DevExpress.XtraEditors.GridLookUpEdit cbTenNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDonVi;
        private DevExpress.XtraEditors.TextEdit txtMaNL;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.DateEdit txtNgayXK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMaPXK;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown numSL;
        private DevExpress.XtraGrid.GridControl dataXK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnTaoPhieuXuat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn id_NguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNL;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
    }
}
