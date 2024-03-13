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
        private double firstValue = 0.0;
        private double secondValue = 0.0;
        private double result = 0.0;
        private string operators = " ";
        private double Memory;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        // "1" Button
        private void button_1_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "1";
        }

        // "2" Button
        private void button_2_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "2";
        }

        // "3" Button
        private void button_3_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "3";
        }

        // "4" Button
        private void button_4_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "4";
        }

        // "5" Button
        private void button_5_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "5";
        }

        // "6" Button
        private void button_6_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "6";
        }

        // "7" Button
        private void button_7_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "7";
        }

        // "8" Button
        private void button_8_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "8";
        }

        // "9" Button
        private void button_9_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "9";
        }

        // "0" Button
        private void button_0_Click(object sender, EventArgs e)
        {
            TxtBox1.Text += "0";

        }

        // "-" Button
        private void button_Sub_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(TxtBox1.Text);
            TxtBox1.Clear();
            operators = "-";
        }

        // "*" Button
        private void button_Multi_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(TxtBox1.Text);
            TxtBox1.Clear();
            operators = "*";
        }

        // "/" Button
        private void button_Div_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(TxtBox1.Text);
            TxtBox1.Clear();
            operators = "/";
        }

        // "." Button
        private void button_dot_Click(object sender, EventArgs e)
        {
            string w = TxtBox1.Text.ToString();
            int len = w.Length;
            if (TxtBox1.Text[--len] != '.')
            {
                TxtBox1.Text += ".";
            }
        }

        // "+" Button
        private void button_plus_Click(object sender, EventArgs e)
        {
            firstValue = Double.Parse(TxtBox1.Text);
            TxtBox1.Clear();
            operators = "+";
        }

        // "±" Button
        private void button_PlusMinus_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = result * -1;
            TxtBox1.Text = result.ToString();
        }

        // "%" Button
        private void button_percentage_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = result / 100;
            TxtBox1.Text = result.ToString();
        }

        // "=" Button
        private void button_Equal_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    secondValue = Double.Parse(TxtBox1.Text);
                    result = firstValue - secondValue;
                    TxtBox1.Text = result.ToString();   
                    break;
                case "+":
                    secondValue = Double.Parse(TxtBox1.Text);
                    result = firstValue + secondValue;
                    TxtBox1.Text = result.ToString();
                    break;
                case "*":
                    secondValue = Double.Parse(TxtBox1.Text);
                    result = firstValue * secondValue;
                    TxtBox1.Text = result.ToString();
                    break;
                case "/":
                    secondValue = Double.Parse(TxtBox1.Text);
                    result = firstValue / secondValue;
                    TxtBox1.Text = result.ToString();
                    break;
            }
        }

        // "C" Button
        private void button_C_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = "0";
        }

        // "CE" Button
        private void button_CE_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = string.Empty;
        }

        // " ← " Button
        private void button_BackKey_Click(object sender, EventArgs e)
        {
            int index = TxtBox1.Text.Length;
            index--;
            TxtBox1.Text = TxtBox1.Text.Remove(index);
            if (TxtBox1.Text == "")
            {
                TxtBox1.Text = "0";
            }
        }

        // "√" Button
        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Sqrt(result);

            TxtBox1.Text = result.ToString();
        }

        // "1/x" Button
        private void button24_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = 1 / result;
            TxtBox1.Text = result.ToString();
        }

        // "M-" Button
        // Subtracts the displayed number in the TextBox1 from another number in memory 
        // but doesn´t display the subtraction of the numbers.
        private void button_Mminus_Click(object sender, EventArgs e)
        {
            Memory = Memory - Convert.ToDouble(TxtBox1.Text);
        }

        // "M+" Button
        // Add the displayed number in the TextBox1 to another number in memory 
        // but doesn´t display the sum of the numbers.
        private void button_MPlus_Click(object sender, EventArgs e)
        {
            Memory = Memory + Convert.ToDouble(TxtBox1.Text);
        }

        // "MS" Button
        // Stores in memory the displayed number in the TextBox1
        private void button_MS_Click(object sender, EventArgs e)
        {
            Memory = Convert.ToDouble(TxtBox1.Text);
        }

        // "MR" Button
        // Recalls the number stored in memory and The number remains in memory.
        private void button_MR_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = Memory.ToString();
        }

        // "MC" Button
        // clear the memory
        private void button_MC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        // "Log" Button
        private void button_Log_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Log10(result);
            TxtBox1.Text = result.ToString();
        }

        // "Sin" Button
        private void butto_Sin_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Sin(result);
            TxtBox1.Text = result.ToString();
        }

        // "Cos" Button
        private void button_Cos_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Cos(result);
            TxtBox1.Text = result.ToString();
        }

        // "Tan" Button
        private void button_Tan_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Tan(result);
            TxtBox1.Text = result.ToString();
        }

        // "Exp" Button
        private void button_Exp_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Exp(result);
            TxtBox1.Text = result.ToString();
        }

        // "x3" Button
        private void button_Xcube_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Pow(result, 3);
            TxtBox1.Text = result.ToString();
        }

        // "x2" Button
        private void button_Xsquare_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Pow(result, 2);
            TxtBox1.Text = result.ToString();
        }

        // "Pi" Button
        private void button_Pi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            TxtBox1.Text = result.ToString();
        }

        // "Tanh" Button
        private void button_Tanh_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Tanh(result);
            TxtBox1.Text = result.ToString();
        }

        // "Cosh" Button
        private void button_Cosh_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Cosh(result);
            TxtBox1.Text = result.ToString();
        }

        // "Sinh" Button
        private void button_Sinh_Click(object sender, EventArgs e)
        {
            result = double.Parse(TxtBox1.Text);
            result = Math.Sinh(result);
            TxtBox1.Text = result.ToString();
        }

        // "Off" Button
        private void button_Off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
