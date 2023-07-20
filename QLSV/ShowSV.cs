using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class ShowSV : Form
    {
        public DataGridView DataGridView1 { get { return dataGridView1; } }
        private Truong truong;
        public ShowSV(Truong truong, SinhVien sinhVien)
        {
            InitializeComponent();
            this.truong = truong;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ý tưởng khi double click vào sinh viên trên datagridview
            //    sẽ hiện ra form cập nhật thông tin sinh viên 
            //    cập nhật thì láy mã sv
            if(e.RowIndex >= 0)
            {
                var ID = DataGridView1.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                //truyền masv vào form bên kia
                SinhVien sinhVien = truong.TimSinhVien(ID);
                MessageBox.Show("Mã sinh viên nhận được: " + ID);
                AddSV addSV = new AddSV(truong, sinhVien);
                SinhVien updatedSinhVien = addSV.UpdatedSinhVien;
                Hide();
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
    }
}
