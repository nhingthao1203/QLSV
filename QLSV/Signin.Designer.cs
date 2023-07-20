namespace QLSV
{
    partial class Signin
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
            button2 = new Button();
            button1 = new Button();
            txtPassword1 = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(73, 332);
            button2.Name = "button2";
            button2.Size = new Size(251, 44);
            button2.TabIndex = 37;
            button2.Text = "Trở về";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(476, 332);
            button1.Name = "button1";
            button1.Size = new Size(251, 44);
            button1.TabIndex = 36;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click_1;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(261, 236);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(417, 27);
            txtPassword1.TabIndex = 35;
            txtPassword1.Text = "admin123";
            txtPassword1.UseWaitCursor = true;
            txtPassword1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(102, 236);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 34;
            label4.Text = "Password Again";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(261, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(417, 27);
            txtPassword.TabIndex = 33;
            txtPassword.Text = "admin123";
            txtPassword.UseWaitCursor = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.AllowDrop = true;
            txtUsername.Location = new Point(261, 136);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(417, 27);
            txtUsername.TabIndex = 32;
            txtUsername.Text = "admin";
            txtUsername.UseWaitCursor = true;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(102, 185);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 31;
            label3.Text = "Password";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(102, 136);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 30;
            label2.Text = "User";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 74);
            label1.Name = "label1";
            label1.Size = new Size(496, 35);
            label1.TabIndex = 29;
            label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword1);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signin";
            Text = "Signin";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtPassword1;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}