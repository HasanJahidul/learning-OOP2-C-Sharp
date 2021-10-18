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


using System.Data.Sql;

namespace Hospital
{
    public partial class Book_Appointmentcs : Form
    {
        public Book_Appointmentcs()
        {
            InitializeComponent();

            

            
            comvodss();
           

        }

        public string booktime
        {
            set;
            get;
        }


        void comvodoctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("select * from doctor where catagory='{0}'", comboBox1.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            SqlDataReader myread;

            myread = cmd.ExecuteReader();

            while (myread.Read())
            {
                string s = myread.GetString(1);


                comboBox2.Items.Add(s);

            }

            comboBox2.Items.Clear();

        }

        void comvodss()
        {

            string[] s = new string[] { "","Cardiologist", "Allergist", "Anesthesiologist", "Cardiovascular surgeon", "Addiction psychiatrist" };

           
                comboBox1.Items.AddRange(s);
            

            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }  

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Left == 800)
            {
                timer1.Start();
            }


            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();

           
           string query = string.Format(" select  * from  Appoinment where DateTime='{0}'", dateTimePicker1.Value.Date.ToString());

            SqlCommand cmd = new SqlCommand(query, con);

           SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            List<string> list = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i][5].ToString();

              //  Console.WriteLine(dt.Rows[i][5].ToString());

                list.Add(dt.Rows[i][5].ToString());
            }

            if (list.Contains("8:30-9:30 Am"))
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.White;
            }
            if (list.Contains("10:00-11:00 Am"))
            {
                button3.BackColor = Color.Red;
            }

            else
            {
                button3.BackColor = Color.White;
            }
            if (list.Contains("12:00-1:00 Pm"))
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.White;
            }

            if (list.Contains("1:00-2:00 Pm"))
            {
                button9.BackColor = Color.Red;
            }

            else
            {
                button9.BackColor = Color.White;
            }
            if (list.Contains("2:00-3:00 Pm"))
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.White;
            }

            if (list.Contains("5:00-6:00 Pm"))
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.White;
            }
            list.Clear();
             




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query = string.Format("select * from doctor where catagory='{0}'",comboBox1.Text);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            SqlDataReader myread;

            myread = cmd.ExecuteReader();

            while (myread.Read())
            {
                string s = myread.GetString(1);


                comboBox2.Items.Add(s);

            }

           
        }

        private void Book_Appointmentcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            
            string query = string.Format(" insert into Appoinment (Name,catagory,Doctor,DateTime,slot1,status1) values ('{0}','{1}','{2}','{3}','{4}','booked')", textBox2.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Value.Date.ToString(), booktime);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();


            {



                SqlConnection con1 = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
                    con1.Open();
                    string query1 = string.Format("SELECT * from Appoinment  WHERE name='{0}' and doctor='{1}' and DateTime='{2}'", textBox2.Text,comboBox2.Text,dateTimePicker1.Value.Date.ToString());
                    SqlCommand cmd1 = new SqlCommand(query1, con1);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();

                    da1.Fill(dt1);
                 
                    string s = dt1.Rows[0][0].ToString();


                    MessageBox.Show("booked Appoinment Successfully...  \n Appoinment ID =" + s);
                
            } 
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {

                if (button2.BackColor == Color.White)
                {
                    button2.BackColor = Color.Blue;
                    booktime = "8:30-9:30 Am";
                }
                else
                {
                    button2.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {
                if (button3.BackColor == Color.White)
                {
                    button3.BackColor = Color.Blue;
                    booktime = "10:00-11:00 Am";
                }
                else
                {
                    button3.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {
                if (button5.BackColor == Color.White)
                {
                    button5.BackColor = Color.Blue;
                    booktime = "12:00-1:00 Pm";
                }
                else
                {
                    button5.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {

                if (button9.BackColor == Color.White)
                {
                    button9.BackColor = Color.Blue;
                    booktime = "1:00-2:00 Pm";
                }
                else
                {
                    button9.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {
                if (button6.BackColor == Color.White)
                {
                    button6.BackColor = Color.Blue;
                    booktime = "2:00-3:00 Pm";
                }
                else
                {
                    button6.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)

        {
            if (button8.BackColor == Color.Red)
            {
                MessageBox.Show(" Slot Booked ");
            }

            else
            {
                if (button8.BackColor == Color.White)
                {
                    button8.BackColor = Color.Blue;
                    booktime = "5:00-6:00 Pm";
                }
                else
                {
                    button8.BackColor = Color.White;
                    booktime = "";
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AHAFID-16-32862;Initial Catalog=clinic;Integrated Security=True");
            con.Open();
            string query1 = string.Format(" select  * from  Appoinment where AppointmentID='{0}'", int.Parse(textBox1.Text));

            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();

            da1.Fill(dt1);

            

            List<string> fist = new List<string>();

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                fist.Add(dt1.Rows[i][4].ToString());
            }


            string dttt = fist.LastOrDefault();
            DateTime dt = Convert.ToDateTime(dttt);

            DateTime dy = dateTimePicker1.Value.Date;

            TimeSpan ts = dy - dt;

            int days = ts.Days;

            if (days <= 90)
            {
                label12.Text = "300";
                label10.Text = "yes";
            }
            else
            {
                label12.Text = "500";
                label10.Text = "NO";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Dashboard f1 = new Dashboard();
            f1.Show();
            this.Hide();
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Book_Appointmentcs_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
