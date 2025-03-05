using System.Net.NetworkInformation;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnamevalue = textBox1.Text;
            string mnamevalue = textBox2.Text;
            string lnamevalue = textBox3.Text;
            string snamevalue = textBox4.Text;
            DialogResult confirmationResult = Message.Show($"Are you sure want to submit!", "Confirmation!", MessageBoxButton.YesNo.MessageBoxIcon.Warning);
            if (confirmationResult == DialogResult.Yes)
            {
                string greetingMessage = ($"Hello There ! {fnamevalue} {mnamevalue} {lnamevalue} {snamevalue}!");
                MessageBox.Show(greetingMessage, "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {


                MessageBox.Show($"Submission canceled.", "Canceled", MessageBoxIcon.Warning);
            }

        }
    }
}
