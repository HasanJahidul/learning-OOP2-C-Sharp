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
    public partial class frm_Calculator : Form
    {
        double number1,number2, result;
        string sign ;
        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {

            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "0";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "1";
            }
            else
            {
                txtbox_Result.Text =txtbox_Result.Text + "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "2";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "3";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "4";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "5";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "6";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "7";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "8";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtbox_Result.Text == "0" && txtbox_Result.Text != null)
            {
                txtbox_Result.Text = "9";
            }
            else
            {
                txtbox_Result.Text = txtbox_Result.Text + "9";
            }
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtbox_Result.Text);
            txtbox_Result.Text = "0";
            sign = "+";
            this.lbl_history.Text = Convert.ToString(number1)+sign;
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtbox_Result.Text);
            txtbox_Result.Text = "0";
            sign = "-";
            this.lbl_history.Text = Convert.ToString(number1) + sign;
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtbox_Result.Text);
            txtbox_Result.Text = "0";
            sign = "X";
            this.lbl_history.Text = Convert.ToString(number1) + sign;
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtbox_Result.Text);
            txtbox_Result.Text = "0";
            sign = "÷";
            this.lbl_history.Text = Convert.ToString(number1) + sign;
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            if (!txtbox_Result.Text.Contains("."))
            {
                txtbox_Result.Text = txtbox_Result.Text + ".";
            }
        }

        private void frm_Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            this.txtbox_Result.Text= "0";
            this.lbl_history.Text = " ";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            
                number2= Convert.ToDouble(txtbox_Result.Text);
            if (sign == "+")
            {
                result = (number1 + number2);
                txtbox_Result.Text = Convert.ToString(result);
                this.lbl_history.Text = Convert.ToString(number1)+sign+ Convert.ToString(number2)+"=";
                number1 = result;
            }
            else if (sign == "-")
            {
                result = (number1 - number2);
                txtbox_Result.Text = Convert.ToString(result);
                this.lbl_history.Text = Convert.ToString(number1) + sign + Convert.ToString(number2) + "=";
                number1 = result;
            }
            else if (sign == "X")
            {
                result = (number1 * number2);
                txtbox_Result.Text = Convert.ToString(result);
                this.lbl_history.Text = Convert.ToString(number1) + sign + Convert.ToString(number2) + "=";
                number1 = result;
            }
            else if (sign == "÷")
            {
                if (number2 == 0)
                {
                    txtbox_Result.Text = "Math Error";
                }
                else
                {
                    result = (number1 / number2);
                    txtbox_Result.Text = Convert.ToString(result);
                    this.lbl_history.Text = Convert.ToString(number1) + sign + Convert.ToString(number2) + "=";
                    number1 = result;
                }
            }
        }
    }
}
