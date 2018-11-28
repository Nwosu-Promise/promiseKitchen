using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Project
{
    public partial class checkOut : Form
    {
        public checkOut()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string first = bunifuMaterialTextbox1.Text;
            string second = bunifuMaterialTextbox1.Text;
            if (first == string.Empty || second == string.Empty)
            {
                MessageBox.Show("Please input fields");
            }
            else
            {
                MessageBox.Show("Transaction Successful");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            buttery man = new buttery();
            man.Close();
        }
    }
}
