using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLog
{
    public partial class Form6 : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public Form6()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void Form6_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.PopulateGridView();
            
        }
        private void PopulateGridView(string sql="select * from invoice;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvinvoice.AutoGenerateColumns = false;
            this.dgvinvoice.DataSource = this.Ds.Tables[0];
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 finv = new Form5();
            finv.Show();
            this.Hide();
        }

        private void txtSB_TextChanged_1(object sender, EventArgs e)
        {
            this.Sql = "select * from invoice where item like '%" + this.txtSB.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        
    }
}
