
using System;
using System.Data;
using System.Windows.Forms;
using QuanAo.Data;
namespace QuanAo
{
    public partial class fLogin : Form
    {

        private string user;
        private string pass;
        private int bruceFoce;
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public fLogin(string username, string password)
        {
            this.User = username;
            this.Pass = password;
        }



        public fLogin()
        {
            InitializeComponent();
            this.bruceFoce = 0;
            this.User = txbUserName.Text;
            this.Pass = txbPassWord.Text;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            txbPassWord.PasswordChar = '*';//hiện thị mật khẩu bằng dấu *
        }


     

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void loadform()
        {
            DataTable data = dataProvider.GetDataTable("select * from NhanVien where id_NhanVien = 'NV00'");
            if(data.Rows.Count == 0)
            {
                dataProvider.exc("exec ThêmKHVaNVMacDinh");
            }
        }
      
        string Login(string useName, string passWord)
        {

            return AccountDAO.Instance.Login(useName, passWord);
        }

       
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
           
            // nếu chọn hiện mật khẩu => cấu hình lại thuộc tính password
            if (showmk.Checked)
            {
                txbPassWord.PasswordChar = (Char)0;//hiển thị lại mật khẩu nhập
            }
            // bỏ chọn chức năng hiện mật khẩu = > cấu hình lại thuộc tính password
            else
            {

                txbPassWord.PasswordChar = '*';//hiện thị mật khẩu bằng dấu *
            }


            
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(this.bruceFoce <= 3)
            {
                string userName = txbUserName.Text;
                string passWord = txbPassWord.Text;
                string pass = MD5(passWord);
                string id_NhanVien = Login(userName, pass);
                if (id_NhanVien != "")
                {
                    string query = "select * from NhanVien where id_NhanVien ='" + id_NhanVien + "'";
                    string ChucVu = dataProvider.GetDataTable(query).Rows[0]["ChucVu"].ToString();
                  
                    loadform();
                    this.Hide();
                    home HOME = new home(id_NhanVien, ChucVu);
                    HOME.ShowDialog();
                    this.Close();

                }
                else
                {
                    this.bruceFoce++;
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu 5 lần!!!");
            }
           
        }
    }
}
