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
    public partial class Form5 : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        public Form5()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        
        private void PopulateGridView(string sql = "select * from pinventory;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvpinventory.AutoGenerateColumns = false;
            this.dgvpinventory.DataSource = this.Ds.Tables[0];
        }

       
        private void txtSB_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from pinventory where name like '%" + this.txtSB.Text + "%';";
            this.PopulateGridView(this.Sql);
        }
        void ClearAll()
        {
            this.txtPid.Clear();
            this.txtPname.Clear();
            this.txtPprice.Clear();
            this.txtPstock.Clear();
            this.txtPbrand.Clear();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from pinventory where id='"+this.txtPid.Text+"';";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.Sql = @"update pinventory
                       set name='" + this.txtPname.Text + @"',
                       stock='" + this.txtPstock.Text + @"',
                       price='" + this.txtPprice.Text + @"',
                       brand='" + this.txtPbrand.Text + @"'
                       where id='" + this.txtPid.Text + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(this.dgvpinventory.CurrentRow.Cells[1].Value.ToString() + " has been updated");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
                this.PopulateGridView();
                this.ClearAll();

            }
            else
            {
                this.Sql = @"insert into pinventory
                       values ('" + this.txtPid.Text + "','" + this.txtPname.Text + "','" + this.txtPstock.Text + "','" + this.txtPprice.Text + "','" + this.txtPbrand.Text + "');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                if (count == 1)
                {
                    MessageBox.Show(this.txtPname.Text + " has been added into the inventory ");

                }
                else
                {
                    MessageBox.Show("Task Failed. Please Insert Proper values");


                }
                this.PopulateGridView();
                this.ClearAll();
            }
        }

        private void Form5_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 femp = new Form4();
            femp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 finvoice = new Form6();
            finvoice.Show();
            this.Hide();
        }

        private void dgvpinventory_DoubleClick(object sender, EventArgs e)
        {
            this.txtPid.Text = this.dgvpinventory.CurrentRow.Cells["id"].Value.ToString();
            this.txtPname.Text = this.dgvpinventory.CurrentRow.Cells["name"].Value.ToString();
            this.txtPbrand.Text = this.dgvpinventory.CurrentRow.Cells["brand"].Value.ToString();
            this.txtPprice.Text = this.dgvpinventory.CurrentRow.Cells["price"].Value.ToString();
            this.txtPstock.Text = this.dgvpinventory.CurrentRow.Cells["stock"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = this.dgvpinventory.CurrentRow.Cells[0].Value.ToString();

            this.Sql = @"delete from pinventory
                       where id ='" + id + "';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(this.dgvpinventory.CurrentRow.Cells[1].Value.ToString() + " has been Removed");
            }
            else
            {
                MessageBox.Show("Task Failed");
            }
            this.PopulateGridView();
            this.ClearAll();
        }
    }
}
