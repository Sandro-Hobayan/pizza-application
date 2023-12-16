namespace pizza_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtuser.Text;
            pass = txtpass.Text;
            if (user == "sandro" && pass == "admin")
            {
                MessageBox.Show($"Welcome to Pizzarap {user}!", "Logged In");
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Invalid Username or Password \n Want to try again?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
