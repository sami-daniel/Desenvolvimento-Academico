using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void btncaucular_Click(object sender, EventArgs e)
        {
            int n1, n2,n3,total;
            double media;
            n1 = int.Parse(txt1.Text);
            n2 = int.Parse(txt2.Text);
            n3 = int.Parse(txt3.Text);

            total = n1 + n2 + n3;
            media = total / 3;
            txtsoma.Text = total.ToString();
            txtmedia.Text = total.ToString();
           
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
