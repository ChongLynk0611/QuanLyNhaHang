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

namespace NhaHang
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn = new KetNoi();
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(txtUser.Text);
            frm.ShowDialog();
            this.Close();
        }
    }
}