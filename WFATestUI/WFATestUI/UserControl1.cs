using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATestUI
{
    public partial class UserControl1 : UserControl
    {
        private int i = 1;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string path = "E:\\Dropbox\\AIUB\\15. Summer 2019-20\\OOP-2\\Projects\\Image\\1.jpg";
            this.pictureBox1.Image = Image.FromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 20;
            if (this.progressBar1.Value >= 100)
            {
                this.timer1.Stop();
                this.progressBar1.Value = 0;
                i++;
            }

            if (i > 3)
            {
                i = 1;
            }

            string path = "E:\\Dropbox\\AIUB\\15. Summer 2019-20\\OOP-2\\Projects\\Image\\"+ i +".jpg";
            this.pictureBox1.Image = Image.FromFile(path);
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 4)
            {
                i = 1;
            }
            else if (i == 1)
            {
                i = 4;
            }

            string path = "E:\\Dropbox\\AIUB\\15. Summer 2019-20\\OOP-2\\Projects\\Image\\" + i + ".jpg";
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
