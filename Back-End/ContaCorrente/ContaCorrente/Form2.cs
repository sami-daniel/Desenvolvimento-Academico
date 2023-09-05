using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form2 : Form
    {
        double saldo = 0.00;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           textBox1.Text = saldo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*') 
            { 
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
