using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tombolequal_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                hasiloutput.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                hasiloutput.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                hasiloutput.Text = result.ToString();
                input = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    hasiloutput.Text = result.ToString();
                    input = result.ToString();
                }
                else
                {
                    hasiloutput.Text = "DIV/Zero!";
                }

            }
        }
        private void tombolkoma_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += ".";
            this.hasiloutput.Text += input;
        }

        private void tombolC_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void tombolminus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void tombolplus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void tombolkali_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void tombolbagi_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void hasiloutput_Click(object sender, EventArgs e)
        {

        }

        private void angka0_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "0";
            this.hasiloutput.Text += input;
        }

        private void angka1_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "1";
            this.hasiloutput.Text += input;
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "2";
            this.hasiloutput.Text += input;
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "3";
            this.hasiloutput.Text += input;
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "4";
            this.hasiloutput.Text += input;
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "5";
            this.hasiloutput.Text += input;
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "6";
            this.hasiloutput.Text += input;
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "7";
            this.hasiloutput.Text += input;
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "8";
            this.hasiloutput.Text += input;
        }

        private void angka9_Click(object sender, EventArgs e)
        {
            this.hasiloutput.Text = "";
            input += "9";
            this.hasiloutput.Text += input;
        }
    }
}
