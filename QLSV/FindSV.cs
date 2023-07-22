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
    public partial class FindSV : Form
    {
        private Truong truong;
        public FindSV(Truong truong)
        {
            InitializeComponent();
            this.truong = truong;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FindSV_Load(object sender, EventArgs e, SinhVien sinhVien)
        {

        }



        private void FindSV_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string StudentName = textBox1.Text;

            if (!string.IsNullOrEmpty(StudentName))
            {
                SinhVien sinhVien = truong.TimTenSinhVien(StudentName);
                if (sinhVien != null)
                {
                    MessageBox.Show($"Tên: {sinhVien.StudentName}\n" +
                        $"Mã sinh viên: {sinhVien.StudentID}\n" +
                        $"Tuổi: {sinhVien.StudentAge}\n" +
                        //Thêm các thông tin khác tương ứng
                        $"GPA: {sinhVien.GPA}\n" +
                        $"Xếp loại: {sinhVien.Rank}");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên có tên tương ứng!");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
