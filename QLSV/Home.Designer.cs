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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            SortByName = new Button();
            SortByID = new Button();
            SortByGPA = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            khácToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 183);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "SINH VIÊN ";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(51, 115);
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
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(338, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(247, 48);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật Sinh Viên Bởi ID";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(SortByName);
            groupBox2.Controls.Add(SortByID);
            groupBox2.Controls.Add(SortByGPA);
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(54, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(638, 185);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "SẮP XẾP";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(363, 115);
            button4.Name = "button4";
            button4.Size = new Size(247, 48);
            button4.TabIndex = 7;
            button4.Text = "Hiển thị danh sách";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SortByName
            // 
            SortByName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SortByName.Location = new Point(363, 41);
            SortByName.Name = "SortByName";
            SortByName.Size = new Size(247, 48);
            SortByName.TabIndex = 6;
            SortByName.Text = "Sắp xếp theo tên";
            SortByName.UseVisualStyleBackColor = true;
            SortByName.Click += SortByName_Click;
            // 
            // SortByID
            // 
            SortByID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SortByID.Location = new Point(51, 115);
            SortByID.Name = "SortByID";
            SortByID.Size = new Size(247, 48);
            SortByID.TabIndex = 5;
            SortByID.Text = "Sắp xếp theo ID";
            SortByID.UseVisualStyleBackColor = true;
            SortByID.Click += SortByID_Click;
            // 
            // SortByGPA
            // 
            SortByGPA.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SortByGPA.Location = new Point(51, 41);
            SortByGPA.Name = "SortByGPA";
            SortByGPA.Size = new Size(247, 48);
            SortByGPA.TabIndex = 4;
            SortByGPA.Text = "Sắp xếp theo GPA";
            SortByGPA.UseVisualStyleBackColor = true;
            SortByGPA.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(130, 65);
            label1.Name = "label1";
            label1.Size = new Size(496, 35);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(732, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, khácToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(162, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // khácToolStripMenuItem
            // 
            khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            khácToolStripMenuItem.Size = new Size(162, 26);
            khácToolStripMenuItem.Text = "Khác";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(732, 532);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Button SortByName;
        private Button SortByID;
        private Button SortByGPA;
        private Label label1;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem khácToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}