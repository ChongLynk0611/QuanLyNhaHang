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

namespace NhaHang.GUI
{
    public partial class XemLichSu : DevExpress.XtraEditors.XtraUserControl
    {
        private string id_TK;
        public XemLichSu(string id_TK)
        {
            this.id_TK = id_TK;
            InitializeComponent();
            LoadLichSuNK();
            LoadLichSuXK();
        }
        KetNoi kn = new KetNoi();
        public void LoadLichSuNK()
        {
            dataLSnhap.DataSource = kn.truyvanTSql("LSNhapKho");

            DataTable data = kn.truyvanTSql("LSNhapKho");
            data.Columns[0].ColumnName = "Mã Phiếu Nhập Kho";
            data.Columns[1].ColumnName = "Mã Nhân Viên";
            data.Columns[2].ColumnName = "Họ Tên";
            data.Columns[3].ColumnName = "Ngày Nhập";
            data.Columns[4].ColumnName = "Giá";
            searchLookUpEdit3.Properties.DataSource = data;
        }
        public void LoadLichSuXK()
        {
            dataLSXK.DataSource = kn.truyvanTSql("LSXuatKho");

            DataTable data = kn.truyvanTSql("LSXuatKho");
            data.Columns[0].ColumnName = "Mã Phiếu Xuất Kho";
            data.Columns[1].ColumnName = "Mã Nhân Viên";
            data.Columns[2].ColumnName = "Họ Tên";
            data.Columns[3].ColumnName = "Ngày Xuất";
            searchLookUpEdit1.Properties.DataSource = data;
        }

        private void searchLookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit3.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã Phiếu Nhập Kho";
            string fieldName2 = "Mã Nhân Viên";
            string fieldName3 = "Họ Tên";
            string fieldName4 = "Ngày Nhập";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            txtTTmaPNK.Text = value1.ToString();
            txtTTmaNV.Text = value2.ToString();
            txtTTHoTen.Text = value3.ToString();
            txtTTngayNhap.Text = value4.ToString().Substring(0, 11);
            DataTable data = kn.Xem_PNK(Convert.ToInt32(txtTTmaPNK.Text));
            dataTTPNK.DataSource = data;
        }

        private void dataLSnhap_Click(object sender, EventArgs e)
        {
            int row = dataLSnhap.CurrentCell.RowIndex;
            txtTTmaPNK.Text = dataLSnhap.Rows[row].Cells["MaPNK"].Value.ToString();
            txtTTmaNV.Text = dataLSnhap.Rows[row].Cells["MaNV"].Value.ToString();
            txtTTHoTen.Text = dataLSnhap.Rows[row].Cells["HT"].Value.ToString();
            if (txtTTmaPNK.Text != "")
                txtTTngayNhap.Text = dataLSnhap.Rows[row].Cells["NgayNhap"].Value.ToString().Substring(0, 11);
            else
            {
                txtTTngayNhap.Text = "";
                for (int i = 0; i < dataTTPNK.Rows.Count - 1; i++)   // clear hang trong bang
                {
                    dataTTPNK.Rows.RemoveAt(i);
                    i--;
                    while (dataTTPNK.Rows.Count == 0)
                        continue;
                }
            }

            try
            {
                DataTable data = kn.Xem_PNK(Convert.ToInt32(txtTTmaPNK.Text));
                dataTTPNK.DataSource = data;
            }
            catch
            {

            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit1.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã Phiếu Xuất Kho";
            string fieldName2 = "Mã Nhân Viên";
            string fieldName3 = "Họ Tên";
            string fieldName4 = "Ngày Xuất";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            txtMaPXK.Text = value1.ToString();
            txtMaNVXK.Text = value2.ToString();
            txtHoTenXK.Text = value3.ToString();
            txtNgayXK.Text = value4.ToString().Substring(0, 11);
            DataTable data = kn.Xem_PXK(Convert.ToInt32(txtMaPXK.Text));
            dataCTXK.DataSource = data;
        }

        private void dataLSXK_Click(object sender, EventArgs e)
        {
            int row = dataLSXK.CurrentCell.RowIndex;
            txtMaPXK.Text = dataLSXK.Rows[row].Cells["MaPXK"].Value.ToString();
            txtMaNVXK.Text = dataLSXK.Rows[row].Cells["MaNVXK"].Value.ToString();
            txtHoTenXK.Text = dataLSXK.Rows[row].Cells["HTXK"].Value.ToString();
            if (txtMaPXK.Text != "")
                txtNgayXK.Text = dataLSXK.Rows[row].Cells["NgayXK"].Value.ToString().Substring(0, 11);
            else
            {
                txtNgayXK.Text = "";
                for (int i = 0; i < dataCTXK.Rows.Count - 1; i++)   // clear hang trong bang
                {
                    dataCTXK.Rows.RemoveAt(i);
                    i--;
                    while (dataCTXK.Rows.Count == 0)
                        continue;
                }
            }

            try
            {
                DataTable data = kn.Xem_PXK(Convert.ToInt32(txtMaPXK.Text));
                dataCTXK.DataSource = data;
            }
            catch
            {

            }
        }
    }
}
