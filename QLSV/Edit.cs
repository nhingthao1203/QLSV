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
            Close();
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
