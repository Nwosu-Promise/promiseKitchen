using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Food_Project
{
    public partial class Cart : UserControl
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string username = File.ReadAllText("CurrentUser.txt");
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            conn.Open();
            using (SqlDataAdapter items = new SqlDataAdapter("SELECT item, qty, price FROM cart WHERE uName='" + username + "'", conn))
            {
                DataTable table = new DataTable();
                items.Fill(table);
                dataGridView1.DataSource = table;
            }
            conn.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string username = File.ReadAllText("CurrentUser.txt");
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            conn.Open();
            SqlCommand Remove = new SqlCommand("DELETE FROM cart WHERE uName='" + username + "'", conn);
            Remove.ExecuteNonQuery();
            conn.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            checkOut man = new checkOut();
            man.Show();
        }
    }
}
