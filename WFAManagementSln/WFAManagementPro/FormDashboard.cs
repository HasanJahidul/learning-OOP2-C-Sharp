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
    public partial class FormDashboard : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }

        private string Sql { get; set; }

        public FormDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //string sql = "select * from movie;";
            this.PopulateGridView();
            this.GenerateMovieID();
            //MessageBox.Show(this.Ds.Tables[0].Rows[0][0].ToString());
            //MessageBox.Show(this.Ds.Tables[0].Rows[0]["title"].ToString());
        }

        private void PopulateGridView(string sql = "select * from movie;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvMovie.AutoGenerateColumns = false;
            this.dgvMovie.DataSource = this.Ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            //string sql = "select * from movie;";
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = "select * from movie where genre = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(this.Sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from movie where title like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from movie where id = '" + this.txtId.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update movie
                        set title = '" + this.txtTitle.Text + @"',
                        imdbrating = " + this.txtIMDB.Text + @",
                        income = " + this.txtIncome.Text + @",
                        releasedate = '" + this.dtpReleaseDate.Text + @"',
                        genre = '" + this.cmbGenre.Text + @"'
                        where id = '" + this.txtId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data updated");
                    }
                    else
                    {
                        MessageBox.Show("Data update failed");
                    }
                }
                else
                {
                    this.Sql = @"insert into movie
                    values ('" + this.txtId.Text + "', '" + this.txtTitle.Text + "'," + this.txtIMDB.Text + "," + this.txtIncome.Text + ", '" + this.dtpReleaseDate.Text + "', '" + this.cmbGenre.Text + "');";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data added properly");
                        //this.GenerateMovieID();
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed");
                    }
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the data\n\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvMovie.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvMovie.CurrentRow.Cells["title"].Value.ToString();
                //MessageBox.Show(name);

                this.Sql = @"delete from movie
                        where id = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void dgvMovie_DoubleClick(object sender, EventArgs e)
        {
            //this.txtId.ReadOnly = true;
            this.txtId.Text = this.dgvMovie.CurrentRow.Cells["id"].Value.ToString();
            this.txtTitle.Text = this.dgvMovie.CurrentRow.Cells["title"].Value.ToString();
            this.txtIMDB.Text = this.dgvMovie.CurrentRow.Cells["imdbrating"].Value.ToString();
            this.txtIncome.Text = this.dgvMovie.CurrentRow.Cells["income"].Value.ToString();
            this.dtpReleaseDate.Text = this.dgvMovie.CurrentRow.Cells["releasedate"].Value.ToString();
            this.cmbGenre.Text = this.dgvMovie.CurrentRow.Cells["genre"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Sql = @"update movie
                        set title = '"+this.txtTitle.Text+ @"',
                        imdbrating = "+this.txtIMDB.Text+ @",
                        income = "+this.txtIncome.Text+ @",
                        releasedate = '"+this.dtpReleaseDate.Text+@"',
                        genre = '"+this.cmbGenre.Text+@"'
                        where id = '" + this.txtId.Text + "';";
            int count = this.Da.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Data updated");
            }
            else
            {
                MessageBox.Show("Data update failed");
            }

            this.PopulateGridView();
            this.ClearAll();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            //this.txtId.ReadOnly = true;
            this.txtTitle.Clear();
            this.txtIMDB.Clear();
            this.txtIncome.Clear();
            this.dtpReleaseDate.Text = "";
            this.cmbGenre.SelectedIndex = -1;
        }

        private void GenerateMovieID()
        {
            
        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
