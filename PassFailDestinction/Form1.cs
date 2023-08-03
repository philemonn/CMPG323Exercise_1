using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassFailDestinction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if(comboBoxgrade.SelectedIndex==0)
            {
                MessageBox.Show("You have failed");
            }

            if (comboBoxgrade.SelectedIndex == 1)
            {
                MessageBox.Show("You have failed");
            }
            if (comboBoxgrade.SelectedIndex == 2)
            {
                MessageBox.Show("You have failed");
            }
            if (comboBoxgrade.SelectedIndex == 3)
            {
                MessageBox.Show("You have failed");
            }
            if (comboBoxgrade.SelectedIndex == 4)
            {
                MessageBox.Show("You have failed");
            }
            if (comboBoxgrade.SelectedIndex == 5)
            {
                MessageBox.Show("You have passed");
            }
            if (comboBoxgrade.SelectedIndex == 6)
            {
                MessageBox.Show("You have passed");
            }
            if (comboBoxgrade.SelectedIndex == 7)
            {
                MessageBox.Show("You have passed");
            }
            if (comboBoxgrade.SelectedIndex == 8)
            {
                MessageBox.Show("You have passed, with distinction");
            }
            if (comboBoxgrade.SelectedIndex == 9)
            {
                MessageBox.Show("You have passed, with distinction");
            }
            if (comboBoxgrade.SelectedIndex == 10)
            {
                MessageBox.Show("You have passed, with distinction");
            }
        }
    }
}
