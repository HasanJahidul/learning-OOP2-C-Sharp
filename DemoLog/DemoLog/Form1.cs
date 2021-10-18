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

namespace DemoLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            string manager = "manager";
            string salesman = "salesman";
            // string query = "select * from plogin;";
            string sql = "select * from plogin where id='" + this.txtId.Text + "' and password='" + this.txtPassword.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1 && manager == ds.Tables[0].Rows[0][3].ToString())
            {
                MessageBox.Show("Login Approved for " + ds.Tables[0].Rows[0][1].ToString());
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
                
            }
            if (ds.Tables[0].Rows.Count == 1 && salesman == ds.Tables[0].Rows[0][3].ToString())
            {
                MessageBox.Show("Login Approved for " + ds.Tables[0].Rows[0][1].ToString());
                Form3 fs = new Form3();
                fs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect ID or Password!");
            }

        }

    } 

       
    
}
 