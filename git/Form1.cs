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


    }
}
