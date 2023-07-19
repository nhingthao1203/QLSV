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
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 7);
            label1.Name = "label1";
            label1.Size = new Size(391, 26);
            label1.TabIndex = 7;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 90);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(365, 23);
            txtPassword.TabIndex = 23;
            txtPassword.Text = "admin123";
            // 
            // txtUsername
            // 
            txtUsername.AllowDrop = true;
            txtUsername.Location = new Point(230, 53);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(365, 23);
            txtUsername.TabIndex = 22;
            txtUsername.Text = "admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 90);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(91, 53);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 20;
            label2.Text = "User";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(230, 128);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 23);
            textBox1.TabIndex = 25;
            textBox1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(91, 128);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 24;
            label4.Text = "Password Again";
            label4.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(230, 200);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(220, 33);
            button1.TabIndex = 26;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(263, 170);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 27;
            label5.Text = "Đăng nhập thành công!";
            label5.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 264);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}