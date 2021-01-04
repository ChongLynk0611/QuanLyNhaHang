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


namespace QuanAo
{
    public partial class NhapKho : DevExpress.XtraEditors.XtraUserControl
    {
        private string id_TK;
        public NhapKho(string id_TK)
        {
            this.id_TK = id_TK;
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void sbtnKhoiTao_Click(object sender, EventArgs e)
        {
            int m = kn.GetMaPNK() + 1;
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            sbtnThemMoi.Enabled = true;
            sbtnNhap.Enabled = false;

            btnThemNL.Enabled = true;
            dateNgayNK.EditValue = DateTime.Now;
            txtMaPNK.Text = m.ToString();
            cbTenNL.Text = "";
            txtMaNL.ResetText();
            txtDonVi.ResetText();
            numSL.Value = 0;
            txtGia_PNK.ResetText();
            dataNK.DataSource = null;
        }

        private void sbtnThemMoi_Click(object sender, EventArgs e)
        {
                groupControl1.Enabled = true;
                cbTenNL.Properties.DataSource = kn.GetDSNL();
                cbTenNL.Properties.DisplayMember = "TenNL";
                cbTenNL.Properties.ValueMember = "TenNL";
                sbtnKhoiTao.Enabled = false;
                sbtnNhap.Enabled = true;
                numSL.Enabled = true;
                txtGia_PNK.Enabled = true;
            
                kn.Them_PNK(id_TK, Convert.ToDateTime(dateNgayNK.Text));
                sbtnThemMoi.Enabled = false;
        }

        private void sbtnNhap_Click(object sender, EventArgs e)
        {
            if (cbTenNL.Text == "" || numSL.Value == 0 || txtGia_PNK.Text == "")
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ vào các thông tin");
            }
            else
            {
                sbtnThemMoi.Enabled = false;
                sbtnKhoiTao.Enabled = true;
                kn.Them_CTNK(Convert.ToInt32(txtMaPNK.Text), Convert.ToInt32(txtMaNL.Text), Convert.ToInt32(numSL.Value.ToString()), Convert.ToInt32(txtGia_PNK.Text),txtDonVi.Text);
                dataNK.DataSource = kn.Xem_PNK(Convert.ToInt32(txtMaPNK.Text));
                numSL.Value = 0;
                txtGia_PNK.ResetText();
                groupControl2.Enabled = true;
            }
        }

        private void NhapKho_Load(object sender, EventArgs e)
        {
            sbtnKhoiTao.Enabled = true;
            btnThemNL.Enabled = false;
            sbtnNhap.Enabled = false;
            sbtnThemMoi.Enabled = false;
            groupControl1.Enabled = false;
            groupControl2.Enabled = false;
            txtMaPNK.ReadOnly = true;
            dateNgayNK.ReadOnly = true;
        }

        private void cbTenNL_EditValueChanged(object sender, EventArgs e)
        {
            if(cbTenNL.Text != "")
            {
                DataTable dt = new DataTable();
                string query = "select *from NguyenLieu where TenNL = N'" + cbTenNL.Text + "'";
                dt = kn.truyvanSQL(query);
                txtMaNL.Text = dt.Rows[0]["id_NguyenLieu"].ToString();
                txtDonVi.Text = dt.Rows[0]["DonVi"].ToString();
                txtGia_PNK.ResetText();
                numSL.ResetText();
            }    
            
        }

        private void txtGia_PNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            ThemNL temp = new ThemNL();
            temp.ShowDialog();
        }
    }    
}

