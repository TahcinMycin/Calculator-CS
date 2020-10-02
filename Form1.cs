using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set location
            this.Location = new Point(450, 200);
            txtDisplay.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //No command
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";            //Displays 0 in the textbox
        }

        int position = 0;   //position of input
        private void btnEql_Click(object sender, EventArgs e)
        {
            try
            {
                string sign;
                double inp1, inp2;  //Declaring input variables

                if (txtDisplay.Text.Contains("+"))
                {

                    position = txtDisplay.Text.IndexOf("+");


                }

                else if (txtDisplay.Text.Contains("-"))
                {

                    position = txtDisplay.Text.IndexOf("-");


                }

                else if (txtDisplay.Text.Contains("x"))
                {

                    position = txtDisplay.Text.IndexOf("x");


                }

                sign = txtDisplay.Text.Substring(position, 1);
                //Taking input
                inp1 = Convert.ToDouble(txtDisplay.Text.Substring(0, position));
                inp2 = Convert.ToDouble(txtDisplay.Text.Substring(position + 1, txtDisplay.TextLength - (position + 1)));

                if(sign == "+")
                {
                    txtDisplay.Text += "=" + (inp1 + inp2); //Addition operation

                }

                else if (sign == "-")
                {
                    txtDisplay.Text += "=" + (inp1 - inp2); //Subtraction operation

                }

                else if (sign == "x")
                {
                    txtDisplay.Text += "=" + (inp1 * inp2); //Multiplication operation

                }

                else if (sign == "/")
                {
                    txtDisplay.Text += "=" + ((float)inp1 / inp2); //Division operation

                }
                

            }

            catch(Exception)
            {
                txtDisplay.Text = "Error!!!";   //Displays Error
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text += "+";
            }

            else
            {
                txtDisplay.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }

            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }

            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }

            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }

            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }

            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }

            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }

            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }

            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void Off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                if (txtDisplay.TextLength > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
                }
            }
            else
            {
                txtDisplay.Text="0";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void about_Click(object sender, EventArgs e)
        {
            About2 var = new About2();
            help var2 = new help();
            var2.Hide();
            var.ShowDialog();
        }

        private void help_Click(object sender, EventArgs e)
        {
            help var = new help();

            var.ShowDialog();
        }
        string mp = "0";
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
            {
                mp = txtDisplay.Text.Substring(txtDisplay.Text.IndexOf("=")+1,position+1);
            }

            else if(txtDisplay.Text=="")
            {
                mp = "0";
            }

            else
            {
                mp = txtDisplay.Text;
            }

            txtDisplay.Text += "M+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("+") || txtDisplay.Text.Contains("-") || txtDisplay.Text.Contains("x") || txtDisplay.Text.Contains("/"))
            {
                txtDisplay.Text += mp;
            }

            else
            {
                txtDisplay.Text = mp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp = "0";
            txtDisplay.Text = "0";
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char var = e.KeyChar;

            if (var == 8 || var == 46)
            {
                e.Handled = false;
            }

            else if (var < '0' || var > '9')
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            details var = new details();
            var.ShowDialog();
        }
    }
}

/***********************************Happy Coding******************************************************/