namespace QLSV
{
    partial class Info
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(84, 62);
            label2.Name = "label2";
            label2.Size = new Size(213, 53);
            label2.TabIndex = 1;
            label2.Text = "About Us";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(88, 132);
            label3.Name = "label3";
            label3.Size = new Size(99, 35);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(439, 9);
            label5.Name = "label5";
            label5.Size = new Size(454, 35);
            label5.TabIndex = 4;
            label5.Text = "The Ho Chi Minh Open University";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveCaptionText;
            linkLabel1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.LightGray;
            linkLabel1.Location = new Point(242, 132);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(358, 35);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ngthaonhi1203@gmail.com";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8726275_signin_icon1;
            pictureBox1.Location = new Point(22, 472);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.abue5;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(905, 518);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Info";
            Text = "Info";
            Load += Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}