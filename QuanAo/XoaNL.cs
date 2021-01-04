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
    public partial class XoaNL : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn = new KetNoi();
        public XoaNL()
        {
            InitializeComponent();
        }
        public void LoadCBNL()
        {
            cbTenNL.Properties.DataSource = kn.GetDSNL();
            cbTenNL.Properties.DisplayMember = "TenNL";
            cbTenNL.Properties.ValueMember = "TenNL";
        }
        private void XoaNL_Load(object sender, EventArgs e)
        {
            txtMaNL.ReadOnly = true;
            LoadCBNL();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbTenNL.Text == "")
            {
                XtraMessageBox.Show("Bạn không được để trống thông tin");
            }
            else
            {
                kn.Xoa_NL(Convert.ToInt32(txtMaNL.Text));
                XtraMessageBox.Show("Xóa thành công");
                LoadCBNL();
                cbTenNL.ResetText();
                txtMaNL.ResetText();
            }
        }

        private void btnHuyXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTenNL_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTenNL.Text != "")
            {
                DataTable dt = new DataTable();
                string query = "select *from NguyenLieu where TenNL = N'" + cbTenNL.Text + "'";
                dt = kn.truyvanSQL(query);
                txtMaNL.Text = dt.Rows[0]["id_NguyenLieu"].ToString();
            }
        }
    }
}