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
    public partial class Doctor_schedule : Form
    {
        public Doctor_schedule()
        {
            InitializeComponent();
        }

        

        void grideview()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("SELECT * FROM Doctor");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);


            dataGridView1.DataSource = dt;
        }

        private void Doctor_schedule_Load(object sender, EventArgs e)
        {
            grideview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("INSERT INTO Doctor(name,catagory,PhoneNumber) VALUES('{0}','{1}','{2}')", textBox2.Text, textBox3.Text,textBox4.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            {

                SqlConnection con1 = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
                con1.Open();
                string query1 = string.Format("SELECT * from Doctor  WHERE PhoneNumber='{0}'", textBox4.Text);
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();

                da1.Fill(dt1);

                string s = dt1.Rows[0][0].ToString();


                MessageBox.Show("Added Successfully...  \n DoctorID =" + s);
            }
            
            grideview();
            textBox3.Text = textBox2.Text = textBox4.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("DELETE FROM Doctor WHERE DoctorID={0}", int.Parse(textBox5.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            grideview();
            MessageBox.Show("Delete Successfully...");
           textBox1.Text= textBox5.Text = textBox3.Text = textBox2.Text = textBox4.Text = string.Empty;
        }

        private void Doctor_schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("UPDATE Doctor SET name='{0}', catagory='{1}',PhoneNumber='{2}' WHERE DoctorID={3}", textBox2.Text, textBox3.Text,textBox4.Text, int.Parse(textBox5.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully...");
            grideview();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("SELECT * FROM Doctor where DoctorID={0} ", int.Parse(textBox5.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);


            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("SELECT * FROM Doctor where name='{0}' ", textBox1.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);


            dataGridView1.DataSource = dt;
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Dashboard f1 = new Dashboard();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
