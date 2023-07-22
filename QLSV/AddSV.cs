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

                truong.ThemSinhVien(sinhVien);
                MessageBox.Show("Thêm sinh viên thành công!");
                ClearForm();

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
            this.Close();
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
                    StudentDateOfBirth = updatedDateOfBirth
                };

                // Đóng form AddSV
                this.Close();
            }
        }
    }


 }

