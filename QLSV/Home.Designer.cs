namespace QLSV
{
    partial class Home
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
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(46, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 183);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "SINH VIÊN ";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(51, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(247, 48);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm Sinh Viên Theo Tên";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(338, 43);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(247, 48);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa Sinh Viên Bởi ID";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(338, 114);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(247, 48);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật Sinh Viên Bởi ID";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(51, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(247, 48);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Sinh Viên";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(46, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(723, 218);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "SẮP XẾP";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(363, 114);
            button4.Name = "button4";
            button4.Size = new Size(247, 48);
            button4.TabIndex = 7;
            button4.Text = "Hiển thị danh sách";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(363, 41);
            button3.Name = "button3";
            button3.Size = new Size(247, 48);
            button3.TabIndex = 6;
            button3.Text = "Thêm Sinh Viên";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(51, 114);
            button2.Name = "button2";
            button2.Size = new Size(247, 48);
            button2.TabIndex = 5;
            button2.Text = "Thêm Sinh Viên";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(51, 41);
            button1.Name = "button1";
            button1.Size = new Size(247, 48);
            button1.TabIndex = 4;
            button1.Text = "Thêm Sinh Viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 22);
            label1.Name = "label1";
            label1.Size = new Size(496, 35);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 532);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button4;
    }
}