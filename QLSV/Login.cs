using ClosedXML.Excel;
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


        private bool CheckUserExisted(string username)
        {
            string filePath = @"D:\LTGD\QLSV\QLSV\UserData.xlsx";

            // Sử dụng thư viện ClosedXML để đọc dữ liệu từ file Excel
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);

                int rowCount = worksheet.RowsUsed().Count();

                // Duyệt qua từng dòng trong file Excel
                for (int row = 2; row <= rowCount; row++)
                {
                    string storedUsername = worksheet.Cell(row, 1).GetString();

                    // Kiểm tra xem tên đăng nhập đã tồn tại hay chưa
                    if (username == storedUsername)
                    {
                        return true; // Tên đăng nhập đã tồn tại
                    }
                }
            }

            return false; // Tên đăng nhập không tồn tại
        }


        private bool CheckLogin(string username, string password)
        {
            string filePath = @"D:\LTGD\QLSV\QLSV\UserData.xlsx";

            // Sử dụng thư viện ClosedXML để đọc dữ liệu từ file Excel
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);

                int rowCount = worksheet.RowsUsed().Count();

                // Duyệt qua từng dòng trong file Excel
                for (int row = 2; row <= rowCount; row++)
                {
                    string storedUsername = worksheet.Cell(row, 1).GetString();
                    string storedPassword = worksheet.Cell(row, 2).GetString();

                    // Kiểm tra username và password nhập vào có khớp với dữ liệu trong file Excel hay không
                    if (username == storedUsername && password == storedPassword)
                    {
                        return true; // Tìm thấy đăng nhập hợp lệ
                    }
                }
            }

            return false; // Không tìm thấy đăng nhập hợp lệ
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isValidLogin = CheckLogin(username, password);

            if (isValidLogin)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                DialogResult = DialogResult.OK;
                this.Hide();
                var home = new Home();
                home.ShowDialog();
            }
            else
            {
                // Kiểm tra xem người dùng đã nhập sai mật khẩu hay là tài khoản chưa tồn tại
                if (!CheckUserExisted(username))
                {
                    // Tài khoản không tồn tại, clear cả hai text box
                    MessageBox.Show("Tài khoản không tồn tại.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    // Sai mật khẩu, clear text box mật khẩu
                    MessageBox.Show("Sai mật khẩu.");
                    txtPassword.Clear();
                }
            }
        }
    }
}
