using NhaHang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhaHang
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private string id_TK;
        public Form1(string id_TK)
        {
            this.id_TK = id_TK;
            InitializeComponent();
            load();
        }
        public void load()
        {
            TonKho QL = new TonKho(id_TK);
           // KHO QL = new KHO();
            panel1.Controls.Add(QL);
        }
    }
}
