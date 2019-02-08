using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcApp : Form
    {
        double firstNumber;
        string Operation;
        public CalcApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void butTwo_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void butFour_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || (Operation == "C"))
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void butMul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double Result;
            secondNumber = Convert.ToDouble(textBox1.Text);

            switch (Operation)
            {
                case "+":
                    {
                        Result = firstNumber + secondNumber;
                        textBox1.Text = Convert.ToString(Result);
                        break;
                    }
                case "-":
                    {
                        Result = firstNumber - secondNumber;
                        textBox1.Text = Convert.ToString(Result);
                        break;
                    }
                case "*":
                    {
                        Result = firstNumber * secondNumber;
                        textBox1.Text = Convert.ToString(Result);
                        break;
                    }
                case "/":
                    {
                        Result = firstNumber / secondNumber;
                        textBox1.Text = Convert.ToString(Result);
                        break;
                    }
            }
            Operation = "C";
        }
    }
}
