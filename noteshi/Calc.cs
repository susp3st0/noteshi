using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace noteshi
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void num_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            { richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1); }
            catch (Exception)
            { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = new DataTable().Compute(richTextBox1.Text, null).ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Error: " + ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }
    }
}