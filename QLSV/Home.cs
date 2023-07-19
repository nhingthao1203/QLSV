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
            AddSV addSV = new AddSV(truong);
            addSV.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SinhVien> danhSachSinhVien = truong.LayDanhSachSinhVien();
            ShowSV showSV = new ShowSV();
            showSV.DataGridView1.DataSource = danhSachSinhVien;
            showSV.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindSV findSV = new FindSV();
            findSV.ShowDialog();
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
    }

}
