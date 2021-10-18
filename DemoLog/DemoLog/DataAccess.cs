using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoLog
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }
        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set{ this.sda = value; }
        }
        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection("Data Source=HIGHLANDER;Initial Catalog=cprojectdb;User ID=sa;Password=nashorstooth");
            this.Sqlcon.Open();
        }
        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }
        public DataSet ExecuteQuery(string sql)
        {
            try 
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(this.Ds);
                return this.Ds;
            }
            catch(Exception exc) 
            {
                return null;
            }
           
        }
        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
 