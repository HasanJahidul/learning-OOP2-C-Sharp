using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAManagementPro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = @"select * from signin where id = '" + this.txtId.Text + "' and password = '" + this.txtPassword.Text + "';";

            DataAccess da = new DataAccess();//Connecting DB
            DataSet ds = da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login approved for " + ds.Tables[0].Rows[0][1].ToString());
            }
            else
            {
                MessageBox.Show("Login Invalid");
            }
        }
    }
}
