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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
     
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
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
            Form5 fxd = new Form5();
            fxd.Show();
            this.Hide();
        }

        
    }
}
