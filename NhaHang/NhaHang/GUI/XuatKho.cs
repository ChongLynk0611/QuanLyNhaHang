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
    public partial class XuatKho : DevExpress.XtraEditors.XtraUserControl
    {
        private string id_TK;
        KetNoi kn = new KetNoi();
        public XuatKho(string id_TK)
        {
            this.id_TK = id_TK;
            InitializeComponent();
        }

        private void XuatKho_Load(object sender, EventArgs e)
        {
            btnTaoPhieuXuat.Enabled = true;
            btnThem.Enabled = false;
            btnXuat.Enabled = false;
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            txtMaPXK.ReadOnly = true;
            txtNgayXK.ReadOnly = true;
        }

        private void btnTaoPhieuXuat_Click(object sender, EventArgs e)
        {
            int m = kn.GetMaPXK() + 1;
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            btnThem.Enabled = true;
            btnXuat.Enabled = false;

            txtNgayXK.EditValue = DateTime.Now;
            txtMaPXK.Text = m.ToString();
            cbTenNL.Text = "";
            txtMaNL.ResetText();
            txtDonVi.ResetText();
            numSL.Value = 0;

            dataXK.DataSource = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = true;
            cbTenNL.Properties.DataSource = kn.GetDSNL();
            cbTenNL.Properties.DisplayMember = "TenNL";
            cbTenNL.Properties.ValueMember = "TenNL";
            btnTaoPhieuXuat.Enabled = false;
            btnXuat.Enabled = true;
            numSL.Enabled = true;

            kn.Them_PXK(id_TK, Convert.ToDateTime(txtNgayXK.Text));
            btnThem.Enabled = false;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (cbTenNL.Text == "" || numSL.Value == 0 )
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ vào các thông tin");
            }
            else
            {
                btnThem.Enabled = false;
                btnTaoPhieuXuat.Enabled = true;
                kn.Them_CTXK(Convert.ToInt32(txtMaPXK.Text), Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(numSL.Value.ToString()), txtDonVi.Text);
                dataXK.DataSource = kn.Xem_PXK(Convert.ToInt32(txtMaPXK.Text));
                numSL.Value = 0;
                groupControl2.Enabled = true;
            }
        }

        private void cbTenNL_EditValueChanged(object sender, EventArgs e)
        {
            if (cbTenNL.Text != "")
            {
                DataTable dt = new DataTable();
                string query = "select *from NguyenLieu where TenNL = N'" + cbTenNL.Text + "'";
                dt = kn.truyvanSQL(query);
                txtMaNL.Text = dt.Rows[0]["id_NguyenLieu"].ToString();
                txtDonVi.Text = dt.Rows[0]["DonVi"].ToString();
                numSL.ResetText();
            }
        }
    }
}
