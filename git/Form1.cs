using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0, d = 0, f = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tBox1.Text);
            b = Convert.ToDouble(tBox2.Text);

            f = a * b;

            tBoxOtv.Text = f.ToString();

        }

        public Form1()
        {
            InitializeComponent();   
        }

        private void Calk_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tBox1.Text);
            b = Convert.ToDouble(tBox2.Text);

            c = a + b;
       
            tBoxOtv.Text = c.ToString();


        }
        private void button1_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(tBox1.Text);
            b = Convert.ToDouble(tBox2.Text);


            d = a - b;
            tBoxOtv.Text = d.ToString();

        }


    }
}
