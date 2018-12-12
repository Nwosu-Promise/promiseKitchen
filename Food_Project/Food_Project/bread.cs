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
    public partial class bread : UserControl
    {
        string[] items = { "Sliced Wheat bread",
                           "Sprinkled Wheat Bread",
                            "Whole White Bread"};
        int[] prices = { 350, 300, 250 };

        public bread()
        {
            InitializeComponent();
        }
        void SendToCart(int id)
        {
            string item = items[id];
            int price = prices[id];
            string username = File.ReadAllText("CurrentUser.txt");
            int quantity = 1;

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            cn.Open();

            // Update quantity and price of items if present in cart
            // Quantity
            SqlCommand UpdateQuantity = new SqlCommand("UPDATE cart SET qty = qty + 1 WHERE uName='" + username + "' AND item='" + item + "'", cn);
            int rowsAffected = (int)UpdateQuantity.ExecuteNonQuery();

            // Price
            SqlCommand UpdatePrice = new SqlCommand("UPDATE cart SET price = price + '" + price + "' WHERE uName='" + username + "' AND item='" + item + "'", cn);
            UpdatePrice.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                SqlCommand Add = new SqlCommand("INSERT INTO cart VALUES ('" + username + "', '" + item + "', '" + quantity + "', '" + price + "')", cn);
                Add.ExecuteNonQuery();
            }

            MessageBox.Show("Item Added to Cart");

            cn.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendToCart(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendToCart(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendToCart(2);
        }
    }
}
