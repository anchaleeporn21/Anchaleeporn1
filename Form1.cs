using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anchaleeporn3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form2 f2 = new Form2();                
                f2.Show();
            }
            if (radioButton2.Checked)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (radioButton3.Checked)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (radioButton4.Checked)
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
        }
    }
}
