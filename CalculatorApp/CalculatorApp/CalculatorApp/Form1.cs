using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
      

        double number1, number2, result;
        string sign;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {

            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "1";
            }
            else
            {
                output.Text = output.Text + "1";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "0";
            }
            else
            {
                output.Text = output.Text + "0";
            }
        }

        private void button_Point_Click(object sender, EventArgs e)
        {

            if (!output.Text.Contains("."))
            {
                output.Text = output.Text + ".";
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "2";
            }
            else
            {
                output.Text = output.Text + "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "3";
            }
            else
            {
                output.Text = output.Text + "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "4";
            }
            else
            {
                output.Text = output.Text + "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "5";
            }
            else
            {
                output.Text = output.Text + "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "6";
            }
            else
            {
                output.Text = output.Text + "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {

            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "7";
            }
            else
            {
                output.Text = output.Text + "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {

            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "8";
            }
            else
            {
                output.Text = output.Text + "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (output.Text == "0" && output.Text != null)
            {
                output.Text = "9";
            }
            else
            {
                output.Text = output.Text + "9";
            }
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {

            number1 = Convert.ToDouble(output.Text);
            output.Text = "0";
            sign = "-";
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(output.Text);
            output.Text = "0";
            sign = "+";
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(output.Text);
            output.Text = "0";
            sign = "/";
        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(output.Text);
            output.Text = "0";
            sign = "*";
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {

            number2 = Convert.ToDouble(output.Text);
            if (sign == "+")
            {
                result = (number1 + number2);
                output.Text = Convert.ToString(result);

                number1 = result;
            }
            else if (sign == "-")
            {
                result = (number1 - number2);
                output.Text = Convert.ToString(result);

                number1 = result;
            }
            else if (sign == "*")
            {
                result = (number1 * number2);
                output.Text = Convert.ToString(result);

                number1 = result;
            }
            else if (sign == "/")
            {
                if (number2 == 0)
                {
                    output.Text = "Math Error";
                }
                else
                {
                    result = (number1 / number2);


                    output.Text = Convert.ToString(result);

                    number1 = result;
                }
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            this.output.Text = "0";
        }
    }
}
