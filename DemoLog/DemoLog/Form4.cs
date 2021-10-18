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
    public partial class Form4 : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public Form4()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.PopulateGridView();
            
        }
        private void PopulateGridView(string sql="select * from plogin;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvemployee.AutoGenerateColumns = false;
            this.dgvemployee.DataSource = this.Ds.Tables[0];
        }

        private void txtSB_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from plogin where name like '%" + this.txtSB.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from plogin where id='"+this.txtEmpId.Text+"';";
            this.Ds = this.Da.ExecuteQuery(this.Sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                this.Sql = @"update plogin
                       set name='" + this.txtEmpName.Text + @"',
                       password='" + this.txtEmpPass.Text + @"',
                       type='" + this.txtEmpType.Text + @"'
                       where id='" + this.txtEmpId.Text + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show(this.dgvemployee.CurrentRow.Cells[1].Value.ToString() + " has been updated");
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
                this.Sql = @"insert into plogin
                       values ('" + this.txtEmpId.Text + "','" + this.txtEmpName.Text + "','" + this.txtEmpPass.Text + "','" + this.txtEmpType.Text + "');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);


                if (count == 1)
                {
                    MessageBox.Show(this.txtEmpName.Text + " has been added as a/an " + this.txtEmpType.Text);

                }
                else
                {
                    MessageBox.Show("Task Failed. Please Insert Proper values");


                }
                this.PopulateGridView();
                this.ClearAll(); 
            }

             
              
            }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = this.dgvemployee.CurrentRow.Cells[0].Value.ToString();

            this.Sql = @"delete from plogin
                       where id ='"+id+"';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(this.dgvemployee.CurrentRow.Cells[1].Value.ToString() + " has been Removed");
            }
            else 
            {
                MessageBox.Show("Task Failed");
            }
            this.PopulateGridView();
            this.ClearAll();
        }

        private void dgvemployee_DoubleClick(object sender, EventArgs e)
        {
            //this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Text = this.dgvemployee.CurrentRow.Cells["id"].Value.ToString();
            this.txtEmpName.Text = this.dgvemployee.CurrentRow.Cells["name"].Value.ToString();
            this.txtEmpPass.Text = this.dgvemployee.CurrentRow.Cells["password"].Value.ToString();
            this.txtEmpType.Text = this.dgvemployee.CurrentRow.Cells["type"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        void ClearAll()
        {
            this.txtEmpId.Clear();
            this.txtEmpName.Clear();
            this.txtEmpPass.Clear();
            this.txtEmpType.Clear();

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Form5 finv = new Form5();
            finv.Show();
            this.Hide();
        }

        
            
        }

}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          