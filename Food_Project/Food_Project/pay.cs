using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Food_Project
{
    public partial class pay : UserControl
    {
        public pay()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            File.Delete("CurrentUser.txt");
            Application.Exit();
            Form1 man = new Form1();
            man.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            string username = File.ReadAllText("CurrentUser.txt");
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            conn.Open();
            SqlCommand Remove = new SqlCommand("DELETE FROM cart WHERE uName='" + username + "'", conn);
            Remove.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Transaction Successful");
            //File.Delete("CurrentUser.txt");
            
        }

        private void pay_Load(object sender, EventArgs e)
        {

        }
    }
}
