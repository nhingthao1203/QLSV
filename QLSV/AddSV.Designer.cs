namespace QLSV
{
    partial class AddSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSV));
            button1 = new Button();
            dtpDateOfBirth = new DateTimePicker();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radMale = new RadioButton();
            radioButton1 = new RadioButton();
            cboAge = new ComboBox();
            txtID = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            cboPhysicSorce = new ComboBox();
            label10 = new Label();
            cboChemistryScore = new ComboBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            cboMathScore = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(375, 561);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 57);
            button1.TabIndex = 31;
            button1.Text = "Thêm Sinh Viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(133, 188);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(285, 27);
            dtpDateOfBirth.TabIndex = 12;
            dtpDateOfBirth.ValueChanged += cboPhysicsScore_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radMale);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(cboAge);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(354, 228);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(459, 305);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 49);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 4;
            label4.Text = "Giới Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 115);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 7;
            label5.Text = "Tuổi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 188);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 8;
            label6.Text = "Ngày Sinh";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(241, 51);
            radMale.Margin = new Padding(3, 4, 3, 4);
            radMale.Name = "radMale";
            radMale.Size = new Size(64, 23);
            radMale.TabIndex = 5;
            radMale.TabStop = true;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(133, 49);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 23);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nữ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // cboAge
            // 
            cboAge.DisplayMember = "5";
            cboAge.FormattingEnabled = true;
            cboAge.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150" });
            cboAge.Location = new Point(133, 115);
            cboAge.Margin = new Padding(3, 4, 3, 4);
            cboAge.Name = "cboAge";
            cboAge.Size = new Size(172, 27);
            cboAge.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(318, 140);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(476, 27);
            txtID.TabIndex = 28;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtName
            // 
            txtName.AllowDrop = true;
            txtName.Location = new Point(318, 75);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(476, 27);
            txtName.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(14, 115);
            label11.Name = "label11";
            label11.Size = new Size(28, 19);
            label11.TabIndex = 18;
            label11.Text = "Lý";
            // 
            // cboPhysicSorce
            // 
            cboPhysicSorce.FormattingEnabled = true;
            cboPhysicSorce.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboPhysicSorce.Location = new Point(89, 115);
            cboPhysicSorce.Margin = new Padding(3, 4, 3, 4);
            cboPhysicSorce.Name = "cboPhysicSorce";
            cboPhysicSorce.Size = new Size(68, 28);
            cboPhysicSorce.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 184);
            label10.Name = "label10";
            label10.Size = new Size(39, 19);
            label10.TabIndex = 16;
            label10.Text = "Hóa";
            // 
            // cboChemistryScore
            // 
            cboChemistryScore.FormattingEnabled = true;
            cboChemistryScore.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboChemistryScore.Location = new Point(89, 184);
            cboChemistryScore.Margin = new Padding(3, 4, 3, 4);
            cboChemistryScore.Name = "cboChemistryScore";
            cboChemistryScore.Size = new Size(68, 28);
            cboChemistryScore.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 45);
            label9.Name = "label9";
            label9.Size = new Size(43, 19);
            label9.TabIndex = 14;
            label9.Text = "Toán";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cboPhysicSorce);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboChemistryScore);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cboMathScore);
            groupBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(102, 228);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(224, 305);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điểm";
            // 
            // cboMathScore
            // 
            cboMathScore.FormattingEnabled = true;
            cboMathScore.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboMathScore.Location = new Point(89, 45);
            cboMathScore.Margin = new Padding(3, 4, 3, 4);
            cboMathScore.Name = "cboMathScore";
            cboMathScore.Size = new Size(68, 28);
            cboMathScore.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(136, 140);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 25;
            label3.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 75);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 24;
            label2.Text = "Tên Sinh Viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 12);
            label1.Name = "label1";
            label1.Size = new Size(182, 45);
            label1.TabIndex = 23;
            label1.Text = "Sinh Viên";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(103, 561);
            button2.Name = "button2";
            button2.Size = new Size(170, 51);
            button2.TabIndex = 32;
            button2.Text = "Trở về";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(658, 568);
            button3.Name = "button3";
            button3.Size = new Size(170, 51);
            button3.TabIndex = 33;
            button3.Text = "Cập nhật";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AddSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 647);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddSV";
            Text = "AddSV";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpDateOfBirth;
        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radMale;
        private RadioButton radioButton1;
        private ComboBox cboAge;
        private TextBox txtID;
        private TextBox txtName;
        private Label label11;
        private ComboBox cboPhysicSorce;
        private Label label10;
        private ComboBox cboChemistryScore;
        private Label label9;
        private GroupBox groupBox2;
        private ComboBox cboMathScore;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}