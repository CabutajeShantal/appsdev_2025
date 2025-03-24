using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cartooncombobox.Items.Add("Spongebob");
            cartooncombobox.Items.Add("Patrick");
            cartooncombobox.Items.Add("Mr. Krabs");
            cartooncombobox.Items.Add("Sandy");

            cartooncombobox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cartoon = cartooncombobox.SelectedItem.ToString();

            switch (cartoon)
            {
                case "Spongebob":
                    pictureBox1.Image = Image.FromFile("C:/Users/MM338/Downloads/233959.jpg");
                    break;

                case "Patrick":
                    pictureBox1.Image = Image.FromFile("C:/Users/MM338/Downloads/Patrick_Star.jpg");
                    break;

                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile("C:/Users/MM338/Downloads/Krabs.jpg");
                    break;
                case "Sandy":
                    pictureBox1.Image = Image.FromFile("C:/Users/MM338/Downloads/62a3405fae4caf8ae9bc1d55dfa9a2dd.jpg");
                    break;
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            cartooncombobox.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

