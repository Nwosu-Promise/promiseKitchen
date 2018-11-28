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

namespace Food_Project
{
    public partial class shop : Form
    {

        public shop()
        {
            InitializeComponent();
            panel5.Height = button10.Height;
            panel5.Top = button10.Top;
            control1.BringToFront();
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shop_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 cs = new Form1();
            cs.ShowDialog();
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

        private void bro_Click(object sender, EventArgs e)
        {
            File.Delete("CurrentUser.txt");
            this.Hide();
            Form1 cs = new Form1();
            cs.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            cart1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Height = button10.Height;
            panel5.Top = button10.Top;
            control1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel5.Height = button12.Height;
            panel5.Top = button12.Top;
            burger1.BringToFront();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel5.Height = button15.Height;
            panel5.Top = button15.Top;
            pizza1.BringToFront();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel5.Height = button16.Height;
            panel5.Top = button16.Top;
            bread1.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel5.Height = button17.Height;
            panel5.Top = button17.Top;
            cake1.BringToFront();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}
