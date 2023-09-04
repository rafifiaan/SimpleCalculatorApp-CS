using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        decimal num1;
        decimal num2;
        int opr;
        Boolean opr_finished = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text == "0")
            {
                textDisplay.Text = "1";
            }
            else
            {
                textDisplay.Text += "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "2";
            }
            else
            {
                textDisplay.Text += "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "3";
            }
            else
            {
                textDisplay.Text += "3";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "4";
            }
            else
            {
                textDisplay.Text += "4";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "5";
            }
            else
            {
                textDisplay.Text += "5";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "6";
            }
            else
            {
                textDisplay.Text += "6";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "7";
            }
            else
            {
                textDisplay.Text += "7";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "8";
            }
            else
            {
                textDisplay.Text += "8";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0")
            {
                textDisplay.Text = "9";
            }
            else
            {
                textDisplay.Text += "9";
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if(textDisplay.Text != "0")
            {
                textDisplay.Text += "0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            textDisplay2.Text = " ";
        }

        private void buttonOfMultiple_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "x";
            textDisplay.Text = " ";
            opr = 1;
            opr_finished = true;
        }

        private void buttonOfDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "/";
            textDisplay.Text = " ";
            opr = 2;
            opr_finished = true;
        }

        private void buttonOfSubstract_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "-";
            textDisplay.Text = " ";
            opr = 3;
            opr_finished = true;
        }

        private void buttonOfAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(textDisplay.Text);
            textDisplay2.Text = "+";
            textDisplay.Text = " ";
            opr = 4;
            opr_finished = true;
        }

        private void buttonOfEquals_Click(object sender, EventArgs e)
        {
            if (opr_finished = true)
                num2 = Convert.ToDecimal(textDisplay.Text);
            {
                switch(opr)
                {
                    case 1:
                        textDisplay.Text = Convert.ToString(num1 * num2);
                        break;
                    case 2:
                        textDisplay.Text = Convert.ToString(num1 / num2);
                        break;
                    case 3:
                        textDisplay.Text = Convert.ToString(num1 - num2);
                        break;
                    case 4:
                        textDisplay.Text = Convert.ToString(num1 + num2);
                        break;
                }
                opr_finished = false;
            }
        }

        private void buttonOfComma_Click(object sender, EventArgs e)
        {
            textDisplay2.Text += ".";
        }
    }
}
