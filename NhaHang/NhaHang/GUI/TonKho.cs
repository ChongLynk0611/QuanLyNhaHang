using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NhaHang
{
    public partial class TonKho : DevExpress.XtraEditors.XtraUserControl
    {
        private string id_TK;
        public TonKho(string id_TK)
        {
            this.id_TK = id_TK;
            InitializeComponent();
            LoadNguyenLieu(); 
            txtMaNL.ReadOnly = true;
            txtSL.ReadOnly = true;
            txtDonVi.ReadOnly = false;
            txtTenNL.ReadOnly = false;
        }
        KetNoi kn = new KetNoi();
        public void LoadNguyenLieu()
        {
            dataNL.DataSource = kn.truyvanTSql("select_NL");

            DataTable data = kn.truyvanTSql("select_NL");
            data.Columns[0].ColumnName = "Mã Nguyên Liệu";
            data.Columns[1].ColumnName = "Tên Nguyên Liệu";
            data.Columns[2].ColumnName = "Số Lượng";
            data.Columns[3].ColumnName = "Đơn Vị";

            searchLookUpEdit2.Properties.DataSource = data;
        }
        private void dataNL_Click(object sender, EventArgs e)
        {
            int row = dataNL.CurrentCell.RowIndex;

            txtMaNL.Text = dataNL.Rows[row].Cells["id_NguyenLieu"].Value.ToString();
            txtTenNL.Text = dataNL.Rows[row].Cells["TenNL"].Value.ToString();
            txtSL.Text = dataNL.Rows[row].Cells["SoLuong"].Value.ToString();
            txtDonVi.Text = dataNL.Rows[row].Cells["DonVi"].Value.ToString();

        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit2.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã Nguyên Liệu";
            string fieldName2 = "Tên Nguyên Liệu";
            string fieldName3 = "Số Lượng";
            string fieldName4 = "Đơn Vị";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            txtMaNL.Text = value1.ToString();
            txtTenNL.Text = value2.ToString();
            txtSL.Text = value3.ToString();
            txtDonVi.Text = value4.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == "")
            {
                XtraMessageBox.Show("Tên Nguyên Liệu không được để trống");
                txtTenNL.Focus();
            }
            else
            {
                kn.Sua_NL(Convert.ToInt32(txtMaNL.Text), txtTenNL.Text, txtDonVi.Text);
                XtraMessageBox.Show("Sửa thông tin thành công");
                LoadNguyenLieu();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNL temp = new ThemNL();
            temp.ShowDialog();
            LoadNguyenLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNL temp = new XoaNL();
            temp.ShowDialog();
            LoadNguyenLieu();
        }
    }
}
