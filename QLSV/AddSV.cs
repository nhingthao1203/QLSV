using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
using ClosedXML.Excel;

namespace QLSV
{
    public partial class AddSV : Form
    {
        public SinhVien UpdatedSinhVien { get; private set; }

        private Truong truong;

        public AddSV(Truong truong, SinhVien sinhVien, bool isUpdateMode)
        {
            InitializeComponent();
            this.truong = truong;
            //txtName.Text = sinhVien.StudentName;
            if (sinhVien != null)
            {
                txtID.Text = sinhVien.StudentID;
            }
            if (isUpdateMode)
            {
                button1.Visible = false;
                txtID.ReadOnly = true;
                txtID.Enabled = true;
            }
            else
            {
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) &&
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                    cboAge.SelectedItem != null &&
                    cboMathScore.SelectedItem != null &&
                    cboPhysicSorce.SelectedItem != null &&
                    cboChemistryScore.SelectedItem != null)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.StudentName = txtName.Text;
                sinhVien.StudentID = txtID.Text;
                sinhVien.StudentGender = radMale.Checked ? "Nam" : "Nữ";
                sinhVien.StudentAge = int.Parse(cboAge.SelectedItem.ToString());
                sinhVien.StudentMathScore = int.Parse(cboMathScore.SelectedItem.ToString());
                sinhVien.StudentPhysicsScore = int.Parse(cboPhysicSorce.SelectedItem.ToString());
                sinhVien.StudentChemistryScore = int.Parse(cboChemistryScore.SelectedItem.ToString());
                sinhVien.StudentDateOfBirth = dtpDateOfBirth.Value;
                sinhVien.GPA = (sinhVien.StudentMathScore + sinhVien.StudentPhysicsScore + sinhVien.StudentChemistryScore) / 3;
                sinhVien.GPA = Math.Round(sinhVien.GPA, 1);
                // Gán học lực dựa trên GPA
                if (sinhVien.GPA >= 8)
                {
                    sinhVien.Rank = "Giỏi";
                }
                else if (sinhVien.GPA >= 6.5)
                {
                    sinhVien.Rank = "Khá";
                }
                else if (sinhVien.GPA >= 5)
                {
                    sinhVien.Rank = "Trung Bình";
                }
                else
                {
                    sinhVien.Rank = "Yếu";
                }
                // Kiểm tra độ tuổi
                int calculatedAge = DateTime.Now.Year - sinhVien.StudentDateOfBirth.Year;
                if (calculatedAge != sinhVien.StudentAge)
                {
                    MessageBox.Show("Tuổi người dùng nhập không khớp với nhau!");
                    return; // Dừng xử lý
                }

                SinhVien sinhVien1 = truong.TimSinhVien(sinhVien.StudentID);
                if (sinhVien1 != null)
                {
                    MessageBox.Show("Đã tồn tại sinh viên này!");
                    return;
                }

               
                    truong.ThemSinhVien(sinhVien);
                    MessageBox.Show("Thêm sinh viên thành công!");
                    SaveDataToExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", truong.LayDanhSachSinhVien());
                    this.Close();
             

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }


        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtID.Text = "";
            cboAge.Text = "";
            cboMathScore.Text = "";
            cboPhysicSorce.Text = "";
            cboChemistryScore.Text = "";
            radMale.Checked = false;
            dtpDateOfBirth = null;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPhysicsScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogResult = DialogResult.OK;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) &&
                    !string.IsNullOrWhiteSpace(txtName.Text) &&
                    cboAge.SelectedItem != null &&
                    cboMathScore.SelectedItem != null &&
                    cboPhysicSorce.SelectedItem != null &&
                    cboChemistryScore.SelectedItem != null)
            {
                // Lấy thông tin sinh viên cần cập nhật từ các điều khiển trên form
                string updatedName = txtName.Text;
                string updatedID = txtID.Text;
                string updatedGender = radMale.Checked ? "Nam" : "Nữ";
                int updatedAge = int.Parse(cboAge.SelectedItem.ToString());
                double updatedMathScore = double.Parse(cboMathScore.SelectedItem.ToString());
                double updatedPhysicsScore = double.Parse(cboPhysicSorce.SelectedItem.ToString());
                double updatedChemistryScore = double.Parse(cboChemistryScore.SelectedItem.ToString());
                DateTime updatedDateOfBirth = dtpDateOfBirth.Value;
                double updateGPA = CalculateGPA(updatedMathScore, updatedPhysicsScore, updatedChemistryScore);
                string updatedRank = CalculateRank(CalculateGPA(updatedMathScore, updatedPhysicsScore, updatedChemistryScore));
                // Kiểm tra độ tuổi
                int calculatedAge = DateTime.Now.Year - updatedDateOfBirth.Year;
                if (calculatedAge != updatedAge)
                {
                    MessageBox.Show("Tuổi người dùng nhập không khớp với nhau!");
                    return; // Dừng xử lý
                }

                // Cập nhật thông tin sinh viên
                UpdatedSinhVien = new SinhVien
                {
                    StudentName = updatedName,
                    StudentID = updatedID,
                    StudentGender = updatedGender,
                    StudentAge = updatedAge,
                    StudentMathScore = updatedMathScore,
                    StudentPhysicsScore = updatedPhysicsScore,
                    StudentChemistryScore = updatedChemistryScore,
                    StudentDateOfBirth = updatedDateOfBirth,
                    GPA = updateGPA,
                    Rank = updatedRank
                };

                // Cập nhật thông tin vào danh sách sinh viên trong lớp Truong
                List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();
                int index = danhSachSinhVien.FindIndex(sv => sv.StudentID == updatedID);
                if (index >= 0)
                {
                    danhSachSinhVien[index] = UpdatedSinhVien;
                    MessageBox.Show("Cập nhật sinh viên thành công!");
                    // Lưu cập nhật vào file excel
                    SaveDataToExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", danhSachSinhVien);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần cập nhật trong danh sách!");
                }

                // Đóng form AddSV
                this.Close();
            }
        }
        private double CalculateGPA(double math,double physic,double chemistry)
        {
            var totalScore =math+physic+chemistry;
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
    }


}

