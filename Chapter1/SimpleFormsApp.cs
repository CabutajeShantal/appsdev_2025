namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string lNameValue = textBox2.Text;
            MessageBox.Show($"Hello World! {fNameValue} {lNameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
