using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanAo.Data;

namespace QuanAo
{
    public partial class DauBep : UserControl
    {
        public DauBep()
        {
            
            InitializeComponent();
            loadForm();
        }

        private void DauBep_Load(object sender, EventArgs e)
        {
            
        }
        private void loadForm()
        {
            // load món trong hàng đợi lên
            dataGridViewHangDoiMon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHangDoiMon.DataSource = dataProvider.GetDataTable("exec GetHangDoiMon");

        }

        private void buttongui_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i=0; i < dataGridViewHangDoiMon.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridViewHangDoiMon.Rows[i].Cells[0].Value) == true)
                {
                    dataProvider.exc("exec SuaHangDoiMon " + dataGridViewHangDoiMon.Rows[i].Cells[3].Value.ToString()+","+ dataGridViewHangDoiMon.Rows[i].Cells[1].Value.ToString());
                    temp++;
                }
            }
            if (temp == 0)
            {
                MessageBox.Show("Ban bam gui khi da chon mon !");
            }
            dataGridViewHangDoiMon.DataSource = dataProvider.GetDataTable("exec GetHangDoiMon");
        }
    }
}
