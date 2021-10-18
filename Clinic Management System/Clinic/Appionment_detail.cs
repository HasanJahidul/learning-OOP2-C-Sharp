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
    public partial class Appionment_detail : Form
    {
        public Appionment_detail()
        {
            InitializeComponent();
            gride();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void gride()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("SELECT * from Appoinment ");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("SELECT * from Appoinment  WHERE AppointmentID='{0}'", int.Parse(textBox1.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void identify_doctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("Delete from Appoinment  WHERE AppointmentID='{0}'", int.Parse(textBox1.Text));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            gride();
            MessageBox.Show("Delete Successfully...");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Dashboard f1 = new Dashboard();
            f1.Show();
            this.Hide();
        
        }

        private void Appionment_detail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
