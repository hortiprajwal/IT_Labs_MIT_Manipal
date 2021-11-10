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
        string input=string.Empty; //to read the input when clicked
        string Op1=string.Empty; //First operand 
        string Op2=string.Empty; //Second operand
        char Operator; //Operator
        double res=0.0;//Finalresult
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            input+="3";
            this.textBox1.Text+=input;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            input+="4";
            this.textBox1.Text+=input;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            input += "5";
            this.textBox1.Text += input;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            input += "6";
            this.textBox1.Text += input;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            input += "7";
            this.textBox1.Text += input;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            input += "8";
            this.textBox1.Text += input;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            input += "9";
            this.textBox1.Text += input;
        }

        private void cmdplus_Click(object sender, EventArgs e)
        {
            Op1=input;
            Operator='+';
            input=string.Empty;
        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            input += "0";
            this.textBox1.Text += input;
        }

        private void cmddot_Click(object sender, EventArgs e)
        {
            input += ".";
            this.textBox1.Text += input;
        }

        private void cmdclr_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            input = string.Empty;
        }

        private void cmdminus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void cmdmul_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void cmddiv_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void cmdans_Click(object sender, EventArgs e)
        {
            Op2=input;
            double num1,num2;
            double.TryParse(Op1,out num1);
            double.TryParse(Op2,out num2);
            if(Operator=='+')
            {
                res=num1+num2;
                this.textBox1.Text=res.ToString();
            }
            else if(Operator=='-')
            {
                res=num1-num2;
                textBox1.Text=res.ToString();
            }
            else if(Operator=='*')
            {
                res=num1*num2;
                textBox1.Text=res.ToString();
            }
            else if(Operator=='/')
            {
                if(num2!=0)
                {
                    res=num1/num2;
                    textBox1.Text=res.ToString();
                }
                else
                {
                    textBox1.Text="DIV/Zero!";
                }
            }
            input=string.Empty;
        }

        private void cmdsqrt_Click(object sender, EventArgs e)
        {
            res = double.Parse(textBox1.Text);
            res = Math.Sqrt(res);

            textBox1.Text = res.ToString();
        }

        private void cmdsquare_Click(object sender, EventArgs e)
        {
            res = double.Parse(textBox1.Text);
            res = Math.Pow(res, 2);
            textBox1.Text = res.ToString();
        }

        private void cmdcube_Click(object sender, EventArgs e)
        {
            res = double.Parse(textBox1.Text);
            res = Math.Pow(res, 3);
            textBox1.Text = res.ToString();  
        }

        private void cmdbyx_Click(object sender, EventArgs e)
        {
            res = double.Parse(textBox1.Text);
            res = 1 / res;
            textBox1.Text = res.ToString();
        }
    }
}
