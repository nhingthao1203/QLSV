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
            AddSV addSV = new AddSV(truong, null, false);
            addSV.FormClosed += AddSV_FormClosed; // Gán trình xử lý sự kiện
            addSV.Show();
            //lưu cập nhật vào file excel
            SaveDataToExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", truong.LayDanhSachSinhVien());

        }

        private void AddSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            SinhVien newSinhVien = (sender as AddSV).UpdatedSinhVien;
            if (newSinhVien != null)
            {
                // Thêm sinh viên mới vào danh sách trong lớp Truong
                truong.ThemSinhVien(newSinhVien);

                // Hiển thị thông báo thêm sinh viên thành công
                MessageBox.Show("Thêm sinh viên thành công!");
                
                // Lưu cập nhật vào file excel
                SaveDataToExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", truong.LayDanhSachSinhVien());
            }

            this.Show();
            // Hiển thị lại form Home
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

                    sinhVien.StudentName = dataRow.Cell(1).GetString();
                    sinhVien.StudentID = dataRow.Cell(2).GetString();
                    sinhVien.StudentAge = dataRow.Cell(3).GetValue<int>();
                    sinhVien.StudentGender = dataRow.Cell(4).GetString();
                    sinhVien.StudentDateOfBirth = dataRow.Cell(5).GetValue<DateTime>();
                    sinhVien.StudentMathScore = dataRow.Cell(6).GetValue<double>();
                    sinhVien.StudentPhysicsScore = dataRow.Cell(7).GetValue<double>();
                    sinhVien.StudentChemistryScore = dataRow.Cell(8).GetValue<double>();
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
                AddSV addSV = new AddSV(truong, sinhVien, true);
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
                        List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();
                        UpdateDataInExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", danhSachSinhVien);
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
        private void SaveDataToExcel(string filePath, List<SinhVien> danhSachSinhVien)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Students");
                worksheet.Cell(1, 1).Value = "StudentName";
                worksheet.Cell(1, 2).Value = "StudentID";
                worksheet.Cell(1, 3).Value = "StudentAge";
                worksheet.Cell(1, 4).Value = "StudentGender";
                worksheet.Cell(1, 5).Value = "StudentDateOfBirth";
                worksheet.Cell(1, 6).Value = "StudentMathScore";
                worksheet.Cell(1, 7).Value = "StudentPhysicsScore";
                worksheet.Cell(1, 8).Value = "StudentChemistryScore";
                worksheet.Cell(1, 9).Value = "GPA";
                worksheet.Cell(1, 10).Value = "Rank";

                for (int i = 1; i < danhSachSinhVien.Count; i++)
                {
                    var sv = danhSachSinhVien[i];
                    worksheet.Cell(i + 1, 1).Value = sv.StudentName;
                    worksheet.Cell(i + 1, 2).Value = sv.StudentID;
                    worksheet.Cell(i + 1, 3).Value = sv.StudentAge;
                    worksheet.Cell(i + 1, 4).Value = sv.StudentGender;
                    worksheet.Cell(i + 1, 5).Value = sv.StudentDateOfBirth;
                    worksheet.Cell(i + 1, 6).Value = sv.StudentMathScore;
                    worksheet.Cell(i + 1, 7).Value = sv.StudentPhysicsScore;
                    worksheet.Cell(i + 1, 8).Value = sv.StudentChemistryScore;
                    worksheet.Cell(i + 1, 9).Value = sv.GPA;
                    worksheet.Cell(i + 1, 10).Value = sv.Rank;
                }

                workbook.SaveAs(filePath);
            }
        }

        private void UpdateDataInExcel(string filePath, List<SinhVien> danhSachSinhVien)
        {
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1); // Get the first worksheet
                int rowCount = worksheet.RowsUsed().Count();

                // Loop through the list of students and update the data in the Excel file
                for (int i = 0; i < danhSachSinhVien.Count; i++)
                {
                    SinhVien sv = danhSachSinhVien[i];
                    IXLRow dataRow = worksheet.Row(i + 2); // Excel rows start from index 1, so add 2 to get the correct row number

                    dataRow.Cell(1).Value = sv.StudentName;
                    dataRow.Cell(2).Value = sv.StudentID;
                    dataRow.Cell(3).Value = sv.StudentAge;
                    dataRow.Cell(4).Value = sv.StudentGender;
                    dataRow.Cell(5).Value = sv.StudentDateOfBirth;
                    dataRow.Cell(6).Value = sv.StudentMathScore;
                    dataRow.Cell(7).Value = sv.StudentPhysicsScore;
                    dataRow.Cell(8).Value = sv.StudentChemistryScore;
                    dataRow.Cell(9).Value = sv.GPA;
                    dataRow.Cell(10).Value = sv.Rank;
                }

                workbook.Save(); // Save the changes to the Excel file
            }
        }
        private void DeleteDataInExcel(string filePath, List<SinhVien> danhSachSinhVien)
        {
            using (XLWorkbook workbook = new XLWorkbook(filePath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1); // Get the first worksheet

                // Xóa toàn bộ dữ liệu cũ trong file Excel
                worksheet.Clear();

                // Ghi lại dữ liệu mới từ danh sách sinh viên đã được cập nhật
                worksheet.Cell(1, 1).Value = "StudentName";
                worksheet.Cell(1, 2).Value = "StudentID";
                worksheet.Cell(1, 3).Value = "StudentAge";
                worksheet.Cell(1, 4).Value = "StudentGender";
                worksheet.Cell(1, 5).Value = "StudentDateOfBirth";
                worksheet.Cell(1, 6).Value = "StudentMathScore";
                worksheet.Cell(1, 7).Value = "StudentPhysicsScore";
                worksheet.Cell(1, 8).Value = "StudentChemistryScore";
                worksheet.Cell(1, 9).Value = "GPA";
                worksheet.Cell(1, 10).Value = "Rank";

                for (int i = 0; i < danhSachSinhVien.Count; i++)
                {
                    SinhVien sv = danhSachSinhVien[i];
                    worksheet.Cell(i + 2, 1).Value = sv.StudentName;
                    worksheet.Cell(i + 2, 2).Value = sv.StudentID;
                    worksheet.Cell(i + 2, 3).Value = sv.StudentAge;
                    worksheet.Cell(i + 2, 4).Value = sv.StudentGender;
                    worksheet.Cell(i + 2, 5).Value = sv.StudentDateOfBirth;
                    worksheet.Cell(i + 2, 6).Value = sv.StudentMathScore;
                    worksheet.Cell(i + 2, 7).Value = sv.StudentPhysicsScore;
                    worksheet.Cell(i + 2, 8).Value = sv.StudentChemistryScore;
                    worksheet.Cell(i + 2, 9).Value = sv.GPA;
                    worksheet.Cell(i + 2, 10).Value = sv.Rank;
                }

                workbook.Save(); // Save the changes to the Excel file
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.GPA).ToList();
            this.Hide();
            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
            
            showSV.FormClosed += showSV_FormClosed;
        }

        private void SortByID_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.StudentID).ToList();
            this.Hide();
            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
           
            showSV.FormClosed += showSV_FormClosed;
        }

        private void SortByName_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();

            // Sắp xếp danh sách sinh viên theo trường "Id"
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.StudentName).ToList();
            this.Hide();
            ShowSV showSV = new ShowSV(truong, null);
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
           
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.ShowDialog();
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


