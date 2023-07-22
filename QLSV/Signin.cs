using System;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QLSV
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
            this.Load += Signin_Load;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string password1 = txtPassword1.Text;

            // Kiểm tra các textbox có rỗng hay không
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(password1))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu.");
                return; // Dừng xử lý, không đăng ký hoặc đăng nhập
            }

            // Kiểm tra xem mật khẩu nhập lại có khớp với mật khẩu nhập ban đầu không
            if (password != password1)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng kiểm tra lại.");
                return; // Dừng xử lý, không đăng ký hoặc đăng nhập
            }

            // Tiếp tục thực hiện đăng ký hoặc đăng nhập nếu thông tin hợp lệ
            bool isUserExisted = CheckUserExisted(username);

            if (isUserExisted)
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
            }
            else
            {
                // Thêm tài khoản người dùng mới vào file Excel
                AddNewUser(username, password);

                MessageBox.Show("Đăng ký tài khoản thành công!");

                // Đóng form Signin và hiển thị lại form đăng nhập (Form1)
                this.DialogResult = DialogResult.OK;
                
                this.Hide();
                Form1 form = new Form1();   
                form.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();

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

        private void AddNewUser(string username, string password)
        {
            string filePath = @"D:\LTGD\QLSV\QLSV\UserData.xlsx";

            // Sử dụng thư viện ClosedXML để thêm dữ liệu vào file Excel
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);

                int nextRow = worksheet.RowsUsed().Count() + 1;

                // Thêm thông tin tài khoản người dùng mới vào dòng tiếp theo của file Excel
                worksheet.Cell(nextRow, 1).Value = username;
                worksheet.Cell(nextRow, 2).Value = password;

                // Lưu file Excel sau khi thêm dữ liệu
                workbook.Save();
            }
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }
    }
}
