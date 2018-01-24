using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sum = 0;
        double alt1 = 0;
        double alt2 = 0;
        string opr = "";

        Calc deal = new Calc();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 1;
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 2;
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 3;
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 4;
            textBox1.Text += 4;            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 5;
            textBox1.Text += 5;            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 6;
            textBox1.Text += 6;            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 7;
            textBox1.Text += 7;            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 8;
            textBox1.Text += 8;            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 9;
            textBox1.Text += 9;            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            alt1 = alt1 * 10 + 0;
            textBox1.Text += 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            alt2 = sum;
            textBox1.Text += "+";            
            sum = deal.calc(alt2, alt1, opr);
            opr = "+";
            alt1 = 0;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            alt2 = sum;
            textBox1.Text += "-";            
            sum = deal.calc(alt2, alt1, opr);
            opr = "-";
            alt1 = 0;

        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            alt2 = sum;
            textBox1.Text += "*";
            sum = deal.calc(alt2, alt1, opr);
            opr = "*";
            alt1 = 0;

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            alt2 = sum;
            textBox1.Text += "/";
            sum = deal.calc(alt2, alt1, opr);
            opr = "/";
            alt1 = 0;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            alt2 = sum;
            sum = deal.calc(alt2, alt1, opr);
            textBox2.Text = Convert.ToString(sum);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            sum = 0;
            alt1 = 0;
            alt2 = 0;
            opr = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
