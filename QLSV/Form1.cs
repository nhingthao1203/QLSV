namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.ShowDialog(); 
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signin = new Signin();
            signin.ShowDialog();
        }
    }
}