using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03Pag0
{
    public partial class Form1 : Form
    {
        double preco,kg = 0;
        public Form1()
        {
            InitializeComponent();
            txtKg.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "Limpar")
            {
                txtKg.Text = "";
                kg = 0;
                preco = 0;
                label1.Text = String.Empty;
            }
            else { 
            kg = double.Parse(txtKg.Text);
            txtKg.Clear();
            preco = kg * 34;
            label1.Text ="O preço toal é de: " + preco.ToString();
            button1.Text = "Limpar";
            }
        }
    }
}
