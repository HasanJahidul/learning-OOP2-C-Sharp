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
    public partial class Form3 : Form
    {

        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }
        public Form3()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from pinventory;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvshop.AutoGenerateColumns = false;
            this.dgvshop.DataSource = this.Ds.Tables[0];
        }
        private void txtSB_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from pinventory where name like '%" + this.txtSB.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSB_TextChanged_1(object sender, EventArgs e)
        {
            this.Sql = "select * from pinventory where name like '%" + this.txtSB.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void dgvshop_DoubleClick(object sender, EventArgs e)
        {
            this.txtitem.Text = this.dgvshop.CurrentRow.Cells["name"].Value.ToString();
            this.txtpuc.Text = this.dgvshop.CurrentRow.Cells["price"].Value.ToString();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text.Length > 0)
            {
                this.txttotal.Text = (Convert.ToInt32(this.txtpuc.Text) * Convert.ToInt32(this.txtqty.Text)).ToString();
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = this.txtitem.Text;
            arr[1] = this.txtqty.Text;
            arr[2] = this.txtpuc.Text;
            arr[3] = this.txttotal.Text;

            ListViewItem lvi = new ListViewItem(arr);
            this.lstvcart.Items.Add(lvi);
            this.txtsubtotal.Text = (Convert.ToInt32(this.txtsubtotal.Text) + Convert.ToInt32(this.txttotal.Text)).ToString();

        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {
            if (txtqty.Text.Length > 0)
            {
                this.txtnet.Text = (Convert.ToInt32(this.txtsubtotal.Text) - ((Convert.ToInt32(this.txtdis.Text) / 100) * Convert.ToInt32(this.txtsubtotal.Text))).ToString();
            }
            
        }

        private void btnrmv_Click(object sender, EventArgs e)
        {
            if (this.lstvcart.SelectedItems.Count > 0)
            {
                for (int i = 0; i < this.lstvcart.SelectedItems.Count; i++)
                {
                    this.txtsubtotal.Text = (Convert.ToInt32(this.txtsubtotal.Text) - Convert.ToInt32(this.lstvcart.Items[i].SubItems[3].Text)).ToString();
                    this.lstvcart.Items[i].Remove();
                }

            }
        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtbalance.Text = (Convert.ToInt32(this.txtpaid.Text) - Convert.ToInt32(this.txtnet.Text)).ToString();
            }
            catch
            {
                Exception exc;
                MessageBox.Show("Balance Calculation Error!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        private void ClearAll()
        {
            int x = 0;
            int y = 5;

            this.lstvcart.Clear();
            this.txtitem.Clear();
            this.txttotal.Clear();
            this.txtpuc.Clear();
            this.txtqty.Clear();
            this.txtsubtotal.Text = x.ToString();
            this.txtdis.Text = y.ToString();
            this.txtnet.Clear();
            this.txtpaid.Clear();
            this.txtbalance.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.lstvcart.Items.Count > 0)
            {
                foreach (ListViewItem ListItem in this.lstvcart.Items)
                {
                    this.Sql = @"insert into invoice
                                 values('" + ListItem.SubItems[0].Text + "','" + ListItem.SubItems[1].Text + "','" + ListItem.SubItems[2].Text + "','" + ListItem.SubItems[3].Text + "');";
                    this.Da.ExecuteUpdateQuery(this.Sql);
                }
                this.ClearAll();
            }
        }



    }
}
