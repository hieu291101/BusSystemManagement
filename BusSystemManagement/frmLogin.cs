using BUS_BusSystemManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSystemManagement
{
    public partial class frmLogin : Form
    {
        private BUS_Login bus_Login=new BUS_Login();
        private string username;
        private string password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;

            if (username=="")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                tbUsername.Focus();
                return;
            }

            if (username.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập có chứa khoảng trắng. Vui lòng kiểm tra lại!");
                tbUsername.Focus();
                return;
            }    

            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                tbPassword.Focus();
                return;
            }

            

            if (bus_Login.CheckLogin(username, password))
            {
                frmTableManager frmTableManager = new frmTableManager();
                this.Hide();
                frmTableManager.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Vui lòng nhập lại!");
                tbUsername.Focus();
            } 
                
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbUsername.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

    }
}
