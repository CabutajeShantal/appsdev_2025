using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MovieFormApp : Form
    {
        public MovieFormApp()
        {
            InitializeComponent();
            string[] movies = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom" };
            checkListBox.Items.AddRange(movies);
            checkListBox.CheckOnClick = true;

        }

        private void checkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movie in checkListBox.Items)
            {
                bool isSelected = checkListBox.GetItemChecked(checkListBox.Items.IndexOf(movie));
                if (isSelected && !listBox.Items.Contains(movie))
                {
                    listBox.Items.Add(movie);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
