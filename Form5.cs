﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Anchaleeporn3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double number1, Rom, number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                if (number2 <= number1)
                {
                    double G95 = 25.75;
                    Rom = (number2 * G95);                    
                    label1.Text = Rom + "      บาท";
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");
                }
            }
            if (radioButton2.Checked)
            {
                double number1, Rom, number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                if (number2 <= number1)
                {
                    double DZ = 24.49;
                    Rom = (number2 * DZ);                    
                    label1.Text = Rom + "      บาท";
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");
                }
            }
        }
    }
}
