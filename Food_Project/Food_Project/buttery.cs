using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Food_Project
{
    public partial class buttery : Form
    {
        public buttery()
        {
            InitializeComponent();
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            control1.BringToFront();
           
        }

        private void buttery_Load(object sender, EventArgs e)
        {

        }

        private void control1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            control1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            burger1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            pizza1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            bread1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
            cake1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;
            about1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cart1.BringToFront();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;
            pay1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button13.Height;
            sidePanel.Top = button13.Top;
            pay1.BringToFront();
        }

        private void pay1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = File.ReadAllText("CurrentUser.txt");
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            conn.Open();
            SqlCommand Remove = new SqlCommand("DELETE FROM cart WHERE uName='" + username + "'", conn);
            Remove.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            File.Delete("CurrentUser.txt");
            Form1 dan = new Form1();
            dan.Show();
        }
    }
}
