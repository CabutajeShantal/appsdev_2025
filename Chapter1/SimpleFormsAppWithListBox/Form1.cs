namespace WinFormsApp3
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !listBox.Items.Contains(txtBox.Text))
            {
                listBox.Items.Add(txtBox.Text);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems != null)
            {
                listBox.Items.Remove(listBox.SelectedItems);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
