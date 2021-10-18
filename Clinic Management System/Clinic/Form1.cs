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

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con1.Open();
            string query1 = string.Format("SELECT * from Login  WHERE username='{0}' and password='{1}' ", textBox1.Text, textBox2.Text);
            SqlCommand cmd1 = new SqlCommand(query1, con1);
      
            cmd1.ExecuteNonQuery();


            
            SqlDataReader myread;

            myread = cmd1.ExecuteReader();

          

                if (myread.Read())
            {
                Dashboard ds = new Dashboard();

                this.Hide();

                ds.Show();
            }
            else
            {
                MessageBox.Show("invalid user of password "); 
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
