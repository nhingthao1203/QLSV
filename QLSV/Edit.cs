using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
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
    public partial class Edit : Form
    {
        private Truong truong;
        public Edit(Truong truong)
        {
            InitializeComponent();
            this.truong = truong;

        }
        private void FindSV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.Show();
    
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
            string studentID = textBox1.Text;

            if (!string.IsNullOrEmpty(studentID))
            {
                SinhVien sinhVien = truong.TimSinhVien(studentID);
                if (sinhVien != null)
                {
                    truong.XoaSinhVien(sinhVien);
                    List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();
                    DeleteDataInExcel(@"D:\LTGD\QLSV\QLSV\Student.xlsx", danhSachSinhVien);
                    MessageBox.Show("Xóa sinh viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có ID tương ứng!");
                }
            }
        }
    }
}
