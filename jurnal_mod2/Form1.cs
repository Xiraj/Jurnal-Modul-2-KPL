﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal_mod2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float number, answer;
        int sum;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            sum = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            compute(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void compute(int sum)
        {
            switch (sum)
            {
                case 2:
                    answer = number + float.Parse(textBox1.Text);
                    textBox1.Text = answer.ToString();
                    break;
            }
        }
    }
}
