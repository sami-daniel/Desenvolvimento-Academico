using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01pag08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Caucular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3,total;
            n1 = double.Parse(txt1.Text);
            n2 = double.Parse(txt2.Text);
            n3 = double.Parse(txt3.Text);
            total = (n1 + n2 + n3);
            lblsoma.Text += (n1+n3);
            lblmedia.Text += (n1 + n2 + n3) / 3;
            lblpor1.Text += ((100*n1)/total);
            lblpor2.Text += ((100*n2)/total);
            lblpor3.Text += ((100 * n3) / total);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            txt3.Text = null;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
