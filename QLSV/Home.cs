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
    public partial class Home : Form
    {

        private Truong truong;

        public Home()
        {
            InitializeComponent();
            truong = new Truong();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSV addSV = new AddSV(truong, null);
            addSV.FormClosed += AddSV_FormClosed; // Gán trình xử lý sự kiện
            addSV.ShowDialog();

        }

        private void AddSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Hiển thị lại form Home
        }
        private void showSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Hiển thị lại form Home
        }
        private void button4_Click(object sender, EventArgs e)
        { 
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();
            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
            this.Hide();
            showSV.FormClosed += showSV_FormClosed;
        }

        private void ReadDataFromExcel(string filePath)
        {
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1); // Đọc từ sheet đầu tiên
                int rowCount = worksheet.RowsUsed().Count();

                for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng thứ 2 (loại bỏ dòng tiêu đề)
                {
                    SinhVien sinhVien = new SinhVien();
                    IXLRow dataRow = worksheet.Row(row);

                    sinhVien.StudentName = dataRow.Cell(2).GetString();
                    sinhVien.StudentID = dataRow.Cell(3).GetString();
                    sinhVien.StudentAge = dataRow.Cell(4).GetValue<int>();
                    sinhVien.StudentGender = dataRow.Cell(5).GetString();
                    sinhVien.StudentDateOfBirth = dataRow.Cell(6).GetValue<DateTime>();
                    sinhVien.StudentMathScore = dataRow.Cell(7).GetValue<double>();
                    sinhVien.StudentPhysicsScore = dataRow.Cell(8).GetValue<double>();
                    sinhVien.StudentChemistryScore = dataRow.Cell(9).GetValue<double>();
                    sinhVien.GPA = Math.Round(CalculateGPA(sinhVien), 1);
                    sinhVien.Rank = CalculateRank(sinhVien.GPA);

                    truong.ThemSinhVien(sinhVien); // Thêm sinh viên vào danh sách trong Truong
                }
            }
        }
        private double CalculateGPA(SinhVien sinhVien)
        {
            double totalScore = sinhVien.StudentMathScore + sinhVien.StudentPhysicsScore + sinhVien.StudentChemistryScore;
            return totalScore / 3;
        }

        private string CalculateRank(double gpa)
        {
            if (gpa >= 8)
                return "Giỏi";
            else if (gpa >= 7)
                return "Khá";
            else if (gpa >= 5)
                return "Trung Bình";
            else
                return "Kém";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindSV findSV = new FindSV(truong);
            findSV.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string filePath = @"D:\LTGD\QLSV\QLSV\Student.xlsx";
            ReadDataFromExcel(filePath);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit editForm = new Edit(truong);
            editForm.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // Hiển thị hộp thoại nhập mã sinh viên
            string studentID = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã sinh viên:", "Tìm sinh viên");

            // Tìm sinh viên theo mã sinh viên
            SinhVien sinhVien = truong.TimSinhVien(studentID);

            if (sinhVien != null)
            {
                // Sinh viên tồn tại, chuyển sang form AddSV để cập nhật thông tin
                this.Hide();
                AddSV addSV = new AddSV(truong, sinhVien);
                addSV.FormClosed += (s, args) =>
                {
                    this.Show(); // Hiển thị lại form Home khi form AddSV được đóng

                    // Lấy thông tin sinh viên đã cập nhật từ AddSV
                    SinhVien updatedSinhVien = addSV.UpdatedSinhVien;

                    if (updatedSinhVien != null)
                    {
                        // Thực hiện các xử lý với thông tin cập nhật ở đây
                        sinhVien.StudentName = updatedSinhVien.StudentName;
                        sinhVien.StudentGender = updatedSinhVien.StudentGender;
                        sinhVien.StudentAge = updatedSinhVien.StudentAge;
                        sinhVien.StudentMathScore = updatedSinhVien.StudentMathScore;
                        sinhVien.StudentPhysicsScore = updatedSinhVien.StudentPhysicsScore;
                        sinhVien.StudentChemistryScore = updatedSinhVien.StudentChemistryScore;
                        sinhVien.StudentDateOfBirth = updatedSinhVien.StudentDateOfBirth;
                        sinhVien.GPA = Math.Round(CalculateGPA(sinhVien), 1);
                        sinhVien.Rank = CalculateRank(sinhVien.GPA);

                        // Hiển thị thông báo cập nhật thành công
                        MessageBox.Show("Cập nhật sinh viên thành công!");
                    }
                };

                addSV.ShowDialog();
            }
            else
            {
                // Sinh viên không tồn tại, hiển thị thông báo
                MessageBox.Show($"Không tồn tại sinh viên có mã {studentID}. Vui lòng điền lại.", "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.GPA).ToList();

            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
            this.Hide();
            showSV.FormClosed += showSV_FormClosed;
        }

        private void SortByID_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.StudentID).ToList();

            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
            this.Hide();
            showSV.FormClosed += showSV_FormClosed;
        }

        private void SortByName_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.StudentName).ToList();

            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
            this.Hide();
            showSV.FormClosed += showSV_FormClosed;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
public class SinhVien
{
    public string StudentName { get; set; }
    public string StudentID { get; set; }
    public int StudentAge { get; set; }
    public string StudentGender { get; set; }
    public DateTime StudentDateOfBirth { get; set; }
    public double StudentMathScore { get; set; }
    public double StudentPhysicsScore { get; set; }
    public double StudentChemistryScore { get; set; }
    public double GPA { get; set; }
    public string Rank { get; set; }
}

public class Truong
{
    private List<SinhVien> danhSachSinhVien;

    public Truong()
    {
        danhSachSinhVien = new List<SinhVien>();
    }

    public void ThemSinhVien(SinhVien sinhVien)
    {
        danhSachSinhVien.Add(sinhVien);
    }

    public List<SinhVien> LayDanhSachSinhVien()
    {
        return danhSachSinhVien;
    }
    public void XoaSinhVien(SinhVien sinhVien)
    {
        danhSachSinhVien.Remove(sinhVien);
    }
    public SinhVien TimSinhVien(string studentID)
    {
        return danhSachSinhVien.FirstOrDefault(s => s.StudentID == studentID);
    }
    public SinhVien TimTenSinhVien(string studentName)
    {
        return danhSachSinhVien.FirstOrDefault(s => s.StudentName == studentName);
    }



}


