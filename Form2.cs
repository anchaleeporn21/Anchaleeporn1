using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
 
            if (radioButton1.Checked)
            {
                double number1, Rom ,number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);//ให้number2มีค่าเท่ากับtextbox2
                if (number2<=number1)
                {
                    Double BZ95 = 32.86;
                    Rom = (number2 * BZ95);
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
                    double E20 = 23.24;
                    Rom = (number2 * E20);           
                    label1.Text = Rom + "      บาท";
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");
                }
            }
            if (radioButton3.Checked)
            {
                double number1, Rom, number2;//number1=ขนาดถังน้ำมัน number2=จำรวนน้ำมัน Rom=ราคารวม
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox2.Text);
                if (number2 <= number1)
                {
                    double G91 = 25.48;
                    Rom = (number2 * G91);
                    label1.Text = Rom + "      บาท";
                }
                else
                {
                    MessageBox.Show("ไม่สามารถเติมน้ำมันเกินถังได้");
                }
            }
            if (radioButton4.Checked)
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
        }       
    }
}
