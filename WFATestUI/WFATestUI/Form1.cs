using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            //cd.ShowDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.panel1.BackColor = cd.Color;
            }
            //this.panel1.BackColor = Color.Crimson;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Cyan;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.label1.Text = this.trackBar1.Value.ToString();
            this.panel2.BackColor = Color.FromArgb(this.trackBar1.Value, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            this.panel3.Controls.Add(uc1);
            uc1.Show();
        }
    }
}
