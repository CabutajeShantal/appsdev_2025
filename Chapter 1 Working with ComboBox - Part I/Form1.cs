using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] deliciousfoodcountry = { "Filipino", "Japanese", "Chinese", "Korean", "United States" };
            comboBoxFoods.Items.AddRange(deliciousfoodcountry);
            comboBoxFoods.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var foods in checkedListBoxFoods.Items)
            {
                bool isSelected = checkedListBoxFoods.GetItemChecked(checkedListBoxFoods.Items.IndexOf(foods));
                if (isSelected && !listBoxFoods.Items.Contains(foods))

                {
                    listBoxFoods.Items.Add(foods);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinolist = { "Bulalo", "Kare-Kare", "Bicol Express", "Pinakbet", };
            string[] japanlist = { "Tempura", "Ramen", "Sushi", "Tamagoyaki", "Tofu" };
            string[] chineselist = { "Dumplings", "stir-fries", "Noodles", };
            string[] koreanlist = { "Rice", "Noodles", "Samgyupsal", };
            string[] unitedlist = { "Fried chicken", "Buffalo wings", "Chicken fried steak", };

            checkedListBoxFoods.Items.Clear();

            if (comboBoxFoods.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBoxFoods.Items.AddRange(filipinolist);
            }
            else if (comboBoxFoods.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBoxFoods.Items.AddRange(japanlist);
            }
            else if (comboBoxFoods.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBoxFoods.Items.AddRange(chineselist);
            }
            else if (comboBoxFoods.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBoxFoods.Items.AddRange(koreanlist);
            }
            else if (comboBoxFoods.SelectedItem.ToString().Contains("United States"))
            {
                checkedListBoxFoods.Items.AddRange(unitedlist);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxFoods.Items.Count >= 1)
            {
                listBoxFoods.Items.Remove(listBoxFoods.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxFoods.Items.Clear();
        }
    }
}
