using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor_schedule dss = new Doctor_schedule();
            this.Hide();

            dss.Show();
        }

        private void find_doctor_Click(object sender, EventArgs e)
        {
            Appionment_detail id = new Appionment_detail();
            id.Show();
            this.Hide();
        }

        private void book_patient_Click(object sender, EventArgs e)
        {
            Book_Appointmentcs ba = new Book_Appointmentcs();
            this.Hide();
            ba.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

       
    }
}
