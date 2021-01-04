namespace QuanAo
{
    partial class XoaNL
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaNL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTenNL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnHuyXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.txtMaNL);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.cbTenNL);
            this.groupControl3.Controls.Add(this.btnHuyXoa);
            this.groupControl3.Controls.Add(this.btnXoa);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(421, 280);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Nhập thông tin";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(157, 105);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(189, 20);
            this.txtMaNL.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Mã nguyên liệu :";
            // 
            // cbTenNL
            // 
            this.cbTenNL.Location = new System.Drawing.Point(157, 63);
            this.cbTenNL.Name = "cbTenNL";
            this.cbTenNL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTenNL.Properties.DisplayMember = "NPPTen";
            this.cbTenNL.Properties.NullText = "";
            this.cbTenNL.Properties.PopupView = this.gridView1;
            this.cbTenNL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbTenNL.Properties.ValueMember = "NPPMa";
            this.cbTenNL.Size = new System.Drawing.Size(189, 20);
            this.cbTenNL.TabIndex = 19;
            this.cbTenNL.EditValueChanged += new System.EventHandler(this.cbTenNL_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnHuyXoa
            // 
            this.btnHuyXoa.Location = new System.Drawing.Point(246, 175);
            this.btnHuyXoa.Name = "btnHuyXoa";
            this.btnHuyXoa.Size = new System.Drawing.Size(75, 39);
            this.btnHuyXoa.TabIndex = 5;
            this.btnHuyXoa.Text = "Hủy";
            this.btnHuyXoa.Click += new System.EventHandler(this.btnHuyXoa_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(110, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên nguyên liệu :";
            // 
            // XoaNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 280);
            this.Controls.Add(this.groupControl3);
            this.Name = "XoaNL";
            this.Text = "Xóa Nguyên Liệu";
            this.Load += new System.EventHandler(this.XoaNL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtMaNL;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GridLookUpEdit cbTenNL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnHuyXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}