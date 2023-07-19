using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private bool ValidateUser(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password))
            {

                label5.Visible = true;
                // Đóng form đăng nhập
                DialogResult = DialogResult.OK;
                Close();
                var home = new Home();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                txtUsername.Clear();
                txtPassword.Clear();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
