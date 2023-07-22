namespace QLSV
{
    partial class Login
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
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(496, 35);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(263, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(417, 27);
            txtPassword.TabIndex = 23;
            // 
            // txtUsername
            // 
            txtUsername.AllowDrop = true;
            txtUsername.Location = new Point(263, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(417, 27);
            txtUsername.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 120);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 71);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 20;
            label2.Text = "User";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(472, 213);
            button1.Name = "button1";
            button1.Size = new Size(251, 44);
            button1.TabIndex = 26;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(69, 213);
            button2.Name = "button2";
            button2.Size = new Size(251, 44);
            button2.TabIndex = 28;
            button2.Text = "Trở về";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 303);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}