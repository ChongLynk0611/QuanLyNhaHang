using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanAo
{
    public partial class ThemNL : DevExpress.XtraEditors.XtraForm
    {
        public ThemNL()
        {
            InitializeComponent();
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
        }
        private void ThemNL_Load(object sender, EventArgs e)
        {
            LoadNguyenLieu();
        }
        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == "")
            {
                XtraMessageBox.Show("Tên Nguyên Liệu không được để trống");
                txtTenNL.Focus();
            }
            else
            {
                DataTable data = new DataTable();
                data = kn.truyvanSQL("Select *from NguyenLieu where TenNL = N'" + txtTenNL.Text + "'");
                if (data.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Nguyên Liệu bạn nhập đã có trong kho");
                }
                else
                {
                    kn.Them_NL(txtTenNL.Text, 0, txtDonVi.Text);
                    LoadNguyenLieu();
                    XtraMessageBox.Show("Thêm nguyên liệu thành công");
                }
            }
        }
    }
}