using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Food_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)   
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string fs = fn.Text;
            string lastname = ln.Text;
            string user = un.Text;
            string email = em.Text;
            string loc = add.Text;
            string key = pass.Text;

            if (fs == string.Empty || lastname == string.Empty || user == string.Empty || email == string.Empty || loc == string.Empty || key == string.Empty)
            {
                MessageBox.Show("Please enter value for the empty fields");
                return;

            }
            else if (key.Length < 5)
            {
                MessageBox.Show("Passwords must be more than 5 ");
            }
            else
            {
                try
                {
                    string conn = "Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True";
                    string query = "INSERT into Users(fName,lName,uName,email,address,password) VALUES('" + this.fn.Text + "','" + this.ln.Text + "', '" + this.un.Text + "','" + this.em.Text + "','" + this.add.Text + "','" + this.pass.Text + "');";
                    SqlConnection myconn = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand(query, myconn);
                    SqlDataReader reader;
                    myconn.Open();
                    reader = cmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        using (StreamWriter fileStr = File.CreateText("CurrentUser.txt"))
                        {
                            fileStr.Write(un.Text);
                        }
                        count += 1;
                        this.Hide();
                        shop bless = new shop();
                        bless.label1.Text = "Hi " + reader.GetString(2) + ", welcome to promise Kicthen";
                        bless.Show();
                    }
                    myconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Form1 man = new Form1();
                //man.Show();
                panel1.Visible = false;   
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-QUAFP07\\PROMISE;Initial Catalog=food;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE uName='" +this.sn.Text+"' And password= '" +this.ps.Text+"'",cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            int count = 0;
            while(dr.Read())
            {
                count += 1;
                this.Hide();
                buttery bless = new buttery();
                bless.label1.Text = "Hi " + dr.GetString(2) + ", welcome to Promise Kicthen";
                bless.Show();
            }
            if (count ==1)
            {
                using (StreamWriter fileStr = File.CreateText("CurrentUser.txt"))
                {
                    fileStr.Write(sn.Text);
                }


            }
            else if(count > 0)
            {
                MessageBox.Show("Duplicate username and password");
            }
            else
            {
                MessageBox.Show("Username or password not correct ");
            }
  
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_OnValueChanged(object sender, EventArgs e)
        {
            pass.isPassword = true;
        }
        private void pass_OnClick(object sender, EventArgs e)
        {
            
        }

        private void ps_OnValueChanged(object sender, EventArgs e)
        {
            ps.isPassword = true;
        }

        private void add_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
