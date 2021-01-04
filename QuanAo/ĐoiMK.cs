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
using QuanAo.Data;

namespace QuanAo
{
    public partial class ĐoiMK : System.Windows.Forms.UserControl
    {
        private string id_NhanVien;
        public ĐoiMK(string id_nhanvien)
        {
            this.id_NhanVien = id_nhanvien;
            InitializeComponent();
        }
        public string MD5(string mk)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(mk);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        private void ĐoiMK_Load(object sender, EventArgs e)
        {
            this.btn_CapNhat.Enabled = false;
            this.tb_MKMoi.Enabled = false;
            this.tb_NhapLai.Enabled = false;
            load();
        }

        //ham load thong tin
        private void load()
        {
            string query = "select * from NhanVien where id_NhanVien ='" + this.id_NhanVien + "'";
            DataRow NhanVien = dataProvider.GetDataTable(query).Rows[0];
            this.lb_id.Text = NhanVien["id_NhanVien"].ToString();
            this.lb_TenHienThi.Text = NhanVien["HoTen"].ToString();
            string query1 = "select * from admin where id_NhanVien ='" + this.id_NhanVien + "'";
            DataRow admin = dataProvider.GetDataTable(query1).Rows[0];
            this.lb_TaiKhoan.Text = admin["TaiKhoan"].ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            this.tb_MKMoi.Enabled = true;
            this.tb_NhapLai.Enabled = true;
            this.btn_Sua.Enabled = false;
            this.btn_CapNhat.Enabled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (this.tb_MKMoi.Text == "")
            {
                MessageBox.Show("Điền mật khẩu trước khi xác nhận");
            }
            else if(this.tb_NhapLai.Text == "")
            {
                MessageBox.Show("Điền mật khẩu trước khi xác nhận");
            }
            else
            {
                if(this.tb_MKMoi.Text != this.tb_NhapLai.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không chính xác");
                }
                else
                {
                    string query = "update admin set MatKhau = '" + this.MD5(this.tb_MKMoi.Text) + "' where id_NhanVien ='" + this.id_NhanVien + "'";
                    dataProvider.exc(query);
                    MessageBox.Show("Đổi mật khẩu thành công !!!");
                    this.btn_CapNhat.Enabled = false;
                    this.btn_Sua.Enabled = true;
                    this.tb_MKMoi.Enabled = false;
                    this.tb_NhapLai.Enabled = false;
                }
            }
        }



    }
}